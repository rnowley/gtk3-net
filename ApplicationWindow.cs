using System;

namespace Gtk3
{
    /// <summary>
    /// ApplicationWindow is a Window subclass that offers some extra functionality for
    /// better integration with Application features. Notably, it can handle both the
    /// application menu as well as the menubar. See gtk_application_set_app_menu() and
    /// gtk_application_set_menubar(). This class implements the GActionGroup and
    /// GActionMap interfaces, to let you add window-specific actions that will be
    /// exported by the associated GtkApplication, together with its application-wide
    /// actions. Window-specific actions are prefixed with the “win.” prefix and
    /// application-wide actions are prefixed with the “app.” prefix. Actions must be
    /// addressed with the prefixed name when referring to them from a MenuModel.
    ///
    /// Note that widgets that are placed inside a ApplicationWindow can also
    /// activate these actions, if they implement the Actionable interface. As with
    /// GtkApplication, the GDK lock will be acquired when processing actions arriving
    /// from other processes and should therefore be held when activating actions locally
    /// (if GDK threads are enabled). The settings “gtk-shell-shows-app-menu” and
    /// “gtk-shell-shows-menubar” tell GTK+ whether the desktop environment is showing the
    /// application menu and menubar models outside the application as part of the desktop
    /// shell. For instance, on OS X, both menus will be displayed remotely; on Windows
    /// neither will be. gnome-shell (starting with version 3.4) will display the
    /// application menu, but not the menubar. If the desktop environment does not display
    /// the menubar, then ApplicationWindow will automatically show a MenuBar for
    /// it. This behaviour can be overridden with the “show-menubar” property. If the
    /// desktop environment does not display the application menu, then it will
    /// automatically be included in the menubar or in the windows client-side decorations.
    /// </summary>
    public class ApplicationWindow : Window
    {
        private readonly IntPtr _instance;

        /// <summary>
        /// Creates a new ApplicationWindow.
        /// </summary>
        /// <param name="application">The <see cref="Application"/> that the widow is attached to.</param>
        public ApplicationWindow(Application application)
        {
            _instance = Native.GtkApplicationWindow.gtk_application_window_new(application.Handle);
        }

        /// <summary>
        /// Gets or sets whether the window will display a menubar for the app menu and menubar as needed.
        /// </summary>
        public bool ShowMenuBar
        {
            get => Native.GtkApplicationWindow.gtk_application_window_get_show_menubar(Handle);
            set => Native.GtkApplicationWindow.gtk_application_window_set_show_menubar(Handle, value);
        }

        /// <summary>
        /// Returns the unique ID of the window. If the window has not yet been added to
        /// a Application 0 is returned.
        /// </summary>
        public uint Id => Native.GtkApplicationWindow.gtk_application_window_get_id(Handle);

        internal IntPtr Handle => _instance;
    }
}
