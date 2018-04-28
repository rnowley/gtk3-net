using System;
using Gtk3.Native;

namespace Gtk3
{
    public class Grid : Widget
    {
        public override IntPtr Handle { get; }

        public Grid() {
            Handle = GtkGrid.gtk_grid_new();
        }

        public void Attach(Widget child, int left, int top, int width, int height) {
            GtkGrid.gtk_grid_attach(Handle, child.Handle, left, top, width, height);
        }

    }
}
