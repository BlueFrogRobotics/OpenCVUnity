#ifndef __PARAM_CONTRIB_HPP__
# define __PARAM_CONTRIB_HPP__

# define HAVE_TESSERACT 0

# define WINDOWS_PLATFORM 1

# if WINDOWS_PLATFORM
	#define DLLEXPORT __declspec(dllexport)
# else
	#define DLLEXPORT
# endif

#endif 