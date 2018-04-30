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

[assembly: ExportRenderer(typeof(NativeMediaPlayerPage), typeof(NativeMediaPlayerRenderer))]
namespace NativeMediaPlayer.Droid
{
    public class NativeMediaPlayerRenderer : PageRenderer, TextureView.ISurfaceTextureListener
    {

        MediaPlayer player;


        public NativeMediaPlayerRenderer(Context context): base(context)
        {
            player = MediaPlayer.Create(context, Android.Net.Uri.Parse("https://shravanj.com/files/dev/vid.mp4"));
            PrepareMediaPlayer();
        }

        public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            player.Start();
        }

        public bool OnSurfaceTextureDestroyed(SurfaceTexture surface)
        {
            player.Stop();
            player.Release();
            return true;
        }

        public void OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
        {
            PrepareMediaPlayer();
        }

        public void OnSurfaceTextureUpdated(SurfaceTexture surface)
        {
            //empty method
        }

        public void PrepareMediaPlayer()
        {
            player.PrepareAsync();
        }

    }
}
