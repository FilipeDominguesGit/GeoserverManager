namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public interface IJai
    {
        bool AllowInterpolation { get; set; }
        bool Recycling { get; set; }
        int TilePriority { get; set; }
        int TileThreads { get; set; }
        double MemoryCapacity { get; set; }
        double MemoryThreshold { get; set; }
        bool imageIOCache { get; set; }
        bool PngAcceleration { get; set; }
        bool JpegAcceleration { get; set; }
        bool AllowNativeMosaic { get; set; }
        bool AllowNativeWarp { get; set; }
    }
}