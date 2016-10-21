
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;namespace OpenCVUnity{
    // C++: class KalmanFilter

    /// <summary>Kalman filter class.</summary>
    ///
    /// <p>The class implements a standard Kalman filter http://en.wikipedia.org/wiki/Kalman_filter,
    /// [Welch95]. However, you can modify <code>transitionMatrix</code>,
    /// <code>controlMatrix</code>, and <code>measurementMatrix</code> to get an
    /// extended Kalman filter functionality. See the OpenCV sample <code>kalman.cpp</code>.</p>
    ///
    /// <p>Note:</p>
    /// <ul>
    ///   <li> An example using the standard Kalman filter can be found at
    /// opencv_source_code/samples/cpp/kalman.cpp
    /// </ul>
    ///
    /// <a href="http://docs.opencv.org/modules/video/doc/motion_analysis_and_object_tracking.html#kalmanfilter">org.opencv.video.KalmanFilter</a>
    public class KalmanFilter : DisposableOpenCVObject
    {
        protected override void Dispose(bool disposing)
        {

            try {

                if (disposing) {
                }

                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_video_KalmanFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }

        }

        //	protected readonly IntPtr nativeObj;
        protected KalmanFilter(IntPtr addr)
        {
            nativeObj = addr;
        }


        //
        // C++:   KalmanFilter::KalmanFilter()
        //

        public KalmanFilter()
        {
            nativeObj = opencvunity_video_KalmanFilter_KalmanFilter_10();

        }


        //
        // C++:   KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
        //

        public KalmanFilter(int dynamParams, int measureParams, int controlParams, int type)
        {
            nativeObj = opencvunity_video_KalmanFilter_KalmanFilter_11(dynamParams, measureParams, controlParams, type);

        }

        public KalmanFilter(int dynamParams, int measureParams)
        {
            nativeObj = opencvunity_video_KalmanFilter_KalmanFilter_12(dynamParams, measureParams);

        }


        //
        // C++:  Mat KalmanFilter::correct(Mat measurement)
        //

        public Mat correct(Mat measurement)
        {
            if (measurement != null)
                measurement.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat retVal = new Mat(opencvunity_video_KalmanFilter_correct_10(nativeObj, measurement.nativeObj));

            return retVal;
        }


        //
        // C++:  Mat KalmanFilter::predict(Mat control = Mat())
        //

        public Mat predict(Mat control)
        {
            if (control != null)
                control.ThrowIfDisposed();
            ThrowIfDisposed();

            Mat retVal = new Mat(opencvunity_video_KalmanFilter_predict_10(nativeObj, control.nativeObj));

            return retVal;
        }

        public Mat predict()
        {
            ThrowIfDisposed();

            Mat retVal = new Mat(opencvunity_video_KalmanFilter_predict_11(nativeObj));

            return retVal;
        }

        public Mat getStatePre()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1statePre_10(nativeObj));
        }

        public void setStatePre(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1statePre_10(nativeObj, val.nativeObj);
        }

        public Mat getStatePost()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1statePost_10(nativeObj));
        }

        public void setStatePost(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1statePost_10(nativeObj, val.nativeObj);
        }

        public Mat getTransitionMatrix()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1transitionMatrix_10(nativeObj));
        }

        public void setTransitionMatrix(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1transitionMatrix_10(nativeObj, val.nativeObj);
        }

        public Mat getControlMatrix()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1controlMatrix_10(nativeObj));
        }

        public void setControlMatrix(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1controlMatrix_10(nativeObj, val.nativeObj);
        }

        public Mat getMeasurementMatrix()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1measurementMatrix_10(nativeObj));
        }

        public void setMeasurementMatrix(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1measurementMatrix_10(nativeObj, val.nativeObj);
        }

        public Mat getProcessNoiseCov()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1processNoiseCov_10(nativeObj));
        }

        public void setProcessNoiseCov(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1processNoiseCov_10(nativeObj, val.nativeObj);
        }

        public Mat getMeasurementNoiseCov()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1measurementNoiseCov_10(nativeObj));
        }

        public void setMeasurementNoiseCov(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1measurementNoiseCov_10(nativeObj, val.nativeObj);
        }

        public Mat getErrorCovPre()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1errorCovPre_10(nativeObj));
        }

        public void setErrorCovPre(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1errorCovPre_10(nativeObj, val.nativeObj);
        }

        public Mat getGain()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1gain_10(nativeObj));
        }

        public void setGain(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1gain_10(nativeObj, val.nativeObj);
        }

        public Mat getErrorCovPost()
        {
            return new Mat(opencvunity_video_KalmanFilter_get_1errorCovPost_10(nativeObj));
        }

        public void setErrorCovPost(Mat val)
        {
            opencvunity_video_KalmanFilter_set_1errorCovPost_10(nativeObj, val.nativeObj);
        }

        // C++:   KalmanFilter::KalmanFilter()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_KalmanFilter_10();

        // C++:   KalmanFilter::KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_KalmanFilter_11(int dynamParams, int measureParams, int controlParams, int type);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_KalmanFilter_12(int dynamParams, int measureParams);

        // C++:  Mat KalmanFilter::correct(Mat measurement)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_correct_10(IntPtr nativeObj, IntPtr measurement_nativeObj);

        // C++:  Mat KalmanFilter::predict(Mat control = Mat())
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_predict_10(IntPtr nativeObj, IntPtr control_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_predict_11(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_delete(IntPtr nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1statePre_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1statePre_10(IntPtr self, IntPtr statePre_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1statePost_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1statePost_10(IntPtr self, IntPtr statePost_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1transitionMatrix_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1transitionMatrix_10(IntPtr self, IntPtr transitionMatrix_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1controlMatrix_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1controlMatrix_10(IntPtr self, IntPtr controlMatrix_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1measurementMatrix_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1measurementMatrix_10(IntPtr self, IntPtr measurementMatrix_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1processNoiseCov_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1processNoiseCov_10(IntPtr self, IntPtr processNoiseCov_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1measurementNoiseCov_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1measurementNoiseCov_10(IntPtr self, IntPtr measurementNoiseCov_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1errorCovPre_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1errorCovPre_10(IntPtr self, IntPtr errorCovPre_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1gain_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1gain_10(IntPtr self, IntPtr gain_nativeObj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_video_KalmanFilter_get_1errorCovPost_10(IntPtr self);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_video_KalmanFilter_set_1errorCovPost_10(IntPtr self, IntPtr errorCovPost_nativeObj);
    }}