using System;

namespace gtk3_net
{
    public abstract class Container : Widget
    {
        public abstract void AddWidget(Widget widget);
    }
}