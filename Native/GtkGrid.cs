using System;
using System.Runtime.InteropServices;

namespace gtk3_net.Native
{
    public static class GtkGrid
    {   
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_grid_new();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_grid_attach(IntPtr grid, IntPtr child, int left, int top, int width, int height);
    }
}