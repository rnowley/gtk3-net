using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public class GtkProgressBar
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_progress_bar_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_progress_bar_pulse(IntPtr progressBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_progress_bar_set_fraction(IntPtr progressBar, double fraction);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_progress_bar_get_fraction(IntPtr progressBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_progress_bar_set_inverted(IntPtr progressBar, bool inverted);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_progress_bar_get_inverted(IntPtr progressBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_progress_bar_set_show_text(IntPtr progressBar, bool showText);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_progress_bar_get_show_text(IntPtr progressBar);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_progress_bar_set_text(IntPtr progressBar, string text);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_progress_bar_get_text(IntPtr progressBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern string gtk_progress_bar_set_ellipsize(IntPtr progressBar, EllipsizeMode mode);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern EllipsizeMode gtk_progress_bar_get_ellipsize(IntPtr progressBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_progress_bar_set_pulse_step(IntPtr progressBar, double fraction);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_progress_bar_get_pulse_step(IntPtr progressBar);
    }
}