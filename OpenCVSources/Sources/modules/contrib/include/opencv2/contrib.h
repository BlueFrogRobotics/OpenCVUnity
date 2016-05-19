#ifndef CONTRIB_H
#define CONTRIB_H

#include "opencv2\core\mat.hpp"
#include "opencv2\core\base.hpp"
#include "opencv2\core\utility.hpp"
#include "opencv2\core\operations.hpp"
//#include "opencv2\core\csharp_converter.hpp"
#include "contrib\converters.hpp"
#include "..\..\imgproc\include\opencv2\imgproc.hpp"
#include "opencv2\highgui.hpp"
#include "opencv2\ml.hpp"
#include "opencv2\core.hpp"
#include "opencv2\objdetect.hpp"
#include "opencv2\imgcodecs.hpp"
#include "opencv2\videoio.hpp"
#include "opencv2\hal.hpp"

#include "contrib\qrcodereader.hpp"
#include "contrib\facerec.hpp"
#include "contrib\lbph_faces.hpp"
#include "contrib\eigen_faces.hpp"
#include "contrib\fisher_faces.hpp"
#include "contrib\erfilter.hpp"
#include "contrib\predict_collector.hpp"
#include "contrib\ocr.hpp"

#include "face.hpp"
#include "text.hpp"

#include <iostream>
#include <cmath>

namespace cv {

#if __cplusplus
	extern "C" {
#endif
		DLLEXPORT void opencvunity_objdetect_Objdetect_find_qrCode_10(Mat* image, Mat* correctedimage, Mat* points);
		DLLEXPORT void opencvunity_objdetect_Objdetect_find_text_10(Mat* img, Mat* rects, int width, int height);

		namespace face {
			DLLEXPORT LBPH* opencvunity_face_LBPHfaces_LBPHfaces_10();
			DLLEXPORT LBPH* opencvunity_face_LBPHfaces_LBPHfaces_11(int radius_, int neighbors_, int gridx, int gridy, double threshold);
			DLLEXPORT void opencvunity_face_LBPHfaces_train_10(LBPH* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj);
			DLLEXPORT void opencvunity_face_LBPHfaces_update_10(LBPH* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj);
			DLLEXPORT void opencvunity_face_LBPHfaces_predict_10(LBPH* ff_native_obj, Mat* src_native_obj, PredictCollector* predict, int state);
			DLLEXPORT void opencvunity_face_LBPHfaces_delete_10(LBPH* ff_native_obj);
			DLLEXPORT void opencvunity_face_LBPHfaces_save_10(LBPH* ff_native_obj, const char* filename);
			DLLEXPORT void opencvunity_face_LBPHfaces_load_10(LBPH* ff_native_obj, const char* filename);

			DLLEXPORT Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_10();
			DLLEXPORT Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_11(int nbcomponents);
			DLLEXPORT Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_12(int nbcomponents, double treshold);
			DLLEXPORT void opencvunity_face_Fisherfaces_train_10(Fisherfaces* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj);
			DLLEXPORT void opencvunity_face_Fisherfaces_update_10(Fisherfaces* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj);
			DLLEXPORT void opencvunity_face_Fisherfaces_predict_10(Fisherfaces* ff_native_obj, Mat* src_native_obj, PredictCollector* predict, int state);
			DLLEXPORT Mat* opencvunity_face_Fisherfaces_getEigenValues_10(Fisherfaces* ff_native_obj);
			DLLEXPORT Mat* opencvunity_face_Fisherfaces_getEigenVector_10(Fisherfaces* ff_native_obj);
			DLLEXPORT Mat* opencvunity_face_Fisherfaces_getLabels_10(Fisherfaces* ff_native_obj);
			DLLEXPORT Mat* opencvunity_face_Fisherfaces_getLabelsByString_10(Fisherfaces* ff_native_obj, const char* name);
			DLLEXPORT void opencvunity_face_Fisherfaces_clear_10(Fisherfaces* ff_native_obj);
			DLLEXPORT Mat* opencvunity_face_Fisherfacess_getMean_10(Fisherfaces* ff_native_obj);
			DLLEXPORT void opencvunity_face_Fisherfaces_setTreshold_10(Fisherfaces* ff_native_obj, double val);
			DLLEXPORT double opencvunity_face_Fisherfaces_getTreshold_10(Fisherfaces* ff_native_obj);
			DLLEXPORT bool opencvunity_face_Fisherfaces_empty_10(Fisherfaces* ff_native_obj);
			DLLEXPORT Mat* opencvunity_face_Fisherfaces_getProjections_10(Fisherfaces* ff_native_obj);
			DLLEXPORT const char* opencvunity_face_Fisherfaces_getLabelInfo_10(Fisherfaces* ff_native_obj, int label);
			DLLEXPORT int opencvunity_face_Fisherfaces_getNumComponents_10(Fisherfaces* ff_native_obj);
			DLLEXPORT void opencvunity_face_Fisherfaces_setNumComponents_10(Fisherfaces* ff_native_obj, int nbcomponent);
			DLLEXPORT void opencvunity_face_Fisherfaces_delete_10(Fisherfaces* ff_native_obj);
			DLLEXPORT void opencvunity_face_Fisherfaces_save_10(Fisherfaces* ff_native_obj, const char* filename);
			DLLEXPORT void opencvunity_face_Fisherfaces_load_10(Fisherfaces* ff_native_obj, const char* filename);

			DLLEXPORT Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_10();
			DLLEXPORT Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_11(int nbcomponents);
			DLLEXPORT Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_12(int nbcomponents, double treshold);
			DLLEXPORT void opencvunity_face_Eigenfaces_train_10(Eigenfaces* egf_native_obj, Mat* data_native_obj, Mat* labels_native_obj);
			DLLEXPORT void opencvunity_face_Eigenfaces_predict_10(Eigenfaces* egf_native_obj, Mat* src_native_obj, PredictCollector* predict, int state);
			DLLEXPORT Mat* opencvunity_face_Eigenfaces_getEigenValues_10(Eigenfaces* egf_native_obj);
			DLLEXPORT Mat* opencvunity_face_Eigenfaces_getEigenVector_10(Eigenfaces* egf_native_obj);
			DLLEXPORT Mat* opencvunity_face_Eigenfaces_getLabels_10(Eigenfaces* egf_native_obj);
			DLLEXPORT Mat* opencvunity_face_Eigenfaces_getLabelsByString_10(Eigenfaces* egf_native_obj, const char* name);
			DLLEXPORT void opencvunity_face_Eigenfaces_clear_10(Eigenfaces* egf_native_obj);
			DLLEXPORT Mat* opencvunity_face_Eigenfaces_getMean_10(Eigenfaces* egf_native_obj);
			DLLEXPORT void opencvunity_face_Eigenfaces_setTreshold_10(Eigenfaces* egf_native_obj, double val);
			DLLEXPORT double opencvunity_face_Eigenfaces_getTreshold_10(Eigenfaces* egf_native_obj);
			DLLEXPORT bool opencvunity_face_Eigenfaces_empty_10(Eigenfaces* egf_native_obj);
			DLLEXPORT Mat* opencvunity_face_Eigenfaces_getProjections_10(Eigenfaces* egf_native_obj);
			DLLEXPORT const char* opencvunity_face_Eigenfaces_getLabelInfo_10(Eigenfaces* egf_native_obj, int label);
			DLLEXPORT int opencvunity_face_Eigenfaces_getNumComponents_10(Eigenfaces* egf_native_obj);
			DLLEXPORT void opencvunity_face_Eigenfaces_setNumComponents_10(Eigenfaces* egf_native_obj, int nbcomponent);
			DLLEXPORT void opencvunity_face_Eigenfaces_delete_10(Eigenfaces* egf_native_obj);
			DLLEXPORT void opencvunity_face_Eigenfaces_save_10(Eigenfaces* egf_native_obj, const char* filename);
			DLLEXPORT void opencvunity_face_Eigenfaces_load_10(Eigenfaces* egf_native_obj, const char* filename);

			DLLEXPORT MinDistancePredictCollector* opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_10();
			DLLEXPORT MinDistancePredictCollector* opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_11(double treshold);
			DLLEXPORT double opencvunity_face_MinDistancePredictCollector_getDist_10(MinDistancePredictCollector* pc_native_obj);
			DLLEXPORT int opencvunity_face_MinDistancePredictCollector_getLabel_10(MinDistancePredictCollector* pc_native_obj);
			DLLEXPORT bool opencvunity_face_MinDistancePredictCollector_emit_10(MinDistancePredictCollector* pc_native_obj, int label, int dist, int state);
			DLLEXPORT void opencvunity_face_MinDistancePredictCollector_delete_10(MinDistancePredictCollector* pc_native_obj);

			DLLEXPORT MapPredictCollector* opencvunity_face_MapPredictCollector_MapPredictCollector_10();
			DLLEXPORT MapPredictCollector* opencvunity_face_MapPredictCollector_MapPredictCollector_11(double treshold);
			DLLEXPORT Mat* opencvunity_face_MapPredictCollector_getResult_10(MapPredictCollector* pc_native_obj);
			DLLEXPORT bool opencvunity_face_MapPredictCollector_emit_10(MapPredictCollector* pc_native_obj, int label, int dist, int state);
			DLLEXPORT void opencvunity_face_MapPredictCollector_delete_10(MapPredictCollector* pc_native_obj);

			DLLEXPORT VectorPredictCollector* opencvunity_face_VectorPredictCollector_VectorPredictCollector_10();
			DLLEXPORT VectorPredictCollector* opencvunity_face_VectorPredictCollector_VectorPredictCollector_11(double treshold);
			DLLEXPORT Mat* opencvunity_face_VectorPredictCollector_getResult_10(VectorPredictCollector* pc_native_obj);
			DLLEXPORT bool opencvunity_face_VectorPredictCollector_emit_10(VectorPredictCollector* pc_native_obj, int label, int dist, int state);
			DLLEXPORT void opencvunity_face_VectorPredictCollector_delete_10(VectorPredictCollector* pc_native_obj);

			DLLEXPORT TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_10();
			DLLEXPORT TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_11(int n);
			DLLEXPORT TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_12(int n, double treshold);
			DLLEXPORT Mat* opencvunity_face_TopNPredictCollector_getResult_10(TopNPredictCollector* pc_native_obj);
			DLLEXPORT bool opencvunity_face_TopNPredictCollector_emit_10(TopNPredictCollector* pc_native_obj, int label, int dist, int state);
			DLLEXPORT void opencvunity_face_TopNPredictCollector_delete_10(TopNPredictCollector* pc_native_obj);

			DLLEXPORT StatPredictCollector* opencvunity_face_StatPredictCollector_StatPredictCollector_10();
			DLLEXPORT StatPredictCollector* opencvunity_face_StatPredictCollector_StatPredictCollector_11(double treshold);
			DLLEXPORT double opencvunity_face_StatPredictCollector_getMin_10(StatPredictCollector* pc_native_obj);
			DLLEXPORT double opencvunity_face_StatPredictCollector_getMax_10(StatPredictCollector* pc_native_obj);
			DLLEXPORT double opencvunity_face_StatPredictCollector_getSum_10(StatPredictCollector* pc_native_obj);
			DLLEXPORT int opencvunity_face_StatPredictCollector_getCount_10(StatPredictCollector* pc_native_obj);
			DLLEXPORT bool opencvunity_face_StatPredictCollector_emit_10(StatPredictCollector* pc_native_obj, int label, int dist, int state);
			DLLEXPORT void opencvunity_face_StatPredictCollector_delete_10(StatPredictCollector* pc_native_obj);

			DLLEXPORT StdPredictCollector* opencvunity_face_StdPredictCollector_StdPredictCollector_10();
			DLLEXPORT StdPredictCollector* opencvunity_face_StdPredictCollector_StdPredictCollector_11(double treshold);
			DLLEXPORT double opencvunity_face_StdPredictCollector_getCount_10(StdPredictCollector* pc_native_obj);
			DLLEXPORT bool opencvunity_face_StdPredictCollector_emit_10(StdPredictCollector* pc_native_obj, int label, int dist, int state);
			DLLEXPORT void opencvunity_face_StdPredictCollector_delete_10(StdPredictCollector* pc_native_obj);
		}

		namespace text {
			DLLEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_10();
			DLLEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_11(const char* datapath);
			DLLEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_12(const char* datapath, const char* lang);
			DLLEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_13(const char* datapath, const char* lang, const char* whitelist);
			DLLEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_14(const char* datapath, const char* lang, const char* whitelist, int oem, int psmode);
			DLLEXPORT void opencvunity_text_OCRTesseract_run_10(Ptr<OCRTesseract>* ocr_native_obj, Mat* image, char* text);
			DLLEXPORT void opencvunity_text_OCRTesseract_run_11(Ptr<OCRTesseract>* ocr_native_obj, Mat* image, Mat* rects, char* text);
			DLLEXPORT void opencvunity_text_OCRTesseract_setWhiteList_10(Ptr<OCRTesseract>* ocr_native_obj, const char* char_whitelist);
			DLLEXPORT void opencvunity_text_OCRTesseract_delete(Ptr<OCRTesseract>* ocr_native_obj);
		}
#if __cplusplus
	}
#endif
}
#endif