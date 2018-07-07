using System;
using System.Runtime.InteropServices;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// A single radio button performs the same basic function as a CheckButton, as
    /// its position in the object hierarchy reflects. It is only when multiple radio
    /// buttons are grouped together that they become a different user interface
    /// component in their own right.
    /// Every radio button is a member of some group of radio buttons. When one is
    /// selected, all other radio buttons in the same group are deselected. A
    /// RadioButton is one way of giving the user a choice from many options.
    ///
    /// Radio button widgets are created with RadioButton(), if this is the first radio
    /// button in a group. In subsequent calls,
    /// the group you wish to add this button to should be passed as an argument.
    /// Optionally,
    /// gtk_radio_button_new_with_label() can be used if you want a text label on the
    /// radio button.
    ///
    /// Alternatively, when adding widgets to an existing group of radio buttons, use
    /// gtk_radio_button_new_from_widget() with a GtkRadioButton that already has a
    /// group assigned to it. The convenience function
    /// gtk_radio_button_new_with_label_from_widget() is also provided.
    ///
    /// To retrieve the group a RadioButton is assigned to, use
    /// gtk_radio_button_get_group().
    /// To remove a RadioButton from one group and make it part of a new one, use
    /// gtk_radio_button_set_group().
    /// The group list does not need to be freed, as each RadioButton will remove
    /// itself and its list item when it is destroyed.
    /// </summary>
    public class RadioButton : CheckButton
    {
        private readonly IntPtr _instance;

        public RadioButton()
        {
            _instance = GtkRadioButton.gtk_radio_button_new(IntPtr.Zero);
        }

        /// <summary>
        /// Creates a new RadioButton, adding it to the same group as radioGroupMember.
        /// As with gtk_radio_button_new(), a widget should be packed into the radio
        /// button.
        /// </summary>
        /// <param name="radioGroupMember">an existing RadioButton.</param>
        public RadioButton(RadioButton radioGroupMember)
        {
            _instance = GtkRadioButton.gtk_radio_button_new_from_widget(radioGroupMember.Handle);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="radioGroupMember">an existing RadioButton or null if
        /// you are creating a new group.</param>
        /// <param name="label">
        /// the text label to display next to the radio button.
        /// </param>
        public RadioButton(RadioButton radioGroupMember, string label)
        {

            if (radioGroupMember == null)
            {
                 _instance = GtkRadioButton.gtk_radio_button_new_with_label_from_widget(IntPtr.Zero, label);
                return;
            }

            if (label.Contains("_"))
            {
                _instance = GtkRadioButton.gtk_radio_button_new_with_mnemonic_from_widget(radioGroupMember.Handle, label);
            }
            else
            {
                _instance = GtkRadioButton.gtk_radio_button_new_with_label_from_widget(radioGroupMember.Handle, label);
            }

        }

        /// <summary>
        /// Joins this RadioButton object to the group of another RadioButton object
        /// </summary>
        /// <param name="source">a radio button object whos group we are joining, or
        /// null to remove the radio button from its group.</param>
        public void JoinGroup(RadioButton source)
        {

            if (source == null)
            {
                GtkRadioButton.gtk_radio_button_join_group(Handle, IntPtr.Zero);
            }
            else
            {
                GtkRadioButton.gtk_radio_button_join_group(Handle, source.Handle);
            }

        }

        public void ConnectGroupChangedSignal(WidgetCallBack2Arg callback, IntPtr data, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(Handle, "group-changed",
                Marshal.GetFunctionPointerForDelegate(callback), data,
                destroyData, GConnectFlags.ConnectAfter);
        }

        public override IntPtr Handle => _instance;
    }
}
