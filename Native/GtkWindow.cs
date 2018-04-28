using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkWindow
    {   
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_new(WindowType type);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_modal(IntPtr window, int modal);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_window_get_resizable(IntPtr window);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_resizable(IntPtr window, int isResizable);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_title(IntPtr window, string title);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_default_size(IntPtr window, int width, int height);
    }
}