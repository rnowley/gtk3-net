using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkDialog
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_dialog_new();

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_dialog_new_with_buttons(string title, IntPtr parent,
            GtkDialogFlags flags, string firstButtonText, params string[] additionbuttonText);

        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_dialog_run(IntPtr dialog);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_dialog_response(IntPtr dialog, int responseId);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_dialog_add_button(IntPtr dialog, string buttonText,
            int responseId);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_dialog_add_action_widget(IntPtr dialog, IntPtr child,
            int responseId);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_dialog_set_default_response(IntPtr dialog,
            int responseId);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_dialog_set_response_sensitive(IntPtr dialog,
            int responseId, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_dialog_get_response_for_widget(IntPtr dialog,
            IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_dialog_get_widget_for_response(IntPtr dialog,
            int responseId);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_dialog_get_action_area(IntPtr dialog);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_dialog_get_content_area(IntPtr dialog);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_alternative_dialog_button_order(IntPtr dialog);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_dialog_set_alternative_button_order(IntPtr dialog, int firstResponseId, params int[] otherResponseIds);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_dialog_set_alternative_button_order_from_array(IntPtr dialog, int nParams, int[] newOrder);

    }
}
