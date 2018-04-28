using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkToggleButton
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_toggle_button_new();
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_toggle_button_new_with_label(string label);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_toggle_button_new_with_mnemonic(string label);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_toggle_button_set_mode(IntPtr self, bool drawIndicator);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_toggle_button_get_mode(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_toggle_button_set_active(IntPtr self, bool isActive);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_toggle_button_get_active(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_toggle_button_get_inconsistent(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_toggle_button_set_inconsistent(IntPtr self, bool setting);
    }
}