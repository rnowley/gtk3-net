﻿using System;

namespace gtk3_net
{
    public class UIBuilder
    {
        private readonly IntPtr _instance;

        public  IntPtr Handle => _instance;

        public UIBuilder() {
            _instance = NativeMethods.gtk_builder_new();
        }

        public uint AddFromFile(string filename, IntPtr error)
        {
            return NativeMethods.gtk_builder_add_from_file(Handle, filename, error);
        }

        public T GetObject<T>(string name, Func<IntPtr,T> createFunction) where T : new()
        {
            var widget = NativeMethods.gtk_builder_get_object(Handle, name);
            return createFunction(widget);
        }
    }
}