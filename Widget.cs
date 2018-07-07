using System;
using System.Runtime.InteropServices;

namespace Gtk3
{
    public abstract class Widget
    {
        public delegate void WidgetCallBack();

        public delegate void WidgetCallBack2Arg(IntPtr widget, IntPtr data);

        public abstract IntPtr Handle { get; }

        public virtual void ConnectSignal(string detailedSignal, WidgetCallBack callback, IntPtr data, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(Handle, detailedSignal,
                Marshal.GetFunctionPointerForDelegate(callback), data,
                destroyData, GConnectFlags.ConnectAfter);
        }

        public virtual void ConnectSignal(string detailedSignal, WidgetCallBack2Arg callback, IntPtr data, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(Handle, detailedSignal,
                Marshal.GetFunctionPointerForDelegate(callback), data,
                destroyData, GConnectFlags.ConnectAfter);
        }

        public virtual void ConnectSignalSwapped(string detailedSignal, WidgetCallBack2Arg callBack, IntPtr data,
                                         NativeMethods.GClosureNotify destroyData) {

            NativeMethods.g_signal_connect_data(Handle, detailedSignal, Marshal.GetFunctionPointerForDelegate(callBack), data,
                        destroyData, GConnectFlags.ConnectSwapped);

        }
    }
}
