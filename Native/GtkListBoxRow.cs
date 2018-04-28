using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkListBoxRow
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_row_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_row_changed(IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_list_box_row_is_selected(IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_row_get_header(IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_row_set_header(IntPtr row, IntPtr header);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_list_box_row_get_index(IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_row_set_activatable(IntPtr row, bool activatable);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_list_box_row_get_activatable(IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_row_set_selectable(IntPtr row, bool selectable);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_list_box_row_get_selectable(IntPtr row);
    }
}