Doit être installés : 
	- CMake (https://cmake.org/download/)
	- Python 2.7.11 (https://www.python.org/downloads/)
	- Visual Studio 2013 ou 2015
	- Ant (http://ant.apache.org/bindownload.cgi)
	- JDK 1.7 (http://www.oracle.com/technetwork/java/javase/downloads/jdk7-downloads-1880260.html)
	- NDK (http://developer.android.com/ndk/downloads/index.html)
	- MinGW (http://sourceforge.net/projects/mingw/files/Installer/) avec dev-tools/base/g++/objc/sys-base

Build Android :

  ---1) Configuration dans CMake----
	- Ouvrir CMake
	- Spécifier le chemin les sources comme étant Path\To\Git\Repository\openCVUnity\OpenCVSources\Sources
	- Spécifier le chemin du build comme étant Path\To\Git\Repository\openCVUnity\OpenCVSources\Build_Android (ne sera pas push)
	- Cliquer sur "Configurer" (en bas à gauche)
	- Spécifier comme compilateur MinGW Makefiles en faisant un "Specify toolchain file for cross-compiling"
	- Spécifier Path\To\Git\Repository\openCVUnity\OpenCVSources\Sources\platforms\android\android.toolchain.cmake. Valider.
	- Une erreur se profile, passer cette erreur
	- Cliquer sur Add Entry
		- Name : ANDROID_NDK
		- Type : Path
		- Value : Path\To\NDK
	- Valider
	- Cliquer à nouveau sur Add Entry
		- Name : ANDROID_TOOLCHAIN_NAME
		- Type : String
		- Value : arm-linux-androideabi-4.9
	- Valider
	- Cliquer sur "Configure" (~ 3 minutes)
	- Dans la configuration :
		- ANDROID_EXECUTABLE : C:\Users\{USER}\AppData\Local\Android\android-sdk\tools\android.bat
		- ANDROID_NATIVE_API_LEVEL : 17
		- ZLIB_INCLUDE_DIR : changer android-8 par android-17
		- ZLIB_LIBRARY_RELEASE : changer android-8 par android-17
		- Désactiver :
			- BUILD_DOCS
			- BUILD_PERF_TESTS
			- BUILD_TESTS
			- WITH_CUDA
			- WITH_EIGEN
			- WITH_CUFFT
	- Cliquer sur "Configure"
	- Dans la configuration :
		- ANDROID_SDK_TARGET : android-21
	- Cliquer sur "Configure"
	- Cliquer sur "Generate"

---2) Compilation en invité de commande----
	- Aller dans le dossier Path\To\Git\Repository\openCVUnity\OpenCVSources\Build_Android et y lancer un invité de commande (cmd.exe)
	- Exécuter : SET JAVA_HOME=Path\To\JDK
	- Exécuter ensuite : Path\To\NDK\prebuilt\windows-x86_64\bin\make.exe -f Makefile (~ 15 minutes)
	- Si la compilation est réussie, aller chercher la Shared Library opencv_java300.so dans Build_Android\lib\armeabi-v7a\

Build Windows :

Soit XX = [x64 || x86] l'architecture souhaitée.

  ---1) Configuration dans CMake----
	- Ouvrir CMake
	- Spécifier le chemin les sources comme étant \Path\To\Git\Repository\openCVUnity\OpenCVSources\Sources
	- Spécifier le chemin du build comme étant \Path\To\Git\Repository\openCVUnity\OpenCVSources\Build_XX (ne sera pas push)
	- Cliquer sur "Configurer" (en bas à gauche)
	- Spécifier comme compilateur le visual studio installé en version XX avec comme option "Use default native compilers"
	- Cliquer sur "Finish" et attendre le temps que la configuration se fasse
	- Dans la configuration :
		- Spécifier le chemin vers le ANT_EXECUTABLE (apache-ant/bin/ant.bat)
		- Désactiver :
			- BUILD_DOCS
			- BUILD_PERF_TESTS
			- BUILD_TESTS
			- BUILD_opencv_cudaarithm
			- BUILD_opencv_cudabgsegm
			- BUILD_opencv_cudacodec
			- BUILD_opencv_cudafeatures2d
			- BUILD_opencv_cudaimgproc
			- BUILD_opencv_cudalegacy
			- BUILD_opencv_cudaobjdetect
			- BUILD_opencv_cudaoptflow
			- BUILD_opencv_cudastereo
			- BUILD_opencv_cudawarping
			- WITH_CUDA
	- Cliquer sur "Configure"
	- BUILD opencv_java a du apparaitre dans la configuration. Il doit être activé.
	- Cliquer sur "Configure"
	- Cliquer sur "Generate"

  ---2) Compilation partielle dans Visual Studio----
	- Aller dans Build_XX et lancer OpenCV.sln avec Visual Studio et attendez que tout s'initialise (~ 2 minutes).
	- Dans le Configuration Manager, passer en mode Release sur l'architecture souhaitée.
	- Ajouter l'option /FORCE (en plus de /machine:x*) dans Linker/Command Line dans les projets :
		- bindings/opencv_java
		- modules/opencv_*\[hal || ts]
	- Builder la solution (~ 5 minutes)
	- Fermer Visual Studio

  ---3) Configuration pour la bibliothèque unique sur CMake---
	- Si la compilation est réussie, vous avez généré la DLL opencv_java300.dll dans Build_XX\bin\Release\ . Cette bibliothèque n'est pas complète.
	- Retourner sur CMake avec la dernière configuration générée pour Windows.
	- Dans la configuration activer BUILD_OPENCV_WORLD
	- Cliquer sur "Configure"
	- Cliquer sur "Generate"

 ---4) Compilation finale dans Visual Studio----
	- Retourner dans Build_XX et relancer Visual Studio avec OpenCV.sln
	- Dans opencv_world\opencv_core\Include\opencv2\core\ ajouter comme élements
	existants Path\To\Git\Repository\openCVUnity\OpenCVSources\Sources\modules\java\generator\src\cpp\*.h
	- Dans opencv_world\opencv_core\Src\ ajouter comme élements
	existants Path\To\Git\Repository\openCVUnity\OpenCVSources\Sources\modules\java\generator\src\cpp\*.cpp
	- Dans opencv_world\opencv_core\Src\ ajouter comme élements
	existants Path\To\Git\Repository\openCVUnity\OpenCVSources\Build_XX\modules\java\*.cpp
	- Dans le Configuration Manager, passer en mode Release sur l'architecture souhaitée.
	- Ajouter l'option /FORCE (en plus de /machine:x*) dans Linker/Command Line pour le projet opencv_world
	- Builder la solution (~ 5 minutes)
	- Si la compilation est réussie, vous avez généré la DLL opencv_world.dll dans Build_XX\bin\Release\