#include "opencv2\contrib\qrcodereader.hpp"

namespace cv {

	const char* qrCode_decode(Mat& iImage) {
		return "null";
	}

	void qrCode(Mat& iImage, std::vector<Mat>& iQRCodeImages, std::vector<Point2f>& iQRCodePoints)
	{
		Mat lImageGray(iImage.size(), CV_MAKETYPE(iImage.depth(), 1));
		Mat lImageEdges(iImage.size(), CV_MAKETYPE(iImage.depth(), 1));
		Mat lQR, lQRRaw, lQRGray, lQRCorrected;

		std::vector<int> lDetectedMarks;
		std::vector<Vec3i> lQRCodeMarks;
		std::vector<Vec4i> lHierarchy;
		std::vector<std::vector<Point> > lContours;
		std::vector<std::pair<Vec3i, Point2i> > lMarkCombinaisons;

		int A, B, C, top, right, bottom, median1, median2, outlier;
		float AB, BC, CA, dist, slope;
		int align, orientation;
		int key = 0;
		int mark = 0;

		lQRRaw = Mat::zeros(100, 100, CV_8UC3);
		lQR = Mat::zeros(100, 100, CV_8UC3);
		lQRGray = Mat::zeros(100, 100, CV_8UC1);
		lQRCorrected = Mat::zeros(100, 100, CV_8UC1);

		cvtColor(iImage, lImageGray, COLOR_RGB2GRAY);
		Canny(lImageGray, lImageEdges, 100, 200, 3);
		//adaptiveThreshold(mGrayScaleMat, mGrayScaleMat,
		//                          255, Imgproc.ADAPTIVE_THRESH_GAUSSIAN_C, Imgproc.THRESH_BINARY_INV, 21, -11);
		//threshold(mGrayScaleMat, mGrayScaleMat, 0, 255, Imgproc.THRESH_BINARY | Imgproc.THRESH_OTSU);
		findContours(lImageEdges, lContours, lHierarchy, RETR_TREE, CHAIN_APPROX_SIMPLE);

		std::vector<Moments> lMoments(lContours.size());
		std::vector<Point2f> lMassCenters(lContours.size());

		for (int i = 0; i < lContours.size(); i++) {
			lMoments[i] = moments(lContours[i], false);
			lMassCenters[i] = Point2f(lMoments[i].m10 / lMoments[i].m00, lMoments[i].m01 / lMoments[i].m00);
		}

		for (int i = 0; i < lContours.size(); i++) {
			int lIndexChild = i;
			int lLayer = 0;

			while (lHierarchy[lIndexChild][2] != -1) {
				lIndexChild = lHierarchy[lIndexChild][2];
				++lLayer;
			}
			if (lHierarchy[lIndexChild][2] != -1)
				++lLayer;

			if (lLayer >= 5) {
				if (mark == 0) {
					lDetectedMarks.push_back(i);
					++mark;
				}
				else if (mark == 1) {
					lDetectedMarks.push_back(i);
					++mark;
				}
				else if (mark == 2) {
					lDetectedMarks.push_back(i);
					mark = 0;
				}
			}
		}
		if (lDetectedMarks.size() > 3) {
			lMarkCombinaisons.reserve(lDetectedMarks.size() * 3);
			//int lTreshold = 68000;
			int lTreshold = 76000;
			int lMarge = 30;
			bool lEndOfDetection = false;
			for (int lFirstInd = 0; lFirstInd < lDetectedMarks.size(); ++lFirstInd) {
				int firstContourID = lDetectedMarks[lFirstInd];
				for (int lSecondInd = 0; lSecondInd < lDetectedMarks.size(); ++lSecondInd) {
					int secondContourID = lDetectedMarks[lSecondInd];
					for (int lThirdInd = 0; lThirdInd < lDetectedMarks.size(); ++lThirdInd) {
						int thirdContourID = lDetectedMarks[lThirdInd];
						if (firstContourID != secondContourID
							&& firstContourID != thirdContourID
							&& secondContourID != thirdContourID) {
							bool lCombinaisonAlreadyExist = false;
							for (int lCombInd = 0; lCombInd < lMarkCombinaisons.size(); ++lCombInd) {
								std::pair<Vec3i, Point2i> lPair = lMarkCombinaisons[lCombInd];
								Vec3i lExistingCombinaison = lPair.first;
								if ((lExistingCombinaison.val[0] == firstContourID
									&& lExistingCombinaison.val[1] == secondContourID
									&& lExistingCombinaison.val[2] == thirdContourID)
									|| (lExistingCombinaison.val[0] == firstContourID
										&& lExistingCombinaison.val[1] == thirdContourID
										&& lExistingCombinaison.val[2] == secondContourID)
									|| (lExistingCombinaison.val[0] == secondContourID
										&& lExistingCombinaison.val[1] == firstContourID
										&& lExistingCombinaison.val[2] == thirdContourID)
									|| (lExistingCombinaison.val[0] == secondContourID
										&& lExistingCombinaison.val[1] == thirdContourID
										&& lExistingCombinaison.val[2] == firstContourID)
									|| (lExistingCombinaison.val[0] == thirdContourID
										&& lExistingCombinaison.val[1] == secondContourID
										&& lExistingCombinaison.val[2] == firstContourID)
									|| (lExistingCombinaison.val[0] == thirdContourID
										&& lExistingCombinaison.val[1] == firstContourID
										&& lExistingCombinaison.val[2] == secondContourID)) {
									lCombinaisonAlreadyExist = true;
									break;
								}
							}
							if (!lCombinaisonAlreadyExist) {
								Point2i lFirstPt = lMassCenters[firstContourID];
								Point2i lSecondPt = lMassCenters[secondContourID];
								Point2i lThirdPt = lMassCenters[thirdContourID];
								Point2i lMeanPt((lFirstPt.x + lSecondPt.x + lThirdPt.x) / 3, (lFirstPt.y + lSecondPt.y + lThirdPt.y) / 3);
								lMarkCombinaisons.push_back(std::make_pair(Vec3i(firstContourID, secondContourID, thirdContourID), lMeanPt));
								int lShining = 0;
								int lBegRow = std::max(0, lMeanPt.y - lMarge);
								int lEndRow = std::min(lImageEdges.rows - 1, lMeanPt.y + lMarge);
								int lBegCol = std::max(0, lMeanPt.x - lMarge);
								int lEndCol = std::min(lImageEdges.cols - 1, lMeanPt.x + lMarge);
								for (int row = lBegRow; row <= lEndRow; ++row)
									for (int col = lBegCol; col <= lEndCol; ++col)
										lShining += lImageEdges.at<uchar>(row, col);
								if (lShining > lTreshold) {
									lQRCodeMarks.push_back(Vec3i(firstContourID, secondContourID, thirdContourID));
									if (lQRCodeMarks.size() == lDetectedMarks.size() / 3)
										lEndOfDetection = true;
								}
							}
						}
						if (lEndOfDetection) break;
					}
					if (lEndOfDetection) break;
				}
				if (lEndOfDetection) break;
			}
		}
		else if (lDetectedMarks.size() == 3) {
			lQRCodeMarks.push_back(Vec3i(lDetectedMarks.at(0), lDetectedMarks.at(1), lDetectedMarks.at(2)));
		}

		for (int lIndVec = 0; lIndVec < lQRCodeMarks.size(); ++lIndVec) {
			Vec3i vec = lQRCodeMarks[lIndVec];
			if (vec.val[2] != -1) {
				A = vec.val[0];
				B = vec.val[1];
				C = vec.val[2];

				AB = computeDistance(lMassCenters[A], lMassCenters[B]);
				BC = computeDistance(lMassCenters[B], lMassCenters[C]);
				CA = computeDistance(lMassCenters[C], lMassCenters[A]);

				if (AB > BC && AB > CA) {
					outlier = C; median1 = A; median2 = B;
				}
				else if (CA > AB && CA > BC) {
					outlier = B; median1 = A; median2 = C;
				}
				else if (BC > AB && BC > CA) {
					outlier = A;  median1 = B; median2 = C;
				}

				top = outlier;
				dist = lineEquation(lMassCenters[median1], lMassCenters[median2], lMassCenters[outlier]);
				slope = lineSlope(lMassCenters[median1], lMassCenters[median2], align);

				if (align == 0) {
					bottom = median1;
					right = median2;
				}
				else if (slope < 0 && dist < 0) {
					bottom = median1;
					right = median2;
					orientation = CV_QR_NORTH;
				}
				else if (slope > 0 && dist < 0) {
					right = median1;
					bottom = median2;
					orientation = CV_QR_EAST;
				}
				else if (slope < 0 && dist > 0) {
					right = median1;
					bottom = median2;
					orientation = CV_QR_SOUTH;
				}
				else if (slope > 0 && dist > 0) {
					bottom = median1;
					right = median2;
					orientation = CV_QR_WEST;
				}

				if (top < lContours.size()
					&& right < lContours.size()
					&& bottom < lContours.size()
					&& contourArea(lContours[top]) > 10
					&& contourArea(lContours[right]) > 10
					&& contourArea(lContours[bottom]) > 10) {
					std::vector<Point2f> L, M, O, tempL, tempM, tempO;
					Point2f N;
					std::vector<Point2f> src, dst;
					Mat warp_matrix;

					getVertices(lContours, top, slope, tempL);
					getVertices(lContours, right, slope, tempM);
					getVertices(lContours, bottom, slope, tempO);

					updateCornerOr(orientation, tempL, L);
					updateCornerOr(orientation, tempM, M);
					updateCornerOr(orientation, tempO, O);

					int iflag = getIntersectionPoint(M[1], M[2], O[3], O[2], N);

					src.push_back(L[0]);
					src.push_back(M[1]);
					src.push_back(N);
					src.push_back(O[3]);

					dst.push_back(Point2f(0, 0));
					dst.push_back(Point2f(lQR.cols, 0));
					dst.push_back(Point2f(lQR.cols, lQR.rows));
					dst.push_back(Point2f(0, lQR.rows));

					if (src.size() == 4 && dst.size() == 4) {
						warp_matrix = getPerspectiveTransform(src, dst);
						warpPerspective(iImage, lQRRaw, warp_matrix, Size(lQR.cols, lQR.rows));
						copyMakeBorder(lQRRaw, lQR, 10, 10, 10, 10, BORDER_CONSTANT, Scalar(255, 255, 255));

						cvtColor(lQR, lQRGray, COLOR_RGB2GRAY);
						threshold(lQRGray, lQRCorrected, 127, 255, THRESH_BINARY);

						iQRCodePoints.reserve(iQRCodePoints.size() + 13);
						int i = 0;
						for (i = 0; i < 4; ++i)
							iQRCodePoints.push_back(L[i]);
						for (i = 0; i < 4; ++i)
							iQRCodePoints.push_back(M[i]);
						iQRCodePoints.push_back(N);
						for (i = 0; i < 4; ++i)
							iQRCodePoints.push_back(O[i]);

						iQRCodeImages.push_back(lQRCorrected);
					}
				}
			}
		}
	}

	// Gets distance between two points
	float computeDistance(Point2f iFirstPoint, Point2f iSecondPoint)
	{
		return sqrt(pow(abs(iFirstPoint.x - iSecondPoint.x), 2) + pow(abs(iFirstPoint.y - iSecondPoint.y), 2));
	}

	// Perpendicular distance of firstpt from line formed by Points second and third; Equation of the line ax+by+c=0
	float lineEquation(Point2f iFirstPoint, Point2f iSecondPoint, Point2f iThirdPoint)
	{
		float a, b, c, pdist;
		a = -((iSecondPoint.y - iFirstPoint.y) / (iSecondPoint.x - iFirstPoint.x));
		b = 1.0;
		c = (((iSecondPoint.y - iFirstPoint.y) / (iSecondPoint.x - iFirstPoint.x)) * iFirstPoint.x) - iFirstPoint.y;
		pdist = (a * iThirdPoint.x + (b * iThirdPoint.y) + c) / sqrt((a * a) + (b * b));
		return pdist;
	}

	// Slope of a line by two Points first and second on it; Slope of line, S = (x1 -x2) / (y1- y2)
	float lineSlope(Point2f iFirstPoint, Point2f iSecondPoint, int& iAlignement)
	{
		float dx, dy;
		dx = iSecondPoint.x - iFirstPoint.x;
		dy = iSecondPoint.y - iFirstPoint.y;

		if (dy != 0) {
			iAlignement = 1;
			return (dy / dx);
		}
		else {
			iAlignement = 0;
			return 0.0;
		}
	}

	// Computes 4 Corners of the Marker in Image Space using Region partitioning
	void getVertices(std::vector<std::vector<Point> > iContours, int iID, float iSlop, std::vector<Point2f>& iQuad)
	{
		Rect box;
		box = boundingRect(iContours[iID]);

		Point2f M0, M1, M2, M3;
		Point2f A, B, C, D, W, X, Y, Z;

		A = box.tl();
		B.x = box.br().x;
		B.y = box.tl().y;
		C = box.br();
		D.x = box.tl().x;
		D.y = box.br().y;


		W.x = (A.x + B.x) / 2;
		W.y = A.y;

		X.x = B.x;
		X.y = (B.y + C.y) / 2;

		Y.x = (C.x + D.x) / 2;
		Y.y = C.y;

		Z.x = D.x;
		Z.y = (D.y + A.y) / 2;

		float dmax[4];
		dmax[0] = 0.0;
		dmax[1] = 0.0;
		dmax[2] = 0.0;
		dmax[3] = 0.0;

		float pd1 = 0.0;
		float pd2 = 0.0;

		if (iSlop > 5 || iSlop < -5) {
			for (int i = 0; i < iContours[iID].size(); i++) {
				pd1 = lineEquation(C, A, iContours[iID][i]);
				pd2 = lineEquation(B, D, iContours[iID][i]);

				if ((pd1 >= 0.0) && (pd2 > 0.0)) {
					updateCorner(iContours[iID][i], W, dmax[1], M1);
				}
				else if ((pd1 > 0.0) && (pd2 <= 0.0)) {
					updateCorner(iContours[iID][i], X, dmax[2], M2);
				}
				else if ((pd1 <= 0.0) && (pd2 < 0.0)) {
					updateCorner(iContours[iID][i], Y, dmax[3], M3);
				}
				else if ((pd1 < 0.0) && (pd2 >= 0.0)) {
					updateCorner(iContours[iID][i], Z, dmax[0], M0);
				}
				else
					continue;
			}
		}
		else
		{
			int halfx = (A.x + B.x) / 2;
			int halfy = (A.y + D.y) / 2;

			for (int i = 0; i < iContours[iID].size(); i++) {
				if ((iContours[iID][i].x < halfx) && (iContours[iID][i].y <= halfy)) {
					updateCorner(iContours[iID][i], C, dmax[2], M0);
				}
				else if ((iContours[iID][i].x >= halfx) && (iContours[iID][i].y < halfy)) {
					updateCorner(iContours[iID][i], D, dmax[3], M1);
				}
				else if ((iContours[iID][i].x > halfx) && (iContours[iID][i].y >= halfy)) {
					updateCorner(iContours[iID][i], A, dmax[0], M2);
				}
				else if ((iContours[iID][i].x <= halfx) && (iContours[iID][i].y > halfy)) {
					updateCorner(iContours[iID][i], B, dmax[1], M3);
				}
			}
		}

		iQuad.push_back(M0);
		iQuad.push_back(M1);
		iQuad.push_back(M2);
		iQuad.push_back(M3);
	}

	// Compares a point if it more far than previously recorded farthest distance
	void updateCorner(Point2f P, Point2f ref, float& baseline, Point2f& corner)
	{
		float temp_dist;
		temp_dist = computeDistance(P, ref);

		if (temp_dist > baseline) {
			baseline = temp_dist;
			corner = P;
		}
	}

	// Sequences the corners wrt to the orientation of the QR Code
	void updateCornerOr(int orientation, std::vector<Point2f> iIN, std::vector<Point2f> &iOUT)
	{
		Point2f M0, M1, M2, M3;
		if (orientation == CV_QR_NORTH) {
			M0 = iIN[0];
			M1 = iIN[1];
			M2 = iIN[2];
			M3 = iIN[3];
		}
		else if (orientation == CV_QR_EAST) {
			M0 = iIN[1];
			M1 = iIN[2];
			M2 = iIN[3];
			M3 = iIN[0];
		}
		else if (orientation == CV_QR_SOUTH) {
			M0 = iIN[2];
			M1 = iIN[3];
			M2 = iIN[0];
			M3 = iIN[1];
		}
		else if (orientation == CV_QR_WEST) {
			M0 = iIN[3];
			M1 = iIN[0];
			M2 = iIN[1];
			M3 = iIN[2];
		}

		iOUT.push_back(M0);
		iOUT.push_back(M1);
		iOUT.push_back(M2);
		iOUT.push_back(M3);
	}

	// Gets the Intersection Point of the lines formed by sets of two points
	bool getIntersectionPoint(Point2f a1, Point2f a2, Point2f b1, Point2f b2, Point2f& intersection)
	{
		Point2f p = a1;
		Point2f q = b1;
		Point2f r(a2 - a1);
		Point2f s(b2 - b1);

		if (cross(r, s) == 0) { return false; }

		float t = cross(q - p, s) / cross(r, s);

		intersection = p + t*r;
		return true;
	}

	float cross(Point2f v1, Point2f v2)
	{
		return v1.x*v2.y - v1.y*v2.x;
	}
}