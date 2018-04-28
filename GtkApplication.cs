namespace Gtk3
{
    public static class GtkApplication
    {
        public static void Init(int argc, string[] argv)
        {
            NativeMethods.gtk_init(argc, argv);
        }

        public static void Quit()
        {
            NativeMethods.gtk_main_quit();
        }

        public static void Run()
        {
            NativeMethods.gtk_main();
        }
    }
}