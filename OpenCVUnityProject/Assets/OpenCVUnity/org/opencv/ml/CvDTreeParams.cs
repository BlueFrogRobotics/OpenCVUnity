
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{



    // C++: class CvDTreeParams
    
	/// <summary>The structure contains all the decision tree training parameters. You can
	/// initialize it by default constructor and then override any parameters
	/// directly before training, or the structure may be fully initialized using the
	/// advanced variant of the constructor.</summary>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/decision_trees.html#cvdtreeparams">org.opencv.ml.CvDTreeParams</a>
	public class CvDTreeParams : DisposableOpenCVObject
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
                        opencvunity_ml_CvDTreeParams_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        public CvDTreeParams()
        {
            nativeObj = opencvunity_ml_CvDTreeParams_CvDTreeParams_10();

        }

        public CvDTreeParams(IntPtr addr)
        {
            nativeObj = addr;
        }


        //
        // C++: int CvDTreeParams::max_categories
        //

        public int get_max_categories()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvDTreeParams_get_1max_1categories_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::max_categories
        //

        public void set_max_categories(int max_categories)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1max_1categories_10(nativeObj, max_categories);

        }


        //
        // C++: int CvDTreeParams::max_depth
        //

        public int get_max_depth()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvDTreeParams_get_1max_1depth_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::max_depth
        //

        public void set_max_depth(int max_depth)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1max_1depth_10(nativeObj, max_depth);

        }


        //
        // C++: int CvDTreeParams::min_sample_count
        //

        public int get_min_sample_count()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvDTreeParams_get_1min_1sample_1count_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::min_sample_count
        //

        public void set_min_sample_count(int min_sample_count)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1min_1sample_1count_10(nativeObj, min_sample_count);

        }


        //
        // C++: int CvDTreeParams::cv_folds
        //

        public int get_cv_folds()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_ml_CvDTreeParams_get_1cv_1folds_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::cv_folds
        //

        public void set_cv_folds(int cv_folds)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1cv_1folds_10(nativeObj, cv_folds);

        }


        //
        // C++: bool CvDTreeParams::use_surrogates
        //

        public bool get_use_surrogates()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvDTreeParams_get_1use_1surrogates_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::use_surrogates
        //

        public void set_use_surrogates(bool use_surrogates)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1use_1surrogates_10(nativeObj, use_surrogates);

        }


        //
        // C++: bool CvDTreeParams::use_1se_rule
        //

        public bool get_use_1se_rule()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvDTreeParams_get_1use_11se_1rule_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::use_1se_rule
        //

        public void set_use_1se_rule(bool use_1se_rule)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1use_11se_1rule_10(nativeObj, use_1se_rule);

        }


        //
        // C++: bool CvDTreeParams::truncate_pruned_tree
        //

        public bool get_truncate_pruned_tree()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_ml_CvDTreeParams_get_1truncate_1pruned_1tree_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::truncate_pruned_tree
        //

        public void set_truncate_pruned_tree(bool truncate_pruned_tree)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1truncate_1pruned_1tree_10(nativeObj, truncate_pruned_tree);

        }


        //
        // C++: float CvDTreeParams::regression_accuracy
        //

        public float get_regression_accuracy()
        {
            ThrowIfDisposed();

            float retVal = opencvunity_ml_CvDTreeParams_get_1regression_1accuracy_10(nativeObj);

            return retVal;
        }


        //
        // C++: void CvDTreeParams::regression_accuracy
        //

        public void set_regression_accuracy(float regression_accuracy)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvDTreeParams_set_1regression_1accuracy_10(nativeObj, regression_accuracy);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_ml_CvDTreeParams_delete(nativeObj);
        //	}



        // C++:   CvDTreeParams::CvDTreeParams()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_ml_CvDTreeParams_CvDTreeParams_10();

        // C++: int CvDTreeParams::max_categories
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvDTreeParams_get_1max_1categories_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::max_categories
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1max_1categories_10(IntPtr nativeObj, int max_categories);

        // C++: int CvDTreeParams::max_depth
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvDTreeParams_get_1max_1depth_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::max_depth
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1max_1depth_10(IntPtr nativeObj, int max_depth);

        // C++: int CvDTreeParams::min_sample_count
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvDTreeParams_get_1min_1sample_1count_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::min_sample_count
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1min_1sample_1count_10(IntPtr nativeObj, int min_sample_count);

        // C++: int CvDTreeParams::cv_folds
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_ml_CvDTreeParams_get_1cv_1folds_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::cv_folds
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1cv_1folds_10(IntPtr nativeObj, int cv_folds);

        // C++: bool CvDTreeParams::use_surrogates
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvDTreeParams_get_1use_1surrogates_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::use_surrogates
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1use_1surrogates_10(IntPtr nativeObj, bool use_surrogates);

        // C++: bool CvDTreeParams::use_1se_rule
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvDTreeParams_get_1use_11se_1rule_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::use_1se_rule
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1use_11se_1rule_10(IntPtr nativeObj, bool use_1se_rule);

        // C++: bool CvDTreeParams::truncate_pruned_tree
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_ml_CvDTreeParams_get_1truncate_1pruned_1tree_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::truncate_pruned_tree
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1truncate_1pruned_1tree_10(IntPtr nativeObj, bool truncate_pruned_tree);

        // C++: float CvDTreeParams::regression_accuracy
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern float opencvunity_ml_CvDTreeParams_get_1regression_1accuracy_10(IntPtr nativeObj);

        // C++: void CvDTreeParams::regression_accuracy
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_set_1regression_1accuracy_10(IntPtr nativeObj, float regression_accuracy);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvDTreeParams_delete(IntPtr nativeObj);
    }}