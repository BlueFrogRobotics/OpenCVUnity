using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Text;

namespace OpenCVUnity
{
    public class OCRTesseract : DisposableOpenCVObject
    {
        public const int OEM_TESSERACT_ONLY = 0;           // Run Tesseract only - fastest
        public const int OEM_CUBE_ONLY = 1;                // Run Cube only - better accuracy, but slower
        public const int OEM_TESSERACT_CUBE_COMBINED = 2;  // Run both and combine results - best accuracy
        public const int OEM_DEFAULT = 3;

        //public const int PSM_OSD_ONLY = 0;       // Orientation and script detection only. CRASH
        public const int PSM_AUTO_OSD = 1;       // Automatic page segmentation with orientation and script detection. (OSD)
        public const int PSM_AUTO_ONLY = 2;      // Automatic page segmentation, but no OSD, or OCR.
        public const int PSM_AUTO = 3;           // Fully automatic page segmentation, but no OSD.
        //public const int PSM_SINGLE_COLUMN = 4;  // Assume a single column of text of variable sizes. CRASH
        public const int PSM_SINGLE_BLOCK_VERT_TEXT = 5;  // Assume a single uniform block of vertically aligned text.
        public const int PSM_SINGLE_BLOCK = 6;   // Assume a single uniform block of text. (Default.)
        public const int PSM_SINGLE_LINE = 7;    // Treat the image as a single text line.
        public const int PSM_SINGLE_WORD = 8;    // Treat the image as a single word.
        public const int PSM_CIRCLE_WORD = 9;    // Treat the image as a single word in a circle.
        public const int PSM_SINGLE_CHAR = 10;    // Treat the image as a single character.
        public const int PSM_SPARSE_TEXT = 11;    // Find as much text as possible in no particular order.
        public const int PSM_SPARSE_TEXT_OSD = 12;  // Sparse text with orientation and script det.
        public const int PSM_RAW_LINE = 13;       // Treat the image as a single text line, bypassing hacks that are Tesseract-specific.

        protected override void Dispose(bool disposing)
        {
            try {
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        opencvunity_text_OCRTesseract_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            } finally {
                base.Dispose(disposing);
            }
        }

        protected OCRTesseract(IntPtr addr)
        {
            nativeObj = addr;
        }

        public OCRTesseract(string datapath)
        {
            if (!Directory.Exists(datapath + "tessdata"))
                throw new ArgumentException("Tesseract : cannot find tessdata folder at : " + datapath);

            nativeObj = opencvunity_text_OCRTesseract_OCRTesseract_11(datapath);
        }

        public OCRTesseract(string datapath, string lang)
        {
            if (!Directory.Exists(datapath + "tessdata"))
                throw new ArgumentException("Tesseract : cannot find tessdata folder at : " + datapath);

            nativeObj = opencvunity_text_OCRTesseract_OCRTesseract_12(datapath, lang);
        }

        public OCRTesseract(string datapath, string lang, string whitelist)
        {
            if (!Directory.Exists(datapath + "tessdata"))
                throw new ArgumentException("Tesseract : cannot find tessdata folder at : " + datapath);

            nativeObj = opencvunity_text_OCRTesseract_OCRTesseract_13(datapath, lang, whitelist);
        }

        public OCRTesseract(string datapath, string lang, string whitelist, int oem, int psmode = 3)
        {
            if (!Directory.Exists(datapath + "tessdata"))
                throw new ArgumentException("Tesseract : cannot find tessdata folder at : " + datapath);

            nativeObj = opencvunity_text_OCRTesseract_OCRTesseract_14(datapath, lang, whitelist, oem, psmode);
        }

        public string run(Mat image)
        {
            if (image != null)
                image.ThrowIfDisposed();

            StringBuilder sbRsltURL = new StringBuilder(1024);
            opencvunity_text_OCRTesseract_run_10(nativeObj, image.nativeObj, sbRsltURL);
            return sbRsltURL.ToString();
        }

        public string run(Mat image, MatOfRect rects)
        {
            if (image != null)
                image.ThrowIfDisposed();

            Mat rectmat = rects;
            StringBuilder sbRsltURL = new StringBuilder(1024);
            opencvunity_text_OCRTesseract_run_11(nativeObj, image.nativeObj, rectmat.nativeObj, sbRsltURL);
            return sbRsltURL.ToString();
        }

        public void setWhiteList(string whitelist)
        {
            opencvunity_text_OCRTesseract_setWhiteList_10(nativeObj, whitelist);
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_text_OCRTesseract_OCRTesseract_11(string datapath);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_text_OCRTesseract_OCRTesseract_12(string datapath, string lang);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_text_OCRTesseract_OCRTesseract_13(string datapath, string lang, string whitelist);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_text_OCRTesseract_OCRTesseract_14(string datapath, string lang, string whitelist, int oem, int psmode);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_text_OCRTesseract_run_10(IntPtr ocr_native_obj, IntPtr image, StringBuilder text);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_text_OCRTesseract_run_11(IntPtr ocr_native_obj, IntPtr image, IntPtr rects, StringBuilder text);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_text_OCRTesseract_setWhiteList_10(IntPtr ocr_native_obj, string char_whitelist);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_text_OCRTesseract_delete(IntPtr ocr_native_obj);
    }
}