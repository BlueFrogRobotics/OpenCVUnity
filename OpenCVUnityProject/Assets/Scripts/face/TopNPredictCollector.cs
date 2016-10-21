using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace OpenCVUnity
{
    public class TopNPredictCollector : PredictCollector
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_TopNPredictCollector_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public TopNPredictCollector(IntPtr addr)
        {
            nativeObj = addr;
        }

        public TopNPredictCollector()
        {
            nativeObj = opencvunity_face_TopNPredictCollector_TopNPredictCollector_10();
        }

        public TopNPredictCollector(int n)
        {
            nativeObj = opencvunity_face_TopNPredictCollector_TopNPredictCollector_11(n);
        }

        public TopNPredictCollector(int n, double treshold)
        {
            nativeObj = opencvunity_face_TopNPredictCollector_TopNPredictCollector_12(n, treshold);
        }

        public Mat getResult()
        {
            return new Mat(opencvunity_face_TopNPredictCollector_getResult_10(nativeObj));
        }

        public bool emit(int label, int dist, int state)
        {
            return opencvunity_face_TopNPredictCollector_emit_10(nativeObj, label, dist, state);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_TopNPredictCollector_TopNPredictCollector_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_TopNPredictCollector_TopNPredictCollector_11(int n);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_TopNPredictCollector_TopNPredictCollector_12(int n, double treshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_TopNPredictCollector_getResult_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  bool opencvunity_face_TopNPredictCollector_emit_10(IntPtr pc_native_obj, int label, int dist, int state);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_TopNPredictCollector_delete_10(IntPtr pc_native_obj);
    }
}