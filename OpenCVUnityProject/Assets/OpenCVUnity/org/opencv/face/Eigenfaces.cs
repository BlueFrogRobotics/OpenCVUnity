﻿using System;
using System.Collections.Generic;

namespace OpenCVUnity
    public class Eigenfaces : DisposableOpenCVObject
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_Eigenfaces_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public Eigenfaces(IntPtr addr)
        {
            nativeObj = addr;
        }

        public Eigenfaces()
        {
            nativeObj = opencvunity_face_Eigenfaces_Eigenfaces_10();
        }

        public Eigenfaces(int nbcomponents)
        {
            nativeObj = opencvunity_face_Eigenfaces_Eigenfaces_11(nbcomponents);
        }

        public Eigenfaces(int nbcomponents, double treshold)
        {
            nativeObj = opencvunity_face_Eigenfaces_Eigenfaces_12(nbcomponents, treshold);
        }

        public void train(List<Mat> data, List<int> labels)
        {
            Mat labelsMat = Converters.vector_int_to_Mat(labels);
            Mat dataMat = Converters.vector_Mat_to_Mat(data);
            opencvunity_face_Eigenfaces_train_10(nativeObj, dataMat.nativeObj, labelsMat.nativeObj);
        }

        public void predict(Mat src, PredictCollector collector, int state)
        {
            if (src!= null)
                src.ThrowIfDisposed();

            opencvunity_face_Eigenfaces_predict_10(nativeObj, src.nativeObj, collector.nativeObj, state);
        }

        public Mat getEigenValues()
        {
            return new Mat(opencvunity_face_Eigenfaces_getEigenValues_10(nativeObj));
        }

        public Mat getEigenVector()
        {
            return new Mat(opencvunity_face_Eigenfaces_getEigenVector_10(nativeObj));
        }

        public Mat getLabels()
        {
            return new Mat(opencvunity_face_Eigenfaces_getLabels_10(nativeObj));
        }

        public Mat getLabelsByString(string name)
        {
            return new Mat(opencvunity_face_Eigenfaces_getLabelsByString_10(nativeObj, name));
        }

        public void clear()
        {
            opencvunity_face_Eigenfaces_clear_10(nativeObj);
        }

        public Mat getMean()
        {
            return new Mat(opencvunity_face_Eigenfaces_getMean_10(nativeObj));
        }

        public void setTreshold(double val)
        {
            opencvunity_face_Eigenfaces_setTreshold_10(nativeObj, val);
        }

        public double getTreshold()
        {
            return opencvunity_face_Eigenfaces_getTreshold_10(nativeObj);
        }

        public void setNumComponents(int val)
        {
            opencvunity_face_Eigenfaces_setNumComponents_10(nativeObj, val);
        }

        public int getNumComponents()
        {
            return opencvunity_face_Eigenfaces_getNumComponents_10(nativeObj);
        }

        public bool empty()
        {
            return opencvunity_face_Eigenfaces_empty_10(nativeObj);
        }

        public string getLabelInfo(int index)
        {
            return opencvunity_face_Eigenfaces_getLabelInfo_10(nativeObj, index);
        }

        public List<Mat> getProjections()
        {
            List<Mat> projections = new List<Mat>();
            Mat projMat = new Mat(opencvunity_face_Eigenfaces_getProjections_10(nativeObj));
            Converters.Mat_to_vector_Mat(projMat, projections);
            return projections;
        }

        public void save(string filename)
        {
            opencvunity_face_Eigenfaces_save_10(nativeObj, filename);
        }

        public void load(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new ArgumentException("File doesn't exist at " + filename);
            opencvunity_face_Eigenfaces_load_10(nativeObj, filename);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_Eigenfaces_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_Eigenfaces_11(int nbcomponents);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_Eigenfaces_12(int nbcomponents, double treshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_train_10(IntPtr egf_native_obj, IntPtr data_native_obj, IntPtr labels_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_predict_10(IntPtr egf_native_obj, IntPtr src_native_obj, IntPtr collector_native_obj, int state);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_getEigenValues_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_getEigenVector_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_getLabels_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_getLabelsByString_10(IntPtr egf_native_obj, string name);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_clear_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_getMean_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_setTreshold_10(IntPtr egf_native_obj, double val);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_face_Eigenfaces_getTreshold_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_face_Eigenfaces_empty_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_Eigenfaces_getProjections_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern string opencvunity_face_Eigenfaces_getLabelInfo_10(IntPtr egf_native_obj, int label);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_face_Eigenfaces_getNumComponents_10(IntPtr egf_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_setNumComponents_10(IntPtr egf_native_obj, int nbcomponent);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_load_10(IntPtr egf_native_obj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_Eigenfaces_save_10(IntPtr egf_native_obj, string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_face_Eigenfaces_delete_10(IntPtr egf_native_obj);
    }
}