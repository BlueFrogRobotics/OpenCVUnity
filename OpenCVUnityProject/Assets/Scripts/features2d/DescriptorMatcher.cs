
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;using System.Collections.Generic;namespace OpenCVUnity{
    // C++: class javaDescriptorMatcher

    /// <summary>Abstract base class for matching keypoint descriptors. It has two groups of
    /// match methods: for matching descriptors of an image with another image or
    /// with an image set.</p>
    ///
    /// <p>class DescriptorMatcher <code></p>
    ///
    /// <p>// C++ code:</p>
    ///
    ///
    /// <p>public:</p>
    ///
    /// <p>virtual ~DescriptorMatcher();</p>
    ///
    /// <p>virtual void add(const vector<Mat>& descriptors);</p>
    ///
    /// <p>const vector<Mat>& getTrainDescriptors() const;</p>
    ///
    /// <p>virtual void clear();</p>
    ///
    /// <p>bool empty() const;</p>
    ///
    /// <p>virtual bool isMaskSupported() const = 0;</p>
    ///
    /// <p>virtual void train();</p>
    ///
    /// <p>////</p>
    /// <ul>
    ///   <li> Group of methods to match descriptors from an image pair.
    ///   <li> /
    /// </ul>
    ///
    /// <p>void match(const Mat& queryDescriptors, const Mat& trainDescriptors,</p>
    ///
    /// <p>vector<DMatch>& matches, const Mat& mask=Mat()) const;</p>
    ///
    /// <p>void knnMatch(const Mat& queryDescriptors, const Mat& trainDescriptors,</p>
    ///
    /// <p>vector<vector<DMatch> >& matches, int k,</p>
    ///
    /// <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
    ///
    /// <p>void radiusMatch(const Mat& queryDescriptors, const Mat& trainDescriptors,</p>
    ///
    /// <p>vector<vector<DMatch> >& matches, float maxDistance,</p>
    ///
    /// <p>const Mat& mask=Mat(), bool compactResult=false) const;</p>
    ///
    /// <p>////</p>
    /// <ul>
    ///   <li> Group of methods to match descriptors from one image to an image set.
    ///   <li> /
    /// </ul>
    ///
    /// <p>void match(const Mat& queryDescriptors, vector<DMatch>& matches,</p>
    ///
    /// <p>const vector<Mat>& masks=vector<Mat>());</p>
    ///
    /// <p>void knnMatch(const Mat& queryDescriptors, vector<vector<DMatch> >& matches,</p>
    ///
    /// <p>int k, const vector<Mat>& masks=vector<Mat>(),</p>
    ///
    /// <p>bool compactResult=false);</p>
    ///
    /// <p>void radiusMatch(const Mat& queryDescriptors, vector<vector<DMatch> >&
    /// matches,</p>
    ///
    /// <p>float maxDistance, const vector<Mat>& masks=vector<Mat>(),</p>
    ///
    /// <p>bool compactResult=false);</p>
    ///
    /// <p>virtual void read(const FileNode&);</p>
    ///
    /// <p>virtual void write(FileStorage&) const;</p>
    ///
    /// <p>virtual Ptr<DescriptorMatcher> clone(bool emptyTrainData=false) const = 0;</p>
    ///
    /// <p>static Ptr<DescriptorMatcher> create(const string& descriptorMatcherType);</p>
    ///
    /// <p>protected:</p>
    ///
    /// <p>vector<Mat> trainDescCollection;...</p>
    ///
    /// <p>};</p>
    ///
    /// <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher">org.opencv.features2d.DescriptorMatcher : public Algorithm</a>
    public class DescriptorMatcher : DisposableOpenCVObject
    {
        protected override void Dispose(bool disposing)
        {
            try {

                if (disposing) {
                }

                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_features2d_DescriptorMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected DescriptorMatcher(IntPtr addr)
        {
            nativeObj = addr;
        }

        public const int FLANNBASED = 1;
        public const int BRUTEFORCE = 2;
        public const int BRUTEFORCE_L1 = 3;
        public const int BRUTEFORCE_HAMMING = 4;
        public const int BRUTEFORCE_HAMMINGLUT = 5;
        public const int BRUTEFORCE_SL2 = 6;


        //
        // C++:  void javaDescriptorMatcher::add(vector_Mat descriptors)
        //

        public void add(List<Mat> descriptors)
        {
            ThrowIfDisposed();

            Mat descriptors_mat = Converters.vector_Mat_to_Mat(descriptors);
            opencvunity_features2d_DescriptorMatcher_add_10(nativeObj, descriptors_mat.nativeObj);
        }


        //
        // C++:  void javaDescriptorMatcher::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            opencvunity_features2d_DescriptorMatcher_clear_10(nativeObj);
        }


        //
        // C++:  javaDescriptorMatcher* javaDescriptorMatcher::jclone(bool emptyTrainData = false)
        //

        public DescriptorMatcher clone(bool emptyTrainData)
        {
            ThrowIfDisposed();

            DescriptorMatcher retVal = new DescriptorMatcher(opencvunity_features2d_DescriptorMatcher_clone_10(nativeObj, emptyTrainData));

            return retVal;
        }

        public DescriptorMatcher clone()
        {
            ThrowIfDisposed();

            DescriptorMatcher retVal = new DescriptorMatcher(opencvunity_features2d_DescriptorMatcher_clone_11(nativeObj));

            return retVal;
        }


        //
        // C++: static javaDescriptorMatcher* javaDescriptorMatcher::create(int matcherType)
        //


        /// <summary>Creates a descriptor matcher of a given type with the default parameters
        /// (using default constructor).</summary>
        ///
        /// <param>matcherType a matcherType</param>
        ///
        /// <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_matchers.html#descriptormatcher-create">org.opencv.features2d.DescriptorMatcher.create</a>
        public static DescriptorMatcher create(int matcherType)
        {
            DescriptorMatcher retVal = new DescriptorMatcher(opencvunity_features2d_DescriptorMatcher_create_10(matcherType));

            return retVal;
        }


        //
        // C++:  bool javaDescriptorMatcher::empty()
        //

        public bool empty()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_features2d_DescriptorMatcher_empty_10(nativeObj);

            return retVal;
        }


        //
        // C++:  vector_Mat javaDescriptorMatcher::getTrainDescriptors()
        //

        public List<Mat> getTrainDescriptors()
        {
            ThrowIfDisposed();

            List<Mat> retVal = new List<Mat>();
            Mat retValMat = new Mat(opencvunity_features2d_DescriptorMatcher_getTrainDescriptors_10(nativeObj));
            Converters.Mat_to_vector_Mat(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  bool javaDescriptorMatcher::isMaskSupported()
        //

        public bool isMaskSupported()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_features2d_DescriptorMatcher_isMaskSupported_10(nativeObj);

            return retVal;
        }


        //
        // C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        //

        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k, Mat mask, bool compactResult)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null)
                trainDescriptors.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            opencvunity_features2d_DescriptorMatcher_knnMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k, mask.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void knnMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, int k)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null)
                trainDescriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            opencvunity_features2d_DescriptorMatcher_knnMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, k);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        //

        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k, List<Mat> masks, bool compactResult)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            opencvunity_features2d_DescriptorMatcher_knnMatch_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k, masks_mat.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void knnMatch(Mat queryDescriptors, List<MatOfDMatch> matches, int k)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            opencvunity_features2d_DescriptorMatcher_knnMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, k);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
        //

        public void match(Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches, Mat mask)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null)
                trainDescriptors.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = matches;
            opencvunity_features2d_DescriptorMatcher_match_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, mask.nativeObj);

        }

        public void match(Mat queryDescriptors, Mat trainDescriptors, MatOfDMatch matches)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null)
                trainDescriptors.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = matches;
            opencvunity_features2d_DescriptorMatcher_match_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj);

        }


        //
        // C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
        //

        public void match(Mat queryDescriptors, MatOfDMatch matches, List<Mat> masks)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = matches;
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            opencvunity_features2d_DescriptorMatcher_match_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, masks_mat.nativeObj);

        }

        public void match(Mat queryDescriptors, MatOfDMatch matches)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (matches != null)
                matches.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = matches;
            opencvunity_features2d_DescriptorMatcher_match_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj);

        }


        //
        // C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        //

        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance, Mat mask, bool compactResult)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null)
                trainDescriptors.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            opencvunity_features2d_DescriptorMatcher_radiusMatch_10(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, mask.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void radiusMatch(Mat queryDescriptors, Mat trainDescriptors, List<MatOfDMatch> matches, float maxDistance)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            if (trainDescriptors != null)
                trainDescriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            opencvunity_features2d_DescriptorMatcher_radiusMatch_11(nativeObj, queryDescriptors.nativeObj, trainDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        //

        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance, List<Mat> masks, bool compactResult)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            opencvunity_features2d_DescriptorMatcher_radiusMatch_12(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance, masks_mat.nativeObj, compactResult);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }

        public void radiusMatch(Mat queryDescriptors, List<MatOfDMatch> matches, float maxDistance)
        {
            if (queryDescriptors != null)
                queryDescriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat matches_mat = new Mat();
            opencvunity_features2d_DescriptorMatcher_radiusMatch_13(nativeObj, queryDescriptors.nativeObj, matches_mat.nativeObj, maxDistance);
            Converters.Mat_to_vector_vector_DMatch(matches_mat, matches);
        }


        //
        // C++:  void javaDescriptorMatcher::read(string fileName)
        //

        public void read(string fileName)
        {
            ThrowIfDisposed();

            opencvunity_features2d_DescriptorMatcher_read_10(nativeObj, fileName);
        }


        //
        // C++:  void javaDescriptorMatcher::train()
        //

        public void train()
        {
            ThrowIfDisposed();

            opencvunity_features2d_DescriptorMatcher_train_10(nativeObj);
        }


        //
        // C++:  void javaDescriptorMatcher::write(string fileName)
        //

        public void write(string fileName)
        {
            ThrowIfDisposed();

            opencvunity_features2d_DescriptorMatcher_write_10(nativeObj, fileName);
        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_features2d_DescriptorMatcher_delete(nativeObj);
        //	}



        // C++:  void javaDescriptorMatcher::add(vector_Mat descriptors)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_add_10(IntPtr nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void javaDescriptorMatcher::clear()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_clear_10(IntPtr nativeObj);

        // C++:  javaDescriptorMatcher* javaDescriptorMatcher::jclone(bool emptyTrainData = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_DescriptorMatcher_clone_10(IntPtr nativeObj, bool emptyTrainData);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_DescriptorMatcher_clone_11(IntPtr nativeObj);

        // C++: static javaDescriptorMatcher* javaDescriptorMatcher::create(int matcherType)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_DescriptorMatcher_create_10(int matcherType);

        // C++:  bool javaDescriptorMatcher::empty()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_features2d_DescriptorMatcher_empty_10(IntPtr nativeObj);

        // C++:  vector_Mat javaDescriptorMatcher::getTrainDescriptors()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_DescriptorMatcher_getTrainDescriptors_10(IntPtr nativeObj);

        // C++:  bool javaDescriptorMatcher::isMaskSupported()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_features2d_DescriptorMatcher_isMaskSupported_10(IntPtr nativeObj);

        // C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, int k, Mat mask = Mat(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_knnMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr mask_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_knnMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void javaDescriptorMatcher::knnMatch(Mat queryDescriptors, vector_vector_DMatch& matches, int k, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_knnMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k, IntPtr masks_mat_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_knnMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, int k);

        // C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, Mat trainDescriptors, vector_DMatch& matches, Mat mask = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_match_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr mask_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_match_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void javaDescriptorMatcher::match(Mat queryDescriptors, vector_DMatch& matches, vector_Mat masks = vector<Mat>())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_match_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, IntPtr masks_mat_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_match_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, Mat trainDescriptors, vector_vector_DMatch& matches, float maxDistance, Mat mask = Mat(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_radiusMatch_10(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr mask_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_radiusMatch_11(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr trainDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void javaDescriptorMatcher::radiusMatch(Mat queryDescriptors, vector_vector_DMatch& matches, float maxDistance, vector_Mat masks = vector<Mat>(), bool compactResult = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_radiusMatch_12(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance, IntPtr masks_mat_nativeObj, bool compactResult);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_radiusMatch_13(IntPtr nativeObj, IntPtr queryDescriptors_nativeObj, IntPtr matches_mat_nativeObj, float maxDistance);

        // C++:  void javaDescriptorMatcher::read(string fileName)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_read_10(IntPtr nativeObj, string fileName);

        // C++:  void javaDescriptorMatcher::train()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_train_10(IntPtr nativeObj);

        // C++:  void javaDescriptorMatcher::write(string fileName)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_write_10(IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorMatcher_delete(IntPtr nativeObj);
    }}