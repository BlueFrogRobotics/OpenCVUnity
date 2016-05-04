﻿using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace OpenCVUnity
{
    public class StdPredictCollector : PredictCollector
    {
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_face_StdPredictCollector_delete_10(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public StdPredictCollector(IntPtr addr)
        {
            nativeObj = addr;
        }

        public StdPredictCollector()
        {
            nativeObj = opencvunity_face_StdPredictCollector_StdPredictCollector_10();
        }

        public StdPredictCollector(double tresh)
        {
            nativeObj = opencvunity_face_StdPredictCollector_StdPredictCollector_11(tresh);
        }

        public double getCount()
        {
            return opencvunity_face_StdPredictCollector_getCount_10(nativeObj);
        }

        public bool emit(int label, int dist, int state)
        {
            return opencvunity_face_StdPredictCollector_emit_10(nativeObj, label, dist, state);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_StdPredictCollector_StdPredictCollector_10();

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_face_StdPredictCollector_StdPredictCollector_11(double treshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  double opencvunity_face_StdPredictCollector_getCount_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_face_StdPredictCollector_delete_10(IntPtr pc_native_obj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern  bool opencvunity_face_StdPredictCollector_emit_10(IntPtr pc_native_obj, int label, int dist, int state);
    }
}