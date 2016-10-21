
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVUnity
{
    public class KeyPointsFilter : Features2d
    {

        protected override void Dispose(bool disposing)
        {

            try {

                if (disposing) {
                }

                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_features2D_keypointsFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }

        }

        public KeyPointsFilter(IntPtr addr)
        {
            nativeObj = addr;
        }

        public KeyPointsFilter()
        {
            nativeObj = opencvunity_features2D_keypointsFilter_keypointsFilter();
        }

        public void runByImageBorder(MatOfKeyPoint keypts, double imageSizewidth, double imageSizeHeight, int borderSize)
        {
            if (keypts != null)
                keypts.ThrowIfDisposed();

            Mat mat = keypts;
            opencvunity_features2D_keypointsFilter_runByImageBorder(nativeObj, mat.nativeObj, imageSizewidth, imageSizeHeight, borderSize);
        }

        public void runByKeypointSize(MatOfKeyPoint keypts, double minSize)
        {
            if (keypts != null)
                keypts.ThrowIfDisposed();

            Mat mat = keypts;
            opencvunity_features2D_keypointsFilter_runByKeypointSize1(nativeObj, mat.nativeObj, minSize);
        }

        public void runByKeypointSize(MatOfKeyPoint keypts, double minSize, double maxSize)
        {
            if (keypts != null)
                keypts.ThrowIfDisposed();

            Mat mat = keypts;
            opencvunity_features2D_keypointsFilter_runByKeypointSize2(nativeObj, mat.nativeObj, minSize, maxSize);
        }

        public void runByPixelsMask(MatOfKeyPoint keypts, Mat mask)
        {
            if (keypts != null)
                keypts.ThrowIfDisposed();

            Mat mat = keypts;
            opencvunity_features2D_keypointsFilter_runByPixelsMask(nativeObj, mat.nativeObj, mask.nativeObj);
        }

        public void removeDuplicated(MatOfKeyPoint keypts)
        {
            if (keypts != null)
                keypts.ThrowIfDisposed();

            Mat mat = keypts;
            opencvunity_features2D_keypointsFilter_removeDuplicated(nativeObj, mat.nativeObj);
        }

        public void retainBest(MatOfKeyPoint keypts, int npoints)
        {
            if (keypts != null)
                keypts.ThrowIfDisposed();

            Mat mat = keypts;
            opencvunity_features2D_keypointsFilter_retainBest(nativeObj, mat.nativeObj, npoints);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2D_keypointsFilter_keypointsFilter();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_runByImageBorder(IntPtr nativeObj, IntPtr keypts, double imageSizewidth, double imageSizeHeight, int borderSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_runByKeypointSize1(IntPtr nativeObj, IntPtr keypts, double minSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_runByKeypointSize2(IntPtr nativeObj, IntPtr keypts, double minSize, double maxSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_runByPixelsMask(IntPtr nativeObj, IntPtr keypts, IntPtr mask);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_removeDuplicated(IntPtr nativeObj, IntPtr keypts);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_retainBest(IntPtr nativeObj, IntPtr keypts, int npoints);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2D_keypointsFilter_delete(IntPtr nativeObj);
    }

}