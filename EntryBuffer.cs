using System;

namespace gtk3_net
{

	/// <summary>
	/// The GtkEntryBuffer class contains the actual text displayed in the
	/// GtkEntry widget.
	/// A single GtkEntryBuffer object can be shared by multiple GtkEntry widgets
	/// that will then share the same text content, but not the cursor position,
	/// visibility attributes, icon, etc.
	/// </summary>
	public class EntryBuffer
	{

        private readonly IntPtr _instance;

		/// <summary>
		/// Creates a new instance of an EntryBufferObject.
		/// </summary>
		/// <param name="initialCharacter">The text to show in the initial buffer, or null</param>
		/// <param name="numberOfInitialCharacters">The number of characters in initialCharacter, or -1</param>
		public EntryBuffer(string initialCharacter, int numberOfInitialCharacters) {
			_instance = NativeMethods.gtk_entry_buffer_new(initialCharacter, numberOfInitialCharacters);
		}

		/// <summary>
		/// Gets or sets the maximum allowed length of text in the buffer.
		/// </summary>
		/// <remarks>
		/// A returned value of 0 indicates that there is no maximum.
		/// When setting the maximum length, if the current contents of the buffer
		/// is longer than the new maximum then they are truncated to fit.
		/// The maximum length passed in is clamped to the range 0-65536.
		/// </remarks>
		public int MaxLength {
			get {
				return NativeMethods.gtk_entry_buffer_get_max_length(Handle);
			}

			set {
				NativeMethods.gtk_entry_buffer_set_max_length(Handle, value);
			}
		}

		/// <summary>
		/// Gets or sets the text in the buffer.
		/// </summary>
		public string Text {
			get{
				return NativeMethods.gtk_entry_buffer_get_text(Handle);
			}

			set {
				var numberOfCharacters = -1;

				if (value != null)
				{
					numberOfCharacters = value.Length;
				}

				NativeMethods.gtk_entry_buffer_set_text(Handle, value, numberOfCharacters);
			}
		}

        public IntPtr Handle => _instance;
	}
}
