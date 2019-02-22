# SikuliTestSuite
Sikuli Test suite

. There are scripts in TestData\TestsAshishMachine folder.

. These tests are for example purpose.

. There are two types of scripts here. Regular test scripts and common scripts.

. Whatever you want to keep as common, create a module_XXX sikuli project. Scripts with module_ prefix won't be considered by the app for running. That's why.

. These common scripts can be refered into the test scripts. So, the common images, common functions can be kept inside the module_XXX.sikuli folders.

. Every Regular test script either should output Debug.log("TEST PASSED!!") or Debug.log("TEST FAILED!!") depending on the test conditions.

. This is required becuase depending on this output, the application will know which tests to be shown in green and red.

. For more information watch the sikuli_demo.mp4 video in the project.

http://doc.sikuli.org/
