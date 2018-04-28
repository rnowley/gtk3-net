using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    // ReSharper disable once InconsistentNaming
    public static class GSList
    {
        public delegate void GDestroyNotify(IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_alloc();
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_append(IntPtr list, IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_prepend(IntPtr list, IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_insert(IntPtr list, IntPtr data, int position);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_insert_before(IntPtr list, IntPtr sibling, IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_remove(IntPtr list, IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_remove_link(IntPtr list, IntPtr link);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_delete_link(IntPtr list, IntPtr link);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_remove_all(IntPtr list, IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_free(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern void g_slist_free_full(IntPtr list, GDestroyNotify freeFunc);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_free_1(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern uint g_slist_length(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_copy(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_reverse(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_concat(IntPtr list1, IntPtr list2);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_last(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_nth(IntPtr list);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_nth_data(IntPtr list, uint n);
        
        [DllImport(GtkConstants.GLib)]
        public static extern IntPtr g_slist_find(IntPtr list, IntPtr data);
        
        [DllImport(GtkConstants.GLib)]
        public static extern int g_slist_position(IntPtr list, IntPtr link);
        
        [DllImport(GtkConstants.GLib)]
        public static extern int g_slist_index(IntPtr list, IntPtr data);
    }
}