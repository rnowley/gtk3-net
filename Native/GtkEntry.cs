using System;
using System.Runtime.InteropServices;

namespace gtk3_net.Native
{
    public class GtkEntry
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_entry_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_entry_new_with_buffer(IntPtr buffer);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_entry_get_buffer(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_entry_set_buffer(IntPtr entry, IntPtr buffer);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_entry_get_text(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_entry_set_text(IntPtr entry, string text);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_entry_get_text_length (IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_entry_set_visibility(IntPtr entry, bool visible);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_entry_get_overwrite_mode(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_entry_set_overwrite_mode(IntPtr entry, bool overwrite);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_entry_set_invisible_char(IntPtr entry, uint ch);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_entry_unset_invisible_char(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_entry_get_placeholder_text(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_entry_set_placeholder_text(IntPtr entry, string text);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_entry_get_progress_fraction(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_entry_set_progress_fraction(IntPtr entry, double fraction);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_entry_progress_pulse(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_entry_get_progress_pulse_step(IntPtr entry);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_entry_set_progress_pulse_step(IntPtr entry, double fraction);
    }
}