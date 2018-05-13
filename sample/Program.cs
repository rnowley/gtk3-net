using System;
using Gtk3;

namespace sample
{

    public static class Program
    {
        public static void Main(string[] args)
        {
            var app1 = new Application("org.gtk.example", GApplicationFlags.None);
            app1.ConnectActivateSignal(Activate, FreeData);
            app1.Run(0, args);
            app1.Exit();
        }

        private static void FreeData()
        {
        }

        private static void Activate(IntPtr app, IntPtr data)
        {
            var window = new Window(app);
            window.Title = "Window";
            window.SetDefaultSize(200, 200);
            window.SetBorderWidth(10);

            var grid = new Grid();

            window.AddWidget(grid);

            var button = new Button("Button 1");
            button.ConnectClickedSignal(PrintHello, IntPtr.Zero, FreeData);
            grid.Attach(button, 0, 0, 1, 1);

            var toggleButton = new ToggleButton("Button 2");
            toggleButton.ConnectToggledSignal(PrintToggled,
                IntPtr.Zero, FreeData);
            grid.Attach(toggleButton, 1, 0, 1, 1);

            button = new Button("Quit");
            button.ConnectClickedSignalSwapped(WindowDestroy, window.Handle, FreeData);
            grid.Attach(button, 0, 1, 2, 1);
            window.Show();
        }

        private static void WindowDestroy(IntPtr app, IntPtr data)
        {
            NativeMethods.gtk_widget_destroy(data);
        }

        private static void PrintHello(IntPtr app, IntPtr data)
        {
            Console.WriteLine("Hello World!");
        }

        private static void PrintToggled(IntPtr app, IntPtr data)
        {
            Console.WriteLine("Toggled!");
        }
    }
}


//#define g_signal_connect_swapped(instance, detailed_signal, c_handler, data) \
//g_signal_connect_data ((instance), (detailed_signal), (c_handler), (data), NULL, G_CONNECT_SWAPPED)

//#define g_signal_connect(instance, detailed_signal, c_handler, data) \
//g_signal_connect_data ((instance), (detailed_signal), (c_handler), (data), NULL, (GConnectFlags) 0)

//#define g_signal_connect_after(instance, detailed_signal, c_handler, data) \
//g_signal_connect_data ((instance), (detailed_signal), (c_handler), (data), NULL, G_CONNECT_AFTER)
