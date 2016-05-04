
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{

    // C++: class EM

    /// <summary>The class implements the EM algorithm as described in the beginning of this
    /// section. It is inherited from "Algorithm".</p>
    ///
    /// <a href="http://docs.opencv.org/modules/ml/doc/expectation_maximization.html#em">org.opencv.ml.EM : public Algorithm</a>
    public class EM : CvStatModel
    {
        public const int COV_MAT_SPHERICAL = 0;
        public const int COV_MAT_DIAGONAL = 1;
        public const int COV_MAT_GENERIC = 2;
        public const int COV_MAT_DEFAULT = COV_MAT_DIAGONAL;
        public const int DEFAULT_NCLUSTERS = 5;
        public const int DEFAULT_MAX_ITERS = 100;
        public const int START_E_STEP = 1;
        public const int START_M_STEP = 2;
        public const int START_AUTO_STEP = 0;

        protected override void Dispose(bool disposing)
        {
            try
            {

                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_ml_EM_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        protected EM(IntPtr addr) : base(addr)
        {
        }

        //
        // C++:   EM::EM(int nclusters = EM::DEFAULT_NCLUSTERS, int covMatType = EM::COV_MAT_DIAGONAL, TermCriteria termCrit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, EM::DEFAULT_MAX_ITERS, FLT_EPSILON))
        //

        public EM(int nclusters, int covMatType, TermCriteria termCrit)
            : base(opencvunity_ml_EM_EM_10(nclusters, covMatType, termCrit.type, termCrit.maxCount, termCrit.epsilon))
        {
        }

        public EM() : base(opencvunity_ml_EM_EM_11())
        {
        }


        //
        // C++:  void EM::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_ml_EM_clear_10(nativeObj);
        }


        //
        // C++:  bool EM::isTrained()
        //

        public bool isTrained()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_isTrained_10(nativeObj);

            return retVal;
        }


        //
        // C++:  Vec2d EM::predict(Mat sample, Mat& probs = Mat())
        //

        public double[] predict(Mat sample, Mat probs)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            if (probs != null)
                probs.ThrowIfDisposed();
            ThrowIfDisposed();


            double[] retVal = new double[2];
            opencvunity_ml_EM_predict_10(nativeObj, sample.nativeObj, probs.nativeObj, retVal);

            return retVal;
        }

        public double[] predict(Mat sample)
        {
            if (sample != null)
                sample.ThrowIfDisposed();
            ThrowIfDisposed();

            double[] retVal = new double[2];
            opencvunity_ml_EM_predict_11(nativeObj, sample.nativeObj, retVal);

            return retVal;
        }


        //
        // C++:  bool EM::train(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        public bool train(Mat samples, Mat logLikelihoods, Mat labels, Mat probs)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (logLikelihoods != null)
                logLikelihoods.ThrowIfDisposed();
            if (labels != null)
                labels.ThrowIfDisposed();
            if (probs != null)
                probs.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_train_10(nativeObj, samples.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);

            return retVal;
        }

        public bool train(Mat samples)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_train_11(nativeObj, samples.nativeObj);

            return retVal;
        }


        //
        // C++:  bool EM::trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        public bool trainE(Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels, Mat probs)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (means0 != null)
                means0.ThrowIfDisposed();
            if (covs0 != null)
                covs0.ThrowIfDisposed();
            if (weights0 != null)
                weights0.ThrowIfDisposed();
            if (logLikelihoods != null)
                logLikelihoods.ThrowIfDisposed();
            if (labels != null)
                labels.ThrowIfDisposed();
            if (probs != null)
                probs.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_trainE_10(nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);

            return retVal;
        }

        public bool trainE(Mat samples, Mat means0)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (means0 != null)
                means0.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_trainE_11(nativeObj, samples.nativeObj, means0.nativeObj);

            return retVal;
        }


        //
        // C++:  bool EM::trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        //

        public bool trainM(Mat samples, Mat probs0, Mat logLikelihoods, Mat labels, Mat probs)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (probs0 != null)
                probs0.ThrowIfDisposed();
            if (logLikelihoods != null)
                logLikelihoods.ThrowIfDisposed();
            if (labels != null)
                labels.ThrowIfDisposed();
            if (probs != null)
                probs.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_trainM_10(nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);

            return retVal;
        }

        public bool trainM(Mat samples, Mat probs0)
        {
            if (samples != null)
                samples.ThrowIfDisposed();
            if (probs0 != null)
                probs0.ThrowIfDisposed();
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_EM_trainM_11(nativeObj, samples.nativeObj, probs0.nativeObj);

            return retVal;
        }


        // C++:   EM::EM(int nclusters = EM::DEFAULT_NCLUSTERS, int covMatType = EM::COV_MAT_DIAGONAL, TermCriteria termCrit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, EM::DEFAULT_MAX_ITERS, FLT_EPSILON))
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_EM_EM_10(int nclusters, int covMatType, int termCrit_type, int termCrit_maxCount, double termCrit_epsilon);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_EM_EM_11();

        // C++:  void EM::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_EM_clear_10(IntPtr nativeObj);

        // C++:  bool EM::isTrained()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_isTrained_10(IntPtr nativeObj);

        // C++:  Vec2d EM::predict(Mat sample, Mat& probs = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_EM_predict_10(IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr probs_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_EM_predict_11(IntPtr nativeObj, IntPtr sample_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

        // C++:  bool EM::train(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_train_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_train_11(IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  bool EM::trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_trainE_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_trainE_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj);

        // C++:  bool EM::trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_trainM_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_EM_trainM_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_EM_delete(IntPtr nativeObj);
    }}