﻿using System;
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
        private readonly IntPtr _instance;
        private Widget _centerWidget;

        /// <summary>
        /// Creates a new Box.
        /// </summary>
        /// <param name="orientation">the box’s orientation.</param>
        /// <param name="spacing">the number of pixels to place by default between children.</param>
        public Box(Orientation orientation, int spacing)
        {
            _instance = GtkBox.gtk_box_new(orientation, spacing);
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

        public override IntPtr Handle => _instance;
    }
}
