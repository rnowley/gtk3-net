using Gtk3.Native;

namespace Gtk3
{
    public class ButtonBox : Container
    {

        public ButtonBox(Orientation orientation) {
            Instance = GtkButtonBox.gtk_button_box_new(orientation);
        }

    }
}
