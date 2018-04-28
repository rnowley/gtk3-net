using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public class GtkComboBox
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_combo_box_new();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_combo_box_new_with_entry();
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_combo_box_new_with_model(IntPtr model);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_combo_box_new_with_model_and_entry(IntPtr model);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_combo_box_new_with_area(IntPtr area);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern IntPtr gtk_combo_box_new_with_area_and_entry(IntPtr area);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_combo_box_get_wrap_width(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_wrap_width(IntPtr self, int width);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_combo_box_get_row_span_column(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_row_span_column(IntPtr self, int width);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_combo_box_get_column_span_column(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_column_span_column(IntPtr self, int columnSpan);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_combo_box_get_active(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_active(IntPtr self, int index);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_combo_box_get_id_column(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_id_column(IntPtr self, int idColumn);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_combo_box_get_active_id(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_combo_box_set_active_id(IntPtr self, string activeId);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_add_tearoffs(IntPtr self, bool addTearOffs);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_combo_box_get_add_tearoffs(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_combo_box_set_title(IntPtr self, string title);
        
        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_combo_box_get_title(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_focus_on_click(IntPtr self, bool focusOnClick);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_combo_box_get_focus_on_click(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_button_sensitivity(IntPtr self, SensitivityType sensitivity);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern SensitivityType gtk_combo_box_get_button_sensitivity(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_combo_box_get_has_entry(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_entry_text_column(IntPtr self, int textColumn);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_combo_box_get_entry_text_column(IntPtr self);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_combo_box_set_popup_fixed_width(IntPtr self, bool fixedWidth);
        
        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_combo_box_get_popup_fixed_width(IntPtr self);
    }
}