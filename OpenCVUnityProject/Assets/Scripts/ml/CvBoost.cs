
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{

    // C++: class CvBoost
    
	/// <summary>Boosted tree classifier derived from "CvStatModel".</summary>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboost">org.opencv.ml.CvBoost : public CvStatModel</a>
	public class CvBoost : CvStatModel
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
                        opencvunity_ml_CvBoost_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvBoost(IntPtr addr) : base(addr)
        {
        }

        public const int DISCRETE = 0;
        public const int REAL = 1;
        public const int LOGIT = 2;
        public const int GENTLE = 3;
        public const int DEFAULT = 0;
        public const int GINI = 1;
        public const int MISCLASS = 3;
        public const int SQERR = 4;


        //
        // C++:   CvBoost::CvBoost()
        //

        public CvBoost() : base(opencvunity_ml_CvBoost_CvBoost_10())
        {
        }


        //
        // C++:   CvBoost::CvBoost(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams())
        //

        public CvBoost(Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvBoostParams _params) : base(opencvunity_ml_CvBoost_CvBoost_11(trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj))
        {
        }

        public CvBoost(Mat trainData, int tflag, Mat responses) : base(opencvunity_ml_CvBoost_CvBoost_12(trainData.nativeObj, tflag, responses.nativeObj))
        {
        }


        //
        // C++:  void CvBoost::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_CvBoost_clear_10(nativeObj);

        }


        //
        // C++:  float CvBoost::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), bool rawMode = false, bool returnSum = false)
        //

        public float predict(Mat sample, Mat missing, Range slice, bool rawMode, bool returnSum)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            if (missing != null)
                missing.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvBoost_predict_10(nativeObj, sample.nativeObj, missing.nativeObj, slice.start, slice.end, rawMode, returnSum);

            return retVal;
        }

        public float predict(Mat sample)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvBoost_predict_11(nativeObj, sample.nativeObj);

            return retVal;
        }


        //
        // C++:  void CvBoost::prune(CvSlice slice)
        //

        //public void prune(Range slice)
        //{
        //    ThrowIfDisposed();

        //    opencvunity_ml_CvBoost_prune_10(nativeObj, slice.start, slice.end);

        //}


        //
        // C++:  bool CvBoost::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams(), bool update = false)
        //

        public bool train(Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, CvBoostParams _params, bool update)
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

            bool retVal = opencvunity_ml_CvBoost_train_10(nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, _params.nativeObj, update);

            return retVal;
        }

        public bool train(Mat trainData, int tflag, Mat responses)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvBoost_train_11(nativeObj, trainData.nativeObj, tflag, responses.nativeObj);

            return retVal;
        }

        // C++:   CvBoost::CvBoost()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvBoost_CvBoost_10();

        // C++:   CvBoost::CvBoost(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvBoost_CvBoost_11(IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvBoost_CvBoost_12(IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);

        // C++:  void CvBoost::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoost_clear_10(IntPtr nativeObj);

        // C++:  float CvBoost::predict(Mat sample, Mat missing = cv::Mat(), Range slice = cv::Range::all(), bool rawMode = false, bool returnSum = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvBoost_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr missing_nativeObj, int slice_start, int slice_end, bool rawMode, bool returnSum);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvBoost_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);

        // C++:  void CvBoost::prune(CvSlice slice)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoost_prune_10(IntPtr nativeObj, int slice_start, int slice_end);

        // C++:  bool CvBoost::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvBoostParams params = CvBoostParams(), bool update = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvBoost_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, IntPtr params_nativeObj, bool update);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvBoost_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoost_delete(IntPtr nativeObj);
    }}