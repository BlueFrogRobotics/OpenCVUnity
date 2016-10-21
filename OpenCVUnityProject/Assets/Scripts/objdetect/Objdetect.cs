
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVUnity{
    public class Objdetect
    {

        public const int CASCADE_DO_CANNY_PRUNING = 1;
        public const int CASCADE_SCALE_IMAGE = 2;
        public const int CASCADE_FIND_BIGGEST_OBJECT = 4;
        public const int CASCADE_DO_ROUGH_SEARCH = 8;


        //
        // C++:  void groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        //


        /// <summary>Groups the object candidate rectangles.</summary>
        ///
        /// <p>The function is a wrapper for the generic function "partition". It clusters
        /// all the input rectangles using the rectangle equivalence criteria that
        /// combines rectangles with similar sizes and similar locations. The similarity
        /// is defined by <code>eps</code>. When <code>eps=0</code>, no clustering is
        /// done at all. If <em>eps-> +inf</em>, all the rectangles are put in one
        /// cluster. Then, the small clusters containing less than or equal to
        /// <code>groupThreshold</code> rectangles are rejected. In each other cluster,
        /// the average rectangle is computed and put into the output rectangle list.</p>
        ///
        /// <param>rectList Input/output vector of rectangles. Output vector includes
        /// retained and grouped rectangles. (The Python list is not modified in place.)</param>
        /// <param>weights a weights</param>
        /// <param>groupThreshold Minimum possible number of rectangles minus 1. The
        /// threshold is used in a group of rectangles to retain it.</param>
        /// <param>eps Relative difference between sides of the rectangles to merge them
        /// into a group.</param>
        ///
        /// <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#grouprectangles">org.opencv.objdetect.Objdetect.groupRectangles</a>
        public static void groupRectangles(MatOfRect rectList, MatOfInt weights, int groupThreshold, double eps)
        {
            if (rectList != null)
                rectList.ThrowIfDisposed();
            if (weights != null)
                weights.ThrowIfDisposed();


            Mat rectList_mat = rectList;
            Mat weights_mat = weights;
            opencvunity_objdetect_Objdetect_groupRectangles_10(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold, eps);

        }


        /// <summary>Groups the object candidate rectangles.</summary>
        ///
        /// <p>The function is a wrapper for the generic function "partition". It clusters
        /// all the input rectangles using the rectangle equivalence criteria that
        /// combines rectangles with similar sizes and similar locations. The similarity
        /// is defined by <code>eps</code>. When <code>eps=0</code>, no clustering is
        /// done at all. If <em>eps-> +inf</em>, all the rectangles are put in one
        /// cluster. Then, the small clusters containing less than or equal to
        /// <code>groupThreshold</code> rectangles are rejected. In each other cluster,
        /// the average rectangle is computed and put into the output rectangle list.</p>
        ///
        /// <param>rectList Input/output vector of rectangles. Output vector includes
        /// retained and grouped rectangles. (The Python list is not modified in place.)</param>
        /// <param>weights a weights</param>
        /// <param>groupThreshold Minimum possible number of rectangles minus 1. The
        /// threshold is used in a group of rectangles to retain it.</param>
        ///
        /// <a href="http://docs.opencv.org/modules/objdetect/doc/cascade_classification.html#grouprectangles">org.opencv.objdetect.Objdetect.groupRectangles</a>
        public static void groupRectangles(MatOfRect rectList, MatOfInt weights, int groupThreshold)
        {
            if (rectList != null)
                rectList.ThrowIfDisposed();
            if (weights != null)
                weights.ThrowIfDisposed();

            Mat rectList_mat = rectList;
            Mat weights_mat = weights;
            opencvunity_objdetect_Objdetect_groupRectangles_11(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold);

        }

        public static void findQrCode(Mat iImage, List<Mat> iQrCodes, List<Point> iPoints)
        {
            if (iImage != null)
                iImage.ThrowIfDisposed();

            MatOfPoint2f pts = new MatOfPoint2f();
            Mat qrcodes = new Mat();
            opencvunity_objdetect_Objdetect_find_qrCode_10(iImage.nativeObj, qrcodes.nativeObj, pts.nativeObj);

            Converters.Mat_to_vector_Mat(qrcodes, iQrCodes);
            for (int i = 0; i < pts.rows(); ++i)
                iPoints.Add(new Point(pts.get(i, 0)[0], pts.get(i, 0)[1]));
        }

        public static void findText(Mat iImage, List<Rect> iTextAreas, int width = 17, int height = 3) {
            if (iImage != null)
                iImage.ThrowIfDisposed();

            Mat rects = new Mat();
            opencvunity_objdetect_Objdetect_find_text_10(iImage.nativeObj, rects.nativeObj, width, height);
            Converters.Mat_to_vector_Rect(rects, iTextAreas);
        }

        // C++:  void groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_Objdetect_groupRectangles_10(IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold, double eps);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_Objdetect_groupRectangles_11(IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_Objdetect_find_qrCode_10(IntPtr image_mat_nativeobj, IntPtr qrcode_mat_nativeobj, IntPtr points_nativeobj);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_objdetect_Objdetect_find_text_10(IntPtr image_mat_nativeobj, IntPtr rects_mat_nativeobj, int width, int height);
    }}