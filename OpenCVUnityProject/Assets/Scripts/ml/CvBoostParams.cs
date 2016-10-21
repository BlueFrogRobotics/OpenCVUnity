
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{



    // C++: class CvBoostParams
    
	/// <summary>Boosting training parameters.</summary>
	///
	/// <p>There is one structure member that you can set directly:</p>
	///
	/// <p>Splitting criteria used to choose optimal splits during a weak tree
	/// construction. Possible values are:</p>
	///
	/// <ul>
	///   <li> CvBoost.DEFAULT Use the default for the particular boosting method,
	/// see below.
	/// </ul>
	/// <p><code></p>
	///
	/// <p>// C++ code:</p>
	/// <ul>
	///   <li> CvBoost.GINI Use Gini index. This is default option for Real
	/// AdaBoost; may be also used for Discrete AdaBoost.
	///   <li> CvBoost.MISCLASS Use misclassification rate. This is default option
	/// for Discrete AdaBoost; may be also used for Real AdaBoost.
	///   <li> CvBoost.SQERR Use least squares criteria. This is default and the
	/// only option for LogitBoost and Gentle AdaBoost.
	/// </ul>
	///
	/// <p>The structure is derived from "CvDTreeParams" but not all of the decision
	/// tree parameters are supported. In particular, cross-validation is not
	/// supported.
	/// </code></p>
	///
	/// <p>All parameters are public. You can initialize them by a constructor and then
	/// override some of them directly if you want.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/boosting.html#cvboostparams">org.opencv.ml.CvBoostParams : public CvDTreeParams</a>
	public class CvBoostParams : CvDTreeParams
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
                        opencvunity_ml_CvBoostParams_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CvBoostParams(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   CvBoostParams::CvBoostParams()
        //

        public CvBoostParams() : base(opencvunity_ml_CvBoostParams_CvBoostParams_10())
        {
        }


        //
        // C++: int CvBoostParams::boost_type
        //

        public int get_boost_type()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvBoostParams_get_1boost_1type_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvBoostParams::boost_type
        //

        public void set_boost_type(int boost_type)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvBoostParams_set_1boost_1type_10(nativeObj, boost_type);

        }


        //
        // C++: int CvBoostParams::weak_count
        //

        public int get_weak_count()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvBoostParams_get_1weak_1count_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvBoostParams::weak_count
        //

        public void set_weak_count(int weak_count)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvBoostParams_set_1weak_1count_10(nativeObj, weak_count);

        }


        //
        // C++: int CvBoostParams::split_criteria
        //

        public int get_split_criteria()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvBoostParams_get_1split_1criteria_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvBoostParams::split_criteria
        //

        public void set_split_criteria(int split_criteria)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvBoostParams_set_1split_1criteria_10(nativeObj, split_criteria);

        }


        //
        // C++: double CvBoostParams::weight_trim_rate
        //

        public double get_weight_trim_rate()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_ml_CvBoostParams_get_1weight_1trim_1rate_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvBoostParams::weight_trim_rate
        //

        public void set_weight_trim_rate(double weight_trim_rate)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvBoostParams_set_1weight_1trim_1rate_10(nativeObj, weight_trim_rate);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_ml_CvBoostParams_delete(nativeObj);
        //	}



        // C++:   CvBoostParams::CvBoostParams()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvBoostParams_CvBoostParams_10();

        // C++: int CvBoostParams::boost_type
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvBoostParams_get_1boost_1type_10(IntPtr nativeObj);

        // C++: void CvBoostParams::boost_type
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoostParams_set_1boost_1type_10(IntPtr nativeObj, int boost_type);

        // C++: int CvBoostParams::weak_count
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvBoostParams_get_1weak_1count_10(IntPtr nativeObj);

        // C++: void CvBoostParams::weak_count
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoostParams_set_1weak_1count_10(IntPtr nativeObj, int weak_count);

        // C++: int CvBoostParams::split_criteria
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvBoostParams_get_1split_1criteria_10(IntPtr nativeObj);

        // C++: void CvBoostParams::split_criteria
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoostParams_set_1split_1criteria_10(IntPtr nativeObj, int split_criteria);

        // C++: double CvBoostParams::weight_trim_rate
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_ml_CvBoostParams_get_1weight_1trim_1rate_10(IntPtr nativeObj);

        // C++: void CvBoostParams::weight_trim_rate
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoostParams_set_1weight_1trim_1rate_10(IntPtr nativeObj, double weight_trim_rate);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvBoostParams_delete(IntPtr nativeObj);
    }}