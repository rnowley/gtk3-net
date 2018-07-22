using System;

namespace Gdk
{
    /// <summary>
    /// Specifies the state of a toplevel window.
    /// </summary>
    public enum WindowState
    {
        /// <summary>
        /// the window is not shown.
        /// </summary>
        Withdrawn,
        /// <summary>
        /// the window is minimized.
        /// </summary>
        Iconified,
        /// <summary>
        /// the window is maximized.
        /// </summary>
        Maximised,
        /// <summary>
        /// the window is sticky.
        /// </summary>
        Sticky,
        /// <summary>
        /// the window is maximized without decorations.
        /// </summary>
        Fullscreen,
        /// <summary>
        /// the window is kept above other windows.
        /// </summary>
        Above,
        /// <summary>
        /// the window is kept below other windows.
        /// </summary>
        Below,
        /// <summary>
        /// the window is presented as focused (with active decorations).
        /// </summary>
        Focused,
        /// <summary>
        /// the window is in a tiled state, this is deprecated in favor of per-edge information.
        /// </summary>
        [Obsolete]
        Tiled,
        /// <summary>
        ///whether the top edge is tiled.
        /// </summary>
        TopTiled,
        /// <summary>
        /// whether the top edge is resizable.
        /// </summary>
        TopResizable,
        /// <summary>
        /// whether the right edge is tiled.
        /// </summary>
        RightTiled,
        /// <summary>
        /// whether the right edge is resizable.
        /// </summary>
        RightResizable,
        /// <summary>
        /// whether the bottom edge is tiled.
        /// </summary>
        BottomTiled,
        /// <summary>
        /// whether the bottom edge is resizable.
        /// </summary>
        BottomResizable,
        /// <summary>
        /// whether the left edge is tiled.
        /// </summary>
        LeftTiled,
        /// <summary>
        /// whether the left edge is resizable.
        /// </summary>
        LeftResizable
    }
}
