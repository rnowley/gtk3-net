﻿using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkButtonBox
    {   
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_button_box_new(Orientation orientation);
    }
}