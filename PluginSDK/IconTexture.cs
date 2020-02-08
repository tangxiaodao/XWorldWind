using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SharpDX.Direct3D9;

namespace WorldWind
{
	/// <summary>
	/// Contains one texture for our icon texture cache
	/// </summary>
	public class IconTexture : IDisposable
	{
		public Texture Texture;
		public int Width;
		public int Height;
        public int ReferenceCount = 0;

        /// <summary>
        /// Base Save path for any downloaded images.  Set to CachePath\IconTextures by default.
        /// TODO: Need to get the real CachePath rather than faking it.
        /// TODO: Should make this directory settable.
        /// TODO: Should have some mechanism to clear the cache out.
        /// </summary>
        public static string BaseSavePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Cache\IconTextures";

		/// <summary>
		/// Initializes a new instance of the <see cref= "T:WorldWind.IconTexture"/> class 
		/// from a texture file on disk.
		/// </summary>
		public IconTexture(Device device, string textureFileName)
		{
            this.UpdateTexture(device, textureFileName);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref= "T:WorldWind.IconTexture"/> class 
		/// from a bitmap.
		/// </summary>
		public IconTexture(Device device, Bitmap image)
		{
            this.LoadImage(device, image);
		}

		protected void LoadImage(Device device, Image image)
		{
            this.Width = (int)Math.Round(Math.Pow(2, (int)(Math.Ceiling(Math.Log(image.Width)/Math.Log(2)))));
			if(this.Width>device.Capabilities.MaxTextureWidth) this.Width = device.Capabilities.MaxTextureWidth;

            this.Height = (int)Math.Round(Math.Pow(2, (int)(Math.Ceiling(Math.Log(image.Height)/Math.Log(2)))));
			if(this.Height>device.Capabilities.MaxTextureHeight) this.Height = device.Capabilities.MaxTextureHeight;

			using(Bitmap textureSource = new Bitmap(this.Width, this.Height))
			using(Graphics g = Graphics.FromImage(textureSource))
			{
				g.DrawImage(image, 0,0, this.Width, this.Height);
				if(this.Texture!=null) this.Texture.Dispose();
                this.Texture = new Texture(device, textureSource, Usage.None, Pool.Managed);
			}
		}

        public void UpdateTexture(Device device, string textureFileName)
        {
            if ((textureFileName != null) && textureFileName.Length > 0)
            {
                if (textureFileName.ToLower().StartsWith("http://") && BaseSavePath != null)
                {
                    // download it
                    try
                    {
                        Uri uri = new Uri(textureFileName);

                        // Set the subdirectory path to the hostname and replace . with _
                        string savePath = uri.Host;
                        savePath = savePath.Replace('.', '_');

                        // build the save file name from the component pieces
                        savePath = BaseSavePath + @"\" + savePath + uri.AbsolutePath;
                        savePath = savePath.Replace('/', '\\');

                        // Offline check
                        if (!World.Settings.WorkOffline)
                        {
                            Net.WebDownload webDownload = new Net.WebDownload(textureFileName);
                            webDownload.DownloadType = Net.DownloadType.Unspecified;
                            webDownload.DownloadFile(savePath);
                        }

                        // reset the texture file name for later use.
                        textureFileName = savePath;
                    }
                    catch { }
                }
            }

            // Clear old texture - don't know if this is necessary so commented out for the moment
            //if (Texture != null)
            //{
            //    Texture.Dispose();
            //}

            if (ImageHelper.IsGdiSupportedImageFormat(textureFileName))
            {
                // Load without rescaling source bitmap
                using (Image image = ImageHelper.LoadImage(textureFileName)) this.LoadImage(device, image);
            }
            else
            {
                // Only DirectX can read this file, might get upscaled depending on input dimensions.
                this.Texture = ImageHelper.LoadIconTexture(textureFileName);
                // Read texture level 0 size
                using (Surface s = this.Texture.GetSurfaceLevel(0))
                {
                    SurfaceDescription desc = s.Description;
                    this.Width = desc.Width;
                    this.Height = desc.Height;
                }
            }
        }


		#region IDisposable Members

		public void Dispose()
		{
			if(this.Texture!=null)
			{
                this.Texture.Dispose();
                this.Texture = null;
			}
			
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
