namespace Gtk3.Native
{
    /// <summary>
    /// Used as a return value of handlers for the "confirm-overwrite" signal of a GtkFileChooser.
    /// This value determines whether the file chooser will present the stock confirmation dialog,
    /// accept the user's choice of a filename, or let the user choose another filename.
    /// </summary>
    public enum GtkFileChooserConfirmation
    {
        /// <summary>
        ///The file chooser will present its stock dialog to confirm about overwriting an existing
        /// file.
        /// </summary>
        Confirm,
        /// <summary>
        ///The file chooser will terminate and accept the user's choice of a file name.
        /// </summary>
        AcceptFilename,
        /// <summary>
        ///The file chooser will continue running, so as to let the user select another file name.
        /// </summary>
        SelectAgain
    }
}
