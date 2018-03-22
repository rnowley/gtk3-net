using System;

namespace gtk3_net
{
    public class Window : Container
    {
        private readonly IntPtr _instance;

        public Window(IntPtr app)
        {
            _instance = NativeMethods.gtk_application_window_new(app);
        }

        public void SetBorderWidth(uint borderWidth) {
            NativeMethods.gtk_container_set_border_width(Handle, borderWidth);
        }

        public void SetDefaultSize(int width, int height)
        {
            NativeMethods.gtk_window_set_default_size(_instance, 200, 200);
        }

        /// <summary>
        /// Sets the title of the window.
        /// </summary>
        /// <param name="title">The title of the window.</param>
        /// <remarks>
        /// The title of a window will be displayed in its title bar; on the X Window System,
        /// the title bar is rendered by the window manager, so exactly how the title appears to
        /// users may vary according to a user’s exact configuration. The title should help a user
        /// distinguish this window from other windows they may have open. A good title might include
        /// the application name and current document filename, for example.
        /// </remarks>
        public void SetTitle(string title)
        {
            NativeMethods.gtk_window_set_title(_instance, title);
        }

        /// <summary>
        /// Show the window and all of its widgets.
        /// </summary>
        public void Show()
        {
            NativeMethods.gtk_widget_show_all(_instance);
        }

        public override IntPtr Handle => _instance;
    }
}