using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkSpinner
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_spinner_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_spinner_start(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_spinner_stop(IntPtr self);
    }
}