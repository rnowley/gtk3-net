using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkStatusbar
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_statusbar_new();
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern uint gtk_statusbar_get_context_id(IntPtr statusbar, string contextDescription);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern uint gtk_statusbar_push(IntPtr statusbar, uint contextId, string text);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_statusbar_pop(IntPtr statusbar, uint contextId);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_statusbar_remove(IntPtr statusbar, uint contextId, uint messageId);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_statusbar_remove_all(IntPtr statusbar, uint contextId);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_statusbar_get_message_area(IntPtr statusbar);
    }
}