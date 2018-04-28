using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkListBox
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_prepend(IntPtr self, IntPtr child);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_insert(IntPtr self, IntPtr child, int position);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_select_row(IntPtr self, IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_unselect_row(IntPtr self, IntPtr row);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_select_all(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_unselect_all(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_get_selected_row(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_get_selected_rows(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_set_selection_mode(IntPtr self, SelectionMode mode);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern SelectionMode gtk_list_box_get_selection_mode(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_set_activate_on_single_click(IntPtr self, bool single);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_list_box_get_activate_on_single_click(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_get_adjustment(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_set_adjustment(IntPtr self, IntPtr adjustment);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_set_placeholder(IntPtr self, IntPtr adjustment);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_get_row_at_index(IntPtr self, int index);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_list_box_get_row_at_y(IntPtr self, int y);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_invalidate_filter(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_list_box_invalidate_headers(IntPtr self);
        
    }
}