
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;
using System.IO;

//
// This file is auto-generated. Please don't modify it!
//
namespace OpenCVUnity{

    // C++: class HOGDescriptor
    public class HOGDescriptor : DisposableOpenCVObject
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
                        opencvunity_objdetect_HOGDescriptor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected HOGDescriptor(IntPtr addr)
        {
            nativeObj = addr;
        }

        public const int L2Hys = 0;
        public const int DEFAULT_NLEVELS = 64;


        //
        // C++:   HOGDescriptor::HOGDescriptor()
        //

        public HOGDescriptor()
        {
            nativeObj = opencvunity_objdetect_HOGDescriptor_HOGDescriptor_10();

        }


        //
        // C++:   HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS)
        //

        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels)
        {
            nativeObj = opencvunity_objdetect_HOGDescriptor_HOGDescriptor_11(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection, _nlevels);

        }

        public HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins)
        {
            nativeObj = opencvunity_objdetect_HOGDescriptor_HOGDescriptor_12(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins);

        }


        //
        // C++:   HOGDescriptor::HOGDescriptor(String filename)
        //

        public HOGDescriptor(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("The specified filename doesn't exist : " + filename);

            nativeObj = opencvunity_objdetect_HOGDescriptor_HOGDescriptor_13(filename);
        }


        //
        // C++:  bool HOGDescriptor::checkDetectorSize()
        //

        public bool checkDetectorSize()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_objdetect_HOGDescriptor_checkDetectorSize_10(nativeObj);

            return retVal;
        }


        //
        // C++:  void HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = vector<Point>())
        //

        public void compute(Mat img, MatOfFloat descriptors, Size winStride, Size padding, MatOfPoint locations)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (descriptors != null)
                descriptors.ThrowIfDisposed();
            if (locations != null)
                locations.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat descriptors_mat = descriptors;
            Mat locations_mat = locations;
            opencvunity_objdetect_HOGDescriptor_compute_10(nativeObj, img.nativeObj, descriptors_mat.nativeObj, winStride.width, winStride.height, padding.width, padding.height, locations_mat.nativeObj);

        }

        public void compute(Mat img, MatOfFloat descriptors)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (descriptors != null)
                descriptors.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat descriptors_mat = descriptors;
            opencvunity_objdetect_HOGDescriptor_compute_11(nativeObj, img.nativeObj, descriptors_mat.nativeObj);

        }


        //
        // C++:  void HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
        //

        public void computeGradient(Mat img, Mat grad, Mat angleOfs, Size paddingTL, Size paddingBR)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (grad != null)
                grad.ThrowIfDisposed();
            if (angleOfs != null)
                angleOfs.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_objdetect_HOGDescriptor_computeGradient_10(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj, paddingTL.width, paddingTL.height, paddingBR.width, paddingBR.height);

        }

        public void computeGradient(Mat img, Mat grad, Mat angleOfs)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (grad != null)
                grad.ThrowIfDisposed();
            if (angleOfs != null)
                angleOfs.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_objdetect_HOGDescriptor_computeGradient_11(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj);

        }


        //
        // C++:  void HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = vector<Point>())
        //

        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold, Size winStride, Size padding, MatOfPoint searchLocations)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (foundLocations != null)
                foundLocations.ThrowIfDisposed();
            if (weights != null)
                weights.ThrowIfDisposed();
            if (searchLocations != null)
                searchLocations.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            Mat searchLocations_mat = searchLocations;
            opencvunity_objdetect_HOGDescriptor_detect_10(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, searchLocations_mat.nativeObj);

        }

        public void detect(Mat img, MatOfPoint foundLocations, MatOfDouble weights)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (foundLocations != null)
                foundLocations.ThrowIfDisposed();
            if (weights != null)
                weights.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat foundLocations_mat = foundLocations;
            Mat weights_mat = weights;
            opencvunity_objdetect_HOGDescriptor_detect_11(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj);

        }


        //
        // C++:  void HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
        //

        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding, double scale, double finalThreshold, bool useMeanshiftGrouping)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (foundLocations != null)
                foundLocations.ThrowIfDisposed();
            if (foundWeights != null)
                foundWeights.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            opencvunity_objdetect_HOGDescriptor_detectMultiScale_10(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, scale, finalThreshold, useMeanshiftGrouping);

        }

        public void detectMultiScale(Mat img, MatOfRect foundLocations, MatOfDouble foundWeights)
        {
            if (img != null)
                img.ThrowIfDisposed();
            if (foundLocations != null)
                foundLocations.ThrowIfDisposed();
            if (foundWeights != null)
                foundWeights.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat foundLocations_mat = foundLocations;
            Mat foundWeights_mat = foundWeights;
            opencvunity_objdetect_HOGDescriptor_detectMultiScale_11(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj);

        }


        //
        // C++: static vector_float HOGDescriptor::getDaimlerPeopleDetector()
        //

        public static MatOfFloat getDaimlerPeopleDetector()
        {
            MatOfFloat retVal = MatOfFloat.fromNativeAddr(opencvunity_objdetect_HOGDescriptor_getDaimlerPeopleDetector_10());

            return retVal;
        }


        //
        // C++: static vector_float HOGDescriptor::getDefaultPeopleDetector()
        //

        public static MatOfFloat getDefaultPeopleDetector()
        {
            MatOfFloat retVal = MatOfFloat.fromNativeAddr(opencvunity_objdetect_HOGDescriptor_getDefaultPeopleDetector_10());

            return retVal;
        }


        //
        // C++:  size_t HOGDescriptor::getDescriptorSize()
        //

        public long getDescriptorSize()
        {
            ThrowIfDisposed();

            long retVal = opencvunity_objdetect_HOGDescriptor_getDescriptorSize_10(nativeObj);

            return retVal;
        }


        //
        // C++:  double HOGDescriptor::getWinSigma()
        //

        public double getWinSigma()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_objdetect_HOGDescriptor_getWinSigma_10(nativeObj);

            return retVal;
        }


        //
        // C++:  bool HOGDescriptor::load(String filename, String objname = String())
        //

        public bool load(string filename, string objname)
        {

            if (!File.Exists(filename))
                throw new IOException("The specified filename doesn't exist : " + filename);

            ThrowIfDisposed();

            bool retVal = opencvunity_objdetect_HOGDescriptor_load_10(nativeObj, filename, objname);

            return retVal;
        }

        public bool load(string filename)
        {
            if (!File.Exists(filename))
                throw new IOException("The specified filename doesn't exist : " + filename);

            ThrowIfDisposed();

            bool retVal = opencvunity_objdetect_HOGDescriptor_load_11(nativeObj, filename);

            return retVal;
        }


        //
        // C++:  void HOGDescriptor::save(String filename, String objname = String())
        //

        public void save(string filename, string objname)
        {
            ThrowIfDisposed();

            opencvunity_objdetect_HOGDescriptor_save_10(nativeObj, filename, objname);

        }

        public void save(string filename)
        {
            ThrowIfDisposed();

            opencvunity_objdetect_HOGDescriptor_save_11(nativeObj, filename);

        }


        //
        // C++:  void HOGDescriptor::setSVMDetector(Mat _svmdetector)
        //

        public void setSVMDetector(Mat _svmdetector)
        {
            if (_svmdetector != null)
                _svmdetector.ThrowIfDisposed();
            ThrowIfDisposed();

            opencvunity_objdetect_HOGDescriptor_setSVMDetector_10(nativeObj, _svmdetector.nativeObj);

        }


        //
        // C++: Size HOGDescriptor::winSize
        //

        public Size get_winSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            opencvunity_objdetect_HOGDescriptor_get_1winSize_10(nativeObj, tmpArray);

            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: Size HOGDescriptor::blockSize
        //

        public Size get_blockSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            opencvunity_objdetect_HOGDescriptor_get_1blockSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: Size HOGDescriptor::blockStride
        //

        public Size get_blockStride()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            opencvunity_objdetect_HOGDescriptor_get_1blockStride_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: Size HOGDescriptor::cellSize
        //

        public Size get_cellSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            opencvunity_objdetect_HOGDescriptor_get_1cellSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++: int HOGDescriptor::nbins
        //

        public int get_nbins()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_objdetect_HOGDescriptor_get_1nbins_10(nativeObj);

            return retVal;
        }


        //
        // C++: int HOGDescriptor::derivAperture
        //

        public int get_derivAperture()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_objdetect_HOGDescriptor_get_1derivAperture_10(nativeObj);

            return retVal;
        }


        //
        // C++: double HOGDescriptor::winSigma
        //

        public double get_winSigma()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_objdetect_HOGDescriptor_get_1winSigma_10(nativeObj);

            return retVal;
        }


        //
        // C++: int HOGDescriptor::histogramNormType
        //

        public int get_histogramNormType()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_objdetect_HOGDescriptor_get_1histogramNormType_10(nativeObj);

            return retVal;
        }


        //
        // C++: double HOGDescriptor::L2HysThreshold
        //

        public double get_L2HysThreshold()
        {
            ThrowIfDisposed();

            double retVal = opencvunity_objdetect_HOGDescriptor_get_1L2HysThreshold_10(nativeObj);

            return retVal;
        }


        //
        // C++: bool HOGDescriptor::gammaCorrection
        //

        public bool get_gammaCorrection()
        {
            ThrowIfDisposed();

            bool retVal = opencvunity_objdetect_HOGDescriptor_get_1gammaCorrection_10(nativeObj);

            return retVal;
        }


        //
        // C++: vector_float HOGDescriptor::svmDetector
        //

        public MatOfFloat get_svmDetector()
        {
            ThrowIfDisposed();


            MatOfFloat retVal = MatOfFloat.fromNativeAddr(opencvunity_objdetect_HOGDescriptor_get_1svmDetector_10(nativeObj));

            return retVal;
        }


        //
        // C++: int HOGDescriptor::nlevels
        //

        public int get_nlevels()
        {
            ThrowIfDisposed();

            int retVal = opencvunity_objdetect_HOGDescriptor_get_1nlevels_10(nativeObj);

            return retVal;
        }


        //	@Override
        //	protected void finalize() throws Throwable {
        //			opencvunity_objdetect_HOGDescriptor_delete(nativeObj);
        //	}



        // C++:   HOGDescriptor::HOGDescriptor()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_HOGDescriptor_10();

        // C++:   HOGDescriptor::HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_HOGDescriptor_11(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_HOGDescriptor_12(double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins);

        // C++:   HOGDescriptor::HOGDescriptor(String filename)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_HOGDescriptor_13(string filename);

        // C++:  bool HOGDescriptor::checkDetectorSize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_objdetect_HOGDescriptor_checkDetectorSize_10(IntPtr nativeObj);

        // C++:  void HOGDescriptor::compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = vector<Point>())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_compute_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr locations_mat_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_compute_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void HOGDescriptor::computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_computeGradient_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj, double paddingTL_width, double paddingTL_height, double paddingBR_width, double paddingBR_height);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_computeGradient_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj);

        // C++:  void HOGDescriptor::detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = vector<Point>())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_detect_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr searchLocations_mat_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_detect_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj);

        // C++:  void HOGDescriptor::detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_detectMultiScale_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale, double finalThreshold, bool useMeanshiftGrouping);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_detectMultiScale_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj);

        // C++: static vector_float HOGDescriptor::getDaimlerPeopleDetector()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_getDaimlerPeopleDetector_10();

        // C++: static vector_float HOGDescriptor::getDefaultPeopleDetector()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_getDefaultPeopleDetector_10();

        // C++:  size_t HOGDescriptor::getDescriptorSize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern long opencvunity_objdetect_HOGDescriptor_getDescriptorSize_10(IntPtr nativeObj);

        // C++:  double HOGDescriptor::getWinSigma()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_objdetect_HOGDescriptor_getWinSigma_10(IntPtr nativeObj);

        // C++:  bool HOGDescriptor::load(String filename, String objname = String())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_objdetect_HOGDescriptor_load_10(IntPtr nativeObj, string filename, string objname);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_objdetect_HOGDescriptor_load_11(IntPtr nativeObj, string filename);

        // C++:  void HOGDescriptor::save(String filename, String objname = String())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_save_10(IntPtr nativeObj, string filename, string objname);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_save_11(IntPtr nativeObj, string filename);

        // C++:  void HOGDescriptor::setSVMDetector(Mat _svmdetector)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_setSVMDetector_10(IntPtr nativeObj, IntPtr _svmdetector_nativeObj);

        // C++: Size HOGDescriptor::winSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_get_1winSize_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

        // C++: Size HOGDescriptor::blockSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_get_1blockSize_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

        // C++: Size HOGDescriptor::blockStride
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_get_1blockStride_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

        // C++: Size HOGDescriptor::cellSize
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_get_1cellSize_10(IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

        // C++: int HOGDescriptor::nbins
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_objdetect_HOGDescriptor_get_1nbins_10(IntPtr nativeObj);

        // C++: int HOGDescriptor::derivAperture
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_objdetect_HOGDescriptor_get_1derivAperture_10(IntPtr nativeObj);

        // C++: double HOGDescriptor::winSigma
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_objdetect_HOGDescriptor_get_1winSigma_10(IntPtr nativeObj);

        // C++: int HOGDescriptor::histogramNormType
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_objdetect_HOGDescriptor_get_1histogramNormType_10(IntPtr nativeObj);

        // C++: double HOGDescriptor::L2HysThreshold
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_objdetect_HOGDescriptor_get_1L2HysThreshold_10(IntPtr nativeObj);

        // C++: bool HOGDescriptor::gammaCorrection
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_objdetect_HOGDescriptor_get_1gammaCorrection_10(IntPtr nativeObj);

        // C++: vector_float HOGDescriptor::svmDetector
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_objdetect_HOGDescriptor_get_1svmDetector_10(IntPtr nativeObj);

        // C++: int HOGDescriptor::nlevels
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_objdetect_HOGDescriptor_get_1nlevels_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_HOGDescriptor_delete(IntPtr nativeObj);
    }}