using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace OpenCVUnity
{
    public class VectorPredictCollector : PredictCollector
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_VectorPredictCollector_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public VectorPredictCollector(IntPtr addr)
        {
            nativeObj = addr;
        }

        public VectorPredictCollector()
        {
            nativeObj = opencvunity_face_VectorPredictCollector_VectorPredictCollector_10();
        }

        public VectorPredictCollector(double tresh)
        {
            nativeObj = opencvunity_face_VectorPredictCollector_VectorPredictCollector_11(tresh);
        }

        public Mat getResult()
        {
            return new Mat(opencvunity_face_VectorPredictCollector_getResult_10(nativeObj));
        }

        public bool emit(int label, int dist, int state)
        {
            return opencvunity_face_VectorPredictCollector_emit_10(nativeObj, label, dist, state);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_VectorPredictCollector_VectorPredictCollector_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_VectorPredictCollector_VectorPredictCollector_11(double treshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_VectorPredictCollector_getResult_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_face_VectorPredictCollector_emit_10(IntPtr pc_native_obj, int label, int dist, int state);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_VectorPredictCollector_delete_10(IntPtr pc_native_obj);
    }
}