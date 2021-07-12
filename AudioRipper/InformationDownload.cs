using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YTRipper
{
    class InformationDownload
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTimeOffset UploadDate { get; set; }
        public Engagement Rating { get; set; }
        public IReadOnlyCollection<Thumbnail> Thumbnails { get; set; }
        public IStreamInfo[] ListAudioStreamInfo { get; set; }
        public string[] ListVideoQuality { get; set; }
        public int LoadingProgression { get; set; }



        public async ValueTask<string> DefaultInfomation(string httpsInput, PictureBox videoImg)
        {
            Video video = await BaseYTVideoForm.youtube.Videos.GetAsync(httpsInput);
            Title = video.Title; // Title of vid
            Author = video.Author.Title; // Aurthor name
            Duration = video.Duration; //  duration 00:07:20
            UploadDate = video.UploadDate;
            Thumbnails = video.Thumbnails;
            Description = video.Description;
            Rating = video.Engagement;
            videoImg.LoadAsync(Thumbnails.ElementAt(0).Url.Substring(0, Math.Max(Thumbnails.ElementAt(0).Url.IndexOf('?'), 0))); // Gets URL string.
            string infoRichText =
                    $"Title: {Title} \n" +
                    $"Author: {Author} \n" +
                    $"Duration: {Duration} \n" +
                    $"Upload Date: {UploadDate} \n" +
                    $"Description: {Description} \n";

            return infoRichText;
        }

        public async ValueTask<bool> GetVideoSettings(string httpsInput)
        {
            Uri videoUri = new Uri(httpsInput);
            string videoID = HttpUtility.ParseQueryString(videoUri.Query).Get("v");

            StreamManifest streamManifest = await BaseYTVideoForm.youtube.Videos.Streams.GetManifestAsync(videoID);
            ///////////////// Video Settings

            ListVideoQuality = streamManifest.GetVideoStreams().Select(e => e.VideoQuality.Label).Distinct().OrderByDescending(s => s).ToArray(); // Get all VideoQuality

            //return listVideoQuality;
            // Return IEnumerable or a list - Check efficiency 
            return true;



            ////////////////////////// Video settings ends

            //var videoStreamInfo = streamManifest.GetVideoStreams().First(s => s.VideoQuality.Label == "1080p60");
            //videoStreamInfo.VideoQuality.Label.ToString();
            //var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
        }

        public async ValueTask<bool> GetAudioSettings(string httpsInput)
        {

            Uri videoUri = new Uri(httpsInput);
            string videoID = HttpUtility.ParseQueryString(videoUri.Query).Get("v");

            StreamManifest streamManifest = await BaseYTVideoForm.youtube.Videos.Streams.GetManifestAsync(videoID);
            var audioStreamMP4 = streamManifest.GetAudioStreams().Where(a => a.Container == Container.Mp4).TryGetWithHighestBitrate();
            var audioStreamWebM = streamManifest.GetAudioStreams().Where(a => a.Container == Container.WebM).TryGetWithHighestBitrate();
            var audioStreamTGPP = streamManifest.GetAudioStreams().Where(a => a.Container == Container.Tgpp).TryGetWithHighestBitrate();

            ListAudioStreamInfo = new IStreamInfo[] { audioStreamMP4, audioStreamWebM, audioStreamTGPP };
            ////// ...or highest bitrate audio-only stream
            //IStreamInfo streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            
            return true;

        }
    }
}
