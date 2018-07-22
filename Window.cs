using System;
using Gdk;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// Toplevel which can contain other widgets
    /// </summary>
    public class Window : Container
    {
        private readonly IntPtr _instance;

        public Window()
        {
        }

        /// <summary>
        /// Creates a new Window, which is a toplevel window that can contain other widgets.
        /// Nearly always, the type of the window should be WindowType.TopLevel. If you’re
        /// implementing something like a popup menu from scratch (which is a bad idea, just use
        /// GtkMenu), you might use WindowType.Popup. WindowType.Popup is not for dialogs, though in
        /// some other toolkits dialogs are called “popups”. In GTK+, WindowType.Popup means a
        /// pop-up menu or pop-up tooltip. On X11, popup windows are not controlled by the window
        /// manager.
        /// If you simply want an undecorated window (no window borders), use
        /// Window.SetDecorated(), don’t use WindowType.Popup.
        /// All top-level windows created by new Window(WindowType type) are stored in an
        /// internal top-level window list. This list can be obtained from Window.ListToplevels().
        /// Due to Gtk+ keeping a reference to the window internally, Window() does not return a
        /// reference to the caller.
        /// To delete a Window, call Widget.Destroy().
        /// </summary>
        /// <param name="type">The type of window to create.</param>
        public Window(WindowType type)
        {
            _instance = GtkWindow.gtk_window_new(type);
        }

        public Window(IntPtr instance)
        {
            _instance = GtkApplicationWindow.gtk_application_window_new(instance);
        }



        public void SetDefaultSize(int width, int height)
        {
            GtkWindow.gtk_window_set_default_size(_instance, 200, 200);
        }

        public void SetModal(bool isModal)
        {
            GtkWindow.gtk_window_set_modal(Handle, isModal);
        }

        /// <summary>
        /// Gets or sets the window gravity
        /// </summary>
        /// <remarks>
        /// Window gravity defines the meaning of coordinates passed to Window.Move(). See
        /// Window.Move() and <see cref="Gravity"/> for more details.
        ///
        /// The default window gravity is Gravity.NorthWest which will typically
        /// “do what you mean.”
        /// </remarks>
        public Gravity Gravity
        {
            get => GtkWindow.gtk_window_get_gravity(Handle);

            set => GtkWindow.gtk_window_set_gravity(Handle, value);
        }

        /// <summary>
        /// Gets or sets whether the user can resize a window. Windows are user resizable by default.
        /// </summary>
        public bool IsResizable
        {
            get => GtkWindow.gtk_window_get_resizable(Handle);

            set => GtkWindow.gtk_window_set_resizable(Handle, value);
        }

        /// <summary>
        /// Activates the default widget for the window, unless the current focused widget has
        /// been configured to receive the default action (see Widget.SetReceivesDefault()),
        /// in which case the focused widget is activated.
        /// </summary>
        /// <returns>True if a widget got activated.</returns>
        public bool ActivateDefault()
        {
            return GtkWindow.gtk_window_activate_default(Handle);
        }

        /// <summary>
        /// Activates the current focused widget within the window.
        /// </summary>
        /// <returns>True if a widget got activated.</returns>
        public bool ActivateFocus()
        {
            return GtkWindow.gtk_window_activate_focus(Handle);
        }

        /// <summary>
        /// Requests that the window is closed, similar to what happens when a window manager close
        /// button is clicked.
        /// This function can be used with close buttons in custom titlebars.
        /// </summary>
        public void Close()
        {
            GtkWindow.gtk_window_close(Handle);
        }

        /// <summary>
        /// Asks to deiconify (i.e. unminimize) the specified window . Note that you shouldn’t
        /// assume the window is definitely deiconified afterward, because other entities
        /// (e.g. the user or window manager)) could iconify it again before your code which
        /// assumes deiconification gets to run.
        /// You can track iconification via the “window-state-event” signal on GtkWidget.
        /// </summary>
        public void DeIconify()
        {
            GtkWindow.gtk_window_deiconify(Handle);
        }

        /// <summary>
        /// Asks to iconify (i.e. minimize) the specified window . Note that you shouldn’t assume
        /// the window is definitely iconified afterward, because other entities (e.g. the user or
        /// window manager) could deiconify it again, or there may not be a window manager in which
        /// case iconification isn’t possible, etc. But normally the window will end up iconified.
        /// Just don’t write code that crashes if not.
        /// It’s permitted to call this function before showing a window, in which case the window
        /// will be iconified before it ever appears onscreen.
        /// You can track iconification via the “window-state-event” signal on Widget.
        /// </summary>
        public void Iconify()
        {
            GtkWindow.gtk_window_iconify(Handle);
        }

        /// <summary>
        /// Gets or sets the title of the window.
        /// </summary>
        /// <remarks>
        /// The title of a window will be displayed in its title bar; on the X Window System,
        /// the title bar is rendered by the window manager, so exactly how the title appears to
        /// users may vary according to a user’s exact configuration. The title should help a user
        /// distinguish this window from other windows they may have open. A good title might include
        /// the application name and current document filename, for example.
        /// </remarks>
        public string Title
        {
            get => GtkWindow.gtk_window_get_title(Handle);
            set => GtkWindow.gtk_window_set_title(Handle, value);
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
