using System;

namespace Gdk
{
    /// <summary>
    /// A set of bit-flags to indicate the state of modifier keys and mouse buttons in various
    /// event types. Typical modifier keys are Shift, Control, Meta, Super, Hyper, Alt, Compose,
    /// Apple, CapsLock or ShiftLock.
    /// Like the X Window System, GDK supports 8 modifier keys and 5 mouse buttons.
    /// Since 2.10, GDK recognizes which of the Meta, Super or Hyper keys are mapped to Mod2 -
    /// Mod5, and indicates this by setting SuperMask, HyperMask or MetaMask
    /// in the state field of key events.
    ///
    /// Note that GDK may add internal values to events which include reserved values such as
    /// Reserved13Mask. Your code should preserve and ignore them. You can use ODIFIER_MASK to remove all reserved values.
    ///
    /// Also note that the GDK X backend interprets button press events for button 4-7 as scroll events, so Button4Mask and Button5Mask will never be set.
    /// </summary>
    [Flags]
    public enum ModifierType
    {
        /// <summary>
        /// the Shift key.
        /// </summary>
        ShiftMask,
        /// <summary>
        /// a Lock key (depending on the modifier mapping of the X server this may either be
        /// CapsLock or ShiftLock).
        /// </summary>
        LockMask,
        /// <summary>
        /// the Control key.
        /// </summary>
        ControlMask,
        /// <summary>
        /// the fourth modifier key (it depends on the modifier mapping of the X server which key
        /// is interpreted as this modifier, but normally it is the Alt key).
        /// </summary>
        Mod1Mask,
        /// <summary>
        /// the fifth modifier key (it depends on the modifier mapping of the X server which key
        /// is interpreted as this modifier).
        /// </summary>
        Mod2Mask,
        /// <summary>
        /// the sixth modifier key (it depends on the modifier mapping of the X server which key
        /// is interpreted as this modifier).
        /// </summary>
        Mod3Mask,
        /// <summary>
        /// the seventh modifier key (it depends on the modifier mapping of the X server which
        /// key is interpreted as this modifier).
        /// </summary>
        Mod4Mask,
        /// <summary>
        /// the eighth modifier key (it depends on the modifier mapping of the X server which key is interpreted as this modifier).
        /// </summary>
        Mod5Mask,
        /// <summary>
        ///the first mouse button.
        /// </summary>
        Button1Mask,
        /// <summary>
        ///the second mouse button.
        /// </summary>
        Button2Mask,
        /// <summary>
        ///the third mouse button.
        /// </summary>
        Button3Mask,
        /// <summary>
        ///the fourth mouse button.
        /// </summary>
        Button4Mask,
        /// <summary>
        /// the fifth mouse button.
        /// </summary>
        Button5Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved13Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved14Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved15Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved16Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved17Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved18Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved19Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved20Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved21Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved22Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved23Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved24Mask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved25Mask,
        /// <summary>
        /// the Super modifier.
        /// </summary>
        SuperMask,
        /// <summary>
        /// the Hyper modifier.
        /// </summary>
        HyperMask,
        /// <summary>
        /// the Meta modifier.
        /// </summary>
        MetaMask,
        /// <summary>
        /// A reserved bit flag; do not use in your own code
        /// </summary>
        Reserved29Mask,
        /// <summary>
        /// not used in GDK itself. GTK+ uses it to differentiate between (keyval, modifiers)
        /// pairs from key press and release events.
        /// </summary>
        ReleaseMask,
        /// <summary>
        /// a mask covering all modifier types.
        /// </summary>
        ModifierMask
    }
}
