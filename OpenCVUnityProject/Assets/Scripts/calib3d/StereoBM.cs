
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{



    // C++: class StereoBM
    
	/// <summary>Class for computing stereo correspondence using the block matching algorithm.</summary>
	///
	/// <p>// Block matching stereo correspondence algorithm class StereoBM <code></p>
	///
	/// <p>// C++ code:</p>
	///
	///
	/// <p>enum { NORMALIZED_RESPONSE = CV_STEREO_BM_NORMALIZED_RESPONSE,</p>
	///
	/// <p>BASIC_PRESET=CV_STEREO_BM_BASIC,</p>
	///
	/// <p>FISH_EYE_PRESET=CV_STEREO_BM_FISH_EYE,</p>
	///
	/// <p>NARROW_PRESET=CV_STEREO_BM_NARROW };</p>
	///
	/// <p>StereoBM();</p>
	///
	/// <p>// the preset is one of..._PRESET above.</p>
	///
	/// <p>// ndisparities is the size of disparity range,</p>
	///
	/// <p>// in which the optimal disparity at each pixel is searched for.</p>
	///
	/// <p>// SADWindowSize is the size of averaging window used to match pixel blocks</p>
	///
	/// <p>// (larger values mean better robustness to noise, but yield blurry disparity
	/// maps)</p>
	///
	/// <p>StereoBM(int preset, int ndisparities=0, int SADWindowSize=21);</p>
	///
	/// <p>// separate initialization function</p>
	///
	/// <p>void init(int preset, int ndisparities=0, int SADWindowSize=21);</p>
	///
	/// <p>// computes the disparity for the two rectified 8-bit single-channel images.</p>
	///
	/// <p>// the disparity will be 16-bit signed (fixed-point) or 32-bit floating-point
	/// image of the same size as left.</p>
	///
	/// <p>void operator()(InputArray left, InputArray right, OutputArray disparity, int
	/// disptype=CV_16S);</p>
	///
	/// <p>Ptr<CvStereoBMState> state;</p>
	///
	/// <p>};</p>
	///
	/// <p>The class is a C++ wrapper for the associated functions. In particular,
	/// :ocv:funcx:"StereoBM.operator()" is the wrapper for </code></p>
	///
	/// <p>"cvFindStereoCorrespondenceBM"... Sample code:</p>
	///
	/// <p>(Ocl) An example for using the stereoBM matching algorithm can be found at
	/// opencv_source_code/samples/ocl/stereo_match.cpp</p>
	///
	/// <a href="http://docs.opencv.org/modules/calib3d/doc/camera_calibration_and_3d_reconstruction.html#stereobm">org.opencv.calib3d.StereoBM</a>
	public class StereoBM : DisposableOpenCVObject
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
                        opencvunity_calib3d_StereoBM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected StereoBM(IntPtr addr)
        {
            nativeObj = addr;
        }

        public const int PREFILTER_NORMALIZED_RESPONSE = 0;
        public const int PREFILTER_XSOBEL = 1;
        public const int BASIC_PRESET = 0;
        public const int FISH_EYE_PRESET = 1;
        public const int NARROW_PRESET = 2;




        //
        // C++:   StereoBM::StereoBM()
        //

        public StereoBM()
        {
            nativeObj = opencvunity_calib3d_StereoBM_StereoBM_10();

        }


        //
        // C++:   StereoBM::StereoBM(int preset, int ndisparities = 0, int SADWindowSize = 21)
        //

        public StereoBM(int preset, int ndisparities, int SADWindowSize)
        {
            nativeObj = opencvunity_calib3d_StereoBM_StereoBM_11(preset, ndisparities, SADWindowSize);

        }

        public StereoBM(int preset)
        {
            nativeObj = opencvunity_calib3d_StereoBM_StereoBM_12(preset);

        }


        //
        // C++:  void StereoBM::operator ()(Mat left, Mat right, Mat& disparity, int disptype = CV_16S)
        //

        public void compute(Mat left, Mat right, Mat disparity, int disptype)
        {
            if (left != null)
                left.ThrowIfDisposed();
            if (right != null)
                right.ThrowIfDisposed();
            if (disparity != null)
                disparity.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_calib3d_StereoBM_compute_10(nativeObj, left.nativeObj, right.nativeObj, disparity.nativeObj, disptype);

        }

        public void compute(Mat left, Mat right, Mat disparity)
        {
            if (left != null)
                left.ThrowIfDisposed();
            if (right != null)
                right.ThrowIfDisposed();
            if (disparity != null)
                disparity.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_calib3d_StereoBM_compute_11(nativeObj, left.nativeObj, right.nativeObj, disparity.nativeObj);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_calib3d_StereoSGBM_delete(nativeObj);
        //	}



        // C++:   StereoBM::StereoBM()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_calib3d_StereoBM_StereoBM_10();

        // C++:   StereoBM::StereoBM(int preset, int ndisparities = 0, int SADWindowSize = 21)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_calib3d_StereoBM_StereoBM_11(int preset, int ndisparities, int SADWindowSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_calib3d_StereoBM_StereoBM_12(int preset);

        // C++:  void StereoBM::operator ()(Mat left, Mat right, Mat& disparity, int disptype = CV_16S)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoBM_compute_10(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disparity_nativeObj, int disptype);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoBM_compute_11(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disparity_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoBM_delete(IntPtr nativeObj);
    }}