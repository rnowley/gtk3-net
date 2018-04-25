﻿using System;
using System.Runtime.InteropServices;

namespace gtk3_net.Native
{
    public static class GtkContainer
    {   
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_container_add(IntPtr container, IntPtr widget);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_container_set_border_width(IntPtr instance, uint borderWidth);
    }
}