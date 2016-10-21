
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;using System.Collections.Generic;namespace OpenCVUnity{
    // C++: class javaDescriptorExtractor

    /// <summary>Abstract base class for computing descriptors for image keypoints.</summary>
    ///
    /// <p>class CV_EXPORTS DescriptorExtractor <code></p>
    ///
    /// <p>// C++ code:</p>
    ///
    ///
    /// <p>public:</p>
    ///
    /// <p>virtual ~DescriptorExtractor();</p>
    ///
    /// <p>void compute(const Mat& image, vector<KeyPoint>& keypoints,</p>
    ///
    /// <p>Mat& descriptors) const;</p>
    ///
    /// <p>void compute(const vector<Mat>& images, vector<vector<KeyPoint> >& keypoints,</p>
    ///
    /// <p>vector<Mat>& descriptors) const;</p>
    ///
    /// <p>virtual void read(const FileNode&);</p>
    ///
    /// <p>virtual void write(FileStorage&) const;</p>
    ///
    /// <p>virtual int descriptorSize() const = 0;</p>
    ///
    /// <p>virtual int descriptorType() const = 0;</p>
    ///
    /// <p>static Ptr<DescriptorExtractor> create(const string& descriptorExtractorType);</p>
    ///
    /// <p>protected:...</p>
    ///
    /// <p>};</p>
    ///
    /// <p>In this interface, a keypoint descriptor can be represented as a </code></p>
    ///
    /// <p>dense, fixed-dimension vector of a basic type. Most descriptors follow this
    /// pattern as it simplifies computing distances between descriptors. Therefore,
    /// a collection of descriptors is represented as "Mat", where each row is a
    /// keypoint descriptor.</p>
    ///
    /// <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_extractors.html#descriptorextractor">org.opencv.features2d.DescriptorExtractor : public Algorithm</a>
    public class DescriptorExtractor : DisposableOpenCVObject
    {
        protected override void Dispose(bool disposing)
        {

            try {

                if (disposing) {
                }

                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_features2d_DescriptorExtractor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected DescriptorExtractor(IntPtr addr)
        {
            nativeObj = addr;
        }

        private const int OPPONENTEXTRACTOR = 1000;
        public const int SIFT = 1;
        public const int SURF = 2;
        public const int ORB = 3;
        public const int BRIEF = 4;
        public const int BRISK = 5;
        public const int FREAK = 6;
        public const int OPPONENT_SIFT = OPPONENTEXTRACTOR + SIFT;
        public const int OPPONENT_SURF = OPPONENTEXTRACTOR + SURF;
        public const int OPPONENT_ORB = OPPONENTEXTRACTOR + ORB;
        public const int OPPONENT_BRIEF = OPPONENTEXTRACTOR + BRIEF;
        public const int OPPONENT_BRISK = OPPONENTEXTRACTOR + BRISK;
        public const int OPPONENT_FREAK = OPPONENTEXTRACTOR + FREAK;


        //
        // C++:  void javaDescriptorExtractor::compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
        //

        public void compute(Mat image, MatOfKeyPoint keypoints, Mat descriptors)
        {
            if (image != null)
                image.ThrowIfDisposed();
            if (keypoints != null)
                keypoints.ThrowIfDisposed();
            if (descriptors != null)
                descriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat keypoints_mat = keypoints;
            opencvunity_features2d_DescriptorExtractor_compute_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);

        }


        //
        // C++:  void javaDescriptorExtractor::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        //

        public void compute(List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> descriptors)
        {
            ThrowIfDisposed();

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            List<Mat> keypoints_tmplm = new List<Mat>((keypoints != null) ? keypoints.Count : 0);
            Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat(keypoints, keypoints_tmplm);
            Mat descriptors_mat = new Mat();
            opencvunity_features2d_DescriptorExtractor_compute_11(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, descriptors_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
            Converters.Mat_to_vector_Mat(descriptors_mat, descriptors);
        }


        //
        // C++: static javaDescriptorExtractor* javaDescriptorExtractor::create(int extractorType)
        //


        /// <summary>Creates a descriptor extractor by name.</summary>
        ///
        /// <p>The current implementation supports the following types of a descriptor
        /// extractor:</p>
        /// <ul>
        ///   <li> <code>"SIFT"</code> -- "SIFT"
        ///   <li> <code>"SURF"</code> -- "SURF"
        ///   <li> <code>"BRIEF"</code> -- "BriefDescriptorExtractor"
        ///   <li> <code>"BRISK"</code> -- "BRISK"
        ///   <li> <code>"ORB"</code> -- "ORB"
        ///   <li> <code>"FREAK"</code> -- "FREAK"
        /// </ul>
        ///
        /// <p>A combined format is also supported: descriptor extractor adapter name
        /// (<code>"Opponent"</code> -- "OpponentColorDescriptorExtractor") + descriptor
        /// extractor name (see above), for example: <code>"OpponentSIFT"</code>.</p>
        ///
        /// <param>extractorType a extractorType</param>
        ///
        /// <a href="http://docs.opencv.org/modules/features2d/doc/common_interfaces_of_descriptor_extractors.html#descriptorextractor-create">org.opencv.features2d.DescriptorExtractor.create</a>
        public static DescriptorExtractor create(int extractorType)
        {
            DescriptorExtractor retVal = new DescriptorExtractor(opencvunity_features2d_DescriptorExtractor_create_10(extractorType));

            return retVal;
        }


        //
        // C++:  int javaDescriptorExtractor::descriptorSize()
        //

        public int descriptorSize()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_features2d_DescriptorExtractor_descriptorSize_10(nativeObj);

            return retVal;
        }


        //
        // C++:  int javaDescriptorExtractor::descriptorType()
        //

        public int descriptorType()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_features2d_DescriptorExtractor_descriptorType_10(nativeObj);

            return retVal;
        }


        //
        // C++:  bool javaDescriptorExtractor::empty()
        //

        public bool empty()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_features2d_DescriptorExtractor_empty_10(nativeObj);

            return retVal;
        }


        //
        // C++:  void javaDescriptorExtractor::read(string fileName)
        //

        public void read(string fileName)
        {
            ThrowIfDisposed();

            opencvunity_features2d_DescriptorExtractor_read_10(nativeObj, fileName);

        }


        //
        // C++:  void javaDescriptorExtractor::write(string fileName)
        //

        public void write(string fileName)
        {
            ThrowIfDisposed();

            opencvunity_features2d_DescriptorExtractor_write_10(nativeObj, fileName);

        }

        // C++:  void javaDescriptorExtractor::compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorExtractor_compute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void javaDescriptorExtractor::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorExtractor_compute_11(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++: static javaDescriptorExtractor* javaDescriptorExtractor::create(int extractorType)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_features2d_DescriptorExtractor_create_10(int extractorType);

        // C++:  int javaDescriptorExtractor::descriptorSize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_features2d_DescriptorExtractor_descriptorSize_10(IntPtr nativeObj);

        // C++:  int javaDescriptorExtractor::descriptorType()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_features2d_DescriptorExtractor_descriptorType_10(IntPtr nativeObj);

        // C++:  bool javaDescriptorExtractor::empty()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_features2d_DescriptorExtractor_empty_10(IntPtr nativeObj);

        // C++:  void javaDescriptorExtractor::read(string fileName)
        //		[DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorExtractor_read_10(IntPtr nativeObj, string fileName);

        // C++:  void javaDescriptorExtractor::write(string fileName)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorExtractor_write_10(IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_features2d_DescriptorExtractor_delete(IntPtr nativeObj);
    }}