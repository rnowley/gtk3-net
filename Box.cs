using System;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// The Box widget organizes child widgets into a rectangular area.
    /// The rectangular area of a Box is organized into either a single row or a
    /// single column of child widgets depending upon the orientation. Thus, all
    /// children of a Box are allocated one dimension in common, which is the height of
    /// a row, or the width of a column.
    /// Box uses a notion of packing. Packing refers to adding widgets with reference
    /// to a particular position in a Container. For a Box, there are two
    /// reference positions: the start and the end of the box. For a vertical Box,
    /// the start is defined as the top of the box and the end is defined as the
    /// bottom. For a horizontal Box the start is defined as the left side and the end
    /// is defined as the right side.
    /// Use repeated calls to PackStart() to pack widgets into a Box from
    /// start to end. Use PackEnd() to add widgets from end to start. You may
    /// intersperse these calls and add widgets from both ends of the same GtkBox.
    /// Because Box is a Container, you may also use Container.Add() to
    /// insert widgets into the box, and they will be packed with the default values
    /// for expand and fill child properties. Use Container.Remove() to remove
    /// widgets from the Box.
    /// Use Homogeneous to specify whether or not all children of the
    /// Box are forced to get the same amount of space.
    /// Use Spacing to determine how much space will be minimally placed
    /// between all children in the Box. Note that spacing is added between the
    /// children, while padding added by PackStart() or PackEnd() is
    /// added on either side of the widget it belongs to.
    /// Use ReorderChild() to move a Box child to a different place in the'
    /// box.
    /// Use SetChildPacking() to reset the expand, fill and padding child
    /// properties. Use QueryChildPacking() to query these fields.
    /// Note that a single-row or single-column Grid provides exactly the same
    /// functionality as Box.
    /// </summary>
    public class Box: Container
    {
        private Widget _centerWidget;

        /// <summary>
        /// Creates a new Box.
        /// </summary>
        /// <param name="orientation">the box’s orientation.</param>
        /// <param name="spacing">the number of pixels to place by default between children.</param>
        public Box(Orientation orientation, int spacing)
        {
            Instance = GtkBox.gtk_box_new(orientation, spacing);
        }

        internal Box(IntPtr handle)
        {
            Instance = handle;
        }

        /// <summary>
        /// Adds child to box, packed with reference to the end of box. The child is packed after (away from
        /// end of) any other child packed with reference to the end of box .
        /// </summary>
        /// <param name="child">The widget to add to the box.</param>
        /// <param name="expand">true if the new child is to be given extra space allocated to box . The extra
        /// space will be divided evenly between all children that use this option</param>
        /// <param name="fill">true if space given to child by the expand option is actually allocated to
        /// child , rather than just padding it. This parameter has no effect if expand is set to false. A
        /// child is always allocated the full height of a horizontal GtkBox and the full width of a vertical
        /// GtkBox. This option affects the other dimension</param>
        /// <param name="padding">extra space in pixels to put between this child and its neighbors, over and
        /// above the global amount specified by “spacing” property. If child is a widget at one of the
        /// reference ends of box, then padding pixels are also put between child and the reference edge of
        /// box</param>
        public void PackEnd(Widget child, bool expand, bool fill, uint padding)
        {
            GtkBox.gtk_box_pack_end(Handle, child.Handle, expand, fill, padding);
        }

        /// <summary>
        /// Adds child to box, packed with reference to the start of box. The child is packed after any
        /// other child packed with reference to the start of box .
        /// </summary>
        /// <param name="child">The widget to add to the box.</param>
        /// <param name="expand">true if the new child is to be given extra space allocated to box . The extra
        /// space will be divided evenly between all children that use this option</param>
        /// <param name="fill">true if space given to child by the expand option is actually allocated to
        /// child , rather than just padding it. This parameter has no effect if expand is set to false. A
        /// child is always allocated the full height of a horizontal GtkBox and the full width of a vertical
        /// GtkBox. This option affects the other dimension</param>
        /// <param name="padding">extra space in pixels to put between this child and its neighbors, over and
        /// above the global amount specified by “spacing” property. If child is a widget at one of the
        /// reference ends of box, then padding pixels are also put between child and the reference edge of
        /// box</param>
        public void PackStart(Widget child, bool expand, bool fill, uint padding)
        {
            GtkBox.gtk_box_pack_start(Handle, child.Handle, expand, fill, padding);
        }

        /// <summary>
        /// Gets or sets a center widget; that is a child widget that will be centered
        /// with respect to the full width of the box, even if the children at either
        /// side take up different amounts of space. Returns the center widget or null if
        /// a center widget is not set.
        /// </summary>
        public Widget CenterWidget
        {
            get => _centerWidget;

            set
            {
                _centerWidget = value;
                GtkBox.gtk_box_set_center_widget(Handle, value.Handle);
            }
        }

        /// <summary>
        /// Gets or sets whether the box is homogeneous (all children are the same
        /// size).
        /// </summary>
        public bool Homogeneous
        {
            get => GtkBox.gtk_box_get_homogeneous(Handle);
            set => GtkBox.gtk_box_set_homogeneous(Handle, value);
        }

        /// <summary>
        /// Gets or sets the “spacing” property of box , which is the number of pixels
        /// to place between children of box.
        /// </summary>
        public int Spacing
        {
            get => GtkBox.gtk_box_get_spacing(Handle);
            set => GtkBox.gtk_box_set_spacing(Handle, value);
        }

    }
}
