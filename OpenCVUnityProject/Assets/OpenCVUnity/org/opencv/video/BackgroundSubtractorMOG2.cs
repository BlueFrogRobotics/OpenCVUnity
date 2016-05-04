
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{

    // C++: class BackgroundSubtractorMOG2
    
	/// <summary>Gaussian Mixture-based Background/Foreground Segmentation Algorithm.</summary>
	///
	/// <p>Here are important members of the class that control the algorithm, which you
	/// can set after constructing the class instance:</p>
	///
	/// <p>Maximum allowed number of mixture components. Actual number is determined
	/// dynamically per pixel.</p>
	///
	/// <p>Threshold defining whether the component is significant enough to be included
	/// into the background model (corresponds to <code>TB=1-cf</code> from the
	/// paper??which paper??). <code>cf=0.1 => TB=0.9</code> is default. For
	/// <code>alpha=0.001</code>, it means that the mode should exist for
	/// approximately 105 frames before it is considered foreground.
	/// <code></p>
	///
	/// <p>// C++ code:</p>
	///
	/// <p>Threshold for the squared Mahalanobis distance that helps decide when a
	/// sample is close to the existing components (corresponds to <code>Tg</code>).
	/// If it is not close to any component, a new component is generated. <code>3
	/// sigma => Tg=3*3=9</code> is default. A smaller <code>Tg</code> value
	/// generates more components. A higher <code>Tg</code> value may result in a
	/// small number of components but they can grow too large.</p>
	///
	/// <p>Initial variance for the newly generated components. It affects the speed of
	/// adaptation. The parameter value is based on your estimate of the typical
	/// standard deviation from the images. OpenCV uses 15 as a reasonable value.</p>
	///
	/// <p>Parameter used to further control the variance.</p>
	///
	/// <p>Parameter used to further control the variance.</p>
	///
	/// <p>Complexity reduction parameter. This parameter defines the number of samples
	/// needed to accept to prove the component exists. <code>CT=0.05</code> is a
	/// default value for all the samples. By setting <code>CT=0</code> you get an
	/// algorithm very similar to the standard Stauffer&Grimson algorithm.</p>
	///
	/// <p>The value for marking shadow pixels in the output foreground mask. Default
	/// value is 127.</p>
	///
	/// <p>Shadow threshold. The shadow is detected if the pixel is a darker version of
	/// the background. <code>Tau</code> is a threshold defining how much darker the
	/// shadow can be. <code>Tau= 0.5</code> means that if a pixel is more than twice
	/// darker then it is not shadow. See Prati,Mikic,Trivedi,Cucchiarra,///Detecting
	/// Moving Shadows...*, IEEE PAMI,2003.</p>
	///
	/// <p>The class implements the Gaussian mixture model background subtraction
	/// described in: </code></p>
	/// <ul>
	///   <li> Z.Zivkovic,///Improved adaptive Gausian mixture model for background
	/// subtraction*, International Conference Pattern Recognition, UK, August, 2004,
	/// http://www.zoranz.net/Publications/zivkovic2004ICPR.pdf. The code is very
	/// fast and performs also shadow detection. Number of Gausssian components is
	/// adapted per pixel.
	///   <li> Z.Zivkovic, F. van der Heijden,///Efficient Adaptive Density Estimapion
	/// per Image Pixel for the Task of Background Subtraction*, Pattern Recognition
	/// Letters, vol. 27, no. 7, pages 773-780, 2006. The algorithm similar to the
	/// standard Stauffer&Grimson algorithm with additional selection of the number
	/// of the Gaussian components based on: Z.Zivkovic, F.van der Heijden, Recursive
	/// unsupervised learning of finite mixture models, IEEE Trans. on Pattern
	/// Analysis and Machine Intelligence, vol.26, no.5, pages 651-656, 2004.
	/// </ul>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#backgroundsubtractormog2">org.opencv.video.BackgroundSubtractorMOG2 : public BackgroundSubtractor</a>
	public class BackgroundSubtractorMOG2 : BackgroundSubtractor
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
                        opencvunity_video_BackgroundSubtractorMOG2_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected BackgroundSubtractorMOG2(IntPtr addr) : base(addr)
        {
        }


        //
        // C++:   BackgroundSubtractorMOG2::BackgroundSubtractorMOG2()
        //

        public BackgroundSubtractorMOG2() : base(opencvunity_video_BackgroundSubtractorMOG2_BackgroundSubtractorMOG2_10())
        {

        }


        //
        // C++:   BackgroundSubtractorMOG2::BackgroundSubtractorMOG2(int history, float varThreshold, bool bShadowDetection = true)
        //

        public BackgroundSubtractorMOG2(int history, float varThreshold, bool bShadowDetection) : base(opencvunity_video_BackgroundSubtractorMOG2_BackgroundSubtractorMOG2_11(history, varThreshold, bShadowDetection))
        {

        }

        public BackgroundSubtractorMOG2(int history, float varThreshold) : base(opencvunity_video_BackgroundSubtractorMOG2_BackgroundSubtractorMOG2_12(history, varThreshold))
        {

        }

        // C++:   BackgroundSubtractorMOG2::BackgroundSubtractorMOG2()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_BackgroundSubtractorMOG2_BackgroundSubtractorMOG2_10();

        // C++:   BackgroundSubtractorMOG2::BackgroundSubtractorMOG2(int history, float varThreshold, bool bShadowDetection = true)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_BackgroundSubtractorMOG2_BackgroundSubtractorMOG2_11(int history, float varThreshold, bool bShadowDetection);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_BackgroundSubtractorMOG2_BackgroundSubtractorMOG2_12(int history, float varThreshold);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_BackgroundSubtractorMOG2_delete(IntPtr nativeObj);
    }}