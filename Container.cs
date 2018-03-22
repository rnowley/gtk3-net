using System;

namespace gtk3_net
{
    public abstract class Container : Widget
    {
        /// <summary>
        /// Adds a widget to the container
        /// </summary>
        /// <param name="widget">The widget to add to the container</param>
        /// <remarks>
        /// Typically used for simple containers such as GtkWindow, GtkFrame, or GtkButton; for more complicated
        /// layout containers such as GtkBox or GtkGrid, this function will pick default packing parameters that
        /// may not be correct. So consider functions such as gtk_box_pack_start() and gtk_grid_attach() as an
        /// alternative to gtk_container_add() in those cases. A widget may be added to only one container at a time;
        /// you can’t place the same widget inside two different containers.
        /// Note that some containers, such as GtkScrolledWindow or GtkListBox, may add intermediate children between
        /// the added widget and the container.
        /// </remarks>
        public void AddWidget(Widget widget)
        {
            NativeMethods.gtk_container_add(Handle, widget.Handle);
        }
    }
}