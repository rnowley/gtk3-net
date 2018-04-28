using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkInfoBar
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_info_bar_new();

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_info_bar_add_action_widget(IntPtr infoBar, IntPtr child, int responseId);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_info_bar_set_response_sensitive(IntPtr infoBar, int responseId, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_info_bar_add_button(IntPtr infoBar, string buttonText, int responseId);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_info_bar_set_default_response(IntPtr infoBar, int responseId, bool setting);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_info_bar_response(IntPtr infoBar, int responseId, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_info_bar_set_message_type(IntPtr infoBar, MessageType messageType);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern MessageType gtk_info_bar_get_message_type(IntPtr infoBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_info_bar_get_action_area(IntPtr infoBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_info_bar_get_content_area(IntPtr infoBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_info_bar_get_show_close_button(IntPtr infoBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_info_bar_set_show_close_button(IntPtr infoBar, bool setting);
    } 
}