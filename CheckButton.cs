using System;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// A CheckButton places a discrete ToggleButton next to a widget, (usually a
    /// Label). See the section on ToggleButton widgets for more information
    /// about toggle/check buttons.
    /// The important signal (“toggled”) is also inherited from ToggleButton.
    /// </summary>
    public class CheckButton: ToggleButton
    {
        private readonly IntPtr _instance;

        /// <summary>
        /// Creates a new CheckButton.
        /// </summary>
        public CheckButton()
        {
            _instance = GtkCheckButton.gtk_check_button_new();
        }

        /// <summary>
        /// Creates a new CheckButton with a Label to the right of it.
        /// </summary>
        /// <param name="label">the text for the check button.</param>
        /// <remarks>
        /// If the text contains an underscore, then the character after the underscore
        /// will indicate the mnemonic for the button.
        /// </remarks>
        public CheckButton(string label)
        {

            if (label.Contains("_"))
            {
                _instance = GtkCheckButton.gtk_check_button_new_with_mnemonic(label);
            }
            else
            {
                _instance = GtkCheckButton.gtk_check_button_new_with_label(label);
            }

        }


        public override IntPtr Handle => _instance;
    }
}
