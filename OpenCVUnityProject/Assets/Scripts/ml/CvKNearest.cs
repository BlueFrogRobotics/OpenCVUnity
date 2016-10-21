
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvKNearest
    
	/// <summary>The class implements K-Nearest Neighbors model as described in the beginning
	/// of this section.</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> (Python) An example of digit recognition using KNearest can be found
	/// at opencv_source/samples/python2/digits.py
	///   <li> (Python) An example of grid search digit recognition using KNearest
	/// can be found at opencv_source/samples/python2/digits_adjust.py
	///   <li> (Python) An example of video digit recognition using KNearest can be
	/// found at opencv_source/samples/python2/digits_video.py
	/// </ul>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/k_nearest_neighbors.html#cvknearest">org.opencv.ml.CvKNearest : public CvStatModel</a>
	public class CvKNearest : CvStatModel
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
                        opencvunity_ml_CvKNearest_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvKNearest(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   CvKNearest::CvKNearest()
        //

        public CvKNearest() : base(opencvunity_ml_CvKNearest_CvKNearest_10())
        {
        }


        //
        // C++:   CvKNearest::CvKNearest(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int max_k = 32)
        //

        public CvKNearest(Mat trainData, Mat responses, Mat sampleIdx, bool isRegression, int max_k) : base(opencvunity_ml_CvKNearest_CvKNearest_11(trainData.nativeObj, responses.nativeObj, sampleIdx.nativeObj, isRegression, max_k))
        {

        }

        public CvKNearest(Mat trainData, Mat responses) : base(opencvunity_ml_CvKNearest_CvKNearest_12(trainData.nativeObj, responses.nativeObj))
        {

        }


        //
        // C++:  float CvKNearest::find_nearest(Mat samples, int k, Mat& results, Mat& neighborResponses, Mat& dists)
        //

        public float find_nearest(Mat samples, int k, Mat results, Mat neighborResponses, Mat dists)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (results != null)
                results.ThrowIfDisposed();
            if (neighborResponses != null)
                neighborResponses.ThrowIfDisposed();
            if (dists != null)
                dists.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvKNearest_find_1nearest_10(nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj, dists.nativeObj);

            return retVal;
        }


        //
        // C++:  bool CvKNearest::train(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int maxK = 32, bool updateBase = false)
        //

        public bool train(Mat trainData, Mat responses, Mat sampleIdx, bool isRegression, int maxK, bool updateBase)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            if (sampleIdx != null)
                sampleIdx.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvKNearest_train_10(nativeObj, trainData.nativeObj, responses.nativeObj, sampleIdx.nativeObj, isRegression, maxK, updateBase);

            return retVal;
        }

        public bool train(Mat trainData, Mat responses)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvKNearest_train_11(nativeObj, trainData.nativeObj, responses.nativeObj);

            return retVal;
        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			_opencvunity_ml_CvKNearest_delete(nativeObj);
        //	}



        // C++:   CvKNearest::CvKNearest()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvKNearest_CvKNearest_10();

        // C++:   CvKNearest::CvKNearest(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int max_k = 32)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvKNearest_CvKNearest_11(IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr sampleIdx_nativeObj, bool isRegression, int max_k);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvKNearest_CvKNearest_12(IntPtr trainData_nativeObj, IntPtr responses_nativeObj);

        // C++:  float CvKNearest::find_nearest(Mat samples, int k, Mat& results, Mat& neighborResponses, Mat& dists)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvKNearest_find_1nearest_10(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj, IntPtr dists_nativeObj);

        // C++:  bool CvKNearest::train(Mat trainData, Mat responses, Mat sampleIdx = cv::Mat(), bool isRegression = false, int maxK = 32, bool updateBase = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvKNearest_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr sampleIdx_nativeObj, bool isRegression, int maxK, bool updateBase);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvKNearest_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvKNearest_delete(IntPtr nativeObj);
    }}