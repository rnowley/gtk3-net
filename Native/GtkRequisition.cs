using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    /// <summary>
    /// A GtkRequisition represents the desired size of a widget.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkRequisition
    {
        /// <summary>
        ///the widget's desired width.
        /// </summary>
        public int width;

        /// <summary>
        ///the widget's desired height.
        /// </summary>
        public int height;
    }
}
