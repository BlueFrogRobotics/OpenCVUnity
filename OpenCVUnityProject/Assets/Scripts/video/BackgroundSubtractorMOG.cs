
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity
{

    // C++: class BackgroundSubtractorMOG
    public class BackgroundSubtractorMOG : BackgroundSubtractor
    {
        protected override void Dispose(bool disposing)
        {

            try {

                if (disposing) {
                }

                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_video_BackgroundSubtractorMOG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }

        }

        protected BackgroundSubtractorMOG(IntPtr addr) : base(addr) { }


        //
        // C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG()
        //

        public BackgroundSubtractorMOG() : base(opencvunity_video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_10())
        {

        }


        //
        // C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma = 0)
        //

        public BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma) : base(opencvunity_video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_11(history, nmixtures, backgroundRatio, noiseSigma))
        {
        }

        public BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio) : base(opencvunity_video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_12(history, nmixtures, backgroundRatio))
        {

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_video_BackgroundSubtractorMOG_delete(nativeObj);
        //	}


        // C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_10();

        // C++:   BackgroundSubtractorMOG::BackgroundSubtractorMOG(int history, int nmixtures, double backgroundRatio, double noiseSigma = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_11(int history, int nmixtures, double backgroundRatio, double noiseSigma);
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_BackgroundSubtractorMOG_BackgroundSubtractorMOG_12(int history, int nmixtures, double backgroundRatio);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_BackgroundSubtractorMOG_delete(IntPtr nativeObj);
    }}