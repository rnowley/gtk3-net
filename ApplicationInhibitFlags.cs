namespace Gtk3
{
    /// <summary>
    /// Types of user actions that may be blocked by gtk_application_inhibit().
    /// </summary>
    public enum ApplicationInhibitFlags
    {
        /// <summary>
        /// Inhibit ending the user session by logging out or by shutting down the computer
        /// </summary>
        InhibitLogout,
        /// <summary>
        /// Inhibit user switching
        /// </summary>
        InhibitSwitch,
        /// <summary>
        /// Inhibit suspending the session or computer
        /// </summary>
        InhibitSuspend,
        /// <summary>
        /// Inhibit the session being marked as idle (and possibly locked)
        /// </summary>
        InhibitIdle
    }
}