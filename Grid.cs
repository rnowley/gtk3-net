using System;

namespace gtk3_net
{
    public class Grid : Widget
    {
        public override IntPtr Handle { get; }

        public Grid() {
            Handle = NativeMethods.gtk_grid_new();
        }

        public void Attach(Widget child, int left, int top, int width, int height) {
            NativeMethods.gtk_grid_attach(Handle, child.Handle, left, top, width, height);
        }
        
    }
}