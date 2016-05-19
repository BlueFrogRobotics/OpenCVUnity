#ifndef _OBJDETECT_EIGENFACE_H_
#define _OBJDETECT_EIGENFACE_H_

#include "face_basic.hpp"

namespace cv {
	namespace face {
		// Turk, M., and Pentland, A. "Eigenfaces for recognition.". Journal of
		// Cognitive Neuroscience 3 (1991), 71–86.
		class Eigenfaces : public BasicFaceRecognizerImpl
		{

		public:
			// Initializes an empty Eigenfaces model.
			Eigenfaces(int num_components = 0, double threshold = DBL_MAX)
				: BasicFaceRecognizerImpl(num_components, threshold)
			{}

			// Computes an Eigenfaces model with images in src and corresponding labels
			// in labels.
			void train(InputArrayOfArrays src, InputArray labels);

			// Send all predict results to caller side for custom result handling
			void predict(InputArray src, PredictCollector& collector, const int state) const;
		};
	}
}
#endif