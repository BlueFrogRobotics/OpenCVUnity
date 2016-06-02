#include "opencv2/contrib.h"

namespace cv {

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
	
#if WINDOWS_PLATFORM && __cplusplus
	extern "C" {
#endif

		JNIEXPORT const char* opencvunity_GetFilePath(const char* filename)
		{
			//TODO
			return filename;
		}

		JNIEXPORT void opencvunity_MatToTexture(Mat* mat, uchar* textureColors)
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

		JNIEXPORT void opencvunity_MatDataToArray(Mat* mat, uchar* array)
		{
			opencvunity_MatToTexture(mat, array);
		}
		
		JNIEXPORT void opencvunity_TextureToMat(uchar* textureColors, Mat* mat)
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

		JNIEXPORT void opencvunity_MatDataToByteArray(Mat* mat, uchar* charArray)
		{
			opencvunity_MatToTexture(mat, charArray);
		}

		JNIEXPORT void opencvunity_ByteArrayToMatData(uchar* byteArray, Mat* mat)
		{
			opencvunity_TextureToMat(byteArray, mat);
		}

		JNIEXPORT void opencvunity_TextureDataToByteArray(void* texPtr, int texWidth, int texHeight, unsigned char* byteArray, int bytesPerPixel)
		{
			texture_to_mat_4chan(byteArray, (unsigned char*)texPtr, texWidth * texHeight * bytesPerPixel);
		}

		JNIEXPORT void opencvunity_ByteArrayToTextureData(unsigned char* byteArray, void* texPtr, int texWidth, int texHeight, int bytesPerPixel)
		{
			mat_4chan_to_texture((unsigned char*)texPtr, byteArray, texWidth * texHeight * bytesPerPixel);
		}

		JNIEXPORT void opencvunity_LowLevelMatToTexture(Mat* mat, void* texPtr, int texWidth, int texHeight)
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

		JNIEXPORT void opencvunity_LowLevelTextureToMat(void* texPtr, int texWidth, int texHeight, Mat* mat)
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

		JNIEXPORT int opencvunity_GetLowLevelTextureFormat(void* texPtr)
		{
			//TODO
			return 2;
		}

		JNIEXPORT void opencvunity_objdetect_Objdetect_find_text_10(Mat* img, Mat* rects, int width, int height) {
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

		JNIEXPORT void opencvunity_objdetect_Objdetect_find_qrCode_10(Mat* image_mat_nativeObj, Mat* qrcodes_mat_nativeObj, Mat* points_mat_nativeObj)
		{
			std::vector<Point2f> pts;
			std::vector<Mat> qrcodes;
			qrCode(*image_mat_nativeObj, qrcodes, pts);
			vector_Mat_to_Mat(qrcodes, *qrcodes_mat_nativeObj);
			vector_Point2f_to_Mat(pts, *points_mat_nativeObj);
		}

		namespace face {

			// LBPHfaces

			JNIEXPORT LBPH* opencvunity_face_LBPHfaces_LBPHfaces_10() {
				return new LBPH();
			}

			JNIEXPORT LBPH* opencvunity_face_LBPHfaces_LBPHfaces_11(int radius_, int neighbors_, int gridx, int gridy, double threshold) {
				return new LBPH(radius_, neighbors_, gridx, gridy, threshold);
			}

			JNIEXPORT void opencvunity_face_LBPHfaces_train_10(LBPH* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->train(data, labels);
			}

			JNIEXPORT void opencvunity_face_LBPHfaces_update_10(LBPH* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->update(data, labels);
			}

			JNIEXPORT void opencvunity_face_LBPHfaces_predict_10(LBPH* ff_native_obj, Mat* src_native_obj, PredictCollector* predict, int state) {
				ff_native_obj->predict(*src_native_obj, *predict, state);
			}

			JNIEXPORT void opencvunity_face_LBPHfaces_delete_10(LBPH* ff_native_obj) {
				delete ff_native_obj;
			}

			JNIEXPORT void opencvunity_face_LBPHfaces_save_10(LBPH* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::WRITE);
				ff_native_obj->save(fs);
				fs.release();
			}

			JNIEXPORT void opencvunity_face_LBPHfaces_load_10(LBPH* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::READ);
				ff_native_obj->load(fs);
				fs.release();
			}

			// Fisherfaces

			JNIEXPORT Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_10() {
				return new Fisherfaces();
			}

			JNIEXPORT Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_11(int nbcomponents) {
				return new Fisherfaces(nbcomponents);
			}

			JNIEXPORT Fisherfaces* opencvunity_face_Fisherfaces_Fisherfaces_12(int nbcomponents, double treshold) {
				return new Fisherfaces(nbcomponents, treshold);
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_train_10(Fisherfaces* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->train(data, labels);
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_update_10(Fisherfaces* ff_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				ff_native_obj->update(data, labels);
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_predict_10(Fisherfaces* ff_native_obj, Mat* src_native_obj, PredictCollector* predict, int state) {
				ff_native_obj->predict(*src_native_obj, *predict, state);
			}

			JNIEXPORT Mat* opencvunity_face_Fisherfaces_getEigenValues_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getEigenValues());
			}

			JNIEXPORT Mat* opencvunity_face_Fisherfaces_getEigenVector_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getEigenVectors());
			}

			JNIEXPORT Mat* opencvunity_face_Fisherfaces_getLabels_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getLabels());
			}

			JNIEXPORT Mat* opencvunity_face_Fisherfaces_getLabelsByString_10(Fisherfaces* ff_native_obj, const char* name) {
				std::vector<int> label = ff_native_obj->getLabelsByString(name);
				Mat labelmat;
				vector_int_to_Mat(label, labelmat);
				return new Mat(labelmat);
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_clear_10(Fisherfaces* ff_native_obj) {
				ff_native_obj->clear();
			}

			JNIEXPORT Mat* opencvunity_face_Fisherfacess_getMean_10(Fisherfaces* ff_native_obj) {
				return new Mat(ff_native_obj->getMean());
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_setTreshold_10(Fisherfaces* ff_native_obj, double val) {
				ff_native_obj->setThreshold(val);
			}

			JNIEXPORT double opencvunity_face_Fisherfaces_getTreshold_10(Fisherfaces* ff_native_obj) {
				return ff_native_obj->getThreshold();
			}

			JNIEXPORT bool opencvunity_face_Fisherfaces_empty_10(Fisherfaces* ff_native_obj) {
				return ff_native_obj->empty();
			}

			JNIEXPORT Mat* opencvunity_face_Fisherfaces_getProjections_10(Fisherfaces* ff_native_obj) {
				std::vector<Mat> proj = ff_native_obj->getProjections();
				Mat projMat;
				vector_Mat_to_Mat(proj, projMat);
				return new Mat(projMat);
			}

			JNIEXPORT const char* opencvunity_face_Fisherfaces_getLabelInfo_10(Fisherfaces* ff_native_obj, int label) {
				return ff_native_obj->getLabelInfo(label).c_str();
			}

			JNIEXPORT int opencvunity_face_Fisherfaces_getNumComponents_10(Fisherfaces* ff_native_obj) {
				return ff_native_obj->getNumComponents();
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_setNumComponents_10(Fisherfaces* ff_native_obj, int nbcomponent) {
				ff_native_obj->setNumComponents(nbcomponent);
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_delete_10(Fisherfaces* ff_native_obj) {
				delete ff_native_obj;
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_save_10(Fisherfaces* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::WRITE);
				ff_native_obj->save(fs);
				fs.release();
			}

			JNIEXPORT void opencvunity_face_Fisherfaces_load_10(Fisherfaces* ff_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::READ);
				ff_native_obj->load(fs);
				fs.release();
			}

			// Eigenfaces

			JNIEXPORT Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_10()
			{
				return new Eigenfaces();
			}

			JNIEXPORT Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_11(int nbcomponents)
			{
				return new Eigenfaces(nbcomponents);
			}

			JNIEXPORT Eigenfaces* opencvunity_face_Eigenfaces_Eigenfaces_12(int nbcomponents, double treshold)
			{
				return new Eigenfaces(nbcomponents, treshold);
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_train_10(Eigenfaces* egf_native_obj, Mat* data_native_obj, Mat* labels_native_obj) {
				std::vector<Mat> data;
				std::vector<int> labels;
				Mat_to_vector_Mat(*data_native_obj, data);
				Mat_to_vector_int(*labels_native_obj, labels);
				egf_native_obj->train(data, labels);
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_predict_10(Eigenfaces* egf_native_obj, Mat* src_native_obj, PredictCollector* predict, int state) {
				egf_native_obj->predict(*src_native_obj, *predict, state);
			}

			JNIEXPORT Mat* opencvunity_face_Eigenfaces_getEigenValues_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getEigenValues());
			}

			JNIEXPORT Mat* opencvunity_face_Eigenfaces_getEigenVector_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getEigenVectors());
			}

			JNIEXPORT Mat* opencvunity_face_Eigenfaces_getLabels_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getLabels());
			}

			JNIEXPORT Mat* opencvunity_face_Eigenfaces_getLabelsByString_10(Eigenfaces* egf_native_obj, const char* name) {
				std::vector<int> label = egf_native_obj->getLabelsByString(name);
				Mat labelmat;
				vector_int_to_Mat(label, labelmat);
				return new Mat(labelmat);
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_clear_10(Eigenfaces* egf_native_obj) {
				egf_native_obj->clear();
			}

			JNIEXPORT Mat* opencvunity_face_Eigenfaces_getMean_10(Eigenfaces* egf_native_obj) {
				return new Mat(egf_native_obj->getMean());
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_setTreshold_10(Eigenfaces* egf_native_obj, double val) {
				egf_native_obj->setThreshold(val);
			}

			JNIEXPORT double opencvunity_face_Eigenfaces_getTreshold_10(Eigenfaces* egf_native_obj) {
				return egf_native_obj->getThreshold();
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_delete_10(Eigenfaces* egf_native_obj) {
				delete egf_native_obj;
			}

			JNIEXPORT bool opencvunity_face_Eigenfaces_empty_10(Eigenfaces* egf_native_obj) {
				return egf_native_obj->empty();
			}

			JNIEXPORT Mat* opencvunity_face_Eigenfaces_getProjections_10(Eigenfaces* egf_native_obj) {
				std::vector<Mat> proj = egf_native_obj->getProjections();
				Mat projMat;
				vector_Mat_to_Mat(proj, projMat);
				return new Mat(projMat);
			}

			JNIEXPORT const char* opencvunity_face_Eigenfaces_getLabelInfo_10(Eigenfaces* egf_native_obj, int label) {
				return egf_native_obj->getLabelInfo(label).c_str();
			}

			JNIEXPORT int opencvunity_face_Eigenfaces_getNumComponents_10(Eigenfaces* egf_native_obj) {
				return egf_native_obj->getNumComponents();
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_setNumComponents_10(Eigenfaces* egf_native_obj, int nbcomponent) {
				egf_native_obj->setNumComponents(nbcomponent);
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_save_10(Eigenfaces* egf_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::WRITE);
				egf_native_obj->save(fs);
				fs.release();
			}

			JNIEXPORT void opencvunity_face_Eigenfaces_load_10(Eigenfaces* egf_native_obj, const char* filename) {
				FileStorage fs(filename, FileStorage::READ);
				egf_native_obj->load(fs);
				fs.release();
			}

			// PredictCollector

			JNIEXPORT MinDistancePredictCollector* opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_10() {
				return new MinDistancePredictCollector();
			}

			JNIEXPORT MinDistancePredictCollector* opencvunity_face_MinDistancePredictCollector_MinDistancePredictCollector_11(double treshold) {
				return new MinDistancePredictCollector(treshold);
			}

			JNIEXPORT double opencvunity_face_MinDistancePredictCollector_getDist_10(MinDistancePredictCollector* pc_native_obj) {
				return pc_native_obj->getDist();
			}

			JNIEXPORT int opencvunity_face_MinDistancePredictCollector_getLabel_10(MinDistancePredictCollector* pc_native_obj) {
				return pc_native_obj->getLabel();
			}

			JNIEXPORT bool opencvunity_face_MinDistancePredictCollector_emit_10(MinDistancePredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			JNIEXPORT void opencvunity_face_MinDistancePredictCollector_delete_10(MinDistancePredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			JNIEXPORT MapPredictCollector* opencvunity_face_MapPredictCollector_MapPredictCollector_10() {
				return new MapPredictCollector();
			}

			JNIEXPORT MapPredictCollector* opencvunity_face_MapPredictCollector_MapPredictCollector_11(double treshold) {
				return new MapPredictCollector(treshold);
			}

			JNIEXPORT Mat* opencvunity_face_MapPredictCollector_getResult_10(MapPredictCollector* pc_native_obj) {
				std::vector<std::pair<int, double> > vec = pc_native_obj->getResultVector();
				Mat res(vec.size(), 2, CV_64FC1);
				for (int i = 0; i < vec.size(); ++i) {
					std::pair<int, double> pair = vec[i];
					res.at<double>(i, 0) = pair.first;
					res.at<double>(i, 1) = pair.second;
				}
				return new Mat(res);
			}

			JNIEXPORT bool opencvunity_face_MapPredictCollector_emit_10(MapPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			JNIEXPORT void opencvunity_face_MapPredictCollector_delete_10(MapPredictCollector* pc_native_obj) {
				delete  pc_native_obj;
			}

			JNIEXPORT VectorPredictCollector* opencvunity_face_VectorPredictCollector_VectorPredictCollector_10() {
				return new VectorPredictCollector();
			}

			JNIEXPORT VectorPredictCollector* opencvunity_face_VectorPredictCollector_VectorPredictCollector_11(double treshold) {
				return new VectorPredictCollector(treshold);
			}

			JNIEXPORT Mat* opencvunity_face_VectorPredictCollector_getResult_10(VectorPredictCollector* pc_native_obj) {
				std::vector<std::pair<int, double> > vec = pc_native_obj->getResultVector();
				Mat res(vec.size(), 2, CV_64FC1);
				for (int i = 0; i < vec.size(); ++i) {
					std::pair<int, double> pair = vec[i];
					res.at<double>(i, 0) = pair.first;
					res.at<double>(i, 1) = pair.second;
				}
				return new Mat(res);
			}

			JNIEXPORT bool opencvunity_face_VectorPredictCollector_emit_10(VectorPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			JNIEXPORT void opencvunity_face_VectorPredictCollector_delete_10(VectorPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			JNIEXPORT TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_10() {
				return new TopNPredictCollector();
			}

			JNIEXPORT TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_11(int n) {
				return new TopNPredictCollector(n);
			}

			JNIEXPORT TopNPredictCollector* opencvunity_face_TopNPredictCollector_TopNPredictCollector_12(int n, double treshold) {
				return new TopNPredictCollector(n, treshold);
			}

			JNIEXPORT Mat* opencvunity_face_TopNPredictCollector_getResult_10(TopNPredictCollector* pc_native_obj) {
				std::vector<std::pair<int, double> > vec = pc_native_obj->getResultVector();
				Mat res(vec.size(), 2, CV_64FC1);
				for (int i = 0; i < vec.size(); ++i) {
					std::pair<int, double> pair = vec[i];
					res.at<double>(i, 0) = pair.first;
					res.at<double>(i, 1) = pair.second;
				}
				return new Mat(res);
			}

			JNIEXPORT bool opencvunity_face_TopNPredictCollector_emit_10(TopNPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			JNIEXPORT void opencvunity_face_TopNPredictCollector_delete_10(TopNPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			JNIEXPORT StatPredictCollector* opencvunity_face_StatPredictCollector_StatPredictCollector_10() {
				return new StatPredictCollector();
			}

			JNIEXPORT StatPredictCollector* opencvunity_face_StatPredictCollector_StatPredictCollector_11(double treshold) {
				return new StatPredictCollector(treshold);
			}

			JNIEXPORT double opencvunity_face_StatPredictCollector_getMin_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getMin();
			}

			JNIEXPORT double opencvunity_face_StatPredictCollector_getMax_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getMax();
			}

			JNIEXPORT double opencvunity_face_StatPredictCollector_getSum_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getSum();
			}

			JNIEXPORT int opencvunity_face_StatPredictCollector_getCount_10(StatPredictCollector* pc_native_obj) {
				return pc_native_obj->getCount();
			}

			JNIEXPORT bool opencvunity_face_StatPredictCollector_emit_10(StatPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			JNIEXPORT void opencvunity_face_StatPredictCollector_delete_10(StatPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}

			JNIEXPORT StdPredictCollector* opencvunity_face_StdPredictCollector_StdPredictCollector_10() {
				return new StdPredictCollector();
			}

			JNIEXPORT StdPredictCollector* opencvunity_face_StdPredictCollector_StdPredictCollector_11(double treshold) {
				return new StdPredictCollector(treshold);
			}

			JNIEXPORT double opencvunity_face_StdPredictCollector_getCount_10(StdPredictCollector* pc_native_obj) {
				return pc_native_obj->getResult();
			}

			JNIEXPORT bool opencvunity_face_StdPredictCollector_emit_10(StdPredictCollector* pc_native_obj, int label, int dist, int state) {
				return pc_native_obj->emit(label, dist, state);
			}

			JNIEXPORT void opencvunity_face_StdPredictCollector_delete_10(StdPredictCollector* pc_native_obj) {
				delete pc_native_obj;
			}
		}

		// Tesseract OCR

		#if HAVE_TESSERACT
		
		namespace text {

			JNIEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_10() {
				return new Ptr<OCRTesseract>(OCRTesseract::create(NULL, NULL, NULL, 3, 3));
			}

			JNIEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_11(const char* datapath) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, NULL, NULL, 3, 3));
			}

			JNIEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_12(const char* datapath, const char* lang) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, lang, NULL, 3, 3));
			}

			JNIEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_13(const char* datapath, const char* lang, const char* whitelist) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, lang, whitelist, 3, 3));
			}

			JNIEXPORT Ptr<OCRTesseract>* opencvunity_text_OCRTesseract_OCRTesseract_14(const char* datapath, const char* lang, const char* whitelist, int oem, int psmode) {
				return new Ptr<OCRTesseract>(OCRTesseract::create(datapath, lang, whitelist, oem, psmode));
			}

			JNIEXPORT void opencvunity_text_OCRTesseract_run_10(Ptr<OCRTesseract>* ocr_native_obj, Mat* image, char* text) {
				std::string lOut = "";
				(*ocr_native_obj)->run(*image, lOut);
				strcpy(text, lOut.c_str());
			}

			JNIEXPORT void opencvunity_text_OCRTesseract_run_11(Ptr<OCRTesseract>* ocr_native_obj, Mat* image, Mat* rects, char* text) {
				std::vector<Rect>* rectvec = new std::vector<Rect>();
				std::string lOut = "";
				(*ocr_native_obj)->run(*image, lOut, rectvec);
				vector_Rect_to_Mat(*rectvec, *rects);
				strcpy(text, lOut.c_str());
				delete rectvec;
			}

			JNIEXPORT void opencvunity_text_OCRTesseract_setWhiteList_10(Ptr<OCRTesseract>* ocr_native_obj, const char* char_whitelist) {
				(*ocr_native_obj)->setWhiteList(String(char_whitelist));
			}

			JNIEXPORT void opencvunity_text_OCRTesseract_delete(Ptr<OCRTesseract>* ocr_native_obj) {
				delete ocr_native_obj;
			}
			
		}
		
		#endif
		
#if WINDOWS_PLATFORM && __cplusplus
	}
#endif
}