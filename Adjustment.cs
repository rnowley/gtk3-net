using System;

namespace gtk3_net
{
	///<summary>
	/// A representation of an adjustable bounded value.
	/// </summary>
	public class Adjustment
	{
        private readonly IntPtr _instance;

        public IntPtr Handle => _instance;

		/// <summary>
		/// Creates a new Adjustment object.
		/// </summary>
		/// <param name="value">The initial value</param>
		/// <param name="lower">The minimum value</param>
		/// <param name="upper">The maximum value</param>
		/// <param name="stepIncrement">The step increment</param>
		/// <param name="pageIncrement">The page increment</param>
		/// <param name="pageSize">The page size</param>
		public Adjustment(double value, double lower, double upper, double stepIncrement,
				double pageIncrement, double pageSize) {
			_instance = NativeMethods.gtk_adjustment_new(value, lower,
					upper, stepIncrement, pageIncrement, pageSize);

		}

		///<summary>
		/// Updates the "value" property to ensure that the range between lower and upper is
		/// in the current page (i.e. between "value" and "value" + "Page-size").
		/// If the range is larger than the page size, then only the start of it will
		/// be in the current page.
		///</summary>
		///<param name="lower">the lower value</param>
		///<param name="upper">the upper value</param>
		///<remarks>
		/// A "value-changed" signal will be emitted if the value is changed.
		///</remarks>
		public void ClampPage(double lower, double upper) {
			NativeMethods.gtk_adjustment_clamp_page(Handle, lower, upper);
		}

		///<summary>
		/// Sets all properties of the adjustment at once.
		///</summary>
		///<param name="value">the new value</param>
		///<param name="lower">the new minimum value</param>
		///<param name="upper">the new maximum value</param>
		///<param name="stepIncrement">the new step increment</param>
		///<param name="pageIncrement">the page increment</param>
		///<param name="pageSize">the new page size</param>
		///<remarks>
		/// Use this function to avoid multiple emissions of the "changed" signal.
		///</remarks>
		public void Configure(double value, double lower, double upper, double stepIncrement,
				double pageIncrement, double pageSize) {
			NativeMethods.gtk_adjustment_configure(Handle, value, lower, upper,
					stepIncrement, pageIncrement, pageSize);
		}

		///<summary>
		/// Gets or sets the minimum value of the adjustment.
		///</summary>
		public double Lower {
			get {
				return NativeMethods.gtk_adjustment_get_lower(Handle);
			}

			set {
				NativeMethods.gtk_adjustment_set_lower(Handle, value);
			}
		}


		///<summary>
		/// Gets or sets the value of the adjustment.
		///</summary>
		public double Value {

			get {
				return NativeMethods.gtk_adjustment_get_value(Handle);
			}

			set {
				NativeMethods.gtk_adjustment_set_value(Handle, value);
			}
		}

		///<summary>
		/// Gets or sets the page size of the adjustment.
		///</summary>
		public double PageSize {
			get {
				return NativeMethods.gtk_adjustment_get_page_size(Handle);
			}

			set {
				NativeMethods.gtk_adjustment_set_page_size(Handle, value);
			}
		}

		///<summary>
		/// Gets or sets the page increment of the adjustment.
		///</summary>
		public double PageIncrement {
			get {
				return NativeMethods.gtk_adjustment_get_page_increment(Handle);
			}

			set {
				NativeMethods.gtk_adjustment_set_page_increment(Handle, value);
			}
	   	}

		///<summary>
		/// Gets or sets the step increment of the adjustment.
		///</summary>
		public double StepIncrement {
			get {
				return NativeMethods.gtk_adjustment_get_step_increment(Handle);
			}

			set {
				NativeMethods.gtk_adjustment_set_step_increment(Handle, value);
			}
		}

		///<summary>
		/// Gets or sets the maximum value of the adjustment.
		///</summary>
		///<remarks>
		/// Note that values will be restricted by upper - pageSize if the pageSize property is nonzero.
		///</remarks>
		public double Upper {
			get {
				return NativeMethods.gtk_adjustment_get_upper(Handle);
			}

			set {
				NativeMethods.gtk_adjustment_set_upper(Handle, value);
			}
		}

	}
}
