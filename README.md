# Welcome to the SikuliTestSuite wiki!

Sikuli is a tool used for UI based testing.
It has the capability to simulate user interaction.
This uses Jython, Python-based scripts.
The user can create scripts to click on a particular part of the screen based on given location, image matching, and the expected results can be verified so as to know the status of the application.

I found Sikuli useful because it's easy to create tests, repetitive scenarios and assist manual testing.

Sikuli package comes with a console based application and also has IDE to create new scripts.
The syntax is pretty straight forward but it takes time to get adjusted to the IDE.
There are some bugs in IDE such that sometimes even the file seemed like saved does not execute the changes.
However, we get adjusted to it pretty quickly.

## Regarding this Test Suite.
I had created this test suite to run the scripts automatically and show the past and failed tests to the tester.
This Test suite has two distinct parts.
First is a C# application, a test harness. Once we load appropriate paths in this app, it will give user list of tests and can run the tests single or multiple times. It creates a report of passed and failed tests.

![Test Harness](https://github.com/AshishLS/SikuliTestSuite/blob/master/CSharpApp.JPG)

Once we load appropriate paths in this app, it will give user list of tests and can run the tests single or multiple times.
It creates a report of passed and failed tests.

The second and most important part is the Sikuli package itself.
This package is standard one available on Sikuli website.
It contains the IDE and also Jython runtimes to run the tests. This package is stand-alone and does not rely on C# application at all.

![SikuliX IDE](https://github.com/AshishLS/SikuliTestSuite/blob/master/SikuliXIDE.JPG)

This package is stand-alone and does not rely on C# application at all.

## How to use this Suite.
* Check the Sikuli Package included in this project TestData\Sikuli Build (online http://sikulix.com/)
* Run runsikulix.cmd to start the IDE
* Create a few tests in the Sikuli IDE. You can refer to the samples in TestData folder.
* Make sure the tests run fine by running them from the IDE itself.
* Once you have your tests, go to the C# application and run the exe.
* Give the application appropriate paths.
* Run the tests.

Please refer to the Sikuli_Demo.mp4 -  a 2-minute video to have an idea of how to run the tests.
To create tests efficiently, check this [Youtube Playlist](https://www.youtube.com/playlist?list=PL1A2CSdiySGJJNe3WzCezcI7by5SPfJTS) on SikuliX IDE - Cannot be simpler than this.

## Limitations of using SikuliX
* The IDE sometimes doesn't run updated code
* SikuliX is largely dependent on the screen resolution. It's not always guaranteed that the script will run on other machines as is.
* There are some tricks that one can use to overcome the deficiencies but it takes some time to optimize.

## Possible alternative to this
http://doc.sikuli.org/faq/020-unit-test.html

