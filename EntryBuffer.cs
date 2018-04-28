using System;

namespace Gtk3
{

	/// <summary>
	/// The EntryBuffer class contains the actual text displayed in the
	/// Entry widget.
	/// A single EntryBuffer object can be shared by multiple Entry widgets
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
			_instance = Native.GtkEntryBuffer.gtk_entry_buffer_new(initialCharacter, numberOfInitialCharacters);
		}

		/// <summary>
		/// Constructs a new EntryBuffer from an existing IntPtr to an entry buffer.
		/// </summary>
		/// <param name="buffer">The buffer to wrap the EntryBuffer around.</param>
		internal EntryBuffer(IntPtr buffer)
		{
			_instance = buffer;
		}

		/// <summary>
		/// Inserts `numberOfChars` characters of `text` into the contents of the
		/// buffer, at position `position`.
		/// 
		// If `numberOfChars` is negative, then characters from text will be inserted
		// until a null-terminator is found. If `position` or `numberOfChars` are out of
		// bounds, or the maximum buffer text length is exceeded, then they are
		// coerced to sane values.
		/// </summary>
		/// <param name="position">the position at which to insert text.</param>
		/// <param name="text">the text to insert into the buffer.</param>
		/// <param name="numberOfChars">the length of the text in characters, or -1</param>
		/// <remarks>Note that the position and length are in characters, not in bytes.</remarks>
		/// <returns>The number of characters actually inserted.</returns>
		public uint InsertText(uint position, string text, int numberOfChars = -1)
		{
			return Native.GtkEntryBuffer.gtk_entry_buffer_insert_text(Handle,
				position, text, numberOfChars);
		}

		/// <summary>
		/// Deletes a sequence of characters from the buffer. `numberOfChars` characters
		/// are deleted starting at `position` . If `numberOfChars` is negative, then
		/// all characters until the end of the text are deleted.
		/// If `position` or `numberOfChars` are out of bounds, then they are
		/// coerced to sane values.
		/// </summary>
		/// <param name="position">position at which to delete text.</param>
		/// <param name="numberOfChars">number of characters to delete</param>
		/// <remarks>Note that the positions are specified in characters, not bytes.</remarks>
		/// <returns>The number of characters deleted.</returns>
		public uint DeleteText(uint position, int numberOfChars)
		{
			return Native.GtkEntryBuffer.gtk_entry_buffer_delete_text(Handle,
				position, numberOfChars);
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
			get => Native.GtkEntryBuffer.gtk_entry_buffer_get_max_length(Handle);

			set => Native.GtkEntryBuffer.gtk_entry_buffer_set_max_length(Handle, value);
		}

		/// <summary>
		/// Gets or sets the text in the buffer.
		/// </summary>
		public string Text {
			get => Native.GtkEntryBuffer.gtk_entry_buffer_get_text(Handle);

			set {
				var numberOfCharacters = -1;

				if (value != null)
				{
					numberOfCharacters = value.Length;
				}

				Native.GtkEntryBuffer.gtk_entry_buffer_set_text(Handle, value, numberOfCharacters);
			}
		}

		public uint Bytes => Native.GtkEntryBuffer.gtk_entry_buffer_get_bytes(Handle);

		public uint Length => Native.GtkEntryBuffer.gtk_entry_buffer_get_length(Handle);

		public IntPtr Handle => _instance;
	}
}
