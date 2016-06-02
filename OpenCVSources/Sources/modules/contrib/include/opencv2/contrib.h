#ifndef CONTRIB_H
#define CONTRIB_H

#include "opencv2\core\mat.hpp"
#include "opencv2\core\base.hpp"
#include "opencv2\core\utility.hpp"
#include "opencv2\core\operations.hpp"
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
#include "contrib\params.hpp"

//#include "..\..\java\generator\src\cpp\converters.hpp"
#include "..\..\java\generator\src\cpp\common.h"
#include "opencv2/core/converters.hpp"

#include "face.hpp"
#include "text.hpp"

#include <iostream>
#include <cmath>

namespace cv {
	typedef unsigned char byte;
}

#endif