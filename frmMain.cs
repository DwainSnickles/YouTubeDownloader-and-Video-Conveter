using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Tyrrrz.Extensions;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using YoutubeDownloader.Properties;
using IDataObject = System.Windows.Forms.IDataObject;
using System.Diagnostics;
using NAudio.Wave;
using System.Text;
using System.Xml;
using AutoUpdaterDotNET;
using VideoLibrary;
using FFMPEG_CSWrapper;
using Logger;
using System.Configuration;
using Microsoft.WindowsAPICodePack.Shell;
//using static System.Collections.Generic.Dictionary<TKey, TValue>;

namespace YoutubeDownloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            axWindowsMediaPlayer2.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            this.simpleLogger = new SimpleLogger();

            this.lstVideoFiles.DoubleClick += new System.EventHandler(this.lstVideoFiles_DoubleClick);
            this.lstMP3s.DoubleClick += new System.EventHandler(this.lstMP3s_DoubleClick);
            this.btnAddMP3.Click += new System.EventHandler(this.btnAddMP3_Click);
            this.btnMoveMP3Down.Click += new System.EventHandler(this.btnMoveMP3Down_Click);
            this.btnRemoveMP3.Click += new System.EventHandler(this.btnRemoveMP3_Click);
            this.btnMoveMP3Down.Click += new System.EventHandler(this.btnMoveMP3Down_Click);
            this.FormClosing += Form1_FormClosing;
            this.tabControlAudioVideo.SelectedIndexChanged += new System.EventHandler(this.tabControlAudioVideo_SelectedIndexChanged);

            cbm = new ClipBoardMonitor();
            cbm.NewUrl += cbm_NewUrl;

            Directory.CreateDirectory(VideoFolderPath);
            Directory.CreateDirectory(MP3FolderPath);
            Directory.CreateDirectory(MP3NormalizeFolderPath);
            Directory.CreateDirectory(MP3ISOFolderPath);
            Directory.CreateDirectory(MP3TempFolderPath);
        }

        //private FileNameEx InputFile = null;
        //private Dictionary<int, PlaybackSession> outputDevices = new Dictionary<int, PlaybackSession>();
        public bool IsFormLoaded = false;
        private object PositionLock = new object();
        private String InputFilePath = String.Empty;
        private string m_Filename;
        private bool FilePlaying = false;
        private Process ffmpeg = new Process();
        private readonly ISimpleLogger simpleLogger;
        private IFFWrapper ffwraper;
        //static String ffmpgPath, ThumbNailPath;
        int ListboxSelectedIndex = 0;
        Silence.Audio PlayMP3File;
        string MP3Gain = AppDomain.CurrentDomain.BaseDirectory + "mp3gain\\MP3GainGUI.exe";
        //string MP3GainNoGUI = AppDomain.CurrentDomain.BaseDirectory + "mp3gain\\MP3Gain.exe -r -d11.0 *.mp3";
        string Audacity = AppDomain.CurrentDomain.BaseDirectory + "audacity-win-2.3.0\\audacity.exe";
        string AudacityHelp = AppDomain.CurrentDomain.BaseDirectory + "audacity-manual-2.3.0\\index.html";
        string VideoFolderPath = AppDomain.CurrentDomain.BaseDirectory + "Videos\\";
        string MP3FolderPath = AppDomain.CurrentDomain.BaseDirectory + "MP3s\\";
        string MP3NormalizeFolderPath = AppDomain.CurrentDomain.BaseDirectory + "Normalize\\";
        string MP3ISOFolderPath = AppDomain.CurrentDomain.BaseDirectory + "ISO\\";//MP3ISOFolderPath
        string MP3GainQuickHelp = AppDomain.CurrentDomain.BaseDirectory + "MP3GainQHelp\\default.html";
        string MP3TempFolderPath = AppDomain.CurrentDomain.BaseDirectory + "MP3Temp\\";
        string WebHelp = AppDomain.CurrentDomain.BaseDirectory + "html docs\\Welcome.html";
        //string ThumbnailPath = AppDomain.CurrentDomain.BaseDirectory + "FFmpeg\\ThumbNails\\ThumbImage.png";
        string ffmpgPath = AppDomain.CurrentDomain.BaseDirectory + "FFmpeg\\fffmpeg.exe";
        string CurSearchURL = String.Empty;
        string RenameFileType = String.Empty;
        String MediaFileInUse = String.Empty;
        String EditFileNamePath = String.Empty;
        Image CurImage = Resources.SongWave2;
        public object lb_item = null;
        String outputFilePath;
        String VideoFileName, VideoName;

        private static double MP3FolderSize;
        //int PBarValue = 0;

        private ClipBoardMonitor cbm = null;
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        enum SaveFileTypes
        {
            AudioFileOnly = 1,
            VideoFileOnly = 2,
            BothAudioAndVideo = 3,
        }

        private void tabControlAudioVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlAudioVideo.SelectedIndex)
            {
                case 0:
                    LoadMP3Files();
                    textProgressBarMax.Visible = true;
                    lblFileCount.Text = "Song Count =";
                    break;

                case 1:
                    textProgressBarMax.Visible = false;
                    lblFileCount.Text = "Video Count =";
                    LoadVideoFiles();
                    lblSongCount.Text = Convert.ToString(lstVideoFiles.Items.Count);
                    break;
            }

        }

        private async void cbm_NewUrl(string txt)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                btnPasteURL.PerformClick();
                this.BringToFront();
                return;
            }

            Boolean isOnline = CheckForInternetConnection();
            if (isOnline == false)
            {
                MessageBox.Show("Please check your internet connection and try again.", "No internet Found!");
                return;
            }
            Cursor = Cursors.WaitCursor;

            await GetVideoData(true);
            Cursor = Cursors.Default;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Boolean isOnline = CheckForInternetConnection();
            if (isOnline == false)
            {
                MessageBox.Show("Please check your internet connection and try again.", "No internet Found!");
            }
            getDir();
            LoadVideoEdit();
            LoadVideoFiles();
            LoadMP3Files();
            IsFormLoaded = true;
            GetVersion();
            webBrowser1.Navigate(WebHelp);
    }   

        private void getDir()
        {
            string executableName = Application.ExecutablePath;
            FileInfo executableFileInfo = new FileInfo(executableName);
            string executableDirectoryName = executableFileInfo.DirectoryName;
            string parentName = executableFileInfo.Directory.Parent.FullName;
            Properties.Settings.Default.ffmpegpath = executableFileInfo.Directory.Parent.FullName.Replace("\\bin", "\\FFmpeg\\ffmpeg.exe");
            Properties.Settings.Default.ThumbNailPath = executableFileInfo.Directory.Parent.FullName.Replace("\\bin", "\\FFmpeg\\ThumbNails\\Thumb.png");
            //MessageBox.Show(Properties.Settings.Default.ffmpegpath.ToString());
            Settings.Default.Save();
        }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        /// <summary>
        /// If given a YouTube URL, parses video id from it.
        /// Otherwise returns the same string.
        /// </summary>
        private static string NormalizeVideoId(string input)
        {
            string videoId = string.Empty; //assuming it's a string

            return YoutubeClient.TryParseVideoId(input, out videoId)
                ? videoId
                : input;
        }

        /// <summary>
        /// Turns file size in bytes into human-readable string.
        /// </summary>
        private static string NormalizeFileSize(long fileSize)
        {
            string[] units = { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            double size = fileSize;
            var unit = 0;

            while (size >= 1024)
            {
                size /= 1024;
                ++unit;
            }

            MP3FolderSize = Math.Round(size);

            return $"{size:0.#} {units[unit]}";
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    picIsConnected.Image = Properties.Resources.internet_ON;
                    return true;
                }
            }
            catch
            {
                picIsConnected.Image = Properties.Resources.internet_off;
                return false;
            }
        }

        #region Main Tab

        private void btnCancelDownload_Click(object sender, EventArgs e)
        {
            textProgressBar1.Visible = false;
            txtFileURL.Clear();
            btnDownLoadNSave.Enabled = false;
            ClearTextBoxes();
        }

        private void btnDeleteVideo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.currentPlaylist.clear();


            if (File.Exists(@VideoFolderPath + txtVideoTitle.Text + ".mp4"))
            {
                File.Delete(@VideoFolderPath + txtVideoTitle.Text + ".mp4");
            }

            btnDownLoadNSave.Enabled = true;
            LoadVideoFiles();
        }

        private void txtVideoTitle_TextChangedAsync(object sender, EventArgs e)
        {
            string NewText = txtVideoTitle.Text.Replace("?", "");
            txtVideoTitle.Text = NewText;
            txtVideoTitle.SelectionStart = txtVideoTitle.Text.Length + 1;
        }

        private void txtSaveVideoAs_TextChanged(object sender, EventArgs e)
        {
            string NewText = txtSaveVideoAs.Text.Replace("?", "");
            txtSaveVideoAs.Text = NewText;
            txtSaveVideoAs.SelectionStart = txtSaveVideoAs.Text.Length + 1;
        }

        private async void txtVideoMP4URL_TextChangedAsync(object sender, EventArgs e)
        {
            ClearTextBoxes();

            if (!txtFileURL.Text.StartsWith("https://"))
            { txtFileURL.Clear(); }
            if (txtFileURL.Text.Contains("youtu"))
            {

                textProgressBar1.Text = "Getting File Information...";
                btnDownLoadNSave.Enabled = false;
                //get video info and fill text boxes
                var client = new YoutubeClient();
                var videoId = NormalizeVideoId(txtFileURL.Text);
                var video = await client.GetVideoAsync(videoId);

                String s = YoutubeClient.ParseVideoId(txtFileURL.Text); // "bnsUkE8i0tU"
                String FileName = RemoveIllegalFileNameChars(video.Title);
                txtFileName.Text = FileName;
                txtVideoTitle.Text = FileName; // "Infected Mushroom - Spitfire [Monstercat Release]"
                txtAuthor.Text = video.Author; // "Monstercat"
                txtDuration.Text = video.Duration.ToString(); // 00:07:14
                btnCancelDownload.Enabled = true;
                btnDownLoadNSave.Enabled = true;
            }
        }

        private async void btnPasteURL_ClickAsync(object sender, EventArgs e)
        {
            // Retrieves data
            IDataObject iData = Clipboard.GetDataObject();
            // Is Data Text? 
            if (iData.GetDataPresent(DataFormats.Text))
                txtFileURL.Text = (String)iData.GetData(DataFormats.Text);

            String URL = txtFileURL.Text.Trim();

            if (URL.StartsWith("https://www.youtu"))
            {
                textProgressBar1.CustomText = "Preparing Download Request";
                textProgressBar1.Visible = true;
                btnPasteURL.Enabled = false;
                await GetVideoData(false);
                textProgressBar1.Visible = false;
            }
            else if (URL.StartsWith("https://youtu"))
            {
                textProgressBar1.CustomText = "Preparing Download Request";
                textProgressBar1.Visible = true;
                btnPasteURL.Enabled = false;
                await GetVideoData(false);
                textProgressBar1.Visible = false;
            }
            else
            {
                txtFileURL.Clear();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDownLoadNSave_Click(object sender, EventArgs e)
        {
            Boolean isOnline = CheckForInternetConnection();
            if (isOnline == false)
            {
                MessageBox.Show("Please check your internet connection and try again.", "No internet Found!");
                return;
            }

            textProgressBar1.Visible = true;

            ProcessUrl();

            if (txtFileURL.Text == string.Empty)
            {
                return;
            }

            //Save Video to video Folder
            SaveVideoToDisk(txtFileURL.Text, VideoFolderPath);
            
            //Gets the filename only
            var fileName = VideoName;

            //// Replace illegal characters in file name
            fileName = RemoveIllegalFileNameChars(fileName);

            tmrVideo.Enabled = true;

            //// Download video
            textProgressBar1.CustomText = "Downloading Audio/Video please wait ... ";

            //// Add Nuget package: https://www.nuget.org/packages/NReco.VideoConverter/ To Convert MP4 to MP3

            // Normalize the video
            Mp3FileNormalization(VideoFolderPath + "\\" + VideoName);

            var Convert = new NReco.VideoConverter.FFMpegConverter();

            //Create Mp3 delete if not needed
            string extension = Path.GetExtension(VideoName);
            String VidName = VideoName;
            String SaveMP3File = MP3FolderPath + VidName.Replace(".mp4", ".mp3").Trim();
            Convert.ConvertMedia(VideoFolderPath + "\\" + VideoName, SaveMP3File, "mp3");

            //Add code to handle different filetype eg save audio only video only or save both

            if (rbMp3Only.Checked == true)
            {

                tabControlAudioVideo.SelectedIndex = 0;

                File.Delete(VideoFolderPath + "\\" + VideoName);

                if (ckbAutoPlay.Checked)
                {
                    PlayFile(@SaveMP3File,1);
                }

            }

            if (rbVideoFileOnly.Checked == true)
            {

            tabControlAudioVideo.SelectedIndex = 1;

            File.Delete(SaveMP3File);

            if (ckbAutoPlay.Checked)
            {
                PlayFile(@VideoFolderPath + VideoName,1);
            }

            }

            if (rbAudioAndVideo.Checked == true)
            {

                tabControlAudioVideo.SelectedIndex = 0;

            if (ckbAutoPlay.Checked)
            {
                PlayFile(@SaveMP3File, 1);
            }

            }

            LoadMP3Files();
            LoadVideoFiles();
            ClearTextBoxes();
            txtFileURL.Clear();
            lblMessages.Text = String.Empty;
            textProgressBar1.Visible = false;
        }

        private void BtnDeleteVideo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.currentPlaylist.clear();

            if (File.Exists(@VideoFolderPath + txtVideoTitle.Text + ".mp4"))
            {
                File.Delete(@VideoFolderPath + txtVideoTitle.Text + ".mp4");
            }

            btnDownLoadNSave.Enabled = true;
            LoadVideoFiles();
        }

        private void SaveVideoToDisk(string link, String SaveToFolder)
        {
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video
            File.WriteAllBytes(@SaveToFolder + video.FullName, video.GetBytes());
            VideoName = video.FullName;
        }

        private void ConvertVideoToMP3(String fileName)
        {
            // Replace illegal characters in file name
            fileName = RemoveIllegalFileNameChars(fileName);
            var Convert = new NReco.VideoConverter.FFMpegConverter();
            String SaveMP3File = MP3FolderPath + fileName.Replace(".mp4", ".mp3").Trim();
            //SaveMP3File = MP3FolderPath + txtSaveVideoAs.Text + ".mp3".Trim();
            Convert.ConvertMedia(VideoFolderPath + fileName.Trim(), SaveMP3File, "mp3");
            LoadMP3Files();
            tabControlAudioVideo.SelectedIndex = 0;
            lstMP3s.SelectedItem = SaveMP3File;
        }

        private void ckbAudioOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAudioOnly.Checked)
            {
                btnDownLoadNSave.Text = "      Download MP3 Audio";
                // Select the image from the ImageList (using the ImageIndex property).    
                btnDownLoadNSave.ImageIndex = 7;
                lblFileExtension.Text = "MP3";
                label8.Text = "Rename MP3" + Environment.NewLine + "(Optional)";
                btnDownLoadNSave.Refresh();
                //picAudioVideo.Image = Properties.Resources.MP3;
                tabControlAudioVideo.SelectedIndex = 0;
            }
            else
            {
                btnDownLoadNSave.Text = "      Download MP4 Video";
                label8.Text = "Rename Video" + Environment.NewLine + "(Optional)";
                lblFileExtension.Text = "MP4";
                //picAudioVideo.Image = Properties.Resources.AudioVideo;
                tabControlAudioVideo.SelectedIndex = 1;
                btnDownLoadNSave.ImageIndex = 10;
            }

        }

        private void tmrVideo_Tick(object sender, EventArgs e)
        {
            if (lblMessages.BackColor == Color.White)
            {
                lblMessages.BackColor = Color.LightCoral;
            }
            else { lblMessages.BackColor = Color.White; }
        }

        private void CsPlaySelectedFile_Click(object sender, EventArgs e)
        {
            if (tabControlAudioVideo.SelectedIndex == 1)
            {
                if (lstVideoFiles.SelectedIndex == -1) { return; }
                else
                {
                    PlayFile(VideoFolderPath + lstVideoFiles.SelectedItem, 1);
                }
            }


            if (tabControlAudioVideo.SelectedIndex == 0)
                if (lstMP3s.SelectedIndex == -1) { return; }
                else
                {
                    PlayFile(MP3FolderPath + lstMP3s.SelectedItem,1);
                }
        }

        void item_Click(object sender, EventArgs e)
        {
            ToolStripItem clickedItem = sender as ToolStripItem;
            lblMessages.Text = "Converting MP4 file to MP3 Please wait...";
            ConvertVideoToMP3(clickedItem.Text);
            lblMessages.Text = "Conversion Completed";
        }

        private void DeleteFiles()
        {

            if (MediaFileInUse == lstMP3s.GetItemText(lstMP3s.SelectedItem))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }

            if (MediaFileInUse == lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }


            switch (tabControlAudioVideo.SelectedIndex)
            {
                case 0: //MP3 Tab Selected

                    if (lstMP3s.SelectedIndex == -1)
                    {
                        return;
                    }

                    String filepath = MP3FolderPath + lstMP3s.SelectedItem;
                    if (PlayMP3File != null) { PlayMP3File.Dispose(); }

                    if (File.Exists(filepath))
                    {
                        File.Delete(filepath);
                        LoadMP3Files();
                    }

                    break;

                case 1: //MP4 video files

                    if (lstVideoFiles.SelectedIndex == -1)
                    {
                        csDeleteVideo.Enabled = false;
                        csPlayVideo.Enabled = false;
                        return;
                    }

                    csDeleteVideo.Enabled = true;
                    csPlayVideo.Enabled = true;
                    filepath = VideoFolderPath + lstVideoFiles.SelectedItem;
                    string FileName = lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem);
                    axWindowsMediaPlayer1.currentPlaylist.clear();

                    if (File.Exists(filepath))
                    {
                        File.Delete(filepath);
                        LoadVideoFiles();
                    }
                    break;
            }

        }

        private void CsDeleteSelected_Click(object sender, EventArgs e)
        {
            DeleteFiles();
        }

        private void VideosMenu_Click(object sender, EventArgs e)
        {


            if (lstVideoFiles.SelectedIndex == -1) { return; }
            var Convert = new NReco.VideoConverter.FFMpegConverter();
            String MP4FileName = VideoFolderPath + lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem);
            String SaveMP3File = MP3FolderPath + lstVideoFiles.SelectedItem;
            SaveMP3File = SaveMP3File.Replace(".mp4", ".mp3").Trim();
            Convert.ConvertMedia(MP4FileName, SaveMP3File, "mp3");
            LoadMP3Files();
            tabControlAudioVideo.SelectedIndex = 0;
            lstMP3s.SelectedItem = Path.GetFileName(SaveMP3File);
        }

        private void addMP3FilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMP3Files(lstMP3s);
        }

        private void AddMP3Files(ListBox listbox)
        {
            this.ofdMP3.Filter = "MP3 files (*.mp3)|*.mp3";
            this.ofdMP3.Multiselect = true;
            this.ofdMP3.Title = "Select MP3 files to upload";
            DialogResult dr = this.ofdMP3.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in ofdMP3.FileNames)
                {
                    try
                    {
                        Mp3FileNormalization(file); //Normalize all mp3 files by default
                        String destFile = MP3FolderPath + Path.GetFileName(file.Trim());
                        File.Copy(file, destFile, true);

                        if (listbox == lstMP3s)
                        {
                            LoadMP3Files();
                            tabControlAudioVideo.SelectedIndex = 0;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void addVideoFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ofdMP3.Filter = "Video files (*.mp4)|*.mp4, (*.avi)| *.avi";
            this.ofdMP3.Multiselect = true;
            this.ofdMP3.Title = "Select Video files to upload";
            DialogResult dr = this.ofdMP3.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in ofdMP3.FileNames)
                {
                    try
                    {
                        String destFile = VideoFolderPath + Path.GetFileName(file.Trim());
                        File.Copy(file, destFile, true);
                        LoadVideoFiles();
                        tabControlAudioVideo.SelectedIndex = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void lstVideoFiles_DoubleClick(object sender, EventArgs e)
        {
            String Video = VideoFolderPath + lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem);
            PlayFile(Video, 1);
        }

        private void lstMP3s_DoubleClick(object sender, EventArgs e)
        {
            String MP3 = MP3FolderPath + lstMP3s.GetItemText(lstMP3s.SelectedItem);
            this.lstMP3s.HorizontalScrollbar = false;
            PlayFile(MP3, 1);
            this.lstMP3s.HorizontalScrollbar = true;

        }

        private void playMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMP3s.SelectedIndex != -1)
            {
                PlayFile(MP3FolderPath + lstMP3s.SelectedItem, 1);
            }
        }

        private void csmDeleteMP3_Click(object sender, EventArgs e)
        {
            DeleteFiles();
        }

        private void deleteMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CsDeleteSelected.PerformClick();
        }

        private void lstMP3s_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMP3s.SelectedIndex == -1)
            {
                cmsRnameMP3.Enabled = false;
                csmPlayMP3.Enabled = false;
                csmDeleteMP3.Enabled = false;
                cmsPlayAllMp3Files.Enabled = false;
            }

            if (lstMP3s.SelectedIndex != -1)
            {
                cmsRnameMP3.Enabled = true;
                csmPlayMP3.Enabled = true;
                csmDeleteMP3.Enabled = true;
                cmsPlayAllMp3Files.Enabled = true;
                txtCurMP3Name.Text = lstMP3s.SelectedItem.ToString();
                ListboxSelectedIndex = lstMP3s.SelectedIndex; //used for rename mp3
                txtCurMP3Name.Text = lstMP3s.GetItemText(lstMP3s.SelectedItem);
            }
        }

       private void lstVideoFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideoFiles.SelectedIndex != -1)
            {
                csDeleteVideo.Enabled = true;
                csPlayVideo.Enabled = true;
                txtCurMP3Name.Text = lstVideoFiles.SelectedItem.ToString();
                cmsPlayAllMp3Files.Enabled = true;
                csRenameVideo.Enabled = true;
            }
            else
            {
                csDeleteVideo.Enabled = false;
                csPlayVideo.Enabled = false;
                cmsPlayAllMp3Files.Enabled = false;
                csRenameVideo.Enabled = false;
            }
        } 
        
        private void cmsPlayAllMp3Files_Click(object sender, EventArgs e)
        {
            PlayAllMP3s();
        }

        private void csPlayVideo_Click(object sender, EventArgs e)
        {
            if (lstVideoFiles.SelectedIndex != -1)
            {
                PlayFile(VideoFolderPath + lstVideoFiles.SelectedItem, 1);
            }
        }

        private void csDeleteVideo_Click(object sender, EventArgs e)
        {
            if (lstVideoFiles.SelectedItem.ToString() == axWindowsMediaPlayer1.URL) { axWindowsMediaPlayer1.Ctlcontrols.stop(); }
            File.Delete(VideoFolderPath + lstVideoFiles.SelectedItem.ToString());
            LoadVideoFiles();
            lstVideoFiles.Refresh();
            csDeleteVideo.Enabled = false;
            csPlayVideo.Enabled = false;
        }

        private void PlayAllMP3s()
        {
            var myPlayList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("MyPlayList");

            foreach (string MP3file in lstMP3s.Items)
            {
                var mediaItem = axWindowsMediaPlayer1.newMedia(MP3FolderPath + MP3file);
                myPlayList.appendItem(mediaItem);
            }

            axWindowsMediaPlayer1.currentPlaylist = myPlayList;
            axWindowsMediaPlayer1.settings.autoStart = true;
            //axWindowsMediaPlayer1.URL = FilePath;
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnMoveMP3Up_Click(object sender, EventArgs e)
        {
            if (MediaFileInUse == lstMP3s.GetItemText(lstMP3s.SelectedItem))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            ListboxMoveItem(-1, lstMP3s);
        }

        private void btnMoveMP3Down_Click(object sender, EventArgs e)
        {
            if (MediaFileInUse == lstMP3s.GetItemText(lstMP3s.SelectedItem))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            ListboxMoveItem(1, lstMP3s);
        }

        private void btnAddMP3_Click(object sender, EventArgs e)
        {
            cmsMP3AddFiles.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void btnRemoveMP3_Click(object sender, EventArgs e)
        {
            if (lstMP3s.SelectedIndex == -1) { return; }
            if (MediaFileInUse == lstMP3s.GetItemText(lstMP3s.SelectedItem))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            string MP3FileName = lstMP3s.GetItemText(lstMP3s.SelectedItem);
            //MessageBox.Show(lstMP3BurnList.SelectedValue.C.ToString();
            String FileToDelete = MP3FolderPath + MP3FileName;
            File.Delete(FileToDelete);
            LoadMP3Files();
        }

        public void ListboxMoveItem(int direction, ListBox listBox1)
        {
            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox1.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox1.SelectedItem;

            // Removing removable element
            listBox1.Items.Remove(selected);
            // Insert it in new position
            listBox1.Items.Insert(newIndex, selected);
            // Restore selection
            listBox1.SetSelected(newIndex, true);
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMP3Files(lstMP3s);
        }

        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //use file dialog to add mp3 files from a folder to burnlist
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != string.Empty)
            {
                //copy all mp3 files ton burn folder
                string[] MP3files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                foreach (string MP3File in MP3files)
                {
                    if (MP3File.EndsWith(".mp3"))
                    
                    {
                        String FileName = Path.GetFileName(MP3File);
                        File.Copy(MP3File, MP3FolderPath + FileName, true);
                    }
                }
            }
            LoadMP3Files();
            Cursor = Cursors.Default;
        }

        private void BtnCancelDownload_Click(object sender, EventArgs e)
        {
            txtFileURL.Clear();
            btnDownLoadNSave.Enabled = false;
            ClearTextBoxes();
        }

        private void renameMP3FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Current MP3 Filename";
            label7.Text = "Enter New MP3 Filename";
            pnlRenameMP3.Visible = true;

        }

        private void btnCancelRename_Click(object sender, EventArgs e)
        {
            pnlRenameMP3.Visible = false;
        }

        private void btnRenameMP3_Click(object sender, EventArgs e)
        {

            Boolean ReLoadMP3 = false;

            {
                PlayMP3File.Dispose();
                ReLoadMP3 = true;
            }
            switch (tabControlAudioVideo.SelectedIndex)
            {
                case 0:
                    if (txtNewMP3FileName.Text == String.Empty) { return; }
                    //Check for a valid file nmae and ensure it has a .mp3 file ext.
                    String MP3Name = txtNewMP3FileName.Text;

                    if (MP3Name.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)
                    {
                        MessageBox.Show("The filename is invalid");
                        return;
                    }

                    else
                    {
                        String NewFilename = txtNewMP3FileName.Text.Trim();
                        if (!txtNewMP3FileName.Text.Trim().EndsWith(".mp3")) { txtNewMP3FileName.Text += ".mp3"; }
                         System.IO.File.Move(MP3FolderPath + txtCurMP3Name.Text.Trim(), MP3FolderPath + txtNewMP3FileName.Text.Trim());

                        if (ReLoadMP3)
                    {
                        PlayMP3File = new Silence.Audio(MP3FolderPath + txtNewMP3FileName.Text);
                    }
                    }

                    LoadMP3Files();
                    txtNewMP3FileName.Clear();

                   
                    break;

                case 1:

                    if (VideoFolderPath + lstVideoFiles.SelectedItem.ToString() == axWindowsMediaPlayer1.URL) { axWindowsMediaPlayer1.Ctlcontrols.stop(); }


                    //Check for a valid file nmae and ensure Current MP3 Name has a .mp3 file ext.
                    String MP4Name = txtNewMP3FileName.Text;

                    if (MP4Name.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)
                    {
                        MessageBox.Show("The filename is invalid");
                        return;
                    }

                    else
                    {
                        String NewFilename = txtNewMP3FileName.Text.Trim();
                        if (!txtNewMP3FileName.Text.Trim().EndsWith(".mp4")) { txtNewMP3FileName.Text += ".mp4"; }
                        System.IO.File.Move(VideoFolderPath + txtCurMP3Name.Text, VideoFolderPath + txtNewMP3FileName.Text.Trim());
                    }

                    LoadVideoFiles();
                    txtNewMP3FileName.Clear();
                    pnlRenameMP3.Visible = false;
                    break;
            }

        }

        private void renameMP3FileAVButton_Click(object sender, EventArgs e)
        {
            label6.Text = "Current Video Filename";
            label7.Text = "Enter New Video Filename";
            RenameFileType = "MP3";
            pnlRenameMP3.Visible = true;
        }

        private void renameVideo_Click(object sender, EventArgs e)
        {
            if (MediaFileInUse == lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
            label6.Text = "Current Video Filename";
            label7.Text = "Enter New Video Filename";
            pnlRenameMP3.Visible = true;
            RenameFileType = "Video";
        }

        private void TxtVideoTitle_TextChangedAsync(object sender, EventArgs e)
        {
            string NewText = txtVideoTitle.Text.Replace("?", "");
            txtVideoTitle.Text = NewText;
            txtVideoTitle.SelectionStart = txtVideoTitle.Text.Length + 1;
        }

        private void TxtSaveVideoAs_TextChanged(object sender, EventArgs e)
        {
            string NewText = txtSaveVideoAs.Text.Replace("?", "");
            txtSaveVideoAs.Text = NewText;
            txtSaveVideoAs.SelectionStart = txtSaveVideoAs.Text.Length + 1;
        }

        private async Task GetVideoData(Boolean ISBrowserRequest)
        {
            switch (ISBrowserRequest)
            {
                case true:

                    {
                      
                    }

                    break;

                case false:

                    //if (txtFileURL.Text.StartsWith("https://www.youtu"))
                    {
                        textProgressBar1.CustomText = "Getting File Information...";
                        lblMessages.Text = "Getting File Information...";
                        btnDownLoadNSave.Enabled = false;
                        //get video info and fill text boxes
                        var client = new YoutubeClient();
                        var videoId = NormalizeVideoId(txtFileURL.Text);
                        var video = await client.GetVideoAsync(videoId);

                        String s = YoutubeClient.ParseVideoId(txtFileURL.Text); // "bnsUkE8i0tU"
                        String FileName = RemoveIllegalFileNameChars(video.Title);
                        if (FileName.Contains('-'))
                        {
                            string[] SongList = FileName.Split("-");
                            txtAuthor.Text = SongList[0].Trim();
                            txtVideoTitle.Text = SongList[1].Trim();
                            //txtSaveVideoAs.Text = SongList[1].Trim();
                        }
                        else
                        {
                            txtAuthor.Text = video.Author.Trim(); ;
                            txtVideoTitle.Text = FileName.Trim(); ;
                        }

                        txtFileName.Text = FileName.Trim(); ;
                        txtDuration.Text = video.Duration.ToString(); // 00:07:14
                        btnCancelDownload.Enabled = true;
                        btnDownLoadNSave.Enabled = true;
                        //txtBrowserFileName.Text = FileName.Trim(); ;
                        textProgressBar1.CustomText = "Ready to Download...";
                        lblMessages.Text = "Ready to Download...";
                    }

                    break;
            }

        }

        private void ProcessUrl()
        {
            if (!txtFileURL.Text.StartsWith("https://youtu"))
            {
                lblMessages.Text = "Please enter a youtube URL and try again";
                txtFileURL.Clear();
                return;
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                lblMessages.Text = "Shutting down video file in use";
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }

            tabControlAudioVideo.SelectedIndex = 0;
            btnDownLoadNSave.Enabled = false;

            if (txtFileURL.Text.Contains("&"))
            {
                String[] NewURL = txtFileURL.Text.Split("&");
                txtFileURL.Text = NewURL[0];
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            btnDownLoadNSave.Enabled = false;
            FilePlaying = false;

            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                case 0:    // Undefined
                    //currentStateLabel.Text = "Undefined";
                    break;

                case 1:    // Stopped
                    //currentStateLabel.Text = "Stopped";
                    btnDownLoadNSave.Enabled = true;
                    break;

                case 2:    // Paused
                           //currentStateLabel.Text = "Paused";
                    break;

                case 3:    // Playing
                           //currentStateLabel.Text = "Playing";
                    btnDownLoadNSave.Enabled = false;
                    FilePlaying = true;
                    break;

                case 4:    // ScanForward
                    //currentStateLabel.Text = "ScanForward";
                    break;

                case 5:    // ScanReverse
                    //currentStateLabel.Text = "ScanReverse";
                    break;

                case 6:    // Buffering
                    //currentStateLabel.Text = "Buffering";
                    break;

                case 7:    // Waiting
                    //currentStateLabel.Text = "Waiting";
                    break;

                case 8:    // MediaEnded
                    //currentStateLabel.Text = "MediaEnded";
                    break;

                case 9:    // Transitioning
                    //currentStateLabel.Text = "Transitioning";
                    break;

                case 10:   // Ready
                    //currentStateLabel.Text = "Ready";
                    break;

                case 11:   // Reconnecting
                    //currentStateLabel.Text = "Reconnecting";
                    break;

                case 12:   // Last
                    //currentStateLabel.Text = "Last";
                    break;

                default:
                    //currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
                    FilePlaying = false;
                    break;
            }
        }

        private void LoadVideoFiles()
        {
            //load all vidoes in listbox
            lstVideoFiles.Items.Clear();
            string folder = @VideoFolderPath;
            List<string> VidFiles = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories).Where(file => new string[] { ".mp4", ".avi", ".wbem" }
            .Contains(Path.GetExtension(file))).ToList();


            foreach (string VFiles in VidFiles)
            {
                string Fname = Path.GetFileName(VFiles);
                lstVideoFiles.Items.Add(Fname);
            }

            CSselectVideoFile.DropDownItems.Clear();

            foreach (String Item in lstVideoFiles.Items)
            {
                CSselectVideoFile.DropDownItems.Add(Item);
            }

            foreach (ToolStripItem mnuitem in CSselectVideoFile.DropDownItems)
            {
                //Add click event hander for each new menuitem added
                mnuitem.Click += new EventHandler(item_Click);
            }

            lblFolderName.Text = "Current Video Folder Size = ";
            long FileSize = DirSize(VideoFolderPath, true);
            lblFolderSize.Text = NormalizeFileSize(FileSize);
        }

        private void LoadMP3Files()
        {
            //load all vidoes in listbox
            lstMP3s.Items.Clear();
            string folder = @MP3FolderPath;
            string[] MP3Files = Directory.GetFiles(folder, "*.mp3");
            foreach (string VFiles in MP3Files)
            {
                string Fname = Path.GetFileName(VFiles);
                lstMP3s.Items.Add(Fname);
            }
            long FileSize = DirSize(MP3FolderPath, true);
            lblFolderSize.Text = NormalizeFileSize(FileSize);
            lblFolderName.Text = "Current MP3 Folder Size = ";
            lblSongCount.Text = Convert.ToString(lstMP3s.Items.Count);

            //need to check and make sure the list does not exceed  685

            if (Convert.ToInt32(MP3FolderSize) >= 688)
            {
                Settings.Default.OverBurnSize = true;
                textProgressBarMax.ProgressColor = Color.Red;
                textProgressBarMax.CustomText = "Exceeded CDR Burn Size";
            }
            else
            {
                Settings.Default.OverBurnSize = false;
                textProgressBarMax.ProgressColor = Color.LawnGreen;
                textProgressBarMax.CustomText = "Burn Size = " + NormalizeFileSize(FileSize);
                textProgressBarMax.Value = Convert.ToInt32(MP3FolderSize);
            }

        }
     
        private void PlayFile(string FilePath, int MediaPlayer)
        {
            if (MediaPlayer == 1)
            {
                 axWindowsMediaPlayer1.settings.autoStart = true;
                 axWindowsMediaPlayer1.URL = FilePath;
                 MediaFileInUse = Path.GetFileName(FilePath);
                 axWindowsMediaPlayer1.Ctlcontrols.next();
                 axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (MediaPlayer == 2)
            {
                axWindowsMediaPlayer2.settings.autoStart = true;
                axWindowsMediaPlayer2.URL = FilePath;
                MediaFileInUse = Path.GetFileName(FilePath);
                axWindowsMediaPlayer2.Ctlcontrols.next();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
           
        }

        public static string RemoveIllegalFileNameChars(string input, string replacement = "")
        {
            if (input.Contains("?"))
            {
                input = input.Replace('?', char.Parse(" "));
            }
            if (input.Contains("&"))
            {
                input = input.Replace('&', char.Parse("-"));
            }
            var regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));

            // check for non asccii characters
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            char[] chars = Encoding.ASCII.GetChars(bytes);
            string line = new String(chars);
            line = line.Replace("?", "");
            //MessageBox.Show(line);
            return r.Replace(line, replacement);
        }


        private void ClearTextBoxes()
        {
            //Main Texboxes
            txtFileName.Clear();
            txtVideoTitle.Clear();
            txtAuthor.Clear();
            txtDuration.Clear();
            txtSaveVideoAs.Clear();
            lblMessages.Text = String.Empty;
            btnPasteURL.Enabled = true;
        }

        #endregion

        private void txtFileName_TextChanged_1(object sender, EventArgs e)
        {
            if (tabControlAudioVideo.SelectedIndex == 1)
            {

            }
        }

        private void tabControl11_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.currentPlaylist.clear();

            //if (tabControlMain.SelectedIndex == 1 && ckbAutoMaximize.CheckState == CheckState.Checked) { WindowState = FormWindowState.Maximized; }

            if (tabControlMain.SelectedIndex != 1 && WindowState == FormWindowState.Maximized) { WindowState = FormWindowState.Normal; }

            if (tabControlAudioVideo.SelectedIndex == 0)
            {
                ClearTextBoxes();
                txtFileURL.Clear();
                LoadMP3Files();
            }
            if (tabControlAudioVideo.SelectedIndex == 1)
            {
                LoadVideoFiles();
            }
        }

        private void btnCheckIConnection_Click(object sender, EventArgs e)
        {
            CheckForInternetConnection();
        }

       
        private void renameMP3File_Click(object sender, EventArgs e)
        {
            if (lstMP3s.SelectedIndex != -1)
            {
                if (MediaFileInUse == lstMP3s.GetItemText(lstMP3s.SelectedItem))
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.currentPlaylist.clear();
                }
                //pnlMain.Visible = false;
                pnlRenameMP3.Width = 897;
                pnlRenameMP3.Visible = true;
                var Song = lstMP3s.SelectedItem;
                txtCurMP3Name.Text = Song.ToString();
                pnlRenameMP3.Visible = true;

            }
        }

        private void CsDeleteSelected_Click_1(object sender, EventArgs e)
        {
            DeleteFiles();
        }

        private void csmPlayMP3_Click(object sender, EventArgs e)
        {
            if (lstMP3s.SelectedIndex != -1)
            {
                String SongToPlay = MP3FolderPath + lstMP3s.SelectedItem;
                PlayFile(SongToPlay, 1);
                
            }
        }

        private void CsConvertMP4ToMP3_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex == 1)
            {
                if (lstVideoFiles.SelectedIndex != -1)
                {
                    var Song = lstVideoFiles.SelectedItem;
                    ConvertVideoToMP3(Song.ToString().Trim());
                }
            }
        }
       
        private static long DirSize(string sourceDir, bool recurse)
        {
            long size = 0;
            string[] fileEntries = Directory.GetFiles(sourceDir);

            foreach (string fileName in fileEntries)
            {
                Interlocked.Add(ref size, (new FileInfo(fileName)).Length);
            }

            if (recurse)
            {
                string[] subdirEntries = Directory.GetDirectories(sourceDir);

                Parallel.For<long>(0, subdirEntries.Length, () => 0, (i, loop, subtotal) =>
                {
                    if ((File.GetAttributes(subdirEntries[i]) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
                    {
                        subtotal += DirSize(subdirEntries[i], true);
                        return subtotal;
                    }
                    return 0;
                },
                    (x) => Interlocked.Add(ref size, x)
                );
            }
            return size;
        }

        private void Mute()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void btnVolDown_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void btnVolUp_Click(object sender, EventArgs e)
        {
            VolUp();
        }

        private void btnVolMute_Click(object sender, EventArgs e)
        {
            Mute();
        }
      
        private void btnMainVolUp_Click(object sender, EventArgs e)
        {
            VolUp();
        }

        private void btnMainVolDown_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void btnMainMute_Click(object sender, EventArgs e)
        {
            Mute();

        }

        private void textProgressBar1_VisibleChanged(object sender, EventArgs e)
        {
            if (textProgressBar1.Visible)
            {
                tmrMarquee.Enabled = true;
            }
            else
            {
                tmrMarquee.Enabled = false;
            }
        }

        private void tmrMarquee_Tick(object sender, EventArgs e)
        {
            textProgressBar1.Value += 5;
            if (textProgressBar1.Value == 110)
            {
                textProgressBar1.Value = 5;
            }
        }

        private void bttnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }

        private void btnLoadBroswer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(MP3Gain);
        }

        private void btnAudacity_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Audacity);
        }

        private void btnAudacityHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AudacityHelp);
        }

        private void linkLabelMP3GainHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mp3gain.sourceforge.net/faq.php");
        }

        private void btnBurnCD_Click(object sender, EventArgs e)
        {
            BurnMedia.MainBurnForm frmBurn = new BurnMedia.MainBurnForm();
            if (rbAutoLoad.Checked)
            {
                frmBurn.AutoLoadFiles = true;
            }
          
            if (rbNoAutoLoad.Checked)
            {
                frmBurn.AutoLoadFiles = false;
            }

            frmBurn.Show();
        }

        private void btnCancelRename_Click_1(object sender, EventArgs e)
        {
            pnlRenameMP3.Visible = false;
        }

        private void mp3Normalization(String MP3FilePath)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string fname in ofd.FileNames)
                {
                    Process pp = new Process();

                    pp.StartInfo.FileName = Application.StartupPath + "\\mp3gain.exe";
                    pp.StartInfo.Arguments = "/r /d 20 /k /c " + MP3FilePath + "";
                    pp.Start();
                    pp.WaitForExit();
                }
                MessageBox.Show("All files successfully normalized.");
            }
        }

        /// <summary>
        /// Normalize mp3 single file with full path including mp3Name.mp3
        /// </summary>
        /// <param name="MP3FilePath"></param>
        private void Mp3FileNormalization(String MP3FilePath)
        {
            //C:\Users\TattleTale\Documents\YoutubeDownloader\YoutubeDownloader\mp3gain\mp3gain.exe 
            // / d10.0 /q  /c /t  "C:\Users\TattleTale\Documents\YoutubeDownloader\YoutubeDownloader\bin\Debug\MP3Temp\Achy Breaky Heart.mp3"
            //string path = Path.GetFullPath(@MP3FilePath);
            String ArgsMP3Path = "/d 10.0 /c /t /q \"" + MP3FilePath + "\"";
            //String ArgsMP3Path = "/d 7.0 /c /a " + MP3FilePath + "\\";
            //MessageBox.Show(ArgsMP3Path);
            Process pp = new Process();
            // Stop the process from opening a new window
            pp.StartInfo.RedirectStandardOutput = true;
            pp.StartInfo.UseShellExecute = false;
            pp.StartInfo.CreateNoWindow = true;
            pp.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "mp3gain\\mp3gain.exe";
            pp.StartInfo.Arguments = ArgsMP3Path;
            pp.Start();
            pp.WaitForExit();

        }

            /// <summary>
            /// Will process a whole folder if needed by passing the folder path
            /// </summary>
            /// <param name = "MP3Folder" ></ param >
            private void Mp3FolderNormalization(String MP3FolderPath)
        {
            Cursor = Cursors.WaitCursor;
            var MP3directory = System.IO.Path.GetDirectoryName(MP3FolderPath + "\\");
            var MP3files = System.IO.Directory.GetFiles(MP3directory, "*.mp3");

            foreach (string fname in MP3files)
            {
                Process pp = new Process();
                // Stop the process from opening a new window
                pp.StartInfo.RedirectStandardOutput = true;
                pp.StartInfo.UseShellExecute = false;
                pp.StartInfo.CreateNoWindow = true;

                String ArgsMP3Path = "/d 7.0 /c /a " + "\"" + fname + "\"";
                //MessageBox.Show(ArgsMP3Path);
                pp.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "mp3gain\\mp3gain.exe";
                pp.StartInfo.Arguments = ArgsMP3Path;
                pp.Start();
                pp.WaitForExit();
            }
            Cursor = Cursors.Default;
        }

        private void editMP3WithAudacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process pp = new Process();
            //String FileCommand = MP3FolderPath + lstMP3s.GetItemText(lstMP3s.SelectedItem);
            pp.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "audacity-win-2.3.0\\audacity.exe"; // + FileCommand;
            //pp.StartInfo.Arguments = FileCommand; 
            pp.Start();
            pp.WaitForExit();
            //$  audacity file1.aiff file2.wav file3.ogg
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();
            FDB.ShowDialog();
            Mp3FolderNormalization(FDB.SelectedPath);
        }

       
        private void btnStopBrowserMediaPlayer_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private TimeSpan SongLenght(String SongPath)
        {
            Mp3FileReader reader = new Mp3FileReader(SongPath);
            return reader.TotalTime;
        }

        void TrimMp3(string inputPath, string outputPath, TimeSpan? begin, TimeSpan? end)
        {
            PlayMP3File.Dispose();
            if (begin.HasValue && end.HasValue && begin > end)
                throw new ArgumentOutOfRangeException("end", "end should be greater than begin");

            using (var reader = new Mp3FileReader(inputPath))
                
            using (var writer = File.Create(outputPath))
            {
                Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                    if (reader.CurrentTime >= begin || !begin.HasValue)
                    {
                        if (reader.CurrentTime <= end || !end.HasValue)
                            writer.Write(frame.RawData, 0, frame.RawData.Length);
                        else break;
                    }
            }
        }


        public static bool isFileLocked(string FileName)
        {
            FileStream fs = null;

            try
            {
                // NOTE: This doesn't handle situations where file is opened for writing by another process but put into write shared mode, it will not throw an exception and won't show it as write locked
                fs = File.Open(FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None); // If we can't open file for reading and writing then it's locked by another process for writing
            }
            catch (UnauthorizedAccessException) // https://msdn.microsoft.com/en-us/library/y973b725(v=vs.110).aspx
            {
                // This is because the file is Read-Only and we tried to open in ReadWrite mode, now try to open in Read only mode
                try
                {
                    fs = File.Open(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                }
                catch (Exception)
                {
                    return true; // This file has been locked, we can't even open it to read
                }
            }
            catch (Exception)
            {
                return true; // This file has been locked
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return false;
        }

        private void txtNewFileName_TextChanged(object sender, EventArgs e)
        {
            txtNewMP3FileName.Text.Trim();
        }

        private void renameMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNewMP3FileName.Clear();
            pnlRenameMP3.Visible = true;
            pnlMain.Visible = false;
        }

        private void btnCancelRename_Click_2(object sender, EventArgs e)
        {
            txtNewMP3FileName.Clear();
            pnlRenameMP3.Visible = false;
            pnlMain.Visible = true;
        }

        private void btnRenameMP3_Click_1(object sender, EventArgs e)
        {
            if (txtNewMP3FileName.Text != String.Empty)
            {
                if (!txtNewMP3FileName.Text.EndsWith(".mp3")) { txtNewMP3FileName.Text += ".mp3"; }

                String OldFileName = MP3FolderPath + txtCurMP3Name.Text;
                String NewFileName = MP3FolderPath + txtNewMP3FileName.Text.Trim();

                if (File.Exists(NewFileName))
                {
                    System.IO.File.Delete(NewFileName);
                }

                System.IO.File.Move(OldFileName, NewFileName.Trim());
                pnlRenameMP3.Visible = false;
                LoadMP3Files();
                txtNewMP3FileName.Clear();
                lstMP3s.SelectedIndex = -1;
            }
        }

        private void btnTagOpenMP3_Click(object sender, EventArgs e)
        {
            if (audioOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                audioOpenFileDialog.InitialDirectory = MP3FolderPath;
                LoadFile(audioOpenFileDialog.FileName);
            }
        }

        private void LoadFile(string path)
        {
            m_Filename = path;

            ucID3v2.ClearTextboxes();
            ucID3v2.LoadFile(m_Filename);

            btnTagSaveTag.Enabled = true;
           
        }

        private void SaveFile(string path)
        {
            ucID3v2.SaveFile(path);
            ucID3v2.ClearTextboxes();
            //LoadFile(path);
        }

        private void btnTagSaveTag_Click(object sender, EventArgs e)
        {
            SaveFile(m_Filename);

        }

        private void ckbAudioOnly_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckbAudioOnly.CheckState == CheckState.Checked)
            {
                picAudioVideo.Image = Properties.Resources.MP3;
                tabControlAudioVideo.SelectedIndex = 0;
                btnDownLoadNSave.Text = "       Download MP3 Audio";
            }
            else
            {
                picAudioVideo.Image = Properties.Resources.AudioVideo;
                tabControlAudioVideo.SelectedIndex = 1;
                btnDownLoadNSave.Text = "       Download Video";
            }
        }

        private void btnRefreshMP3List_Click(object sender, EventArgs e)
        {
            LoadMP3Files();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 3;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControlAudioVideo.SelectedIndex = 1;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControlAudioVideo.SelectedIndex = 0;
        }

        private void pictureBox4_MouseEnter_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox7_MouseEnter_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox7_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox10_MouseEnter_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox10_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseEnter_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        //private void lstMP3s_MouseEnter(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.Hand;
        //}

        //private void lstMP3s_MouseLeave(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.Default;
        //}

        //private void lstVideoFiles_MouseEnter(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.Hand;
        //}

        //private void lstVideoFiles_MouseLeave(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.Default;
        //}

        private void openMP3FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioOpenFileDialog.InitialDirectory = MP3FolderPath;
            audioOpenFileDialog.ShowDialog();
        }

        private void openVideoFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioOpenFileDialog.InitialDirectory = VideoFolderPath;
            audioOpenFileDialog.Filter = "";
            audioOpenFileDialog.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Http://www.productfast.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.paypal.me/YTDPlatinum");
        }

        private void btnVideoFullScreen_Click(object sender, EventArgs e)
        {
            if (FilePlaying == true)
            {
              axWindowsMediaPlayer1.fullScreen = true;
            }
            
        }

        private void btnMainHelp_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void btnMainBurn_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void btnMainTRiM_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void btnMainTE_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void lstMP3s_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String MP3 = MP3FolderPath + lstMP3s.GetItemText(lstMP3s.SelectedItem);
            this.lstMP3s.HorizontalScrollbar = false;
            PlayFile(MP3, 1);
            this.lstMP3s.HorizontalScrollbar = true;
        }

        private void lstMP3s_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Collections.Specialized.StringCollection fileList = new System.Collections.Specialized.StringCollection();
                fileList.Add(MP3FolderPath + lstMP3s.GetItemText(lstMP3s.SelectedItem));
                DataObject dataObj = new DataObject();
                dataObj.SetFileDropList(fileList);

                lstMP3s.DoDragDrop(dataObj, DragDropEffects.Move);
                LoadMP3Files();
            }
        }

        private void lstVideoFiles_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Collections.Specialized.StringCollection fileList = new System.Collections.Specialized.StringCollection();
                fileList.Add(VideoFolderPath + lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem));
                DataObject dataObj = new DataObject();
                dataObj.SetFileDropList(fileList);

                lstVideoFiles.DoDragDrop(dataObj, DragDropEffects.Move);
                LoadVideoFiles();
            }
           
        }

        private void lstVideoFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String Video = VideoFolderPath + lstVideoFiles.GetItemText(lstVideoFiles.SelectedItem);
            this.lstVideoFiles.HorizontalScrollbar = false;
            PlayFile(Video, 1);
            this.lstMP3s.HorizontalScrollbar = true;
        }

        private void llemailSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", "dwains102@gmail.com", "Youtube Downloader Platinum", "");
            System.Diagnostics.Process.Start(mailto);
        }

        String CurVersion = Properties.Settings.Default.CurrentVersion;
        
        //private void llCheckForUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;
        //    switch (VersionCheck())
        //    {
        //        case true:
        //            MessageBox.Show("You are running the newest version.");
        //            break;

        //        case false:
        //            AutoUpdater.Start("http://productfast.com/YTDP.xml");
        //            break;
        //    }
        //    Cursor = Cursors.Default;
        //}

        // /// <summary>
        // /// Compares the website xml file to the version listed in properties Current Version if equal no updates needed.
        // /// Both must be changed to initialize an update.
        // /// </summary>
        // /// <returns></returns>
        //private bool VersionCheck()
        // {
        //     XmlDocument xDoc = new XmlDocument();
        //     xDoc.Load("http://productfast.com/YTDP.xml");
        //     XmlNodeList TheVersion = xDoc.GetElementsByTagName("version");
        //     //String VersionCheck = "version xml: " + TheVersion[0].InnerText + Environment.NewLine + "Actual Ver " + TheVersion;
        //     //MessageBox.Show(VersionCheck);
        //     Version version = new Version(Application.ProductVersion); //gets version from assinfo.cs
        //     MessageBox.Show(version.ToString());
        //     if (TheVersion[0].InnerText == Properties.Settings.Default.CurrentVersion)
        //     {
        //         return false;
        //     }
        //     else { return true; } //update is avaialable
        //     //MessageBox.Show("version: " + TheVersion[0].InnerText);
        // }

        private void GetVersion()
        {
            Version version = new Version(Application.ProductVersion);
            this.Text = this.Text + " " + version.ToString();

            //MessageBox.Show(version.ToString());
        }

        private void llCheckForUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("http://productfast.com/YTDP.xml");
            XmlNodeList TheVersion = xDoc.GetElementsByTagName("version");
            String XMLVersion = "version xml: " + TheVersion[0].InnerText + Environment.NewLine + "Actual Ver " + TheVersion;
            //MessageBox.Show(XMLVersion);
            Version APPVersion = new Version(Application.ProductVersion);
            //MessageBox.Show(APPVersion.ToString());
            if (TheVersion[0].InnerText == APPVersion.ToString())
            {
                MessageBox.Show("Youtube Downloader Platinum is up to date.");
            }
            else
            {
                Cursor = Cursors.WaitCursor;

                AutoUpdater.Mandatory = true;
                //AutoUpdater.ShowSkipButton = true;
                //AutoUpdater.ShowRemindLaterButton = true;
                AutoUpdater.Start("http://productfast.com/YTDP.xml");
                //MessageBox.Show("Update Avaiable");
                Cursor = Cursors.Default;
            }
        }

        private void mmuConvertVideo_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string strCmdLine = "-i " + "G:\\VideoEdit\\VideoEdit\\FFmpeg\\Temp\\PictureMe.mp4 "  + "G:\\VideoEdit\\VideoEdit\\FFmpeg\\Temp\\PictureMe.avi";
            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.FileName = @"C:\Users\dwain.DESKTOP-PBV6NB0\Documents\Visual Studio 2017\Projects\YoutubeDownloader - Copy\YoutubeDownloader\FFmpeg\ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = strCmdLine;
            ffmpeg.EnableRaisingEvents = true;
            ffmpeg.Start();
            Cursor = Cursors.Default;
        }

        #region Video Edit Tab

        private bool LoadVideoEdit()
        {

            string executableName = Application.ExecutablePath;
            FileInfo executableFileInfo = new FileInfo(executableName);
            string executableDirectoryName = executableFileInfo.DirectoryName;
            string parentName = executableFileInfo.Directory.Parent.FullName;
            string PathName = parentName.Remove(parentName.LastIndexOf("\\", parentName.Length));
            String ffmpegPath = PathName + "\\FFmpeg\\ffmpeg.exe";
            ffmpgPath = PathName + "\\FFmpeg\\ffmpeg.exe";
            Properties.Settings.Default.ThumbNailPath = PathName +  @"\FFmpeg\ThumbNails\Thumb.png";
            //Set the path to mpeg in app config.based on the end users path which is unknown.
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["FFMPEG_PATH"].Value = ffmpegPath;
            Properties.Settings.Default.ffmpegpath = ffmpegPath;
            config.Save(ConfigurationSaveMode.Modified);
            //ThumbNailPath = PathName +
            //C:\Users\dwain.DESKTOP-PBV6NB0\Downloads\FFGUI-master\FFGUI-master\FFGUI\FFGUI\FFmpeg\ThumbNails\
            var ffmpeg = ConfigurationManager.AppSettings["FFMPEG_PATH"];
            simpleLogger.LogMessage($"Using ffmpeg at: \"{ffmpeg}\"");
            ffwraper = new FFWrapper(simpleLogger, ffmpeg);
            ffwraper.OnProgressChanged += Ffwraper_OnProgressChanged;
            ffwraper.OnCompleted += Ffwraper_OnCompleted;

            saveFileDialog1.Filter = Resources.FileFormats;
            saveFileDialog1.DefaultExt = "MP4";

            conversionFormats.Items.AddRange(new[] {
                "MP4",
                "MP3",
                "MPEG",
                "AVI",
                "FLV"
            });
            conversionFormats.SelectedIndex = 0;

            foreach (var preset in EncodingOptions.Presets)
            {
                presets.Items.Add(preset.PresetName);
            }
            presets.SelectedIndex = 1;
            //SetEncodingOptions(EncodingOptions.Custom720);
            return true;
        }

        //adds keyto app.config if it doesnt exsist
        public static void ModifyAppConfiguration(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var entry = config.AppSettings.Settings[key];
            if (entry == null)
                config.AppSettings.Settings.Add(key, value);
            else
                config.AppSettings.Settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);
        }

        private void setToolStripText(string text)
        {
            toolStripStatusLabel1.Text = text;
        }

        private void Ffwraper_OnCompleted()
        {
            setToolStripText("Conversion completed");
        }

        private void Ffwraper_OnProgressChanged(int currentFileIndex, string currentFileName, int totalFiles, float percentage)
        {
            setToolStripText($"Converting \"{currentFileName}\" - file {currentFileIndex} of {totalFiles} ({percentage}%)");
        }

        private EncodingOptions GetEncodingOptions()
        {
            var res = String.Empty;
            var resText = videoResolution.Text;
            var p = resText.Split('x');
            if (p.Length > 1)
            {
                uint a, b;
                if (UInt32.TryParse(p[0], out a) && UInt32.TryParse(p[1], out b))
                {
                    res = a + "x" + b;
                }
            }
            if ((!String.IsNullOrEmpty(resText)) && String.IsNullOrEmpty(res))
            {
                MessageBox.Show(this, $"\"{resText}\" is an invalid resolution. Please enter one in the format of \"1920x1080\" or leave the field blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            var options = new EncodingOptions
            {
                IncludeVideo = includeVideo.Checked,
                VideoResolution = res,
                VideoFramerate = videoFramerate.Text,
                VideoBitrate = videoBitrate.Text,
                VideoScaleQuality = videoScaleQuality.Text,

                IncludeAudio = includeAudio.Checked,
                AudioSampleRate = audioSamplerate.Text,
                AudioBitrate = txtaudioBitrate.Text,
                AudioChannels = audioChannels.Text,
                AudioScaleQuality = audioScaleQuality.Text,
                ApplyAudioNormalizationFilter = applyAudioNormalizationFilter.Checked,
            };

            return options;
        }

        private void SetEncodingOptions(EncodingOptions options)
        {
            includeVideo.Checked = options.IncludeVideo;
            videoResolution.Text = options.VideoResolution;
            videoFramerate.Text = options.VideoFramerate;
            videoBitrate.Text = options.VideoBitrate;
            videoScaleQuality.Text = options.VideoScaleQuality;

            includeAudio.Checked = options.IncludeAudio;
            audioSamplerate.Text = options.AudioSampleRate;
            txtaudioBitrate.Text = options.AudioBitrate;
            audioChannels.Text = options.AudioChannels;
            audioScaleQuality.Text = options.AudioScaleQuality;
            applyAudioNormalizationFilter.Checked = options.ApplyAudioNormalizationFilter;
        }

        private void OnChangeBatchMode(object sender, EventArgs e)
        {
            conversionFormats.Visible = checkBoxBatchMode.Checked;
        }

        private async void startConversionButton_Click(object sender, EventArgs e)
        { 

            if (inputFileName.Text == outputFileName.Text)
            {
                MessageBox.Show("Can not have output file the same as the input file." + Environment.NewLine + "Change the output file path and try again");
                return;
            }

            var inputFile = inputFileName.Text;
            if (string.IsNullOrEmpty(inputFile))
            {
                MessageBox.Show(this, Resources.Form1_onStartConversion_No_input_file_selected, Resources.Form1_onStartConversion_Invalid_input_file, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var outputFile = outputFileName.Text;

            if (string.IsNullOrEmpty(outputFile))
            {
                MessageBox.Show(this, Resources.Form1_onStartConversion_No_output_file_selected, Resources.Form1_onStartConversion_Invalid_output_file, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var advancedOptions = GetEncodingOptions();

            if (advancedOptions == null)
            {
                return;
            }

            try
            {
                setToolStripText("Convertion stating...");
                toolStripProgressBar1.Visible = true;

                bool success = false;
                if (checkBoxBatchMode.Checked)
                {
                    string outputFormat = conversionFormats.SelectedItem.ToString();
                    success = await ffwraper.StartBatchConversionAsync(inputFile, outputFile, outputFormat, advancedOptions);
                }
                else
                {
                    success = await ffwraper.StartConversionAsync(inputFile, outputFile, advancedOptions);
                }
                var messageBoxMessage = $"The conversion completed successfully. The result is saved at: \"{outputFile}\".";
                var toolStripMessage = "Ready";
                if (!success)
                {
                    toolStripMessage = "Conversion Failed";
                    if (checkBoxBatchMode.Checked)
                    {
                        messageBoxMessage = "Not all files could be converted succesfully. Please review the log and try again.";
                    }
                    else
                    {
                        messageBoxMessage = "Something went wrong during conversion. Please try again.";
                    }
                }
                toolStripStatusLabel1.Text = toolStripMessage;
                toolStripProgressBar1.Visible = false;
                MessageBox.Show(this, messageBoxMessage, "Conversion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            if (checkBoxBatchMode.Checked)
            {
                folderBrowserDialog1.SelectedPath = outputFileName.Text;
                var result = folderBrowserDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    outputFileName.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else
            {
                var result = folderBrowserDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    outputFilePath = folderBrowserDialog1.SelectedPath;
                    setOutputFilePath();
                }
                //saveFileDialog1.FileName = outputFileName.Text;
                //var result = saveFileDialog1.ShowDialog(this);
                //if (result == DialogResult.OK)
                //{
                //    outputFileName.Text = saveFileDialog1.FileName;
                //}
            }
        }

        private void setOutputFilePath()
        {
            VideoFileName = Path.GetFileNameWithoutExtension(inputFileName.Text);
            String ext = "." + conversionFormats.Text.ToLower();
            outputFileName.Text = outputFilePath + "\\" + VideoFileName + ext;
        }

        private void btnPlayFile_Click(object sender, EventArgs e)
        {
            string Ext = Path.GetExtension(outputFileName.Text);
            if (Ext == ".flv") { return; }

            if (string.IsNullOrEmpty(inputFileName.Text) && (string.IsNullOrEmpty(outputFileName.Text))) { return; }
            if (! string.IsNullOrEmpty(outputFileName.Text)) { PlayFile(outputFileName.Text,2); }
            else { PlayFile(inputFileName.Text, 2); }
        }

        private void browseInputButton_Click(object sender, EventArgs e)
        {

            if (checkBoxBatchMode.Checked)
            {
                folderBrowserDialog1.SelectedPath = inputFileName.Text;
                var result = folderBrowserDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var fileName = folderBrowserDialog1.SelectedPath;
                    inputFileName.Text = fileName;
                    outputFileName.Text = fileName + " output";
                }
            }
            else
            {

                openFileDialog1.FileName = inputFileName.Text;
                var result = openFileDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;
                    inputFileName.Text = fileName;
                    fileName = fileName.Substring(0, fileName.LastIndexOf('.'));
                    
                    if (picThumbNail.Image != null)
                    {
                        picThumbNail.Image.Dispose();
                        picThumbNail.Image = null;
                    }

                    if (File.Exists(Properties.Settings.Default.ThumbNailPath))
                    {
                        File.Delete(Properties.Settings.Default.ThumbNailPath);
                    }

                    //Must add nuget package:
                    //Install-Package WindowsAPICodePack-Shell -Version 1.1.1
                    ShellFile shellFile = ShellFile.FromFilePath(inputFileName.Text);
                    Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
                    picThumbNail.Image = shellThumb;


                }
            }
        }


        private void presets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEncodingOptions(EncodingOptions.Presets[presets.SelectedIndex]);
        }

        private void applyAudioNormalizationFilter_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool RunFFmpeg(string args)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo();

                procStartInfo.FileName = ffmpgPath;
                procStartInfo.Arguments = args;
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                using (Process process = new Process())
                {
                    process.StartInfo = procStartInfo;
                    process.Start();

                    process.WaitForExit();

                    string result = process.StandardOutput.ReadToEnd();
                    Console.WriteLine(result);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("*** Error occured executing the following commands.");
                Console.WriteLine(ffmpgPath);
                Console.WriteLine(args);
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        #endregion


        private void btnDelVideoMPlayer2_Click(object sender, EventArgs e)
        {
            if (File.Exists(outputFileName.Text))
            {
                axWindowsMediaPlayer2.Ctlcontrols.stop();
                axWindowsMediaPlayer2.currentPlaylist.clear();

                if (File.Exists(outputFileName.Text))
                {
                    File.Delete(outputFileName.Text);
                }

            }
        }

        private void cmbAudioBitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtaudioBitrate.Text = cmbAudioBitrate.SelectedItem.ToString();
        }

        private void inputFileName_TextChanged(object sender, EventArgs e)
        {
            //Get the file extension and update the convert to combobox
            if ( !String.IsNullOrEmpty(inputFileName.Text))
            {
                String ext = Path.GetExtension(inputFileName.Text).Replace(".", "").Trim();
                conversionFormats.SelectedItem = ext.ToUpper();
                //switch (ext)
                //{
                //    case
                //}

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FilePlaying == true)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VolUp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mute();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void conversionFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputFileName.Text)) { return; }
            if (String.IsNullOrEmpty(outputFileName.Text)) { return; }
            setOutputFilePath();
        }
    }
}


public class ClipBoardMonitor : NativeWindow
{

    private const int WM_DESTROY = 0x2;
    private const int WM_DRAWCLIPBOARD = 0x308;
    private const int WM_CHANGECBCHAIN = 0x30d;

    [DllImport("user32.dll")]
    private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
    [DllImport("user32.dll")]
    private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    public event NewUrlHandler NewUrl;
    public delegate void NewUrlHandler(string txt);

    private IntPtr NextClipBoardViewerHandle;

    public ClipBoardMonitor()
    {
        this.CreateHandle(new CreateParams());
        this.NextClipBoardViewerHandle = SetClipboardViewer(this.Handle);
    }

    protected override void WndProc(ref Message m)
    {
        switch (m.Msg)
        {
            case WM_DRAWCLIPBOARD:
                if (Clipboard.ContainsText())
                {
                    string txt = Clipboard.GetText();
                    if (this.NewUrl != null && this.IsValidUrl(txt))
                    {
                        this.NewUrl(txt);
                    }
                }
                SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);

                break;

            case WM_CHANGECBCHAIN:
                if (m.WParam.Equals(this.NextClipBoardViewerHandle))
                {
                    this.NextClipBoardViewerHandle = m.LParam;
                }
                else if (!this.NextClipBoardViewerHandle.Equals(IntPtr.Zero))
                {
                    SendMessage(this.NextClipBoardViewerHandle, m.Msg, m.WParam, m.LParam);
                }
                break;

            case WM_DESTROY:
                ChangeClipboardChain(this.Handle, this.NextClipBoardViewerHandle);
                break;

        }

        base.WndProc(ref m);
    }

    private bool IsValidUrl(string txt)
    {
        Uri uriResult;
        return Uri.TryCreate(txt, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}


