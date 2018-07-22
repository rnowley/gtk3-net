using System;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// Dialog boxes are a convenient way to prompt the user for a small amount of input, e.g. to
    /// display a message, ask a question, or anything else that does not require extensive effort
    /// on the user's part.
    ///
    /// GTK+ treats a dialog as a window split vertically. The top section is a
    /// GtkVBox, and is where widgets such as a GtkLabel or a GtkEntry should be packed. The bottom
    /// area is known as the action_area. This is generally used for packing buttons into the
    /// dialog which may perform functions such as cancel, ok, or apply.
    ///
    /// GtkDialog boxes are created
    /// with a call to gtk_dialog_new() or gtk_dialog_new_with_buttons().
    /// gtk_dialog_new_with_buttons() is recommended; it allows you to set the dialog title, some
    /// convenient flags, and add simple buttons.
    ///
    /// If 'dialog' is a newly created dialog, the two
    /// primary areas of the window can be accessed through gtk_dialog_get_content_area() and
    /// gtk_dialog_get_action_area(), as can be seen from the example below.
    ///
    /// A 'modal' dialog (that
    /// is, one which freezes the rest of the application from user input), can be created by
    /// calling gtk_window_set_modal() on the dialog. Use the GTK_WINDOW() macro to cast the widget
    /// returned from gtk_dialog_new() into a GtkWindow. When using gtk_dialog_new_with_buttons()
    /// you can also pass the GTK_DIALOG_MODAL flag to make a dialog modal.
    ///
    /// If you add buttons to
    /// GtkDialog using gtk_dialog_new_with_buttons(), gtk_dialog_add_button(),
    /// gtk_dialog_add_buttons(), or gtk_dialog_add_action_widget(), clicking the button will emit
    /// a signal called "response" with a response ID that you specified. GTK+ will never assign a
    /// meaning to positive response IDs; these are entirely user-defined. But for convenience, you
    /// can use the response IDs in the GtkResponseType enumeration (these all have values less
    /// than zero). If a dialog receives a delete event, the "response" signal will be emitted with
    /// a response ID of GTK_RESPONSE_DELETE_EVENT.
    ///
    /// If you want to block waiting for a dialog to
    /// return before returning control flow to your code, you can call gtk_dialog_run(). This
    /// function enters a recursive main loop and waits for the user to respond to the dialog,
    /// returning the response ID corresponding to the button the user clicked.
    ///
    /// For the simple dialog in the following example, in reality you'd probably use
    /// GtkMessageDialog to save yourself some effort. But you'd need to create the dialog contents
    /// manually if you had more than a simple message in the dialog.
    /// </summary>
    public class Dialog : Window
    {

        /// <summary>
        /// Creates a new dialog box.
        /// Widgets should not be packed into this GtkWindow directly, but into the vbox and
        /// action_area, as described above.
        /// </summary>
        public Dialog()
        {
            Instance = GtkDialog.gtk_dialog_new();
        }

        /// <summary>
        /// Creates a new GtkDialog with title title (or NULL for the default title; see
        /// gtk_window_set_title()) and transient parent parent (or NULL for none; see
        /// gtk_window_set_transient_for()). The flags argument can be used to make the dialog
        /// modal (GTK_DIALOG_MODAL) and/or to have it destroyed along with its transient
        /// parent (GTK_DIALOG_DESTROY_WITH_PARENT). After flags, button text/response ID pairs
        /// should be listed, with a NULL pointer ending the list. Button text can be either a
        /// stock ID such as GTK_STOCK_OK, or some arbitrary text. A response ID can be any
        /// positive number, or one of the values in the GtkResponseType enumeration. If the
        /// user clicks one of these dialog buttons, GtkDialog will emit the "response" signal
        /// with the corresponding response ID. If a GtkDialog receives the "delete-event"
        /// signal, it will emit ::response with a response ID of GTK_RESPONSE_DELETE_EVENT.
        /// However, destroying a dialog does not emit the ::response signal; so be careful
        /// relying on ::response when using the GTK_DIALOG_DESTROY_WITH_PARENT flag. Buttons
        /// are from left to right, so the first button in the list will be the leftmost button
        /// in the dialog.
        /// </summary>
        /// <param name="title">Title of the dialog, or NULL.</param>
        /// <param name="parent">Transient parent of the dialog, or NULL.</param>
        /// <param name="flags">from GtkDialogFlags</param>
        /// <param name="firstButtonText">stock ID or text to go in first button, or NULL.</param>
        /// <param name="additionalButtonText">response ID for first button, then additional buttons, ending with NULL</param>
        public Dialog(string title, Window parent, GtkDialogFlags flags, string firstButtonText,
            params string[] additionalButtonText)
        {

            if (parent == null)
            {
                Instance = GtkDialog.gtk_dialog_new_with_buttons(title, IntPtr.Zero, flags, firstButtonText,
                    additionalButtonText);
            }
            else
            {
                Instance = GtkDialog.gtk_dialog_new_with_buttons(title, parent.Handle, flags, firstButtonText,
                    additionalButtonText);
            }

        }

        /// <summary>
        /// Blocks in a recursive main loop until the dialog either emits the "response"
        /// signal, or is destroyed. If the dialog is destroyed during the call to
        /// gtk_dialog_run(), gtk_dialog_run() returns GTK_RESPONSE_NONE. Otherwise, it returns
        /// the response ID from the ::response signal emission.
        /// Before entering the recursive main loop, gtk_dialog_run() calls gtk_widget_show()
        /// on the dialog for you. Note that you still need to show any children of the dialog
        /// yourself.
        /// During gtk_dialog_run(), the default behavior of "delete-event" is disabled; if the
        /// dialog receives ::delete_event, it will not be destroyed as windows usually are,
        /// and gtk_dialog_run() will return GTK_RESPONSE_DELETE_EVENT. Also, during
        /// gtk_dialog_run() the dialog will be modal. You can force gtk_dialog_run() to return
        /// at any time by calling gtk_dialog_response() to emit the ::response signal.
        /// Destroying the dialog during gtk_dialog_run() is a very bad idea, because your
        /// post-run code won't know whether the dialog was destroyed or not.
        /// After gtk_dialog_run() returns, you are responsible for hiding or destroying the
        /// dialog if you wish to do so.
        /// </summary>
        /// <remarks>Note that even though the recursive main loop gives the effect of a modal
        /// dialog (it prevents the user from interacting with other windows in the same window
        /// group while the dialog is run), callbacks such as timeouts, IO channel watches, DND
        /// drops, etc, will be triggered during a gtk_dialog_run() call.</remarks>
        /// <returns>response ID</returns>
        public int Run()
        {
            return GtkDialog.gtk_dialog_run(Instance);
        }

        /// <summary>
        /// Emits the "response" signal with the given response ID. Used to indicate that the
        /// user has responded to the dialog in some way; typically either you or gtk_dialog_run
        /// () will be monitoring the ::response signal and take appropriate action.
        /// </summary>
        /// <param name="responseId">response ID</param>
        public void Response(int responseId)
        {
            GtkDialog.gtk_dialog_response(Instance, responseId);
        }

        /// <summary>
        /// Adds a button with the given text (or a stock button, if button_text is a stock ID) and
        /// sets things up so that clicking the button will emit the "response" signal with the
        /// given response_id. The button is appended to the end of the dialog's action area. The
        /// button widget is returned, but usually you don't need it.
        /// </summary>
        /// <param name="buttonText">text of button, or stock ID</param>
        /// <param name="responseId">response ID for the button</param>
        /// <returns>the Button widget that was added.</returns>
        public Widget AddButton(string buttonText, int responseId)
        {
            var handle = GtkDialog.gtk_dialog_add_button(Instance, buttonText, responseId);

            return new Button(handle);
        }

        /// <summary>
        /// Adds an activatable widget to the action area of a GtkDialog, connecting a signal
        /// handler that will emit the "response" signal on the dialog when the widget is activated.
        /// The widget is appended to the end of the dialog's action area. If you want to add a
        /// non-activatable widget, simply pack it into the action_area field of the GtkDialog
        /// struct.
        /// </summary>
        /// <param name="child">an activatable widget</param>
        /// <param name="responseId">response ID for child</param>
        public void AddActionWidget(Widget child, int responseId)
        {
            GtkDialog.gtk_dialog_add_action_widget(Instance, child.Handle, responseId);
        }

        /// <summary>
        /// Sets the last widget in the dialog's action area with the given response_id as the
        /// default widget for the dialog. Pressing "Enter" normally activates the default widget.
        /// </summary>
        /// <param name="responseId">a response ID</param>
        public void SetDefaultResponse(int responseId)
        {
            GtkDialog.gtk_dialog_set_default_response(Instance, responseId);
        }

        /// <summary>
        /// Calls gtk_widget_set_sensitive (widget, setting) for each widget in the dialog's action
        /// area with the given response_id. A convenient way to sensitize/desensitize dialog
        /// buttons.
        /// </summary>
        /// <param name="responseId">a response ID</param>
        /// <param name="setting">true for sensitive</param>
        public void SetResponseSensitive(int responseId, bool setting)
        {
             GtkDialog.gtk_dialog_set_response_sensitive(Instance, responseId, setting);
        }

        /// <summary>
        /// Gets the response id of a widget in the action area of a dialog.
        /// </summary>
        /// <param name="widget">a widget in the action area of dialog</param>
        /// <returns>the response id of widget, or GTK_RESPONSE_NONE if widget doesn't have a
        /// response id set.</returns>
        public int GetResponseForWidget(Widget widget)
        {
            return GtkDialog.gtk_dialog_get_response_for_widget(Instance, widget.Handle);
        }

        /// <summary>
        /// Gets the widget button that uses the given response ID in the action area of a dialog.
        /// </summary>
        /// <param name="responseId">the response ID used by the dialog widget</param>
        /// <returns>the widget button that uses the given response_id, or NULL.</returns>
        public Widget GetWidgetForResponse(int responseId)
        {
            var handle = GtkDialog.gtk_dialog_get_widget_for_response(Instance, responseId);

            return new Button(handle);
        }

        /// <summary>
        /// Returns the action area of dialog.
        /// </summary>
        /// <returns>the action area.</returns>
        public Widget GetActionArea()
        {
            var handle = GtkDialog.gtk_dialog_get_action_area(Instance);

            return new Box(handle);
        }


        /// <summary>
        /// Returns the content area of dialog.
        /// </summary>
        /// <returns>the content area (Box).</returns>
        public Widget GetContentArea()
        {
            var handle = GtkDialog.gtk_dialog_get_content_area(Instance);

            return new Box(handle);
        }

        /// <summary>
        /// Sets an alternative button order. If the "gtk-alternative-button-order" setting is set
        /// to TRUE, the dialog buttons are reordered according to the order of the response ids
        /// passed to this function.By default, GTK+ dialogs use the button order advocated by the
        /// Gnome Human Interface Guidelines with the affirmative button at the far right, and the
        /// cancel button left of it. But the builtin GTK+ dialogs and GtkMessageDialogs do provide
        /// an alternative button order, which is more suitable on some platforms, e.g. Windows.Use
        /// this function after adding all the buttons to your dialog.
        /// </summary>
        /// <param name="firstResponseId">a response id used by one dialog's buttons</param>
        /// <param name="otherResponseIds">a list of more response ids of dialog's buttons,
        /// terminated by -1</param>
        public void SetAlternativeButtonOrder(int firstResponseId, params int[] otherResponseIds)
        {
           GtkDialog.gtk_dialog_set_alternative_button_order(Instance, firstResponseId, otherResponseIds);
        }

        /// <summary>
        /// Sets an alternative button order. If the "gtk-alternative-button-order" setting is set
        /// to TRUE, the dialog buttons are reordered according to the order of the response ids in
        /// new_order.
        /// See gtk_dialog_set_alternative_button_order() for more information.
        /// </summary>
        /// <param name="newOrder">an array of response ids of dialog's buttons.</param>
        public void SetAlternativeButtonOrder(int[] newOrder)
        {
            GtkDialog.gtk_dialog_set_alternative_button_order_from_array(Instance, newOrder.Length, newOrder);
        }
    }
}
