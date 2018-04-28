namespace Gtk3
{
    /// <summary>
    /// Describes what sort of (if any) ellipsization should be applied to a line of text.
    /// In the ellipsization process characters are removed from the text in order to make
    /// it fit to a given width and replaced with an ellipsis.
    /// </summary>
    public enum EllipsizeMode
    {
        /// <summary>
        /// No ellipsization
        /// </summary>
        None,
        /// <summary>
        /// Omit characters at the start of the text
        /// </summary>
        Start,
        /// <summary>
        /// Omit characters in the middle of the text
        /// </summary>
        Middle,
        /// <summary>
        /// Omit characters at the end of the text
        /// </summary>
        End
    }
}