#ifndef CONVERTER_CPP
#define CONVERTER_CPP

#include "opencv2\core\mat.hpp"
#include "opencv2\core\IUnityGraphics.h"
#include "opencv2\core\IUnityInterface.h"
#include <vector>
#include "params.hpp"

namespace cv {

	typedef Point3i Point3;
	typedef unsigned char byte;

	//void Mat_to_vector_int(cv::Mat& mat, std::vector<int>& v_int);
	//void vector_int_to_Mat(std::vector<int>& v_int, cv::Mat& mat);

	//void Mat_to_vector_double(cv::Mat& mat, std::vector<double>& v_double);
	//void vector_double_to_Mat(std::vector<double>& v_double, cv::Mat& mat);

	//void Mat_to_vector_float(cv::Mat& mat, std::vector<float>& v_float);
	//void vector_float_to_Mat(std::vector<float>& v_float, cv::Mat& mat);

	//void Mat_to_vector_uchar(cv::Mat& mat, std::vector<uchar>& v_uchar);
	//void vector_uchar_to_Mat(std::vector<uchar>& v_uchar, cv::Mat& mat);

	//void Mat_to_vector_char(cv::Mat& mat, std::vector<char>& v_char);
	//void vector_char_to_Mat(std::vector<char>& v_char, cv::Mat& mat);

	//void Mat_to_vector_Rect(cv::Mat& mat, std::vector<cv::Rect>& v_rect);
	//void vector_Rect_to_Mat(std::vector<cv::Rect>& v_rect, cv::Mat& mat);

	//void Mat_to_vector_Point(cv::Mat& mat, std::vector<cv::Point>& v_point);
	//void Mat_to_vector_Point2f(cv::Mat& mat, std::vector<cv::Point2f>& v_point);
	//void Mat_to_vector_Point2d(cv::Mat& mat, std::vector<cv::Point2d>& v_point);
	//void Mat_to_vector_Point3i(cv::Mat& mat, std::vector<cv::Point3i>& v_point);
	//void Mat_to_vector_Point3f(cv::Mat& mat, std::vector<cv::Point3f>& v_point);
	//void Mat_to_vector_Point3d(cv::Mat& mat, std::vector<cv::Point3d>& v_point);

	//void vector_Point_to_Mat(std::vector<cv::Point>& v_point, cv::Mat& mat);
	//void vector_Point2f_to_Mat(std::vector<cv::Point2f>& v_point, cv::Mat& mat);
	//void vector_Point2d_to_Mat(std::vector<cv::Point2d>& v_point, cv::Mat& mat);
	//void vector_Point3i_to_Mat(std::vector<cv::Point3i>& v_point, cv::Mat& mat);
	//void vector_Point3f_to_Mat(std::vector<cv::Point3f>& v_point, cv::Mat& mat);
	//void vector_Point3d_to_Mat(std::vector<cv::Point3d>& v_point, cv::Mat& mat);

	//void vector_Vec4i_to_Mat(std::vector<cv::Vec4i>& v_vec, cv::Mat& mat);
	//void vector_Vec4f_to_Mat(std::vector<cv::Vec4f>& v_vec, cv::Mat& mat);
	//void vector_Vec6f_to_Mat(std::vector<cv::Vec6f>& v_vec, cv::Mat& mat);

	//void Mat_to_vector_Mat(cv::Mat& mat, std::vector<cv::Mat>& v_mat);
	//void vector_Mat_to_Mat(std::vector<cv::Mat>& v_mat, cv::Mat& mat);

	//void Mat_to_vector_vector_char(cv::Mat& mat, std::vector< std::vector< char > >& vv_ch);
	//void vector_vector_char_to_Mat(std::vector< std::vector< char > >& vv_ch, cv::Mat& mat);

	//void Mat_to_vector_vector_Point(cv::Mat& mat, std::vector< std::vector< cv::Point > >& vv_pt);
	//void vector_vector_Point_to_Mat(std::vector< std::vector< cv::Point > >& vv_pt, cv::Mat& mat);

	//void Mat_to_vector_vector_Point2f(cv::Mat& mat, std::vector< std::vector< cv::Point2f > >& vv_pt);
	//void vector_vector_Point2f_to_Mat(std::vector< std::vector< cv::Point2f > >& vv_pt, cv::Mat& mat);

	//void Mat_to_vector_vector_Point3f(cv::Mat& mat, std::vector< std::vector< cv::Point3f > >& vv_pt);
	//void vector_vector_Point3f_to_Mat(std::vector< std::vector< cv::Point3f > >& vv_pt, cv::Mat& mat);

	//void Mat_to_vector_KeyPoint(Mat& mat, std::vector<KeyPoint>& v_kp);
	//void vector_KeyPoint_to_Mat(std::vector<KeyPoint>& v_kp, Mat& mat);

	//void Mat_to_vector_DMatch(Mat& mat, std::vector<DMatch>& v_dm);
	//void vector_DMatch_to_Mat(std::vector<DMatch>& v_dm, Mat& mat);

	//void Mat_to_vector_vector_KeyPoint(Mat& mat, std::vector< std::vector< KeyPoint > >& vv_kp);
	//void vector_vector_KeyPoint_to_Mat(std::vector< std::vector< KeyPoint > >& vv_kp, Mat& mat);

	//void Mat_to_vector_vector_DMatch(Mat& mat, std::vector< std::vector< DMatch > >& vv_dm);
	//void vector_vector_DMatch_to_Mat(std::vector< std::vector< DMatch > >& vv_dm, Mat& mat);

	//inline void mat_4chan_to_texture(byte* dst, const byte* src, size_t n);
	//inline void texture_to_mat_4chan(byte* dst, const byte* src, size_t n);

	//inline void mat_3chan_to_texture(byte* dst, const byte* src, size_t n);
	//inline void texture_to_mat_3chan(byte* dst, const byte* src, size_t n);

	//inline void mat_1chan_to_texture(float* dst, const byte* src, size_t n);
	//inline void texture_to_mat_1chan(byte* dst, const float* src, size_t n);

#if WINDOWS_PLATFORM && __cplusplus
	extern "C" {
#endif
		DLLEXPORT void opencvunity_MatDataToArray(Mat* mat, byte* array);
		DLLEXPORT const char* opencvunity_GetFilePath(const char* filename);
		DLLEXPORT void opencvunity_MatToTexture(Mat* mat, byte* textureColors);
		DLLEXPORT void opencvunity_TextureToMat(byte* textureColors, Mat* mat);
		DLLEXPORT void opencvunity_MatDataToByteArray(Mat* mat, byte* byteArray);
		DLLEXPORT void opencvunity_ByteArrayToMatData(byte* byteArray, Mat* mat);
		DLLEXPORT void opencvunity_TextureDataToByteArray(void* texPtr, int texWidth, int texHeight, byte* byteArray, int bytesPerPixel);
		DLLEXPORT void opencvunity_ByteArrayToTextureData(byte* byteArray, void* texPtr, int texWidth, int texHeight, int bytesPerPixel);
		DLLEXPORT void opencvunity_LowLevelMatToTexture(Mat* mat, void* texPtr, int texWidth, int texHeight);
		DLLEXPORT void opencvunity_LowLevelTextureToMat(void* texPtr, int texWidth, int texHeight, Mat* mat);
		DLLEXPORT int opencvunity_GetLowLevelTextureFormat(void* texPtr);

#if WINDOWS_PLATFORM && __cplusplus
	}
#endif

}
#endif