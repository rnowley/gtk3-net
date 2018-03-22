using System;

namespace gtk3_net
{
    public class ButtonBox : Container
    {
        private readonly IntPtr _instance;
        public override IntPtr Handle => _instance;
        public ButtonBox(GtkOrientation orientation) {
            _instance = NativeMethods.gtk_button_box_new(orientation);
        }
        
    }
}