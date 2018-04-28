using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkLevelBar
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_level_bar_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_level_bar_new_for_interval(double minValue, double maxValue);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_level_bar_set_mode(IntPtr levelBar, LevelBarMode mode);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern LevelBarMode gtk_level_bar_get_mode(IntPtr levelBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_level_bar_set_value(IntPtr levelBar, double value);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_level_bar_get_value(IntPtr levelBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_level_bar_set_min_value(IntPtr levelBar, double value);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_level_bar_get_min_value(IntPtr levelBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_level_bar_set_max_value(IntPtr levelBar, double value);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern double gtk_level_bar_get_max_value(IntPtr levelBar);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_level_bar_set_inverted(IntPtr levelBar, bool inverted);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_level_bar_get_inverted(IntPtr levelBar);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_level_bar_add_offset_value(IntPtr levelBar, string name, double value);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_level_bar_remove_offset_value(IntPtr levelBar, string name);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern bool gtk_level_bar_get_offset_value(IntPtr levelBar, string name, IntPtr value);
    }
}