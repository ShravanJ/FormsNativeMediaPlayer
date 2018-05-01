# NativeMediaPlayer
Native iOS and Android media players rendered in a Xamarin Forms solution
Features include:
* Uses platform specific native AVPlayer (iOS) and VideoView (Android)
* No extra dependencies
* Full native performance
* iOS solution utilizes the AVPlayerViewController inside of the PageRenderer so no xib-based ViewController is required
* Android solution uses a XML based layout for managing the view
# Building and running
This project was built with the latest version of Visual Studio for Mac with the latest Android, iOS, and Xamarin SDK as of 4/29/18. The iOS version's video playback works fine in the iOS Simulator but I recommend deploying the Android version directly to a physical device since the Android Emulator isn't that great at video decoding. If you get any build errors, try to clean and rebuild as this usually fixes most errors.

Licensed under the MIT license. Copyright 2018 Shravan Jambukesan (shravan@shravanj.com). 
