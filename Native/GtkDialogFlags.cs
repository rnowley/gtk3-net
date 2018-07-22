using System;

namespace Gtk3.Native
{
    /// <summary>
    /// Flags used to influence dialog construction.
    /// </summary>
    [Flags]
    public enum GtkDialogFlags
    {
       /// <summary>
       /// 	Make the constructed dialog modal
       /// </summary>
       Modal = 0,
       /// <summary>
       /// Destroy the dialog when its parent is destroyed
       /// </summary>
       DestroyWithParent
    }
}
