namespace Gtk3
{
    /// <summary>
    /// Window placement can be influenced using this enumeration. Note that using CenterAlways
    /// is almost always a bad idea. It won’t necessarily work well with all window managers or
    /// on all windowing systems.
    /// </summary>
    public enum WindowPosition
    {
        /// <summary>
        /// No influence is made on placement.
        /// </summary>
        None,
        /// <summary>
        /// Windows should be placed in the center of the screen.
        /// </summary>
        Center,
        /// <summary>
        /// Windows should be placed at the current mouse position.
        /// </summary>
        Mouse,
        /// <summary>
        /// Keep window centered as it changes size, etc.
        /// </summary>
        CenterAlways,
        /// <summary>
        /// Center the window on its transient parent (see Window.SetTransientFor()).
        /// </summary>
        CenterOnParent
    }
}
