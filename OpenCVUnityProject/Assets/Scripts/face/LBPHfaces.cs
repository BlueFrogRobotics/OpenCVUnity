using System;using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVUnity{
    public class LBPHfaces : DisposableOpenCVObject
    {
        protected override void Dispose(bool disposing)
        {
            try {
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_LBPHfaces_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose(disposing);
            }
        }

        public LBPHfaces(IntPtr addr)
        {
            nativeObj = addr;
        }

        public LBPHfaces(int radius = 1, int neighbors = 8, int gridx = 8, int gridy = 8, double threshold = double.MaxValue)
        {
            nativeObj = opencvunity_face_LBPHfaces_LBPHfaces_11(radius, neighbors, gridx, gridy, threshold);
        }

        public void train(List<Mat> data, List<int> labels)
        {
            Mat labelsMat = Converters.vector_int_to_Mat(labels);
            Mat dataMat = Converters.vector_Mat_to_Mat(data);
            opencvunity_face_LBPHfaces_train_10(nativeObj, dataMat.nativeObj, labelsMat.nativeObj);
        }

        public void update(List<Mat> data, List<int> labels)
        {
            Mat labelsMat = Converters.vector_int_to_Mat(labels);
            Mat dataMat = Converters.vector_Mat_to_Mat(data);
            opencvunity_face_LBPHfaces_update_10(nativeObj, dataMat.nativeObj, labelsMat.nativeObj);
        }

        public void predict(Mat src, PredictCollector collector, int state)
        {
            if (src != null)
                src.ThrowIfDisposed();

            opencvunity_face_LBPHfaces_predict_10(nativeObj, src.nativeObj, collector.nativeObj, state);
        }

        public void save(string filename)
        {
            opencvunity_face_LBPHfaces_save_10(nativeObj, filename);
        }

        public void load(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new ArgumentException("File doesn't exist at " + filename);
            opencvunity_face_LBPHfaces_load_10(nativeObj, filename);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_LBPHfaces_LBPHfaces_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_LBPHfaces_LBPHfaces_11(int radius_, int neighbors_, int gridx, int gridy, double threshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_LBPHfaces_train_10(IntPtr ff_native_obj, IntPtr data_native_obj, IntPtr labels_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_LBPHfaces_update_10(IntPtr ff_native_obj, IntPtr data_native_obj, IntPtr labels_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_LBPHfaces_predict_10(IntPtr ff_native_obj, IntPtr src_native_obj, IntPtr collector_native_obj, int state);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_LBPHfaces_load_10(IntPtr ff_native_obj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_LBPHfaces_save_10(IntPtr ff_native_obj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_LBPHfaces_delete_10(IntPtr ff_native_obj);
    }
}