using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkButton
    {
       
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_button_new_with_label(string label);
    }
}