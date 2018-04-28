namespace Gtk3
{
    /// <summary>
    /// Determines how GTK+ handles the sensitivity of stepper arrows at the end of
    /// range widgets.
    /// </summary>
    public enum SensitivityType
    {
        /// <summary>
        /// The arrow is made insensitive if the thumb is at the end
        /// </summary>
        Auto,
        /// <summary>
        /// The arrow is always sensitive
        /// </summary>
        On,
        /// <summary>
        /// The arrow is always insensitive
        /// </summary>
        Off
    }
}