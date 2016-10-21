using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace OpenCVUnity
{
    public class StatPredictCollector : PredictCollector
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_StatPredictCollector_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public StatPredictCollector(IntPtr addr)
        {
            nativeObj = addr;
        }

        public StatPredictCollector()
        {
            nativeObj = opencvunity_face_StatPredictCollector_StatPredictCollector_10();
        }

        public StatPredictCollector(double tresh)
        {
            nativeObj = opencvunity_face_StatPredictCollector_StatPredictCollector_11(tresh);
        }

        public double getMin()
        {
            return opencvunity_face_StatPredictCollector_getMin_10(nativeObj);
        }

        public double getMax()
        {
            return opencvunity_face_StatPredictCollector_getMax_10(nativeObj);
        }

        public double getSum()
        {
            return opencvunity_face_StatPredictCollector_getSum_10(nativeObj);
        }

        public int getCount()
        {
            return opencvunity_face_StatPredictCollector_getCount_10(nativeObj);
        }

        public bool emit(int label, int dist, int state)
        {
            return opencvunity_face_StatPredictCollector_emit_10(nativeObj, label, dist, state);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_StatPredictCollector_StatPredictCollector_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_StatPredictCollector_StatPredictCollector_11(double treshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  double opencvunity_face_StatPredictCollector_getMin_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  double opencvunity_face_StatPredictCollector_getMax_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  double opencvunity_face_StatPredictCollector_getSum_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  int opencvunity_face_StatPredictCollector_getCount_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  bool opencvunity_face_StatPredictCollector_emit_10(IntPtr pc_native_obj, int label, int dist, int state);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_StatPredictCollector_delete_10(IntPtr pc_native_obj);
    }
}