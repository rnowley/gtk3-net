﻿using System;
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
        public static extern void gtk_window_set_title(IntPtr window, string title);

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
        public static extern void gtk_container_set_border_width(IntPtr instance, uint borderWidth);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_grid_new();

        [DllImport(GtkLib)]
        public static extern void gtk_grid_attach(IntPtr grid, IntPtr child, int left, int top, int width, int height);
        
        [DllImport(GtkLib)]
        public static extern void gtk_widget_destroy(IntPtr widget);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_button_new_with_label(string label);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_builder_new();

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern uint gtk_builder_add_from_file(IntPtr builder, string filename, IntPtr error);
        
        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_builder_get_object(IntPtr builder, string name);
        
        [DllImport(GtkLib)]
        public static extern void gtk_main();
        
        [DllImport(GtkLib)]
        public static extern void gtk_main_quit();
        
        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_init(int argc, string[] argv);
        
        [DllImport(GtkLib)]
        public static extern IntPtr gtk_window_new(WindowType type);
        
        [DllImport(GtkLib)]
        public static extern void gtk_window_set_modal(IntPtr window, int modal);
        
        [DllImport(GtkLib)]
        public static extern int gtk_window_get_resizable(IntPtr window);
        
        [DllImport(GtkLib)]
        public static extern void gtk_window_set_resizable(IntPtr window, int isResizable);
    }

}