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

        public void SetDefaultSize(int width, int height)
        {
            NativeMethods.gtk_window_set_default_size(_instance, 200, 200);
        }

        /// <summary>
        /// Show the window and all of its widgets.
        /// </summary>
        public void Show()
        {
            NativeMethods.gtk_widget_show_all(_instance);
        }

        /// <summary>
        /// Adds a widget to the container
        /// </summary>
        /// <param name="widget">The widget to add to the container</param>
        /// <remarks>
        /// Typically used for simple containers such as GtkWindow, GtkFrame, or GtkButton; for more complicated
        /// layout containers such as GtkBox or GtkGrid, this function will pick default packing parameters that
        /// may not be correct. So consider functions such as gtk_box_pack_start() and gtk_grid_attach() as an
        /// alternative to gtk_container_add() in those cases. A widget may be added to only one container at a time;
        /// you can’t place the same widget inside two different containers.
        /// Note that some containers, such as GtkScrolledWindow or GtkListBox, may add intermediate children between
        /// the added widget and the container.
        /// </remarks>
        public override void AddWidget(Widget widget)
        {
            NativeMethods.gtk_container_add(_instance, widget.Handle);
        }

        internal override IntPtr Handle => _instance;
    }
}