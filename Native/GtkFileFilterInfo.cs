using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    /// <summary>
    /// A GtkFileFilterInfo struct is used to pass information about the tested file to
    /// gtk_file_filter_filter().
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GtkFileFilterInfo
    {
        /// <summary>
        /// Flags indicating which of the following fields need are filled
        /// </summary>
        public GtkFileFilterFlags contains;

        /// <summary>
        /// the filename of the file being tested
        /// </summary>
        public string filename;

        /// <summary>
        /// the URI for the file being tested
        /// </summary>
        public string uri;

        /// <summary>
        /// the string that will be used to display the file in the file chooser
        /// </summary>
        public string displayName;

        /// <summary>
        /// the mime type of the file
        /// </summary>
        public string mimeType;
    }
}
