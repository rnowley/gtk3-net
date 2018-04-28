using System;

namespace Gtk3
{

	public class Entry : Widget {

		private readonly IntPtr _instance;

		public override IntPtr Handle => _instance;

		/// <summary>
		/// Creates a new instance of an Entry.
		/// </summary>
		public Entry() {
			_instance = Native.GtkEntry.gtk_entry_new();
		}

		/// <summary>
		/// Creates a new entry with the specified text buffer.
		/// </summary>
		/// <param name="buffer">The buffer to use for the new Entry.</param>
		public Entry(EntryBuffer buffer)
		{
			_instance = Native.GtkEntry.gtk_entry_new_with_buffer(buffer.Handle);
		}

		/// <summary>
		/// Indicates that some progress is made, but you don’t know how much.
		/// Causes the entry’s progress indicator to enter “activity mode,”
		/// where a block bounces back and forth. Each call to
		/// ProgressPulse() causes the block to move by a little
		/// bit (the amount of movement per pulse is determined by
		/// ProgressPulseStep).
		/// </summary>
		public void ProgressPulse()
		{
			Native.GtkEntry.gtk_entry_progress_pulse(Handle);
		}

		/// <summary>
		/// Sets whether the contents of the entry are visible or not. When
		/// visibility is set to false, characters are displayed as the
		/// invisible char, and will also appear that way when the text in the
		/// entry widget is copied elsewhere.
		/// By default, GTK+ picks the best invisible character available in
		/// the current font, but it can be changed with SetInvisibleChar().
		/// </summary>
		/// <param name="visible">true if the contents of the entry are displayed as plaintext</param>
		/// <remarks>Note that you probably want to set “input-purpose” to
		/// GTK_INPUT_PURPOSE_PASSWORD or GTK_INPUT_PURPOSE_PIN to inform
		/// input methods about the purpose of this entry, in addition to
		/// setting visibility to false.</remarks>
		public void SetVisibility(bool visible)
		{
			Native.GtkEntry.gtk_entry_set_visibility(Handle, visible);
		}

		/// <summary>
		/// Sets the character to use in place of the actual text when
		/// SetVisibility() has been called to set text visibility
		/// to false. i.e. this is the character used in “password mode” to
		/// show the user how many characters have been typed. By default, GTK+
		/// picks the best invisible char available in the current font. If you
		/// set the invisible char to null, then the user will get no feedback at
		/// all; there will be no text on the screen as they type.
		/// </summary>
		/// <param name="invisibleCharacter">a Unicode character</param>
		public void SetInvisibleChar(char? invisibleCharacter)
		{
			uint value = 0;

			if (invisibleCharacter.HasValue)
			{
				value = (uint) invisibleCharacter;
			}
			
			Native.GtkEntry.gtk_entry_set_invisible_char(Handle, value);
		}

		/// <summary>
		/// Unsets the invisible char previously set with SetInvisibleChar().
		/// So that the default invisible char is used again.
		/// </summary>
		public void UnsetInvisibleChar()
		{
			Native.GtkEntry.gtk_entry_unset_invisible_char(Handle);
		}

		/// <summary>
		/// Gets or sets the entry buffer used by this Entry.
		/// </summary>
		public EntryBuffer Buffer
		{
			get
			{
				var bufferHandle = Native.GtkEntry.gtk_entry_get_buffer(Handle);
				return new EntryBuffer(bufferHandle);
			}

			set => Native.GtkEntry.gtk_entry_set_buffer(Handle, value.Handle);
		}

		/// <summary>
		/// Gets or sets whether the text is overwritten when typing in the Entry.
		/// </summary>
		public bool OverwriteMode
		{
			get => Native.GtkEntry.gtk_entry_get_overwrite_mode(Handle);

			set => Native.GtkEntry.gtk_entry_set_overwrite_mode(Handle, value);
		}

		/// <summary>
		/// Gets or sets the text to be displayed when it is empty and unfocused.
		/// </summary>
		/// <remarks>
		/// Note that since the placeholder text gets removed when the entry
		/// received focus, using this feature is a bit problematic if the
		/// entry is given the initial focus in a window. Sometimes this can
		/// be worked around by delaying the initial focus setting until the
		/// first key event arrives.
		/// </remarks>
		public string PlaceholderText
		{
			get => Native.GtkEntry.gtk_entry_get_placeholder_text(Handle);
			
			set => Native.GtkEntry.gtk_entry_set_placeholder_text(Handle, value);
		}

		/// <summary>
		/// Gets or sets the entry’s progress indicator to “fill in” the
		/// given fraction of the bar. The fraction should be between
		/// 0.0 and 1.0, inclusive.
		/// </summary>
		public double ProgressFraction
		{
			get => Native.GtkEntry.gtk_entry_get_progress_fraction(Handle);

			set => Native.GtkEntry.gtk_entry_set_progress_fraction(Handle, value);
		}
		
		/// <summary>
		/// Sets the fraction of total entry width to move the progress
		/// bouncing block for each call to ProgressPulse().
		/// </summary>
		public double ProgressPulseStep
		{
			get => Native.GtkEntry.gtk_entry_get_progress_pulse_step(Handle);

			set => Native.GtkEntry.gtk_entry_set_progress_pulse_step(Handle, value);
		}

		/// <summary>
		/// Gets or sets the text content of the entry widget.
		/// </summary>
		public string Text
		{
			get => Native.GtkEntry.gtk_entry_get_text(Handle);
			
			set => Native.GtkEntry.gtk_entry_set_text(Handle, value);
		}

		/// <summary>
		/// Retrieves the current length of the text in the entry.
		/// </summary>
		public uint TextLength => Native.GtkEntry.gtk_entry_get_text_length(Handle);
	}
}
