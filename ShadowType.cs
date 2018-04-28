namespace Gtk3
{
    /// <summary>
    /// Used to change the appearance of an outline typically provided by a GtkFrame.
    /// </summary>
    /// <remarks>
    /// Note that many themes do not differentiate the appearance of the various
    /// shadow types: Either their is no visible shadow (None), or there is
    /// (any other value).
    /// </remarks>
    public enum ShadowType
    {
        /// <summary>
        /// No outline.
        /// </summary>
        None,
        /// <summary>
        /// The outline is bevelled inwards.
        /// </summary>
        In,
        /// <summary>
        /// The outline is bevelled outwards like a button.
        /// </summary>
        Out,
        /// <summary>
        /// The outline has a sunken 3d appearance.
        /// </summary>
        EtchedIn,
        /// <summary>
        /// The outline has a raised 3d appearance.
        /// </summary>
        EtchedOut
    }
}