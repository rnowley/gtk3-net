using System;
using Gtk3;

namespace builderExample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            GtkApplication.Init(args.Length, args);
            
            var builder = new UiBuilder();
            builder.AddFromFile("builder.ui", IntPtr.Zero);

            var window = builder.GetObject("window", l => new Window(l));
            window.ConnectSignal("destroy", GtkApplication.Quit, IntPtr.Zero, FreeData);

            var button = builder.GetObject("button1", l => new Button(l));
            button.ConnectSignal("clicked", PrintHello, IntPtr.Zero, FreeData);
            
            button = builder.GetObject("button2", l => new Button(l));
            button.ConnectSignal("clicked", PrintHello, IntPtr.Zero, FreeData);
            
            button = builder.GetObject("quit", l => new Button(l));
            button.ConnectSignal("clicked", GtkApplication.Quit, IntPtr.Zero, FreeData);
            
            GtkApplication.Run();
        }
        
        private static void FreeData()
        {
        }
        
        private static void PrintHello(IntPtr app, IntPtr data)
        {
            Console.WriteLine("Hello World!");
        }
    }
}