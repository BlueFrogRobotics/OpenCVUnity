
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvSVMParams
    
	/// <summary>SVM training parameters.</summary>
	///
	/// <p>The structure must be initialized and passed to the training method of
	/// "CvSVM".</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvsvmparams">org.opencv.ml.CvSVMParams</a>
	public class CvSVMParams : DisposableOpenCVObject
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
                        opencvunity_ml_CvSVMParams_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        public CvSVMParams()
        {
            nativeObj = opencvunity_ml_CvSVMParams_CvSVMParams_10();

        }


        //
        // C++: int CvSVMParams::svm_type
        //

        public int get_svm_type()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvSVMParams_get_1svm_1type_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::svm_type
        //

        public void set_svm_type(int svm_type)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1svm_1type_10(nativeObj, svm_type);

        }


        //
        // C++: int CvSVMParams::kernel_type
        //

        public int get_kernel_type()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvSVMParams_get_1kernel_1type_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::kernel_type
        //

        public void set_kernel_type(int kernel_type)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1kernel_1type_10(nativeObj, kernel_type);

        }


        //
        // C++: double CvSVMParams::degree
        //

        public double get_degree()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvSVMParams_get_1degree_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::degree
        //

        public void set_degree(double degree)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1degree_10(nativeObj, degree);

        }


        //
        // C++: double CvSVMParams::gamma
        //

        public double get_gamma()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvSVMParams_get_1gamma_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::gamma
        //

        public void set_gamma(double gamma)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1gamma_10(nativeObj, gamma);

        }


        //
        // C++: double CvSVMParams::coef0
        //

        public double get_coef0()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvSVMParams_get_1coef0_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::coef0
        //

        public void set_coef0(double coef0)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1coef0_10(nativeObj, coef0);

        }


        //
        // C++: double CvSVMParams::C
        //

        public double get_C()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvSVMParams_get_1C_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::C
        //

        public void set_C(double C)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1C_10(nativeObj, C);

        }


        //
        // C++: double CvSVMParams::nu
        //

        public double get_nu()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvSVMParams_get_1nu_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::nu
        //

        public void set_nu(double nu)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1nu_10(nativeObj, nu);

        }


        //
        // C++: double CvSVMParams::p
        //

        public double get_p()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvSVMParams_get_1p_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvSVMParams::p
        //

        public void set_p(double p)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1p_10(nativeObj, p);

        }


        //
        // C++: TermCriteria CvSVMParams::term_crit
        //

        public TermCriteria get_term_crit()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            opencvunity_ml_CvSVMParams_get_1term_1crit_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++: void CvSVMParams::term_crit
        //

        public void set_term_crit(TermCriteria term_crit)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvSVMParams_set_1term_1crit_10(nativeObj, term_crit.type, term_crit.maxCount, term_crit.epsilon);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_ml_CvSVMParams_delete(nativeObj);
        //	}



        // C++:   CvSVMParams::CvSVMParams()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvSVMParams_CvSVMParams_10();

        // C++: int CvSVMParams::svm_type
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvSVMParams_get_1svm_1type_10(IntPtr nativeObj);

        // C++: void CvSVMParams::svm_type
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1svm_1type_10(IntPtr nativeObj, int svm_type);

        // C++: int CvSVMParams::kernel_type
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvSVMParams_get_1kernel_1type_10(IntPtr nativeObj);

        // C++: void CvSVMParams::kernel_type
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1kernel_1type_10(IntPtr nativeObj, int kernel_type);

        // C++: double CvSVMParams::degree
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvSVMParams_get_1degree_10(IntPtr nativeObj);

        // C++: void CvSVMParams::degree
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1degree_10(IntPtr nativeObj, double degree);

        // C++: double CvSVMParams::gamma
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvSVMParams_get_1gamma_10(IntPtr nativeObj);

        // C++: void CvSVMParams::gamma
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1gamma_10(IntPtr nativeObj, double gamma);

        // C++: double CvSVMParams::coef0
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvSVMParams_get_1coef0_10(IntPtr nativeObj);

        // C++: void CvSVMParams::coef0
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1coef0_10(IntPtr nativeObj, double coef0);

        // C++: double CvSVMParams::C
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvSVMParams_get_1C_10(IntPtr nativeObj);

        // C++: void CvSVMParams::C
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1C_10(IntPtr nativeObj, double C);

        // C++: double CvSVMParams::nu
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvSVMParams_get_1nu_10(IntPtr nativeObj);

        // C++: void CvSVMParams::nu
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1nu_10(IntPtr nativeObj, double nu);

        // C++: double CvSVMParams::p
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvSVMParams_get_1p_10(IntPtr nativeObj);

        // C++: void CvSVMParams::p
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1p_10(IntPtr nativeObj, double p);

        // C++: TermCriteria CvSVMParams::term_crit
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_get_1term_1crit_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]  double[] vals);

        // C++: void CvSVMParams::term_crit
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_set_1term_1crit_10(IntPtr nativeObj, int term_crit_type, int term_crit_maxCount, double term_crit_epsilon);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvSVMParams_delete(IntPtr nativeObj);
    }}