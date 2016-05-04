
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvNormalBayesClassifier
    
	/// <summary>Bayes classifier for normally distributed data.</summary>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/normal_bayes_classifier.html#cvnormalbayesclassifier">org.opencv.ml.CvNormalBayesClassifier : public CvStatModel</a>
	public class CvNormalBayesClassifier : CvStatModel
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
                        opencvunity_ml_CvNormalBayesClassifier_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvNormalBayesClassifier(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   CvNormalBayesClassifier::CvNormalBayesClassifier()
        //

        public CvNormalBayesClassifier() : base(opencvunity_ml_CvNormalBayesClassifier_CvNormalBayesClassifier_10())
        {

        }


        //
        // C++:   CvNormalBayesClassifier::CvNormalBayesClassifier(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat())
        //

        public CvNormalBayesClassifier(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx) : base(opencvunity_ml_CvNormalBayesClassifier_CvNormalBayesClassifier_11(trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj))
        {

        }

        public CvNormalBayesClassifier(Mat trainData, Mat responses) : base(opencvunity_ml_CvNormalBayesClassifier_CvNormalBayesClassifier_12(trainData.nativeObj, responses.nativeObj))
        {

        }


        //
        // C++:  void CvNormalBayesClassifier::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_CvNormalBayesClassifier_clear_10(nativeObj);

        }


        //
        // C++:  float CvNormalBayesClassifier::predict(Mat samples, Mat* results = 0)
        //

        public float predict(Mat samples, Mat results)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (results != null)
                results.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvNormalBayesClassifier_predict_10(nativeObj, samples.nativeObj, results.nativeObj);

            return retVal;
        }

        public float predict(Mat samples)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvNormalBayesClassifier_predict_11(nativeObj, samples.nativeObj);

            return retVal;
        }


        //
        // C++:  bool CvNormalBayesClassifier::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), bool update = false)
        //

        public bool train(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, bool update)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            if (varIdx != null)
                varIdx.ThrowIfDisposed();
            if (sampleIdx != null)
                sampleIdx.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvNormalBayesClassifier_train_10(nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, update);

            return retVal;
        }

        public bool train(Mat trainData, Mat responses)
        {
            bool retVal = opencvunity_ml_CvNormalBayesClassifier_train_11(nativeObj, trainData.nativeObj, responses.nativeObj);

            return retVal;
        }

        // C++:   CvNormalBayesClassifier::CvNormalBayesClassifier()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvNormalBayesClassifier_CvNormalBayesClassifier_10();

        // C++:   CvNormalBayesClassifier::CvNormalBayesClassifier(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvNormalBayesClassifier_CvNormalBayesClassifier_11(IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvNormalBayesClassifier_CvNormalBayesClassifier_12(IntPtr trainData_nativeObj, IntPtr responses_nativeObj);

        // C++:  void CvNormalBayesClassifier::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvNormalBayesClassifier_clear_10(IntPtr nativeObj);

        // C++:  float CvNormalBayesClassifier::predict(Mat samples, Mat* results = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvNormalBayesClassifier_predict_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvNormalBayesClassifier_predict_11(IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  bool CvNormalBayesClassifier::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), bool update = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvNormalBayesClassifier_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, bool update);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvNormalBayesClassifier_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvNormalBayesClassifier_delete(IntPtr nativeObj);
    }}