//// This file is auto-generated. Please don't modify it!//using System;using System.Runtime.InteropServices;namespace OpenCVUnity{// C++: class CvParamGrid		
	/// <summary>The structure represents the logarithmic grid range of statmodel parameters.
	/// It is used for optimizing statmodel accuracy by varying model parameters, the
	/// accuracy estimate being computed by cross-validation.</summary>
	///
	/// <p>Minimum value of the statmodel parameter.</p>
	///
	/// <p>Maximum value of the statmodel parameter.
	/// <code></p>
	///
	/// <p>// C++ code:</p>
	///
	/// <p>Logarithmic step for iterating the statmodel parameter.</p>
	///
	/// <p>The grid determines the following iteration sequence of the statmodel
	/// parameter values: </code></p>
	///
	/// <p><em>(min_val, min_val*step, min_val*(step)^2, dots, min_val*(step)^n),</em></p>
	///
	/// <p>where <em>n</em> is the maximal index satisfying</p>
	///
	/// <p><em>min_val/// step ^n &lt max_val</em></p>
	///
	/// <p>The grid is logarithmic, so <code>step</code> must always be greater then 1.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvparamgrid">org.opencv.ml.CvParamGrid</a>
	public class CvParamGrid : DisposableOpenCVObject		{				protected override void Dispose (bool disposing)				{									try {								if (disposing) {								}								if (IsEnabledDispose) {										if (nativeObj != IntPtr.Zero)												opencvunity_ml_CvParamGrid_delete (nativeObj);										nativeObj = IntPtr.Zero;								}										} finally {								base.Dispose (disposing);						}							}					
	/// <summary>The constructors.</summary>
	///
	/// <p>The full constructor initializes corresponding members. The default
	/// constructor creates a dummy grid:</p>
	///
	/// <p><code></p>
	///
	/// <p>// C++ code:</p>
	///
	/// <p>CvParamGrid.CvParamGrid()</p>
	///
	///
	/// <p>min_val = max_val = step = 0;</p>
	///
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/support_vector_machines.html#cvparamgrid-cvparamgrid">org.opencv.ml.CvParamGrid.CvParamGrid</a>
	public   CvParamGrid()				{						nativeObj = opencvunity_ml_CvParamGrid_CvParamGrid_10 ();						}						//				// C++: double CvParamGrid::min_val				//					public  double get_min_val ()				{						ThrowIfDisposed ();						double retVal = opencvunity_ml_CvParamGrid_get_1min_1val_10 (nativeObj);								return retVal;				}						//				// C++: void CvParamGrid::min_val				//					public  void set_min_val (double min_val)				{						ThrowIfDisposed ();						opencvunity_ml_CvParamGrid_set_1min_1val_10 (nativeObj, min_val);						}						//				// C++: double CvParamGrid::max_val				//					public  double get_max_val ()				{						ThrowIfDisposed ();								double retVal = opencvunity_ml_CvParamGrid_get_1max_1val_10 (nativeObj);								return retVal;				}						//				// C++: void CvParamGrid::max_val				//					public  void set_max_val (double max_val)				{						ThrowIfDisposed ();						opencvunity_ml_CvParamGrid_set_1max_1val_10 (nativeObj, max_val);						}						//				// C++: double CvParamGrid::step				//					public  double get_step ()				{						ThrowIfDisposed ();						double retVal = opencvunity_ml_CvParamGrid_get_1step_10 (nativeObj);								return retVal;				}						//				// C++: void CvParamGrid::step				//					public  void set_step (double step)				{						ThrowIfDisposed ();								opencvunity_ml_CvParamGrid_set_1step_10 (nativeObj, step);						}		//	@Override//	protected void finalize() throws Throwable {//			opencvunity_ml_CvParamGrid_delete(nativeObj);//	}						// C++:   CvParamGrid::CvParamGrid()				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern IntPtr opencvunity_ml_CvParamGrid_CvParamGrid_10 ();						// C++: double CvParamGrid::min_val				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern double opencvunity_ml_CvParamGrid_get_1min_1val_10 (IntPtr nativeObj);						// C++: void CvParamGrid::min_val				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern void opencvunity_ml_CvParamGrid_set_1min_1val_10 (IntPtr nativeObj, double min_val);						// C++: double CvParamGrid::max_val				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern double opencvunity_ml_CvParamGrid_get_1max_1val_10 (IntPtr nativeObj);						// C++: void CvParamGrid::max_val				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern void opencvunity_ml_CvParamGrid_set_1max_1val_10 (IntPtr nativeObj, double max_val);						// C++: double CvParamGrid::step				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern double opencvunity_ml_CvParamGrid_get_1step_10 (IntPtr nativeObj);						// C++: void CvParamGrid::step				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern void opencvunity_ml_CvParamGrid_set_1step_10 (IntPtr nativeObj, double step);						// native support for java finalize()				[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]				private static extern void opencvunity_ml_CvParamGrid_delete (IntPtr nativeObj);		}}