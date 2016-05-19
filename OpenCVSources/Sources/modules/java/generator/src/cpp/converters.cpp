#define LOG_TAG "org.opencv.utils.Converters"
#include "common.h"

using namespace cv;

#define CHECK_MAT(cond) if(!(cond)){ LOGD("FAILED: " #cond); return; }


// vector_int

void Mat_to_vector_int(Mat& mat, std::vector<int>& v_int)
{
    v_int.clear();
    CHECK_MAT(mat.type()==CV_32SC1 && mat.cols==1);
    v_int = (std::vector<int>) mat;
}

void vector_int_to_Mat(std::vector<int>& v_int, Mat& mat)
{
    mat = Mat(v_int, true);
}


//vector_double

void Mat_to_vector_double(Mat& mat, std::vector<double>& v_double)
{
    v_double.clear();
    CHECK_MAT(mat.type()==CV_64FC1 && mat.cols==1);
    v_double = (std::vector<double>) mat;
}

void vector_double_to_Mat(std::vector<double>& v_double, Mat& mat)
{
    mat = Mat(v_double, true);
}


// vector_float

void Mat_to_vector_float(Mat& mat, std::vector<float>& v_float)
{
    v_float.clear();
    CHECK_MAT(mat.type()==CV_32FC1 && mat.cols==1);
    v_float = (std::vector<float>) mat;
}

void vector_float_to_Mat(std::vector<float>& v_float, Mat& mat)
{
    mat = Mat(v_float, true);
}


//vector_uchar

void Mat_to_vector_uchar(Mat& mat, std::vector<uchar>& v_uchar)
{
    v_uchar.clear();
    CHECK_MAT(mat.type()==CV_8UC1 && mat.cols==1);
    v_uchar = (std::vector<uchar>) mat;
}

void vector_uchar_to_Mat(std::vector<uchar>& v_uchar, Mat& mat)
{
    mat = Mat(v_uchar, true);
}

void Mat_to_vector_char(Mat& mat, std::vector<char>& v_char)
{
    v_char.clear();
    CHECK_MAT(mat.type()==CV_8SC1 && mat.cols==1);
    v_char = (std::vector<char>) mat;
}

void vector_char_to_Mat(std::vector<char>& v_char, Mat& mat)
{
    mat = Mat(v_char, true);
}


//vector_Rect

void Mat_to_vector_Rect(Mat& mat, std::vector<Rect>& v_rect)
{
    v_rect.clear();
    CHECK_MAT(mat.type()==CV_32SC4 && mat.cols==1);
    v_rect = (std::vector<Rect>) mat;
}

void vector_Rect_to_Mat(std::vector<Rect>& v_rect, Mat& mat)
{
    mat = Mat(v_rect, true);
}


//vector_Point
void Mat_to_vector_Point(Mat& mat, std::vector<Point>& v_point)
{
    v_point.clear();
    CHECK_MAT(mat.type()==CV_32SC2 && mat.cols==1);
    v_point = (std::vector<Point>) mat;
}

//vector_Point2f
void Mat_to_vector_Point2f(Mat& mat, std::vector<Point2f>& v_point)
{
    v_point.clear();
    CHECK_MAT(mat.type()==CV_32FC2 && mat.cols==1);
    v_point = (std::vector<Point2f>) mat;
}

//vector_Point2d
void Mat_to_vector_Point2d(Mat& mat, std::vector<Point2d>& v_point)
{
    v_point.clear();
    CHECK_MAT(mat.type()==CV_64FC2 && mat.cols==1);
    v_point = (std::vector<Point2d>) mat;
}


//vector_Point3i
void Mat_to_vector_Point3i(Mat& mat, std::vector<Point3i>& v_point)
{
    v_point.clear();
    CHECK_MAT(mat.type()==CV_32SC3 && mat.cols==1);
    v_point = (std::vector<Point3i>) mat;
}

//vector_Point3f
void Mat_to_vector_Point3f(Mat& mat, std::vector<Point3f>& v_point)
{
    v_point.clear();
    CHECK_MAT(mat.type()==CV_32FC3 && mat.cols==1);
    v_point = (std::vector<Point3f>) mat;
}

//vector_Point3d
void Mat_to_vector_Point3d(Mat& mat, std::vector<Point3d>& v_point)
{
    v_point.clear();
    CHECK_MAT(mat.type()==CV_64FC3 && mat.cols==1);
    v_point = (std::vector<Point3d>) mat;
}


void vector_Point_to_Mat(std::vector<Point>& v_point, Mat& mat)
{
    mat = Mat(v_point, true);
}

void vector_Point2f_to_Mat(std::vector<Point2f>& v_point, Mat& mat)
{
    mat = Mat(v_point, true);
}

void vector_Point2d_to_Mat(std::vector<Point2d>& v_point, Mat& mat)
{
    mat = Mat(v_point, true);
}

void vector_Point3i_to_Mat(std::vector<Point3i>& v_point, Mat& mat)
{
    mat = Mat(v_point, true);
}

void vector_Point3f_to_Mat(std::vector<Point3f>& v_point, Mat& mat)
{
    mat = Mat(v_point, true);
}

void vector_Point3d_to_Mat(std::vector<Point3d>& v_point, Mat& mat)
{
    mat = Mat(v_point, true);
}

//vector_Mat
void Mat_to_vector_Mat(cv::Mat& mat, std::vector<cv::Mat>& v_mat)
{
    v_mat.clear();
    if(mat.type() == CV_32SC2 && mat.cols == 1)
    {
        v_mat.reserve(mat.rows);
        for(int i=0; i<mat.rows; i++)
        {
            Vec<int, 2> a = mat.at< Vec<int, 2> >(i, 0);
            long long addr = (((long long)a[0])<<32) | (a[1]&0xffffffff);
            Mat& m = *( (Mat*) addr );
            v_mat.push_back(m);
        }
    } else {
        LOGD("Mat_to_vector_Mat() FAILED: mat.type() == CV_32SC2 && mat.cols == 1");
    }
}


void vector_Mat_to_Mat(std::vector<cv::Mat>& v_mat, cv::Mat& mat)
{
    int count = (int)v_mat.size();
    mat.create(count, 1, CV_32SC2);
    for(int i=0; i<count; i++)
    {
        long long addr = (long long) new Mat(v_mat[i]);
        mat.at< Vec<int, 2> >(i, 0) = Vec<int, 2>(addr>>32, addr&0xffffffff);
    }
}

void Mat_to_vector_vector_Point(Mat& mat, std::vector< std::vector< Point > >& vv_pt)
{
    std::vector<Mat> vm;
    vm.reserve( mat.rows );
    Mat_to_vector_Mat(mat, vm);
    for(size_t i=0; i<vm.size(); i++)
    {
        std::vector<Point> vpt;
        Mat_to_vector_Point(vm[i], vpt);
        vv_pt.push_back(vpt);
    }
}

void Mat_to_vector_vector_Point2f(Mat& mat, std::vector< std::vector< Point2f > >& vv_pt)
{
    std::vector<Mat> vm;
    vm.reserve( mat.rows );
    Mat_to_vector_Mat(mat, vm);
    for(size_t i=0; i<vm.size(); i++)
    {
        std::vector<Point2f> vpt;
        Mat_to_vector_Point2f(vm[i], vpt);
        vv_pt.push_back(vpt);
    }
}

void Mat_to_vector_vector_Point3f(Mat& mat, std::vector< std::vector< Point3f > >& vv_pt)
{
    std::vector<Mat> vm;
    vm.reserve( mat.rows );
    Mat_to_vector_Mat(mat, vm);
    for(size_t i=0; i<vm.size(); i++)
    {
        std::vector<Point3f> vpt;
        Mat_to_vector_Point3f(vm[i], vpt);
        vv_pt.push_back(vpt);
    }
}

void Mat_to_vector_vector_char(Mat& mat, std::vector< std::vector< char > >& vv_ch)
{
    std::vector<Mat> vm;
    vm.reserve( mat.rows );
    Mat_to_vector_Mat(mat, vm);
    for(size_t i=0; i<vm.size(); i++)
    {
        std::vector<char> vch;
        Mat_to_vector_char(vm[i], vch);
        vv_ch.push_back(vch);
    }
}

void vector_vector_char_to_Mat(std::vector< std::vector< char > >& vv_ch, Mat& mat)
{
    std::vector<Mat> vm;
    vm.reserve( vv_ch.size() );
    for(size_t i=0; i<vv_ch.size(); i++)
    {
        Mat m;
        vector_char_to_Mat(vv_ch[i], m);
        vm.push_back(m);
    }
    vector_Mat_to_Mat(vm, mat);
}

void vector_vector_Point_to_Mat(std::vector< std::vector< Point > >& vv_pt, Mat& mat)
{
    std::vector<Mat> vm;
    vm.reserve( vv_pt.size() );
    for(size_t i=0; i<vv_pt.size(); i++)
    {
        Mat m;
        vector_Point_to_Mat(vv_pt[i], m);
        vm.push_back(m);
    }
    vector_Mat_to_Mat(vm, mat);
}

void vector_vector_Point2f_to_Mat(std::vector< std::vector< Point2f > >& vv_pt, Mat& mat)
{
    std::vector<Mat> vm;
    vm.reserve( vv_pt.size() );
    for(size_t i=0; i<vv_pt.size(); i++)
    {
        Mat m;
        vector_Point2f_to_Mat(vv_pt[i], m);
        vm.push_back(m);
    }
    vector_Mat_to_Mat(vm, mat);
}

void vector_vector_Point3f_to_Mat(std::vector< std::vector< Point3f > >& vv_pt, Mat& mat)
{
    std::vector<Mat> vm;
    vm.reserve( vv_pt.size() );
    for(size_t i=0; i<vv_pt.size(); i++)
    {
        Mat m;
        vector_Point3f_to_Mat(vv_pt[i], m);
        vm.push_back(m);
    }
    vector_Mat_to_Mat(vm, mat);
}

void vector_Vec4i_to_Mat(std::vector<Vec4i>& v_vec, Mat& mat)
{
    mat = Mat(v_vec, true);
}

void vector_Vec4f_to_Mat(std::vector<Vec4f>& v_vec, Mat& mat)
{
    mat = Mat(v_vec, true);
}

void vector_Vec6f_to_Mat(std::vector<Vec6f>& v_vec, Mat& mat)
{
    mat = Mat(v_vec, true);
}


	
		void mat_4chan_to_texture(unsigned char* dst, const unsigned char* src, size_t n)
	{
		for (size_t i = 0; i < n; i += 4 ){
			dst[n-i-1] = 255;
			dst[n-i-2] = src[i+2];
			dst[n-i-3] = src[i+1];
			dst[n-i-4] = src[i];
		}
	}

	
		void texture_to_mat_4chan(unsigned char* dst, const unsigned char* src, size_t n)
	{
		for (size_t i = 0; i < n; i += 4 ){
			dst[n-i-1] = 255;
			dst[n-i-2] = src[i+2];
			dst[n-i-3] = src[i+1];
			dst[n-i-4] = src[i];
		}
	}

	
		void mat_3chan_to_texture(unsigned char* dst, const unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < n; i += 4) {
			dst[n-i-4] = src[k];
			dst[n-i-3] = src[k+1];
			dst[n-i-2] = src[k+2];
			dst[n-i-1] = 255;
			k += 3;
		}
	}

	
		void texture_to_mat_3chan(unsigned char* dst, const unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < n; i += 3) {
			dst[n-i-3] = src[k];
			dst[n-i-2] = src[k+1];
			dst[n-i-1] = src[k+2];
			k += 4;
		}
	}


	
		void mat_1chan_to_texture(unsigned char* dst, const unsigned char* src,size_t n)
	{
		int k = 0;
			for (size_t i = 0; i < 4*n; i+=4) {
			dst[4*n-i-4] = src[k];
			dst[4*n-i-3] = src[k];
			dst[4*n-i-2] = src[k++];
			dst[4*n-i-1] = 255;		
		}
	}

	
		void texture_to_mat_1chan(unsigned char* dst, unsigned char* src, size_t n)
	{
		int k = 0;
		for (size_t i = 0; i < n; i += 1) {
			dst[n-i-1] = src[k] ;
			k += 4;
		}
	}

extern "C" {
		unsigned char* opencvunity_GetFilePath(unsigned char* filename)
		{
			//TODO
			return filename;
		}

		void opencvunity_MatDataToArray(Mat* mat, unsigned char* array)
		{
			array = (unsigned char*)memcpy(array, mat->data, mat->rows * mat->cols * mat->channels() * sizeof(unsigned char));
		}

		void opencvunity_MatToTexture(Mat* mat, unsigned char* textureColors)
		{
			switch (mat->channels()) {
			case 1:
				mat_1chan_to_texture(textureColors, mat->data, mat->total() * sizeof(unsigned char));
				break;
			case 3:
				mat_3chan_to_texture(textureColors, mat->data, mat->total() * (mat->channels() + 1) * sizeof(unsigned char));
				break;
			default:
				mat_4chan_to_texture(textureColors, mat->data, mat->total() * mat->channels() * sizeof(unsigned char));
				break;
			}
		}

		void opencvunity_TextureToMat(unsigned char* textureColors, Mat* mat)
		{
			switch (mat->channels()) {
			case 1:
				texture_to_mat_1chan(mat->data, textureColors, mat->total() * sizeof(unsigned char));
				break;
			case 3:
				texture_to_mat_3chan(mat->data, textureColors, mat->total() * mat->channels() * sizeof(unsigned char));
				break;
			default:
				texture_to_mat_4chan(mat->data, textureColors, mat->total() * mat->channels() * sizeof(unsigned char));
				break;
			}
		}

		void opencvunity_MatDataToByteArray(Mat* mat, unsigned char* charArray)
		{
			charArray = (unsigned char*)memcpy(charArray, mat->data, mat->rows * mat->cols * mat->channels() * sizeof(unsigned char));
		}

		void opencvunity_ByteArrayToMatData(unsigned char* byteArray, Mat* mat)
		{
			mat = (Mat*)memcpy(mat->data, byteArray, mat->rows * mat->cols * mat->channels() * sizeof(unsigned char));
		}

		void opencvunity_TextureDataToByteArray(void* texPtr, int texWidth, int texHeight,unsigned char* byteArray, int bytesPerPixel)
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


}
