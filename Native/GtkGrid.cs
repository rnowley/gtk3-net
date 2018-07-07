using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkGrid
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_grid_new();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_attach(IntPtr grid, IntPtr child, int left, int top, int width, int height);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_insert_row(IntPtr grid, int position);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_insert_column(IntPtr grid, int position);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_remove_row(IntPtr grid, int position);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_remove_column(IntPtr grid, int position);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_set_row_homogeneous(IntPtr grid, bool homogeneous);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_grid_get_row_homogeneous(IntPtr grid);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_grid_set_row_spacing(IntPtr grid, uint spacing);

        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_grid_get_row_spacing(IntPtr grid);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_set_column_homogeneous(IntPtr grid, bool homogeneous);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_grid_get_column_homogeneous(IntPtr grid);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_set_column_spacing(IntPtr grid, uint spacing);

        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_grid_get_column_spacing(IntPtr grid);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_set_baseline_row(IntPtr grid, int row);

        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_grid_get_baseline_row(IntPtr grid);

        [DllImport(GtkConstants.GtkLib)] public static extern void gtk_grid_set_row_baseline_position(IntPtr grid, int row, GtkBaselinePosition pos);

        [DllImport(GtkConstants.GtkLib)]
        public static extern GtkBaselinePosition gtk_grid_get_row_baseline_position(IntPtr grid, int row);
    }
}
