using System;
using System.Runtime.InteropServices;

namespace gtk3_net
{
    public static class NativeMethods
    {
        public delegate void GClosureNotify();

        private const string GtkLib = "libgtk-3.so.0";
        private const string GObjLib = "libgobject-2.0.so.0";

        [DllImport(GtkLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_application_new(string applicationId, GApplicationFlags flags);

        [DllImport(GObjLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint g_signal_connect_data(IntPtr instance, string detiledSignal, IntPtr handler,
            IntPtr data, GClosureNotify destroyData, GConnectFlags connectFlags);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern int g_application_run(IntPtr application, int argc, string[] argv);

        [DllImport(GtkLib)]
        public static extern void g_object_unref(IntPtr application);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_application_window_new(IntPtr application);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_title(IntPtr window, string title);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_window_set_default_size(IntPtr window, int width, int height);

        [DllImport(GtkLib)]
        public static extern void gtk_widget_show_all(IntPtr widget);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_button_box_new(GtkOrientation orientation);

        [DllImport(GtkLib)]
        public static extern void gtk_container_add(IntPtr container, IntPtr widget);

        [DllImport(GObjLib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern uint g_signal_connect_swapped(IntPtr instance, string detailedSignal, IntPtr handler,
            IntPtr data);

        [DllImport(GtkLib)]
        public static extern void gtk_container_set_border_width(IntPtr instance, uint borderWidth);

        [DllImport(GtkLib)]
        public static extern IntPtr gtk_grid_new();

        [DllImport(GtkLib)]
        public static extern void gtk_grid_attach(IntPtr grid, IntPtr child, int left, int top, int width, int height);

        [DllImport(GtkLib)]
        public static extern void gtk_widget_destroy(IntPtr widget);

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_button_new_with_label(string label);

<<<<<<< HEAD
		[DllImport(GtkLib)]
		public static extern IntPtr gtk_flow_box_new();

		[DllImport(GtkLib)]
		public static extern void gtk_flow_box_insert(IntPtr box, IntPtr widget, int positition);

		[DllImport(GtkLib)]
		public static extern IntPtr gtk_adjustment_new(double value, double lower, double upper,
				double stepIncrement, double pageIncrement, double pageSize);

		[DllImport(GtkLib)]
		public static extern double gtk_adjustment_get_value(IntPtr adjustment);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_set_value(IntPtr adjustment, double value);


		[DllImport(GtkLib)]
		public static extern double gtk_adjustment_get_page_size(IntPtr adjustment);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_set_page_size(IntPtr adjustment, double pageSize);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_clamp_page(IntPtr adjustment, double lower, double upper);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_configure(IntPtr adjustment, double value, double lower,
				double upper, double stepIncrement, double pageIncrement, double pageSize);

		[DllImport(GtkLib)]
		public static extern double gtk_adjustment_get_page_increment(IntPtr adjustment);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_set_page_increment(IntPtr adjustment, double pageIncrement);

		[DllImport(GtkLib)]
		public static extern double gtk_adjustment_get_step_increment(IntPtr adjustment);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_set_step_increment(IntPtr adjustment, double stepIncrement);


		[DllImport(GtkLib)]
		public static extern double gtk_adjustment_get_lower(IntPtr adjustment);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_set_lower(IntPtr adjustment, double lower);

		[DllImport(GtkLib)]
		public static extern double gtk_adjustment_get_upper(IntPtr adjustment);

		[DllImport(GtkLib)]
		public static extern void gtk_adjustment_set_upper(IntPtr adjustment, double upper);

		[DllImport(GtkLib)]
		public static extern uint gtk_flow_box_get_column_spacing(IntPtr box);

		[DllImport(GtkLib)]
		public static extern void gtk_flow_box_set_column_spacing(IntPtr box, uint spacing);


		[DllImport(GtkLib)]
		public static extern uint gtk_flow_box_get_row_spacing(IntPtr box);

		[DllImport(GtkLib)]
		public static extern void gtk_flow_box_set_row_spacing(IntPtr box, uint spacing);

		[DllImport(GtkLib)]
		public static extern bool gtk_flow_box_get_homogeneous(IntPtr box);

		[DllImport(GtkLib)]
		public static extern void gtk_flow_box_set_homogeneous(IntPtr box, bool isHomogeneous);

		[DllImport(GtkLib)]
		public static extern uint gtk_flow_box_get_min_children_per_line(IntPtr box);

		[DllImport(GtkLib)]
		public static extern void gtk_flow_box_set_min_children_per_line(IntPtr box, uint numberOfChildren);


		[DllImport(GtkLib)]
		public static extern uint gtk_flow_box_get_max_children_per_line(IntPtr box);

		[DllImport(GtkLib)]
		public static extern void gtk_flow_box_set_max_children_per_line(IntPtr box, uint numberOfChildren);


        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_entry_buffer_new(string initialCharacters, int numberOfInitialCharacters);

		[DllImport(GtkLib, CharSet = CharSet.Ansi)]
		public static extern string gtk_entry_buffer_get_text(IntPtr buffer);

		[DllImport(GtkLib, CharSet = CharSet.Ansi)]
		public static extern string gtk_entry_buffer_set_text(IntPtr buffer, string text, int textLength);

		[DllImport(GtkLib)]
		public static extern int gtk_entry_buffer_get_max_length(IntPtr buffer);

		[DllImport(GtkLib)]
		public static extern void gtk_entry_buffer_set_max_length(IntPtr buffer, int maxLength);

		[DllImport(GtkLib)]
		public static extern IntPtr gtk_entry_new();
=======
        [DllImport(GtkLib)]
        public static extern IntPtr gtk_builder_new();

        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern uint gtk_builder_add_from_file(IntPtr builder, string filename, IntPtr error);
        
        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern IntPtr gtk_builder_get_object(IntPtr builder, string name);
        
        [DllImport(GtkLib)]
        public static extern void gtk_main();
        
        [DllImport(GtkLib)]
        public static extern void gtk_main_quit();
        
        [DllImport(GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_init(int argc, string[] argv);
        
        [DllImport(GtkLib)]
        public static extern IntPtr gtk_window_new(WindowType type);
        
        [DllImport(GtkLib)]
        public static extern void gtk_window_set_modal(IntPtr window, int modal);
        
        [DllImport(GtkLib)]
        public static extern int gtk_window_get_resizable(IntPtr window);
        
        [DllImport(GtkLib)]
        public static extern void gtk_window_set_resizable(IntPtr window, int isResizable);
>>>>>>> df10237a9b415f5e08bc33e517f5de573363650c
    }

}
