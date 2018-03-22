using System;

namespace gtk3_net
{
    public class Button : Widget
    {
        private readonly IntPtr _instance;
        public Button(string label)
        {
            _instance = NativeMethods.gtk_button_new_with_label(label);
        }

        public override IntPtr Handle => _instance;
    }
}