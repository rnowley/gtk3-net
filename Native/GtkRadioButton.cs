using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public class GtkRadioButton
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_radio_button_new(IntPtr group);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_radio_button_new_from_widget(IntPtr radioGroupMember);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_radio_button_new_with_label(
            IntPtr group, string label);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_radio_button_new_with_label_from_widget(
            IntPtr radioGroupMember, string label);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_radio_button_new_with_mnemonic(
            IntPtr group, string label);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_radio_button_new_with_mnemonic_from_widget(
            IntPtr radioGroupMember, string label);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_radio_button_set_group(IntPtr radioButton, IntPtr group);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_radio_button_get_group(IntPtr radioButton);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_radio_button_join_group(IntPtr radioButton, IntPtr groupSource);
    }
}