namespace Gtk3.Native
{
    /// <summary>
    /// These identify the various errors that can occur while calling GtkFileChooser functions.
    /// </summary>
    public enum GtkFileChooserError
    {
        /// <summary>
        ///	Indicates that a file does not exist.
        /// </summary>
        NonExistent,
        /// <summary>
        ///	Indicates a malformed filename.
        /// </summary>
        BadFilename,
        /// <summary>
        ///Indicates a duplicate path (e.g. when adding a bookmark).
        /// </summary>
        AlreadyExists,
        /// <summary>
        ///	Indicates an incomplete hostname (e.g. "http://foo" without a slash after that).
        /// </summary>
        IncompleteHostname
    }
}
