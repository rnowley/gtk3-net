using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkFlowBox
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_flow_box_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_insert(IntPtr self, IntPtr widget, int position);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_flow_box_get_child_at_index(IntPtr self, int index);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_flow_box_get_child_at_pos(IntPtr self, int x, int y);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_hadjustment(IntPtr self, IntPtr adjustment);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_vadjustment(IntPtr self, IntPtr adjustment);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_homogeneous(IntPtr self, bool homogeneous);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_flow_box_get_homogeneous(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_row_spacing(IntPtr self, uint spacing);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_flow_box_get_row_spacing(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_column_spacing(IntPtr self, uint spacing);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_flow_box_get_column_spacing(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_min_children_per_line(IntPtr self, uint numberOfChildren);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_flow_box_get_min_children_per_line(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_max_children_per_line(IntPtr self, uint numberOfChildren);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_flow_box_get_max_children_per_line(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_activate_on_single_click(IntPtr self, bool single);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_flow_box_get_activate_on_single_click(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_flow_box_get_selected_children(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_select_child(IntPtr self, IntPtr child);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_unselect_child(IntPtr self, IntPtr child);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_select_all(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_unselect_all(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_flow_box_set_selection_mode(IntPtr self, SelectionMode mode);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern SelectionMode gtk_flow_box_get_selection_mode(IntPtr self);
    }
}