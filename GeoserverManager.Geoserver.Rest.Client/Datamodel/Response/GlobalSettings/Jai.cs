namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public class Jai : IJai
    {
        public bool AllowInterpolation { get; set; }
        public bool Recycling { get; set; }
        public int TilePriority { get; set; }
        public int TileThreads { get; set; }
        public double MemoryCapacity { get; set; }
        public double MemoryThreshold { get; set; }
        public bool imageIOCache { get; set; }
        public bool PngAcceleration { get; set; }
        public bool JpegAcceleration { get; set; }
        public bool AllowNativeMosaic { get; set; }
        public bool AllowNativeWarp { get; set; }
    }
}