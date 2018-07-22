namespace Gtk3.Native
{
    /// <summary>
    /// Describes whether a GtkFileChooser is being used to open existing files or to save to a
    /// possibly new file.
    /// </summary>
    public enum GtkFileChooserAction
    {
        /// <summary>
        ///	Indicates open mode. The file chooser will only let the user pick an existing file.
        /// </summary>
        Open,
        /// <summary>
        ///	Indicates save mode. The file chooser will let the user pick an existing file, or type
        /// in a new filename.
        /// </summary>
        Save,
        /// <summary>
        ///Indicates an Open mode for selecting folders. The file chooser will let the user pick an
        /// existing folder.
        /// </summary>
        SelectFolder,
        /// <summary>
        ///	Indicates a mode for creating a new folder. The file chooser will let the user name an
        /// existing or new folder.
        /// </summary>
        CreateFolder
    }
}
