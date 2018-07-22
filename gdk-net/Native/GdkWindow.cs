using System;
using System.Runtime.InteropServices;

namespace Gdk.Native
{
    public static class GdkWindow
    {
        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_new();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_destroy();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern WindowType gdk_window_get_window_type();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_display();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_screen();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_visual();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_at_pointer();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_show();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_show_unraised();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_hide();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_is_destroyed();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_is_visible();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_is_viewable();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_is_input_only();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_is_shaped();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern WindowState gdk_window_get_state();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_withdraw();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_iconify();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_deiconify();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_stick();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_unstick();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_maximize();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_unmaximize();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_fullscreen();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_fullscreen_on_monitor();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_unfullscreen();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern FullScreenMode gdk_window_get_fullscreen_mode();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_fullscreen_mode();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_keep_above();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_keep_below();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_opacity();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_composited();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_composited();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_pass_through();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_pass_through();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_move();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_resize();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_move_resize();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_scroll();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_move_region();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_flush();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_has_native();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_ensure_native();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_reparent();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_raise();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_lower();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_restack();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_focus();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_register_dnd();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_begin_resize_drag();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_begin_resize_drag_for_device();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_begin_move_drag();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_begin_move_drag_for_device();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_show_window_menu();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_constrain_size();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_beep();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern int gdk_window_get_scale_factor();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_opaque_region();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_create_gl_context();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_mark_paint_from_clip();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_clip_region();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_begin_paint_rect();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_begin_paint_region();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_end_paint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_begin_draw_frame();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_end_draw_frame();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_visible_region();

        // void	(*GdkWindowInvalidateHandlerFunc) ()

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_invalidate_handler();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_invalidate_rect();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_invalidate_region();

        // gboolean	(*GdkWindowChildFunc) ()

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_invalidate_maybe_recurse();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_update_area();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_freeze_updates();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_thaw_updates();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_process_all_updates();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_process_updates();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_debug_updates();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_enable_synchronized_configure();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_configure_finished();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_frame_clock();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_user_data();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_override_redirect();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_accept_focus();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_accept_focus();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_focus_on_map();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_focus_on_map();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_add_filter();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_remove_filter();

        //GdkFilterReturn	(*GdkFilterFunc) ()

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_shape_combine_region();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_child_shapes();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_merge_child_shapes();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_input_shape_combine_region();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_child_input_shapes();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_merge_child_input_shapes();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_set_static_gravities();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_title();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_background();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_background_rgba();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_background_pattern();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_background_pattern();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_cursor();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_cursor();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_get_user_data();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_get_geometry();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_geometry_hints();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern int gdk_window_get_width();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern int gdk_window_get_height();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_icon_list();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_modal_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_modal_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_type_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern WindowTypeHint gdk_window_get_type_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_shadow_width();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_skip_taskbar_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_skip_pager_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_urgency_hint();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_get_position();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_get_root_origin();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_get_frame_extents();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern int gdk_window_get_origin();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_get_root_coords();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_pointer();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_device_position();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_device_position_double();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_parent();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_toplevel();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_children();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_children_with_user_data();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_peek_children();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern EventMask gdk_window_get_events();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_events();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_icon_name();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_transient_for();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_role();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_startup_id();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_group();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_group();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_decorations();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_decorations();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_functions();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_get_default_root_window();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_support_multidevice();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_support_multidevice();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_device_cursor();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_device_cursor();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern EventMask gdk_window_get_device_events();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_device_events();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern EventMask gdk_window_get_source_events();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_source_events();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern bool gdk_window_get_event_compression();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_set_event_compression();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_offscreen_window_get_surface();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_offscreen_window_set_embedder();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_offscreen_window_get_embedder();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_geometry_changed();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_coords_from_parent();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern void gdk_window_coords_to_parent();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_effective_parent();

        [DllImport(GdkGlobal.GdkLib)]
        public static extern IntPtr gdk_window_get_effective_toplevel();

    }
}
