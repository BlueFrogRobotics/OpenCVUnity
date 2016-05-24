#include "opencv2\contrib\converters.hpp"

#if SUPPORT_D3D9
#	include <d3d9.h>
#	include "opencv2\core\IUnityGraphicsD3D9.h"
#endif
#if SUPPORT_D3D11
#	include <d3d11.h>
#	include "opencv2\core\IUnityGraphicsD3D11.h"
#endif

#if SUPPORT_OPENGLES
#	if UNITY_IPHONE
#		include <OpenGLES/ES2/gl.h>
#	elif UNITY_ANDROID
#		include <GLES2/gl2.h>
#	endif
#elif SUPPORT_OPENGL
#	if UNITY_WIN || UNITY_LINUX
#		include <GL/gl.h>
#	else
#		include <OpenGL/gl.h>
#	endif
#endif

namespace cv {

#define CHECK_MAT(cond) if(!(cond)){return; }

	// vector_int

	//void Mat_to_vector_int(Mat& mat, std::vector<int>& v_int)
	//{
	//	v_int.clear();
	//	CHECK_MAT(mat.type() == CV_32SC1 && mat.cols == 1);
	//	v_int = (std::vector<int>) mat;
	//}

	//void vector_int_to_Mat(std::vector<int>& v_int, Mat& mat)
	//{
	//	mat = Mat(v_int, true);
	//}

	////vector_double

	//void Mat_to_vector_double(Mat& mat, std::vector<double>& v_double)
	//{
	//	v_double.clear();
	//	CHECK_MAT(mat.type() == CV_64FC1 && mat.cols == 1);
	//	v_double = (std::vector<double>) mat;
	//}

	//void vector_double_to_Mat(std::vector<double>& v_double, Mat& mat)
	//{
	//	mat = Mat(v_double, true);
	//}

	//// vector_float

	//void Mat_to_vector_float(Mat& mat, std::vector<float>& v_float)
	//{
	//	v_float.clear();
	//	CHECK_MAT(mat.type() == CV_32FC1 && mat.cols == 1);
	//	v_float = (std::vector<float>) mat;
	//}

	//void vector_float_to_Mat(std::vector<float>& v_float, Mat& mat)
	//{
	//	mat = Mat(v_float, true);
	//}


	////vector_uchar

	//void Mat_to_vector_uchar(Mat& mat, std::vector<uchar>& v_uchar)
	//{
	//	v_uchar.clear();
	//	CHECK_MAT(mat.type() == CV_8UC1 && mat.cols == 1);
	//	v_uchar = (std::vector<uchar>) mat;
	//}

	//void vector_uchar_to_Mat(std::vector<uchar>& v_uchar, Mat& mat)
	//{
	//	mat = Mat(v_uchar, true);
	//}

	//void Mat_to_vector_char(Mat& mat, std::vector<char>& v_char)
	//{
	//	v_char.clear();
	//	CHECK_MAT(mat.type() == CV_8SC1 && mat.cols == 1);
	//	v_char = (std::vector<char>) mat;
	//}

	//void vector_char_to_Mat(std::vector<char>& v_char, Mat& mat)
	//{
	//	mat = Mat(v_char, true);
	//}

	////vector_Rect

	//void Mat_to_vector_Rect(Mat& mat, std::vector<Rect>& v_rect)
	//{
	//	v_rect.clear();
	//	CHECK_MAT(mat.type() == CV_32SC4 && mat.cols == 1);
	//	v_rect = (std::vector<Rect>) mat;
	//}

	//void vector_Rect_to_Mat(std::vector<Rect>& v_rect, Mat& mat)
	//{
	//	mat = Mat(v_rect, true);
	//}


	////vector_Point
	//void Mat_to_vector_Point(Mat& mat, std::vector<Point>& v_point)
	//{
	//	v_point.clear();
	//	CHECK_MAT(mat.type() == CV_32SC2 && mat.cols == 1);
	//	v_point = (std::vector<Point>) mat;
	//}

	////vector_Point2f
	//void Mat_to_vector_Point2f(Mat& mat, std::vector<Point2f>& v_point)
	//{
	//	v_point.clear();
	//	CHECK_MAT(mat.type() == CV_32FC2 && mat.cols == 1);
	//	v_point = (std::vector<Point2f>) mat;
	//}

	////vector_Point2d
	//void Mat_to_vector_Point2d(Mat& mat, std::vector<Point2d>& v_point)
	//{
	//	v_point.clear();
	//	CHECK_MAT(mat.type() == CV_64FC2 && mat.cols == 1);
	//	v_point = (std::vector<Point2d>) mat;
	//}


	////vector_Point3i
	//void Mat_to_vector_Point3i(Mat& mat, std::vector<Point3i>& v_point)
	//{
	//	v_point.clear();
	//	CHECK_MAT(mat.type() == CV_32SC3 && mat.cols == 1);
	//	v_point = (std::vector<Point3i>) mat;
	//}

	////vector_Point3f
	//void Mat_to_vector_Point3f(Mat& mat, std::vector<Point3f>& v_point)
	//{
	//	v_point.clear();
	//	CHECK_MAT(mat.type() == CV_32FC3 && mat.cols == 1);
	//	v_point = (std::vector<Point3f>) mat;
	//}

	////vector_Point3d
	//void Mat_to_vector_Point3d(Mat& mat, std::vector<Point3d>& v_point)
	//{
	//	v_point.clear();
	//	CHECK_MAT(mat.type() == CV_64FC3 && mat.cols == 1);
	//	v_point = (std::vector<Point3d>) mat;
	//}


	//void vector_Point_to_Mat(std::vector<Point>& v_point, Mat& mat)
	//{
	//	mat = Mat(v_point, true);
	//}

	//void vector_Point2f_to_Mat(std::vector<Point2f>& v_point, Mat& mat)
	//{
	//	mat = Mat(v_point, true);
	//}

	//void vector_Point2d_to_Mat(std::vector<Point2d>& v_point, Mat& mat)
	//{
	//	mat = Mat(v_point, true);
	//}

	//void vector_Point3i_to_Mat(std::vector<Point3i>& v_point, Mat& mat)
	//{
	//	mat = Mat(v_point, true);
	//}

	//void vector_Point3f_to_Mat(std::vector<Point3f>& v_point, Mat& mat)
	//{
	//	mat = Mat(v_point, true);
	//}

	//void vector_Point3d_to_Mat(std::vector<Point3d>& v_point, Mat& mat)
	//{
	//	mat = Mat(v_point, true);
	//}

	////vector_Mat
	//void Mat_to_vector_Mat(cv::Mat& mat, std::vector<cv::Mat>& v_mat)
	//{
	//	v_mat.clear();
	//	if (mat.type() == CV_32SC2 && mat.cols == 1)
	//	{
	//		v_mat.reserve(mat.rows);
	//		for (int i = 0; i < mat.rows; i++)
	//		{
	//			Vec<int, 2> a = mat.at< Vec<int, 2> >(i, 0);
	//			long long addr = (((long long)a[0]) << 32) | (a[1] & 0xffffffff);
	//			Mat& m = *((Mat*)addr);
	//			v_mat.push_back(m);
	//		}
	//	}
	//}


	//void vector_Mat_to_Mat(std::vector<cv::Mat>& v_mat, cv::Mat& mat)
	//{
	//	int count = (int)v_mat.size();
	//	mat.create(count, 1, CV_32SC2);
	//	for (int i = 0; i < count; i++)
	//	{
	//		long long addr = (long long) new Mat(v_mat[i]);
	//		mat.at< Vec<int, 2> >(i, 0) = Vec<int, 2>(addr >> 32, addr & 0xffffffff);
	//	}
	//}

	//void Mat_to_vector_vector_Point(Mat& mat, std::vector< std::vector< Point > >& vv_pt)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(mat.rows);
	//	Mat_to_vector_Mat(mat, vm);
	//	for (size_t i = 0; i < vm.size(); i++)
	//	{
	//		std::vector<Point> vpt;
	//		Mat_to_vector_Point(vm[i], vpt);
	//		vv_pt.push_back(vpt);
	//	}
	//}

	//void Mat_to_vector_vector_Point2f(Mat& mat, std::vector< std::vector< Point2f > >& vv_pt)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(mat.rows);
	//	Mat_to_vector_Mat(mat, vm);
	//	for (size_t i = 0; i < vm.size(); i++)
	//	{
	//		std::vector<Point2f> vpt;
	//		Mat_to_vector_Point2f(vm[i], vpt);
	//		vv_pt.push_back(vpt);
	//	}
	//}

	//void Mat_to_vector_vector_Point3f(Mat& mat, std::vector< std::vector< Point3f > >& vv_pt)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(mat.rows);
	//	Mat_to_vector_Mat(mat, vm);
	//	for (size_t i = 0; i < vm.size(); i++)
	//	{
	//		std::vector<Point3f> vpt;
	//		Mat_to_vector_Point3f(vm[i], vpt);
	//		vv_pt.push_back(vpt);
	//	}
	//}

	//void Mat_to_vector_vector_char(Mat& mat, std::vector< std::vector< char > >& vv_ch)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(mat.rows);
	//	Mat_to_vector_Mat(mat, vm);
	//	for (size_t i = 0; i < vm.size(); i++)
	//	{
	//		std::vector<char> vch;
	//		Mat_to_vector_char(vm[i], vch);
	//		vv_ch.push_back(vch);
	//	}
	//}

	//void vector_vector_char_to_Mat(std::vector< std::vector< char > >& vv_ch, Mat& mat)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(vv_ch.size());
	//	for (size_t i = 0; i < vv_ch.size(); i++)
	//	{
	//		Mat m;
	//		vector_char_to_Mat(vv_ch[i], m);
	//		vm.push_back(m);
	//	}
	//	vector_Mat_to_Mat(vm, mat);
	//}

	//void vector_vector_Point_to_Mat(std::vector< std::vector< Point > >& vv_pt, Mat& mat)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(vv_pt.size());
	//	for (size_t i = 0; i < vv_pt.size(); i++)
	//	{
	//		Mat m;
	//		vector_Point_to_Mat(vv_pt[i], m);
	//		vm.push_back(m);
	//	}
	//	vector_Mat_to_Mat(vm, mat);
	//}

	//void vector_vector_Point2f_to_Mat(std::vector< std::vector< Point2f > >& vv_pt, Mat& mat)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(vv_pt.size());
	//	for (size_t i = 0; i < vv_pt.size(); i++)
	//	{
	//		Mat m;
	//		vector_Point2f_to_Mat(vv_pt[i], m);
	//		vm.push_back(m);
	//	}
	//	vector_Mat_to_Mat(vm, mat);
	//}

	//void vector_vector_Point3f_to_Mat(std::vector< std::vector< Point3f > >& vv_pt, Mat& mat)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(vv_pt.size());
	//	for (size_t i = 0; i < vv_pt.size(); i++)
	//	{
	//		Mat m;
	//		vector_Point3f_to_Mat(vv_pt[i], m);
	//		vm.push_back(m);
	//	}
	//	vector_Mat_to_Mat(vm, mat);
	//}

	//void vector_Vec4i_to_Mat(std::vector<Vec4i>& v_vec, Mat& mat)
	//{
	//	mat = Mat(v_vec, true);
	//}

	//void vector_Vec4f_to_Mat(std::vector<Vec4f>& v_vec, Mat& mat)
	//{
	//	mat = Mat(v_vec, true);
	//}

	//void vector_Vec6f_to_Mat(std::vector<Vec6f>& v_vec, Mat& mat)
	//{
	//	mat = Mat(v_vec, true);
	//}

	////vector_KeyPoint
	//void Mat_to_vector_KeyPoint(Mat& mat, std::vector<KeyPoint>& v_kp)
	//{
	//	v_kp.clear();
	//	CHECK_MAT(mat.type() == CV_32FC(7) && mat.cols == 1);
	//	for (int i = 0; i < mat.rows; i++)
	//	{
	//		Vec<float, 7> v = mat.at< Vec<float, 7> >(i, 0);
	//		KeyPoint kp(v[0], v[1], v[2], v[3], v[4], (int)v[5], (int)v[6]);
	//		v_kp.push_back(kp);
	//	}
	//	return;
	//}


	//void vector_KeyPoint_to_Mat(std::vector<KeyPoint>& v_kp, Mat& mat)
	//{
	//	int count = (int)v_kp.size();
	//	mat.create(count, 1, CV_32FC(7));
	//	for (int i = 0; i < count; i++)
	//	{
	//		KeyPoint kp = v_kp[i];
	//		mat.at< Vec<float, 7> >(i, 0) = Vec<float, 7>(kp.pt.x, kp.pt.y, kp.size, kp.angle, kp.response, (float)kp.octave, (float)kp.class_id);
	//	}
	//}

	////vector_DMatch
	//void Mat_to_vector_DMatch(Mat& mat, std::vector<DMatch>& v_dm)
	//{
	//	v_dm.clear();
	//	CHECK_MAT(mat.type() == CV_32FC4 && mat.cols == 1);
	//	for (int i = 0; i < mat.rows; i++)
	//	{
	//		Vec<float, 4> v = mat.at< Vec<float, 4> >(i, 0);
	//		DMatch dm((int)v[0], (int)v[1], (int)v[2], v[3]);
	//		v_dm.push_back(dm);
	//	}
	//	return;
	//}


	//void vector_DMatch_to_Mat(std::vector<DMatch>& v_dm, Mat& mat)
	//{
	//	int count = (int)v_dm.size();
	//	mat.create(count, 1, CV_32FC4);
	//	for (int i = 0; i < count; i++)
	//	{
	//		DMatch dm = v_dm[i];
	//		mat.at< Vec<float, 4> >(i, 0) = Vec<float, 4>((float)dm.queryIdx, (float)dm.trainIdx, (float)dm.imgIdx, dm.distance);
	//	}
	//}

	//void Mat_to_vector_vector_KeyPoint(Mat& mat, std::vector< std::vector< KeyPoint > >& vv_kp)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(mat.rows);
	//	Mat_to_vector_Mat(mat, vm);
	//	for (size_t i = 0; i < vm.size(); i++)
	//	{
	//		std::vector<KeyPoint> vkp;
	//		Mat_to_vector_KeyPoint(vm[i], vkp);
	//		vv_kp.push_back(vkp);
	//	}
	//}

	//void vector_vector_KeyPoint_to_Mat(std::vector< std::vector< KeyPoint > >& vv_kp, Mat& mat)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(vv_kp.size());
	//	for (size_t i = 0; i < vv_kp.size(); i++)
	//	{
	//		Mat m;
	//		vector_KeyPoint_to_Mat(vv_kp[i], m);
	//		vm.push_back(m);
	//	}
	//	vector_Mat_to_Mat(vm, mat);
	//}

	//void Mat_to_vector_vector_DMatch(Mat& mat, std::vector< std::vector< DMatch > >& vv_dm)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(mat.rows);
	//	Mat_to_vector_Mat(mat, vm);
	//	for (size_t i = 0; i < vm.size(); i++)
	//	{
	//		std::vector<DMatch> vdm;
	//		Mat_to_vector_DMatch(vm[i], vdm);
	//		vv_dm.push_back(vdm);
	//	}
	//}

	//void vector_vector_DMatch_to_Mat(std::vector< std::vector< DMatch > >& vv_dm, Mat& mat)
	//{
	//	std::vector<Mat> vm;
	//	vm.reserve(vv_dm.size());
	//	for (size_t i = 0; i < vv_dm.size(); i++)
	//	{
	//		Mat m;
	//		vector_DMatch_to_Mat(vv_dm[i], m);
	//		vm.push_back(m);
	//	}
	//	vector_Mat_to_Mat(vm, mat);
	//}

	void mat_4chan_to_texture(unsigned char* dst, const unsigned char* src, size_t n)
	{
		for (size_t i = 0; i < n; ++i)
			dst[i] = src[i];
	}

	void mat_3chan_to_texture(unsigned char* dst, const unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < n; i += 4) {
			dst[i] = src[k];
			dst[i + 1] = src[k + 1];
			dst[i + 2] = src[k + 2];
			dst[i + 3] = 255;
			k += 3;
		}
	}

	void mat_1chan_to_texture(unsigned char* dst, const unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < 4 * n; i += 4) {
			dst[i] = src[k];
			dst[i + 1] = src[k];
			dst[i + 2] = src[k++];
			dst[i + 3] = 255;
		}
	}

	void texture_to_mat_4chan(unsigned char* dst, const unsigned char* src, size_t n)
	{
		for (size_t i = 0; i < n; ++i)
			dst[i] = src[i];
	}

	void texture_to_mat_3chan(unsigned char* dst, const unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < n; i += 3) {
			dst[i] = src[k];
			dst[i + 1] = src[k + 1];
			dst[i + 2] = src[k + 2];
			k += 4;
		}
	}

	void texture_to_mat_1chan(unsigned char* dst, unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < n; i += 1) {
			dst[i] = src[k];
			k += 4;
		}
	}

	template<typename T>
	void matToTexture(const Mat* mat, uchar* text, const T conv) {
		size_t sizeTex = mat->total() * 4;
		if (mat->channels() == 1) {
			int k = 0;
			for (size_t i = 0; i < sizeTex; i += 4) {
				//text[i] = static_cast<uchar>(static_cast<T>(mat->data[k]) * conv);
				//text[i + 1] = static_cast<uchar>(static_cast<T>(mat->data[k]) * conv);
				//text[i + 2] = static_cast<uchar>(static_cast<T>(mat->data[k++]) * conv);
				//text[i + 3] = 255;
				text[sizeTex - 4 - i] = static_cast<uchar>(static_cast<T>(mat->data[k]) * conv);
				text[sizeTex - 3 - i] = static_cast<uchar>(static_cast<T>(mat->data[k]) * conv);
				text[sizeTex - 2 - i] = static_cast<uchar>(static_cast<T>(mat->data[k++]) * conv);
				text[sizeTex - 1 - i] = 255;
			}
		}
		else if (mat->channels() == 3) {
			int k = 0;
			for (size_t i = 0; i < sizeTex; i += 4) {
				/*text[i] = static_cast<uchar>(static_cast<T>(mat->data[k]) * conv);
				text[i + 1] = static_cast<uchar>(static_cast<T>(mat->data[k + 1]) * conv);
				text[i + 2] = static_cast<uchar>(static_cast<T>(mat->data[k + 2]) * conv);
				text[i + 3] = 255;
				k += 3;*/
				text[sizeTex - 4 - i] = static_cast<uchar>(static_cast<T>(mat->data[k]) * conv);
				text[sizeTex - 3 - i] = static_cast<uchar>(static_cast<T>(mat->data[k + 1]) * conv);
				text[sizeTex - 2 - i] = static_cast<uchar>(static_cast<T>(mat->data[k + 2]) * conv);
				text[sizeTex - 1 - i] = 255;
				k += 3;
			}
		}
		else if (mat->channels() == 4) {
			for (size_t i = 0; i < sizeTex; ++i)
				text[i] = static_cast<uchar>(mat->data[i]);
		}
	}

	template<typename T> inline
		void matToTexture(Mat* mat, uchar* text) {
		matToTexture<T>(mat, text, 1);
	}

	template<> inline
	void matToTexture<float>(Mat* mat, uchar* text) {
		matToTexture<float>(mat, text, 255);
	}

	template<> inline
		void matToTexture<double>(Mat* mat, uchar* text) {
		matToTexture<double>(mat, text, 255);
	}

	template<typename T>
	void textureToMat(const uchar* text, Mat* mat, const T conv) {
		if (mat->channels() == 1) {
			int k = 0;
			size_t sizeMat = mat->total();
			for (size_t i = 0; i < sizeMat; ++i) {
				//mat->data[i] = static_cast<T>(static_cast<T>(text[k]) / conv);
				mat->data[sizeMat - 1 - i] = static_cast<T>(static_cast<T>(text[k]) / conv);
				k += 4;
			}
		}
		else if (mat->channels() == 3) {
			int k = 0;
			size_t sizeMat = mat->total() * 3 * sizeof(uchar);
			for (size_t i = 0; i < sizeMat; i += 3) {
				//mat->data[i] = static_cast<T>(static_cast<T>(text[k]) / conv);
				//mat->data[i + 1] = static_cast<T>(static_cast<T>(text[k + 1]) / conv);
				//mat->data[i + 2] = static_cast<T>(static_cast<T>(text[k + 2]) / conv);
				//k += 4;

				mat->data[sizeMat - 3 - i] = static_cast<T>(static_cast<T>(text[k]) / conv);
				mat->data[sizeMat - 2 - i] = static_cast<T>(static_cast<T>(text[k + 1]) / conv);
				mat->data[sizeMat - 1 - i] = static_cast<T>(static_cast<T>(text[k + 2]) / conv);
				k += 4;
			}
		}
		else if (mat->channels() == 4) {
			size_t sizeMat = mat->total() * 4;
			for (size_t i = 0; i < sizeMat; ++i)
				mat->data[i] = text[i];
		}
	}

	template<typename T> inline
		void textureToMat(uchar* text, Mat* mat) {
		textureToMat<T>(text, mat, 1);
	}

	//template<> inline
	//	void textureToMat<double>(uchar* text, Mat* mat) {
	//	textureToMat<double>(text, mat, 1);
	//}

	//template<> inline
	//	void textureToMat<float>(uchar* text, Mat* mat) {
	//	textureToMat<float>(text, mat, 1);
	//}

#if WINDOWS_PLATFORM && __cplusplus
	extern "C" {
#endif

		const char* opencvunity_GetFilePath(const char* filename)
		{
			//TODO
			return filename;
		}

		void opencvunity_MatDataToArray(Mat* mat, uchar* array)
		{
			opencvunity_MatToTexture(mat, array);
		}

		void opencvunity_MatToTexture(Mat* mat, uchar* textureColors)
		{
			switch (mat->depth()) {
			case CV_8U:
				matToTexture<uchar>(mat, textureColors);
				break;

			case CV_8S:
				matToTexture<schar>(mat, textureColors);
				break;

			case CV_16U:
				matToTexture<ushort>(mat, textureColors);
				break;

			case CV_16S:
				matToTexture<short>(mat, textureColors);
				break;

			case CV_32S:
				matToTexture<int>(mat, textureColors);
				break;

			case CV_32F:
				matToTexture<float>(mat, textureColors);
				break;

			case CV_64F:
				matToTexture<double>(mat, textureColors);
				break;
			}
		}

		void opencvunity_TextureToMat(uchar* textureColors, Mat* mat)
		{
			switch (mat->depth()) {
			case CV_8U:
				textureToMat<uchar>(textureColors, mat);
				break;

			case CV_8S:
				textureToMat<schar>(textureColors, mat);
				break;

			case CV_16U:
				textureToMat<ushort>(textureColors, mat);
				break;

			case CV_16S:
				textureToMat<short>(textureColors, mat);
				break;

			case CV_32S:
				textureToMat<int>(textureColors, mat);
				break;

			case CV_32F:
				textureToMat<float>(textureColors, mat);
				break;

			case CV_64F:
				textureToMat<double>(textureColors, mat);
				break;
			}
		}

		void opencvunity_MatDataToByteArray(Mat* mat, uchar* charArray)
		{
			opencvunity_MatToTexture(mat, charArray);
		}

		void opencvunity_ByteArrayToMatData(uchar* byteArray, Mat* mat)
		{
			opencvunity_TextureToMat(byteArray, mat);
		}

		void opencvunity_TextureDataToByteArray(void* texPtr, int texWidth, int texHeight, unsigned char* byteArray, int bytesPerPixel)
		{
			texture_to_mat_4chan(byteArray, (unsigned char*)texPtr, texWidth * texHeight * bytesPerPixel);
		}

		void opencvunity_ByteArrayToTextureData(unsigned char* byteArray, void* texPtr, int texWidth, int texHeight, int bytesPerPixel)
		{
			mat_4chan_to_texture((unsigned char*)texPtr, byteArray, texWidth * texHeight * bytesPerPixel);
		}

		void opencvunity_LowLevelMatToTexture(Mat* mat, void* texPtr, int texWidth, int texHeight)
		{
			switch (mat->channels()) {
			case 1:
				mat_1chan_to_texture((unsigned char*)texPtr, mat->data, mat->total() * sizeof(float));
				break;
			case 3:
				mat_3chan_to_texture((unsigned char*)texPtr, mat->data, mat->total() * (mat->channels() + 1) * sizeof(unsigned char));
				break;
			default:
				mat_4chan_to_texture((unsigned char*)texPtr, mat->data, mat->total() * mat->channels() * sizeof(unsigned char));
				break;
			}
		}

		void opencvunity_LowLevelTextureToMat(void* texPtr, int texWidth, int texHeight, Mat* mat)
		{
			switch (mat->channels()) {
			case 1:
				texture_to_mat_1chan(mat->data, (unsigned char*)texPtr, mat->total() * sizeof(unsigned char));
				break;
			case 3:
				texture_to_mat_3chan(mat->data, (unsigned char*)texPtr, mat->total() * mat->channels() * sizeof(unsigned char));
				break;
			default:
				texture_to_mat_4chan(mat->data, (unsigned char*)texPtr, mat->total() * mat->channels() * sizeof(unsigned char));
			}
		}

		int opencvunity_GetLowLevelTextureFormat(void* texPtr)
		{
			//TODO
			return 2;
		}
#if WINDOWS_PLATFORM && __cplusplus
	}
#endif
}