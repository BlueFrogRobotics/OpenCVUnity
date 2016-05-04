// Belhumeur, P. N., Hespanha, J., and Kriegman, D. "Eigenfaces vs. Fisher-
// faces: Recognition using class specific linear projection.". IEEE
// Transactions on Pattern Analysis and Machine Intelligence 19, 7 (1997),
// 711–720.

#ifndef _OBJDETECT_FISHERFACE_H_
#define _OBJDETECT_FISHERFACE_H_

#include "opencv2\objdetect\face_basic.hpp"

namespace cv {
	namespace face {
		class Fisherfaces : public BasicFaceRecognizerImpl
		{
		public:
			// Initializes an empty Fisherfaces model.
			Fisherfaces(int num_components = 0, double threshold = DBL_MAX)
				: BasicFaceRecognizerImpl(num_components, threshold)
			{ }

			// Computes a Fisherfaces model with images in src and corresponding labels
			// in labels.
			void train(InputArrayOfArrays src, InputArray labels);

			// Send all predict results to caller side for custom result handling
			void predict(InputArray src, PredictCollector& collector, const int state) const;
		};
	}
}
#endif