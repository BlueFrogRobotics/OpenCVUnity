
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CLAHE
    public class CLAHE : Algorithm
    {


        protected override void Dispose(bool disposing)
        {

            try
            {

                if (disposing)
                {
                }

                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_imgproc_CLAHE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CLAHE(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  void CLAHE::apply(Mat src, Mat& dst)
        //

        public void apply(Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();
            ThrowIfDisposed();


            opencvunity_imgproc_CLAHE_apply_10(nativeObj, src.nativeObj, dst.nativeObj);

        }


        //
        // C++:  void CLAHE::setClipLimit(double clipLimit)
        //

        public void setClipLimit(double clipLimit)
        {
            ThrowIfDisposed();

            opencvunity_imgproc_CLAHE_setClipLimit_10(nativeObj, clipLimit);

        }


        //
        // C++:  void CLAHE::setTilesGridSize(Size tileGridSize)
        //

        public void setTilesGridSize(Size tileGridSize)
        {
            ThrowIfDisposed();

            opencvunity_imgproc_CLAHE_setTilesGridSize_10(nativeObj, tileGridSize.width, tileGridSize.height);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_imgproc_CLAHE_delete(nativeObj);
        //	}



        // C++:  void CLAHE::apply(Mat src, Mat& dst)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_imgproc_CLAHE_apply_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void CLAHE::setClipLimit(double clipLimit)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_imgproc_CLAHE_setClipLimit_10(IntPtr nativeObj, double clipLimit);

        // C++:  void CLAHE::setTilesGridSize(Size tileGridSize)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_imgproc_CLAHE_setTilesGridSize_10(IntPtr nativeObj, double tileGridSize_width, double tileGridSize_height);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_imgproc_CLAHE_delete(IntPtr nativeObj);
    }}