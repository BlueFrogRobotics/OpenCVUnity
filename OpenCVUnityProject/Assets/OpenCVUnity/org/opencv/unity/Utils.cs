using UnityEngine;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

namespace OpenCVUnity
{
    public static class Utils
    {
        /// <summary>
        /// Convert the input Unity texture 2D into a OpenCVUnity Mat.
        /// </summary>
        /// <param name="texture2D">The texture to convert</param>
        /// <param name="iType">The type of the output mat</param>
        /// <returns>The Mat of the texture 2D</returns>
        public static Mat Texture2DToMat(Texture2D texture2D, int iType)
        {
            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");

            Mat mat = new Mat(texture2D.height, texture2D.width, iType);

            if (mat.cols() != texture2D.width || mat.rows() != texture2D.height)
                throw new ArgumentException("The output Texture2D object has to be of the same size");

            Color32[] colors = texture2D.GetPixels32();
            GCHandle colorsHandle = GCHandle.Alloc(colors, GCHandleType.Pinned);
            opencvunity_TextureToMat(colorsHandle.AddrOfPinnedObject(), mat.nativeObj);
            colorsHandle.Free();

            return mat;
        }

        /// <summary>
        /// Gets a Mat from a specific file (absolute path).
        /// Works with JPG and PNG.
        /// </summary>
        /// <param name="filename">The name of the file to convert</param>
        /// <param name="iType">The type of the output Mat</param>
        /// <returns>Mat of the file</returns>
        public static Mat GetMatFromFile(string filename, int iType)
        {
            return Texture2DToMat(GetTextureFromFile(filename), iType);
        }

        /// <summary>
        /// Gets a Texture 2D from a specific file (absolute path).
        /// Works with JPG and PNG
        /// </summary>
        /// <param name="filename">The name of the file to convert</param>
        /// <returns>Texture 2D of the file</returns>
        public static Texture2D GetTextureFromFile(string filename)
        {
            Mat lMat = Highgui.imread(filename);
            Texture2D lTexture = new Texture2D(lMat.cols(), lMat.rows());

            FileStream fs = File.OpenRead(filename);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
            lTexture.LoadImage(bytes);

            return lTexture;
        }

        /// <summary>
        /// Gets an array of Color32 from a OpenCVUnity Mat
        /// </summary>
        /// <param name="mat">The original mat</param>
        /// <param name="buff">The data buffer of the mat</param>
        /// <param name="data32">The output color32 array</param>
        public static void MatToColor32(Mat mat, byte[] buff, Color32[] data32)
        {
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            if (mat != null)
                mat.ThrowIfDisposed();

            mat.get(0, 0, buff);

            int k = 0;
            for (int i = 0; i < mat.total(); i++)
            {
                data32[i].b = buff[k];
                data32[i].g = buff[k + 1];
                data32[i].r = buff[k + 2];
                if (mat.channels() == 4)
                    data32[i].a = buff[k + 3];
                k += mat.channels();
            }
        }

        public static void CopyFromMat(Mat mat, IntPtr intPtr)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");

            opencvunity_MatDataToByteArray(mat.nativeObj, intPtr);
        }

        public static void CopyToMat(IntPtr intPtr, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");
            if (mat == null)
                throw new ArgumentNullException("mat == null");
            opencvunity_ByteArrayToMatData(intPtr, mat.nativeObj);
        }

        public static void CopyFromMat<T>(Mat mat, IList<T> array)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat == null");
            if (array == null)
                throw new ArgumentNullException("array == null");

            GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            opencvunity_MatDataToByteArray(mat.nativeObj, arrayHandle.AddrOfPinnedObject());
            arrayHandle.Free();
        }

        public static void CopyToMat<T>(IList<T> array, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (array == null)
                throw new ArgumentNullException("array == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            opencvunity_ByteArrayToMatData(arrayHandle.AddrOfPinnedObject(), mat.nativeObj);
            arrayHandle.Free();
        }

        public static void CopyFromTexture(Texture texture, IntPtr intPtr, int bytesPerPixel)
        {
            if (texture == null)
                throw new ArgumentNullException("texture == null");
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");
            opencvunity_TextureDataToByteArray(texture.GetNativeTexturePtr(), texture.width, texture.height, intPtr, bytesPerPixel);
        }

        public static void CopyToTexture(IntPtr intPtr, Texture texture, int bytesPerPixel)
        {

            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException("intPtr == IntPtr.Zero");
            if (texture == null)
                throw new ArgumentNullException("texture == null");

            opencvunity_ByteArrayToTextureData(intPtr, texture.GetNativeTexturePtr(), texture.width, texture.height, bytesPerPixel);
        }

        public static void CopyFromTexture<T>(Texture texture, IList<T> array, int bytesPerPixel)
        {

            if (texture == null)
                throw new ArgumentNullException("texture == null");
            if (array == null)
                throw new ArgumentNullException("array == null");

            GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            opencvunity_TextureDataToByteArray(texture.GetNativeTexturePtr(), texture.width, texture.height, arrayHandle.AddrOfPinnedObject(), bytesPerPixel);
            arrayHandle.Free();
        }

        public static void CopyToTexture<T>(IList<T> array, Texture texture, int bytesPerPixel)
        {
            if (array == null)
                throw new ArgumentNullException("array == null");
            if (texture == null)
                throw new ArgumentNullException("texture == null");

            GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
            opencvunity_ByteArrayToTextureData(arrayHandle.AddrOfPinnedObject(), texture.GetNativeTexturePtr(), texture.width, texture.height, bytesPerPixel);
            arrayHandle.Free();
        }

        /// <summary>
        /// Converts an OpenCVUnity Mat into an Unity texture 2D.
        /// </summary>
        /// <param name="mat">The mat to convert</param>
        /// <returns>The texture 2D of the mat</returns>
        public static Texture2D MatToTexture2D(Mat mat)
        {
            Texture2D texture = new Texture2D(mat.width(), mat.height());
            MatToTexture2D(mat, texture);
            return texture;
        }

        /// <summary>
        /// Converts an OpenCVUnity Mat into an array of Color32.
        /// </summary>
        /// <param name="mat">The mat to convert</param>
        /// <returns>The Color32 array of the mat</returns>
        public static Color32[] MatToColor32(Mat mat)
        {
            Texture2D texture = new Texture2D(mat.width(), mat.height());
            MatToTexture2D(mat, texture);
            return texture.GetPixels32();
        }

        /// <summary>
        /// Converts an OpenCVUnity Mat into an Unity texture 2D.
        /// </summary>
        /// <param name="mat">The mat to convert</param>
        /// <param name="texture2D">The output texture2D</param>
        /// <param name="bufferColors">The colors32 array of the texture</param>
        public static void MatToTexture2D(Mat mat, Texture2D texture2D, Color32[] bufferColors = null)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat");
            if (texture2D == null)
                throw new ArgumentNullException("texture2D");

            if (mat.cols() != texture2D.width || mat.rows() != texture2D.height)
                throw new ArgumentException("The output Texture2D object has to be of the same size");

            if (bufferColors == null)
                bufferColors = texture2D.GetPixels32();

            GCHandle colorsHandle = GCHandle.Alloc(bufferColors, GCHandleType.Pinned);
            opencvunity_MatToTexture(mat.nativeObj, colorsHandle.AddrOfPinnedObject());
            texture2D.SetPixels32(bufferColors);

            texture2D.Apply();
            colorsHandle.Free();
        }

        /// <summary>
        /// Converts an Unity Texture2D into an OpenCVUnity Mat.
        /// </summary>
        /// <param name="texture2D">The texture 2D to convert</param>
        /// <param name="mat">The output OpenCVUnity Mat</param>
        public static void Texture2DToMat(Texture2D texture2D, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (texture2D == null)
                throw new ArgumentNullException("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            if (mat.cols() != texture2D.width || mat.rows() != texture2D.height)
                throw new ArgumentException("The output Mat object has to be of the same size");

            Color32[] colors = texture2D.GetPixels32();
            GCHandle colorsHandle = GCHandle.Alloc(colors, GCHandleType.Pinned);
            opencvunity_TextureToMat(colorsHandle.AddrOfPinnedObject(), mat.nativeObj);
            colorsHandle.Free();
        }

        /// <summary>
        /// Converts an Unity WebcamTexture into an OpenCVUnity Mat.
        /// </summary>
        /// <param name="webCamTexture">The webcamtexture to convert</param>
        /// <param name="mat">The output OpenCVUnity Mat</param>
        /// <param name="bufferColors">The color32 array of the input texture2D</param>
        public static void WebCamTextureToMat(WebCamTexture webCamTexture, Mat mat, Color32[] bufferColors = null)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (webCamTexture == null)
                throw new ArgumentNullException("webCamTexture == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            if (mat.cols() != webCamTexture.width || mat.rows() != webCamTexture.height)
                throw new ArgumentException("The output Mat object has to be of the same size");

            GCHandle colorsHandle;
            if (bufferColors == null)
            {
                Color32[] colors = webCamTexture.GetPixels32();
                colorsHandle = GCHandle.Alloc(colors, GCHandleType.Pinned);
            }
            else
            {
                webCamTexture.GetPixels32(bufferColors);
                colorsHandle = GCHandle.Alloc(bufferColors, GCHandleType.Pinned);
            }

            opencvunity_TextureToMat(colorsHandle.AddrOfPinnedObject(), mat.nativeObj);
            colorsHandle.Free();
        }

        public static void MatToTexture(Mat mat, Texture texture)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (mat == null)
                throw new ArgumentNullException("mat");
            if (texture == null)
                throw new ArgumentNullException("texture2D");

            if (mat.cols() != texture.width || mat.rows() != texture.height)
                throw new ArgumentException("The output Texture object has to be of the same size");

            opencvunity_LowLevelMatToTexture(mat.nativeObj, texture.GetNativeTexturePtr(), texture.width, texture.height);
        }

        public static void TextureToMat(Texture texture, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed();

            if (texture == null)
                throw new ArgumentNullException("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException("mat == null");

            if (mat.cols() != texture.width || mat.rows() != texture.height)
                throw new ArgumentException("The output Mat object has to be of the same size");

            opencvunity_LowLevelTextureToMat(texture.GetNativeTexturePtr(), texture.width, texture.height, mat.nativeObj);
        }

        public static int GetLowLevelTextureFormat(Texture texture)
        {
            if (texture == null)
                throw new ArgumentNullException("texture == null");

            return opencvunity_GetLowLevelTextureFormat(texture.GetNativeTexturePtr());
        }

        public static string GetFilePath(string filename)
        {
            return System.IO.Path.Combine(Application.streamingAssetsPath, filename)
                .Replace("/StreamingAssets", "/_API/StreamingAssets");
        }

        /// <summary>
        /// URs the shift.
        /// </summary>
        /// <returns>The shift.</returns>
        /// <param name="number">Number.</param>
        /// <param name="bits">Bits.</param>
        internal static int URShift(int number, int bits)
        {
            if (number >= 0)
                return number >> bits;
            else
                return (number >> bits) + (2 << ~bits);
        }

        /// <summary>
        /// URs the shift.
        /// </summary>
        /// <returns>The shift.</returns>
        /// <param name="number">Number.</param>
        /// <param name="bits">Bits.</param>
        internal static long URShift(long number, int bits)
        {
            if (number >= 0)
                return number >> bits;
            else
                return (number >> bits) + (2 << ~bits);
        }

        /// <summary>
        /// Determines if hash contents the specified enumerable.
        /// </summary>
        /// <returns><c>true</c> if hash contents the specified enumerable; otherwise, <c>false</c>.</returns>
        /// <param name="enumerable">Enumerable.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        internal static int HashContents<T>(this IEnumerable<T> enumerable)
        {
            int hash = 0x218A9B2C;
            foreach (var item in enumerable)
            {
                int thisHash = item.GetHashCode();
                hash = thisHash ^ ((hash << 5) + hash);
            }
            return hash;
        }

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr opencvunity_GetFilePath(string filename);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_MatToTexture(IntPtr mat, IntPtr textureColors);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_TextureToMat(IntPtr textureColors, IntPtr Mat);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_MatDataToByteArray(IntPtr mat, IntPtr byteArray);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ByteArrayToMatData(IntPtr byteArray, IntPtr Mat);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_TextureDataToByteArray(IntPtr texPtr, int texWidth, int texHeight, IntPtr byteArray, int bytesPerPixel);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_ByteArrayToTextureData(IntPtr byteArray, IntPtr texPtr, int texWidth, int texHeight, int bytesPerPixel);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_LowLevelMatToTexture(IntPtr mat, IntPtr texPtr, int texWidth, int texHeight);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern void opencvunity_LowLevelTextureToMat(IntPtr texPtr, int texWidth, int texHeight, IntPtr mat);

        [DllImport("opencvunity", CallingConvention = CallingConvention.Cdecl)]
        private static extern int opencvunity_GetLowLevelTextureFormat(IntPtr texPtr);
    }
}
