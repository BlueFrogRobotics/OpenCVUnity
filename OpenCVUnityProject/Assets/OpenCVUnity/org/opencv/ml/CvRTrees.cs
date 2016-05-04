
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvRTrees
    
	/// <summary>The class implements the random forest predictor as described in the
	/// beginning of this section.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtrees">org.opencv.ml.CvRTrees : public CvStatModel</a>
	public class CvRTrees : CvStatModel
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
                        opencvunity_ml_CvRTrees_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvRTrees(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   CvRTrees::CvRTrees()
        //

        public CvRTrees() : base(opencvunity_ml_CvRTrees_CvRTrees_10())
        {

        }


        //
        // C++:  void CvRTrees::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_CvRTrees_clear_10(nativeObj);

        }


        //
        // C++:  Mat CvRTrees::getVarImportance()
        //

        public Mat getVarImportance()
        {
            ThrowIfDisposed();

            Mat retVal = new Mat(opencvunity_ml_CvRTrees_getVarImportance_10(nativeObj));

            return retVal;
        }


        //
        // C++:  float CvRTrees::predict(Mat sample, Mat missing = cv::Mat())
        //

        public float predict(Mat sample, Mat missing)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            if (missing != null)
                missing.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvRTrees_predict_10(nativeObj, sample.nativeObj, missing.nativeObj);

            return retVal;
        }

        public float predict(Mat sample)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvRTrees_predict_11(nativeObj, sample.nativeObj);

            return retVal;
        }


        //
        // C++:  float CvRTrees::predict_prob(Mat sample, Mat missing = cv::Mat())
        //

        public float predict_prob(Mat sample, Mat missing)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            if (missing != null)
                missing.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvRTrees_predict_1prob_10(nativeObj, sample.nativeObj, missing.nativeObj);

            return retVal;
        }

        public float predict_prob(Mat sample)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvRTrees_predict_1prob_11(nativeObj, sample.nativeObj);

            return retVal;
        }


        //
        // C++:  bool CvRTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
        //

        public virtual bool train(Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvRTParams _params)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            if (varIdx != null)
                varIdx.ThrowIfDisposed();
            if (sampleIdx != null)
                sampleIdx.ThrowIfDisposed();
            if (varType != null)
                varType.ThrowIfDisposed();
            if (missingDataMask != null)
                missingDataMask.ThrowIfDisposed();
            if (_params != null)
                _params.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvRTrees_train_10(nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj);

            return retVal;
        }

        public virtual bool train(Mat trainData, int tflag, Mat responses)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvRTrees_train_11(nativeObj, trainData.nativeObj, tflag, responses.nativeObj);

            return retVal;
        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_ml_CvRTrees_delete(nativeObj);
        //	}



        // C++:   CvRTrees::CvRTrees()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvRTrees_CvRTrees_10();

        // C++:  void CvRTrees::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvRTrees_clear_10(IntPtr nativeObj);

        // C++:  Mat CvRTrees::getVarImportance()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvRTrees_getVarImportance_10(IntPtr nativeObj);

        // C++:  float CvRTrees::predict(Mat sample, Mat missing = cv::Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvRTrees_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvRTrees_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);

        // C++:  float CvRTrees::predict_prob(Mat sample, Mat missing = cv::Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvRTrees_predict_1prob_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvRTrees_predict_1prob_11(IntPtr nativeObj, IntPtr sample_nativeObj);

        // C++:  bool CvRTrees::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvRTParams params = CvRTParams())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvRTrees_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvRTrees_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvRTrees_delete(IntPtr nativeObj);
    }}