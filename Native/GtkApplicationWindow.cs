using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkApplicationWindow
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_application_window_new(IntPtr application);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_application_window_set_show_menubar(IntPtr self, bool showMenuBar);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_application_window_get_show_menubar(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_application_window_get_id(IntPtr self);
    }
}
