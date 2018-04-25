using System;
using System.Runtime.InteropServices;

namespace gtk3_net.Native
{
    public static class GtkEntryBuffer
    {
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_entry_buffer_new(string initialCharacters, int numberOfInitialCharacters);

        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_entry_buffer_get_bytes(IntPtr buffer);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_entry_buffer_get_length(IntPtr buffer);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_entry_buffer_get_text(IntPtr buffer);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_entry_buffer_set_text(IntPtr buffer, string text, int textLength);

        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_entry_buffer_get_max_length(IntPtr buffer);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_entry_buffer_set_max_length(IntPtr buffer, int maxLength);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern uint gtk_entry_buffer_insert_text (IntPtr buffer, uint position,
            string chars, int numberOfChars);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern uint gtk_entry_buffer_delete_text (IntPtr buffer, uint position,
            int numberOfChars);
    }
}