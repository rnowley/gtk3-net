using System;

namespace Gtk3
{

	public class FlowBox : Widget
	{
		private readonly IntPtr _instance;

		public override IntPtr Handle => _instance;

		public FlowBox() {
			_instance = NativeMethods.gtk_flow_box_new();
		}

		/// <summary>
		/// Inserts the widget into the flow box at the specified position.
		/// </summary>
		/// <param name="widget">The widget to add to the flow box</param>
		/// <param name="position">The position to insert the child at. If position is -1, or larger than the number of children in the box then the widget will be appended the end.</param>
		public void Insert(Widget widget, int position) {
			NativeMethods.gtk_flow_box_insert(Handle, widget.Handle, position);
		}

		/// <summary>
		/// Gets or sets the horizontal space to add between the children.
		/// </summary>
		public uint ColumnSpacing {
			get {
				return NativeMethods.gtk_flow_box_get_column_spacing(Handle);
			}

			set {
				NativeMethods.gtk_flow_box_set_column_spacing(Handle, value);
			}
		}

		/// <summary>
		/// Gets or sets whether homogeneous property of the box. If set to homogeneous
		/// then all children in the box have the same size.
		/// </summary>
		public bool Homogeneous {
			get {
				return NativeMethods.gtk_flow_box_get_homogeneous(Handle);
			}

			set {
				NativeMethods.gtk_flow_box_set_homogeneous(Handle, value);
			}
		}

		/// <summary>
		/// Gets or sets the minimum number of children to line up in the box's
		/// orientation before flowing.
		/// </summary>
		public uint MinimumChildrenPerLine {
			get {
				return NativeMethods.gtk_flow_box_get_min_children_per_line(Handle);
			}

			set {
				NativeMethods.gtk_flow_box_set_min_children_per_line(Handle, value);
			}
		}


		/// <summary>
		/// Gets or sets the maximum number of children to line up in the box's
		/// orientation before flowing.
		/// </summary>
		/// <remarks>
		/// Setting the maximum number of children per line limits the overall natural size request to
		/// be no more than the set number of children long in the given orientation.
		/// </remarks>
		public uint MaximumChildrenPerLine {
			get {
				return NativeMethods.gtk_flow_box_get_max_children_per_line(Handle);
			}

			set {
				NativeMethods.gtk_flow_box_set_max_children_per_line(Handle, value);
			}
		}

		/// <summary>
		/// Gets or sets the vertical space between the children.
		/// </summary>
		public uint RowSpacing {
			get {
				return NativeMethods.gtk_flow_box_get_row_spacing(Handle);
			}

			set {
				NativeMethods.gtk_flow_box_set_row_spacing(Handle, value);
			}
	   	}
	}
}

