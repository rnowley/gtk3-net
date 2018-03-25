using System;

namespace gtk3_net
{
    public class FlowBox : Container
    {
        public FlowBox()
        {
            Handle = NativeMethods.gtk_grid_new();
        }

        public FlowBox(IntPtr instance)
        {
            Handle = instance;
        }
        
        public override IntPtr Handle { get; }
    }
}