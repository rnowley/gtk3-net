using System;
using System.Runtime.InteropServices;

namespace gtk3_net.Native
{
    public static class GtkAdjustment
    {   
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_adjustment_new(double value, double lower, double upper,
            double stepIncrement, double pageIncrement, double pageSize);

        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_adjustment_get_value(IntPtr adjustment);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_set_value(IntPtr adjustment, double value);


        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_adjustment_get_page_size(IntPtr adjustment);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_set_page_size(IntPtr adjustment, double pageSize);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_clamp_page(IntPtr adjustment, double lower, double upper);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_configure(IntPtr adjustment, double value, double lower,
            double upper, double stepIncrement, double pageIncrement, double pageSize);

        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_adjustment_get_page_increment(IntPtr adjustment);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_set_page_increment(IntPtr adjustment, double pageIncrement);

        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_adjustment_get_step_increment(IntPtr adjustment);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_set_step_increment(IntPtr adjustment, double stepIncrement);


        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_adjustment_get_lower(IntPtr adjustment);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_set_lower(IntPtr adjustment, double lower);

        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_adjustment_get_upper(IntPtr adjustment);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_adjustment_set_upper(IntPtr adjustment, double upper);
    }
}