namespace Gtk3
{
    /// <summary>
    /// The type of message being displayed in the dialog.
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Informational message
        /// </summary>
        Info,
        /// <summary>
        /// Non-fatal warning message
        /// </summary>
        Warning,
        /// <summary>
        /// Question requiring a choice
        /// </summary>
        Question,
        /// <summary>
        /// Fatal error message
        /// </summary>
        Error,
        /// <summary>
        /// None of the above
        /// </summary>
        Other
    }
}