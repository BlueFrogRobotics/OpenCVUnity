
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;using System.Collections.Generic;namespace OpenCVUnity{
    public class Video
    {

        private const int CV_LKFLOW_INITIAL_GUESSES = 4;
        private const int CV_LKFLOW_GET_MIN_EIGENVALS = 8;
        public const int OPTFLOW_USE_INITIAL_FLOW = CV_LKFLOW_INITIAL_GUESSES;
        public const int OPTFLOW_LK_GET_MIN_EIGENVALS = CV_LKFLOW_GET_MIN_EIGENVALS;
        public const int OPTFLOW_FARNEBACK_GAUSSIAN = 256;


        //
        // C++:  RotatedRect CamShift(Mat probImage, Rect& window, TermCriteria criteria)
        //

        
	/// <summary>Finds an object center, size, and orientation.</summary>
	///
	/// <p>The function implements the CAMSHIFT object tracking algorithm [Bradski98].
	/// First, it finds an object center using "meanShift" and then adjusts the
	/// window size and finds the optimal rotation. The function returns the rotated
	/// rectangle structure that includes the object position, size, and orientation.
	/// The next position of the search window can be obtained with <code>RotatedRect.boundingRect()</code>.</p>
	///
	/// <p>See the OpenCV sample <code>camshiftdemo.c</code> that tracks colored
	/// objects.</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> (Python) A sample explaining the camshift tracking algorithm can be
	/// found at opencv_source_code/samples/python2/camshift.py
	/// </ul>
	///
	/// <param>probImage Back projection of the object histogram. See
	/// "calcBackProject".</param>
	/// <param>window Initial search window.</param>
	/// <param>criteria Stop criteria for the underlying "meanShift".</param>
	///
	/// <p>:returns: (in old interfaces) Number of iterations CAMSHIFT took to converge</p></param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#camshift">org.opencv.video.Video.CamShift</a>
	public static RotatedRect CamShift(Mat probImage, Rect window, TermCriteria criteria)
        {
            if (probImage != null)
                probImage.ThrowIfDisposed();


            double[] window_out = new double[4];
            double[] tmpArray = new double[5];

            opencvunity_video_Video_CamShift_10(probImage.nativeObj, window.x, window.y, window.width, window.height, window_out, criteria.type, criteria.maxCount, criteria.epsilon, tmpArray);

            RotatedRect retVal = new RotatedRect(tmpArray);
            if (window != null)
            {
                window.x = (int)window_out[0];
                window.y = (int)window_out[1];
                window.width = (int)window_out[2];
                window.height = (int)window_out[3];
            }
            return retVal;
        }


        //
        // C++:  int buildOpticalFlowPyramid(Mat img, vector_Mat& pyramid, Size winSize, int maxLevel, bool withDerivatives = true, int pyrBorder = BORDER_REFLECT_101, int derivBorder = BORDER_CONSTANT, bool tryReuseInputImage = true)
        //

        
	/// <summary>Constructs the image pyramid which can be passed to "calcOpticalFlowPyrLK".</summary>
	///
	/// <param>img 8-bit input image.</param>
	/// <param>pyramid output pyramid.</param>
	/// <param>winSize window size of optical flow algorithm. Must be not less than
	/// <code>winSize</code> argument of "calcOpticalFlowPyrLK". It is needed to
	/// calculate required padding for pyramid levels.</param>
	/// <param>maxLevel 0-based maximal pyramid level number.</param>
	/// <param>withDerivatives set to precompute gradients for the every pyramid
	/// level. If pyramid is constructed without the gradients then "calcOpticalFlowPyrLK"
	/// will calculate them internally.</param>
	/// <param>pyrBorder the border mode for pyramid layers.</param>
	/// <param>derivBorder the border mode for gradients.</param>
	/// <param>tryReuseInputImage put ROI of input image into the pyramid if
	/// possible. You can pass <code>false</code> to force data copying.</param>
	///
	/// <p>:return: number of levels in constructed pyramid. Can be less than
	/// <code>maxLevel</code>.</p></param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#buildopticalflowpyramid">org.opencv.video.Video.buildOpticalFlowPyramid</a>
	public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder, bool tryReuseInputImage)
        {
            if (img != null)
                img.ThrowIfDisposed();

            Mat pyramid_mat = new Mat();
            int retVal = opencvunity_video_Video_buildOpticalFlowPyramid_10(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel, withDerivatives, pyrBorder, derivBorder, tryReuseInputImage);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            return retVal;
        }

        
	/// <summary>Constructs the image pyramid which can be passed to "calcOpticalFlowPyrLK".</summary>
	///
	/// <param>img 8-bit input image.</param>
	/// <param>pyramid output pyramid.</param>
	/// <param>winSize window size of optical flow algorithm. Must be not less than
	/// <code>winSize</code> argument of "calcOpticalFlowPyrLK". It is needed to
	/// calculate required padding for pyramid levels.</param>
	/// <param>maxLevel 0-based maximal pyramid level number.</param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#buildopticalflowpyramid">org.opencv.video.Video.buildOpticalFlowPyramid</a>
	public static int buildOpticalFlowPyramid(Mat img, List<Mat> pyramid, Size winSize, int maxLevel)
        {
            if (img != null)
                img.ThrowIfDisposed();

            Mat pyramid_mat = new Mat();
            int retVal = opencvunity_video_Video_buildOpticalFlowPyramid_11(img.nativeObj, pyramid_mat.nativeObj, winSize.width, winSize.height, maxLevel);
            Converters.Mat_to_vector_Mat(pyramid_mat, pyramid);
            return retVal;

        }

        //
        // C++:  void calcOpticalFlowFarneback(Mat prev, Mat next, Mat& flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        //

        
	/// <summary>Computes a dense optical flow using the Gunnar Farneback's algorithm.</summary>
	///
	/// <p>The function finds an optical flow for each <code>prev</code> pixel using the
	/// [Farneback2003] algorithm so that</p>
	///
	/// <p><em>prev(y,x) ~ next(y + flow(y,x)[1], x + flow(y,x)[0])</em></p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> An example using the optical flow algorithm described by Gunnar
	/// Farneback can be found at opencv_source_code/samples/cpp/fback.cpp
	///   <li> (Python) An example using the optical flow algorithm described by
	/// Gunnar Farneback can be found at opencv_source_code/samples/python2/opt_flow.py
	/// </ul>
	///
	/// <param>prev first 8-bit single-channel input image.</param>
	/// <param>next second input image of the same size and the same type as</param>
	/// <code>prev</code>.
	/// <param>flow computed flow image that has the same size as <code>prev</code></param>
	/// and type <code>CV_32FC2</code>.
	/// <param>pyr_scale parameter, specifying the image scale (<1) to build pyramids</param>
	/// for each image; <code>pyr_scale=0.5</code> means a classical pyramid, where
	/// each next layer is twice smaller than the previous one.
	/// <param>levels number of pyramid layers including the initial image;</param>
	/// <code>levels=1</code> means that no extra layers are created and only the
	/// original images are used.
	/// <param>winsize averaging window size; larger values increase the algorithm</param>
	/// robustness to image noise and give more chances for fast motion detection,
	/// but yield more blurred motion field.
	/// <param>iterations number of iterations the algorithm does at each pyramid</param>
	/// level.
	/// <param>poly_n size of the pixel neighborhood used to find polynomial</param>
	/// expansion in each pixel; larger values mean that the image will be
	/// approximated with smoother surfaces, yielding more robust algorithm and more
	/// blurred motion field, typically <code>poly_n</code> =5 or 7.
	/// <param>poly_sigma standard deviation of the Gaussian that is used to smooth</param>
	/// derivatives used as a basis for the polynomial expansion; for
	/// <code>poly_n=5</code>, you can set <code>poly_sigma=1.1</code>, for
	/// <code>poly_n=7</code>, a good value would be <code>poly_sigma=1.5</code>.
	/// <param>flags operation flags that can be a combination of the following:</param>
	/// <ul>
	///   <li> OPTFLOW_USE_INITIAL_FLOW uses the input <code>flow</code> as an
	/// initial flow approximation.
	///   <li> OPTFLOW_FARNEBACK_GAUSSIAN uses the Gaussian <em>winsizexwinsize</em>
	/// filter instead of a box filter of the same size for optical flow estimation;
	/// usually, this option gives z more accurate flow than with a box filter, at
	/// the cost of lower speed; normally, <code>winsize</code> for a Gaussian window
	/// should be set to a larger value to achieve the same level of robustness.
	/// </ul>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#calcopticalflowfarneback">org.opencv.video.Video.calcOpticalFlowFarneback</a>
	public static void calcOpticalFlowFarneback(Mat prev, Mat next, Mat flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        {
            if (prev != null)
                prev.ThrowIfDisposed();
            if (next != null)
                next.ThrowIfDisposed();
            if (flow != null)
                flow.ThrowIfDisposed();

            opencvunity_video_Video_calcOpticalFlowFarneback_10(prev.nativeObj, next.nativeObj, flow.nativeObj, pyr_scale, levels, winsize, iterations, poly_n, poly_sigma, flags);

        }


        //
        // C++:  void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, vector_Point2f prevPts, vector_Point2f& nextPts, vector_uchar& status, vector_float& err, Size winSize = Size(21,21), int maxLevel = 3, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        //

        
	/// <summary>Calculates an optical flow for a sparse feature set using the iterative
	/// Lucas-Kanade method with pyramids.</summary>
	///
	/// <p>The function implements a sparse iterative version of the Lucas-Kanade
	/// optical flow in pyramids. See [Bouguet00]. The function is parallelized with
	/// the TBB library.</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> An example using the Lucas-Kanade optical flow algorithm can be found
	/// at opencv_source_code/samples/cpp/lkdemo.cpp
	///   <li> (Python) An example using the Lucas-Kanade optical flow algorithm can
	/// be found at opencv_source_code/samples/python2/lk_track.py
	///   <li> (Python) An example using the Lucas-Kanade tracker for homography
	/// matching can be found at opencv_source_code/samples/python2/lk_homography.py
	/// </ul>
	///
	/// <param>prevImg first 8-bit input image or pyramid constructed by
	/// "buildOpticalFlowPyramid".</param>
	/// <param>nextImg second input image or pyramid of the same size and the same
	/// type as <code>prevImg</code>.</param>
	/// <param>prevPts vector of 2D points for which the flow needs to be found;
	/// point coordinates must be single-precision floating-point numbers.</param>
	/// <param>nextPts output vector of 2D points (with single-precision
	/// floating-point coordinates) containing the calculated new positions of input
	/// features in the second image; when <code>OPTFLOW_USE_INITIAL_FLOW</code> flag
	/// is passed, the vector must have the same size as in the input.</param>
	/// <param>status output status vector (of unsigned chars); each element of the
	/// vector is set to 1 if the flow for the corresponding features has been found,
	/// otherwise, it is set to 0.</param>
	/// <param>err output vector of errors; each element of the vector is set to an
	/// error for the corresponding feature, type of the error measure can be set in
	/// <code>flags</code> parameter; if the flow wasn't found then the error is not
	/// defined (use the <code>status</code> parameter to find such cases).</param>
	/// <param>winSize size of the search window at each pyramid level.</param>
	/// <param>maxLevel 0-based maximal pyramid level number; if set to 0, pyramids
	/// are not used (single level), if set to 1, two levels are used, and so on; if
	/// pyramids are passed to input then algorithm will use as many levels as
	/// pyramids have but no more than <code>maxLevel</code>.</param>
	/// <param>criteria parameter, specifying the termination criteria of the
	/// iterative search algorithm (after the specified maximum number of iterations
	/// <code>criteria.maxCount</code> or when the search window moves by less than
	/// <code>criteria.epsilon</code>.</param>
	/// <param>flags operation flags:
	/// <ul>
	///   <li> OPTFLOW_USE_INITIAL_FLOW uses initial estimations, stored in
	/// <code>nextPts</code>; if the flag is not set, then <code>prevPts</code> is
	/// copied to <code>nextPts</code> and is considered the initial estimate.
	///   <li> OPTFLOW_LK_GET_MIN_EIGENVALS use minimum eigen values as an error
	/// measure (see <code>minEigThreshold</code> description); if the flag is not
	/// set, then L1 distance between patches around the original and a moved point,
	/// divided by number of pixels in a window, is used as a error measure.
	/// </ul></param>
	/// <param>minEigThreshold the algorithm calculates the minimum eigen value of a
	/// 2x2 normal matrix of optical flow equations (this matrix is called a spatial
	/// gradient matrix in [Bouguet00]), divided by number of pixels in a window; if
	/// this value is less than <code>minEigThreshold</code>, then a corresponding
	/// feature is filtered out and its flow is not processed, so it allows to remove
	/// bad points and get a performance boost.</param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#calcopticalflowpyrlk">org.opencv.video.Video.calcOpticalFlowPyrLK</a>
	public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel, TermCriteria criteria, int flags, double minEigThreshold)
        {
            if (prevImg != null)
                prevImg.ThrowIfDisposed();
            if (nextImg != null)
                nextImg.ThrowIfDisposed();
            if (prevPts != null)
                prevPts.ThrowIfDisposed();
            if (nextPts != null)
                nextPts.ThrowIfDisposed();
            if (status != null)
                status.ThrowIfDisposed();
            if (err != null)
                err.ThrowIfDisposed();

            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            opencvunity_video_Video_calcOpticalFlowPyrLK_10(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel, criteria.type, criteria.maxCount, criteria.epsilon, flags, minEigThreshold);

        }

        
	/// <summary>Calculates an optical flow for a sparse feature set using the iterative
	/// Lucas-Kanade method with pyramids.</p>
	///
	/// <p>The function implements a sparse iterative version of the Lucas-Kanade
	/// optical flow in pyramids. See [Bouguet00]. The function is parallelized with
	/// the TBB library.</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> An example using the Lucas-Kanade optical flow algorithm can be found
	/// at opencv_source_code/samples/cpp/lkdemo.cpp
	///   <li> (Python) An example using the Lucas-Kanade optical flow algorithm can
	/// be found at opencv_source_code/samples/python2/lk_track.py
	///   <li> (Python) An example using the Lucas-Kanade tracker for homography
	/// matching can be found at opencv_source_code/samples/python2/lk_homography.py
	/// </ul>
	///
	/// <param>prevImg first 8-bit input image or pyramid constructed by</param>
	/// "buildOpticalFlowPyramid".
	/// <param>nextImg second input image or pyramid of the same size and the same</param>
	/// type as <code>prevImg</code>.
	/// <param>prevPts vector of 2D points for which the flow needs to be found;</param>
	/// point coordinates must be single-precision floating-point numbers.
	/// <param>nextPts output vector of 2D points (with single-precision</param>
	/// floating-point coordinates) containing the calculated new positions of input
	/// features in the second image; when <code>OPTFLOW_USE_INITIAL_FLOW</code> flag
	/// is passed, the vector must have the same size as in the input.
	/// <param>status output status vector (of unsigned chars); each element of the</param>
	/// vector is set to 1 if the flow for the corresponding features has been found,
	/// otherwise, it is set to 0.
	/// <param>err output vector of errors; each element of the vector is set to an</param>
	/// error for the corresponding feature, type of the error measure can be set in
	/// <code>flags</code> parameter; if the flow wasn't found then the error is not
	/// defined (use the <code>status</code> parameter to find such cases).
	/// <param>winSize size of the search window at each pyramid level.</param>
	/// <param>maxLevel 0-based maximal pyramid level number; if set to 0, pyramids</param>
	/// are not used (single level), if set to 1, two levels are used, and so on; if
	/// pyramids are passed to input then algorithm will use as many levels as
	/// pyramids have but no more than <code>maxLevel</code>.
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#calcopticalflowpyrlk">org.opencv.video.Video.calcOpticalFlowPyrLK</a>
	public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err, Size winSize, int maxLevel)
        {
            if (prevImg != null)
                prevImg.ThrowIfDisposed();
            if (nextImg != null)
                nextImg.ThrowIfDisposed();
            if (prevPts != null)
                prevPts.ThrowIfDisposed();
            if (nextPts != null)
                nextPts.ThrowIfDisposed();
            if (status != null)
                status.ThrowIfDisposed();
            if (err != null)
                err.ThrowIfDisposed();

            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            opencvunity_video_Video_calcOpticalFlowPyrLK_11(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj, winSize.width, winSize.height, maxLevel);

        }

        
	/// <summary>Calculates an optical flow for a sparse feature set using the iterative
	/// Lucas-Kanade method with pyramids.</summary>
	///
	/// <p>The function implements a sparse iterative version of the Lucas-Kanade
	/// optical flow in pyramids. See [Bouguet00]. The function is parallelized with
	/// the TBB library.</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> An example using the Lucas-Kanade optical flow algorithm can be found
	/// at opencv_source_code/samples/cpp/lkdemo.cpp
	///   <li> (Python) An example using the Lucas-Kanade optical flow algorithm can
	/// be found at opencv_source_code/samples/python2/lk_track.py
	///   <li> (Python) An example using the Lucas-Kanade tracker for homography
	/// matching can be found at opencv_source_code/samples/python2/lk_homography.py
	/// </ul>
	///
	/// <param>prevImg first 8-bit input image or pyramid constructed by
	/// "buildOpticalFlowPyramid".</param>
	/// <param>nextImg second input image or pyramid of the same size and the same
	/// type as <code>prevImg</code>.</param>
	/// <param>prevPts vector of 2D points for which the flow needs to be found;
	/// point coordinates must be single-precision floating-point numbers.</param>
	/// <param>nextPts output vector of 2D points (with single-precision
	/// floating-point coordinates) containing the calculated new positions of input
	/// features in the second image; when <code>OPTFLOW_USE_INITIAL_FLOW</code> flag
	/// is passed, the vector must have the same size as in the input.</param>
	/// <param>status output status vector (of unsigned chars); each element of the
	/// vector is set to 1 if the flow for the corresponding features has been found,
	/// otherwise, it is set to 0.</param>
	/// <param>err output vector of errors; each element of the vector is set to an
	/// error for the corresponding feature, type of the error measure can be set in
	/// <code>flags</code> parameter; if the flow wasn't found then the error is not
	/// defined (use the <code>status</code> parameter to find such cases).</param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#calcopticalflowpyrlk">org.opencv.video.Video.calcOpticalFlowPyrLK</a>
	public static void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, MatOfPoint2f prevPts, MatOfPoint2f nextPts, MatOfByte status, MatOfFloat err)
        {
            if (prevImg != null)
                prevImg.ThrowIfDisposed();
            if (nextImg != null)
                nextImg.ThrowIfDisposed();
            if (prevPts != null)
                prevPts.ThrowIfDisposed();
            if (nextPts != null)
                nextPts.ThrowIfDisposed();
            if (status != null)
                status.ThrowIfDisposed();
            if (err != null)
                err.ThrowIfDisposed();

            Mat prevPts_mat = prevPts;
            Mat nextPts_mat = nextPts;
            Mat status_mat = status;
            Mat err_mat = err;
            opencvunity_video_Video_calcOpticalFlowPyrLK_12(prevImg.nativeObj, nextImg.nativeObj, prevPts_mat.nativeObj, nextPts_mat.nativeObj, status_mat.nativeObj, err_mat.nativeObj);

        }

        //
        // C++:  Mat estimateRigidTransform(Mat src, Mat dst, bool fullAffine)
        //

        
	/// <summary>Computes an optimal affine transformation between two 2D point sets.</summary>
	///
	/// <p>The function finds an optimal affine transform///[A|b]/// (a <code>2 x 3</code>
	/// floating-point matrix) that approximates best the affine transformation
	/// between:</p>
	/// <ul>
	///   <li> Two point sets
	///   <li> Two raster images. In this case, the function first finds some
	/// features in the <code>src</code> image and finds the corresponding features
	/// in <code>dst</code> image. After that, the problem is reduced to the first
	/// case.
	/// </ul>
	///
	/// <p>In case of point sets, the problem is formulated as follows: you need to find
	/// a 2x2 matrix///A/// and 2x1 vector///b/// so that:</p>
	///
	/// <p><em>[A^*|b^*] = arg min _([A|b]) sum _i|dst[i] - A (src[i])^T - b| ^2</em></p>
	///
	/// <p>where <code>src[i]</code> and <code>dst[i]</code> are the i-th points in
	/// <code>src</code> and <code>dst</code>, respectively</p>
	///
	/// <p><em>[A|b]</em> can be either arbitrary (when <code>fullAffine=true</code>) or
	/// have a form of</p>
	///
	/// <p><em>a_11 a_12 b_1
	/// -a_12 a_11 b_2 </em></p>
	///
	/// <p>when <code>fullAffine=false</code>.</p>
	///
	/// <param>src First input 2D point set stored in <code>std.vector</code> or</param>
	/// <code>Mat</code>, or an image stored in <code>Mat</code>.
	/// <param>dst Second input 2D point set of the same size and the same type as</param>
	/// <code>A</code>, or another image.
	/// <param>fullAffine If true, the function finds an optimal affine</param>
	/// transformation with no additional restrictions (6 degrees of freedom).
	/// Otherwise, the class of transformations to choose from is limited to
	/// combinations of translation, rotation, and uniform scaling (5 degrees of
	/// freedom).
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#estimaterigidtransform">org.opencv.video.Video.estimateRigidTransform</a>
	/// org.opencv.calib3d.Calib3d#findHomography
	/// org.opencv.imgproc.Imgproc#getAffineTransform
	/// org.opencv.imgproc.Imgproc#getPerspectiveTransform
	public static Mat estimateRigidTransform(Mat src, Mat dst, bool fullAffine)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();

            Mat retVal = new Mat(opencvunity_video_Video_estimateRigidTransform_10(src.nativeObj, dst.nativeObj, fullAffine));

            return retVal;
        }


        //
        // C++:  int meanShift(Mat probImage, Rect& window, TermCriteria criteria)
        //

        
	/// <summary>Finds an object on a back projection image.</summary>
	///
	/// <p>The function implements the iterative object search algorithm. It takes the
	/// input back projection of an object and the initial position. The mass center
	/// in <code>window</code> of the back projection image is computed and the
	/// search window center shifts to the mass center. The procedure is repeated
	/// until the specified number of iterations <code>criteria.maxCount</code> is
	/// done or until the window center shifts by less than <code>criteria.epsilon</code>.
	/// The algorithm is used inside "CamShift" and, unlike "CamShift", the search
	/// window size or orientation do not change during the search. You can simply
	/// pass the output of "calcBackProject" to this function. But better results can
	/// be obtained if you pre-filter the back projection and remove the noise. For
	/// example, you can do this by retrieving connected components with
	/// "findContours", throwing away contours with small area ("contourArea"), and
	/// rendering the remaining contours with "drawContours".</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> A mean-shift tracking sample can be found at opencv_source_code/samples/cpp/camshiftdemo.cpp
	/// </ul>
	///
	/// <param>probImage Back projection of the object histogram. See
	/// "calcBackProject" for details.</param>
	/// <param>window Initial search window.</param>
	/// <param>criteria Stop criteria for the iterative search algorithm.</param>
	///
	/// <p>:returns: Number of iterations CAMSHIFT took to converge.</p></param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#meanshift">org.opencv.video.Video.meanShift</a>
	public static int meanShift(Mat probImage, Rect window, TermCriteria criteria)
        {
            if (probImage != null)
                probImage.ThrowIfDisposed();

            double[] window_out = new double[4];
            int retVal = opencvunity_video_Video_meanShift_10(probImage.nativeObj, window.x, window.y, window.width, window.height, window_out, criteria.type, criteria.maxCount, criteria.epsilon);
            if (window != null)
            {
                window.x = (int)window_out[0];
                window.y = (int)window_out[1];
                window.width = (int)window_out[2];
                window.height = (int)window_out[3];
            }
            return retVal;
        }


        //
        // C++:  void segmentMotion(Mat mhi, Mat& segmask, vector_Rect& boundingRects, double timestamp, double segThresh)
        //

        
	/// <summary>Splits a motion history image into a few parts corresponding to separate
	/// independent motions (for example, left hand, right hand).</summary>
	///
	/// <p>The function finds all of the motion segments and marks them in
	/// <code>segmask</code> with individual values (1,2,...). It also computes a
	/// vector with ROIs of motion connected components. After that the motion
	/// direction for every component can be calculated with "calcGlobalOrientation"
	/// using the extracted mask of the particular component.</p>
	///
	/// <param>mhi Motion history image.</param>
	/// <param>segmask Image where the found mask should be stored, single-channel,
	/// 32-bit floating-point.</param>
	/// <param>boundingRects Vector containing ROIs of motion connected components.</param>
	/// <param>timestamp Current time in milliseconds or other units.</param>
	/// <param>segThresh Segmentation threshold that is recommended to be equal to
	/// the interval between motion history "steps" or greater.</param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#segmentmotion">org.opencv.video.Video.segmentMotion</a>
	public static void segmentMotion(Mat mhi, Mat segmask, MatOfRect boundingRects, double timestamp, double segThresh)
        {
            if (mhi != null)
                mhi.ThrowIfDisposed();
            if (segmask != null)
                segmask.ThrowIfDisposed();
            if (boundingRects != null)
                boundingRects.ThrowIfDisposed();

            Mat boundingRects_mat = boundingRects;
            opencvunity_video_Video_segmentMotion_10(mhi.nativeObj, segmask.nativeObj, boundingRects_mat.nativeObj, timestamp, segThresh);

        }


        //
        // C++:  void updateMotionHistory(Mat silhouette, Mat& mhi, double timestamp, double duration)
        //

        
	/// <summary>Updates the motion history image by a moving silhouette.</summary>
	///
	/// <p>The function updates the motion history image as follows:</p>
	///
	/// <p><em>mhi(x,y)= timestamp if silhouette(x,y) != 0; 0 if silhouette(x,y) = 0 and
	/// mhi &lt(timestamp - duration); mhi(x,y) otherwise</em></p>
	///
	/// <p>That is, MHI pixels where the motion occurs are set to the current
	/// <code>timestamp</code>, while the pixels where the motion happened last time
	/// a long time ago are cleared.</p>
	///
	/// <p>The function, together with "calcMotionGradient" and "calcGlobalOrientation",
	/// implements a motion templates technique described in [Davis97] and
	/// [Bradski00].
	/// See also the OpenCV sample <code>motempl.c</code> that demonstrates the use
	/// of all the motion template functions.</p>
	///
	/// <param>silhouette Silhouette mask that has non-zero pixels where the motion
	/// occurs.</param>
	/// <param>mhi Motion history image that is updated by the function
	/// (single-channel, 32-bit floating-point).</param>
	/// <param>timestamp Current time in milliseconds or other units.</param>
	/// <param>duration Maximal duration of the motion track in the same units as
	/// <code>timestamp</code>.</param>
	///
	/// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#updatemotionhistory">org.opencv.video.Video.updateMotionHistory</a>
	public static void updateMotionHistory(Mat silhouette, Mat mhi, double timestamp, double duration)
        {
            if (silhouette != null)
                silhouette.ThrowIfDisposed();
            if (mhi != null)
                mhi.ThrowIfDisposed();

            opencvunity_video_Video_updateMotionHistory_10(silhouette.nativeObj, mhi.nativeObj, timestamp, duration);

        }


        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix)
        {
            if (templateImage != null)
                templateImage.ThrowIfDisposed();

            if (inputImage != null)
                inputImage.ThrowIfDisposed();

            if (warpMatrix!= null)
                warpMatrix.ThrowIfDisposed();

            return opencvunity_video_Video_findTransformECC_1(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj);
        }

        public static double findTransformECC(Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria termCriteria, Mat inputMask)
        {
            if (templateImage != null)
                templateImage.ThrowIfDisposed();

            if (inputImage != null)
                inputImage.ThrowIfDisposed();

            if (warpMatrix != null)
                warpMatrix.ThrowIfDisposed();

            if (inputMask != null)
                inputMask.ThrowIfDisposed(); 

            return opencvunity_video_Video_findTransformECC_2(templateImage.nativeObj, inputImage.nativeObj, warpMatrix.nativeObj, motionType, termCriteria.type, termCriteria.maxCount, termCriteria.epsilon, inputMask.nativeObj);
        }

        // C++:  RotatedRect CamShift(Mat probImage, Rect& window, TermCriteria criteria)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_CamShift_10(IntPtr probImage_nativeObj, int window_x, int window_y, int window_width, int window_height, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] double[] window_out, int criteria_type, int criteria_maxCount, double criteria_epsilon, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 5)] double[] vals);

        // C++:  int buildOpticalFlowPyramid(Mat img, vector_Mat& pyramid, Size winSize, int maxLevel, bool withDerivatives = true, int pyrBorder = BORDER_REFLECT_101, int derivBorder = BORDER_CONSTANT, bool tryReuseInputImage = true)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_video_Video_buildOpticalFlowPyramid_10(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, bool withDerivatives, int pyrBorder, int derivBorder, bool tryReuseInputImage);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_video_Video_buildOpticalFlowPyramid_11(IntPtr img_nativeObj, IntPtr pyramid_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel);

        // C++:  double calcGlobalOrientation(Mat orientation, Mat mask, Mat mhi, double timestamp, double duration)
        //[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        //private static extern double opencvunity_video_Video_calcGlobalOrientation_10 (IntPtr orientation_nativeObj, IntPtr mask_nativeObj, IntPtr mhi_nativeObj, double timestamp, double duration);

        // C++:  void calcMotionGradient(Mat mhi, Mat& mask, Mat& orientation, double delta1, double delta2, int apertureSize = 3)
        //[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        //private static extern void opencvunity_video_Video_calcMotionGradient_10 (IntPtr mhi_nativeObj, IntPtr mask_nativeObj, IntPtr orientation_nativeObj, double delta1, double delta2, int apertureSize);

        //[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        //private static extern void opencvunity_video_Video_calcMotionGradient_11 (IntPtr mhi_nativeObj, IntPtr mask_nativeObj, IntPtr orientation_nativeObj, double delta1, double delta2);

        // C++:  void calcOpticalFlowFarneback(Mat prev, Mat next, Mat& flow, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_calcOpticalFlowFarneback_10(IntPtr prev_nativeObj, IntPtr next_nativeObj, IntPtr flow_nativeObj, double pyr_scale, int levels, int winsize, int iterations, int poly_n, double poly_sigma, int flags);

        // C++:  void calcOpticalFlowPyrLK(Mat prevImg, Mat nextImg, vector_Point2f prevPts, vector_Point2f& nextPts, vector_uchar& status, vector_float& err, Size winSize = Size(21,21), int maxLevel = 3, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_calcOpticalFlowPyrLK_10(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel, int criteria_type, int criteria_maxCount, double criteria_epsilon, int flags, double minEigThreshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_calcOpticalFlowPyrLK_11(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj, double winSize_width, double winSize_height, int maxLevel);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_calcOpticalFlowPyrLK_12(IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_mat_nativeObj, IntPtr nextPts_mat_nativeObj, IntPtr status_mat_nativeObj, IntPtr err_mat_nativeObj);

        // C++:  void calcOpticalFlowSF(Mat from, Mat to, Mat flow, int layers, int averaging_block_size, int max_flow)
        //[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        //private static extern void opencvunity_video_Video_calcOpticalFlowSF_10 (IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr flow_nativeObj, int layers, int averaging_block_size, int max_flow);

        // C++:  void calcOpticalFlowSF(Mat from, Mat to, Mat flow, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr)
        //[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        //private static extern void opencvunity_video_Video_calcOpticalFlowSF_11 (IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr flow_nativeObj, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr);

        // C++:  Mat estimateRigidTransform(Mat src, Mat dst, bool fullAffine)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_Video_estimateRigidTransform_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, bool fullAffine);

        // C++:  int meanShift(Mat probImage, Rect& window, TermCriteria criteria)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_video_Video_meanShift_10(IntPtr probImage_nativeObj, int window_x, int window_y, int window_width, int window_height, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] double[] window_out, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  void segmentMotion(Mat mhi, Mat& segmask, vector_Rect& boundingRects, double timestamp, double segThresh)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_segmentMotion_10(IntPtr mhi_nativeObj, IntPtr segmask_nativeObj, IntPtr boundingRects_mat_nativeObj, double timestamp, double segThresh);

        // C++:  void updateMotionHistory(Mat silhouette, Mat& mhi, double timestamp, double duration)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_Video_updateMotionHistory_10(IntPtr silhouette_nativeObj, IntPtr mhi_nativeObj, double timestamp, double duration);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_video_Video_findTransformECC_1(IntPtr templateImage, IntPtr inputImage, IntPtr warpMatrix);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_video_Video_findTransformECC_2(IntPtr templateImage, IntPtr inputImage, IntPtr warpMatrix, int motionType, int criteria_type, int criteria_maxcount, double criteria_eps, IntPtr inputMask);
    }}