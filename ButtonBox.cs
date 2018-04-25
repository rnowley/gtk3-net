using System;
using gtk3_net.Native;

namespace gtk3_net
{
    public class ButtonBox : Container
    {
        public override IntPtr Handle { get; }

        public ButtonBox(Orientation orientation) {
            Handle = GtkButtonBox.gtk_button_box_new(orientation);
        }
        
    }
}