using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkApplication
    {
        public delegate void GClosureNotify();

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_application_new(string applicationId, GApplicationFlags flags);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_application_add_window(IntPtr self, IntPtr window);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_application_remove_window(IntPtr self, IntPtr window);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_application_get_windows(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_application_get_window_by_id(IntPtr self, uint id);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_application_get_active_window(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint gtk_application_inhibit(IntPtr self, IntPtr window,
            ApplicationInhibitFlags flags, string reason);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint gtk_application_uninhibit(IntPtr self, uint cookie);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_application_is_inhibited(IntPtr self, ApplicationInhibitFlags flags);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool gtk_application_prefers_app_menu(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_application_get_app_menu(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_application_set_app_menu(IntPtr self, IntPtr appMenu);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr gtk_application_get_menubar(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern void gtk_application_set_menubar(IntPtr self, IntPtr menuBar);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_application_get_menu_by_id(IntPtr self, string id);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void gtk_application_add_accelerator(IntPtr self, string accelerator,
            string actionName, IntPtr parameter);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void gtk_application_remove_accelerator(IntPtr self,
            string actionName, IntPtr parameter);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern string[] gtk_application_list_action_descriptions(IntPtr self);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern string[] gtk_application_get_accels_for_action(IntPtr self, string detailedActionName);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void gtk_application_set_accels_for_action(IntPtr self,
            string actionName, string accels);

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern string[] gtk_application_get_actions_for_accel(IntPtr self,
            string accel);
    }
}
