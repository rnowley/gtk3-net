using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkFrame
    {
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_frame_new(string label);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_frame_set_label(IntPtr self, string label);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_frame_set_label_widget(IntPtr self, IntPtr labelWidget);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_frame_set_label_align(IntPtr self, float xalign, float yalign);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_frame_set_shadow_type(IntPtr self, ShadowType type);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_frame_get_label(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_frame_get_label_align(IntPtr self, IntPtr xalign, IntPtr yalign);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_frame_get_label_widget(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern ShadowType gtk_frame_get_shadow_type(IntPtr self);
    }
}