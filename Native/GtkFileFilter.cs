using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public class GtkFileFilter
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_file_filter_new();

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_filter_set_name(IntPtr filter, string name);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_file_filter_get_name(IntPtr filter);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_filter_add_mime_type(IntPtr filter, string mimeType);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_file_filter_add_pattern(IntPtr filter, string pattern);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_file_filter_add_pixbuf_formats(IntPtr filter);

        [DllImport(GtkConstants.GtkLib)]
        public static extern GtkFileFilterFlags gtk_file_filter_get_needed(IntPtr filter);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_file_filter_filter(IntPtr filter, GtkFileFilterInfo filterInfo);
    }
}
