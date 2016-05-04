using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace OpenCVUnity
{
    public class MinDistancePredictCollector : PredictCollector
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_MinDistancePredictCollector_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public MinDistancePredictCollector(IntPtr addr)
        {
            nativeObj = addr;
        }

        public MinDistancePredictCollector()
        {
            nativeObj = opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_10();
        }

        public MinDistancePredictCollector(double tresh)
        {
            nativeObj = opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_11(tresh);
        }

        public int getLabel()
        {
            return opencvunity_face_MinDistancePredictCollector_getLabel_10(nativeObj);
        }

        public double getDist()
        {
            return opencvunity_face_MinDistancePredictCollector_getDist_10(nativeObj);
        }

        public bool emit(int label, int dist, int state)
        {
            return opencvunity_face_MinDistancePredictCollector_emit_10(nativeObj, label, dist, state);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_11(double treshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern double opencvunity_face_MinDistancePredictCollector_getDist_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_face_MinDistancePredictCollector_getLabel_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool opencvunity_face_MinDistancePredictCollector_emit_10(IntPtr pc_native_obj, int label, int dist, int state);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_MinDistancePredictCollector_delete_10(IntPtr pc_native_obj);
    }
}