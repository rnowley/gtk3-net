using System;
using System.ComponentModel;
using Gtk3.Native;

namespace Gtk3
{
    public class Image : Widget
    {

        /// <summary>
        /// Creates a new empty GtkImage widget.
        /// </summary>
        public Image()
        {
            Instance = GtkImage.gtk_image_new();
        }

        /// <summary>
        /// Creates a new GtkImage displaying pixbuf . The GtkImage does not assume a reference
        /// to the pixbuf; you still need to unref it if you own references. GtkImage will add
        /// its own reference rather than adopting yours.
        ///
        /// Note that this function just creates an GtkImage from the pixbuf. The GtkImage
        /// created will not react to state changes. Should you want that, you should use
        /// gtk_image_new_from_icon_name().
        /// </summary>
        /// <param name="pixbuf">a Pixbuf, or null.</param>
        public Image(Pixbuf pixbuf)
        {

            if (pixbuf == null)
            {
                Instance = Native.GtkImage.gtk_image_new_from_pixbuf(IntPtr.Zero);
            }
            else
            {
                Instance = Native.GtkImage.gtk_image_new_from_pixbuf(pixbuf.Instance);
            }

        }

        /// <summary>
        /// Creates a GtkImage displaying an icon from the current icon theme. If the icon
        /// name isn’t known, a “broken image” icon will be displayed instead. If the current
        /// icon theme is changed, the icon will be updated appropriately.
        /// </summary>
        /// <param name="iconName">an icon name or null.</param>
        /// <param name="size">a stock icon size.</param>
        public Image(string iconName, GtkIconSize size)
        {
            Instance = GtkImage.gtk_image_new_from_icon_name(iconName, size);
        }

        /// <summary>
        /// Creates an Image displaying an icon from the current icon theme. If the icon name
        /// isn’t known, a “broken image” icon will be displayed instead. If the current icon
        /// theme is changed, the icon will be updated appropriately.
        /// </summary>
        /// <param name="icon">an icon</param>
        /// <param name="size">a stock icon size</param>
        public Image(Icon icon, GtkIconSize size)
        {
            Instance = GtkImage.gtk_image_new_from_gicon(icon.Instance, size);
        }

        /// <summary>
        /// Creates a new GtkImage displaying the resource file resource_path . If the file
        /// isn’t found or can’t be loaded, the resulting GtkImage will display a “broken
        /// image” icon. This function never returns NULL, it always returns a valid GtkImage
        /// widget.If the file contains an animation, the image will contain an animation. If
        /// you need to detect failures to load the file, use gdk_pixbuf_new_from_file() to
        /// load the file yourself, then create the GtkImage from the pixbuf. (Or for
        /// animations, use gdk_pixbuf_animation_new_from_file()).The storage type
        /// (gtk_image_get_storage_type()) of the returned image is not defined, it will be
        /// whatever is appropriate for displaying the file.
        /// </summary>
        /// <param name="path">the path to the image source</param>
        /// <param name="source"></param>
        public Image(string path, ImageSource source)
        {

            switch (source)
            {
                case ImageSource.Resource:
                    Instance = GtkImage.gtk_image_new_from_resource(path);
                    break;
                case ImageSource.File:
                    Instance = GtkImage.gtk_image_new_from_file(path);
                    break;
                default:
                    throw new InvalidEnumArgumentException("source is not a valid enum value");
            }

        }

        /// <summary>
        /// Creates a new GtkImage displaying surface . The GtkImage does not assume a
        /// reference to the surface; you still need to unref it if you own references.
        /// GtkImage will add its own reference rather than adopting yours.
        /// </summary>
        /// <param name="surface">a cairo_surface_t, or null.</param>
        public Image(CairoSurface surface)
        {

            if (surface == null)
            {
                Instance = GtkImage.gtk_image_new_from_surface(IntPtr.Zero);
            }
            else
            {
                Instance = GtkImage.gtk_image_new_from_surface(surface.Instance);
            }

        }

        /// <summary>
        /// Creates a Image displaying the given animation. The Image does not assume a
        /// reference to the animation; you still need to unref it if you own references.
        /// GtkImage will add its own reference rather than adopting yours.Note that the
        /// animation frames are shown using a timeout with G_PRIORITY_DEFAULT. When using
        /// animations to indicate busyness, keep in mind that the animation will only be
        /// shown if the main loop is not busy with something that has a higher priority.
        /// </summary>
        /// <param name="animation">an animation</param>
        public Image(PixbufAnimation animation)
        {
            Instance = GtkImage.gtk_image_get_animation(animation.Instance);
        }

        /// <summary>
        /// Resets the image to be empty.
        /// </summary>
        public void Clear()
        {
            GtkImage.gtk_image_clear(Instance);
        }

        /// <summary>
        /// Gets the icon name and size being displayed by the GtkImage. The storage type of
        /// the image must be GTK_IMAGE_EMPTY or GTK_IMAGE_ICON_NAME (see
        /// gtk_image_get_storage_type()). The returned string is owned by the GtkImage and
        /// should not be freed.
        /// </summary>
        /// <returns>An IconInfo object representing the name and size of the icon</returns>
        public IconInfo GetIconName()
        {
            GtkImage.gtk_image_get_icon_name(Instance, out var iconName, out var size);

            return new IconInfo
            {
                IconName = iconName,
                Size = size
            };
        }

        /// <summary>
        /// Sets an Image displaying an icon from the current icon theme. If the icon name
        /// isn’t known, a “broken image” icon will be displayed instead. If the current icon
        /// theme is changed, the icon will be updated appropriately.
        /// </summary>
        /// <param name="icon">an icon</param>
        /// <param name="size">a stock icon size</param>
        public void SetFromIcon(Icon icon, GtkIconSize size)
        {
            GtkImage.gtk_image_set_from_gicon(Instance, icon.Instance, size);
        }

        /// <summary>
        /// sets a new GtkImage displaying the resource file resource_path . If the file isn’t
        /// found or can’t be loaded, the resulting GtkImage will display a “broken image”
        /// icon. This function never returns NULL, it always returns a valid GtkImage widget.
        /// If the file contains an animation, the image will contain an animation. If you need
        /// to detect failures to load the file, use gdk_pixbuf_new_from_file() to load the
        /// file yourself, then create the GtkImage from the pixbuf. (Or for animations, use
        /// gdk_pixbuf_animation_new_from_file()). The storage type (gtk_image_get_storage_type
        /// ()) of the returned image is not defined, it will be whatever is appropriate for
        /// displaying the file.
        /// </summary>
        /// <param name="resourcePath">a resource path or null</param>
        public void SetFromResource(string resourcePath)
        {
            GtkImage.gtk_image_set_from_resource(Instance, resourcePath);
        }

        /// <summary>
        /// Sets a new GtkImage displaying surface . The GtkImage does not assume a
        /// reference to the surface; you still need to unref it if you own references.
        /// GtkImage will add its own reference rather than adopting yours.
        /// </summary>
        /// <param name="surface">A CairoSurface or null</param>
        public void SetFromSurface(CairoSurface surface)
        {

            if (surface == null)
            {
                GtkImage.gtk_image_set_from_surface(Instance, IntPtr.Zero);
            }
            else
            {
                GtkImage.gtk_image_set_from_surface(Instance, surface.Instance);
            }

        }

        /// <summary>
        /// Sets a new GtkImage displaying the file filename . If the file isn’t found or
        /// can’t be loaded, the resulting GtkImage will display a “broken image” icon. This
        /// function never returns NULL, it always returns a valid GtkImage widget.
        /// If the file contains an animation, the image will contain an animation.If you need
        /// to detect failures to load the file, use gdk_pixbuf_new_from_file() to load the
        /// file yourself, then create the GtkImage from the pixbuf. (Or for animations, use
        /// gdk_pixbuf_animation_new_from_file()).The storage type (gtk_image_get_storage_type
        /// ()) of the returned image is not defined, it will be whatever is appropriate for
        /// displaying the file.
        /// </summary>
        /// <param name="filename">The name of the file to set the image from.</param>
        public void SetFromFile(string filename)
        {
            GtkImage.gtk_image_set_from_file(Handle, filename);
        }

        /// <summary>
        /// Sets the pixel size to use for named icons. If the pixel size is set to a value !=
        /// -1, it is used instead of the icon size set by SetFromIconName().
        /// </summary>
        public int PixelSize
        {
            get => Native.GtkImage.gtk_image_get_pixel_size(Instance);

            set => Native.GtkImage.gtk_image_set_pixel_size(Instance, value);
        }
    }

    public class IconInfo
    {
        public string IconName { get; set; }
        public GtkIconSize Size { get; set; }
    }

    public class Icon
    {
        public IntPtr Instance { get; set; }
    }

    public class IconSet
    {
        public IntPtr Instance { get; set; }
    }

    public enum ImageSource
    {
        File,
        Resource
    }

    public class PixbufAnimation
    {
        public IntPtr Instance { get; set; }
    }

    public class Pixbuf
    {
        public IntPtr Instance { get; set; }
    }

    public class CairoSurface
    {
        public IntPtr Instance { get; set; }
    }
}
