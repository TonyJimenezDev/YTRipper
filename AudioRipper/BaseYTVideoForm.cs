using System;
using System.Windows.Forms;
using YoutubeExplode;


namespace YTRipper
{
    public partial class BaseYTVideoForm : Form
    {
        public static YoutubeClient youtube = new YoutubeClient();
        public static Panel tmpPanel;

        public BaseYTVideoForm()
        {
            InitializeComponent();
        }
        #region Button Events
        private void BaseYTVideoForm_Load(object sender, EventArgs e)
        {
            OnStartUp();
        }

        private void GetDownloadInfo(object sender, EventArgs e)
        {

            LoadInfoPressed();

            //string download = httpsInput_TextBox.Text;
            //using (var client = new WebClient())
            //{
            //    client.DownloadFile("https://www.youtube.com/watch?v=9CBPnduL9LQ", "D:\\Tony_Misc\\youtube.mp4");
            //}


            //Debug.WriteLine(download);
            //try
            //{
            //    Uri videoUri = new Uri(httpsInput_TextBox.Text);
            //    string videoID = HttpUtility.ParseQueryString(videoUri.Query).Get("v");
            //    string videoInfoUrl = "https://www.youtube.com/get_video_info?html5=1&video_id=" + videoID+ "&el=embedded"; //+ " & asv=3&el=detailpage&hl=en_US";
            //    //https://www.youtube.com/get_video_info?html5=1&video_id={videoID}

            //    HttpWebRequest request = WebRequest.CreateHttp(videoUri); // Made change
            //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //    Stream responseStream = response.GetResponseStream();
            //    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));

            //    string videoInfo = HttpUtility.HtmlDecode(reader.ReadToEnd());
            //    NameValueCollection videoParams = HttpUtility.ParseQueryString(videoInfo);

            //    if(videoParams["reason"] != null)
            //    {
            //        message_Label.Text = videoParams["reason"];
            //        return; // Issue with download
            //    }
            //    //foreach (var x in videoParams)
            //    //{
            //    //    Debug.WriteLine(x);
            //    //}
            //    string[] videoURLs = videoParams["url"].Split(',');
            //    //string[] videoURLs = videoParams["url_encoded_fmt_stream_map"].Split(',');

            //    foreach(string vURL in videoURLs)
            //    {
            //        string singleURL = HttpUtility.HtmlDecode(vURL);
            //        NameValueCollection urlParams = HttpUtility.ParseQueryString(singleURL);
            //        // TODO: Get a list of items inside urlParams
            //        string videoFormat = HttpUtility.HtmlDecode(urlParams["type"]);

            //        singleURL = HttpUtility.HtmlDecode(urlParams["url"]) + 
            //            "&signature=" + HttpUtility.HtmlDecode(urlParams["sig"]) + // 18 Description
            //            "&type=" + videoFormat + 
            //            "&title=" + HttpUtility.HtmlDecode(videoParams["title"] // 17
            //            );
            //        videoFormat = urlParams["quality"] + " - " + videoFormat.Split(';')[0].Split('/')[1];
            //        videoFormats_ListBox.Items.Add(new ListViewItem(videoFormat, singleURL));
            //    }

            //    videoFormats_ListBox.Visible = true;
            //    downloadInfo_Btn.Visible = true;
            //    message_Label.Text = "Video information";
            //    message_Label.ForeColor = Color.Green;
            //}
            //catch(Exception ex)
            //{
            //    message_Label.Text = ex.Message;
            //    message_Label.ForeColor = Color.Red;
            //    return;
            //}
        }

        private void DownloadBtn_Clicked(object sender, EventArgs e)
        {
            DownloadButtonPressed();

            //Uri videoUri = new Uri(httpsInput_TextBox.Text);
            //string videoID = HttpUtility.ParseQueryString(videoUri.Query).Get("v");
            //YoutubeClient youtube = new YoutubeClient();

            //// You can specify both video ID or URL
            //YoutubeExplode.Videos.Video video = await youtube.Videos.GetAsync(httpsInput_TextBox.Text);
            //StreamManifest streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoID);

            //string title = video.Title; // Title of vid
            //string author = video.Author.Title; // Aurthor name
            //TimeSpan? duration = video.Duration; //  duration 00:07:20

            //// Get highest quality muxed stream
            ////var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            ////// ...or highest bitrate audio-only stream
            //IStreamInfo streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

            ////// ...or highest quality MP4 video-only stream
            ////var streamInfo = streamManifest
            ////    .GetVideoOnlyStreams()
            ////    .Where(s => s.Container == Container.Mp4)
            ////    .GetWithHighestVideoQuality()


            //// Actual downloads file
            //await youtube.Videos.Streams.DownloadAsync(streamInfo, $"D:\\video.{streamInfo.Container}");
        }
        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            NaviButtonClicked(home_Panel, home_Btn);
        }
        private void MuxBtn_Clicked(object sender, EventArgs e)
        {
            NaviButtonClicked(mux_Panel, mux_Btn);
        }
        private void AudioBtn_Clicked(object sender, EventArgs e)
        {
            NaviButtonClicked(audio_Panel, audio_Btn);
        }
        private void VideoBtn_Clicked(object sender, EventArgs e)
        {
            NaviButtonClicked(video_Panel, video_Btn);
        }
        private void MediaBtn_Clicked(object sender, EventArgs e)
        {
            NaviButtonClicked(media_Panel, Media_Btn);
        }
        private void SettingsBtn_Clicked(object sender, EventArgs e)
        {
            NaviButtonClicked(settings_Panel, settings_Btn);
        }
        private void DownloadInfo_Btn_Click(object sender, EventArgs e)
        {
            LoadInfoPressed();
        }

        private void Minimize_Btn_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void Maximize_Btn_Click(object sender, EventArgs e)
        {
            
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                info_LayoutPanel.Height = 450;
                info_LayoutPanel.ColumnStyles[0].SizeType = SizeType.Percent;
                info_LayoutPanel.ColumnStyles[0].Width = 25;
                info_LayoutPanel.ColumnStyles[1].Width = 35;
                info_LayoutPanel.ColumnStyles[2].Width = 40;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                info_LayoutPanel.Height = 280;
                info_LayoutPanel.ColumnStyles[0].SizeType = SizeType.Percent;
                info_LayoutPanel.ColumnStyles[0].Width = 42;
                info_LayoutPanel.ColumnStyles[1].Width = 50;
                info_LayoutPanel.ColumnStyles[2].Width = 8;
            }
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        #region Virtual Functions
        protected virtual void OnStartUp()
        {
            throw new NotImplementedException("OnStartUp() does not have implementation");
        }
        protected virtual void DownloadButtonPressed()
        {
            throw new NotImplementedException("DownloadButtonPriessed() does not have implementation");
        }
        protected async virtual void LoadInfoPressed()
        {
            throw new NotImplementedException("LoadInfoPressed() does not have implementation");
        }
        //protected virtual void LoadOptions()
        //{
        //    throw new NotImplementedException("LoadOptions() does not have implementation");
        //}
        protected virtual void NaviButtonClicked(Panel panel, Button button)
        {
            throw new NotImplementedException("HomeBtn() does not have implementation");
        }
        #endregion

        private void HttpsInput_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e) => Utilities.MovePanelWinForms(Handle, e);

        private void Loading_Label_TextChanged(object sender, EventArgs e)
        {
            ProgressBarChange();
        }

        protected virtual void ProgressBarChange()
        {
            throw new NotImplementedException("ProgressBarChange() does not have implementation");
        }

        private void Rating_Label_TextChanged(object sender, EventArgs e)
        {
            //LoadOptions();
        }

    }
}
