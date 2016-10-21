using System;
using System.Runtime.InteropServices;
using System.IO;

//
// This file is auto-generated. Please don't modify it!
//
namespace OpenCVUnity
{

    
	/// <summary>Cascade classifier class for object detection.</summary>
	///
	/// <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#cascadeclassifier">org.opencv.objdetect.CascadeClassifier</a>
	public class CascadeClassifier : DisposableOpenCVObject
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_objdetect_CascadeClassifier_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        protected CascadeClassifier(IntPtr addr)
        {
            nativeObj = addr;
        }


        //
        // C++:   CascadeClassifier::CascadeClassifier()
        //

        public CascadeClassifier()
        {

            nativeObj = opencvunity_objdetect_CascadeClassifier_CascadeClassifier_10();
        }


        //
        // C++:   CascadeClassifier::CascadeClassifier(string filename)
        //

        public CascadeClassifier(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("The specified filename doesn't exist : " + filename);

            nativeObj = opencvunity_objdetect_CascadeClassifier_CascadeClassifier_11(filename);
        }


        //
        // C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //
        public void detectMultiScale(Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {

            if (image != null)
                image.ThrowIfDisposed();
            if (objects != null)
                objects.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat objects_mat = objects;
            opencvunity_objdetect_CascadeClassifier_detectMultiScale_10(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
        }

        public void detectMultiScale(Mat image, MatOfRect objects)
        {
            if (image != null)
                image.ThrowIfDisposed();
            if (objects != null)
                objects.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat objects_mat = objects;
            opencvunity_objdetect_CascadeClassifier_detectMultiScale_11(nativeObj, image.nativeObj, objects_mat.nativeObj);
        }


        //
        // C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int rejectLevels, vector_double levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        //

        public void detectMultiScale(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize, bool outputRejectLevels)
        {
            if (image != null)
                image.ThrowIfDisposed();
            if (objects != null)
                objects.ThrowIfDisposed();
            if (rejectLevels != null)
                rejectLevels.ThrowIfDisposed();
            if (levelWeights != null)
                levelWeights.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            opencvunity_objdetect_CascadeClassifier_detectMultiScale_12(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height, outputRejectLevels);

        }

        public void detectMultiScale(Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights)
        {
            if (image != null)
                image.ThrowIfDisposed();
            if (objects != null)
                objects.ThrowIfDisposed();
            if (rejectLevels != null)
                rejectLevels.ThrowIfDisposed();
            if (levelWeights != null)
                levelWeights.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat objects_mat = objects;
            Mat rejectLevels_mat = rejectLevels;
            Mat levelWeights_mat = levelWeights;
            opencvunity_objdetect_CascadeClassifier_detectMultiScale_13(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj);

        }


        //
        // C++:  bool CascadeClassifier::empty()
        //

        public bool empty()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_objdetect_CascadeClassifier_empty_10(nativeObj);

            return retVal;
        }


        //
        // C++:  bool CascadeClassifier::load(string filename)
        //

        public bool load(string filename)
        {
            ThrowIfDisposed();

            if (!File.Exists(filename))
                throw new IOException("The specified filename doesn't exist : " + filename);

            bool retVal = opencvunity_objdetect_CascadeClassifier_load_10(nativeObj, filename);

            return retVal;
        }

        // C++:   CascadeClassifier::CascadeClassifier()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_CascadeClassifier_CascadeClassifier_10();

        // C++:   CascadeClassifier::CascadeClassifier(string filename)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_CascadeClassifier_CascadeClassifier_11(string filename);

        // C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_CascadeClassifier_detectMultiScale_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_CascadeClassifier_detectMultiScale_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);

        // C++:  void CascadeClassifier::detectMultiScale(Mat image, vector_Rect& objects, vector_int rejectLevels, vector_double levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_CascadeClassifier_detectMultiScale_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, bool outputRejectLevels);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_CascadeClassifier_detectMultiScale_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);

        // C++:  bool CascadeClassifier::empty()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_objdetect_CascadeClassifier_empty_10(IntPtr nativeObj);

        // C++:  bool CascadeClassifier::load(string filename)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_objdetect_CascadeClassifier_load_10(IntPtr nativeObj, string filename);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_CascadeClassifier_delete(IntPtr nativeObj);
    }
}
