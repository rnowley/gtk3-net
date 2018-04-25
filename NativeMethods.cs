using System;
using System.Runtime.InteropServices;
using gtk3_net.Native;

namespace gtk3_net
{
    public static class NativeMethods
    {
        public delegate void GClosureNotify();

        [DllImport(GtkConstants.GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_application_new(string applicationId, GApplicationFlags flags);

        [DllImport(GtkConstants.GObjLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint g_signal_connect_data(IntPtr instance, string detiledSignal, IntPtr handler,
            IntPtr data, GClosureNotify destroyData, GConnectFlags connectFlags);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern int g_application_run(IntPtr application, int argc, string[] argv);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void g_object_unref(IntPtr application);

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_application_window_new(IntPtr application);

        

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_show_all(IntPtr widget);

        

        

        [DllImport(GtkConstants.GObjLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint g_signal_connect_swapped(IntPtr instance, string detailedSignal, IntPtr handler,
            IntPtr data);

        

        /*[DllImport(GtkLib)]
        public static extern IntPtr gtk_grid_new();

        [DllImport(GtkLib)]
        public static extern void gtk_grid_attach(IntPtr grid, IntPtr child, int left, int top, int width, int height);*/

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_destroy(IntPtr widget);

        

		[DllImport(GtkConstants.GtkLib)]
		public static extern IntPtr gtk_flow_box_new();

		[DllImport(GtkConstants.GtkLib)]
		public static extern void gtk_flow_box_insert(IntPtr box, IntPtr widget, int positition);

		

		[DllImport(GtkConstants.GtkLib)]
		public static extern uint gtk_flow_box_get_column_spacing(IntPtr box);

		[DllImport(GtkConstants.GtkLib)]
		public static extern void gtk_flow_box_set_column_spacing(IntPtr box, uint spacing);


		[DllImport(GtkConstants.GtkLib)]
		public static extern uint gtk_flow_box_get_row_spacing(IntPtr box);

		[DllImport(GtkConstants.GtkLib)]
		public static extern void gtk_flow_box_set_row_spacing(IntPtr box, uint spacing);

		[DllImport(GtkConstants.GtkLib)]
		public static extern bool gtk_flow_box_get_homogeneous(IntPtr box);

		[DllImport(GtkConstants.GtkLib)]
		public static extern void gtk_flow_box_set_homogeneous(IntPtr box, bool isHomogeneous);

		[DllImport(GtkConstants.GtkLib)]
		public static extern uint gtk_flow_box_get_min_children_per_line(IntPtr box);

		[DllImport(GtkConstants.GtkLib)]
		public static extern void gtk_flow_box_set_min_children_per_line(IntPtr box, uint numberOfChildren);


		[DllImport(GtkConstants.GtkLib)]
		public static extern uint gtk_flow_box_get_max_children_per_line(IntPtr box);

		[DllImport(GtkConstants.GtkLib)]
		public static extern void gtk_flow_box_set_max_children_per_line(IntPtr box, uint numberOfChildren);


        

		

        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_builder_new();

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern uint gtk_builder_add_from_file(IntPtr builder, string filename, IntPtr error);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_builder_get_object(IntPtr builder, string name);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_main();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_main_quit();
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_init(int argc, string[] argv);
        
        

    }

}
