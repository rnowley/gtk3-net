namespace Gdk
{
    /// <summary>
    /// Indicates which monitor (in a multi-head setup) a window should span over when in
    /// fullscreen mode.
    /// </summary>
    public enum FullScreenMode
    {
        /// <summary>
        /// Fullscreen on current monitor only.
        /// </summary>
        OnCurrentMonitor,
        /// <summary>
        /// Span across all monitors when fullscreen.
        /// </summary>
        OnAllMonitors
    }
}
