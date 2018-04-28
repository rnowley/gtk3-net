using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkSwitch
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_switch_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_switch_set_active(IntPtr self, bool isActive);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_switch_get_active(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_switch_set_state(IntPtr self, bool state);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_switch_get_state(IntPtr self);
    }
}