using WorldWind;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Security.Permissions;
using System.Security;
using Utility;

namespace WorldWind.PluginEngine
{
	/// <summary>
	/// Loads plug-in scripts, compiles and executes them
	/// </summary>
	public class PluginCompiler
	{
		MainApplication worldWind;
		const string LogCategory = "PLUG";
		Hashtable codeDomProviders = new Hashtable(); // File Extension -> Compiler table
		CompilerParameters cp = new CompilerParameters();
		ArrayList m_plugins = new ArrayList();
		StringCollection m_worldWindReferencesList = new StringCollection();
		string m_pluginRootDirectory;

		public string PluginRootDirectory
		{
			get
			{
				return this.m_pluginRootDirectory;
			}
			set
			{
                this.m_pluginRootDirectory = value;

				try
				{
					// Create plugin directory
					Directory.CreateDirectory(this.m_pluginRootDirectory);
				}
				catch
				{
				}
			}
		}

		/// <summary>
		/// The list of discovered plugins.
		/// </summary>
		public ArrayList Plugins
		{
			get
			{
				return this.m_plugins;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref= "T:WorldWind.PluginEngine.PluginCompiler"/> class.
		/// </summary>
		/// <param name="worldWind"></param>
		/// <param name="pluginDirectory"></param>
		public PluginCompiler( MainApplication worldWind, string pluginDirectory )
		{
			this.worldWind = worldWind;

			// Add the available codeDomProviders
			// TODO: Enumerate codeDomProviders (easier in .net 2.0)
            this.AddCodeProvider(new Microsoft.CSharp.CSharpCodeProvider() );
            this.AddCodeProvider(new VBCodeProvider() );
            this.AddCodeProvider(new Microsoft.JScript.JScriptCodeProvider() );

			// Setup compiler parameters
            this.cp.GenerateExecutable = false;
            this.cp.GenerateInMemory = true;
            this.cp.IncludeDebugInformation = false;

			// Load all assemblies WW has a reference to
			AssemblyName[] assemblyNames = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
			foreach(AssemblyName assemblyName in assemblyNames)
				Assembly.Load(assemblyName);

			// Reference all assemblies WW has loaded
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach(Assembly assembly in assemblies)
			{
				try
				{
					if(assembly.Location.Length > 0) this.m_worldWindReferencesList.Add(assembly.Location);
				}
				catch(NotSupportedException) 
				{
					// In-memory compiled assembly etc.
				}
			}

            this.PluginRootDirectory = pluginDirectory;
		}

		/// <summary>
		/// Adds a compiler to the list of available codeDomProviders
		/// </summary>
		public void AddCodeProvider( CodeDomProvider cdp )
		{
			// Add leading dot since that's what Path.GetExtension uses
            this.codeDomProviders.Add("."+cdp.FileExtension, cdp);
		}

		/// <summary>
		/// Scan for plugins inside an assembly.
		/// </summary>
		public void FindPlugins( Assembly assembly )
		{
			foreach( Type t in assembly.GetTypes() )
			{
				if(!t.IsClass)
					continue;

				if(!t.IsPublic)
					continue;

				if(t.BaseType!=typeof(Plugin))
					continue;

				try
				{
					PluginInfo pi = new PluginInfo(this.worldWind);
					pi.Plugin = (Plugin) assembly.CreateInstance( t.ToString() );
					pi.Name = t.Name;
					pi.Description = "World Wind internally loaded plugin.";
                    this.m_plugins.Add(pi);
				}
				catch
				{
					// Ignore exceptions during entry point search.
				}
			}
		}

		/// <summary>
		/// Build/update the list of available plugins.
		/// </summary>
		public void FindPlugins()
		{
			if(!Directory.Exists(this.m_pluginRootDirectory))
				return;

			// Plugins should reside in subdirectories of path
			foreach(string directory in Directory.GetDirectories(this.m_pluginRootDirectory)) this.AddPlugin(directory);

			// Also scan Plugins base directory
            this.AddPlugin(this.m_pluginRootDirectory);
		}

		/// <summary>
		/// Adds plugin from one of the plugins
		/// </summary>
		void AddPlugin(string path)
		{
			foreach (string filename in Directory.GetFiles(path))
			{
				bool isAlreadyInList = false;
				foreach(PluginInfo info in this.m_plugins)
				{
					if(info.FullPath == filename)
					{
						isAlreadyInList = true;
						break;
					}
				}

				if(isAlreadyInList)
					continue;

				string extension = Path.GetExtension(filename).ToLower();
				if(this.HasCompiler(extension) || IsPreCompiled(extension))
				{
					PluginInfo plugin = new PluginInfo(this.worldWind);
					plugin.FullPath = filename;
                    this.m_plugins.Add(plugin);
				}
			}
		}

		/// <summary>
		/// Loads the plugins that are set for load on world wind startup.
		/// </summary>
		public void LoadStartupPlugins()
		{
			foreach(PluginInfo pi in this.m_plugins)
			{
				if(pi.IsLoadedAtStartup)
				{
					try
					{
						// Compile
                        Log.Write(Log.Levels.Debug, LogCategory, "loading "+pi.Name+" ...");
                        this.worldWind.SetStatusText("Initializing plugin " + pi.Name);
                        this.Load(pi);
					}
					catch(Exception caught)
					{
						// Plugin failed to load
						string message = "Plugin " + pi.Name + " failed: " + caught.Message;
						Log.Write(Log.Levels.Error, LogCategory, message);
						Log.Write(caught);

						// Disable automatic load of this plugin on startup
						pi.IsLoadedAtStartup = false;

                        this.worldWind.SetStatusText(message);
					}
				}
			}
		}

		/// <summary>
		/// Determine if a file extension is that of a compilable plugin.
		/// </summary>
        /// <param name="fileExtension">File extension to check.</param>
		public bool HasCompiler(string fileExtension)
		{
			CodeDomProvider cdp = (CodeDomProvider) this.codeDomProviders[fileExtension];
			return cdp != null;
		}

		/// <summary>
		/// Determine if a file extension is that of a pre-compiled plugin.
		/// </summary>
		static public bool IsPreCompiled(string fileExtension)
		{
			return fileExtension==".dll";
		}

		/// <summary>
		/// Load a plugin
		/// </summary>
		public void Load(PluginInfo pi)
		{
			if(pi.Plugin == null)
			{
				// Try to find a suitable compiler
				string extension = Path.GetExtension(pi.FullPath).ToLower();
				Assembly asm = null;
				if(extension==".dll")
				{
					// Load pre-compiled assembly
					asm = Assembly.LoadFile(pi.FullPath);
				}
				else
				{
					CodeDomProvider cdp = (CodeDomProvider) this.codeDomProviders[extension];
					if(cdp==null)
						return;
					asm = this.Compile(pi, cdp);
				}

				pi.Plugin = GetPluginInterface(asm);
			}

			string pluginPath = this.worldWind.DirectoryPath;
			if( pi.FullPath != null && pi.FullPath.Length > 0)
				pluginPath = Path.GetDirectoryName(pi.FullPath);

			pi.Plugin.PluginLoad(this.worldWind, pluginPath);
		}

		/// <summary>
		/// Unload a plugin if it's loaded.
		/// </summary>
		public void Unload(PluginInfo pi)
		{
			if(!pi.IsCurrentlyLoaded)
				return;
			pi.Plugin.PluginUnload();
		}

		/// <summary>
		/// Uninstall/delete a plugin.
		/// </summary>
		/// <param name="pi"></param>
		public void Uninstall(PluginInfo pi)
		{
			// Unload the plugin
            this.Unload(pi);

			File.Delete( pi.FullPath );

            this.m_plugins.Remove( pi );
		}

		/// <summary>
		/// Shut down plugins
		/// </summary>
		public void Dispose()
		{
			foreach(PluginInfo pi in this.m_plugins)
			{
				try
				{
                    this.Unload(pi);
				}
				catch(Exception caught)
				{
					Log.Write(Log.Levels.Error, "PLUG", "Plugin unload failed: " + caught.Message);
				}
			}
		}

		/// <summary>
		/// Compiles a file to an assembly using specified compiler.
		/// </summary>
		Assembly Compile( PluginInfo pi, CodeDomProvider cdp )
		{
			// Compile
			//ICodeCompiler compiler = cdp.CreateCompiler();

			if(cdp is Microsoft.JScript.JScriptCodeProvider)
				// JSCript doesn't support unsafe code
                this.cp.CompilerOptions = "";
			else
                this.cp.CompilerOptions = "/unsafe";

			// Add references
            this.cp.ReferencedAssemblies.Clear();
			foreach( string reference in this.m_worldWindReferencesList) this.cp.ReferencedAssemblies.Add(reference);

			// Add reference to core functions for VB.Net users 
			if(cdp is VBCodeProvider) this.cp.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");

			// Add references specified in the plugin
			foreach( string reference in pi.References.Split(',')) this.AddCompilerReference( pi.FullPath, reference.Trim() );

			CompilerResults cr = cdp.CompileAssemblyFromFile(this.cp, pi.FullPath );
			if(cr.Errors.HasErrors || cr.Errors.HasWarnings)
			{
				// Handle compiler errors
				StringBuilder error = new StringBuilder();
				foreach (CompilerError err in cr.Errors)
				{
					string type = (err.IsWarning ? "Warning" : "Error");
					if(error.Length>0)
						error.Append(Environment.NewLine);
					error.AppendFormat("{0} {1}: Line {2} Column {3}: {4}", type, err.ErrorNumber, err.Line, err.Column, err.ErrorText );
				}
                Log.Write(Log.Levels.Error, LogCategory, error.ToString());
                if(cr.Errors.HasErrors)
				    throw new Exception( error.ToString() );
			}

			// Success, return our new assembly
			return cr.CompiledAssembly;
		}

		/// <summary>
		/// Adds reference to a local assembly or an assembly in the global cache.
		/// </summary>
		/// <param name="pluginDirectory">Local directory to search.</param>
		/// <param name="assemblyName">Partial name of the assembly.</param>
		void AddCompilerReference( string pluginDirectory, string assemblyName )
		{
			try
			{
				if(assemblyName.Length<=0)
					return;

				Assembly referencedAssembly = Assembly.Load(assemblyName);
				if(referencedAssembly == null)
				{
					// Try plug-in directory
					string pluginReferencePath = Path.Combine( Path.GetDirectoryName(pluginDirectory),
						assemblyName );
					referencedAssembly = Assembly.LoadFile(pluginReferencePath);

					if(referencedAssembly == null)
						throw new ApplicationException("Search for required library '" + assemblyName + "' failed.");
				}

                this.cp.ReferencedAssemblies.Add( referencedAssembly.Location );
			}
			catch(Exception caught)
			{
				throw new ApplicationException("Failed to load '"+assemblyName+"': "+caught.Message);
			}
		}

		/// <summary>
		/// Looks for class derived from Plugin and returns an instance of this class.
		/// </summary>
		static Plugin GetPluginInterface(Assembly asm)
		{
			foreach( Type t in asm.GetTypes() )
			{
				if(!t.IsClass)
					continue;

				if(!t.IsPublic)
					continue;

				if(t.BaseType!=typeof(Plugin))
					continue;

				try
				{
					Plugin pluginInstance = (Plugin) asm.CreateInstance( t.ToString() );	
					return pluginInstance;
				}
				catch(MissingMethodException)
				{
					throw;
				}
				catch
				{
					// Ignore exceptions during entry point search.
				}
			}

			throw new ArgumentException( "Plugin does not derive from base class Plugin." );
		}
	}
}