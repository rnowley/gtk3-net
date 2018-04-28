namespace Gtk3
{
    /// <summary>
    /// Whenever a container has some form of natural row it may align children in that
    /// row along a common typographical baseline. If the amount of verical space in the
    /// row is taller than the total requested height of the baseline-aligned children then
    /// it can use a BaselinePosition to select where to put the baseline inside the
    /// extra availible space.
    /// </summary>
    public enum BaselinePosition
    {
        Top,
        Centre,
        Bottom
    }
}