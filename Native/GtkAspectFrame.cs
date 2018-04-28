using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkAspectFrame
    {
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_aspect_frame_new(string label, float xAlign, 
            float yAlign, float ratio, bool obeyChild);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_aspect_frame_set(IntPtr self, string label, float xAlign, 
            float yAlign, float ratio, bool obeyChild);
    }
}