using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using Android.Graphics;
using NativeMediaPlayer.Droid;
using NativeMediaPlayer;
using Android.Content;
using Android.Media;
using Android.Net;
using Android.App;
using Android.Widget;


[assembly: ExportRenderer(typeof(NativeMediaPlayerPage), typeof(NativeMediaPlayerRenderer))]
namespace NativeMediaPlayer.Droid
{
    public class NativeMediaPlayerRenderer : PageRenderer
    {

        Activity activity;
        Android.Views.View view;
        VideoView videoView;
        Context myContext;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                SetupUI();
                StartMediaPlayer();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }


        public NativeMediaPlayerRenderer(Context context) : base(context)
        {
            myContext = context;
        }

        public void SetupUI()
        {
            activity = this.Context as Activity;
            view = activity.LayoutInflater.Inflate(Resource.Layout.MyVideoView, this, false);
            activity.SetContentView(view);
            videoView = view.FindViewById<VideoView>(Resource.Id.VideoViewRender);
        }

        public void StartMediaPlayer()
        {
            var sourceUri = Android.Net.Uri.Parse("https://shravanj.com/files/dev/vid.mp4");
            videoView.SetVideoURI(sourceUri);
            videoView.Visibility = ViewStates.Visible;
            MediaController mediaController = new MediaController(myContext);
            mediaController.SetAnchorView(videoView);
            videoView.SetMediaController(mediaController);
            videoView.Start();
            System.Diagnostics.Debug.WriteLine("Now playing");
        }
    }
}

