using System;
using System.Runtime.InteropServices;

namespace gtk3_net
{
    public static class NativeMethods
    {
        public delegate void GClosureNotify();

        private const string GtkLib = "libgtk-3.so.0";
        private const string GObjLib = "libgobject-2.0.so.0";

        [DllImport(GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_application_new(string applicationId, GApplicationFlags flags);

        [DllImport(GObjLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint g_signal_connect_data(IntPtr instance, string detiledSignal, IntPtr handler,
            IntPtr data, GClosureNotify destroyData, GConnectFlags connectFlags);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern int g_application_run(IntPtr application, int argc, string[] argv);

        [DllImport(GtkLib)]
        public static extern void g_object_unref(IntPtr application);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_application_window_new(IntPtr application);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_window_set_title(IntPtr window, string title);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_default_size(IntPtr window, int width, int height);

        [DllImport(GtkLib)]
        public static extern void gtk_widget_show_all(IntPtr widget);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_button_box_new(GtkOrientation orientation);

        [DllImport(GtkLib)]
        public static extern void gtk_container_add(IntPtr container, IntPtr widget);

        [DllImport(GObjLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint g_signal_connect_swapped(IntPtr instance, string detailedSignal, IntPtr handler,
            IntPtr data);

        [DllImport(GtkLib)]
        public static extern void gtk_widget_destroy(IntPtr widget);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_button_new_with_label(string label);
    }

    [Flags]
    public enum GApplicationFlags
    {
        None
    }

    [Flags]
    public enum GConnectFlags
    {
        /// <summary>
        ///     whether the handler should be called before or after the default handler of the signal.
        /// </summary>
        ConnectAfter,

        /// <summary>
        ///     whether the instance and data should be swapped when calling the handler; see g_signal_connect_swapped() for an
        ///     example.
        /// </summary>
        ConnectSwapped
    }

    public enum GtkOrientation
    {
        Horizontal,
        Vertical
    }
}