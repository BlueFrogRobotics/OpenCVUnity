#ifndef QRCODE_HPP
#define QRCODE_HPP

#include <cstdlib>
#include <algorithm>

#include "opencv2\core\mat.hpp"
#include "opencv2\core\base.hpp"
#include "opencv2\core\utility.hpp"
#include "opencv2\core\operations.hpp"
#include "converters.hpp"

#include "..\..\imgproc\include\opencv2\imgproc.hpp"
#include "opencv2\highgui.hpp"
#include "opencv2\ml.hpp"
#include "opencv2\core.hpp"
#include "opencv2\objdetect.hpp"
#include "opencv2\imgcodecs.hpp"
#include "opencv2\videoio.hpp"
#include "opencv2\hal.hpp"

namespace cv {
	const int CV_QR_NORTH = 0;
	const int CV_QR_EAST = 1;
	const int CV_QR_SOUTH = 2;
	const int CV_QR_WEST = 3;

	const char* qrCode_decode(Mat& qrcode);
	void qrCode(Mat& image, std::vector<Mat>& correctedimage, std::vector<Point2f>& iVec);
	float computeDistance(Point2f iFirstPoint, Point2f iSecondPoint);
	float lineEquation(Point2f iFirstPoint, Point2f iSecondPoint, Point2f iThirdPoint);
	float lineSlope(Point2f iFirstPoint, Point2f iSecondPoint, int& alignement);
	void getVertices(std::vector<std::vector<Point>> contours, int c_id, float slope, std::vector<Point2f>& X);
	void updateCorner(Point2f iFirstPoint, Point2f iSecondPoint, float& baseline, Point2f& corner);
	void updateCornerOr(int orientation, std::vector<Point2f> IN, std::vector<Point2f> &OUT);
	bool getIntersectionPoint(Point2f a1, Point2f a2, Point2f b1, Point2f b2, Point2f& intersection);
	float cross(Point2f v1, Point2f v2);
}

#endif