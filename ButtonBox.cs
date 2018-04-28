using System;
using Gtk3.Native;

namespace Gtk3
{
    public class ButtonBox : Container
    {
        public override IntPtr Handle { get; }

        public ButtonBox(Orientation orientation) {
            Handle = GtkButtonBox.gtk_button_box_new(orientation);
        }
        
    }
}