using System;

namespace gtk3_net
{
    [Flags]
    public enum GConnectFlags
    {
        /// <summary>
        ///     whether the handler should be called before or after the default handler of the signal.
        /// </summary>
        ConnectAfter,

        /// <summary>
        ///     whether the instance and data should be swapped when calling the handler; see g_signal_connect_swapped() for an
        ///     example.
        /// </summary>
        ConnectSwapped
    }
}