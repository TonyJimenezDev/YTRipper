using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTRipper
{
    public partial class ChildYTVideoForm : BaseYTVideoForm
    {

        InformationDownload informationDownload = new InformationDownload();
        Home home = new Home();

        protected override void OnStartUp()
        {
            home_Panel.Visible = true;
            home_Panel.BringToFront();
            mux_Panel.Visible = false;
            welcome_RichBox.Text = home.Introduction();
            tmpPanel = home_Panel;
            progressBar.Maximum = 100;
        }
        protected override void DownloadButtonPressed()
        {
            MuxDownload muxDownload = new MuxDownload();

            informationDownload.LoadingProgression = 0;
            loading_Label.Text = "Downloading..";
            //muxDownload.DefaultDownload(httpsInput_TextBox.Text);
            if(defaultLoadout_RB.Checked)
            {
                muxDownload.DefaultDownload(httpsInput_TextBox.Text);
                return;
            }            
            int audioSettingsIndex = audioSettings_CB.SelectedIndex;
            int videoSettingsIndex = videoOptions_CB.SelectedIndex;
            muxDownload.MuxDownloadOptions(httpsInput_TextBox.Text, informationDownload.ListAudioStreamInfo[audioSettingsIndex], informationDownload.ListVideoQuality[videoSettingsIndex]);

        }

        protected async override void LoadInfoPressed()
        {
            loading_Label.Visible = true;
            progressBar.Visible = true;
            informationDownload.LoadingProgression = 25;
            loading_Label.Text = "Loading..";
            info_RichTextBox.Text = await informationDownload.DefaultInfomation(httpsInput_TextBox.Text, videoImg_PictureBox);
            rating_Label.Text = informationDownload.Rating.ToString();
            informationDownload.LoadingProgression = 100;
            LoadOptions(await informationDownload.GetVideoSettings(httpsInput_TextBox.Text), await informationDownload.GetAudioSettings(httpsInput_TextBox.Text));
            //.LoadingProgression = 100;
        }

        protected override void ProgressBarChange() => progressBar.Value = informationDownload.LoadingProgression; // changes through loading label

        protected override void NaviButtonClicked(Panel panel, Button button)
        {
            //8.25            
            if (panel.Visible) return;            
            panel.Visible = true;
            tmpPanel.Visible = false;
            panel.BringToFront();
            button.Font = new Font("Reem Kufi", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
            tmpPanel = panel;
        }

        private void LoadOptions(bool isVidComplete, bool isAudComplete)
        {
            audioSettings_CB.Items.Clear();
            videoOptions_CB.Items.Clear();
            if(isVidComplete && isAudComplete)
            {
                foreach (var videoSetting in informationDownload.ListVideoQuality)
                {
                    if (videoSetting != null) videoOptions_CB.Items.Add(videoSetting);
                }
                informationDownload.LoadingProgression = 75;
                loading_Label.Text = "Loading...";
                foreach (var audioSettings in informationDownload.ListAudioStreamInfo)
                {
                    if (audioSettings != null) audioSettings_CB.Items.Add(audioSettings.ToString()); ///// TODO: you should be able to grab this via Index. List we create will have the exact same index as the array we store in it
                }
                informationDownload.LoadingProgression = 100;
                loading_Label.Text = "Complete";
            }

        }
    }
}
