using System;
using System.Runtime.InteropServices;
using Gdk;

namespace Gtk3.Native
{
    public static class GtkWindow
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_new(WindowType type);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_modal(IntPtr self, bool modal);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_resizable(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_resizable(IntPtr self, bool isResizable);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_title(IntPtr self, string title);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_default_size(IntPtr self, int width, int height);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_activate_focus(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_activate_default(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_gravity(IntPtr self, Gravity gravity);

        [DllImport(GtkConstants.GtkLib)]
        public static extern Gravity gtk_window_get_gravity(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_position(IntPtr self, WindowPosition window);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_transient_for(IntPtr self, IntPtr parent);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_attached_to(IntPtr self, IntPtr attachWindow);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_destroy_with_parent(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_hide_titlebar_when_maximized(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_is_active(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_is_maximized(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_has_toplevel_focus(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_list_toplevels();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_add_mnemonic(IntPtr self, uint keyVal, IntPtr target);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_remove_mnemonic(IntPtr self, uint keyVal, IntPtr target);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_mnemonic_activate(IntPtr self, uint keyVal,
            ModifierType modifier);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_focus(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_focus(IntPtr self, IntPtr focus);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_default_widget(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_default(IntPtr self, IntPtr defaultWidget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_present(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_present(IntPtr self, uint timestamp);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_close(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_iconify(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_deiconify(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_stick(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_unstick(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_maximize(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_unmaximize(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_fullscreen(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_unfullscreen(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_keep_above(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_keep_below(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_begin_resize_drag(IntPtr self, WindowEdge edge,
            int button, int rootX, int rootY, uint timestamp);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_begin_move_drag(IntPtr self, int button,
            int rootX, int rootY, uint timestamp);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_decorated(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_deletable(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_mnemonic_modifier(IntPtr self, ModifierType modifier);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_type_hint(IntPtr self, WindowTypeHint hint);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_skip_taskbar_hint(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_skip_pager_hint(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_urgency_hint(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_accept_focus(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_focus_on_map(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_startup_id(IntPtr self, string startupId);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_role(IntPtr self, string role);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_decorated(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_deletable(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_default_icon_list();

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_window_get_default_icon_name();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_get_default_size(IntPtr self, IntPtr width, IntPtr height);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_destroy_with_parent(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_hide_titlebar_when_maximized(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_icon(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_icon_list(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_window_get_icon_name(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern ModifierType gtk_window_get_mnemonic_modifier(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_modal(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_get_position(IntPtr self, IntPtr rootX, IntPtr rootY);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_window_get_role(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_get_size(IntPtr self, IntPtr width, IntPtr height);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_window_get_title(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_transient_for(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_attached_to(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern WindowTypeHint gtk_window_get_type_hint(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_skip_taskbar_hint(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_skip_pager_hint(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_urgency_hint(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_accept_focus(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_focus_on_map(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_group(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_has_group(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern WindowType gtk_window_get_window_type(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_move(IntPtr self, int x, int y);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_window_parse_geometry(IntPtr self, string geometry);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_reshow_with_initial_size(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_resize(IntPtr self, int width, int height);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_resize_to_geometry(IntPtr self, int width, int height);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_default_icon_list(IntPtr list);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_default_icon(IntPtr icon);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_window_set_default_icon_name(string name);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_icon(IntPtr self, IntPtr icon);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_icon_list(IntPtr self, IntPtr list);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_window_set_icon_name(IntPtr self, string name);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_auto_startup_notification(bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_window_get_opacity(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_opacity(IntPtr self, double opacity);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_mnemonics_visible(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_mnemonics_visible(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_focus_visible(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_focus_visible(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_get_has_resize_grip(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_has_resize_grip(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_window_resize_grip_is_visible(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_application(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_application(IntPtr self, IntPtr application);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_has_user_ref_count(IntPtr self, bool setting);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_window_set_titlebar(IntPtr self, IntPtr titleBar);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_get_titlebar(IntPtr self);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_window_set_interactive_debugging(bool enable);
    }
}
