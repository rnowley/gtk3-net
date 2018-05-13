using System;
using System.Runtime.InteropServices;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// A ToggleButton is a Button which will remain “pressed-in” when clicked. Clicking
    /// again will cause the toggle button to return to its normal state.
    /// A toggle button is created by calling either new ToggleButton() or
    /// TogleButton(label). If using the former, it is advisable to pack a widget, (such
    /// as a Label and/or an Image), into the toggle button’s container. (See Button for
    /// more information).
    ///
    /// The state of a ToggleButton can be set and retrieved using the
    /// ToggleButton.Active.
    /// To simply switch the state of a toggle button, use gtk_toggle_button_toggled().
    /// </summary>
    public class ToggleButton: Button
    {
        private readonly IntPtr _instance;

        /// <summary>
        /// Creates a new toggle button.
        /// </summary>
        public ToggleButton()
        {
            _instance = GtkToggleButton.gtk_toggle_button_new();
        }

        /// <summary>
        /// Creates a new toggle button with a text label.
        /// </summary>
        /// <param name="label">a string containing the message to be placed in the toggle button.</param>
        /// <remarks>
        /// If the text contains an underscore, then the character after the underscore
        /// will indicate the mnemonic for the button.
        /// </remarks>
        public ToggleButton(string label)
        {

            if (label.Contains("_"))
            {
                _instance = GtkToggleButton.gtk_toggle_button_new_with_mnemonic(label);
            }
            else
            {
                _instance = GtkToggleButton.gtk_toggle_button_new_with_label(label);
            }

        }

        /// <summary>
        /// Gets or sets whether the button is displayed as a separate indicator and label.
        /// If mode is set to true then the toggle button is drawn as a separate indicator
        /// and label.
        /// </summary>
        public bool Mode
        {
            get => GtkToggleButton.gtk_toggle_button_get_mode(Handle);
            set => GtkToggleButton.gtk_toggle_button_set_mode(Handle, value);
        }

        /// <summary>
        /// Gets or sets the current state of the ToggleButton. True indicates that the
        /// button is raised and false indicates that it is raised.
        /// </summary>
        /// <remarks>
        /// Setting to true causes the "toggled" event and the "clicked" event to be
        /// emitted.
        /// </remarks>
        public bool Active
        {
            get => GtkToggleButton.gtk_toggle_button_get_active(Handle);
            set => GtkToggleButton.gtk_toggle_button_set_active(Handle, value);
        }

        /// <summary>
        /// Gets or sets whether or not the button is displayed as consistent. True
        /// indicates the button is displayed as inconsistent and false otherwise.
        /// </summary>
        /// <remarks>
        /// If the user has selected a range of elements (such as some text or spreadsheet
        /// cells) that are affected by a toggle button, and the current values in that
        /// range are inconsistent, you may want to display the toggle in an “in between”
        /// state. This function turns on “in between” display. Normally you would turn
        /// off the inconsistent state again if the user toggles the toggle button. This
        /// has to be done manually, GtkToggleButton.Inconsistent only affects
        /// visual appearance, it doesn’t affect the semantics of the button.
        /// </remarks>
        public bool Inconsistent
        {
            get => GtkToggleButton.gtk_toggle_button_get_inconsistent(Handle);
            set => GtkToggleButton.gtk_toggle_button_set_inconsistent(Handle, value);
        }

        public void ConnectToggledSignal(WidgetCallBack2Arg callback, IntPtr data, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(Handle, "toggled",
                Marshal.GetFunctionPointerForDelegate(callback), data,
                destroyData, GConnectFlags.ConnectAfter);
        }


        private static void FreeData()
        {
        }

        public override IntPtr Handle => _instance;
    }
}
