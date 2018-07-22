using System;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// A GtkFileFilter can be used to restrict the files being
    /// shown in a GtkFileChooser. Files can be filtered based
    /// on their name (with gtk_file_filter_add_pattern()), on
    /// their mime type (with gtk_file_filter_add_mime_type()),
    /// or by a custom filter function (with
    /// gtk_file_filter_add_custom()).
    ///
    /// Filtering by mime types handles aliasing and subclassing
    /// of mime types; e.g. a filter for text/plain also matches
    /// a file with mime type application/rtf, since
    /// application/rtf is a subclass of text/plain. Note that
    /// GtkFileFilter allows wildcards for the subtype of a mime
    /// type, so you can e.g. filter for image/*.
    ///
    /// Normally, filters are used by adding them to a
    /// GtkFileChooser, see gtk_file_chooser_add_filter(), but
    /// it is also possible to manually use a filter on a file
    /// with gtk_file_filter_filter().
    /// </summary>
    public class FileFilter
    {
        internal readonly IntPtr Instance;

        /// <summary>
        /// Creates a new GtkFileFilter with no rules added to it. Such a filter doesn't accept
        /// any files, so is not particularly useful until you add rules with
        /// gtk_file_filter_add_mime_type(), gtk_file_filter_add_pattern(), or
        /// gtk_file_filter_add_custom().
        /// </summary>
        public FileFilter()
        {
            Instance = GtkFileFilter.gtk_file_filter_new();
        }

        /// <summary>
        /// Adds a rule allowing a given mime type to filter.
        /// </summary>
        /// <param name="mimeType">name of a MIME type</param>
        public void AddMimeType(string mimeType)
        {
            GtkFileFilter.gtk_file_filter_add_mime_type(Instance, mimeType);
        }

        /// <summary>
        /// Adds a rule allowing a shell style glob to a filter.
        /// </summary>
        /// <param name="pattern">a shell style glob</param>
        public void AddPattern(string pattern)
        {
            GtkFileFilter.gtk_file_filter_add_pattern(Instance, pattern);
        }

        /// <summary>
        /// Adds a rule allowing image files in the formats supported by GdkPixbuf.
        /// </summary>
        public void AddPixbufFormats()
        {
            GtkFileFilter.gtk_file_filter_add_pixbuf_formats(Instance);
        }

        /// <summary>
        ///Tests whether a file should be displayed according to filter. The GtkFileFilterInfo
        /// structure filter_info should include the fields returned from
        /// gtk_file_filter_get_needed(). This function will not typically be used by
        /// applications; it is intended principally for use in the implementation of
        /// GtkFileChooser.
        /// </summary>
        /// <param name="filterInfo">a GtkFileFilterInfo structure containing information about
        /// a file.</param>
        /// <returns>true if the file should be displayed</returns>
        public bool Filter(GtkFileFilterInfo filterInfo) => GtkFileFilter.gtk_file_filter_filter(Instance, filterInfo);

        /// <summary>
        /// Gets or Sets the human-readable name of the filter; this is the string that will be
        /// displayed in the file selector user interface if there is a selectable list of
        /// filters.
        /// </summary>
        public string Name {
            get => GtkFileFilter.gtk_file_filter_get_name(Instance);
            set => GtkFileFilter.gtk_file_filter_set_name(Instance, value);
        }

        /// <summary>
        /// Gets the fields that need to be filled in for the structure passed to
        /// gtk_file_filter_filter().This function will not typically be used by applications;
        /// it is intended principally for use in the implementation of GtkFileChooser.
        /// </summary>
        public GtkFileFilterFlags Needed => GtkFileFilter.gtk_file_filter_get_needed(Instance);
    }
}
