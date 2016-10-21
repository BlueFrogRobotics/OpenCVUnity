
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{


    // C++: class CvStatModel
    
	/// <summary>Base class for statistical models in ML.</summary>
	///
	/// <p>class CvStatModel <code></p>
	///
	/// <p>// C++ code:</p>
	///
	///
	/// <p>public:</p>
	///
	/// <p>//// CvStatModel();/// /</p>
	///
	/// <p>//// CvStatModel(const Mat& train_data...);/// /</p>
	///
	/// <p>virtual ~CvStatModel();</p>
	///
	/// <p>virtual void clear()=0;</p>
	///
	/// <p>//// virtual bool train(const Mat& train_data, [int tflag,]..., const</p>
	///
	/// <p>Mat& responses,...,</p>
	///
	/// <p>[const Mat& var_idx,]..., [const Mat& sample_idx,]...</p>
	///
	/// <p>[const Mat& var_type,]..., [const Mat& missing_mask,]</p>
	///
	/// <p><misc_training_alg_params>...)=0;</p>
	/// <ul>
	///   <li> /
	/// </ul>
	///
	/// <p>//// virtual float predict(const Mat& sample...) const=0;/// /</p>
	///
	/// <p>virtual void save(const char/// filename, const char/// name=0)=0;</p>
	///
	/// <p>virtual void load(const char/// filename, const char/// name=0)=0;</p>
	///
	/// <p>virtual void write(CvFileStorage/// storage, const char/// name)=0;</p>
	///
	/// <p>virtual void read(CvFileStorage/// storage, CvFileNode/// node)=0;</p>
	///
	/// <p>};</p>
	///
	/// <p>In this declaration, some methods are commented off. These are methods for
	/// which there is no unified API (with the exception of the default
	/// constructor). However, there are many similarities in the syntax and
	/// semantics that are briefly described below in this section, as if they are
	/// part of the base class.
	/// </code></p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/statistical_models.html#cvstatmodel">org.opencv.ml.CvStatModel</a>
	public class CvStatModel : DisposableOpenCVObject
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
                        opencvunity_ml_CvStatModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected CvStatModel(IntPtr addr)
        {
            nativeObj = addr;
        }


        //
        // C++:  void CvStatModel::load(c_string filename, c_string name = 0)
        //

        //public void load(string filename, string name)
        //{
        //    ThrowIfDisposed();

        //    opencvunity_ml_CvStatModel_load_10(nativeObj, filename, name);
        //}

        //public void load(string filename)
        //{
        //    ThrowIfDisposed();

        //    opencvunity_ml_CvStatModel_load_11(nativeObj, filename);
        //}

        void loadANN(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10ANN(nativeObj, filename, name);
        }

        void loadBoost(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10Boost(nativeObj, filename, name);
        }

        void loadRTrees(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10RTrees(nativeObj, filename, name);
        }

        void loadEM(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10EM(nativeObj, filename, name);
        }

        void loadKNearest(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10KNearest(nativeObj, filename, name);
        }

        void loadLogisticRegression(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10LogisticRegression(nativeObj, filename, name);
        }

        void loadNormalBayesClassifier(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10NormalBayesClassifier(nativeObj, filename, name);
        }

        void loadSVM(string filename, string name)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_10SVM(nativeObj, filename, name);
        }

        void loadANN(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11ANN(nativeObj, filename);
        }

        void loadBoost(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11Boost(nativeObj, filename);
        }

        void loadRTrees(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11RTrees(nativeObj, filename);
        }

        void loadEM(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11EM(nativeObj, filename);
        }

        void loadKNearest(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11KNearest(nativeObj, filename);
        }

        void loadLogisticRegression(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11LogisticRegression(nativeObj, filename);
        }

        void loadNormalBayesClassifier(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11NormalBayesClassifier(nativeObj, filename);
        }

        void loadSVM(string filename)
        {
            ThrowIfDisposed();
            opencvunity_ml_CvStatModel_load_11SVM(nativeObj, filename);
        }

        //
        // C++:  void CvStatModel::save(c_string filename, c_string name = 0)
        //

        public void save(string filename, string name)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvStatModel_save_10(nativeObj, filename, name);
        }

        public void save(string filename)
        {
            ThrowIfDisposed();

            opencvunity_ml_CvStatModel_save_11(nativeObj, filename);
        }

        // C++:  void CvStatModel::load(c_string filename, c_string name = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10ANN(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10Boost(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10RTrees(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10EM(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10KNearest(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10LogisticRegression(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10NormalBayesClassifier(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_10SVM(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11ANN(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11Boost(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11RTrees(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11EM(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11KNearest(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11LogisticRegression(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11NormalBayesClassifier(IntPtr nativeObj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_load_11SVM(IntPtr nativeObj, string filename);


        // C++:  void CvStatModel::save(c_string filename, c_string name = 0)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_save_10(IntPtr nativeObj, string filename, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_save_11(IntPtr nativeObj, string filename);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ml_CvStatModel_delete(IntPtr nativeObj);
    }}