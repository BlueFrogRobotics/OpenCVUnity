
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{
    // C++: class BackgroundSubtractor

    /// <summary>Base class for background/foreground segmentation.</summary>
    ///
    /// <p>class BackgroundSubtractor : public Algorithm <code></p>
    ///
    /// <p>// C++ code:</p>
    ///
    ///
    /// <p>public:</p>
    ///
    /// <p>virtual ~BackgroundSubtractor();</p>
    ///
    /// <p>virtual void operator()(InputArray image, OutputArray fgmask, double
    /// learningRate=0);</p>
    ///
    /// <p>virtual void getBackgroundImage(OutputArray backgroundImage) const;</p>
    ///
    /// <p>};</p>
    ///
    /// <p>The class is only used to define the common interface for the whole family of
    /// background/foreground segmentation algorithms.
    /// </code></p>
    ///
    /// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractor">org.opencv.video.BackgroundSubtractor : public Algorithm</a>
    public class BackgroundSubtractor : Algorithm
    {
        protected override void Dispose(bool disposing)
        {

            try {

                if (disposing) {
                }

                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_video_BackgroundSubtractor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }

        }

        protected BackgroundSubtractor(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:  void BackgroundSubtractor::operator ()(Mat image, Mat& fgmask, double learningRate = 0)
        //

        public void apply(Mat image, Mat fgmask, double learningRate)
        {
            if (image != null)
                image.ThrowIfDisposed();
            if (fgmask != null)
                fgmask.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_video_BackgroundSubtractor_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);

        }

        public void apply(Mat image, Mat fgmask)
        {
            if (image != null)
                image.ThrowIfDisposed();
            if (fgmask != null)
                fgmask.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_video_BackgroundSubtractor_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_video_BackgroundSubtractor_delete(nativeObj);
        //	}



        // C++:  void BackgroundSubtractor::operator ()(Mat image, Mat& fgmask, double learningRate = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_BackgroundSubtractor_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_BackgroundSubtractor_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_BackgroundSubtractor_delete(IntPtr nativeObj);
    }}