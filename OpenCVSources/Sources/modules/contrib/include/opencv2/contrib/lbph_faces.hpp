// Face Recognition based on Local Binary Patterns.
//
//  Ahonen T, Hadid A. and Pietikäinen M. "Face description with local binary
//  patterns: Application to face recognition." IEEE Transactions on Pattern
//  Analysis and Machine Intelligence, 28(12):2037-2041.
//

#ifndef _OBJDETECT_LBPHFACE_H_
#define _OBJDETECT_LBPHFACE_H_

#include "face_basic.hpp"
#include "opencv2/face.hpp"
#include "opencv2/objdetect.hpp"
#include "opencv2/imgproc.hpp"

#include "opencv2/ml.hpp"

#include "opencv2/core/utility.hpp"
#include "opencv2/core/ocl.hpp"

#include "opencv2/opencv_modules.hpp"
#ifdef HAVE_OPENCV_HIGHGUI
#  include "opencv2/highgui.hpp"
#endif

#include "opencv2/core/private.hpp"

#ifdef HAVE_TEGRA_OPTIMIZATION
#include "opencv2/objdetect/objdetect_tegra.hpp"
#endif

#include "opencv2/imgproc.hpp"
#include "opencv2/core.hpp"
#include "opencv2/core/utility.hpp"
#include "opencv2/core/private.hpp"
#include "opencv2/core/persistence.hpp"
#include <set>
#include <limits>
#include <iostream>

namespace cv {
	namespace face {
		class LBPH : public LBPHFaceRecognizer
		{
		private:
			int _grid_x;
			int _grid_y;
			int _radius;
			int _neighbors;
			double _threshold;

			std::vector<Mat> _histograms;
			Mat _labels;

			// Computes a LBPH model with images in src and
			// corresponding labels in labels, possibly preserving
			// old model data.
			void train(InputArrayOfArrays src, InputArray labels, bool preserveData);


		public:
			using FaceRecognizer::save;
			using FaceRecognizer::load;

			// Initializes this LBPH Model. The current implementation is rather fixed
			// as it uses the Extended Local Binary Patterns per default.
			//
			// radius, neighbors are used in the local binary patterns creation.
			// grid_x, grid_y control the grid size of the spatial histograms.
			LBPH(int radius_ = 1, int neighbors_ = 8,
				int gridx = 8, int gridy = 8,
				double threshold = DBL_MAX) :
				_grid_x(gridx),
				_grid_y(gridy),
				_radius(radius_),
				_neighbors(neighbors_),
				_threshold(threshold) {}

			// Initializes and computes this LBPH Model. The current implementation is
			// rather fixed as it uses the Extended Local Binary Patterns per default.
			//
			// (radius=1), (neighbors=8) are used in the local binary patterns creation.
			// (grid_x=8), (grid_y=8) controls the grid size of the spatial histograms.
			LBPH(InputArrayOfArrays src,
				InputArray labels,
				int radius_ = 1, int neighbors_ = 8,
				int gridx = 8, int gridy = 8,
				double threshold = DBL_MAX) :
				_grid_x(gridx),
				_grid_y(gridy),
				_radius(radius_),
				_neighbors(neighbors_),
				_threshold(threshold) {
				train(src, labels);
			}

			~LBPH() { }

			// Computes a LBPH model with images in src and
			// corresponding labels in labels.
			void train(InputArrayOfArrays src, InputArray labels);

			// Updates this LBPH model with images in src and
			// corresponding labels in labels.
			void update(InputArrayOfArrays src, InputArray labels);

			// Send all predict results to caller side for custom result handling
			void predict(InputArray src, PredictCollector& collector, const int state = 0) const;

			// See FaceRecognizer::load.
			void load(const FileStorage& fs);

			// See FaceRecognizer::save.
			void save(FileStorage& fs) const;

			CV_IMPL_PROPERTY(int, GridX, _grid_x)
				CV_IMPL_PROPERTY(int, GridY, _grid_y)
				CV_IMPL_PROPERTY(int, Radius, _radius)
				CV_IMPL_PROPERTY(int, Neighbors, _neighbors)
				CV_IMPL_PROPERTY(double, Threshold, _threshold)
				CV_IMPL_PROPERTY_RO(std::vector<cv::Mat>, Histograms, _histograms)
				CV_IMPL_PROPERTY_RO(cv::Mat, Labels, _labels)
		};
	}
}
#endif