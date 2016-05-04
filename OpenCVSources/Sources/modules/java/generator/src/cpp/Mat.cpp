#define LOG_TAG "org.opencv.core.Mat"

#include <stdexcept>
#include <string>

#include "common.h"
#include "opencv2/core.hpp"

using namespace cv;

/// throw java exception
static void throwJavaException(JNIEnv *env, const std::exception *e, const char *method) {
	std::string what = "unknown exception";
	jclass je = 0;

	if (e) {
		std::string exception_type = "std::exception";

		if (dynamic_cast<const cv::Exception*>(e)) {
			exception_type = "cv::Exception";
			je = env->FindClass("org/opencv/core/CvException");
		}

		what = exception_type + ": " + e->what();
	}

	if (!je) je = env->FindClass("java/lang/Exception");
	env->ThrowNew(je, what.c_str());

	LOGE("%s caught %s", method, what.c_str());
	(void)method;        // avoid "unused" warning
}

extern "C" {


	//
	//   MatXXX::MatXXX()
	//


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__
		(JNIEnv*, jclass);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__
		(JNIEnv*, jclass)
	{
		LOGD("Mat::n_1Mat__()");
		return (jlong) new cv::Mat();
	}

	JNIEXPORT Mat* core_Mat_n_1Mat__
		()
	{
		return new cv::Mat();
	}



	//
	//   Mat::Mat(int rows, int cols, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type)
	{
		static const char method_name[] = "Mat::n_1Mat__III()";
		try {
			LOGD("%s", method_name);
			return (jlong) new Mat(rows, cols, type);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1Mat__III
		(int rows, int cols, int type)
	{
		return new Mat(rows, cols, type);
	}



	//
	//   Mat::Mat(Size size, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type)
	{
		static const char method_name[] = "Mat::n_1Mat__DDI()";
		try {
			LOGD("%s", method_name);
			Size size((int)size_width, (int)size_height);
			return (jlong) new Mat(size, type);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1Mat__DDI
		(double size_width, double size_height, int type)
	{

		Size size((int)size_width, (int)size_height);
		return new Mat(size, type);

	}



	//
	//   Mat::Mat(int rows, int cols, int type, Scalar s)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__IIIDDDD
		(JNIEnv* env, jclass, jint rows, jint cols, jint type, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3);


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__IIIDDDD
		(JNIEnv* env, jclass, jint rows, jint cols, jint type, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3)
	{
		static const char method_name[] = "Mat::n_1Mat__IIIDDDD()";
		try {
			LOGD("%s", method_name);
			Scalar s(s_val0, s_val1, s_val2, s_val3);
			return (jlong) new Mat(rows, cols, type, s);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}



	JNIEXPORT Mat* core_Mat_n_1Mat__IIIDDDD
		(int rows, int cols, int type, double s_val0, double s_val1, double s_val2, double s_val3)
	{
		Scalar s(s_val0, s_val1, s_val2, s_val3);
		return new Mat(rows, cols, type, s);
	}



	//
	//   Mat::Mat(Size size, int type, Scalar s)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__DDIDDDD
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__DDIDDDD
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3)
	{
		static const char method_name[] = "Mat::n_1Mat__DDIDDDD()";
		try {
			LOGD("%s", method_name);
			Size size((int)size_width, (int)size_height);
			Scalar s(s_val0, s_val1, s_val2, s_val3);
			return (jlong) new Mat(size, type, s);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1Mat__DDIDDDD
		(double size_width, double size_height, int type, double s_val0, double s_val1, double s_val2, double s_val3)
	{

		Size size((int)size_width, (int)size_height);
		Scalar s(s_val0, s_val1, s_val2, s_val3);
		return new Mat(size, type, s);

	}



	//
	//   Mat::Mat(Mat m, Range rowRange, Range colRange = Range::all())
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__JIIII
		(JNIEnv* env, jclass, jlong m_nativeObj, jint rowRange_start, jint rowRange_end, jint colRange_start, jint colRange_end);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__JIIII
		(JNIEnv* env, jclass, jlong m_nativeObj, jint rowRange_start, jint rowRange_end, jint colRange_start, jint colRange_end)
	{
		static const char method_name[] = "Mat::n_1Mat__JIIII()";
		try {
			LOGD("%s", method_name);
			Range rowRange(rowRange_start, rowRange_end);
			Range colRange(colRange_start, colRange_end);
			return (jlong) new Mat((*(Mat*)m_nativeObj), rowRange, colRange);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1Mat__JIIII
		(Mat* m_nativeObj, int rowRange_start, int rowRange_end, int colRange_start, int colRange_end)
	{
		Range rowRange(rowRange_start, rowRange_end);
		Range colRange(colRange_start, colRange_end);
		return new Mat((*(Mat*)m_nativeObj), rowRange, colRange);
	}


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__JII
		(JNIEnv* env, jclass, jlong m_nativeObj, jint rowRange_start, jint rowRange_end);


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1Mat__JII
		(JNIEnv* env, jclass, jlong m_nativeObj, jint rowRange_start, jint rowRange_end)
	{
		static const char method_name[] = "Mat::n_1Mat__JII()";
		try {
			LOGD("%s", method_name);
			Range rowRange(rowRange_start, rowRange_end);
			return (jlong) new Mat((*(Mat*)m_nativeObj), rowRange);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1Mat__JII
		(Mat* m_nativeObj, int rowRange_start, int rowRange_end)
	{
		Range rowRange(rowRange_start, rowRange_end);
		return new Mat((*(Mat*)m_nativeObj), rowRange);
	}

	//
	//  Mat Mat::adjustROI(int dtop, int dbottom, int dleft, int dright)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1adjustROI
		(JNIEnv* env, jclass, jlong self, jint dtop, jint dbottom, jint dleft, jint dright);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1adjustROI
		(JNIEnv* env, jclass, jlong self, jint dtop, jint dbottom, jint dleft, jint dright)
	{
		static const char method_name[] = "Mat::n_1adjustROI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->adjustROI(dtop, dbottom, dleft, dright);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1adjustROI
		(Mat* self, int dtop, int dbottom, int dleft, int dright)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->adjustROI(dtop, dbottom, dleft, dright);
		return new Mat(_retval_);

	}



	//
	//  void Mat::assignTo(Mat m, int type = -1)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1assignTo__JJI
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint type);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1assignTo__JJI
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint type)
	{
		static const char method_name[] = "Mat::n_1assignTo__JJI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			me->assignTo((*(Mat*)m_nativeObj), type);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1assignTo__JJI
		(Mat* self, long m_nativeObj, int type)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		me->assignTo((*(Mat*)m_nativeObj), type);
	}


	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1assignTo__JJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1assignTo__JJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj)
	{
		static const char method_name[] = "Mat::n_1assignTo__JJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			me->assignTo((*(Mat*)m_nativeObj));
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1assignTo__JJ
		(Mat* self, Mat* m_nativeObj)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		me->assignTo((*(Mat*)m_nativeObj));
	}



	//
	//  int Mat::channels()
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1channels
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1channels
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1channels()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->channels();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_n_1channels
		(Mat* self)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->channels();
	}



	//
	//  int Mat::checkVector(int elemChannels, int depth = -1, bool requireContinuous = true)
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1checkVector__JIIZ
		(JNIEnv* env, jclass, jlong self, jint elemChannels, jint depth, jboolean requireContinuous);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1checkVector__JIIZ
		(JNIEnv* env, jclass, jlong self, jint elemChannels, jint depth, jboolean requireContinuous)
	{
		static const char method_name[] = "Mat::n_1checkVector__JIIZ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->checkVector(elemChannels, depth, requireContinuous);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT int core_Mat_n_1checkVector__JIIZ
		(Mat* self, int elemChannels, int depth, bool requireContinuous)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->checkVector(elemChannels, depth, requireContinuous);
	}



	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1checkVector__JII
		(JNIEnv* env, jclass, jlong self, jint elemChannels, jint depth);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1checkVector__JII
		(JNIEnv* env, jclass, jlong self, jint elemChannels, jint depth)
	{
		static const char method_name[] = "Mat::n_1checkVector__JII()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->checkVector(elemChannels, depth);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT int core_Mat_n_1checkVector__JII
		(Mat* self, int elemChannels, int depth)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->checkVector(elemChannels, depth);

	}


	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1checkVector__JI
		(JNIEnv* env, jclass, jlong self, jint elemChannels);


	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1checkVector__JI
		(JNIEnv* env, jclass, jlong self, jint elemChannels)
	{
		static const char method_name[] = "Mat::n_1checkVector__JI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->checkVector(elemChannels);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_n_1checkVector__JI
		(Mat* self, int elemChannels)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->checkVector(elemChannels);

	}


	//
	//  Mat Mat::clone()
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1clone
		(JNIEnv* env, jclass, jlong self);


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1clone
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1clone()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->clone();
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1clone
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->clone();
		return new Mat(_retval_);

	}


	//
	//  Mat Mat::col(int x)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1col
		(JNIEnv* env, jclass, jlong self, jint x);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1col
		(JNIEnv* env, jclass, jlong self, jint x)
	{
		static const char method_name[] = "Mat::n_1col()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->col(x);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1col
		(Mat* self, int x)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->col(x);
		return new Mat(_retval_);

	}



	//
	//  Mat Mat::colRange(int startcol, int endcol)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1colRange
		(JNIEnv* env, jclass, jlong self, jint startcol, jint endcol);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1colRange
		(JNIEnv* env, jclass, jlong self, jint startcol, jint endcol)
	{
		static const char method_name[] = "Mat::n_1colRange()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->colRange(startcol, endcol);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1colRange
		(Mat* self, int startcol, int endcol)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->colRange(startcol, endcol);
		return new Mat(_retval_);

	}



	//
	//  int Mat::dims()
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1dims
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1dims
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1dims()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->dims;
		}
		catch (const cv::Exception& e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_n_1dims
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->dims;

	}



	//
	//  int Mat::cols()
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1cols
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1cols
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1cols()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->cols;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT int core_Mat_n_1cols
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->cols;

	}


	//
	//  void Mat::convertTo(Mat& m, int rtype, double alpha = 1, double beta = 0)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1convertTo__JJIDD
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint rtype, jdouble alpha, jdouble beta);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1convertTo__JJIDD
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint rtype, jdouble alpha, jdouble beta)
	{
		static const char method_name[] = "Mat::n_1convertTo__JJIDD()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			me->convertTo(m, rtype, alpha, beta);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}


	JNIEXPORT void core_Mat_n_1convertTo__JJIDD
		(Mat* self, Mat* m_nativeObj, int rtype, double alpha, double beta)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		me->convertTo(m, rtype, alpha, beta);

	}


	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1convertTo__JJID
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint rtype, jdouble alpha);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1convertTo__JJID
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint rtype, jdouble alpha)
	{
		static const char method_name[] = "Mat::n_1convertTo__JJID()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			me->convertTo(m, rtype, alpha);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1convertTo__JJID
		(Mat* self, Mat* m_nativeObj, int rtype, double alpha)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		me->convertTo(m, rtype, alpha);

	}


	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1convertTo__JJI
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint rtype);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1convertTo__JJI
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jint rtype)
	{
		static const char method_name[] = "Mat::n_1convertTo__JJI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			me->convertTo(m, rtype);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1convertTo__JJI
		(Mat* self, Mat* m_nativeObj, int rtype)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		me->convertTo(m, rtype);

	}



	//
	//  void Mat::copyTo(Mat& m)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1copyTo__JJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1copyTo__JJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj)
	{
		static const char method_name[] = "Mat::n_1copyTo__JJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			me->copyTo(m);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1copyTo__JJ
		(Mat* self, Mat* m_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		me->copyTo(m);

	}



	//
	//  void Mat::copyTo(Mat& m, Mat mask)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1copyTo__JJJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jlong mask_nativeObj);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1copyTo__JJJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jlong mask_nativeObj)
	{
		static const char method_name[] = "Mat::n_1copyTo__JJJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			Mat& mask = *((Mat*)mask_nativeObj);
			me->copyTo(m, mask);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1copyTo__JJJ
		(Mat* self, Mat* m_nativeObj, Mat* mask_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		Mat& mask = *((Mat*)mask_nativeObj);
		me->copyTo(m, mask);

	}



	//
	//  void Mat::create(int rows, int cols, int type)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1create__JIII
		(JNIEnv* env, jclass, jlong self, jint rows, jint cols, jint type);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1create__JIII
		(JNIEnv* env, jclass, jlong self, jint rows, jint cols, jint type)
	{
		static const char method_name[] = "Mat::n_1create__JIII()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			me->create(rows, cols, type);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1create__JIII
		(Mat* self, int rows, int cols, int type)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		me->create(rows, cols, type);

	}



	//
	//  void Mat::create(Size size, int type)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1create__JDDI
		(JNIEnv* env, jclass, jlong self, jdouble size_width, jdouble size_height, jint type);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1create__JDDI
		(JNIEnv* env, jclass, jlong self, jdouble size_width, jdouble size_height, jint type)
	{
		static const char method_name[] = "Mat::n_1create__JDDI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Size size((int)size_width, (int)size_height);
			me->create(size, type);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1create__JDDI
		(Mat* self, double size_width, double size_height, int type)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Size size((int)size_width, (int)size_height);
		me->create(size, type);

	}



	//
	//  Mat Mat::cross(Mat m)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1cross
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1cross
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj)
	{
		static const char method_name[] = "Mat::n_1cross()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			Mat _retval_ = me->cross(m);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1cross
		(Mat* self, Mat* m_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		Mat _retval_ = me->cross(m);
		return new Mat(_retval_);

	}



	//
	//  long Mat::dataAddr()
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1dataAddr
		(JNIEnv*, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1dataAddr
		(JNIEnv*, jclass, jlong self)
	{
		LOGD("Mat::n_1dataAddr()");
		Mat* me = (Mat*)self; //TODO: check for NULL
		return (jlong)me->data;
	}

	JNIEXPORT unsigned char* core_Mat_n_1dataAddr
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return  me->data;
	}



	//
	//  int Mat::depth()
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1depth
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1depth
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1depth()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->depth();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_n_1depth
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->depth();

	}



	//
	//  Mat Mat::diag(int d = 0)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1diag__JI
		(JNIEnv* env, jclass, jlong self, jint d);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1diag__JI
		(JNIEnv* env, jclass, jlong self, jint d)
	{
		static const char method_name[] = "Mat::n_1diag__JI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->diag(d);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1diag__JI
		(Mat* self, int d)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->diag(d);
		return  new Mat(_retval_);

	}




	//
	// static Mat Mat::diag(Mat d)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1diag__J
		(JNIEnv* env, jclass, jlong d_nativeObj);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1diag__J
		(JNIEnv* env, jclass, jlong d_nativeObj)
	{
		static const char method_name[] = "Mat::n_1diag__J()";
		try {
			LOGD("%s", method_name);
			Mat _retval_ = Mat::diag((*(Mat*)d_nativeObj));
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1diag__J
		(Mat* d_nativeObj)
	{
		Mat _retval_ = Mat::diag((*(Mat*)d_nativeObj));
		return new Mat(_retval_);

	}



	//
	//  double Mat::dot(Mat m)
	//

	JNIEXPORT jdouble JNICALL Java_org_opencv_core_Mat_n_1dot
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj);

	JNIEXPORT jdouble JNICALL Java_org_opencv_core_Mat_n_1dot
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj)
	{
		static const char method_name[] = "Mat::n_1dot()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			return me->dot(m);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT double core_Mat_n_1dot
		(Mat* self, Mat* m_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		return me->dot(m);

	}



	//
	//  size_t Mat::elemSize()
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1elemSize
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1elemSize
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1elemSize()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->elemSize();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT unsigned int* core_Mat_n_1elemSize
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return (unsigned int*)me->elemSize();

	}



	//
	//  size_t Mat::elemSize1()
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1elemSize1
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1elemSize1
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1elemSize1()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->elemSize1();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT unsigned int* core_Mat_n_1elemSize1
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return (unsigned int*)me->elemSize1();

	}



	//
	//  bool Mat::empty()
	//

	JNIEXPORT jboolean JNICALL Java_org_opencv_core_Mat_n_1empty
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jboolean JNICALL Java_org_opencv_core_Mat_n_1empty
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1empty()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->empty();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT bool core_Mat_n_1empty
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->empty();

	}




	//
	// static Mat Mat::eye(int rows, int cols, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1eye__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1eye__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type)
	{
		static const char method_name[] = "Mat::n_1eye__III()";
		try {
			LOGD("%s", method_name);
			Mat _retval_ = Mat::eye(rows, cols, type);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1eye__III
		(int rows, int cols, int type)
	{

		Mat _retval_ = Mat::eye(rows, cols, type);
		return new Mat(_retval_);

	}



	//
	// static Mat Mat::eye(Size size, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1eye__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1eye__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type)
	{
		static const char method_name[] = "Mat::n_1eye__DDI()";
		try {
			LOGD("%s", method_name);
			Size size((int)size_width, (int)size_height);
			Mat _retval_ = Mat::eye(size, type);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1eye__DDI
		(double size_width, double size_height, int type)
	{

		Size size((int)size_width, (int)size_height);
		Mat _retval_ = Mat::eye(size, type);
		return new Mat(_retval_);

	}



	//
	//  Mat Mat::inv(int method = DECOMP_LU)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1inv__JI
		(JNIEnv* env, jclass, jlong self, jint method);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1inv__JI
		(JNIEnv* env, jclass, jlong self, jint method)
	{
		static const char method_name[] = "Mat::n_1inv__JI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->inv(method);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1inv__JI
		(Mat* self, int method)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->inv(method);
		return new Mat(_retval_);

	}


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1inv__J
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1inv__J
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1inv__J()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->inv();
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1inv__J
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->inv();
		return new Mat(_retval_);

	}



	//
	//  bool Mat::isContinuous()
	//

	JNIEXPORT jboolean JNICALL Java_org_opencv_core_Mat_n_1isContinuous
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jboolean JNICALL Java_org_opencv_core_Mat_n_1isContinuous
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1isContinuous()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->isContinuous();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT bool core_Mat_n_1isContinuous
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->isContinuous();

	}



	//
	//  bool Mat::isSubmatrix()
	//

	JNIEXPORT jboolean JNICALL Java_org_opencv_core_Mat_n_1isSubmatrix
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jboolean JNICALL Java_org_opencv_core_Mat_n_1isSubmatrix
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1isSubmatrix()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->isSubmatrix();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT bool core_Mat_n_1isSubmatrix
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->isSubmatrix();

	}



	//
	//  void Mat::locateROI(Size wholeSize, Point ofs)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_locateROI_10
		(JNIEnv* env, jclass, jlong self, jdoubleArray wholeSize_out, jdoubleArray ofs_out);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_locateROI_10
		(JNIEnv* env, jclass, jlong self, jdoubleArray wholeSize_out, jdoubleArray ofs_out)
	{
		static const char method_name[] = "core::locateROI_10()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Size wholeSize;
			Point ofs;
			me->locateROI(wholeSize, ofs);
			jdouble tmp_wholeSize[2] = { (jdouble)wholeSize.width, (jdouble)wholeSize.height }; env->SetDoubleArrayRegion(wholeSize_out, 0, 2, tmp_wholeSize);  jdouble tmp_ofs[2] = { (jdouble)ofs.x, (jdouble)ofs.y }; env->SetDoubleArrayRegion(ofs_out, 0, 2, tmp_ofs);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}


	JNIEXPORT void core_Mat_locateROI_10
		(Mat* self, double* wholeSize_out, double* ofs_out)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Size wholeSize;
		Point ofs;
		me->locateROI(wholeSize, ofs);
		wholeSize_out[0] = wholeSize.width;
		wholeSize_out[1] = wholeSize.height;
		ofs_out[0] = ofs.x;
		ofs_out[1] = ofs.y;
	}




	//
	//  Mat Mat::mul(Mat m, double scale = 1)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1mul__JJD
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jdouble scale);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1mul__JJD
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj, jdouble scale)
	{
		static const char method_name[] = "Mat::n_1mul__JJD()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			Mat _retval_ = me->mul(m, scale);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1mul__JJD
		(Mat* self, Mat* m_nativeObj, double scale)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		Mat _retval_ = me->mul(m, scale);
		return  new Mat(_retval_);

	}



	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1mul__JJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1mul__JJ
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj)
	{
		static const char method_name[] = "Mat::n_1mul__JJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& m = *((Mat*)m_nativeObj);
			Mat _retval_ = me->mul(m);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1mul__JJ
		(Mat* self, Mat* m_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& m = *((Mat*)m_nativeObj);
		Mat _retval_ = me->mul(m);
		return new Mat(_retval_);

	}



	//
	// static Mat Mat::ones(int rows, int cols, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1ones__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1ones__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type)
	{
		static const char method_name[] = "Mat::n_1ones__III()";
		try {
			LOGD("%s", method_name);
			Mat _retval_ = Mat::ones(rows, cols, type);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1ones__III
		(int rows, int cols, int type)
	{

		Mat _retval_ = Mat::ones(rows, cols, type);
		return new Mat(_retval_);

	}



	//
	// static Mat Mat::ones(Size size, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1ones__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1ones__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type)
	{
		static const char method_name[] = "Mat::n_1ones__DDI()";
		try {
			LOGD("%s", method_name);
			Size size((int)size_width, (int)size_height);
			Mat _retval_ = Mat::ones(size, type);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1ones__DDI
		(double size_width, double size_height, int type)
	{

		Size size((int)size_width, (int)size_height);
		Mat _retval_ = Mat::ones(size, type);
		return new Mat(_retval_);

	}



	//
	//  void Mat::push_back(Mat m)
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1push_1back
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1push_1back
		(JNIEnv* env, jclass, jlong self, jlong m_nativeObj)
	{
		static const char method_name[] = "Mat::n_1push_1back()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			me->push_back((*(Mat*)m_nativeObj));
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1push_1back
		(Mat* self, Mat* m_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		me->push_back((*(Mat*)m_nativeObj));

	}



	//
	//  void Mat::release()
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1release
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1release
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1release()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			me->release();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}
	}

	JNIEXPORT void core_Mat_n_1release
		(Mat* self)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		me->release();

	}



	//
	//  Mat Mat::reshape(int cn, int rows = 0)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1reshape__JII
		(JNIEnv* env, jclass, jlong self, jint cn, jint rows);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1reshape__JII
		(JNIEnv* env, jclass, jlong self, jint cn, jint rows)
	{
		static const char method_name[] = "Mat::n_1reshape__JII()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->reshape(cn, rows);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1reshape__JII
		(Mat* self, int cn, int rows)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->reshape(cn, rows);
		return new Mat(_retval_);

	}



	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1reshape__JI
		(JNIEnv* env, jclass, jlong self, jint cn);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1reshape__JI
		(JNIEnv* env, jclass, jlong self, jint cn)
	{
		static const char method_name[] = "Mat::n_1reshape__JI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->reshape(cn);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1reshape__JI
		(Mat* self, int cn)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->reshape(cn);
		return new Mat(_retval_);

	}


	//
	//  Mat Mat::row(int y)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1row
		(JNIEnv* env, jclass, jlong self, jint y);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1row
		(JNIEnv* env, jclass, jlong self, jint y)
	{
		static const char method_name[] = "Mat::n_1row()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->row(y);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1row
		(Mat* self, int y)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->row(y);
		return new Mat(_retval_);

	}


	//
	//  Mat Mat::rowRange(int startrow, int endrow)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1rowRange
		(JNIEnv* env, jclass, jlong self, jint startrow, jint endrow);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1rowRange
		(JNIEnv* env, jclass, jlong self, jint startrow, jint endrow)
	{
		static const char method_name[] = "Mat::n_1rowRange()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->rowRange(startrow, endrow);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1rowRange
		(Mat* self, int startrow, int endrow)
	{
		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->rowRange(startrow, endrow);
		return new Mat(_retval_);

	}


	//
	//  int Mat::rows()
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1rows
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1rows
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1rows()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->rows;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_n_1rows
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->rows;

	}



	//
	//  Mat Mat::operator =(Scalar s)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JDDDD
		(JNIEnv* env, jclass, jlong self, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JDDDD
		(JNIEnv* env, jclass, jlong self, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3)
	{
		static const char method_name[] = "Mat::n_1setTo__JDDDD()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Scalar s(s_val0, s_val1, s_val2, s_val3);
			Mat _retval_ = me->operator =(s);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1setTo__JDDDD
		(Mat* self, double s_val0, double s_val1, double s_val2, double s_val3)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Scalar s(s_val0, s_val1, s_val2, s_val3);
		Mat _retval_ = me->operator =(s);
		return new Mat(_retval_);

	}

	//
	//  Mat Mat::setTo(Scalar value, Mat mask = Mat())
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JDDDDJ
		(JNIEnv* env, jclass, jlong self, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3, jlong mask_nativeObj);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JDDDDJ
		(JNIEnv* env, jclass, jlong self, jdouble s_val0, jdouble s_val1, jdouble s_val2, jdouble s_val3, jlong mask_nativeObj)
	{
		static const char method_name[] = "Mat::n_1setTo__JDDDDJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Scalar s(s_val0, s_val1, s_val2, s_val3);
			Mat& mask = *((Mat*)mask_nativeObj);
			Mat _retval_ = me->setTo(s, mask);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1setTo__JDDDDJ
		(Mat* self, double s_val0, double s_val1, double s_val2, double s_val3, Mat* mask_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Scalar s(s_val0, s_val1, s_val2, s_val3);
		Mat& mask = *((Mat*)mask_nativeObj);
		Mat _retval_ = me->setTo(s, mask);
		return new Mat(_retval_);

	}


	//
	//  Mat Mat::setTo(Mat value, Mat mask = Mat())
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JJJ
		(JNIEnv* env, jclass, jlong self, jlong value_nativeObj, jlong mask_nativeObj);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JJJ
		(JNIEnv* env, jclass, jlong self, jlong value_nativeObj, jlong mask_nativeObj)
	{
		static const char method_name[] = "Mat::n_1setTo__JJJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& value = *((Mat*)value_nativeObj);
			Mat& mask = *((Mat*)mask_nativeObj);
			Mat _retval_ = me->setTo(value, mask);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1setTo__JJJ
		(Mat* self, Mat* value_nativeObj, Mat* mask_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& value = *((Mat*)value_nativeObj);
		Mat& mask = *((Mat*)mask_nativeObj);
		Mat _retval_ = me->setTo(value, mask);
		return new Mat(_retval_);

	}


	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JJ
		(JNIEnv* env, jclass, jlong self, jlong value_nativeObj);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1setTo__JJ
		(JNIEnv* env, jclass, jlong self, jlong value_nativeObj)
	{
		static const char method_name[] = "Mat::n_1setTo__JJ()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat& value = *((Mat*)value_nativeObj);
			Mat _retval_ = me->setTo(value);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1setTo__JJ
		(Mat* self, Mat* value_nativeObj)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat& value = *((Mat*)value_nativeObj);
		Mat _retval_ = me->setTo(value);
		return new Mat(_retval_);

	}



	//
	//  Size Mat::size()
	//

	JNIEXPORT jdoubleArray JNICALL Java_org_opencv_core_Mat_n_1size
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jdoubleArray JNICALL Java_org_opencv_core_Mat_n_1size
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1size()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Size _retval_ = me->size();
			jdoubleArray _da_retval_ = env->NewDoubleArray(2);
			jdouble _tmp_retval_[2] = { (jdouble)_retval_.width, (jdouble)_retval_.height };
			env->SetDoubleArrayRegion(_da_retval_, 0, 2, _tmp_retval_);
			return _da_retval_;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT void core_Mat_n_1size
		(Mat* self, double* vals)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Size _retval_ = me->size();
		vals[0] = _retval_.width;
		vals[1] = _retval_.height;

	}



	//
	//  size_t Mat::step1(int i = 0)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1step1__JI
		(JNIEnv* env, jclass, jlong self, jint i);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1step1__JI
		(JNIEnv* env, jclass, jlong self, jint i)
	{
		static const char method_name[] = "Mat::n_1step1__JI()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->step1(i);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT long core_Mat_n_1step1__JI
		(Mat* self, int i)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->step1(i);

	}



	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1step1__J
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1step1__J
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1step1__J()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->step1();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT long core_Mat_n_1step1__J
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->step1();

	}
	//
	//  Mat Mat::operator()(Range rowRange, Range colRange)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1submat_1rr
		(JNIEnv* env, jclass, jlong self, jint rowRange_start, jint rowRange_end, jint colRange_start, jint colRange_end);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1submat_1rr
		(JNIEnv* env, jclass, jlong self, jint rowRange_start, jint rowRange_end, jint colRange_start, jint colRange_end)
	{
		static const char method_name[] = "Mat::n_1submat_1rr()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Range rowRange(rowRange_start, rowRange_end);
			Range colRange(colRange_start, colRange_end);
			Mat _retval_ = me->operator()(rowRange, colRange);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1submat_1rr
		(Mat* self, int rowRange_start, int rowRange_end, int colRange_start, int colRange_end)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Range rowRange(rowRange_start, rowRange_end);
		Range colRange(colRange_start, colRange_end);
		Mat _retval_ = me->operator()(rowRange, colRange);
		return new Mat(_retval_);

	}



	//
	//  Mat Mat::operator()(Rect roi)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1submat
		(JNIEnv* env, jclass, jlong self, jint roi_x, jint roi_y, jint roi_width, jint roi_height);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1submat
		(JNIEnv* env, jclass, jlong self, jint roi_x, jint roi_y, jint roi_width, jint roi_height)
	{
		static const char method_name[] = "Mat::n_1submat()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Rect roi(roi_x, roi_y, roi_width, roi_height);
			Mat _retval_ = me->operator()(roi);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT Mat* core_Mat_n_1submat
		(Mat* self, int roi_x, int roi_y, int roi_width, int roi_height)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Rect roi(roi_x, roi_y, roi_width, roi_height);
		Mat _retval_ = me->operator()(roi);
		return  new Mat(_retval_);

	}



	//
	//  Mat Mat::t()
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1t
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1t
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1t()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			Mat _retval_ = me->t();
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1t
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		Mat _retval_ = me->t();
		return new Mat(_retval_);

	}

	//
	//  size_t Mat::total()
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1total
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1total
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1total()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->total();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT long core_Mat_n_1total
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->total();

	}




	//
	//  int Mat::type()
	//

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1type
		(JNIEnv* env, jclass, jlong self);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_n_1type
		(JNIEnv* env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::n_1type()";
		try {
			LOGD("%s", method_name);
			Mat* me = (Mat*)self; //TODO: check for NULL
			return me->type();
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_n_1type
		(Mat* self)
	{

		Mat* me = (Mat*)self; //TODO: check for NULL
		return me->type();

	}



	//
	// static Mat Mat::zeros(int rows, int cols, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1zeros__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1zeros__III
		(JNIEnv* env, jclass, jint rows, jint cols, jint type)
	{
		static const char method_name[] = "Mat::n_1zeros__III()";
		try {
			LOGD("%s", method_name);
			Mat _retval_ = Mat::zeros(rows, cols, type);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1zeros__III
		(int rows, int cols, int type)
	{

		Mat _retval_ = Mat::zeros(rows, cols, type);
		return new Mat(_retval_);

	}


	//
	// static Mat Mat::zeros(Size size, int type)
	//

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1zeros__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type);

	JNIEXPORT jlong JNICALL Java_org_opencv_core_Mat_n_1zeros__DDI
		(JNIEnv* env, jclass, jdouble size_width, jdouble size_height, jint type)
	{
		static const char method_name[] = "Mat::n_1zeros__DDI()";
		try {
			LOGD("%s", method_name);
			Size size((int)size_width, (int)size_height);
			Mat _retval_ = Mat::zeros(size, type);
			return (jlong) new Mat(_retval_);
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT Mat* core_Mat_n_1zeros__DDI
		(double size_width, double size_height, int type)
	{

		Size size((int)size_width, (int)size_height);
		Mat _retval_ = Mat::zeros(size, type);
		return new Mat(_retval_);

	}


	//
	//  native support for java finalize()
	//  static void Mat::n_delete( __int64 self )
	//

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1delete
		(JNIEnv*, jclass, jlong self);

	JNIEXPORT void JNICALL Java_org_opencv_core_Mat_n_1delete
		(JNIEnv*, jclass, jlong self)
	{
		delete (Mat*)self;
	}

	JNIEXPORT void core_Mat_n_1delete
		(Mat* self)
	{
		delete (Mat*)self;
	}

	// unlike other nPut()-s this one (with double[]) should convert input values to correct type
#define PUT_ITEM(T, R, C) { T*dst = (T*)me->ptr(R, C); for(int ch=0; ch<me->channels() && count>0; count--,ch++,src++,dst++) *dst = cv::saturate_cast<T>(*src); }

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutD
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jdoubleArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutD
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jdoubleArray vals)
	{
		static const char method_name[] = "Mat::nPutD()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!me || !me->data) return 0;  // no native object behind
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			int rest = ((me->rows - row) * me->cols - col) * me->channels();
			if (count > rest) count = rest;
			int res = count;
			double* values = (double*)env->GetPrimitiveArrayCritical(vals, 0);
			double* src = values;
			int r, c;
			for (c = col; c < me->cols && count>0; c++)
			{
				switch (me->depth()) {
				case CV_8U:  PUT_ITEM(uchar, row, c); break;
				case CV_8S:  PUT_ITEM(schar, row, c); break;
				case CV_16U: PUT_ITEM(ushort, row, c); break;
				case CV_16S: PUT_ITEM(short, row, c); break;
				case CV_32S: PUT_ITEM(int, row, c); break;
				case CV_32F: PUT_ITEM(float, row, c); break;
				case CV_64F: PUT_ITEM(double, row, c); break;
				}
			}

			for (r = row + 1; r < me->rows && count>0; r++)
				for (c = 0; c < me->cols && count>0; c++)
				{
					switch (me->depth()) {
					case CV_8U:  PUT_ITEM(uchar, r, c); break;
					case CV_8S:  PUT_ITEM(schar, r, c); break;
					case CV_16U: PUT_ITEM(ushort, r, c); break;
					case CV_16S: PUT_ITEM(short, r, c); break;
					case CV_32S: PUT_ITEM(int, r, c); break;
					case CV_32F: PUT_ITEM(float, r, c); break;
					case CV_64F: PUT_ITEM(double, r, c); break;
					}
				}

			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT int core_Mat_nPutD
		(Mat* self, int row, int col, int count, double* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!me || !me->data) return 0;  // no native object behind
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		int rest = ((me->rows - row) * me->cols - col) * me->channels();
		if (count > rest) count = rest;
		int res = count;
		double* values = vals;
		double* src = values;
		int r, c;
		for (c = col; c < me->cols && count>0; c++)
		{
			switch (me->depth()) {
			case CV_8U:  PUT_ITEM(uchar, row, c); break;
			case CV_8S:  PUT_ITEM(schar, row, c); break;
			case CV_16U: PUT_ITEM(ushort, row, c); break;
			case CV_16S: PUT_ITEM(short, row, c); break;
			case CV_32S: PUT_ITEM(int, row, c); break;
			case CV_32F: PUT_ITEM(float, row, c); break;
			case CV_64F: PUT_ITEM(double, row, c); break;
			}
		}

		for (r = row + 1; r < me->rows && count>0; r++)
			for (c = 0; c < me->cols && count>0; c++)
			{
				switch (me->depth()) {
				case CV_8U:  PUT_ITEM(uchar, r, c); break;
				case CV_8S:  PUT_ITEM(schar, r, c); break;
				case CV_16U: PUT_ITEM(ushort, r, c); break;
				case CV_16S: PUT_ITEM(short, r, c); break;
				case CV_32S: PUT_ITEM(int, r, c); break;
				case CV_32F: PUT_ITEM(float, r, c); break;
				case CV_64F: PUT_ITEM(double, r, c); break;
				}
			}


		return res;

	}


} // extern "C"

template<typename T> static int mat_put(cv::Mat* m, int row, int col, int count, char* buff)
{
	if (!m) return 0;
	if (!buff) return 0;

	count *= sizeof(T);
	int rest = ((m->rows - row) * m->cols - col) * (int)m->elemSize();
	if (count > rest) count = rest;
	int res = count;

	if (m->isContinuous())
	{
		memcpy(m->ptr(row, col), buff, count);
	}
	else {
		// row by row
		int num = (m->cols - col) * (int)m->elemSize(); // 1st partial row
		if (count < num) num = count;
		uchar* data = m->ptr(row++, col);
		while (count > 0) {
			memcpy(data, buff, num);
			count -= num;
			buff += num;
			num = m->cols * (int)m->elemSize();
			if (count < num) num = count;
			data = m->ptr(row++, 0);
		}
	}
	return res;
}


extern "C" {

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutB
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jbyteArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutB
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jbyteArray vals)
	{
		static const char method_name[] = "Mat::nPutB()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_8U && me->depth() != CV_8S) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_put<char>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT int core_Mat_nPutB
		(Mat* self, int row, int col, int count, char* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_8U && me->depth() != CV_8S) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_put<char>(me, row, col, count, values);

		return res;

	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutS
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jshortArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutS
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jshortArray vals)
	{
		static const char method_name[] = "Mat::nPutS()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_16U && me->depth() != CV_16S) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_put<short>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nPutS
		(Mat* self, int row, int col, int count, short* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_16U && me->depth() != CV_16S) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_put<short>(me, row, col, count, values);

		return res;

	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutI
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jintArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutI
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jintArray vals)
	{
		static const char method_name[] = "Mat::nPutI()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_32S) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_put<int>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}


	JNIEXPORT int core_Mat_nPutI
		(Mat* self, int row, int col, int count, int* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_32S) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_put<int>(me, row, col, count, values);
		return res;

	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutF
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jfloatArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nPutF
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jfloatArray vals)
	{
		static const char method_name[] = "Mat::nPutF()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_32F) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_put<float>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nPutF
		(Mat* self, int row, int col, int count, float* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_32F) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_put<float>(me, row, col, count, values);
		return res;

	}


} // extern "C"

template<typename T> int mat_get(cv::Mat* m, int row, int col, int count, char* buff)
{
	if (!m) return 0;
	if (!buff) return 0;

	int bytesToCopy = count * sizeof(T);
	int bytesRestInMat = ((m->rows - row) * m->cols - col) * (int)m->elemSize();
	if (bytesToCopy > bytesRestInMat) bytesToCopy = bytesRestInMat;
	int res = bytesToCopy;

	if (m->isContinuous())
	{
		memcpy(buff, m->ptr(row, col), bytesToCopy);
	}
	else {
		// row by row
		int bytesInRow = (m->cols - col) * (int)m->elemSize(); // 1st partial row
		while (bytesToCopy > 0)
		{
			int len = std::min(bytesToCopy, bytesInRow);
			memcpy(buff, m->ptr(row, col), len);
			bytesToCopy -= len;
			buff += len;
			row++;
			col = 0;
			bytesInRow = m->cols * (int)m->elemSize();
		}
	}
	return res;
}

extern "C" {

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetB
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jbyteArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetB
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jbyteArray vals)
	{
		static const char method_name[] = "Mat::nGetB()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_8U && me->depth() != CV_8S) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_get<char>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nGetB
		(Mat* self, int row, int col, int count, char* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_8U && me->depth() != CV_8S) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_get<char>(me, row, col, count, values);

		return res;

	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetS
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jshortArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetS
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jshortArray vals)
	{
		static const char method_name[] = "Mat::nGetS()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_16U && me->depth() != CV_16S) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_get<short>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nGetS
		(Mat* self, int row, int col, int count, short* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_16U && me->depth() != CV_16S) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_get<short>(me, row, col, count, values);
		return res;

	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetI
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jintArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetI
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jintArray vals)
	{
		static const char method_name[] = "Mat::nGetI()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_32S) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_get<int>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nGetI
		(Mat* self, int row, int col, int count, int* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_32S) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_get<int>(me, row, col, count, values);
		return res;

	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetF
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jfloatArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetF
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jfloatArray vals)
	{
		static const char method_name[] = "Mat::nGetF()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_32F) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_get<float>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nGetF
		(Mat* self, int row, int col, int count, float* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_32F) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_get<float>(me, row, col, count, values);
		return res;


	}

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetD
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jdoubleArray vals);

	JNIEXPORT jint JNICALL Java_org_opencv_core_Mat_nGetD
		(JNIEnv* env, jclass, jlong self, jint row, jint col, jint count, jdoubleArray vals)
	{
		static const char method_name[] = "Mat::nGetD()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->depth() != CV_64F) return 0; // incompatible type
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			char* values = (char*)env->GetPrimitiveArrayCritical(vals, 0);
			int res = mat_get<double>(me, row, col, count, values);
			env->ReleasePrimitiveArrayCritical(vals, values, 0);
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nGetD
		(Mat* self, int row, int col, int count, double* vals)
	{

		cv::Mat* me = (cv::Mat*) self;
		if (!self) return 0; // no native object behind
		if (me->depth() != CV_64F) return 0; // incompatible type
		if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

		char* values = (char*)vals;
		int res = mat_get<double>(me, row, col, count, values);

		return res;

	}

	JNIEXPORT jdoubleArray JNICALL Java_org_opencv_core_Mat_nGet
		(JNIEnv* env, jclass, jlong self, jint row, jint col);

	JNIEXPORT jdoubleArray JNICALL Java_org_opencv_core_Mat_nGet
		(JNIEnv* env, jclass, jlong self, jint row, jint col)
	{
		static const char method_name[] = "Mat::nGet()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self;
			if (!self) return 0; // no native object behind
			if (me->rows <= row || me->cols <= col) return 0; // indexes out of range

			jdoubleArray res = env->NewDoubleArray(me->channels());
			if (res) {
				jdouble buff[CV_CN_MAX];//me->channels()
				int i;
				switch (me->depth()) {
				case CV_8U:  for (i = 0; i < me->channels(); i++) buff[i] = *((unsigned char*)me->ptr(row, col) + i); break;
				case CV_8S:  for (i = 0; i < me->channels(); i++) buff[i] = *((signed char*)me->ptr(row, col) + i); break;
				case CV_16U: for (i = 0; i < me->channels(); i++) buff[i] = *((unsigned short*)me->ptr(row, col) + i); break;
				case CV_16S: for (i = 0; i < me->channels(); i++) buff[i] = *((signed short*)me->ptr(row, col) + i); break;
				case CV_32S: for (i = 0; i < me->channels(); i++) buff[i] = *((int*)me->ptr(row, col) + i); break;
				case CV_32F: for (i = 0; i < me->channels(); i++) buff[i] = *((float*)me->ptr(row, col) + i); break;
				case CV_64F: for (i = 0; i < me->channels(); i++) buff[i] = *((double*)me->ptr(row, col) + i); break;
				}
				env->SetDoubleArrayRegion(res, 0, me->channels(), buff);
			}
			return res;
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}

	JNIEXPORT int core_Mat_nGet(Mat* self, int row, int col, int count, double* vals)
	{
		if (!self) return 0; // no native object behind
		if (self->rows <= row || self->cols <= col) return 0; // indexes out of range

		int res = self->channels();
		if (res) {
			double buff[CV_CN_MAX];//me->channels()
			int i;
			switch (self->depth()) {
			case CV_8U:  for (i = 0; i < self->channels(); i++) vals[i] = *((unsigned char*)self->ptr(row, col) + i); break;
			case CV_8S:  for (i = 0; i < self->channels(); i++) vals[i] = *((signed char*)self->ptr(row, col) + i); break;
			case CV_16U: for (i = 0; i < self->channels(); i++) vals[i] = *((unsigned short*)self->ptr(row, col) + i); break;
			case CV_16S: for (i = 0; i < self->channels(); i++) vals[i] = *((signed short*)self->ptr(row, col) + i); break;
			case CV_32S: for (i = 0; i < self->channels(); i++) vals[i] = *((int*)self->ptr(row, col) + i); break;
			case CV_32F: for (i = 0; i < self->channels(); i++) vals[i] = *((float*)self->ptr(row, col) + i); break;
			case CV_64F: for (i = 0; i < self->channels(); i++) vals[i] = *((double*)self->ptr(row, col) + i); break;
			}
		}
		return res;
	}

	JNIEXPORT const char* opencvunity_core_Mat_nDump(Mat* self)
	{
		String s;
		Ptr<Formatted> fmtd = Formatter::get()->format(*self);
		for (const char* str = fmtd->next(); str; str = fmtd->next())
		{
			s = s + String(str);
		}
		const char* dump = s.c_str();
		return dump;
	}

	JNIEXPORT jstring JNICALL Java_org_opencv_core_Mat_nDump
		(JNIEnv *env, jclass, jlong self);

	JNIEXPORT jstring JNICALL Java_org_opencv_core_Mat_nDump
		(JNIEnv *env, jclass, jlong self)
	{
		static const char method_name[] = "Mat::nDump()";
		try {
			LOGD("%s", method_name);
			cv::Mat* me = (cv::Mat*) self; //TODO: check for NULL
			String s;
			Ptr<Formatted> fmtd = Formatter::get()->format(*me);
			for (const char* str = fmtd->next(); str; str = fmtd->next())
			{
				s = s + String(str);
			}
			return env->NewStringUTF(s.c_str());
		}
		catch (const std::exception &e) {
			throwJavaException(env, &e, method_name);
		}
		catch (...) {
			throwJavaException(env, 0, method_name);
		}

		return 0;
	}




} // extern "C"
