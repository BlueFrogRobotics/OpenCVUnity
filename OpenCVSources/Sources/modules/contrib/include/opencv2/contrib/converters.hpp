#ifndef CONVERTER_MAT_VEC_HPP
# define CONVERTER_MAT_VEC_HPP

# include "..\..\java\generator\src\cpp\common.h"
# include "opencv2/opencv_modules.hpp"
# include "opencv2/core.hpp"

using namespace cv;

void Mat_to_vector_int(Mat& mat, std::vector<int>& v_int);
void vector_int_to_Mat(std::vector<int>& v_int, Mat& mat);

void Mat_to_vector_double(Mat& mat, std::vector<double>& v_double);
void vector_double_to_Mat(std::vector<double>& v_double, Mat& mat);

void Mat_to_vector_float(Mat& mat, std::vector<float>& v_float);
void vector_float_to_Mat(std::vector<float>& v_float, Mat& mat);

void Mat_to_vector_uchar(Mat& mat, std::vector<uchar>& v_uchar);
void vector_uchar_to_Mat(std::vector<uchar>& v_uchar, Mat& mat);

void Mat_to_vector_char(Mat& mat, std::vector<char>& v_char);
void vector_char_to_Mat(std::vector<char>& v_char, Mat& mat);

void Mat_to_vector_Rect(Mat& mat, std::vector<Rect>& v_rect);
void vector_Rect_to_Mat(std::vector<Rect>& v_rect, Mat& mat);

void Mat_to_vector_Point(Mat& mat, std::vector<Point>& v_point);
void Mat_to_vector_Point2f(Mat& mat, std::vector<Point2f>& v_point);
void Mat_to_vector_Point2d(Mat& mat, std::vector<Point2d>& v_point);
void Mat_to_vector_Point3i(Mat& mat, std::vector<Point3i>& v_point);
void Mat_to_vector_Point3f(Mat& mat, std::vector<Point3f>& v_point);
void Mat_to_vector_Point3d(Mat& mat, std::vector<Point3d>& v_point);

void vector_Point_to_Mat(std::vector<Point>& v_point, Mat& mat);
void vector_Point2f_to_Mat(std::vector<Point2f>& v_point, Mat& mat);
void vector_Point2d_to_Mat(std::vector<Point2d>& v_point, Mat& mat);
void vector_Point3i_to_Mat(std::vector<Point3i>& v_point, Mat& mat);
void vector_Point3f_to_Mat(std::vector<Point3f>& v_point, Mat& mat);
void vector_Point3d_to_Mat(std::vector<Point3d>& v_point, Mat& mat);

void vector_Vec4i_to_Mat(std::vector<Vec4i>& v_vec, Mat& mat);
void vector_Vec4f_to_Mat(std::vector<Vec4f>& v_vec, Mat& mat);
void vector_Vec6f_to_Mat(std::vector<Vec6f>& v_vec, Mat& mat);

void Mat_to_vector_Mat(Mat& mat, std::vector<Mat>& v_mat);
void vector_Mat_to_Mat(std::vector<Mat>& v_mat, Mat& mat);

void Mat_to_vector_vector_char(Mat& mat, std::vector< std::vector< char > >& vv_ch);
void vector_vector_char_to_Mat(std::vector< std::vector< char > >& vv_ch, Mat& mat);

void Mat_to_vector_vector_Point(Mat& mat, std::vector< std::vector< Point > >& vv_pt);
void vector_vector_Point_to_Mat(std::vector< std::vector< Point > >& vv_pt, Mat& mat);

void Mat_to_vector_vector_Point2f(Mat& mat, std::vector< std::vector< Point2f > >& vv_pt);
void vector_vector_Point2f_to_Mat(std::vector< std::vector< Point2f > >& vv_pt, Mat& mat);

void Mat_to_vector_vector_Point3f(Mat& mat, std::vector< std::vector< Point3f > >& vv_pt);
void vector_vector_Point3f_to_Mat(std::vector< std::vector< Point3f > >& vv_pt, Mat& mat);

#endif