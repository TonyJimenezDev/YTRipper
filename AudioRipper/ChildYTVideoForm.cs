﻿using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTRipper
{
    public partial class ChildYTVideoForm : BaseYTVideoForm
    {

        MuxDownload muxDownload = new MuxDownload();
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
            //muxDownload.DefaultDownload(httpsInput_TextBox.Text);
            muxDownload.MuxDownloadOptions(httpsInput_TextBox.Text, informationDownload.ListAudioStreamInfo[0], informationDownload.ListVideoQuality[0]);
        }

        protected async override void LoadInfoPressed()
        {
            loading_Label.Visible = true;
            progressBar.Visible = true;
            informationDownload.LoadingProgression = 25;
            loading_Label.Text = "Loading:";
            info_RichTextBox.Text = await informationDownload.DefaultInfomation(httpsInput_TextBox.Text, videoImg_PictureBox);
            rating_Label.Text = informationDownload.Rating.ToString();
            // Add to a list/dropdown    informationDownload.GetVideoSettings(httpsInput_TextBox.Text);
            informationDownload.GetVideoSettings(httpsInput_TextBox.Text);
            informationDownload.GetAudioSettings(httpsInput_TextBox.Text);
            
        }

        protected override void ProgressBarChange()
        {
            progressBar.Value = informationDownload.LoadingProgression;
        }

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


    }
}