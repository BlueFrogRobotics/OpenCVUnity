
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvANN_MLP
    
	/// <summary>MLP model.</summary>
	///
	/// <p>Unlike many other models in ML that are constructed and trained at once, in
	/// the MLP model these steps are separated. First, a network with the specified
	/// topology is created using the non-default constructor or the method
	/// "CvANN_MLP.create". All the weights are set to zeros. Then, the network is
	/// trained using a set of input and output vectors. The training procedure can
	/// be repeated more than once, that is, the weights can be adjusted based on the
	/// new training data.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp">org.opencv.ml.CvANN_MLP : public CvStatModel</a>
	public class CvANN_MLP : CvStatModel
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
                        opencvunity_ml_CvANN_1MLP_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvANN_MLP(IntPtr addr) : base(addr)
        {
        }

        public const int IDENTITY = 0;
        public const int SIGMOID_SYM = 1;
        public const int GAUSSIAN = 2;
        public const int UPDATE_WEIGHTS = 1;
        public const int NO_INPUT_SCALE = 2;
        public const int NO_OUTPUT_SCALE = 4;

        //
        // C++:   CvANN_MLP::CvANN_MLP()
        //

        public CvANN_MLP() : base(opencvunity_ml_CvANN_1MLP_CvANN_1MLP_10())
        {

        }


        //
        // C++:   CvANN_MLP::CvANN_MLP(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
        //


        public CvANN_MLP(Mat layerSizes, int activateFunc, double fparam1, double fparam2) : base(opencvunity_ml_CvANN_1MLP_CvANN_1MLP_11(layerSizes.nativeObj, activateFunc, fparam1, fparam2))
        {

        }


        public CvANN_MLP(Mat layerSizes) : base(opencvunity_ml_CvANN_1MLP_CvANN_1MLP_12(layerSizes.nativeObj))
        {

        }


        //
        // C++:  void CvANN_MLP::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_CvANN_1MLP_clear_10(nativeObj);

        }

        //
        // C++:  void CvANN_MLP::create(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
        //

        public void create(Mat layerSizes, int activateFunc, double fparam1, double fparam2)
        {
            if (layerSizes != null)
                layerSizes.ThrowIfDisposed();
            ThrowIfDisposed();


            opencvunity_ml_CvANN_1MLP_create_10(nativeObj, layerSizes.nativeObj, activateFunc, fparam1, fparam2);

        }

        public void create(Mat layerSizes)
        {
            if (layerSizes != null)
                layerSizes.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_ml_CvANN_1MLP_create_11(nativeObj, layerSizes.nativeObj);

        }


        //
        // C++:  float CvANN_MLP::predict(Mat inputs, Mat& outputs)
        //

        public float predict(Mat inputs, Mat outputs)
        {
            if (inputs != null)
                inputs.ThrowIfDisposed();
            if (outputs != null)
                outputs.ThrowIfDisposed();
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvANN_1MLP_predict_10(nativeObj, inputs.nativeObj, outputs.nativeObj);

            return retVal;
        }


        //
        // C++:  int CvANN_MLP::train(Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx = cv::Mat(), CvANN_MLP_TrainParams params = CvANN_MLP_TrainParams(), int flags = 0)
        //

        public int train(Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx, CvANN_MLP_TrainParams _params, int flags)
        {
            if (inputs != null)
                inputs.ThrowIfDisposed();
            if (outputs != null)
                outputs.ThrowIfDisposed();
            if (sampleWeights != null)
                sampleWeights.ThrowIfDisposed();
            if (sampleIdx != null)
                sampleIdx.ThrowIfDisposed();
            if (_params != null)
                _params.ThrowIfDisposed();
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvANN_1MLP_train_10(nativeObj, inputs.nativeObj, outputs.nativeObj, sampleWeights.nativeObj, sampleIdx.nativeObj, _params.nativeObj, flags);

            return retVal;
        }

        public int train(Mat inputs, Mat outputs, Mat sampleWeights)
        {
            if (inputs != null)
                inputs.ThrowIfDisposed();
            if (outputs != null)
                outputs.ThrowIfDisposed();
            if (sampleWeights != null)
                sampleWeights.ThrowIfDisposed();
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvANN_1MLP_train_11(nativeObj, inputs.nativeObj, outputs.nativeObj, sampleWeights.nativeObj);

            return retVal;
        }

        // C++:   CvANN_MLP::CvANN_MLP()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvANN_1MLP_CvANN_1MLP_10();

        // C++:   CvANN_MLP::CvANN_MLP(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvANN_1MLP_CvANN_1MLP_11(IntPtr layerSizes_nativeObj, int activateFunc, double fparam1, double fparam2);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvANN_1MLP_CvANN_1MLP_12(IntPtr layerSizes_nativeObj);

        // C++:  void CvANN_MLP::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvANN_1MLP_clear_10(IntPtr nativeObj);

        // C++:  void CvANN_MLP::create(Mat layerSizes, int activateFunc = CvANN_MLP::SIGMOID_SYM, double fparam1 = 0, double fparam2 = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvANN_1MLP_create_10(IntPtr nativeObj, IntPtr layerSizes_nativeObj, int activateFunc, double fparam1, double fparam2);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvANN_1MLP_create_11(IntPtr nativeObj, IntPtr layerSizes_nativeObj);

        // C++:  float CvANN_MLP::predict(Mat inputs, Mat& outputs)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvANN_1MLP_predict_10(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj);

        // C++:  int CvANN_MLP::train(Mat inputs, Mat outputs, Mat sampleWeights, Mat sampleIdx = cv::Mat(), CvANN_MLP_TrainParams params = CvANN_MLP_TrainParams(), int flags = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvANN_1MLP_train_10(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr sampleWeights_nativeObj, IntPtr sampleIdx_nativeObj, IntPtr params_nativeObj, int flags);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvANN_1MLP_train_11(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr sampleWeights_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvANN_1MLP_delete(IntPtr nativeObj);
    }}