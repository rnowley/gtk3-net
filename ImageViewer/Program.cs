using System;
using System.ComponentModel;
using Gtk3;

namespace ImageViewer
{
    class Program
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
            var window = new Window(app) {Title = "Image Viewer"};

            var box = new Box(Orientation.Vertical, 5);
            var button = new Button("Open Image");
            var image = new Image();
            box.PackStart(image, true, true, 0);
            box.PackStart(button, false, false, 0);

            window.AddWidget(box);
            window.Show();
        }
    }
}
