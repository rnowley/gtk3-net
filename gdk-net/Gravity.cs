namespace Gdk
{
    /// <summary>
    /// Defines the reference point of a window and the meaning of coordinates passed to
    /// Window.Move(). See Window.Move() and the "implementation notes" section
    /// of the Extended Window Manager Hints specification for more details.
    /// </summary>
    public enum Gravity
    {
        /// <summary>
        /// the reference point is at the top left corner.
        /// </summary>
        NorthWest,
        /// <summary>
        /// the reference point is in the middle of the top edge.
        /// </summary>
        North,
        /// <summary>
        /// the reference point is at the top right corner.
        /// </summary>
        NorthEast,
        /// <summary>
        /// the reference point is at the middle of the left edge.
        /// </summary>
        West,
        /// <summary>
        /// the reference point is at the center of the window.
        /// </summary>
        Centre,
        /// <summary>
        /// the reference point is at the middle of the right edge.
        /// </summary>
        East,
        /// <summary>
        /// the reference point is at the lower left corner.
        /// </summary>
        SouthWest,
        /// <summary>
        /// the reference point is at the middle of the lower edge.
        /// </summary>
        South,
        /// <summary>
        /// the reference point is at the lower right corner.
        /// </summary>
        SouthEast,
        /// <summary>
        /// the reference point is at the top left corner of the window itself, ignoring window
        /// manager decorations.
        /// </summary>
        Static
    }
}
