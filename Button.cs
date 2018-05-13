using System;
using System.Runtime.InteropServices;
using Gtk3.Native;

namespace Gtk3
{
    public class Button : Widget
    {
        private readonly IntPtr _instance;

        private delegate void FireEventDelegate(IntPtr app, IntPtr data);
        public delegate void ButtonDelegate(object sender, EventArgs e);

        public Button() {}

        public Button(string label)
        {
            _instance = GtkButton.gtk_button_new_with_label(label);
        }

        public Button(IntPtr instance)
        {
            _instance = instance;
        }

        public void ConnectClickedSignal(WidgetCallBack2Arg callback, IntPtr data, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(Handle, "clicked",
                Marshal.GetFunctionPointerForDelegate(callback), data,
                destroyData, GConnectFlags.ConnectAfter);
        }

        public void ConnectClickedSignalSwapped(WidgetCallBack2Arg callBack, IntPtr data,
            NativeMethods.GClosureNotify destroyData) {

            NativeMethods.g_signal_connect_data(Handle, "clicked", Marshal.GetFunctionPointerForDelegate(callBack), data,
                destroyData, GConnectFlags.ConnectSwapped);

        }

        public override IntPtr Handle => _instance;
    }
}
