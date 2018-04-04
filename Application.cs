using System;
using System.Runtime.InteropServices;

namespace gtk3_net
{
    public class Application
    {
        public delegate void ApplicationCallBack(IntPtr app, IntPtr data);
        private readonly IntPtr _instance;

        public Application(string applicationId, GApplicationFlags flags)
        {
            _instance = NativeMethods.gtk_application_new(applicationId, flags);
        }

        public void ConnectSignal(string detailedSignal, ApplicationCallBack callback, NativeMethods.GClosureNotify destroyData)
        {
            NativeMethods.g_signal_connect_data(_instance, detailedSignal,
                Marshal.GetFunctionPointerForDelegate(callback), IntPtr.Zero, 
                destroyData, GConnectFlags.ConnectAfter);
        }

        public Window CreateWindow()
        {
            var windowHandle = NativeMethods.gtk_application_window_new(Handle);
            return new Window(windowHandle);
        }

        public int Run(int argc, string[] argv)
        {
            return NativeMethods.g_application_run(_instance, argc, argv);
        }

        internal IntPtr Handle => _instance;

        public void Exit()
        {
            NativeMethods.g_object_unref(_instance);
        }
    }
}