
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;using System.Collections.Generic;namespace OpenCVUnity{


    // C++: class javaGenericDescriptorMatcher
    
	/// <summary>Abstract interface for extracting and matching a keypoint descriptor. There
	/// are also "DescriptorExtractor" and "DescriptorMatcher" for these purposes but
	/// their interfaces are intended for descriptors represented as vectors in a
	/// multidimensional space. <code>GenericDescriptorMatcher</code> is a more
	/// generic interface for descriptors. <code>DescriptorMatcher</code> and
	/// <code>GenericDescriptorMatcher</code> have two groups of match methods: for
	/// matching keypoints of an image with another image or with an image set.</p>
	///
	/// <p>class GenericDescriptorMatcher <code></p>
	///
	/// <p>// C++ code:</p>
	///
	///
	/// <p>public:</p>
	///
	/// <p>GenericDescriptorMatcher();</p>
	///
	/// <p>virtual ~GenericDescriptorMatcher();</p>
	///
	/// <p>virtual void add(const vector<Mat>& images,</p>
	///
	/// <p>vector<vector<KeyPoint> >& keypoints);</p>
	///
	/// <p>const vector<Mat>& getTrainImages() const;</p>
	///
	/// <p>const vector<vector<KeyPoint> >& getTrainKeypoints() const;</p>
	///
	/// <p>virtual void clear();</p>
	///
	/// <p>virtual void train() = 0;</p>
	///
	/// <p>virtual bool isMaskSupported() = 0;</p>
	///
	/// <p>void classify(const Mat& queryImage,</p>
	///
	/// <p>vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>const Mat& trainImage,</p>
	///
	/// <p>vector<KeyPoint>& trainKeypoints) const;</p>
	///
	/// <p>void classify(const Mat& queryImage,</p>
	///
	/// <p>vector<KeyPoint>& queryKeypoints);</p>
	///
	/// <p>////</p>
	/// <ul>
	///   <li> Group of methods to match keypoints from an image pair.
	///   <li> /
	/// </ul>
	///
	/// <p>void match(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>const Mat& trainImage, vector<KeyPoint>& trainKeypoints,</p>
	///
	/// <p>vector<DMatch>& matches, const Mat& mask=Mat()) const;</p>
	///
	/// <p>void knnMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>const Mat& trainImage, vector<KeyPoint>& trainKeypoints,</p>
	///
	/// <p>vector<vector<DMatch> >& matches, int k,</p>
	///
	/// <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
	///
	/// <p>void radiusMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>const Mat& trainImage, vector<KeyPoint>& trainKeypoints,</p>
	///
	/// <p>vector<vector<DMatch> >& matches, float maxDistance,</p>
	///
	/// <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
	///
	/// <p>////</p>
	/// <ul>
	///   <li> Group of methods to match keypoints from one image to an image set.
	///   <li> /
	/// </ul>
	///
	/// <p>void match(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>vector<DMatch>& matches, const vector<Mat>& masks=vector<Mat>());</p>
	///
	/// <p>void knnMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>vector<vector<DMatch> >& matches, int k,</p>
	///
	/// <p>const vector<Mat>& masks=vector<Mat>(), bool compactResult=false);</p>
	///
	/// <p>void radiusMatch(const Mat& queryImage, vector<KeyPoint>& queryKeypoints,</p>
	///
	/// <p>vector<vector<DMatch> >& matches, float maxDistance,</p>
	///
	/// <p>const vector<Mat>& masks=vector<Mat>(), bool compactResult=false);</p>
	///
	/// <p>virtual void read(const FileNode&);</p>
	///
	/// <p>virtual void write(FileStorage&) const;</p>
	///
	/// <p>virtual Ptr<GenericDescriptorMatcher> clone(bool emptyTrainData=false) const
	/// = 0;</p>
	///
	/// <p>protected:...</p>
	///
	/// <p>};</p>
	///
	/// <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_generic_descriptor_matchers.html#genericdescriptormatcher">org.opencv.features2d.GenericDescriptorMatcher</a>
	public class GenericDescriptorMatcher : DisposableOpenCVObject
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
                        opencvunity_features2d_GenericDescriptorMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected GenericDescriptorMatcher(IntPtr addr)
        {
            nativeObj = addr;
        }

        public const int ONEWAY = 1;
        public const int FERN = 2;


        //
        // C++:  void javaGenericDescriptorMatcher::add(vector_Mat images, vector_vector_KeyPoint keypoints)
        //

        public void add(List<Mat> images, List<MatOfKeyPoint> keypoints)
        {
            ThrowIfDisposed();

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            List<Mat> keypoints_tmplm = new List<Mat>((keypoints != null) ? keypoints.Count : 0);
            Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat(keypoints, keypoints_tmplm);
            opencvunity_features2d_GenericDescriptorMatcher_add_10(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints)
        //

        public void classify(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            opencvunity_features2d_GenericDescriptorMatcher_classify_10(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints)
        //

        public void classify(Mat queryImage, MatOfKeyPoint queryKeypoints)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            opencvunity_features2d_GenericDescriptorMatcher_classify_11(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_features2d_GenericDescriptorMatcher_clear_10(nativeObj);

        }


        //
        // C++:  javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::jclone(bool emptyTrainData = false)
        //

        public GenericDescriptorMatcher clone(bool emptyTrainData)
        {
            ThrowIfDisposed();

            GenericDescriptorMatcher retVal = new GenericDescriptorMatcher(opencvunity_features2d_GenericDescriptorMatcher_clone_10(nativeObj, emptyTrainData));

            return retVal;
        }

        public GenericDescriptorMatcher clone()
        {
            ThrowIfDisposed();

            GenericDescriptorMatcher retVal = new GenericDescriptorMatcher(opencvunity_features2d_GenericDescriptorMatcher_clone_11(nativeObj));

            return retVal;
        }


        //
        // C++: static javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::create(int matcherType)
        //

        public static GenericDescriptorMatcher create(int matcherType)
        {

            GenericDescriptorMatcher retVal = new GenericDescriptorMatcher(opencvunity_features2d_GenericDescriptorMatcher_create_10(matcherType));

            return retVal;
        }


        //
        // C++:  bool javaGenericDescriptorMatcher::empty()
        //

        public bool empty()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_features2d_GenericDescriptorMatcher_empty_10(nativeObj);

            return retVal;
        }


        //
        // C++:  vector_Mat javaGenericDescriptorMatcher::getTrainImages()
        //

        public List<Mat> getTrainImages()
        {
            ThrowIfDisposed();

            List<Mat> retVal = new List<Mat>();
            Mat retValMat = new Mat(opencvunity_features2d_GenericDescriptorMatcher_getTrainImages_10(nativeObj));
            Converters.Mat_to_vector_Mat(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  vector_vector_KeyPoint javaGenericDescriptorMatcher::getTrainKeypoints()
        //

        public List<MatOfKeyPoint> getTrainKeypoints()
        {
            ThrowIfDisposed();

            List<MatOfKeyPoint> retVal = new List<MatOfKeyPoint>();
            Mat retValMat = new Mat(opencvunity_features2d_GenericDescriptorMatcher_getTrainKeypoints_10(nativeObj));
            Converters.Mat_to_vector_vector_KeyPoint(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  bool javaGenericDescriptorMatcher::isMaskSupported()
        //

        public bool isMaskSupported()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_features2d_GenericDescriptorMatcher_isMaskSupported_10(nativeObj);

            return retVal;
        }


        //
        // C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        //

        public void knnMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            Mat matches_mat = new Mat();
            opencvunity_features2d_GenericDescriptorMatcher_knnMatch_10(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void knnMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, int k)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            Mat matches_mat = new Mat();
            opencvunity_features2d_GenericDescriptorMatcher_knnMatch_11(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, k);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        //

        public void knnMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            opencvunity_features2d_GenericDescriptorMatcher_knnMatch_12(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void knnMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, int k)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat matches_mat = new Mat();
            opencvunity_features2d_GenericDescriptorMatcher_knnMatch_13(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, k);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_DMatch& matches, Mat mask = Mat())
        //

        public void match(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, MatOfDMatch matches, Mat mask)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            Mat matches_mat = matches;
            opencvunity_features2d_GenericDescriptorMatcher_match_10(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, mask.nativeObj);

        }

        public void match(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, MatOfDMatch matches)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            Mat matches_mat = matches;
            opencvunity_features2d_GenericDescriptorMatcher_match_11(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
        //

        public void match(Mat queryImage, MatOfKeyPoint queryKeypoints, MatOfDMatch matches, List<Mat> masks)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat matches_mat = matches;
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            opencvunity_features2d_GenericDescriptorMatcher_match_12(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);

        }

        public void match(Mat queryImage, MatOfKeyPoint queryKeypoints, MatOfDMatch matches)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat matches_mat = matches;
            opencvunity_features2d_GenericDescriptorMatcher_match_13(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        //

        public void radiusMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            Mat matches_mat = new Mat();
            opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_10(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void radiusMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, Mat trainImage, MatOfKeyPoint trainKeypoints, List<MatOfDMatch> matches, float maxDistance)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            if (trainImage != null)
                trainImage.ThrowIfDisposed();
            if (trainKeypoints != null)
                trainKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat trainKeypoints_mat = trainKeypoints;
            Mat matches_mat = new Mat();
            opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_11(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, trainImage.nativeObj, trainKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        //

        public void radiusMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_12(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void radiusMatch(Mat queryImage, MatOfKeyPoint queryKeypoints, List<MatOfDMatch> matches, float maxDistance)
        {
            if (queryImage != null)
                queryImage.ThrowIfDisposed();
            if (queryKeypoints != null)
                queryKeypoints.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat queryKeypoints_mat = queryKeypoints;
            Mat matches_mat = new Mat();
            opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_13(nativeObj, queryImage.nativeObj, queryKeypoints_mat.nativeObj, matches_mat.nativeObj, maxDistance);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaGenericDescriptorMatcher::read(string fileName)
        //

        public void read(string fileName)
        {
            ThrowIfDisposed();

            opencvunity_features2d_GenericDescriptorMatcher_read_10(nativeObj, fileName);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::train()
        //

        public void train()
        {
            ThrowIfDisposed();

            opencvunity_features2d_GenericDescriptorMatcher_train_10(nativeObj);

        }


        //
        // C++:  void javaGenericDescriptorMatcher::write(string fileName)
        //

        public void write(string fileName)
        {
            ThrowIfDisposed();

            opencvunity_features2d_GenericDescriptorMatcher_write_10(nativeObj, fileName);

        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_features2d_GenericDescriptorMatcher_delete(nativeObj);
        //	}



        // C++:  void javaGenericDescriptorMatcher::add(vector_Mat images, vector_vector_KeyPoint keypoints)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_add_10(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_classify_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj);

        // C++:  void javaGenericDescriptorMatcher::classify(Mat queryImage, vector_KeyPoint& queryKeypoints)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_classify_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj);

        // C++:  void javaGenericDescriptorMatcher::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_clear_10(IntPtr nativeObj);

        // C++:  javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::jclone(bool emptyTrainData = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_GenericDescriptorMatcher_clone_10(IntPtr nativeObj, bool emptyTrainData);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_GenericDescriptorMatcher_clone_11(IntPtr nativeObj);

        // C++: static javaGenericDescriptorMatcher* javaGenericDescriptorMatcher::create(int matcherType)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_GenericDescriptorMatcher_create_10(int matcherType);

        // C++:  bool javaGenericDescriptorMatcher::empty()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_features2d_GenericDescriptorMatcher_empty_10(IntPtr nativeObj);

        // C++:  vector_Mat javaGenericDescriptorMatcher::getTrainImages()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_GenericDescriptorMatcher_getTrainImages_10(IntPtr nativeObj);

        // C++:  vector_vector_KeyPoint javaGenericDescriptorMatcher::getTrainKeypoints()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_GenericDescriptorMatcher_getTrainKeypoints_10(IntPtr nativeObj);

        // C++:  bool javaGenericDescriptorMatcher::isMaskSupported()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_features2d_GenericDescriptorMatcher_isMaskSupported_10(IntPtr nativeObj);

        // C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_knnMatch_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_knnMatch_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void javaGenericDescriptorMatcher::knnMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_knnMatch_12(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_knnMatch_13(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_DMatch& matches, Mat mask = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_match_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_match_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void javaGenericDescriptorMatcher::match(Mat queryImage, vector_KeyPoint queryKeypoints, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_match_12(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_match_13(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, Mat trainImage, vector_KeyPoint trainKeypoints, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_10(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_11(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr trainImage_nativeObj, IntPtr trainKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void javaGenericDescriptorMatcher::radiusMatch(Mat queryImage, vector_KeyPoint queryKeypoints, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_12(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_radiusMatch_13(IntPtr nativeObj, IntPtr queryImage_nativeObj, IntPtr queryKeypoints_mat_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void javaGenericDescriptorMatcher::read(string fileName)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_read_10(IntPtr nativeObj, string fileName);

        // C++:  void javaGenericDescriptorMatcher::train()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_train_10(IntPtr nativeObj);

        // C++:  void javaGenericDescriptorMatcher::write(string fileName)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_write_10(IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_GenericDescriptorMatcher_delete(IntPtr nativeObj);
    }}