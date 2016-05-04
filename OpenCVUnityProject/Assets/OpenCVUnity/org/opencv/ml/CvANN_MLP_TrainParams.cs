
	/// <summary>Parameters of the MLP training algorithm. You can initialize the structure by
	/// a constructor or the individual parameters can be adjusted after the
	/// structure is created.</summary>
	///
	/// <p>The back-propagation algorithm parameters:</p>
	///
	/// <p>Strength of the weight gradient term. The recommended value is about 0.1.</p>
	///
	/// <p>Strength of the momentum term (the difference between weights on the 2
	/// previous iterations). This parameter provides some inertia to smooth the
	/// random fluctuations of the weights. It can vary from 0 (the feature is
	/// disabled) to 1 and beyond. The value 0.1 or so is good enough <code></p>
	///
	/// <p>// C++ code:</p>
	///
	/// <p>The RPROP algorithm parameters (see [RPROP93] for details):</p>
	///
	/// <p>Initial value <em>Delta_0</em> of update-values <em>Delta_(ij)</em>.</p>
	///
	/// <p>Increase factor <em>eta^+</em>. It must be >1.</p>
	///
	/// <p>Decrease factor <em>eta^-</em>. It must be <1.</p>
	///
	/// <p>Update-values lower limit <em>Delta_(min)</em>. It must be positive.</p>
	///
	/// <p>Update-values upper limit <em>Delta_(max)</em>. It must be >1.</p>
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-trainparams">org.opencv.ml.CvANN_MLP_TrainParams</a>
	public class CvANN_MLP_TrainParams : DisposableOpenCVObject
	/// <summary>The constructors.</summary>
	///
	/// <p>By default the RPROP algorithm is used:</p>
	///
	/// <p><code></p>
	///
	/// <p>// C++ code:</p>
	///
	/// <p>CvANN_MLP_TrainParams.CvANN_MLP_TrainParams()</p>
	///
	///
	/// <p>term_crit = cvTermCriteria(CV_TERMCRIT_ITER + CV_TERMCRIT_EPS, 1000, 0.01);</p>
	///
	/// <p>train_method = RPROP;</p>
	///
	/// <p>bp_dw_scale = bp_moment_scale = 0.1;</p>
	///
	/// <p>rp_dw0 = 0.1; rp_dw_plus = 1.2; rp_dw_minus = 0.5;</p>
	///
	/// <p>rp_dw_min = FLT_EPSILON; rp_dw_max = 50.;</p>
	///
	///
	/// <a href="http://docs.opencv.org/modules/ml/doc/neural_networks.html#cvann-mlp-trainparams-cvann-mlp-trainparams">org.opencv.ml.CvANN_MLP_TrainParams.CvANN_MLP_TrainParams</a>
	public   CvANN_MLP_TrainParams()