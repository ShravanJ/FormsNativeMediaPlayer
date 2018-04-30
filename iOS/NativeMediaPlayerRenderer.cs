using System;
using Foundation;
using AVFoundation;
using AVKit;
using NativeMediaPlayer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using NativeMediaPlayer.iOS;

[assembly:ExportRenderer (typeof(NativeMediaPlayerPage), typeof(NativeMediaPlayerRenderer))]
namespace NativeMediaPlayer.iOS
{
    public class NativeMediaPlayerRenderer : PageRenderer
    {

        AVPlayer player;
        AVPlayerViewController playerViewController;

        public NativeMediaPlayerRenderer()
        {
            
        }

		public override void ViewDidLoad()
		{
            base.ViewDidLoad();

            var source = NSUrl.FromString("https://shravanj.com/files/dev/vid.mp4");
            player = new AVPlayer(source);
            playerViewController = new AVPlayerViewController();
            playerViewController.Player = player;
            AddChildViewController(playerViewController);
            View.AddSubview(playerViewController.View);
            playerViewController.View.Frame = View.Frame;
            playerViewController.ShowsPlaybackControls = true;
            player.Play();
            System.Diagnostics.Debug.WriteLine("Now playing");

		}


	}
}
