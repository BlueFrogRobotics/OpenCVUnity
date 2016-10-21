
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvDTree
    
	/// <summary>The class implements a decision tree as described in the beginning of this
	/// section.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtree">org.opencv.ml.CvDTree : public CvStatModel</a>
	public class CvDTree : CvStatModel
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
                        opencvunity_ml_CvDTree_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvDTree(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   CvDTree::CvDTree()
        //

        public CvDTree() : base(opencvunity_ml_CvDTree_CvDTree_10())
        {

        }


        //
        // C++:  void CvDTree::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTree_clear_10(nativeObj);

        }


        //
        // C++:  Mat CvDTree::getVarImportance()
        //

        public Mat getVarImportance()
        {
            ThrowIfDisposed();

            Mat retVal = new Mat(opencvunity_ml_CvDTree_getVarImportance_10(nativeObj));

            return retVal;
        }


        //
        // C++:  CvDTreeNode* CvDTree::predict(Mat sample, Mat missingDataMask = cv::Mat(), bool preprocessedInput = false)
        //

        // Return type 'CvDTreeNode*' is not supported, skipping the function


        //
        // C++:  bool CvDTree::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvDTreeParams params = CvDTreeParams())
        //

        public bool train(Mat trainData, int tflag, Mat responses, Mat varIdx, Mat sampleIdx, Mat varType, Mat missingDataMask, int flag)
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
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvDTree_train_10(nativeObj, trainData.nativeObj, tflag, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, varType.nativeObj, missingDataMask.nativeObj, flag);

            return retVal;
        }

        public bool train(Mat trainData, int tflag, Mat responses)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvDTree_train_11(nativeObj, trainData.nativeObj, tflag, responses.nativeObj);

            return retVal;
        }


        // C++:   CvDTree::CvDTree()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvDTree_CvDTree_10();

        // C++:  void CvDTree::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTree_clear_10(IntPtr nativeObj);

        // C++:  Mat CvDTree::getVarImportance()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvDTree_getVarImportance_10(IntPtr nativeObj);

        // C++:  bool CvDTree::train(Mat trainData, int tflag, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), Mat varType = cv::Mat(), Mat missingDataMask = cv::Mat(), CvDTreeParams params = CvDTreeParams())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvDTree_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr varType_nativeObj, IntPtr missingDataMask_nativeObj, int flag);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvDTree_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, int tflag, IntPtr responses_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTree_delete(IntPtr nativeObj);
    }}