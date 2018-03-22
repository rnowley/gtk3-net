﻿using System;
using System.Runtime.InteropServices;

namespace gtk3_net
{
    public abstract class Widget
    {
        public delegate void WidgetCallBack(IntPtr widget, IntPtr data);
        public abstract IntPtr Handle { get; }

        public void ConnectSignal(string detailedSignal, WidgetCallBack callback, IntPtr data, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(Handle, detailedSignal,
                Marshal.GetFunctionPointerForDelegate(callback), data, 
                destroyData, GConnectFlags.ConnectAfter);
        }

        public void ConnectSignalSwapped(string detailedSignal, WidgetCallBack callBack, IntPtr data,
                                         NativeMethods.GClosureNotify destroyData) {

            NativeMethods.g_signal_connect_data(Handle, detailedSignal, Marshal.GetFunctionPointerForDelegate(callBack), data,
                        destroyData, GConnectFlags.ConnectSwapped);

        }
    }
}