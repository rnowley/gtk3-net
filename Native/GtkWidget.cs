﻿using System;
using System.Runtime.InteropServices;

namespace Gtk3.Native
{
    public static class GtkWidget
    {
        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_destroy(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_widget_in_destruction(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_unparent(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_size_request(IntPtr widget, GtkRequisition requisition);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_get_child_requisition(IntPtr widget, GtkRequisition requisition);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_show(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_show_now(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_queue_draw(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_queue_resize(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_queue_resize_no_redraw(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_hide(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_show_all(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_map(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_unmap(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_realize(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_unrealize(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_draw(IntPtr widget, IntPtr cr);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern void gtk_widget_set_name(IntPtr widget, string name);

        [DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
        public static extern string gtk_widget_get_name(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void  gtk_widget_pop_composite_child();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_push_composite_child();

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_queue_draw_area(IntPtr widget, int x,
                                                        int y, int width, int height);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_widget_is_focus(IntPtr widget);


        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_grab_focus(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_grab_default(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_set_sensitive(IntPtr widget, bool sensitive);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_set_parent(IntPtr widget, IntPtr parent);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_set_state(IntPtr widget, GtkStateType state);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_set_events(IntPtr widget, int events);

        [DllImport(GtkConstants.GtkLib)]
        public static extern int gtk_widget_get_events(IntPtr widget);

        [DllImport(GtkConstants.GtkLib)]
        public static extern void gtk_widget_add_events(IntPtr widget, int events);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_widget_is_ancestor(IntPtr widget, IntPtr ancestor);


        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_widget_translate_coordinates(IntPtr srcWidget, IntPtr destWidget,
                                                         int srcX, int srcY, out int destX, out int destY);

        [DllImport(GtkConstants.GtkLib)]
        public static extern bool gtk_widget_hide_on_delete(IntPtr widget);



        //[DllImport(GtkConstants.GtkLib)]                                                 //[DllImport(GtkConstants.GtkLib, CharSet = CharSet.Ansi)]
//        GtkWidget *         gtk_widget_new                      (GType type,
//                                                         const gchar *first_property_name,
//                                                         ...);
//void                gtk_widget_destroyed                (GtkWidget *widget,
//                                                         GtkWidget **widget_pointer);

//void                gtk_widget_size_allocate            (GtkWidget *widget,
//                                                         GtkAllocation *allocation);
//void                gtk_widget_add_accelerator          (GtkWidget *widget,
//                                                         const gchar *accel_signal,
//                                                         GtkAccelGroup *accel_group,
//                                                         guint accel_key,
//                                                         GdkModifierType accel_mods,
//                                                         GtkAccelFlags accel_flags);
//gboolean            gtk_widget_remove_accelerator       (GtkWidget *widget,
//                                                         GtkAccelGroup *accel_group,
//                                                         guint accel_key,
//                                                         GdkModifierType accel_mods);
//void                gtk_widget_set_accel_path           (GtkWidget *widget,
//                                                         const gchar *accel_path,
//                                                         GtkAccelGroup *accel_group);
//GList *             gtk_widget_list_accel_closures      (GtkWidget *widget);
//gboolean            gtk_widget_can_activate_accel       (GtkWidget *widget,
//                                                         guint signal_id);
//gboolean            gtk_widget_event                    (GtkWidget *widget,
//                                                         GdkEvent *event);
//gboolean            gtk_widget_activate                 (GtkWidget *widget);
//void                gtk_widget_reparent                 (GtkWidget *widget,
//                                                         GtkWidget *new_parent);
//gboolean            gtk_widget_intersect                (GtkWidget *widget,
//                                                         const GdkRectangle *area,
//                                                         GdkRectangle *intersection);

//void                gtk_widget_set_parent_window        (GtkWidget *widget,
//                                                         GdkWindow *parent_window);
//GdkWindow *         gtk_widget_get_parent_window        (GtkWidget *widget);
//void                gtk_widget_set_events               (GtkWidget *widget,
//                                                         gint events);
//gint                gtk_widget_get_events               (GtkWidget *widget);
//void                gtk_widget_add_events               (GtkWidget *widget,
//                                                         gint events);
//void                gtk_widget_set_device_events        (GtkWidget *widget,
//                                                         GdkDevice *device,
//                                                         GdkEventMask events);
//GdkEventMask        gtk_widget_get_device_events        (GtkWidget *widget,
//                                                         GdkDevice *device);
//void                gtk_widget_add_device_events        (GtkWidget *widget,
//                                                         GdkDevice *device,
//                                                         GdkEventMask events);
//void                gtk_widget_set_device_enabled       (GtkWidget *widget,
//                                                         GdkDevice *device,
//                                                         gboolean enabled);
//gboolean            gtk_widget_get_device_enabled       (GtkWidget *widget,
//                                                         GdkDevice *device);
//GtkWidget *         gtk_widget_get_toplevel             (GtkWidget *widget);
//GtkWidget *         gtk_widget_get_ancestor             (GtkWidget *widget,
//                                                         GType widget_type);
//GdkVisual *         gtk_widget_get_visual               (GtkWidget *widget);
//void                gtk_widget_set_visual               (GtkWidget *widget,
//                                                         GdkVisual *visual);
//void                gtk_widget_get_pointer              (GtkWidget *widget,
//                                                         gint *x,
//                                                         gint *y);
//void                gtk_widget_set_style                (GtkWidget *widget,
//                                                         GtkStyle *style);
//void                gtk_widget_ensure_style             (GtkWidget *widget);
//GtkStyle *          gtk_widget_get_style                (GtkWidget *widget);
//void                gtk_widget_reset_rc_styles          (GtkWidget *widget);
//GtkStyle *          gtk_widget_get_default_style        (void);
//void                gtk_widget_set_direction            (GtkWidget *widget,
//                                                         GtkTextDirection dir);
//enum                GtkTextDirection;
//GtkTextDirection    gtk_widget_get_direction            (GtkWidget *widget);
//void                gtk_widget_set_default_direction    (GtkTextDirection dir);
//GtkTextDirection    gtk_widget_get_default_direction    (void);
//void                gtk_widget_shape_combine_region     (GtkWidget *widget,
//                                                         cairo_region_t *region);
//void                gtk_widget_input_shape_combine_region
//                                                        (GtkWidget *widget,
//                                                         cairo_region_t *region);
//void                gtk_widget_path                     (GtkWidget *widget,
//                                                         guint *path_length,
//                                                         gchar **path,
//                                                         gchar **path_reversed);
//void                gtk_widget_class_path               (GtkWidget *widget,
//                                                         guint *path_length,
//                                                         gchar **path,
//                                                         gchar **path_reversed);
//gchar *             gtk_widget_get_composite_name       (GtkWidget *widget);
//void                gtk_widget_override_background_color
//                                                        (GtkWidget *widget,
//                                                         GtkStateFlags state,
//                                                         const GdkRGBA *color);
//void                gtk_widget_override_color           (GtkWidget *widget,
//                                                         GtkStateFlags state,
//                                                         const GdkRGBA *color);
//void                gtk_widget_override_font            (GtkWidget *widget,
//                                                         const PangoFontDescription *font_desc);
//void                gtk_widget_override_symbolic_color  (GtkWidget *widget,
//                                                         const gchar *name,
//                                                         const GdkRGBA *color);
//void                gtk_widget_override_cursor          (GtkWidget *widget,
//                                                         const GdkRGBA *cursor,
//                                                         const GdkRGBA *secondary_cursor);
//void                gtk_widget_modify_style             (GtkWidget *widget,
//                                                         GtkRcStyle *style);
//GtkRcStyle *        gtk_widget_get_modifier_style       (GtkWidget *widget);
//void                gtk_widget_modify_fg                (GtkWidget *widget,
//                                                         GtkStateType state,
//                                                         const GdkColor *color);
//void                gtk_widget_modify_bg                (GtkWidget *widget,
//                                                         GtkStateType state,
//                                                         const GdkColor *color);
//void                gtk_widget_modify_text              (GtkWidget *widget,
//                                                         GtkStateType state,
//                                                         const GdkColor *color);
//void                gtk_widget_modify_base              (GtkWidget *widget,
//                                                         GtkStateType state,
//                                                         const GdkColor *color);
//void                gtk_widget_modify_font              (GtkWidget *widget,
//                                                         PangoFontDescription *font_desc);
//void                gtk_widget_modify_cursor            (GtkWidget *widget,
//                                                         const GdkColor *primary,
//                                                         const GdkColor *secondary);
//PangoContext *      gtk_widget_create_pango_context     (GtkWidget *widget);
//PangoContext *      gtk_widget_get_pango_context        (GtkWidget *widget);
//PangoLayout *       gtk_widget_create_pango_layout      (GtkWidget *widget,
//                                                         const gchar *text);
//GdkPixbuf *         gtk_widget_render_icon              (GtkWidget *widget,
//                                                         const gchar *stock_id,
//                                                         GtkIconSize size,
//                                                         const gchar *detail);
//GdkPixbuf *         gtk_widget_render_icon_pixbuf       (GtkWidget *widget,
//                                                         const gchar *stock_id,
//                                                         GtkIconSize size);

//void                gtk_widget_queue_draw_region        (GtkWidget *widget,
//                                                         const cairo_region_t *region);
//void                gtk_widget_set_app_paintable        (GtkWidget *widget,
//                                                         gboolean app_paintable);
//void                gtk_widget_set_double_buffered      (GtkWidget *widget,
//                                                         gboolean double_buffered);
//void                gtk_widget_set_redraw_on_allocate   (GtkWidget *widget,
//                                                         gboolean redraw_on_allocate);
//void                gtk_widget_set_composite_name       (GtkWidget *widget,
//                                                         const gchar *name);
//gboolean            gtk_widget_mnemonic_activate        (GtkWidget *widget,
//                                                         gboolean group_cycling);
//void                gtk_widget_class_install_style_property
//                                                        (GtkWidgetClass *klass,
//                                                         GParamSpec *pspec);
//void                gtk_widget_class_install_style_property_parser
//                                                        (GtkWidgetClass *klass,
//                                                         GParamSpec *pspec,
//                                                         GtkRcPropertyParser parser);
//GParamSpec *        gtk_widget_class_find_style_property
//                                                        (GtkWidgetClass *klass,
//                                                         const gchar *property_name);
//GParamSpec **       gtk_widget_class_list_style_properties
//                                                        (GtkWidgetClass *klass,
//                                                         guint *n_properties);
//cairo_region_t *    gtk_widget_region_intersect         (GtkWidget *widget,
//                                                         const cairo_region_t *region);
//gint                gtk_widget_send_expose              (GtkWidget *widget,
//                                                         GdkEvent *event);
//gboolean            gtk_widget_send_focus_change        (GtkWidget *widget,
//                                                         GdkEvent *event);
//void                gtk_widget_style_get                (GtkWidget *widget,
//                                                         const gchar *first_property_name,
//                                                         ...);
//void                gtk_widget_style_get_property       (GtkWidget *widget,
//                                                         const gchar *property_name,
//                                                         GValue *value);
//void                gtk_widget_style_get_valist         (GtkWidget *widget,
//                                                         const gchar *first_property_name,
//                                                         va_list var_args);
//void                gtk_widget_style_attach             (GtkWidget *widget);
//void                gtk_widget_class_set_accessible_type
//                                                        (GtkWidgetClass *widget_class,
//                                                         GType type);
//void                gtk_widget_class_set_accessible_role
//                                                        (GtkWidgetClass *widget_class,
//                                                         AtkRole role);
//AtkObject *         gtk_widget_get_accessible           (GtkWidget *widget);
//gboolean            gtk_widget_child_focus              (GtkWidget *widget,
//                                                         GtkDirectionType direction);
//void                gtk_widget_child_notify             (GtkWidget *widget,
//                                                         const gchar *child_property);
//void                gtk_widget_freeze_child_notify      (GtkWidget *widget);
//gboolean            gtk_widget_get_child_visible        (GtkWidget *widget);
//GtkWidget *         gtk_widget_get_parent               (GtkWidget *widget);
//GtkSettings *       gtk_widget_get_settings             (GtkWidget *widget);
//GtkClipboard *      gtk_widget_get_clipboard            (GtkWidget *widget,
//                                                         GdkAtom selection);
//GdkDisplay *        gtk_widget_get_display              (GtkWidget *widget);
//GdkWindow *         gtk_widget_get_root_window          (GtkWidget *widget);
//GdkScreen *         gtk_widget_get_screen               (GtkWidget *widget);
//gboolean            gtk_widget_has_screen               (GtkWidget *widget);
//void                gtk_widget_get_size_request         (GtkWidget *widget,
//                                                         gint *width,
//                                                         gint *height);
//void                gtk_widget_set_child_visible        (GtkWidget *widget,
//                                                         gboolean is_visible);
//void                gtk_widget_set_size_request         (GtkWidget *widget,
//                                                         gint width,
//                                                         gint height);
//void                gtk_widget_thaw_child_notify        (GtkWidget *widget);
//void                gtk_widget_set_no_show_all          (GtkWidget *widget,
//                                                         gboolean no_show_all);
//gboolean            gtk_widget_get_no_show_all          (GtkWidget *widget);
//GList *             gtk_widget_list_mnemonic_labels     (GtkWidget *widget);
//void                gtk_widget_add_mnemonic_label       (GtkWidget *widget,
//                                                         GtkWidget *label);
//void                gtk_widget_remove_mnemonic_label    (GtkWidget *widget,
//                                                         GtkWidget *label);
//gboolean            gtk_widget_is_composited            (GtkWidget *widget);
//void                gtk_widget_error_bell               (GtkWidget *widget);
//gboolean            gtk_widget_keynav_failed            (GtkWidget *widget,
//                                                         GtkDirectionType direction);
//gchar *             gtk_widget_get_tooltip_markup       (GtkWidget *widget);
//void                gtk_widget_set_tooltip_markup       (GtkWidget *widget,
//                                                         const gchar *markup);
//gchar *             gtk_widget_get_tooltip_text         (GtkWidget *widget);
//void                gtk_widget_set_tooltip_text         (GtkWidget *widget,
//                                                         const gchar *text);
//GtkWindow *         gtk_widget_get_tooltip_window       (GtkWidget *widget);
//void                gtk_widget_set_tooltip_window       (GtkWidget *widget,
//                                                         GtkWindow *custom_window);
//gboolean            gtk_widget_get_has_tooltip          (GtkWidget *widget);
//void                gtk_widget_set_has_tooltip          (GtkWidget *widget,
//                                                         gboolean has_tooltip);
//void                gtk_widget_trigger_tooltip_query    (GtkWidget *widget);
//GdkWindow *         gtk_widget_get_window               (GtkWidget *widget);
//gboolean            gtk_cairo_should_draw_window        (cairo_t *cr,
//                                                         GdkWindow *window);
//void                gtk_cairo_transform_to_window       (cairo_t *cr,
//                                                         GtkWidget *widget,
//                                                         GdkWindow *window);
//int                 gtk_widget_get_allocated_width      (GtkWidget *widget);
//int                 gtk_widget_get_allocated_height     (GtkWidget *widget);
//void                gtk_widget_get_allocation           (GtkWidget *widget,
//                                                         GtkAllocation *allocation);
//void                gtk_widget_set_allocation           (GtkWidget *widget,
//                                                         const GtkAllocation *allocation);
//gboolean            gtk_widget_get_app_paintable        (GtkWidget *widget);
//gboolean            gtk_widget_get_can_default          (GtkWidget *widget);
//void                gtk_widget_set_can_default          (GtkWidget *widget,
//                                                         gboolean can_default);
//gboolean            gtk_widget_get_can_focus            (GtkWidget *widget);
//void                gtk_widget_set_can_focus            (GtkWidget *widget,
//                                                         gboolean can_focus);
//gboolean            gtk_widget_get_double_buffered      (GtkWidget *widget);
//gboolean            gtk_widget_get_has_window           (GtkWidget *widget);
//void                gtk_widget_set_has_window           (GtkWidget *widget,
//                                                         gboolean has_window);
//gboolean            gtk_widget_get_sensitive            (GtkWidget *widget);
//gboolean            gtk_widget_is_sensitive             (GtkWidget *widget);
//GtkStateType        gtk_widget_get_state                (GtkWidget *widget);
//gboolean            gtk_widget_get_visible              (GtkWidget *widget);
//void                gtk_widget_set_visible              (GtkWidget *widget,
//                                                         gboolean visible);
//void                gtk_widget_set_state_flags          (GtkWidget *widget,
//                                                         GtkStateFlags flags,
//                                                         gboolean clear);
//void                gtk_widget_unset_state_flags        (GtkWidget *widget,
//                                                         GtkStateFlags flags);
//GtkStateFlags       gtk_widget_get_state_flags          (GtkWidget *widget);
//gboolean            gtk_widget_has_default              (GtkWidget *widget);
//gboolean            gtk_widget_has_focus                (GtkWidget *widget);
//gboolean            gtk_widget_has_visible_focus        (GtkWidget *widget);
//gboolean            gtk_widget_has_grab                 (GtkWidget *widget);
//gboolean            gtk_widget_has_rc_style             (GtkWidget *widget);
//gboolean            gtk_widget_is_drawable              (GtkWidget *widget);
//gboolean            gtk_widget_is_toplevel              (GtkWidget *widget);
//void                gtk_widget_set_window               (GtkWidget *widget,
//                                                         GdkWindow *window);
//void                gtk_widget_set_receives_default     (GtkWidget *widget,
//                                                         gboolean receives_default);
//gboolean            gtk_widget_get_receives_default     (GtkWidget *widget);
//void                gtk_widget_set_support_multidevice  (GtkWidget *widget,
//                                                         gboolean support_multidevice);
//gboolean            gtk_widget_get_support_multidevice  (GtkWidget *widget);
//void                gtk_widget_set_realized             (GtkWidget *widget,
//                                                         gboolean realized);
//gboolean            gtk_widget_get_realized             (GtkWidget *widget);
//void                gtk_widget_set_mapped               (GtkWidget *widget,
//                                                         gboolean mapped);
//gboolean            gtk_widget_get_mapped               (GtkWidget *widget);
//void                gtk_widget_get_requisition          (GtkWidget *widget,
//                                                         GtkRequisition *requisition);
//gboolean            gtk_widget_device_is_shadowed       (GtkWidget *widget,
//                                                         GdkDevice *device);
//
//GtkWidgetPath *     gtk_widget_get_path                 (GtkWidget *widget);
//GtkStyleContext *   gtk_widget_get_style_context        (GtkWidget *widget);
//void                gtk_widget_reset_style              (GtkWidget *widget);
//
//GtkRequisition *    gtk_requisition_new                 (void);
//GtkRequisition *    gtk_requisition_copy                (const GtkRequisition *requisition);
//void                gtk_requisition_free                (GtkRequisition *requisition);
//
//enum                GtkSizeRequestMode;
//struct              GtkRequestedSize;
//void                gtk_widget_get_preferred_height     (GtkWidget *widget,
//                                                         gint *minimum_height,
//                                                         gint *natural_height);
//void                gtk_widget_get_preferred_width      (GtkWidget *widget,
//                                                         gint *minimum_width,
//                                                         gint *natural_width);
//void                gtk_widget_get_preferred_height_for_width
//                                                        (GtkWidget *widget,
//                                                         gint width,
//                                                         gint *minimum_height,
//                                                         gint *natural_height);
//void                gtk_widget_get_preferred_width_for_height
//                                                        (GtkWidget *widget,
//                                                         gint height,
//                                                         gint *minimum_width,
//                                                         gint *natural_width);
//GtkSizeRequestMode  gtk_widget_get_request_mode         (GtkWidget *widget);
//void                gtk_widget_get_preferred_size       (GtkWidget *widget,
//                                                         GtkRequisition *minimum_size,
//                                                         GtkRequisition *natural_size);
//gint                gtk_distribute_natural_allocation   (gint extra_space,
//                                                         guint n_requested_sizes,
//                                                         GtkRequestedSize *sizes);
//
//enum                GtkAlign;
//GtkAlign            gtk_widget_get_halign               (GtkWidget *widget);
//void                gtk_widget_set_halign               (GtkWidget *widget,
//                                                         GtkAlign align);
//GtkAlign            gtk_widget_get_valign               (GtkWidget *widget);
//void                gtk_widget_set_valign               (GtkWidget *widget,
//                                                         GtkAlign align);
//gint                gtk_widget_get_margin_left          (GtkWidget *widget);
//void                gtk_widget_set_margin_left          (GtkWidget *widget,
//                                                         gint margin);
//gint                gtk_widget_get_margin_right         (GtkWidget *widget);
//void                gtk_widget_set_margin_right         (GtkWidget *widget,
//                                                         gint margin);
//gint                gtk_widget_get_margin_top           (GtkWidget *widget);
//void                gtk_widget_set_margin_top           (GtkWidget *widget,
//                                                         gint margin);
//gint                gtk_widget_get_margin_bottom        (GtkWidget *widget);
//void                gtk_widget_set_margin_bottom        (GtkWidget *widget,
//                                                         gint margin);
//
//gboolean            gtk_widget_get_hexpand              (GtkWidget *widget);
//void                gtk_widget_set_hexpand              (GtkWidget *widget,
//                                                         gboolean expand);
//gboolean            gtk_widget_get_hexpand_set          (GtkWidget *widget);
//void                gtk_widget_set_hexpand_set          (GtkWidget *widget,
//                                                         gboolean set);
//gboolean            gtk_widget_get_vexpand              (GtkWidget *widget);
//void                gtk_widget_set_vexpand              (GtkWidget *widget,
//                                                         gboolean expand);
//gboolean            gtk_widget_get_vexpand_set          (GtkWidget *widget);
//void                gtk_widget_set_vexpand_set          (GtkWidget *widget,
//                                                         gboolean set);
//void                gtk_widget_queue_compute_expand     (GtkWidget *widget);
//gboolean            gtk_widget_compute_expand           (GtkWidget *widget,
    }
}
