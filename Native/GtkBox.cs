using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkBox
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_box_new(Orientation orientation, int spacing);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_box_pack_start(IntPtr box, IntPtr child, bool expand, bool fill, uint padding);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_box_pack_end(IntPtr box, IntPtr child, bool expand, bool fill, uint padding);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_box_get_homogeneous(IntPtr box);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_set_homogeneous(IntPtr box, bool homogeneous);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_box_get_spacing(IntPtr box);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_set_spacing(IntPtr box, int spacing);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_reorder_child(IntPtr box, IntPtr child, int position);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_query_child_packing(IntPtr box, IntPtr child, IntPtr expand,
            IntPtr fill, IntPtr padding, IntPtr packType);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_set_child_packing(IntPtr box, IntPtr child, bool expand,
            bool fill, uint padding, PackType packType);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern BaselinePosition gtk_box_get_baseline_position(IntPtr box);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_set_baseline_position(IntPtr box, BaselinePosition position);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_box_get_center_widget(IntPtr box);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_box_set_center_widget(IntPtr box, IntPtr widget);
    }
}