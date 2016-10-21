
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvSVM
    
	/// <summary>Support Vector Machines.</summary>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> (Python) An example of digit recognition using SVM can be found at
	/// opencv_source/samples/python2/digits.py
	///   <li> (Python) An example of grid search digit recognition using SVM can be
	/// found at opencv_source/samples/python2/digits_adjust.py
	///   <li> (Python) An example of video digit recognition using SVM can be found
	/// at opencv_source/samples/python2/digits_video.py
	/// </ul>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvm">org.opencv.ml.CvSVM : public CvStatModel</a>
	public class CvSVM : CvStatModel
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
                        opencvunity_ml_CvSVM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvSVM(IntPtr addr) : base(addr)
        {
        }

        public const int C_SVC = 100;
        public const int NU_SVC = 101;
        public const int ONE_CLASS = 102;
        public const int EPS_SVR = 103;
        public const int NU_SVR = 104;
        public const int LINEAR = 0;
        public const int POLY = 1;
        public const int RBF = 2;
        public const int SIGMOID = 3;
        public const int C = 0;
        public const int GAMMA = 1;
        public const int P = 2;
        public const int NU = 3;
        public const int COEF = 4;
        public const int DEGREE = 5;


        //
        // C++:   CvSVM::CvSVM()
        //

        public CvSVM() : base(opencvunity_ml_CvSVM_CvSVM_10())
        {
        }


        //
        // C++:   CvSVM::CvSVM(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
        //

        public CvSVM(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params) : base(opencvunity_ml_CvSVM_CvSVM_11(trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj))
        {

        }

        public CvSVM(Mat trainData, Mat responses) : base(opencvunity_ml_CvSVM_CvSVM_12(trainData.nativeObj, responses.nativeObj))
        {
        }


        //
        // C++:  void CvSVM::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVM_clear_10(nativeObj);

        }


        //
        // C++:  int CvSVM::get_support_vector_count()
        //

        public int get_support_vector_count()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvSVM_get_1support_1vector_1count_10(nativeObj);

            return retVal;
        }


        //
        // C++:  int CvSVM::get_var_count()
        //

        public int get_var_count()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvSVM_get_1var_1count_10(nativeObj);

            return retVal;
        }


        //
        // C++:  float CvSVM::predict(Mat sample, bool returnDFVal = false)
        //

        public float predict(Mat sample, bool returnDFVal)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvSVM_predict_10(nativeObj, sample.nativeObj, returnDFVal);

            return retVal;
        }

        public float predict(Mat sample)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvSVM_predict_11(nativeObj, sample.nativeObj);

            return retVal;
        }


        //
        // C++:  void CvSVM::predict(Mat samples, Mat& results)
        //

        public void predict_all(Mat samples, Mat results)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (results != null)
                results.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_ml_CvSVM_predict_1all_10(nativeObj, samples.nativeObj, results.nativeObj);

        }


        //
        // C++:  bool CvSVM::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
        //

        public bool train(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, int flag)
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

            bool retVal = opencvunity_ml_CvSVM_train_10(nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, flag);

            return retVal;
        }

        public bool train(Mat trainData, Mat responses)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvSVM_train_11(nativeObj, trainData.nativeObj, responses.nativeObj);

            return retVal;
        }


        //
        // C++:  bool CvSVM::train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams params, int k_fold = 10, CvParamGrid Cgrid = CvSVM::get_default_grid(CvSVM::C), CvParamGrid gammaGrid = CvSVM::get_default_grid(CvSVM::GAMMA), CvParamGrid pGrid = CvSVM::get_default_grid(CvSVM::P), CvParamGrid nuGrid = CvSVM::get_default_grid(CvSVM::NU), CvParamGrid coeffGrid = CvSVM::get_default_grid(CvSVM::COEF), CvParamGrid degreeGrid = CvSVM::get_default_grid(CvSVM::DEGREE), bool balanced = false)
        //

        public bool train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params, int k_fold, CvParamGrid Cgrid, CvParamGrid gammaGrid, CvParamGrid pGrid, CvParamGrid nuGrid, CvParamGrid coeffGrid, CvParamGrid degreeGrid, bool balanced)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            if (varIdx != null)
                varIdx.ThrowIfDisposed();
            if (sampleIdx != null)
                sampleIdx.ThrowIfDisposed();
            if (_params != null)
                _params.ThrowIfDisposed();
            if (Cgrid != null)
                Cgrid.ThrowIfDisposed();
            if (gammaGrid != null)
                gammaGrid.ThrowIfDisposed();
            if (pGrid != null)
                pGrid.ThrowIfDisposed();
            if (nuGrid != null)
                nuGrid.ThrowIfDisposed();
            if (coeffGrid != null)
                coeffGrid.ThrowIfDisposed();
            if (degreeGrid != null)
                degreeGrid.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvSVM_train_1auto_10(nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj, k_fold, Cgrid.nativeObj, gammaGrid.nativeObj, pGrid.nativeObj, nuGrid.nativeObj, coeffGrid.nativeObj, degreeGrid.nativeObj, balanced);

            return retVal;
        }

        public bool train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams _params)
        {
            if (trainData != null)
                trainData.ThrowIfDisposed();
            if (responses != null)
                responses.ThrowIfDisposed();
            if (varIdx != null)
                varIdx.ThrowIfDisposed();
            if (sampleIdx != null)
                sampleIdx.ThrowIfDisposed();
            if (_params != null)
                _params.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvSVM_train_1auto_11(nativeObj, trainData.nativeObj, responses.nativeObj, varIdx.nativeObj, sampleIdx.nativeObj, _params.nativeObj);

            return retVal;
        }

        // C++:   CvSVM::CvSVM()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvSVM_CvSVM_10();

        // C++:   CvSVM::CvSVM(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvSVM_CvSVM_11(IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvSVM_CvSVM_12(IntPtr trainData_nativeObj, IntPtr responses_nativeObj);

        // C++:  void CvSVM::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVM_clear_10(IntPtr nativeObj);

        // C++:  int CvSVM::get_support_vector_count()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvSVM_get_1support_1vector_1count_10(IntPtr nativeObj);

        // C++:  int CvSVM::get_var_count()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvSVM_get_1var_1count_10(IntPtr nativeObj);

        // C++:  float CvSVM::predict(Mat sample, bool returnDFVal = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvSVM_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, bool returnDFVal);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvSVM_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj);

        // C++:  void CvSVM::predict(Mat samples, Mat& results)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVM_predict_1all_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);

        // C++:  bool CvSVM::train(Mat trainData, Mat responses, Mat varIdx = cv::Mat(), Mat sampleIdx = cv::Mat(), CvSVMParams params = CvSVMParams())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvSVM_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, int flag);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvSVM_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj);

        // C++:  bool CvSVM::train_auto(Mat trainData, Mat responses, Mat varIdx, Mat sampleIdx, CvSVMParams params, int k_fold = 10, CvParamGrid Cgrid = CvSVM::get_default_grid(CvSVM::C), CvParamGrid gammaGrid = CvSVM::get_default_grid(CvSVM::GAMMA), CvParamGrid pGrid = CvSVM::get_default_grid(CvSVM::P), CvParamGrid nuGrid = CvSVM::get_default_grid(CvSVM::NU), CvParamGrid coeffGrid = CvSVM::get_default_grid(CvSVM::COEF), CvParamGrid degreeGrid = CvSVM::get_default_grid(CvSVM::DEGREE), bool balanced = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvSVM_train_1auto_10(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj, int k_fold, IntPtr Cgrid_nativeObj, IntPtr gammaGrid_nativeObj, IntPtr pGrid_nativeObj, IntPtr nuGrid_nativeObj, IntPtr coeffGrid_nativeObj, IntPtr degreeGrid_nativeObj, bool balanced);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvSVM_train_1auto_11(IntPtr nativeObj, IntPtr trainData_nativeObj, IntPtr responses_nativeObj, IntPtr varIdx_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVM_delete(IntPtr nativeObj);
    }}