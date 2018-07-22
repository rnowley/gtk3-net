namespace Gdk
{
    /// <summary>
    /// Describes the kind of window.
    /// </summary>
    public enum WindowType
    {
        /// <summary>
        ///root window; this window has no parent, covers the entire screen, and is created by
        /// the window system
        /// </summary>
        Root,
        /// <summary>
        /// toplevel window (used to implement GtkWindow)
        /// </summary>
        TopLevel,
        /// <summary>
        /// child window (used to implement e.g. GtkEntry)
        /// </summary>
        Child,
        /// <summary>
        /// override redirect temporary window (used to implement GtkMenu)
        /// </summary>
        Temp,
        /// <summary>
        /// foreign window
        /// </summary>
        Foreign,
        /// <summary>
        /// offscreen window
        /// </summary>
        Offscreen,
        /// <summary>
        /// subsurface-based window; This window is visually tied to a toplevel, and is
        /// moved/stacked with it. Currently this window type is only implemented in Wayland.
        /// </summary>
        Subsurface
    }
}
