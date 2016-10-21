
//
// This file is auto-generated. Please don't modify it!
//
using System;using System.Runtime.InteropServices;using System.Collections.Generic;namespace OpenCVUnity{
    public class Photo
    {

        private const int CV_INPAINT_NS = 0;
        private const int CV_INPAINT_TELEA = 1;
        public const int INPAINT_NS = CV_INPAINT_NS;
        public const int INPAINT_TELEA = CV_INPAINT_TELEA;


        //
        // C++:  void fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        
	/// <summary>Perform image denoising using Non-local Means Denoising algorithm
	/// http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/ with several
	/// computational optimizations. Noise expected to be a gaussian white noise</summary>
	///
	/// <p>This function expected to be applied to grayscale images. For colored images
	/// look at <code>fastNlMeansDenoisingColored</code>.
	/// Advanced usage of this functions can be manual denoising of colored image in
	/// different colorspaces.
	/// Such approach is used in <code>fastNlMeansDenoisingColored</code> by
	/// converting image to CIELAB colorspace and then separately denoise L and AB
	/// components with different h parameter.</p>
	///
	/// <param>src Input 8-bit 1-channel, 2-channel or 3-channel image.</param>
	/// <param>dst Output image with the same size and type as <code>src</code>.</param>
	/// <param>h Parameter regulating filter strength. Big h value perfectly removes
	/// noise but also removes image details, smaller h value preserves details but
	/// also preserves some noise</param>
	/// <param>templateWindowSize Size in pixels of the template patch that is used
	/// to compute weights. Should be odd. Recommended value 7 pixels</param>
	/// <param>searchWindowSize Size in pixels of the window that is used to compute
	/// weighted average for given pixel. Should be odd. Affect performance linearly:
	/// greater searchWindowsSize - greater denoising time. Recommended value 21
	/// pixels</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoising">org.opencv.photo.Photo.fastNlMeansDenoising</a>
	public static void fastNlMeansDenoising(Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();

            opencvunity_photo_Photo_fastNlMeansDenoising_10(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize);

        }

        
	/// <summary>Perform image denoising using Non-local Means Denoising algorithm
	/// http://www.ipol.im/pub/algo/bcm_non_local_means_denoising/ with several
	/// computational optimizations. Noise expected to be a gaussian white noise</summary>
	///
	/// <p>This function expected to be applied to grayscale images. For colored images
	/// look at <code>fastNlMeansDenoisingColored</code>.
	/// Advanced usage of this functions can be manual denoising of colored image in
	/// different colorspaces.
	/// Such approach is used in <code>fastNlMeansDenoisingColored</code> by
	/// converting image to CIELAB colorspace and then separately denoise L and AB
	/// components with different h parameter.</p>
	///
	/// <param>src Input 8-bit 1-channel, 2-channel or 3-channel image.</param>
	/// <param>dst Output image with the same size and type as <code>src</code>.</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoising">org.opencv.photo.Photo.fastNlMeansDenoising</a>
	public static void fastNlMeansDenoising(Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();

            opencvunity_photo_Photo_fastNlMeansDenoising_11(src.nativeObj, dst.nativeObj);

        }


        //
        // C++:  void fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        
	/// <summary>Modification of <code>fastNlMeansDenoising</code> function for colored images</summary>
	///
	/// <p>The function converts image to CIELAB colorspace and then separately denoise
	/// L and AB components with given h parameters using <code>fastNlMeansDenoising</code>
	/// function.</p>
	///
	/// <param>src Input 8-bit 3-channel image.</param>
	/// <param>dst Output image with the same size and type as <code>src</code>.</param>
	/// <param>h Parameter regulating filter strength for luminance component. Bigger
	/// h value perfectly removes noise but also removes image details, smaller h
	/// value preserves details but also preserves some noise</param>
	/// <param>hColor a hColor</param>
	/// <param>templateWindowSize Size in pixels of the template patch that is used
	/// to compute weights. Should be odd. Recommended value 7 pixels</param>
	/// <param>searchWindowSize Size in pixels of the window that is used to compute
	/// weighted average for given pixel. Should be odd. Affect performance linearly:
	/// greater searchWindowsSize - greater denoising time. Recommended value 21
	/// pixels</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoisingcolored">org.opencv.photo.Photo.fastNlMeansDenoisingColored</a>
	public static void fastNlMeansDenoisingColored(Mat src, Mat dst, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();

            opencvunity_photo_Photo_fastNlMeansDenoisingColored_10(src.nativeObj, dst.nativeObj, h, hColor, templateWindowSize, searchWindowSize);

        }

        
	/// <summary>Modification of <code>fastNlMeansDenoising</code> function for colored images</summary>
	///
	/// <p>The function converts image to CIELAB colorspace and then separately denoise
	/// L and AB components with given h parameters using <code>fastNlMeansDenoising</code>
	/// function.</p>
	///
	/// <param>src Input 8-bit 3-channel image.</param>
	/// <param>dst Output image with the same size and type as <code>src</code>.</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoisingcolored">org.opencv.photo.Photo.fastNlMeansDenoisingColored</a>
	public static void fastNlMeansDenoisingColored(Mat src, Mat dst)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();

            opencvunity_photo_Photo_fastNlMeansDenoisingColored_11(src.nativeObj, dst.nativeObj);

        }


        //
        // C++:  void fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        
	/// <summary>Modification of <code>fastNlMeansDenoisingMulti</code> function for colored
	/// images sequences</p>
	///
	/// <p>The function converts images to CIELAB colorspace and then separately denoise
	/// L and AB components with given h parameters using <code>fastNlMeansDenoisingMulti</code>
	/// function.</p>
	///
	/// <param>srcImgs Input 8-bit 3-channel images sequence. All images should have</param>
	/// the same type and size.
	/// <param>dst Output image with the same size and type as <code>srcImgs</code></param>
	/// images.
	/// <param>imgToDenoiseIndex Target image to denoise index in <code>srcImgs</code></param>
	/// sequence
	/// <param>temporalWindowSize Number of surrounding images to use for target</param>
	/// image denoising. Should be odd. Images from <code>imgToDenoiseIndex -
	/// temporalWindowSize / 2</code> to <code>imgToDenoiseIndex - temporalWindowSize
	/// / 2</code> from <code>srcImgs</code> will be used to denoise
	/// <code>srcImgs[imgToDenoiseIndex]</code> image.
	/// <param>h Parameter regulating filter strength for luminance component. Bigger</param>
	/// h value perfectly removes noise but also removes image details, smaller h
	/// value preserves details but also preserves some noise.
	/// <param>hColor a hColor</param>
	/// <param>templateWindowSize Size in pixels of the template patch that is used</param>
	/// to compute weights. Should be odd. Recommended value 7 pixels
	/// <param>searchWindowSize Size in pixels of the window that is used to compute</param>
	/// weighted average for given pixel. Should be odd. Affect performance linearly:
	/// greater searchWindowsSize - greater denoising time. Recommended value 21
	/// pixels
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoisingcoloredmulti">org.opencv.photo.Photo.fastNlMeansDenoisingColoredMulti</a>
	public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null)
                dst.ThrowIfDisposed();

            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            opencvunity_photo_Photo_fastNlMeansDenoisingColoredMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize, searchWindowSize);

        }

        
	/// <summary>Modification of <code>fastNlMeansDenoisingMulti</code> function for colored
	/// images sequences</summary>
	///
	/// <p>The function converts images to CIELAB colorspace and then separately denoise
	/// L and AB components with given h parameters using <code>fastNlMeansDenoisingMulti</code>
	/// function.</p>
	///
	/// <param>srcImgs Input 8-bit 3-channel images sequence. All images should have
	/// the same type and size.</param>
	/// <param>dst Output image with the same size and type as <code>srcImgs</code>
	/// images.</param>
	/// <param>imgToDenoiseIndex Target image to denoise index in <code>srcImgs</code>
	/// sequence</param>
	/// <param>temporalWindowSize Number of surrounding images to use for target
	/// image denoising. Should be odd. Images from <code>imgToDenoiseIndex -
	/// temporalWindowSize / 2</code> to <code>imgToDenoiseIndex - temporalWindowSize
	/// / 2</code> from <code>srcImgs</code> will be used to denoise
	/// <code>srcImgs[imgToDenoiseIndex]</code> image.</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoisingcoloredmulti">org.opencv.photo.Photo.fastNlMeansDenoisingColoredMulti</a>
	public static void fastNlMeansDenoisingColoredMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null)
                dst.ThrowIfDisposed();

            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            opencvunity_photo_Photo_fastNlMeansDenoisingColoredMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);

        }


        //
        // C++:  void fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        
	/// <summary>Modification of <code>fastNlMeansDenoising</code> function for images
	/// sequence where consequtive images have been captured in small period of time.
	/// For example video. This version of the function is for grayscale images or
	/// for manual manipulation with colorspaces.
	/// For more details see http://citeseerx.ist.psu.edu/viewdoc/summary?doi=10.1.1.131.6394</summary>
	///
	/// <param>srcImgs Input 8-bit 1-channel, 2-channel or 3-channel images sequence.
	/// All images should have the same type and size.</param>
	/// <param>dst Output image with the same size and type as <code>srcImgs</code>
	/// images.</param>
	/// <param>imgToDenoiseIndex Target image to denoise index in <code>srcImgs</code>
	/// sequence</param>
	/// <param>temporalWindowSize Number of surrounding images to use for target
	/// image denoising. Should be odd. Images from <code>imgToDenoiseIndex -
	/// temporalWindowSize / 2</code> to <code>imgToDenoiseIndex - temporalWindowSize
	/// / 2</code> from <code>srcImgs</code> will be used to denoise
	/// <code>srcImgs[imgToDenoiseIndex]</code> image.</param>
	/// <param>h Parameter regulating filter strength for luminance component. Bigger
	/// h value perfectly removes noise but also removes image details, smaller h
	/// value preserves details but also preserves some noise</param>
	/// <param>templateWindowSize Size in pixels of the template patch that is used
	/// to compute weights. Should be odd. Recommended value 7 pixels</param>
	/// <param>searchWindowSize Size in pixels of the window that is used to compute
	/// weighted average for given pixel. Should be odd. Affect performance linearly:
	/// greater searchWindowsSize - greater denoising time. Recommended value 21
	/// pixels</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoisingmulti">org.opencv.photo.Photo.fastNlMeansDenoisingMulti</a>
	public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null)
                dst.ThrowIfDisposed();

            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            opencvunity_photo_Photo_fastNlMeansDenoisingMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize);

        }

        
	/// <summary>Modification of <code>fastNlMeansDenoising</code> function for images
	/// sequence where consequtive images have been captured in small period of time.
	/// For example video. This version of the function is for grayscale images or
	/// for manual manipulation with colorspaces.
	/// For more details see http://citeseerx.ist.psu.edu/viewdoc/summary?doi=10.1.1.131.6394</summary>
	///
	/// <param>srcImgs Input 8-bit 1-channel, 2-channel or 3-channel images sequence.
	/// All images should have the same type and size.</param>
	/// <param>dst Output image with the same size and type as <code>srcImgs</code>
	/// images.</param>
	/// <param>imgToDenoiseIndex Target image to denoise index in <code>srcImgs</code>
	/// sequence</param>
	/// <param>temporalWindowSize Number of surrounding images to use for target
	/// image denoising. Should be odd. Images from <code>imgToDenoiseIndex -
	/// temporalWindowSize / 2</code> to <code>imgToDenoiseIndex - temporalWindowSize
	/// / 2</code> from <code>srcImgs</code> will be used to denoise
	/// <code>srcImgs[imgToDenoiseIndex]</code> image.</param>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/denoising.html#fastnlmeansdenoisingmulti">org.opencv.photo.Photo.fastNlMeansDenoisingMulti</a>
	public static void fastNlMeansDenoisingMulti(List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null)
                dst.ThrowIfDisposed();

            Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
            opencvunity_photo_Photo_fastNlMeansDenoisingMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);

        }


        //
        // C++:  void inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        //

        
	/// <summary>Restores the selected region in an image using the region neighborhood.</summary>
	///
	/// <p>The function reconstructs the selected image area from the pixel near the
	/// area boundary. The function may be used to remove dust and scratches from a
	/// scanned photo, or to remove undesirable objects from still images or video.
	/// See http://en.wikipedia.org/wiki/Inpainting for more details.</p>
	///
	/// <p>Note:</p>
	/// <ul>
	///   <li> An example using the inpainting technique can be found at
	/// opencv_source_code/samples/cpp/inpaint.cpp
	///   <li> (Python) An example using the inpainting technique can be found at
	/// opencv_source_code/samples/python2/inpaint.py
	/// </ul>
	///
	/// <param>src Input 8-bit 1-channel or 3-channel image.</param>
	/// <param>inpaintMask Inpainting mask, 8-bit 1-channel image. Non-zero pixels</param>
	/// indicate the area that needs to be inpainted.
	/// <param>dst Output image with the same size and type as <code>src</code>.</param>
	/// <param>inpaintRadius Radius of a circular neighborhood of each point</param>
	/// inpainted that is considered by the algorithm.
	/// <param>flags Inpainting method that could be one of the following:</param>
	/// <ul>
	///   <li> INPAINT_NS Navier-Stokes based method.
	///   <li> INPAINT_TELEA Method by Alexandru Telea [Telea04].
	/// </ul>
	///
	/// <a href="http://docs.opencv.org/modules/photo/doc/inpainting.html#inpaint">org.opencv.photo.Photo.inpaint</a>
	public static void inpaint(Mat src, Mat inpaintMask, Mat dst, double inpaintRadius, int flags)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (inpaintMask != null)
                inpaintMask.ThrowIfDisposed();
            if (dst != null)
                dst.ThrowIfDisposed();

            opencvunity_photo_Photo_inpaint_10(src.nativeObj, inpaintMask.nativeObj, dst.nativeObj, inpaintRadius, flags);

        }



        // C++:  void fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoising_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoising_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoisingColored_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor, int templateWindowSize, int searchWindowSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoisingColored_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoisingColoredMulti_10(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoisingColoredMulti_11(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoisingMulti_10(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_fastNlMeansDenoisingMulti_11(IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_photo_Photo_inpaint_10(IntPtr src_nativeObj, IntPtr inpaintMask_nativeObj, IntPtr dst_nativeObj, double inpaintRadius, int flags);

    }}