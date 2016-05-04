
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{

    // C++: class StereoSGBM
    
	/// <summary>Class for computing stereo correspondence using the semi-global block
	/// matching algorithm.</summary>
	///
	/// <p>class StereoSGBM <code></p>
	///
	/// <p>// C++ code:</p>
	///
	///
	/// <p>StereoSGBM();</p>
	///
	/// <p>StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize,</p>
	///
	/// <p>int P1=0, int P2=0, int disp12MaxDiff=0,</p>
	///
	/// <p>int preFilterCap=0, int uniquenessRatio=0,</p>
	///
	/// <p>int speckleWindowSize=0, int speckleRange=0,</p>
	///
	/// <p>bool fullDP=false);</p>
	///
	/// <p>virtual ~StereoSGBM();</p>
	///
	/// <p>virtual void operator()(InputArray left, InputArray right, OutputArray disp);</p>
	///
	/// <p>int minDisparity;</p>
	///
	/// <p>int numberOfDisparities;</p>
	///
	/// <p>int SADWindowSize;</p>
	///
	/// <p>int preFilterCap;</p>
	///
	/// <p>int uniquenessRatio;</p>
	///
	/// <p>int P1, P2;</p>
	///
	/// <p>int speckleWindowSize;</p>
	///
	/// <p>int speckleRange;</p>
	///
	/// <p>int disp12MaxDiff;</p>
	///
	/// <p>bool fullDP;...</p>
	///
	/// <p>};</p>
	///
	/// <p>The class implements the modified H. Hirschmuller algorithm [HH08] that
	/// differs from the original one as follows: </code></p>
	/// <ul>
	///   <li> By default, the algorithm is single-pass, which means that you
	/// consider only 5 directions instead of 8. Set <code>fullDP=true</code> to run
	/// the full variant of the algorithm but beware that it may consume a lot of
	/// memory.
	///   <li> The algorithm matches blocks, not individual pixels. Though, setting
	/// <code>SADWindowSize=1</code> reduces the blocks to single pixels.
	///   <li> Mutual information cost function is not implemented. Instead, a
	/// simpler Birchfield-Tomasi sub-pixel metric from [BT98] is used. Though, the
	/// color images are supported as well.
	///   <li> Some pre- and post- processing steps from K. Konolige algorithm
	/// :ocv:funcx:"StereoBM.operator()" are included, for example: pre-filtering
	/// (<code>CV_STEREO_BM_XSOBEL</code> type) and post-filtering (uniqueness check,
	/// quadratic interpolation and speckle filtering).
	/// </ul>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> (Python) An example illustrating the use of the StereoSGBM matching
	/// algorithm can be found at opencv_source_code/samples/python2/stereo_match.py
	/// </ul>
	///
	/// <a href="http://docs.opencv.org/modules/calib3d/doc/camera_calibration_and_3d_reconstruction.html#stereosgbm">org.opencv.calib3d.StereoSGBM</a>
	public class StereoSGBM : DisposableOpenCVObject
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
                        opencvunity_calib3d_StereoSGBM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected StereoSGBM(IntPtr addr)
        {
            nativeObj = addr;
        }

        public const int DISP_SHIFT = 4;
        public const int DISP_SCALE = (1 << DISP_SHIFT);




        //
        // C++:   StereoSGBM::StereoSGBM()
        //

        public StereoSGBM()
        {
            nativeObj = opencvunity_calib3d_StereoSGBM_StereoSGBM_10();

        }


        //
        // C++:   StereoSGBM::StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, bool fullDP = false)
        //

        public StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, bool fullDP)
        {
            nativeObj = opencvunity_calib3d_StereoSGBM_StereoSGBM_11(minDisparity, numDisparities, SADWindowSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, fullDP);

        }

        public StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize)
        {
            nativeObj = opencvunity_calib3d_StereoSGBM_StereoSGBM_12(minDisparity, numDisparities, SADWindowSize);

        }


        //
        // C++:  void StereoSGBM::operator ()(Mat left, Mat right, Mat& disp)
        //

        public void compute(Mat left, Mat right, Mat disp)
        {
            if (left != null)
                left.ThrowIfDisposed();
            if (right != null)
                right.ThrowIfDisposed();
            if (disp != null)
                disp.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_compute_10(nativeObj, left.nativeObj, right.nativeObj, disp.nativeObj);

        }


        //
        // C++: int StereoSGBM::minDisparity
        //

        public int get_minDisparity()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1minDisparity_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::minDisparity
        //

        public void set_minDisparity(int minDisparity)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1minDisparity_10(nativeObj, minDisparity);

        }


        //
        // C++: int StereoSGBM::numberOfDisparities
        //

        public int get_numberOfDisparities()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1numberOfDisparities_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::numberOfDisparities
        //

        public void set_numberOfDisparities(int numberOfDisparities)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1numberOfDisparities_10(nativeObj, numberOfDisparities);

        }


        //
        // C++: int StereoSGBM::SADWindowSize
        //

        public int get_SADWindowSize()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1SADWindowSize_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::SADWindowSize
        //

        public void set_SADWindowSize(int SADWindowSize)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1SADWindowSize_10(nativeObj, SADWindowSize);

        }


        //
        // C++: int StereoSGBM::preFilterCap
        //

        public int get_preFilterCap()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1preFilterCap_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::preFilterCap
        //

        public void set_preFilterCap(int preFilterCap)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1preFilterCap_10(nativeObj, preFilterCap);

        }


        //
        // C++: int StereoSGBM::uniquenessRatio
        //

        public int get_uniquenessRatio()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1uniquenessRatio_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::uniquenessRatio
        //

        public void set_uniquenessRatio(int uniquenessRatio)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1uniquenessRatio_10(nativeObj, uniquenessRatio);

        }


        //
        // C++: int StereoSGBM::P1
        //

        public int get_P1()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1P1_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::P1
        //

        public void set_P1(int P1)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1P1_10(nativeObj, P1);

        }


        //
        // C++: int StereoSGBM::P2
        //

        public int get_P2()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1P2_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::P2
        //

        public void set_P2(int P2)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1P2_10(nativeObj, P2);

        }


        //
        // C++: int StereoSGBM::speckleWindowSize
        //

        public int get_speckleWindowSize()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1speckleWindowSize_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::speckleWindowSize
        //

        public void set_speckleWindowSize(int speckleWindowSize)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1speckleWindowSize_10(nativeObj, speckleWindowSize);

        }


        //
        // C++: int StereoSGBM::speckleRange
        //

        public int get_speckleRange()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1speckleRange_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::speckleRange
        //

        public void set_speckleRange(int speckleRange)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1speckleRange_10(nativeObj, speckleRange);

        }


        //
        // C++: int StereoSGBM::disp12MaxDiff
        //

        public int get_disp12MaxDiff()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_calib3d_StereoSGBM_get_1disp12MaxDiff_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::disp12MaxDiff
        //

        public void set_disp12MaxDiff(int disp12MaxDiff)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1disp12MaxDiff_10(nativeObj, disp12MaxDiff);

        }


        //
        // C++: bool StereoSGBM::fullDP
        //

        public bool get_fullDP()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_calib3d_StereoSGBM_get_1fullDP_10(nativeObj);

            return retVal;
        }


        //
        // C++: void StereoSGBM::fullDP
        //

        public void set_fullDP(bool fullDP)
        {
            ThrowIfDisposed();

            opencvunity_calib3d_StereoSGBM_set_1fullDP_10(nativeObj, fullDP);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_calib3d_StereoSGBM_delete(nativeObj);
        //	}





        // C++:   StereoSGBM::StereoSGBM()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_calib3d_StereoSGBM_StereoSGBM_10();

        // C++:   StereoSGBM::StereoSGBM(int minDisparity, int numDisparities, int SADWindowSize, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, bool fullDP = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_calib3d_StereoSGBM_StereoSGBM_11(int minDisparity, int numDisparities, int SADWindowSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, bool fullDP);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_calib3d_StereoSGBM_StereoSGBM_12(int minDisparity, int numDisparities, int SADWindowSize);

        // C++:  void StereoSGBM::operator ()(Mat left, Mat right, Mat& disp)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_compute_10(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disp_nativeObj);

        // C++: int StereoSGBM::minDisparity
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1minDisparity_10(IntPtr nativeObj);

        // C++: void StereoSGBM::minDisparity
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1minDisparity_10(IntPtr nativeObj, int minDisparity);

        // C++: int StereoSGBM::numberOfDisparities
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1numberOfDisparities_10(IntPtr nativeObj);

        // C++: void StereoSGBM::numberOfDisparities
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1numberOfDisparities_10(IntPtr nativeObj, int numberOfDisparities);

        // C++: int StereoSGBM::SADWindowSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1SADWindowSize_10(IntPtr nativeObj);

        // C++: void StereoSGBM::SADWindowSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1SADWindowSize_10(IntPtr nativeObj, int SADWindowSize);

        // C++: int StereoSGBM::preFilterCap
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1preFilterCap_10(IntPtr nativeObj);

        // C++: void StereoSGBM::preFilterCap
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1preFilterCap_10(IntPtr nativeObj, int preFilterCap);

        // C++: int StereoSGBM::uniquenessRatio
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1uniquenessRatio_10(IntPtr nativeObj);

        // C++: void StereoSGBM::uniquenessRatio
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1uniquenessRatio_10(IntPtr nativeObj, int uniquenessRatio);

        // C++: int StereoSGBM::P1
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1P1_10(IntPtr nativeObj);

        // C++: void StereoSGBM::P1
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1P1_10(IntPtr nativeObj, int P1);

        // C++: int StereoSGBM::P2
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1P2_10(IntPtr nativeObj);

        // C++: void StereoSGBM::P2
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1P2_10(IntPtr nativeObj, int P2);

        // C++: int StereoSGBM::speckleWindowSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1speckleWindowSize_10(IntPtr nativeObj);

        // C++: void StereoSGBM::speckleWindowSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1speckleWindowSize_10(IntPtr nativeObj, int speckleWindowSize);

        // C++: int StereoSGBM::speckleRange
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1speckleRange_10(IntPtr nativeObj);

        // C++: void StereoSGBM::speckleRange
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1speckleRange_10(IntPtr nativeObj, int speckleRange);

        // C++: int StereoSGBM::disp12MaxDiff
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_calib3d_StereoSGBM_get_1disp12MaxDiff_10(IntPtr nativeObj);

        // C++: void StereoSGBM::disp12MaxDiff
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1disp12MaxDiff_10(IntPtr nativeObj, int disp12MaxDiff);

        // C++: bool StereoSGBM::fullDP
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_calib3d_StereoSGBM_get_1fullDP_10(IntPtr nativeObj);

        // C++: void StereoSGBM::fullDP
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_set_1fullDP_10(IntPtr nativeObj, bool fullDP);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_calib3d_StereoSGBM_delete(IntPtr nativeObj);
    }}