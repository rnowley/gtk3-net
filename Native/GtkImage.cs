using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkImage
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_get_pixbuf(IntPtr image);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_get_animation(IntPtr image);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_get_icon_name(IntPtr image, out string iconName, out GtkIconSize size);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_get_gicon(IntPtr image, out IntPtr gicon, out GtkIconSize size);

        [DllImport(GtkConstants.GtkLib)]
        public static extern GtkImageType gtk_image_get_storage_type(IntPtr image);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_image_new_from_file(string filename);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_new_from_pixbuf(IntPtr pixbuf);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_new_from_animation(IntPtr animation);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_image_new_from_icon_name(string iconName, GtkIconSize size);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_new_from_gicon(IntPtr icon, GtkIconSize size);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_image_new_from_resource(string resourcePath);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_image_set_from_file(IntPtr image, string filename);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_new_from_surface(IntPtr surface);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_set_from_pixbuf(IntPtr image, IntPtr pixbuf);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_set_from_animation(IntPtr image, IntPtr animation);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_image_set_from_icon_name(IntPtr image, string iconName, GtkIconSize size);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_set_from_gicon(IntPtr image, IntPtr icon, GtkIconSize size);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_image_set_from_resource(IntPtr image, string resourcePath);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_set_from_surface(IntPtr image, IntPtr surface);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_clear(IntPtr image);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_image_new();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_image_set_pixel_size(IntPtr image, int pixelSize);

        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_image_get_pixel_size(IntPtr image);
    }
}
