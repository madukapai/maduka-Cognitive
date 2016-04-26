using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using Models;
using System.Drawing;

namespace VideoApp
{
    public partial class frmMain : Form
    {
        List<CognitiveModels.FaceDetectionEvent> objEvents = null;
        List<Rectangle> rect = new List<Rectangle>();
        int intTimeScale;
        Cognitive objCognitive = new Cognitive();

        public frmMain()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            plTag.BackColor = System.Drawing.Color.Transparent;
        }

        private async void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtVideo.Text = openFileDialog1.FileName;

                // 進行影片上傳的動作
                HttpResponseMessage response = await objCognitive.TrackingVideo(File.ReadAllBytes(txtVideo.Text));

                if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    txtOperationUrl.Text = ((string[])response.Headers.GetValues("Operation-Location"))[0];
                    txtResultUrl.Text = txtOperationUrl.Text + "/content";
                    tiGetStatus.Enabled = true;
                    btnTracking.Enabled = false;
                    btnOpen.Enabled = false;
                }
                else
                {
                    txtResponse.Text = response.ReasonPhrase + "\r\n" + txtResponse.Text;
                }
            }
        }

        private async void btnTracking_Click(object sender, EventArgs e)
        {
            string strVideoUrl = txtVideo.Text;
            HttpResponseMessage response = await objCognitive.TrackingVideo(strVideoUrl);
            
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                txtOperationUrl.Text = ((string[])response.Headers.GetValues("Operation-Location"))[0];
                txtResultUrl.Text = txtOperationUrl.Text + "/content";
                tiGetStatus.Enabled = true;
                btnTracking.Enabled = false;
                btnOpen.Enabled = false;
            }
            else
            {
                txtResponse.Text = response.ReasonPhrase + "\r\n" + txtResponse.Text;
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            this.RefreshOperation();
        }

        /// <summary>
        /// 每五秒取得一次目前進度的內容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiGetStatus_Tick(object sender, EventArgs e)
        {
            this.RefreshOperation();
        }

        private async void RefreshOperation()
        {
            string strTrackingUrl = txtOperationUrl.Text;
            HttpResponseMessage response = await objCognitive.GetVideoOperationStatus(strTrackingUrl);
            btnGetResult.Enabled = false;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Stream stream = await response.Content.ReadAsStreamAsync();
                byte[] bytes = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(bytes, 0, (int)stream.Length);
                try
                {
                    CognitiveModels.FaceDetection objFaces = JsonConvert.DeserializeObject<CognitiveModels.FaceDetection>(Encoding.ASCII.GetString(bytes));
                    lblStatus.Text = objFaces.status + ":" + objFaces.progress + "%";
                    if (objFaces.progress == 100)
                    {
                        btnGetResult.Enabled = true;
                        tiGetStatus.Enabled = false;
                        btnTracking.Enabled = true;
                        btnOpen.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    txtResponse.Text = ex.Message;
                }
            }
            else
            {
                txtResponse.Text = response.ReasonPhrase + "\r\n" + txtResponse.Text;
            }
        }

        /// <summary>
        /// 取得處理結果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGetResult_Click(object sender, EventArgs e)
        {
            string strResultUrl = txtResultUrl.Text;
            HttpResponseMessage response = await objCognitive.GetVideoResule(strResultUrl);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // 取得分析的結果
                Stream stream = await response.Content.ReadAsStreamAsync();
                byte[] bytes = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(bytes, 0, (int)stream.Length);
                string strContent = Encoding.ASCII.GetString(bytes);
                CognitiveModels.FaceDetectionResult objFaces = JsonConvert.DeserializeObject<CognitiveModels.FaceDetectionResult>(strContent);

                // 找出影片定義資訊
                string strVideoInfo = "timescale:" + objFaces.timescale.ToString() + "\r\n";
                strVideoInfo += "framerate:" + objFaces.framerate.ToString() + "\r\n";
                txtResponse.Text = strVideoInfo;
                intTimeScale = objFaces.timescale;

                objEvents = new List<CognitiveModels.FaceDetectionEvent>();
                // 定義主時間軸
                int intCurrTime = -1;

                // 找出影格數
                for (int i = 0; i < objFaces.fragments.Length; i++)
                {
                    if (objFaces.fragments[i].events != null)
                    {
                        
                        // 找出每一個影格中的事件
                        for (int f = 0; f < objFaces.fragments[i].events.Length; f++)
                        {
                            for (int ff = 0; ff < objFaces.fragments[i].events[f].Length; ff++)
                            {
                                if (objFaces.fragments[i].start >= intCurrTime)
                                    intCurrTime = objFaces.fragments[i].start;

                                objEvents.Add(
                                    new CognitiveModels.FaceDetectionEvent()
                                    {
                                        duration = objFaces.fragments[i].duration,
                                        interval = objFaces.fragments[i].interval,
                                        start = intCurrTime,
                                        id = objFaces.fragments[i].events[f][ff].id,
                                        height = objFaces.fragments[i].events[f][ff].height,
                                        width = objFaces.fragments[i].events[f][ff].width,
                                        x = objFaces.fragments[i].events[f][ff].x,
                                        y = objFaces.fragments[i].events[f][ff].y,
                                    }
                                );

                                intCurrTime += objFaces.fragments[i].interval;
                            }
                        }
                    }
                }

                gvTimeTable.DataSource = objEvents;
                axWindowsMediaPlayer1.URL = txtVideo.Text;
                this.btnPlay_Click(sender, e);
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
                btnPause.Enabled = true;
            }
            else
            {
                txtResponse.Text = response.ReasonPhrase + "\r\n" + txtResponse.Text;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            tiVideoSecound.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            tiVideoSecound.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void tiVideoSecound_Tick(object sender, EventArgs e)
        {
            lblVedioSecound.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString();
            // 根據載入的事件，比對目前的秒數，並匯出方格
            int intStart = (int)(axWindowsMediaPlayer1.Ctlcontrols.currentPosition * intTimeScale);
            int intLast = intStart - (tiVideoSecound.Interval * intTimeScale / 1000);
            lblVedioSecound.Text = intStart.ToString();

            List<CognitiveModels.FaceDetectionEvent> results = objEvents.FindAll(
                 delegate (CognitiveModels.FaceDetectionEvent evt) { return evt.start < intStart && evt.start > intLast; }
            );

            lblEventCount.Text = results.Count.ToString();
            rect.Clear();
            for (int i = 0; i < results.Count; i++)
            {
                // 取得事件的x,y以及height, width
                int intVedioWidth = axWindowsMediaPlayer1.Width;
                int intVedioHeight = axWindowsMediaPlayer1.Height;

                // 找出方框出現的X與Y
                int intX = (int)(intVedioWidth * results[i].x);
                int intY = (int)(intVedioHeight * results[i].y);
                //intX = axWindowsMediaPlayer1.Left + intX;
                //intY = axWindowsMediaPlayer1.Top + intY;

                // 找出方框的高度與寬度
                int intHeight = (int)(intVedioHeight * results[i].height);
                int intWidth = (int)(intVedioWidth * results[i].width);

                rect.Add(new Rectangle(intX, intY, intHeight, intWidth));
            }

            plTag.Invalidate();
        }

        /// <summary>
        /// 繪製方塊的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Green, 1))
            {
                for (int i = 0; i < rect.Count; i++)
                    e.Graphics.DrawRectangle(pen, rect[i]);
            }
        }

        private void plTag_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Green, 1))
            {
                for (int i=0; i<rect.Count; i++)
                    e.Graphics.DrawRectangle(pen, rect[i]);
            }
        }

    }
}