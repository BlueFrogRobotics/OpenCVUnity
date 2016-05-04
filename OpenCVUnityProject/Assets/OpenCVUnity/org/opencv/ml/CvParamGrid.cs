
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
	public class CvParamGrid : DisposableOpenCVObject
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
	public   CvParamGrid()