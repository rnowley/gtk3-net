using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public class GtkCheckButton
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_check_button_new();

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_check_button_new_with_label(string label);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_check_button_new_with_mnemonic(string label);
    }

}
