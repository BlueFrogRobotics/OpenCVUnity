//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;

namespace OpenCVUnity
{

    // C++: class CvRTParams
    
	/// <summary>Training parameters of random trees.</summary>
	///
	/// <p>The set of training parameters for the forest is a superset of the training
	/// parameters for a single tree. However, random trees do not need all the
	/// functionality/features of decision trees. Most noticeably, the trees are not
	/// pruned, so the cross-validation parameters are not used.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/random_trees.html#cvrtparams">org.opencv.ml.CvRTParams : public CvDTreeParams</a>
	public class CvRTParams : CvDTreeParams
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
                        ml_CvRTParams_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvRTParams(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   CvRTParams::CvRTParams()
        //

        public CvRTParams() : base(ml_CvRTParams_CvRTParams_10())
        {
        }


        //
        // C++: bool CvRTParams::calc_var_importance
        //

        public bool get_calc_var_importance()
        {
            ThrowIfDisposed();

            bool retVal = ml_CvRTParams_get_1calc_1var_1importance_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvRTParams::calc_var_importance
        //

        public void set_calc_var_importance(bool calc_var_importance)
        {
            ThrowIfDisposed();

            ml_CvRTParams_set_1calc_1var_1importance_10(nativeObj, calc_var_importance);

        }


        //
        // C++: int CvRTParams::nactive_vars
        //

        public int get_nactive_vars()
        {
            ThrowIfDisposed();

            int retVal = ml_CvRTParams_get_1nactive_1vars_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvRTParams::nactive_vars
        //

        public void set_nactive_vars(int nactive_vars)
        {
            ThrowIfDisposed();

            ml_CvRTParams_set_1nactive_1vars_10(nativeObj, nactive_vars);

            return;
        }


        //
        // C++: TermCriteria CvRTParams::term_crit
        //

        public TermCriteria get_term_crit()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            ml_CvRTParams_get_1term_1crit_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++: void CvRTParams::term_crit
        //

        public void set_term_crit(TermCriteria term_crit)
        {
            ThrowIfDisposed();

            ml_CvRTParams_set_1term_1crit_10(nativeObj, term_crit.type, term_crit.maxCount, term_crit.epsilon);
        }

        // C++:   CvRTParams::CvRTParams()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr ml_CvRTParams_CvRTParams_10();

        // C++: bool CvRTParams::calc_var_importance
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool ml_CvRTParams_get_1calc_1var_1importance_10(IntPtr nativeObj);

        // C++: void CvRTParams::calc_var_importance
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ml_CvRTParams_set_1calc_1var_1importance_10(IntPtr nativeObj, bool calc_var_importance);

        // C++: int CvRTParams::nactive_vars
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int ml_CvRTParams_get_1nactive_1vars_10(IntPtr nativeObj);

        // C++: void CvRTParams::nactive_vars
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ml_CvRTParams_set_1nactive_1vars_10(IntPtr nativeObj, int nactive_vars);

        // C++: TermCriteria CvRTParams::term_crit
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ml_CvRTParams_get_1term_1crit_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)]  double[] vals);

        // C++: void CvRTParams::term_crit
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ml_CvRTParams_set_1term_1crit_10(IntPtr nativeObj, int term_crit_type, int term_crit_maxCount, double term_crit_epsilon);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ml_CvRTParams_delete(IntPtr nativeObj);
    }
}
