using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkPaned
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_paned_new(Orientation orientation);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_paned_add1(IntPtr self, IntPtr child);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_paned_add2(IntPtr self, IntPtr child);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_paned_pack1(IntPtr self, IntPtr child, bool resize, bool shrink);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_paned_pack2(IntPtr self, IntPtr child, bool resize, bool shrink);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_paned_get_child1(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_paned_get_child2(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_paned_set_wide_handle(IntPtr self, bool wide);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_paned_get_wide_handle(IntPtr self);
    }
}