using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkScale
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_scale_new(Orientation orientation, IntPtr adjustment);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_scale_new_with_range(Orientation orientation, double min,
            double max, double step);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_scale_set_digits(IntPtr self, int digits);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_scale_set_draw_value(IntPtr self, bool drawValue);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_scale_set_has_origin(IntPtr self, bool hasOrigin);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_scale_set_value_pos(IntPtr self, PositionType pos);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_scale_get_digits(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_scale_get_draw_value(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_scale_get_has_origin(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern PositionType gtk_scale_get_value_pos(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_scale_get_layout_offsets(IntPtr self, IntPtr x, IntPtr y);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_scale_add_mark(IntPtr self, double value, PositionType position,
            string markup);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_scale_clear_marks(IntPtr self);
    }
}