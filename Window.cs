﻿using System;

namespace gtk3_net
{
    public class Window : Container
    {
        private readonly IntPtr _instance;
        
        public Window() {}

        public Window(WindowType type)
        {
            _instance = NativeMethods.gtk_window_new(type);
        }

        public Window(IntPtr instance)
        {
            _instance = instance;
        }

        public void SetBorderWidth(uint borderWidth) {
            NativeMethods.gtk_container_set_border_width(Handle, borderWidth);
        }

        public void SetDefaultSize(int width, int height)
        {
            NativeMethods.gtk_window_set_default_size(_instance, 200, 200);
        }

        public void SetModal(bool isModal)
        {
            var boolAsInt = isModal ? 1 : 0;
            NativeMethods.gtk_window_set_modal(Handle, boolAsInt);
        }

        public bool IsResizable()
        {
            int result = NativeMethods.gtk_window_get_resizable(Handle);

            return result != 0;
        }
        
        public void SetResizable(bool isResizable)
        {
            var boolAsInt = isResizable ? 1 : 0;
            NativeMethods.gtk_window_set_resizable(Handle, boolAsInt);
        }

        /// <summary>
        /// Sets the title of the window.
        /// </summary>
        /// <param name="title">The title of the window.</param>
        /// <remarks>
        /// The title of a window will be displayed in its title bar; on the X Window System,
        /// the title bar is rendered by the window manager, so exactly how the title appears to
        /// users may vary according to a user’s exact configuration. The title should help a user
        /// distinguish this window from other windows they may have open. A good title might include
        /// the application name and current document filename, for example.
        /// </remarks>
        public void SetTitle(string title)
        {
            NativeMethods.gtk_window_set_title(_instance, title);
        }

        /// <summary>
        /// Show the window and all of its widgets.
        /// </summary>
        public void Show()
        {
            NativeMethods.gtk_widget_show_all(_instance);
        }

        public override IntPtr Handle => _instance;
    }
}