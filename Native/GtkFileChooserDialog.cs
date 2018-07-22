using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkFileChooserDialog
    {
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_dialog_new(string title, IntPtr parent,
                GtkFileChooserAction action, IntPtr nil);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_action(IntPtr chooser,
            GtkFileChooserAction action);

        [DllImport(GtkConstants.GtkLib)]
        public static extern GtkFileChooserAction gtk_file_chooser_get_action(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_local_only(IntPtr chooser, bool localOnly);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_local_only(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_select_multiple(IntPtr chooser,
            bool selectMultiple);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_select_multiple(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_show_hidden(IntPtr chooser, bool showHidden);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_show_hidden(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_do_overwrite_confirmation(IntPtr chooser,
            bool doOverwriteConfirmation);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_do_overwrite_confirmation(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_create_folders (IntPtr chooser,
            bool createFolders);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_create_folders(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_chooser_set_current_name(IntPtr chooser, string name);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_chooser_get_filename(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_set_filename(IntPtr chooser,string filename);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_select_filename(IntPtr chooser,string filename);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_chooser_unselect_filename(IntPtr chooser,string filename);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_select_all(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_chooser_unselect_all(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_get_filenames(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_set_current_folder(IntPtr chooser,
            string filename);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_chooser_get_current_folder(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_chooser_get_uri(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_set_uri(IntPtr chooser, string uri);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_select_uri(IntPtr chooser,string uri);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_chooser_unselect_uri(IntPtr chooser, string uri);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_get_uris(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_set_current_folder_uri(IntPtr chooser,
            string uri);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_chooser_get_current_folder_uri(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_preview_widget (IntPtr chooser,
            IntPtr previewWidget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_file_chooser_get_preview_widget (IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_preview_widget_active(IntPtr chooser,
            bool active);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_preview_widget_active(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_use_preview_label(IntPtr chooser,
            bool useLabel);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_chooser_get_use_preview_label(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_chooser_get_preview_filename(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_chooser_get_preview_uri(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_extra_widget(IntPtr chooser,
            IntPtr extraWidget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_file_chooser_get_extra_widget(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_add_filter(IntPtr chooser, IntPtr filter);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_remove_filter(IntPtr chooser, IntPtr filter);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_list_filters(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_chooser_set_filter(IntPtr chooser, IntPtr filter);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_file_chooser_get_filter(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_add_shortcut_folder(IntPtr chooser,
            string folder, IntPtr error);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_remove_shortcut_folder(IntPtr chooser,
            string folder, string error);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_list_shortcut_folders(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_add_shortcut_folder_uri(IntPtr chooser,
            string uri, IntPtr error);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_remove_shortcut_folder_uri(IntPtr chooser,
            string uri, IntPtr error);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_file_chooser_list_shortcut_folder_uris(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_file_chooser_get_current_folder_file(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_get_file(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_get_files(IntPtr chooser);


        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_file_chooser_get_preview_file(IntPtr chooser);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_select_file(IntPtr chooser, IntPtr file,
            IntPtr error);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_set_current_folder_file(IntPtr chooser,
            IntPtr file, IntPtr error);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_file_chooser_set_file(IntPtr chooser, IntPtr file,
            IntPtr error);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_chooser_unselect_file(IntPtr chooser, IntPtr file);
    }
}
