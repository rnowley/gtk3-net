using System;

namespace Gtk3.Native
{
    /// <summary>
    /// These flags indicate what parts of a GtkFileFilterInfo struct are filled or need to
    /// be filled.
    /// </summary>
    [Flags]
    public enum GtkFileFilterFlags
    {
        /// <summary>
        /// the filename of the file being tested
        /// </summary>
        Filename = 1,
        /// <summary>
        ///the URI for the file being tested
        /// </summary>
        Uri = 2,
        /// <summary>
        ///	the string that will be used to display the file in the file chooser
        /// </summary>
        DisplayName = 4,
        /// <summary>
        ///the mime type of the file
        /// </summary>
        MimeType = 8
    }
}
