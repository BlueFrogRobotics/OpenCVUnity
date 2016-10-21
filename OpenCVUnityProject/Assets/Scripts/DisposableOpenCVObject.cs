using UnityEngine;using System;namespace OpenCVUnity{
    abstract public class DisposableOpenCVObject : DisposableObject
    {
        public IntPtr nativeObj;

        protected DisposableOpenCVObject() : this(true)
        {
        }

        protected DisposableOpenCVObject(IntPtr ptr) : this(ptr, true)
        {
        }

        protected DisposableOpenCVObject(bool isEnabledDispose) : this(IntPtr.Zero, isEnabledDispose)
        {
        }

        protected DisposableOpenCVObject(IntPtr ptr, bool isEnabledDispose) : base(isEnabledDispose)
        {
            this.nativeObj = ptr;
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                nativeObj = IntPtr.Zero;
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

    }}