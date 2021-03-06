namespace Gtk3
{

	public enum SelectionMode {
		/// No selection possible.
		None,
		/// Zero or one element may be selected.
		Single,
		/// Exactly one element is selected. In some circumstances such as
		/// initially or during a search operation, It's possible for no
		/// element to be selected with BROWSE. What is really enforced is
		/// that the user can't deselect a currently selected element except
		/// by selecting another element.
		Browse,
		/// Any number of elements may be selected. The Ctrl key may be used
		/// to enlarge the selection, and Shift key to select between the focus
		/// and the child pointed to. Some widgets may also allow Click-drag to select
		/// a range of elements.
		Multiple
	};
}
