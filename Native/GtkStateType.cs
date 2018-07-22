namespace Gtk3.Native
{
    /// <summary>
    /// This type indicates the current state of a widget; the state determines how the widget
    /// is drawn. The GtkStateType enumeration is also used to identify different colors in a
    /// GtkStyle for drawing, so states can be used for subparts of a widget as well as entire
    /// widgets.
    /// </summary>
    public enum GtkStateType
    {
        /// <summary>
        /// State during normal operation.
        /// </summary>
        Normal,
        /// <summary>
        /// State of a currently active widget, such as a depressed button.
        /// </summary>
        Active,
        /// <summary>
        ///State indicating that the mouse pointer is over the widget and the widget will
        /// respond to mouse clicks.
        /// </summary>
        Prelight,
        /// <summary>
        ///	State of a selected item, such the selected row in a list.
        /// </summary>
        Selected,
        /// <summary>
        /// State indicating that the widget is unresponsive to user actions.
        /// </summary>
        Insensitive,
        /// <summary>
        ///The widget is inconsistent, such as checkbuttons or radiobuttons that aren't either
        /// set to true nor false, or buttons requiring the user attention.
        /// </summary>
        Inconsistent,
        /// <summary>
        ///	The widget has the keyboard focus.
        /// </summary>
        Focus
    }
}
