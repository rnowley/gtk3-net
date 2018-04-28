using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkLinkButton
    {
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_link_button_new(string uri);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_link_button_new_with_label(string uri, string label);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_link_button_get_uri(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_link_button_set_uri(IntPtr self, string uri);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_link_button_get_visited(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_link_button_set_visited(IntPtr self, bool visited);
    }
}