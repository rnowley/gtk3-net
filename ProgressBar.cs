using System;
using Gtk3.Native;

namespace Gtk3
{
    /// <summary>
    /// The ProgressBar is typically used to display the progress of a long running
    /// operation. It provides a visual clue that processing is underway. The
    /// ProgressBar can be used in two different modes: percentage mode and activity
    /// mode.
    /// When an application can determine how much work needs to take place (e.g. read
    /// a fixed number of bytes from a file) and can monitor its progress, it can use
    /// the ProgressBar in percentage mode and the user sees a growing bar indicating
    /// the percentage of the work that has been completed. In this mode, the
    /// application is required to call SetFraction() periodically to
    /// update the progress bar.
    /// When an application has no accurate way of knowing the amount of work to do, it
    /// can use the ProgressBar in activity mode, which shows activity by a block
    /// moving back and forth within the progress area. In this mode, the application
    /// is required to call Pulse() periodically to update the progress bar.
    /// There is quite a bit of flexibility provided to control the appearance of the
    /// ProgressBar. Functions are provided to control the orientation of the bar,
    /// optional text can be displayed along with the bar, and the step size used in
    /// activity mode can be set.
    /// </summary>
    public class ProgressBar: Widget
    {

        /// <summary>
        /// Creates a new ProgressBar.
        /// </summary>
        public ProgressBar()
        {
            Instance = GtkProgressBar.gtk_progress_bar_new();
        }

        /// <summary>
        /// Indicates that some progress has been made, but you don’t know how much.
        /// Causes the progress bar to enter “activity mode,” where a block bounces
        /// back and forth. Each call to Pulse() causes the block to move by a little
        /// bit (the amount of movement per pulse is determined by PulseStep).
        /// </summary>
        public void Pulse()
        {
            GtkProgressBar.gtk_progress_bar_pulse(Handle);
        }

        /// <summary>
        /// Gets or sets the fraction of the task that has been completed.
        /// Causes the progress bar to “fill in” the given fraction of the bar. The
        /// fraction should be between 0.0 and 1.0, inclusive.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Indicates that value is outside of the allowed range.</exception>
        public double Fraction
        {
            get => GtkProgressBar.gtk_progress_bar_get_fraction(Handle);
            set
            {
                if (value < 0.0 || value > 1.0) {
                    throw new ArgumentOutOfRangeException(nameof(value), "Outside of range 0.0 <= x <= 1.0");
                }

                GtkProgressBar.gtk_progress_bar_set_fraction(Handle, value);
            }
        }

        /// <summary>
        /// Gets or sets the mode used to ellipsize (add an ellipsis: "...") the text
        /// if there is not enough space to render the entire string.
        /// </summary>
        public EllipsizeMode Ellipsize
        {
            get => GtkProgressBar.gtk_progress_bar_get_ellipsize(Handle);
            set => GtkProgressBar.gtk_progress_bar_set_ellipsize(Handle, value);
        }

        /// <summary>
        /// Gets or sets whether or not the progress bar is inverted. If set to true then
        /// the progress bar is inverted.
        /// </summary>
        /// <remarks>
        /// Progress bars normally grow from top to bottom or left to right. Inverted
        /// progress bars grow in the opposite direction.
        /// </remarks>
        public bool Inverted
        {
            get => GtkProgressBar.gtk_progress_bar_get_inverted(Handle);
            set => GtkProgressBar.gtk_progress_bar_set_inverted(Handle, value);
        }

        /// <summary>
        /// Gets or sets whether the progress bar will show the text next to the bar.
        /// The shown text is either the value of the “text” property or, if that is
        /// null, the “fraction” value, as a percentage.
        /// To make a progress bar that is styled and sized suitably for containing
        /// text (even if the actual text is blank), set “show-text” to true and “text”
        /// to the empty string (not null).
        /// </summary>
        public bool ShowText
        {
            get => GtkProgressBar.gtk_progress_bar_get_show_text(Handle);
            set => GtkProgressBar.gtk_progress_bar_set_show_text(Handle, value);
        }

        /// <summary>
        /// Gets or sets the text that is displayed in the progress bar.
        /// </summary>
        /// <remarks>
        /// If text is null and “show-text” is true, the current value of “fraction”
        /// will be displayed as a percentage.
        /// If text is non-null and “show-text” is true, the text will be displayed.
        /// In this case, it will not display the progress percentage. If text is the
        /// empty string, the progress bar will still be styled and sized suitably for
        /// containing text, as long as “show-text” is true.
        /// </remarks>
        public string Text
        {
            get => GtkProgressBar.gtk_progress_bar_get_text(Handle);
            set => GtkProgressBar.gtk_progress_bar_set_text(Handle, value);
        }

        /// <summary>
        /// Gets or sets the fraction of total progress bar length to move the bouncing
        /// block for each call to Pulse().
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Indicates that value is outside of the allowed range.</exception>
        public double PulseStep
        {
            get => GtkProgressBar.gtk_progress_bar_get_pulse_step(Handle);
            set
            {

                if (value < 0.0 || value > 1.0) {
                    throw new ArgumentOutOfRangeException(nameof(value), "Outside of range 0.0 <= x <= 1.0");
                }

                GtkProgressBar.gtk_progress_bar_set_pulse_step(Handle, value);
            }
        }

    }
}
