using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkSeparator
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_separator_new(Orientation orientation);
    }
}