namespace Gtk3.Native
{
    /// <summary>
    /// Predefined values for use as response ids in gtk_dialog_add_button(). All predefined
    /// values are negative, GTK+ leaves positive values for application-defined response ids.
    /// </summary>
    public enum GtkResponseType
    {
        /// <summary>
        /// Returned if an action widget has no response id, or if the dialog gets
        /// programmatically hidden or destroyed
        /// </summary>
        None = -1,
        /// <summary>
        /// Generic response id, not used by GTK+ dialogs
        /// </summary>
        Reject = -2,
        /// <summary>
        /// Generic response id, not used by GTK+ dialogs
        /// </summary>
        Accept = -3,
        /// <summary>
        /// Returned if the dialog is deleted
        /// </summary>
        DeleteEvent = -4,
        /// <summary>
        /// Returned by OK buttons in GTK+ dialogs
        /// </summary>
        Ok = -5,
        /// <summary>
        /// Returned by Cancel buttons in GTK+ dialogs
        /// </summary>
        Cancel = -6,
        /// <summary>
        /// Returned by Close buttons in GTK+ dialogs
        /// </summary>
        Close = -7,
        /// <summary>
        /// Returned by Yes buttons in GTK+ dialogs
        /// </summary>
        Yes = -8,
        /// <summary>
        ///Returned by No buttons in GTK+ dialogs
        /// </summary>
        No = -9,
        /// <summary>
        ///Returned by Apply buttons in GTK+ dialogs
        /// </summary>
        Apply = -10,
        /// <summary>
        /// Returned by Help buttons in GTK+ dialogs
        /// </summary>
        Help = -11
    }
}
