using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;


namespace YTRipper
{
    class MuxDownload: BaseYTVideoForm
    {
        InformationDownload informationDownload = new InformationDownload();
        static bool isDownloadComplete;
        public async void DefaultDownload(string httpsInput)
        {
            informationDownload.LoadingProgression = 25;
            loading_Label.Text = "Downloading...";
            //httpsInput.Text = "Test from Child";
            Uri videoUri = new Uri(httpsInput);
            string videoID = HttpUtility.ParseQueryString(videoUri.Query).Get("v");

            Video video = await BaseYTVideoForm.youtube.Videos.GetAsync(httpsInput);
            StreamManifest streamManifest = await BaseYTVideoForm.youtube.Videos.Streams.GetManifestAsync(videoID);

            //Get highest quality muxed stream
            IVideoStreamInfo streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            var progress = new Progress<double>();
            progress.ProgressChanged += DownloadProgress;
            // Actual downloads file
            await BaseYTVideoForm.youtube.Videos.Streams.DownloadAsync(streamInfo, $"D:\\video.{streamInfo.Container}", progress);
            
        }

        private void DownloadProgress(object sender, double e)
        {
            if (e >= 1)
            {
                informationDownload.LoadingProgression = 100;
                loading_Label.Text = "Complete";
            }
        }
        //protected override void ProgressBarChange() => progressBar.Value = 100; // changes through loading label

        //private double DownloadProgress()
        //{
        //    return 0.0;
        //}
        public async void MuxDownloadOptions(string httpsInput, IStreamInfo chosenAudioStreamInfo, string videoQaulity)
        {

            Uri videoUri = new Uri(httpsInput);
            string videoID = HttpUtility.ParseQueryString(videoUri.Query).Get("v");


            // Build presets of Converter
            ConversionRequestBuilder converter = new ConversionRequestBuilder("D:\\video.mp4");
            converter.SetFFmpegPath(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\bin\"+ Utilities.build + @"\runtimes\win-x64\MMTools\ffmpeg.exe"); // TODO: DEBUG into Release folder change
            converter.SetFormat("mp4");
            converter.SetPreset(ConversionPreset.UltraFast);



            StreamManifest streamManifest = await BaseYTVideoForm.youtube.Videos.Streams.GetManifestAsync(videoID);

            //var audioStreamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
            var videoStreamInfo = streamManifest.GetVideoStreams().First(s => s.VideoQuality.Label == videoQaulity); //"1080p60" Change this hard code
            videoStreamInfo.VideoQuality.Label.ToString();
            var streamInfos = new IStreamInfo[] { chosenAudioStreamInfo, videoStreamInfo };

            // Download and process them into one file
            await BaseYTVideoForm.youtube.Videos.DownloadAsync(streamInfos, converter.Build());
        }

    }
}
