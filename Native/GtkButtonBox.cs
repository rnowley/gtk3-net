using System;
using System.Runtime.InteropServices;

namespace gtk3_net.Native
{
    public static class GtkButtonBox
    {   
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_button_box_new(Orientation orientation);
    }
}