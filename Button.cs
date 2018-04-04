using System;

namespace gtk3_net
{
    public class Button : Widget
    {
        private readonly IntPtr _instance;
        
        public Button() {}
        
        public Button(string label)
        {
            _instance = NativeMethods.gtk_button_new_with_label(label);
        }

        public Button(IntPtr instance)
        {
            _instance = instance;
        }

        public override IntPtr Handle => _instance;
    }
}