using System;

namespace Gdk
{
    /// <summary>
    /// A set of bit-flags to indicate which events a window is to receive. Most of these masks
    /// map onto one or more of the GdkEventType event types above.
    /// See the input handling overview for details of event masks and event propagation.
    ///
    /// GDK_POINTER_MOTION_HINT_MASK is deprecated. It is a special mask to reduce the number of
    /// GDK_MOTION_NOTIFY events received. When using GDK_POINTER_MOTION_HINT_MASK, fewer
    /// GDK_MOTION_NOTIFY events will be sent, some of which are marked as a hint (the is_hint
    /// member is TRUE). To receive more motion events after a motion hint event, the application
    /// needs to asks for more, by calling gdk_event_request_motions().
    ///
    /// Since GTK 3.8, motion events are already compressed by default, independent of this
    /// mechanism. This compression can be disabled with gdk_window_set_event_compression(). See
    /// the documentation of that function for details. If GDK_TOUCH_MASK is enabled, the window
    /// will receive touch events from touch-enabled devices. Those will come as sequences of
    /// GdkEventTouch with type GDK_TOUCH_UPDATE, enclosed by two events with type
    /// GDK_TOUCH_BEGIN and GDK_TOUCH_END (or GDK_TOUCH_CANCEL). gdk_event_get_event_sequence()
    /// returns the event sequence for these events, so different sequences may be distinguished.
    /// </summary>
    public enum EventMask
    {
        /// <summary>
        /// receive expose events
        /// </summary>
        ExposureMask,
        /// <summary>
        /// receive all pointer motion events
        /// </summary>
        PointerMotionMask,
        /// <summary>
        /// deprecated. see the explanation above
        /// </summary>
        [Obsolete]
        PointerMotionHintMask,
        /// <summary>
        /// receive pointer motion events while any button is pressed
        /// </summary>
        ButtonMotionMask,
        /// <summary>
        /// receive pointer motion events while 1 button is pressed
        /// </summary>
        ButtonMotion1Mask,
        /// <summary>
        /// receive pointer motion events while 2 button is pressed
        /// </summary>
        ButtonMotion2Mask,
        /// <summary>
        /// receive pointer motion events while 3 button is pressed
        /// </summary>
        ButtonMotion3Mask,
        /// <summary>
        ///receive button press events
        /// </summary>
        ButtonPressMask,
        /// <summary>
        /// receive button release events
        /// </summary>
        ButtonReleaseMask,
        /// <summary>
        /// receive key press events
        /// </summary>
        KeyPressMask,
        /// <summary>
        /// receive key release events
        /// </summary>
        KeyReleaseMask,
        /// <summary>
        /// receive window enter events
        /// </summary>
        EnterNotifyMask,
        /// <summary>
        /// receive window leave events
        /// </summary>
        LeaveNotifyMask,
        /// <summary>
        /// receive focus change events
        /// </summary>
        FocusChangeMask,
        /// <summary>
        /// receive events about window configuration change
        /// </summary>
        StructureMask,
        /// <summary>
        /// receive property change events
        /// </summary>
        PropertyChangeMask,
        /// <summary>
        /// receive visibility change events
        /// </summary>
        VisibilityNotifyMask,
        /// <summary>
        /// receive proximity in events
        /// </summary>
        ProximityInMask,
        /// <summary>
        /// receive proximity out events
        /// </summary>
        ProximityOutMask,
        /// <summary>
        /// receive events about window configuration changes of child windows
        /// </summary>
        SubstructureMask,
        /// <summary>
        /// receive scroll events
        /// </summary>
        ScrollMask,
        /// <summary>
        /// receive touch events
        /// </summary>
        TouchMask,
        /// <summary>
        /// receive smooth scrolling events.
        /// </summary>
        SmoothScrollMask,
        /// <summary>
        /// receive touchpad gesture events.
        /// </summary>
        TouchpadGestureMask,
        /// <summary>
        /// receive tablet pad events.
        /// </summary>
        TabletPadMask,
        /// <summary>
        /// the combination of all the above event masks.
        /// </summary>
        AllEventsMask
    }
}
