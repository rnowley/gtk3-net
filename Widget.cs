using System;

namespace gtk3_net
{
    public abstract class Widget
    {
        internal abstract IntPtr Handle { get; }
    }
}