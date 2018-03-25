using System;

namespace gtk3_net
{
    public class ButtonBox : Container
    {
        public override IntPtr Handle { get; }

        public ButtonBox(GtkOrientation orientation) {
            Handle = NativeMethods.gtk_button_box_new(orientation);
        }
        
    }
}