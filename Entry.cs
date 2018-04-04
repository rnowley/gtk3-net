using System;

namespace gtk3_net
{

	public class Entry : Widget {

		private readonly IntPtr _instance;

		public override IntPtr Handle => _instance;

		/// <summary>
		/// Creates a new instance of an Entry.
		/// </summary>
		public Entry() {
			_instance = NativeMethods.gtk_entry_new();
		}
	}
}
