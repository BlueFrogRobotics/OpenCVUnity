#include "opencv2/contrib.h"
#include "C:\Users\Valentin\Documents\Repository\opencvUnity\OpenCVSources\Sources\modules\java\generator\src\cpp\converters.cpp"

namespace cv {
	
#if WINDOWS_PLATFORM && __cplusplus
	extern "C" {
#endif	
		void opencvunity_objdetect_Objdetect_find_text_10(Mat* img, Mat* rects, int width, int height) {
			std::vector<cv::Rect> boundRect;
			Mat img_gray, img_sobel, img_threshold, element;
			cvtColor(*img, img_gray, COLOR_RGB2GRAY);
			cv::Sobel(img_gray, img_sobel, CV_8U, 1, 0, 3, 1, 0, cv::BORDER_DEFAULT);
			threshold(img_sobel, img_threshold, 0, 255, THRESH_OTSU + THRESH_BINARY);
			element = getStructuringElement(cv::MORPH_RECT, cv::Size(width, height));
			morphologyEx(img_threshold, img_threshold, MORPH_CLOSE, element);
			std::vector< std::vector<Point> > contours;
			findContours(img_threshold, contours, 0, 1);
			std::vector<std::vector<Point> > contours_poly(contours.size());
			for (int i = 0; i < contours.size(); i++)
				if (contours[i].size() > 100)
				{
					approxPolyDP(Mat(contours[i]), contours_poly[i], 3, true);
					Rect appRect(boundingRect(Mat(contours_poly[i])));
					if (appRect.width > appRect.height)
						boundRect.push_back(appRect);
				}
			vector_Rect_to_Mat(boundRect, *rects);
		}

		void opencvunity_objdetect_Objdetect_find_qrCode_10(Mat* image_mat_nativeObj, Mat* qrcodes_mat_nativeObj, Mat* points_mat_nativeObj)
		{
			std::vector<Point2f> pts;
			std::vector<Mat> qrcodes;
			qrCode(*image_mat_nativeObj, qrcodes, pts);
			vector_Mat_to_Mat(qrcodes, *qrcodes_mat_nativeObj);
			vector_Point2f_to_Mat(pts, *points_mat_nativeObj);
		}

		namespace face {

			// LBPHfaces

			LBPH* opencvunity_face_LBPHfaces_LBPHfaces_10() {
				return new LBPH();
			}

			LBPH* opencvunity_face_LBPHfaces_LBPHfaces_11(int radius_, int neighbors_, int gridx, int gridy, double threshold) {
				return new LBPH(radius_, neighbors_, gridx, gridy, threshold);
			}

			void opencvunity_face_LBPHfaces_train_10(LBPH* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->train(data, labels);
			}

			void opencvunity_face_LBPHfaces_update_10(LBPH* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->update(data, labels);
			}

			void opencvunity_face_LBPHfaces_predict_10(LBPH* ff_native_obj, Mat* src_native_obj, PredictCollector* predict, int state) {
				ff_native_obj->predict(*src_native_obj, *predict, state);
			}

			void opencvunity_face_LBPHfaces_delete_10(LBPH* ff_native_obj) {
				delete ff_native_obj;
			}

			void opencvunity_face_LBPHfaces_save_10(LBPH* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::WRITE);
				ff_native_obj->save(fs);
				fs.release();
			}

			void opencvunity_face_LBPHfaces_load_10(LBPH* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::READ);
				ff_native_obj->load(fs);
				fs.release();
			}

			// Fisherfaces

			Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_10() {
				return new Fisherfaces();
			}

			Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_11(int nbcomponents) {
				return new Fisherfaces(nbcomponents);
			}

			Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_12(int nbcomponents, double treshold) {
				return new Fisherfaces(nbcomponents, treshold);
			}

			void opencvunity_face_Fisherfaces_train_10(Fisherfaces* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->train(data, labels);
			}

			void opencvunity_face_Fisherfaces_update_10(Fisherfaces* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->update(data, labels);
			}

			void opencvunity_face_Fisherfaces_predict_10(Fisherfaces* ff_native_obj, Mat* src_native_obj, PredictCollector* predict, int state) {
				ff_native_obj->predict(*src_native_obj, *predict, state);
			}

			Mat* opencvunity_face_Fisherfaces_getEigenValues_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getEigenValues());
			}

			Mat* opencvunity_face_Fisherfaces_getEigenVector_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getEigenVectors());
			}

			Mat* opencvunity_face_Fisherfaces_getLabels_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getLabels());
			}

			Mat* opencvunity_face_Fisherfaces_getLabelsByString_10(Fisherfaces* ff_native_obj, const char* name) {
				std::vector<int> label = ff_native_obj->getLabelsByString(name);
				Mat labelmat;
				vector_int_to_Mat(label, labelmat);
				return new Mat(labelmat);
			}

			void opencvunity_face_Fisherfaces_clear_10(Fisherfaces* ff_native_obj) {
				ff_native_obj->clear();
			}

			Mat* opencvunity_face_Fisherfacess_getMean_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getMean());
			}

			void opencvunity_face_Fisherfaces_setTreshold_10(Fisherfaces* ff_native_obj, double val) {
				ff_native_obj->setThreshold(val);
			}

			double opencvunity_face_Fisherfaces_getTreshold_10(Fisherfaces* ff_native_obj) {
				return ff_native_obj->getThreshold();
			}

			bool opencvunity_face_Fisherfaces_empty_10(Fisherfaces* ff_native_obj) {
				return ff_native_obj->empty();
			}

			Mat* opencvunity_face_Fisherfaces_getProjections_10(Fisherfaces* ff_native_obj) {
				std::vector<Mat> proj = ff_native_obj->getProjections();
				Mat projMat;
				vector_Mat_to_Mat(proj, projMat);
				return new Mat(projMat);
			}

			const char* opencvunity_face_Fisherfaces_getLabelInfo_10(Fisherfaces* ff_native_obj, int label) {
				return ff_native_obj->getLabelInfo(label).c_str();
			}

			int opencvunity_face_Fisherfaces_getNumComponents_10(Fisherfaces* ff_native_obj) {
				return ff_native_obj->getNumComponents();
			}

			void opencvunity_face_Fisherfaces_setNumComponents_10(Fisherfaces* ff_native_obj, int nbcomponent) {
				ff_native_obj->setNumComponents(nbcomponent);
			}

			void opencvunity_face_Fisherfaces_delete_10(Fisherfaces* ff_native_obj) {
				delete ff_native_obj;
			}

			void opencvunity_face_Fisherfaces_save_10(Fisherfaces* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::WRITE);
				ff_native_obj->save(fs);
				fs.release();
			}

			void opencvunity_face_Fisherfaces_load_10(Fisherfaces* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::READ);
				ff_native_obj->load(fs);
				fs.release();
			}

			// Eigenfaces

			Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_10()
			{
				return new Eigenfaces();
			}

			Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_11(int nbcomponents)
			{
				return new Eigenfaces(nbcomponents);
			}

			Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_12(int nbcomponents, double treshold)
			{
				return new Eigenfaces(nbcomponents, treshold);
			}

			void opencvunity_face_Eigenfaces_train_10(Eigenfaces* egf_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				egf_native_obj->train(data, labels);
			}

			void opencvunity_face_Eigenfaces_predict_10(Eigenfaces* egf_native_obj, Mat* src_native_obj, PredictCollector* predict, int state) {
				egf_native_obj->predict(*src_native_obj, *predict, state);
			}

			Mat* opencvunity_face_Eigenfaces_getEigenValues_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getEigenValues());
			}

			Mat* opencvunity_face_Eigenfaces_getEigenVector_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getEigenVectors());
			}

			Mat* opencvunity_face_Eigenfaces_getLabels_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getLabels());
			}

			Mat* opencvunity_face_Eigenfaces_getLabelsByString_10(Eigenfaces* egf_native_obj, const char* name) {
				std::vector<int> label = egf_native_obj->getLabelsByString(name);
				Mat labelmat;
				vector_int_to_Mat(label, labelmat);
				return new Mat(labelmat);
			}

			void opencvunity_face_Eigenfaces_clear_10(Eigenfaces* egf_native_obj) {
				egf_native_obj->clear();
			}

			Mat* opencvunity_face_Eigenfaces_getMean_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getMean());
			}

			void opencvunity_face_Eigenfaces_setTreshold_10(Eigenfaces* egf_native_obj, double val) {
				egf_native_obj->setThreshold(val);
			}

			double opencvunity_face_Eigenfaces_getTreshold_10(Eigenfaces* egf_native_obj) {
				return egf_native_obj->getThreshold();
			}

			void opencvunity_face_Eigenfaces_delete_10(Eigenfaces* egf_native_obj) {
				delete egf_native_obj;
			}

			bool opencvunity_face_Eigenfaces_empty_10(Eigenfaces* egf_native_obj) {
				return egf_native_obj->empty();
			}

			Mat* opencvunity_face_Eigenfaces_getProjections_10(Eigenfaces* egf_native_obj) {
				std::vector<Mat> proj = egf_native_obj->getProjections();
				Mat projMat;
				vector_Mat_to_Mat(proj, projMat);
				return new Mat(projMat);
			}

			const char* opencvunity_face_Eigenfaces_getLabelInfo_10(Eigenfaces* egf_native_obj, int label) {
				return egf_native_obj->getLabelInfo(label).c_str();
			}

			int opencvunity_face_Eigenfaces_getNumComponents_10(Eigenfaces* egf_native_obj) {
				return egf_native_obj->getNumComponents();
			}

			void opencvunity_face_Eigenfaces_setNumComponents_10(Eigenfaces* egf_native_obj, int nbcomponent) {
				egf_native_obj->setNumComponents(nbcomponent);
			}

			void opencvunity_face_Eigenfaces_save_10(Eigenfaces* egf_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::WRITE);
				egf_native_obj->save(fs);
				fs.release();
			}

			void opencvunity_face_Eigenfaces_load_10(Eigenfaces* egf_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::READ);
				egf_native_obj->load(fs);
				fs.release();
			}

			// PredictCollector

			MinDistancePredictCollector* opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_10() {
				return new MinDistancePredictCollector();
			}

			MinDistancePredictCollector* opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_11(double treshold) {
				return new MinDistancePredictCollector(treshold);
			}

			double opencvunity_face_MinDistancePredictCollector_getDist_10(MinDistancePredictCollector* pc_native_obj) {
				return pc_native_obj->getDist();
			}

			int opencvunity_face_MinDistancePredictCollector_getLabel_10(MinDistancePredictCollector* pc_native_obj) {
				return pc_native_obj->getLabel();
			}

			bool opencvunity_face_MinDistancePredictCollector_emit_10(MinDistancePredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			void opencvunity_face_MinDistancePredictCollector_delete_10(MinDistancePredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			MapPredictCollector* opencvunity_face_MapPredictCollector_MapPredictCollector_10() {
				return new MapPredictCollector();
			}

			MapPredictCollector* opencvunity_face_MapPredictCollector_MapPredictCollector_11(double treshold) {
				return new MapPredictCollector(treshold);
			}

			Mat* opencvunity_face_MapPredictCollector_getResult_10(MapPredictCollector* pc_native_obj) {
				std::vector<std::pair<int, double> > vec = pc_native_obj->getResultVector();
				Mat res(vec.size(), 2, CV_64FC1);
				for (int i = 0; i < vec.size(); ++i) {
					std::pair<int, double> pair = vec[i];
					res.at<double>(i, 0) = pair.first;
					res.at<double>(i, 1) = pair.second;
				}
				return new Mat(res);
			}

			bool opencvunity_face_MapPredictCollector_emit_10(MapPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			void opencvunity_face_MapPredictCollector_delete_10(MapPredictCollector* pc_native_obj) {
				delete  pc_native_obj;
			}

			VectorPredictCollector* opencvunity_face_VectorPredictCollector_VectorPredictCollector_10() {
				return new VectorPredictCollector();
			}

			VectorPredictCollector* opencvunity_face_VectorPredictCollector_VectorPredictCollector_11(double treshold) {
				return new VectorPredictCollector(treshold);
			}

			Mat* opencvunity_face_VectorPredictCollector_getResult_10(VectorPredictCollector* pc_native_obj) {
				std::vector<std::pair<int, double> > vec = pc_native_obj->getResultVector();
				Mat res(vec.size(), 2, CV_64FC1);
				for (int i = 0; i < vec.size(); ++i) {
					std::pair<int, double> pair = vec[i];
					res.at<double>(i, 0) = pair.first;
					res.at<double>(i, 1) = pair.second;
				}
				return new Mat(res);
			}

			bool opencvunity_face_VectorPredictCollector_emit_10(VectorPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			void opencvunity_face_VectorPredictCollector_delete_10(VectorPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_10() {
				return new TopNPredictCollector();
			}

			TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_11(int n) {
				return new TopNPredictCollector(n);
			}

			TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_12(int n, double treshold) {
				return new TopNPredictCollector(n, treshold);
			}

			Mat* opencvunity_face_TopNPredictCollector_getResult_10(TopNPredictCollector* pc_native_obj) {
				std::vector<std::pair<int, double> > vec = pc_native_obj->getResultVector();
				Mat res(vec.size(), 2, CV_64FC1);
				for (int i = 0; i < vec.size(); ++i) {
					std::pair<int, double> pair = vec[i];
					res.at<double>(i, 0) = pair.first;
					res.at<double>(i, 1) = pair.second;
				}
				return new Mat(res);
			}

			bool opencvunity_face_TopNPredictCollector_emit_10(TopNPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			void opencvunity_face_TopNPredictCollector_delete_10(TopNPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			StatPredictCollector* opencvunity_face_StatPredictCollector_StatPredictCollector_10() {
				return new StatPredictCollector();
			}

			StatPredictCollector* opencvunity_face_StatPredictCollector_StatPredictCollector_11(double treshold) {
				return new StatPredictCollector(treshold);
			}

			double opencvunity_face_StatPredictCollector_getMin_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getMin();
			}

			double opencvunity_face_StatPredictCollector_getMax_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getMax();
			}

			double opencvunity_face_StatPredictCollector_getSum_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getSum();
			}

			int opencvunity_face_StatPredictCollector_getCount_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getCount();
			}

			bool opencvunity_face_StatPredictCollector_emit_10(StatPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			void opencvunity_face_StatPredictCollector_delete_10(StatPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			StdPredictCollector* opencvunity_face_StdPredictCollector_StdPredictCollector_10() {
				return new StdPredictCollector();
			}

			StdPredictCollector* opencvunity_face_StdPredictCollector_StdPredictCollector_11(double treshold) {
				return new StdPredictCollector(treshold);
			}

			double opencvunity_face_StdPredictCollector_getCount_10(StdPredictCollector* pc_native_obj) {
				return pc_native_obj->getResult();
			}

			bool opencvunity_face_StdPredictCollector_emit_10(StdPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			void opencvunity_face_StdPredictCollector_delete_10(StdPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}
		}

		// Tesseract OCR

		#if HAVE_TESSERACT
		
		namespace text {

			Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_10() {
				return new Ptr<OCRTesseract>(OCRTesseract::create(NULL, NULL, NULL, 3, 3));
			}

			Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_11(const char* datapath) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, NULL, NULL, 3, 3));
			}

			Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_12(const char* datapath, const char* lang) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, lang, NULL, 3, 3));
			}

			Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_13(const char* datapath, const char* lang, const char* whitelist) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, lang, whitelist, 3, 3));
			}

			Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_14(const char* datapath, const char* lang, const char* whitelist, int oem, int psmode) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, lang, whitelist, oem, psmode));
			}

			void opencvunity_text_OCRTesseract_run_10(Ptr<OCRTesseract>* ocr_native_obj, Mat* image, char* text) {
				std::string lOut = "";
				(*ocr_native_obj)->run(*image, lOut);
				strcpy(text, lOut.c_str());
			}

			void opencvunity_text_OCRTesseract_run_11(Ptr<OCRTesseract>* ocr_native_obj, Mat* image, Mat* rects, char* text) {
				std::vector<Rect>* rectvec = new std::vector<Rect>();
				std::string lOut = "";
				(*ocr_native_obj)->run(*image, lOut, rectvec);
				vector_Rect_to_Mat(*rectvec, *rects);
				strcpy(text, lOut.c_str());
				delete rectvec;
			}

			void opencvunity_text_OCRTesseract_setWhiteList_10(Ptr<OCRTesseract>* ocr_native_obj, const char* char_whitelist) {
				(*ocr_native_obj)->setWhiteList(String(char_whitelist));
			}

			void opencvunity_text_OCRTesseract_delete(Ptr<OCRTesseract>* ocr_native_obj) {
				delete ocr_native_obj;
			}
			
		}
		
		#endif

#if WINDOWS_PLATFORM && __cplusplus
	}
#endif
}