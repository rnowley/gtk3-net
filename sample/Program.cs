using System;
using System.Runtime.InteropServices;
using gtk3_net;

namespace sample
{
    public delegate void CallBack(IntPtr app, IntPtr data);

    public delegate void CallBack2(IntPtr app);

    public static class Program
    {
        public static void Main(string[] args)
        {
            var app1 = new Application("org.gtk.example", GApplicationFlags.None);
            app1.ConnectSignal("activate", Activate, FreeData);
            var app = NativeMethods.gtk_application_new("org.gtk.example", GApplicationFlags.None);
            NativeMethods.g_signal_connect_data(app, "activate",
                Marshal.GetFunctionPointerForDelegate(new CallBack(Activate)),
                IntPtr.Zero, FreeData, GConnectFlags.ConnectAfter);
            NativeMethods.g_application_run(app, args.Length, args);
            NativeMethods.g_object_unref(app);
        }

        private static void FreeData()
        {
        }

        private static void Activate(IntPtr app, IntPtr data)
        {
            var window = new Window(app);
            window.SetTitle("Window");
            window.SetDefaultSize(200, 200);
            
            //var window = NativeMethods.gtk_application_window_new(app);
            //NativeMethods.gtk_window_set_title(window, "Window");
            //NativeMethods.gtk_window_set_default_size(window, 200, 200);

            var buttonBox = NativeMethods.gtk_button_box_new(GtkOrientation.Horizontal);
            NativeMethods.gtk_container_add(window, buttonBox);

            var button = NativeMethods.gtk_button_new_with_label("Hello World");
            NativeMethods.g_signal_connect_data(button, "clicked", Marshal.GetFunctionPointerForDelegate(
                    new CallBack(PrintHello)),
                IntPtr.Zero, FreeData, GConnectFlags.ConnectAfter);
            // Note g_signal_connect and g_signal_connect_swapped are macros around g_signal_connect_data.
            NativeMethods.g_signal_connect_data(button, "clicked", Marshal.GetFunctionPointerForDelegate(
                new CallBack2(WindowDestroy)), window, FreeData, GConnectFlags.ConnectSwapped);
            NativeMethods.gtk_container_add(buttonBox, button);

            NativeMethods.gtk_widget_show_all(window);
        }

        private static void WindowDestroy(IntPtr app)
        {
            NativeMethods.gtk_widget_destroy(app);
        }

        private static void PrintHello(IntPtr app, IntPtr data)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


//#define g_signal_connect_swapped(instance, detailed_signal, c_handler, data) \
//g_signal_connect_data ((instance), (detailed_signal), (c_handler), (data), NULL, G_CONNECT_SWAPPED)

//#define g_signal_connect(instance, detailed_signal, c_handler, data) \
//g_signal_connect_data ((instance), (detailed_signal), (c_handler), (data), NULL, (GConnectFlags) 0)

//#define g_signal_connect_after(instance, detailed_signal, c_handler, data) \
//g_signal_connect_data ((instance), (detailed_signal), (c_handler), (data), NULL, G_CONNECT_AFTER)