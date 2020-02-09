using WorldWind.Net;

namespace WorldWind
{
	/// <summary>
	/// Base class for geo-spatial download requests
	/// </summary>
	public abstract class GeoSpatialDownloadRequest : WebDownloadRequest
	{
		/// <summary>
		/// Initializes a new instance of the <see cref= "T:WorldWind.GeoSpatialDownloadRequest"/> class.
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="uri"></param>
		protected GeoSpatialDownloadRequest(object owner, string uri) : base( owner, uri )
		{
            this.download.DownloadType = DownloadType.Wms;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref= "T:WorldWind.GeoSpatialDownloadRequest"/> class.
		/// </summary>
		/// <param name="owner"></param>
		protected GeoSpatialDownloadRequest(object owner) : this( owner, null )
		{
		}

		/// <summary>
		/// Western bound of current request (decimal degrees)
		/// </summary>
		public abstract float West
		{
			get;
		}

		/// <summary>
		/// Eastern bound of current request (decimal degrees)
		/// </summary>
		public abstract float East
		{
			get;
		}

		/// <summary>
		/// Northern bound of current request (decimal degrees)
		/// </summary>
		public abstract float North
		{
			get;
		}

		/// <summary>
		/// Southern bound of current request (decimal degrees)
		/// </summary>
		public abstract float South
		{
			get;
		}

		/// <summary>
		/// Color used to identify this layer (download info)
		/// </summary>
		public abstract int Color
		{
			get;
		}
	}
}