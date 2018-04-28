using System;
using Gtk3.Native;

namespace Gtk3
{
    public class Button : Widget
    {
        private readonly IntPtr _instance;
        
        public Button() {}
        
        public Button(string label)
        {
            _instance = GtkButton.gtk_button_new_with_label(label);
        }

        public Button(IntPtr instance)
        {
            _instance = instance;
        }

        public override IntPtr Handle => _instance;
    }
}