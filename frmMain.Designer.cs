using System;

namespace YoutubeDownloader
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAudioAndVideo = new System.Windows.Forms.RadioButton();
            this.rbMp3Only = new System.Windows.Forms.RadioButton();
            this.rbVideoFileOnly = new System.Windows.Forms.RadioButton();
            this.btnVideoFullScreen = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.picAudioVideo = new System.Windows.Forms.PictureBox();
            this.btnMainVolUp = new System.Windows.Forms.Button();
            this.cmsAudioVideoButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CsConvertMP4ToMP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.CSselectVideoFile = new System.Windows.Forms.ToolStripMenuItem();
            this.selectVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CsDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.addMP3FilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMainMute = new System.Windows.Forms.Button();
            this.btnMainVolDown = new System.Windows.Forms.Button();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.lblSongCount = new System.Windows.Forms.Label();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.lblFolderSize = new System.Windows.Forms.Label();
            this.btnCheckIConnection = new System.Windows.Forms.Button();
            this.picIsConnected = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelDownload = new System.Windows.Forms.Button();
            this.ckbAudioOnly = new System.Windows.Forms.CheckBox();
            this.btnPasteURL = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.txtSaveVideoAs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlAudioVideo = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstMP3s = new System.Windows.Forms.ListBox();
            this.csListMP3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmPlayMP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.csmDeleteMP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRnameMP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPlayAllMp3Files = new System.Windows.Forms.ToolStripMenuItem();
            this.openMP3FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshMP3List = new System.Windows.Forms.Button();
            this.cmsMP3AddFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMP3 = new System.Windows.Forms.Button();
            this.btnRemoveMP3 = new System.Windows.Forms.Button();
            this.btnMoveMP3Down = new System.Windows.Forms.Button();
            this.btnMoveMP3Up = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lstVideoFiles = new System.Windows.Forms.ListBox();
            this.csVideos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csPlayVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.csDeleteVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.csRenameVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideoFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuConvertVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbAutoPlay = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnDownLoadNSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtVideoTitle = new System.Windows.Forms.TextBox();
            this.txtFileURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlRenameMP3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRenameMP3 = new System.Windows.Forms.Button();
            this.btnCancelRename = new System.Windows.Forms.Button();
            this.txtNewMP3FileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurMP3Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picThumbNail = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbAudioBitrate = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.audioChannels = new System.Windows.Forms.ComboBox();
            this.audioSamplerate = new System.Windows.Forms.TextBox();
            this.txtaudioBitrate = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.audioScaleQuality = new System.Windows.Forms.ComboBox();
            this.includeAudio = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.includeVideo = new System.Windows.Forms.CheckBox();
            this.videoResolution = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.videoBitrate = new System.Windows.Forms.TextBox();
            this.videoFramerate = new System.Windows.Forms.TextBox();
            this.videoScaleQuality = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelVideoMPlayer2 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPlayFile = new System.Windows.Forms.Button();
            this.applyAudioNormalizationFilter = new System.Windows.Forms.CheckBox();
            this.conversionFormats = new System.Windows.Forms.ComboBox();
            this.checkBoxBatchMode = new System.Windows.Forms.CheckBox();
            this.presets = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.outputFileName = new System.Windows.Forms.TextBox();
            this.inputFileName = new System.Windows.Forms.TextBox();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.startConversionButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMainTRiM = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnMainTE = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTagEditFilePath = new System.Windows.Forms.Label();
            this.btnTagSaveTag = new System.Windows.Forms.Button();
            this.btnTagOpenMP3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMainBurn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNoAutoLoad = new System.Windows.Forms.RadioButton();
            this.rbAutoLoad = new System.Windows.Forms.RadioButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBurnCD = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.llCheckForUpdates = new System.Windows.Forms.LinkLabel();
            this.llemailSupport = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnMainHelp = new System.Windows.Forms.Button();
            this.ofdMP3 = new System.Windows.Forms.OpenFileDialog();
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tmrMarquee = new System.Windows.Forms.Timer(this.components);
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.tmrBrowserPBar = new System.Windows.Forms.Timer(this.components);
            this.audioOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.ofdVideos = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.encodingOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.encodingOptionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitButton1 = new wyDay.Controls.SplitButton();
            this.textProgressBarMax = new ProgressBarSample.TextProgressBar();
            this.textProgressBar1 = new ProgressBarSample.TextProgressBar();
            this.mP3SliderSongTrim = new YoutubeDownloader.UserControls.MP3Slider();
            this.mP3SliderAlbumSplitter = new YoutubeDownloader.UserControls.MP3Slider();
            this.ucID3v2 = new IdSharp.Tagging.Harness.WinForms.UserControls.ID3v2UserControl();
            this.imageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAudioVideo)).BeginInit();
            this.cmsAudioVideoButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIsConnected)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlAudioVideo.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.csListMP3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsMP3AddFiles.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.csVideos.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRenameMP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbNail)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodingOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingOptionsBindingSource1)).BeginInit();
            this.ucID3v2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage10);
            this.tabControlMain.Controls.Add(this.tabPage6);
            this.tabControlMain.Controls.Add(this.tabPage7);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ImageList = this.imageList1;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1023, 530);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControl11_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.ImageIndex = 40;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnVideoFullScreen);
            this.splitContainer1.Panel1.Controls.Add(this.picAudioVideo);
            this.splitContainer1.Panel1.Controls.Add(this.btnMainVolUp);
            this.splitContainer1.Panel1.Controls.Add(this.splitButton1);
            this.splitContainer1.Panel1.Controls.Add(this.btnMainMute);
            this.splitContainer1.Panel1.Controls.Add(this.btnMainVolDown);
            this.splitContainer1.Panel1.Controls.Add(this.textProgressBarMax);
            this.splitContainer1.Panel1.Controls.Add(this.lblFileCount);
            this.splitContainer1.Panel1.Controls.Add(this.lblSongCount);
            this.splitContainer1.Panel1.Controls.Add(this.textProgressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.lblFolderName);
            this.splitContainer1.Panel1.Controls.Add(this.lblFolderSize);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckIConnection);
            this.splitContainer1.Panel1.Controls.Add(this.picIsConnected);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelDownload);
            this.splitContainer1.Panel1.Controls.Add(this.ckbAudioOnly);
            this.splitContainer1.Panel1.Controls.Add(this.btnPasteURL);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.lblFileExtension);
            this.splitContainer1.Panel1.Controls.Add(this.txtSaveVideoAs);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.ckbAutoPlay);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileName);
            this.splitContainer1.Panel1.Controls.Add(this.btnDownLoadNSave);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtDuration);
            this.splitContainer1.Panel1.Controls.Add(this.txtAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.txtVideoTitle);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileURL);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlMain);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.pnlRenameMP3);
            this.splitContainer1.Size = new System.Drawing.Size(1009, 493);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(380, 51);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(289, 264);
            this.axWindowsMediaPlayer1.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAudioAndVideo);
            this.groupBox1.Controls.Add(this.rbMp3Only);
            this.groupBox1.Controls.Add(this.rbVideoFileOnly);
            this.groupBox1.Location = new System.Drawing.Point(91, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 98);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Options";
            // 
            // rbAudioAndVideo
            // 
            this.rbAudioAndVideo.AutoSize = true;
            this.rbAudioAndVideo.Location = new System.Drawing.Point(6, 68);
            this.rbAudioAndVideo.Name = "rbAudioAndVideo";
            this.rbAudioAndVideo.Size = new System.Drawing.Size(180, 17);
            this.rbAudioAndVideo.TabIndex = 94;
            this.rbAudioAndVideo.Text = "Save Both Audio and Video Files";
            this.rbAudioAndVideo.UseVisualStyleBackColor = true;
            // 
            // rbMp3Only
            // 
            this.rbMp3Only.AutoSize = true;
            this.rbMp3Only.Checked = true;
            this.rbMp3Only.Location = new System.Drawing.Point(6, 22);
            this.rbMp3Only.Name = "rbMp3Only";
            this.rbMp3Only.Size = new System.Drawing.Size(120, 17);
            this.rbMp3Only.TabIndex = 92;
            this.rbMp3Only.TabStop = true;
            this.rbMp3Only.Text = "MP3 Audio File Only";
            this.rbMp3Only.UseVisualStyleBackColor = true;
            // 
            // rbVideoFileOnly
            // 
            this.rbVideoFileOnly.AutoSize = true;
            this.rbVideoFileOnly.Location = new System.Drawing.Point(6, 45);
            this.rbVideoFileOnly.Name = "rbVideoFileOnly";
            this.rbVideoFileOnly.Size = new System.Drawing.Size(95, 17);
            this.rbVideoFileOnly.TabIndex = 93;
            this.rbVideoFileOnly.Text = "Video File Only";
            this.rbVideoFileOnly.UseVisualStyleBackColor = true;
            // 
            // btnVideoFullScreen
            // 
            this.btnVideoFullScreen.BackColor = System.Drawing.Color.White;
            this.btnVideoFullScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoFullScreen.ImageIndex = 13;
            this.btnVideoFullScreen.ImageList = this.imageList2;
            this.btnVideoFullScreen.Location = new System.Drawing.Point(576, 327);
            this.btnVideoFullScreen.Name = "btnVideoFullScreen";
            this.btnVideoFullScreen.Size = new System.Drawing.Size(90, 42);
            this.btnVideoFullScreen.TabIndex = 90;
            this.btnVideoFullScreen.Text = "       Full Screen";
            this.toolTip1.SetToolTip(this.btnVideoFullScreen, "Play video in fullscreen mode.\r\nMust load video first.");
            this.btnVideoFullScreen.UseVisualStyleBackColor = false;
            this.btnVideoFullScreen.Click += new System.EventHandler(this.btnVideoFullScreen_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "audio-button-Low.png");
            this.imageList2.Images.SetKeyName(1, "audio-button-plus.png");
            this.imageList2.Images.SetKeyName(2, "audio-music-off-sound-sound-off-speaker-volume-icon-6.png");
            this.imageList2.Images.SetKeyName(3, "YouTube-icon.png");
            this.imageList2.Images.SetKeyName(4, "MediaStop.png");
            this.imageList2.Images.SetKeyName(5, "cut-icon.jpg");
            this.imageList2.Images.SetKeyName(6, "cutMP3.png");
            this.imageList2.Images.SetKeyName(7, "shop-open.png");
            this.imageList2.Images.SetKeyName(8, "saveFolder.png");
            this.imageList2.Images.SetKeyName(9, "Save.png");
            this.imageList2.Images.SetKeyName(10, "CutLeft.png");
            this.imageList2.Images.SetKeyName(11, "CutRight.png");
            this.imageList2.Images.SetKeyName(12, "46-512.png");
            this.imageList2.Images.SetKeyName(13, "46-512.png");
            this.imageList2.Images.SetKeyName(14, "VideoPlay.png");
            this.imageList2.Images.SetKeyName(15, "Browse.jpg");
            this.imageList2.Images.SetKeyName(16, "cancel.png");
            this.imageList2.Images.SetKeyName(17, "folder+open.png");
            this.imageList2.Images.SetKeyName(18, "folder-search.png");
            this.imageList2.Images.SetKeyName(19, "MP3.png");
            this.imageList2.Images.SetKeyName(20, "mp3-icon.png");
            this.imageList2.Images.SetKeyName(21, "PushPlay.jpg");
            this.imageList2.Images.SetKeyName(22, "Lightning.png");
            // 
            // picAudioVideo
            // 
            this.picAudioVideo.BackColor = System.Drawing.Color.LawnGreen;
            this.picAudioVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAudioVideo.Image = ((System.Drawing.Image)(resources.GetObject("picAudioVideo.Image")));
            this.picAudioVideo.Location = new System.Drawing.Point(304, 217);
            this.picAudioVideo.Name = "picAudioVideo";
            this.picAudioVideo.Size = new System.Drawing.Size(64, 64);
            this.picAudioVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAudioVideo.TabIndex = 89;
            this.picAudioVideo.TabStop = false;
            // 
            // btnMainVolUp
            // 
            this.btnMainVolUp.BackColor = System.Drawing.Color.White;
            this.btnMainVolUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainVolUp.ImageIndex = 1;
            this.btnMainVolUp.ImageList = this.imageList2;
            this.btnMainVolUp.Location = new System.Drawing.Point(510, 327);
            this.btnMainVolUp.Name = "btnMainVolUp";
            this.btnMainVolUp.Size = new System.Drawing.Size(65, 42);
            this.btnMainVolUp.TabIndex = 82;
            this.btnMainVolUp.Text = "        Vol +";
            this.btnMainVolUp.UseVisualStyleBackColor = false;
            this.btnMainVolUp.Click += new System.EventHandler(this.btnMainVolUp_Click);
            // 
            // cmsAudioVideoButton
            // 
            this.cmsAudioVideoButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAudioVideoButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CsConvertMP4ToMP3,
            this.CsDeleteSelected,
            this.addMP3FilesToolStripMenuItem,
            this.addVideoFilesToolStripMenuItem});
            this.cmsAudioVideoButton.Name = "contextMenuStrip2";
            this.cmsAudioVideoButton.Size = new System.Drawing.Size(189, 108);
            // 
            // CsConvertMP4ToMP3
            // 
            this.CsConvertMP4ToMP3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSselectVideoFile});
            this.CsConvertMP4ToMP3.Image = ((System.Drawing.Image)(resources.GetObject("CsConvertMP4ToMP3.Image")));
            this.CsConvertMP4ToMP3.Name = "CsConvertMP4ToMP3";
            this.CsConvertMP4ToMP3.Size = new System.Drawing.Size(188, 26);
            this.CsConvertMP4ToMP3.Text = "Convert MP4 to MP3";
            this.CsConvertMP4ToMP3.Click += new System.EventHandler(this.CsConvertMP4ToMP3_Click);
            // 
            // CSselectVideoFile
            // 
            this.CSselectVideoFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectVideoToolStripMenuItem});
            this.CSselectVideoFile.Image = ((System.Drawing.Image)(resources.GetObject("CSselectVideoFile.Image")));
            this.CSselectVideoFile.Name = "CSselectVideoFile";
            this.CSselectVideoFile.Size = new System.Drawing.Size(159, 22);
            this.CSselectVideoFile.Text = "Select Video File";
            // 
            // selectVideoToolStripMenuItem
            // 
            this.selectVideoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVideoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectVideoToolStripMenuItem.Image")));
            this.selectVideoToolStripMenuItem.Name = "selectVideoToolStripMenuItem";
            this.selectVideoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.selectVideoToolStripMenuItem.Text = "Select Video From List";
            // 
            // CsDeleteSelected
            // 
            this.CsDeleteSelected.Image = ((System.Drawing.Image)(resources.GetObject("CsDeleteSelected.Image")));
            this.CsDeleteSelected.Name = "CsDeleteSelected";
            this.CsDeleteSelected.Size = new System.Drawing.Size(188, 26);
            this.CsDeleteSelected.Text = "Delete Selected File";
            this.CsDeleteSelected.Click += new System.EventHandler(this.CsDeleteSelected_Click_1);
            // 
            // addMP3FilesToolStripMenuItem
            // 
            this.addMP3FilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addMP3FilesToolStripMenuItem.Image")));
            this.addMP3FilesToolStripMenuItem.Name = "addMP3FilesToolStripMenuItem";
            this.addMP3FilesToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addMP3FilesToolStripMenuItem.Text = "Add MP3 files";
            // 
            // addVideoFilesToolStripMenuItem
            // 
            this.addVideoFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addVideoFilesToolStripMenuItem.Image")));
            this.addVideoFilesToolStripMenuItem.Name = "addVideoFilesToolStripMenuItem";
            this.addVideoFilesToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addVideoFilesToolStripMenuItem.Text = "Add Video Files";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Paste-icon.png");
            this.imageList1.Images.SetKeyName(1, "Convert.png");
            this.imageList1.Images.SetKeyName(2, "delete-file-icon.png");
            this.imageList1.Images.SetKeyName(3, "iso.png");
            this.imageList1.Images.SetKeyName(4, "mp3-icon.png");
            this.imageList1.Images.SetKeyName(5, "PushPlay.jpg");
            this.imageList1.Images.SetKeyName(6, "MP3.png");
            this.imageList1.Images.SetKeyName(7, "CD-Music_Icon.svg.png");
            this.imageList1.Images.SetKeyName(8, "close3Png.png");
            this.imageList1.Images.SetKeyName(9, "video-icon.png");
            this.imageList1.Images.SetKeyName(10, "AudioVideo.png");
            this.imageList1.Images.SetKeyName(11, "MP3.png");
            this.imageList1.Images.SetKeyName(12, "close3Png.png");
            this.imageList1.Images.SetKeyName(13, "DownArrow.png");
            this.imageList1.Images.SetKeyName(14, "UpArrow.png");
            this.imageList1.Images.SetKeyName(15, "Browse+.png");
            this.imageList1.Images.SetKeyName(16, "Burn%20Disk.png");
            this.imageList1.Images.SetKeyName(17, "Audio%20Disk.png");
            this.imageList1.Images.SetKeyName(18, "cdburn.png");
            this.imageList1.Images.SetKeyName(19, "exit.jpg");
            this.imageList1.Images.SetKeyName(20, "copy-icon-6655585.jpg");
            this.imageList1.Images.SetKeyName(21, "Save.png");
            this.imageList1.Images.SetKeyName(22, "audio-button-Low.png");
            this.imageList1.Images.SetKeyName(23, "audio-button-plus.png");
            this.imageList1.Images.SetKeyName(24, "audio-music-off-sound-sound-off-speaker-volume-icon-6.png");
            this.imageList1.Images.SetKeyName(25, "Help.png");
            this.imageList1.Images.SetKeyName(26, "Fire.png");
            this.imageList1.Images.SetKeyName(27, "YouTube-icon.png");
            this.imageList1.Images.SetKeyName(28, "Play.png");
            this.imageList1.Images.SetKeyName(29, "Player_stop.png");
            this.imageList1.Images.SetKeyName(30, "MediaStop.png");
            this.imageList1.Images.SetKeyName(31, "Cut.png");
            this.imageList1.Images.SetKeyName(32, "cut-icon.jpg");
            this.imageList1.Images.SetKeyName(33, "Save.png");
            this.imageList1.Images.SetKeyName(34, "DownArrow.png");
            this.imageList1.Images.SetKeyName(35, "UpArrowPoiter.png");
            this.imageList1.Images.SetKeyName(36, "Refresh1.gif");
            this.imageList1.Images.SetKeyName(37, "refresh1.png");
            this.imageList1.Images.SetKeyName(38, "Refresh4.png");
            this.imageList1.Images.SetKeyName(39, "Refresh-image.png");
            this.imageList1.Images.SetKeyName(40, "YouTube-icon.png");
            this.imageList1.Images.SetKeyName(41, "eeditMP3Tag.png");
            this.imageList1.Images.SetKeyName(42, "Help.png");
            // 
            // btnMainMute
            // 
            this.btnMainMute.BackColor = System.Drawing.Color.White;
            this.btnMainMute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMute.ImageIndex = 2;
            this.btnMainMute.ImageList = this.imageList2;
            this.btnMainMute.Location = new System.Drawing.Point(444, 327);
            this.btnMainMute.Name = "btnMainMute";
            this.btnMainMute.Size = new System.Drawing.Size(65, 42);
            this.btnMainMute.TabIndex = 81;
            this.btnMainMute.Text = "       Mute";
            this.btnMainMute.UseVisualStyleBackColor = false;
            this.btnMainMute.Click += new System.EventHandler(this.btnMainMute_Click);
            // 
            // btnMainVolDown
            // 
            this.btnMainVolDown.BackColor = System.Drawing.Color.White;
            this.btnMainVolDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainVolDown.ImageIndex = 0;
            this.btnMainVolDown.ImageList = this.imageList2;
            this.btnMainVolDown.Location = new System.Drawing.Point(380, 327);
            this.btnMainVolDown.Name = "btnMainVolDown";
            this.btnMainVolDown.Size = new System.Drawing.Size(64, 42);
            this.btnMainVolDown.TabIndex = 83;
            this.btnMainVolDown.Text = "      Vol -";
            this.btnMainVolDown.UseVisualStyleBackColor = false;
            this.btnMainVolDown.Click += new System.EventHandler(this.btnMainVolDown_Click);
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(893, 281);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(72, 13);
            this.lblFileCount.TabIndex = 87;
            this.lblFileCount.Text = "Song Count =";
            // 
            // lblSongCount
            // 
            this.lblSongCount.AutoSize = true;
            this.lblSongCount.Location = new System.Drawing.Point(964, 281);
            this.lblSongCount.Name = "lblSongCount";
            this.lblSongCount.Size = new System.Drawing.Size(13, 13);
            this.lblSongCount.TabIndex = 86;
            this.lblSongCount.Text = "0";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Location = new System.Drawing.Point(684, 281);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(133, 13);
            this.lblFolderName.TabIndex = 74;
            this.lblFolderName.Text = "Current MP3 Folder Size = ";
            // 
            // lblFolderSize
            // 
            this.lblFolderSize.AutoSize = true;
            this.lblFolderSize.Location = new System.Drawing.Point(815, 281);
            this.lblFolderSize.Name = "lblFolderSize";
            this.lblFolderSize.Size = new System.Drawing.Size(41, 13);
            this.lblFolderSize.TabIndex = 69;
            this.lblFolderSize.Text = "label15";
            // 
            // btnCheckIConnection
            // 
            this.btnCheckIConnection.BackColor = System.Drawing.Color.White;
            this.btnCheckIConnection.Location = new System.Drawing.Point(6, 317);
            this.btnCheckIConnection.Name = "btnCheckIConnection";
            this.btnCheckIConnection.Size = new System.Drawing.Size(92, 23);
            this.btnCheckIConnection.TabIndex = 1;
            this.btnCheckIConnection.Text = "Check Internet";
            this.toolTip1.SetToolTip(this.btnCheckIConnection, "Checks the internet connection.");
            this.btnCheckIConnection.UseVisualStyleBackColor = false;
            this.btnCheckIConnection.Click += new System.EventHandler(this.btnCheckIConnection_Click);
            // 
            // picIsConnected
            // 
            this.picIsConnected.BackColor = System.Drawing.Color.LawnGreen;
            this.picIsConnected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picIsConnected.Image = ((System.Drawing.Image)(resources.GetObject("picIsConnected.Image")));
            this.picIsConnected.Location = new System.Drawing.Point(9, 217);
            this.picIsConnected.Name = "picIsConnected";
            this.picIsConnected.Size = new System.Drawing.Size(64, 64);
            this.picIsConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIsConnected.TabIndex = 73;
            this.picIsConnected.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblMessages});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 72;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Software Status :  ";
            // 
            // lblMessages
            // 
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancelDownload
            // 
            this.btnCancelDownload.BackColor = System.Drawing.Color.White;
            this.btnCancelDownload.Enabled = false;
            this.btnCancelDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDownload.ImageIndex = 10;
            this.btnCancelDownload.ImageList = this.imageList1;
            this.btnCancelDownload.Location = new System.Drawing.Point(104, 317);
            this.btnCancelDownload.Name = "btnCancelDownload";
            this.btnCancelDownload.Size = new System.Drawing.Size(117, 23);
            this.btnCancelDownload.TabIndex = 71;
            this.btnCancelDownload.Text = "      Cancel Download";
            this.toolTip1.SetToolTip(this.btnCancelDownload, "Cancels the current download");
            this.btnCancelDownload.UseVisualStyleBackColor = false;
            this.btnCancelDownload.Click += new System.EventHandler(this.btnCancelDownload_Click);
            // 
            // ckbAudioOnly
            // 
            this.ckbAudioOnly.AutoSize = true;
            this.ckbAudioOnly.Checked = true;
            this.ckbAudioOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAudioOnly.Location = new System.Drawing.Point(227, 379);
            this.ckbAudioOnly.Name = "ckbAudioOnly";
            this.ckbAudioOnly.Size = new System.Drawing.Size(175, 17);
            this.ckbAudioOnly.TabIndex = 69;
            this.ckbAudioOnly.Text = "Download MP3  Audio File Only";
            this.ckbAudioOnly.UseVisualStyleBackColor = true;
            this.ckbAudioOnly.CheckedChanged += new System.EventHandler(this.ckbAudioOnly_CheckedChanged_1);
            // 
            // btnPasteURL
            // 
            this.btnPasteURL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasteURL.ImageIndex = 0;
            this.btnPasteURL.ImageList = this.imageList1;
            this.btnPasteURL.Location = new System.Drawing.Point(576, 17);
            this.btnPasteURL.Name = "btnPasteURL";
            this.btnPasteURL.Size = new System.Drawing.Size(93, 23);
            this.btnPasteURL.TabIndex = 66;
            this.btnPasteURL.Tag = "Allows manual paste check if url is valid if so it loads the video.";
            this.btnPasteURL.Text = "Paste URL";
            this.btnPasteURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPasteURL.UseVisualStyleBackColor = true;
            this.btnPasteURL.Click += new System.EventHandler(this.btnPasteURL_ClickAsync);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 26);
            this.label8.TabIndex = 64;
            this.label8.Text = "Rename MP3\r\n(Optional)";
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Location = new System.Drawing.Point(331, 170);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(32, 13);
            this.lblFileExtension.TabIndex = 63;
            this.lblFileExtension.Text = ".MP3";
            // 
            // txtSaveVideoAs
            // 
            this.txtSaveVideoAs.Location = new System.Drawing.Point(92, 165);
            this.txtSaveVideoAs.Name = "txtSaveVideoAs";
            this.txtSaveVideoAs.Size = new System.Drawing.Size(233, 20);
            this.txtSaveVideoAs.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlAudioVideo);
            this.panel1.Location = new System.Drawing.Point(681, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 256);
            this.panel1.TabIndex = 61;
            // 
            // tabControlAudioVideo
            // 
            this.tabControlAudioVideo.Controls.Add(this.tabPage4);
            this.tabControlAudioVideo.Controls.Add(this.tabPage5);
            this.tabControlAudioVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAudioVideo.ImageList = this.imageList1;
            this.tabControlAudioVideo.Location = new System.Drawing.Point(0, 0);
            this.tabControlAudioVideo.Name = "tabControlAudioVideo";
            this.tabControlAudioVideo.SelectedIndex = 0;
            this.tabControlAudioVideo.Size = new System.Drawing.Size(321, 256);
            this.tabControlAudioVideo.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstMP3s);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.ImageIndex = 11;
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(313, 225);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "MP3 Files";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstMP3s
            // 
            this.lstMP3s.AllowDrop = true;
            this.lstMP3s.ContextMenuStrip = this.csListMP3;
            this.lstMP3s.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMP3s.FormattingEnabled = true;
            this.lstMP3s.HorizontalScrollbar = true;
            this.lstMP3s.Location = new System.Drawing.Point(3, 3);
            this.lstMP3s.Name = "lstMP3s";
            this.lstMP3s.Size = new System.Drawing.Size(307, 195);
            this.lstMP3s.TabIndex = 25;
            this.toolTip1.SetToolTip(this.lstMP3s, "Double click file to play MP3.\r\nRight click for more options.");
            this.lstMP3s.SelectedIndexChanged += new System.EventHandler(this.lstMP3s_SelectedIndexChanged);
            this.lstMP3s.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMP3s_MouseDoubleClick);
            this.lstMP3s.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstMP3s_MouseMove);
            // 
            // csListMP3
            // 
            this.csListMP3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csListMP3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmPlayMP3,
            this.csmDeleteMP3,
            this.cmsRnameMP3,
            this.cmsPlayAllMp3Files,
            this.openMP3FolderToolStripMenuItem});
            this.csListMP3.Name = "csListMP3";
            this.csListMP3.Size = new System.Drawing.Size(205, 134);
            // 
            // csmPlayMP3
            // 
            this.csmPlayMP3.Enabled = false;
            this.csmPlayMP3.Image = ((System.Drawing.Image)(resources.GetObject("csmPlayMP3.Image")));
            this.csmPlayMP3.Name = "csmPlayMP3";
            this.csmPlayMP3.Size = new System.Drawing.Size(204, 26);
            this.csmPlayMP3.Text = "Play MP3";
            this.csmPlayMP3.Click += new System.EventHandler(this.csmPlayMP3_Click);
            // 
            // csmDeleteMP3
            // 
            this.csmDeleteMP3.Enabled = false;
            this.csmDeleteMP3.Image = ((System.Drawing.Image)(resources.GetObject("csmDeleteMP3.Image")));
            this.csmDeleteMP3.Name = "csmDeleteMP3";
            this.csmDeleteMP3.Size = new System.Drawing.Size(204, 26);
            this.csmDeleteMP3.Text = "Delete MP3";
            this.csmDeleteMP3.Click += new System.EventHandler(this.csmDeleteMP3_Click);
            // 
            // cmsRnameMP3
            // 
            this.cmsRnameMP3.Enabled = false;
            this.cmsRnameMP3.Image = ((System.Drawing.Image)(resources.GetObject("cmsRnameMP3.Image")));
            this.cmsRnameMP3.Name = "cmsRnameMP3";
            this.cmsRnameMP3.Size = new System.Drawing.Size(204, 26);
            this.cmsRnameMP3.Text = "Rename MP3";
            this.cmsRnameMP3.Click += new System.EventHandler(this.renameMP3ToolStripMenuItem_Click);
            // 
            // cmsPlayAllMp3Files
            // 
            this.cmsPlayAllMp3Files.Enabled = false;
            this.cmsPlayAllMp3Files.Image = ((System.Drawing.Image)(resources.GetObject("cmsPlayAllMp3Files.Image")));
            this.cmsPlayAllMp3Files.Name = "cmsPlayAllMp3Files";
            this.cmsPlayAllMp3Files.Size = new System.Drawing.Size(204, 26);
            this.cmsPlayAllMp3Files.Text = "Play All MP3 Files In List";
            this.cmsPlayAllMp3Files.Click += new System.EventHandler(this.cmsPlayAllMp3Files_Click);
            // 
            // openMP3FolderToolStripMenuItem
            // 
            this.openMP3FolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openMP3FolderToolStripMenuItem.Image")));
            this.openMP3FolderToolStripMenuItem.Name = "openMP3FolderToolStripMenuItem";
            this.openMP3FolderToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.openMP3FolderToolStripMenuItem.Text = "Open MP3 Folder";
            this.openMP3FolderToolStripMenuItem.Click += new System.EventHandler(this.openMP3FolderToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshMP3List);
            this.panel2.Controls.Add(this.btnAddMP3);
            this.panel2.Controls.Add(this.btnRemoveMP3);
            this.panel2.Controls.Add(this.btnMoveMP3Down);
            this.panel2.Controls.Add(this.btnMoveMP3Up);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 24);
            this.panel2.TabIndex = 24;
            // 
            // btnRefreshMP3List
            // 
            this.btnRefreshMP3List.ContextMenuStrip = this.cmsMP3AddFiles;
            this.btnRefreshMP3List.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshMP3List.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshMP3List.ImageIndex = 38;
            this.btnRefreshMP3List.ImageList = this.imageList1;
            this.btnRefreshMP3List.Location = new System.Drawing.Point(238, 0);
            this.btnRefreshMP3List.Name = "btnRefreshMP3List";
            this.btnRefreshMP3List.Size = new System.Drawing.Size(69, 24);
            this.btnRefreshMP3List.TabIndex = 4;
            this.btnRefreshMP3List.Text = "    Refresh";
            this.btnRefreshMP3List.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshMP3List.UseVisualStyleBackColor = true;
            this.btnRefreshMP3List.Click += new System.EventHandler(this.btnRefreshMP3List_Click);
            // 
            // cmsMP3AddFiles
            // 
            this.cmsMP3AddFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMP3AddFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.addFolderToolStripMenuItem});
            this.cmsMP3AddFiles.Name = "cmsMP3AddFiles";
            this.cmsMP3AddFiles.Size = new System.Drawing.Size(137, 56);
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFilesToolStripMenuItem.Image")));
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addFilesToolStripMenuItem.Text = "Add File(s)";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addFolderToolStripMenuItem.Image")));
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addFolderToolStripMenuItem.Text = "Add Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // btnAddMP3
            // 
            this.btnAddMP3.ContextMenuStrip = this.cmsMP3AddFiles;
            this.btnAddMP3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMP3.ImageIndex = 15;
            this.btnAddMP3.ImageList = this.imageList1;
            this.btnAddMP3.Location = new System.Drawing.Point(184, 0);
            this.btnAddMP3.Name = "btnAddMP3";
            this.btnAddMP3.Size = new System.Drawing.Size(54, 24);
            this.btnAddMP3.TabIndex = 3;
            this.btnAddMP3.Text = "   Add";
            this.btnAddMP3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAddMP3, "Adds files or folders to playlist.\r\nIf adding folders it only add all the MP3s fr" +
        "om that folder ");
            this.btnAddMP3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMP3
            // 
            this.btnRemoveMP3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveMP3.ImageIndex = 12;
            this.btnRemoveMP3.ImageList = this.imageList1;
            this.btnRemoveMP3.Location = new System.Drawing.Point(109, 0);
            this.btnRemoveMP3.Name = "btnRemoveMP3";
            this.btnRemoveMP3.Size = new System.Drawing.Size(75, 24);
            this.btnRemoveMP3.TabIndex = 2;
            this.btnRemoveMP3.Text = "      Delete";
            this.btnRemoveMP3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnRemoveMP3, "Deketes the selected file");
            this.btnRemoveMP3.UseVisualStyleBackColor = true;
            this.btnRemoveMP3.Click += new System.EventHandler(this.btnRemoveMP3_Click);
            // 
            // btnMoveMP3Down
            // 
            this.btnMoveMP3Down.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMoveMP3Down.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveMP3Down.ImageIndex = 13;
            this.btnMoveMP3Down.ImageList = this.imageList1;
            this.btnMoveMP3Down.Location = new System.Drawing.Point(47, 0);
            this.btnMoveMP3Down.Name = "btnMoveMP3Down";
            this.btnMoveMP3Down.Size = new System.Drawing.Size(62, 24);
            this.btnMoveMP3Down.TabIndex = 1;
            this.btnMoveMP3Down.Text = "     Down";
            this.btnMoveMP3Down.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMoveMP3Down, "Moves selected file down in the playlist");
            this.btnMoveMP3Down.UseVisualStyleBackColor = true;
            // 
            // btnMoveMP3Up
            // 
            this.btnMoveMP3Up.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMoveMP3Up.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoveMP3Up.ImageIndex = 14;
            this.btnMoveMP3Up.ImageList = this.imageList1;
            this.btnMoveMP3Up.Location = new System.Drawing.Point(0, 0);
            this.btnMoveMP3Up.Name = "btnMoveMP3Up";
            this.btnMoveMP3Up.Size = new System.Drawing.Size(47, 24);
            this.btnMoveMP3Up.TabIndex = 0;
            this.btnMoveMP3Up.Text = "   Up";
            this.btnMoveMP3Up.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnMoveMP3Up, "Moves the select file up in the playlist");
            this.btnMoveMP3Up.UseVisualStyleBackColor = true;
            this.btnMoveMP3Up.Click += new System.EventHandler(this.btnMoveMP3Up_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.lstVideoFiles);
            this.tabPage5.ImageIndex = 9;
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(313, 225);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Video Files";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lstVideoFiles
            // 
            this.lstVideoFiles.ContextMenuStrip = this.csVideos;
            this.lstVideoFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVideoFiles.FormattingEnabled = true;
            this.lstVideoFiles.HorizontalScrollbar = true;
            this.lstVideoFiles.Location = new System.Drawing.Point(3, 3);
            this.lstVideoFiles.Name = "lstVideoFiles";
            this.lstVideoFiles.Size = new System.Drawing.Size(307, 219);
            this.lstVideoFiles.TabIndex = 18;
            this.lstVideoFiles.SelectedIndexChanged += new System.EventHandler(this.lstVideoFiles_SelectedIndexChanged);
            this.lstVideoFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVideoFiles_MouseDoubleClick);
            this.lstVideoFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstVideoFiles_MouseMove);
            // 
            // csVideos
            // 
            this.csVideos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csVideos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csPlayVideo,
            this.csDeleteVideo,
            this.csRenameVideo,
            this.openVideoFolderToolStripMenuItem,
            this.mmuConvertVideo});
            this.csVideos.Name = "csVideos";
            this.csVideos.Size = new System.Drawing.Size(177, 134);
            // 
            // csPlayVideo
            // 
            this.csPlayVideo.Image = ((System.Drawing.Image)(resources.GetObject("csPlayVideo.Image")));
            this.csPlayVideo.Name = "csPlayVideo";
            this.csPlayVideo.Size = new System.Drawing.Size(176, 26);
            this.csPlayVideo.Text = "Play Video";
            this.csPlayVideo.Click += new System.EventHandler(this.csPlayVideo_Click);
            // 
            // csDeleteVideo
            // 
            this.csDeleteVideo.Image = ((System.Drawing.Image)(resources.GetObject("csDeleteVideo.Image")));
            this.csDeleteVideo.Name = "csDeleteVideo";
            this.csDeleteVideo.Size = new System.Drawing.Size(176, 26);
            this.csDeleteVideo.Text = "Delete Video File";
            this.csDeleteVideo.Click += new System.EventHandler(this.csDeleteVideo_Click);
            // 
            // csRenameVideo
            // 
            this.csRenameVideo.Image = ((System.Drawing.Image)(resources.GetObject("csRenameVideo.Image")));
            this.csRenameVideo.Name = "csRenameVideo";
            this.csRenameVideo.Size = new System.Drawing.Size(176, 26);
            this.csRenameVideo.Text = "Rename Video";
            this.csRenameVideo.Click += new System.EventHandler(this.renameVideo_Click);
            // 
            // openVideoFolderToolStripMenuItem
            // 
            this.openVideoFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openVideoFolderToolStripMenuItem.Image")));
            this.openVideoFolderToolStripMenuItem.Name = "openVideoFolderToolStripMenuItem";
            this.openVideoFolderToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.openVideoFolderToolStripMenuItem.Text = "Open Video Folder";
            this.openVideoFolderToolStripMenuItem.Click += new System.EventHandler(this.openVideoFolderToolStripMenuItem_Click);
            // 
            // mmuConvertVideo
            // 
            this.mmuConvertVideo.Image = ((System.Drawing.Image)(resources.GetObject("mmuConvertVideo.Image")));
            this.mmuConvertVideo.Name = "mmuConvertVideo";
            this.mmuConvertVideo.Size = new System.Drawing.Size(176, 26);
            this.mmuConvertVideo.Text = "Convert Video";
            this.mmuConvertVideo.Click += new System.EventHandler(this.mmuConvertVideo_Click);
            // 
            // ckbAutoPlay
            // 
            this.ckbAutoPlay.AutoSize = true;
            this.ckbAutoPlay.Checked = true;
            this.ckbAutoPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAutoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAutoPlay.Location = new System.Drawing.Point(91, 294);
            this.ckbAutoPlay.Name = "ckbAutoPlay";
            this.ckbAutoPlay.Size = new System.Drawing.Size(202, 19);
            this.ckbAutoPlay.TabIndex = 60;
            this.ckbAutoPlay.Text = "Auto Play File After Downloaded.";
            this.ckbAutoPlay.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "FileName";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFileName.Location = new System.Drawing.Point(92, 48);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(276, 20);
            this.txtFileName.TabIndex = 56;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged_1);
            // 
            // btnDownLoadNSave
            // 
            this.btnDownLoadNSave.BackColor = System.Drawing.Color.White;
            this.btnDownLoadNSave.Enabled = false;
            this.btnDownLoadNSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownLoadNSave.ImageIndex = 10;
            this.btnDownLoadNSave.ImageList = this.imageList1;
            this.btnDownLoadNSave.Location = new System.Drawing.Point(227, 317);
            this.btnDownLoadNSave.Name = "btnDownLoadNSave";
            this.btnDownLoadNSave.Size = new System.Drawing.Size(139, 23);
            this.btnDownLoadNSave.TabIndex = 55;
            this.btnDownLoadNSave.Text = "       Download MP3 Audio";
            this.toolTip1.SetToolTip(this.btnDownLoadNSave, "Downloads either MP3 and or video depending on \r\nthe checkbox Download MP3 audio " +
        "checked state.");
            this.btnDownLoadNSave.UseVisualStyleBackColor = false;
            this.btnDownLoadNSave.Click += new System.EventHandler(this.BtnDownLoadNSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Video Title";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Info;
            this.txtDuration.Location = new System.Drawing.Point(92, 135);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(276, 20);
            this.txtDuration.TabIndex = 51;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAuthor.Location = new System.Drawing.Point(92, 106);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(276, 20);
            this.txtAuthor.TabIndex = 50;
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtVideoTitle.Location = new System.Drawing.Point(92, 76);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.ReadOnly = true;
            this.txtVideoTitle.Size = new System.Drawing.Size(276, 20);
            this.txtVideoTitle.TabIndex = 49;
            // 
            // txtFileURL
            // 
            this.txtFileURL.Location = new System.Drawing.Point(92, 19);
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.Size = new System.Drawing.Size(479, 20);
            this.txtFileURL.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Youtube URL";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.label13);
            this.pnlMain.Controls.Add(this.label12);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label20);
            this.pnlMain.Controls.Add(this.pictureBox7);
            this.pnlMain.Controls.Add(this.pictureBox10);
            this.pnlMain.Controls.Add(this.label25);
            this.pnlMain.Controls.Add(this.label24);
            this.pnlMain.Controls.Add(this.pictureBox6);
            this.pnlMain.Controls.Add(this.pictureBox5);
            this.pnlMain.Controls.Add(this.pictureBox4);
            this.pnlMain.Controls.Add(this.pictureBox3);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Location = new System.Drawing.Point(48, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(818, 85);
            this.pnlMain.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(731, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Edit MP3 Tags";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(284, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "MP3s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Youtube";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Burn Files to CD/DVD";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(369, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Trim MP3";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(377, 23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Click here to edit mp3 using thee trim function");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseEnter += new System.EventHandler(this.pictureBox7_MouseEnter_1);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox7_MouseLeave_1);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(474, 23);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(49, 45);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox10, "Click here to start your browser");
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseEnter += new System.EventHandler(this.pictureBox10_MouseEnter_1);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox10_MouseLeave_1);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(184, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Video\'s";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.MediumBlue;
            this.label24.Location = new System.Drawing.Point(157, -1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(412, 24);
            this.label24.TabIndex = 6;
            this.label24.Text = "Youtube MP3 / Video Downloader Platinum";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(578, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(134, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Click here to burn CD/DVD");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter_1);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(151, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(280, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Click here to view MP3 files");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter_1);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(188, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Click here to view video files.");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(739, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Click here to edit MP3 tags");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter_1);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 19;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(910, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 43);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "      Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlRenameMP3
            // 
            this.pnlRenameMP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRenameMP3.Controls.Add(this.pictureBox1);
            this.pnlRenameMP3.Controls.Add(this.label10);
            this.pnlRenameMP3.Controls.Add(this.btnRenameMP3);
            this.pnlRenameMP3.Controls.Add(this.btnCancelRename);
            this.pnlRenameMP3.Controls.Add(this.txtNewMP3FileName);
            this.pnlRenameMP3.Controls.Add(this.label7);
            this.pnlRenameMP3.Controls.Add(this.txtCurMP3Name);
            this.pnlRenameMP3.Controls.Add(this.label6);
            this.pnlRenameMP3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRenameMP3.Location = new System.Drawing.Point(0, 0);
            this.pnlRenameMP3.Name = "pnlRenameMP3";
            this.pnlRenameMP3.Size = new System.Drawing.Size(892, 94);
            this.pnlRenameMP3.TabIndex = 71;
            this.pnlRenameMP3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(669, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 33);
            this.label10.TabIndex = 11;
            this.label10.Text = "MP3 File Renamer";
            // 
            // btnRenameMP3
            // 
            this.btnRenameMP3.BackColor = System.Drawing.Color.White;
            this.btnRenameMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenameMP3.ImageIndex = 33;
            this.btnRenameMP3.ImageList = this.imageList1;
            this.btnRenameMP3.Location = new System.Drawing.Point(775, 47);
            this.btnRenameMP3.Name = "btnRenameMP3";
            this.btnRenameMP3.Size = new System.Drawing.Size(93, 33);
            this.btnRenameMP3.TabIndex = 10;
            this.btnRenameMP3.Tag = "MP3";
            this.btnRenameMP3.Text = "       Save Name";
            this.toolTip1.SetToolTip(this.btnRenameMP3, "Save new MP3 filename");
            this.btnRenameMP3.UseVisualStyleBackColor = false;
            this.btnRenameMP3.Click += new System.EventHandler(this.btnRenameMP3_Click_1);
            // 
            // btnCancelRename
            // 
            this.btnCancelRename.BackColor = System.Drawing.Color.White;
            this.btnCancelRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelRename.ImageIndex = 8;
            this.btnCancelRename.ImageList = this.imageList1;
            this.btnCancelRename.Location = new System.Drawing.Point(690, 48);
            this.btnCancelRename.Name = "btnCancelRename";
            this.btnCancelRename.Size = new System.Drawing.Size(75, 33);
            this.btnCancelRename.TabIndex = 9;
            this.btnCancelRename.Tag = "Cancel";
            this.btnCancelRename.Text = "       Cancel";
            this.toolTip1.SetToolTip(this.btnCancelRename, "Close Renaming screen without saving.");
            this.btnCancelRename.UseVisualStyleBackColor = false;
            this.btnCancelRename.Click += new System.EventHandler(this.btnCancelRename_Click_2);
            // 
            // txtNewMP3FileName
            // 
            this.txtNewMP3FileName.Location = new System.Drawing.Point(416, 53);
            this.txtNewMP3FileName.Name = "txtNewMP3FileName";
            this.txtNewMP3FileName.Size = new System.Drawing.Size(233, 20);
            this.txtNewMP3FileName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter New MP3 Filename";
            // 
            // txtCurMP3Name
            // 
            this.txtCurMP3Name.AllowDrop = true;
            this.txtCurMP3Name.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCurMP3Name.Location = new System.Drawing.Point(102, 53);
            this.txtCurMP3Name.Name = "txtCurMP3Name";
            this.txtCurMP3Name.ReadOnly = true;
            this.txtCurMP3Name.Size = new System.Drawing.Size(241, 20);
            this.txtCurMP3Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current MP3 Filename";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.groupBox6);
            this.tabPage10.Controls.Add(this.groupBox5);
            this.tabPage10.Controls.Add(this.groupBox4);
            this.tabPage10.Controls.Add(this.label14);
            this.tabPage10.Controls.Add(this.btnDelVideoMPlayer2);
            this.tabPage10.Controls.Add(this.axWindowsMediaPlayer2);
            this.tabPage10.Controls.Add(this.button2);
            this.tabPage10.Controls.Add(this.button3);
            this.tabPage10.Controls.Add(this.button4);
            this.tabPage10.Controls.Add(this.btnPlayFile);
            this.tabPage10.Controls.Add(this.applyAudioNormalizationFilter);
            this.tabPage10.Controls.Add(this.conversionFormats);
            this.tabPage10.Controls.Add(this.checkBoxBatchMode);
            this.tabPage10.Controls.Add(this.presets);
            this.tabPage10.Controls.Add(this.label36);
            this.tabPage10.Controls.Add(this.label37);
            this.tabPage10.Controls.Add(this.label38);
            this.tabPage10.Controls.Add(this.browseOutputButton);
            this.tabPage10.Controls.Add(this.outputFileName);
            this.tabPage10.Controls.Add(this.inputFileName);
            this.tabPage10.Controls.Add(this.browseInputButton);
            this.tabPage10.Controls.Add(this.statusStrip2);
            this.tabPage10.Controls.Add(this.startConversionButton);
            this.tabPage10.ImageIndex = 9;
            this.tabPage10.Location = new System.Drawing.Point(4, 27);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1015, 499);
            this.tabPage10.TabIndex = 6;
            this.tabPage10.Text = "Edit Video";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picThumbNail);
            this.groupBox6.Location = new System.Drawing.Point(255, 161);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 204);
            this.groupBox6.TabIndex = 102;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Video Thumbnail Image";
            // 
            // picThumbNail
            // 
            this.picThumbNail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picThumbNail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picThumbNail.Location = new System.Drawing.Point(6, 19);
            this.picThumbNail.Name = "picThumbNail";
            this.picThumbNail.Size = new System.Drawing.Size(149, 173);
            this.picThumbNail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumbNail.TabIndex = 71;
            this.picThumbNail.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbAudioBitrate);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.audioChannels);
            this.groupBox5.Controls.Add(this.audioSamplerate);
            this.groupBox5.Controls.Add(this.txtaudioBitrate);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.audioScaleQuality);
            this.groupBox5.Controls.Add(this.includeAudio);
            this.groupBox5.Location = new System.Drawing.Point(423, 159);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 163);
            this.groupBox5.TabIndex = 101;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Audio Options";
            // 
            // cmbAudioBitrate
            // 
            this.cmbAudioBitrate.FormattingEnabled = true;
            this.cmbAudioBitrate.Items.AddRange(new object[] {
            "32k",
            "96k",
            "128k",
            "192k",
            "256k",
            "320k"});
            this.cmbAudioBitrate.Location = new System.Drawing.Point(73, 73);
            this.cmbAudioBitrate.Name = "cmbAudioBitrate";
            this.cmbAudioBitrate.Size = new System.Drawing.Size(121, 21);
            this.cmbAudioBitrate.TabIndex = 99;
            this.cmbAudioBitrate.Text = "192k";
            this.cmbAudioBitrate.SelectedIndexChanged += new System.EventHandler(this.cmbAudioBitrate_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 48);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 13);
            this.label29.TabIndex = 58;
            this.label29.Text = "Samplerate";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 59;
            this.label28.Text = "Audio Bitrate";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 108);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 60;
            this.label27.Text = "Channels";
            // 
            // audioChannels
            // 
            this.audioChannels.FormattingEnabled = true;
            this.audioChannels.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.audioChannels.Location = new System.Drawing.Point(74, 104);
            this.audioChannels.Name = "audioChannels";
            this.audioChannels.Size = new System.Drawing.Size(121, 21);
            this.audioChannels.TabIndex = 61;
            // 
            // audioSamplerate
            // 
            this.audioSamplerate.Location = new System.Drawing.Point(74, 45);
            this.audioSamplerate.Name = "audioSamplerate";
            this.audioSamplerate.Size = new System.Drawing.Size(121, 20);
            this.audioSamplerate.TabIndex = 62;
            // 
            // txtaudioBitrate
            // 
            this.txtaudioBitrate.Location = new System.Drawing.Point(74, 73);
            this.txtaudioBitrate.Name = "txtaudioBitrate";
            this.txtaudioBitrate.Size = new System.Drawing.Size(121, 20);
            this.txtaudioBitrate.TabIndex = 63;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 136);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 65;
            this.label26.Text = "Scale quality";
            // 
            // audioScaleQuality
            // 
            this.audioScaleQuality.FormattingEnabled = true;
            this.audioScaleQuality.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.audioScaleQuality.Location = new System.Drawing.Point(74, 133);
            this.audioScaleQuality.Name = "audioScaleQuality";
            this.audioScaleQuality.Size = new System.Drawing.Size(121, 21);
            this.audioScaleQuality.TabIndex = 66;
            // 
            // includeAudio
            // 
            this.includeAudio.AutoSize = true;
            this.includeAudio.Checked = true;
            this.includeAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeAudio.Location = new System.Drawing.Point(88, 19);
            this.includeAudio.Name = "includeAudio";
            this.includeAudio.Size = new System.Drawing.Size(90, 17);
            this.includeAudio.TabIndex = 57;
            this.includeAudio.Text = "Include audio";
            this.includeAudio.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.includeVideo);
            this.groupBox4.Controls.Add(this.videoResolution);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.videoBitrate);
            this.groupBox4.Controls.Add(this.videoFramerate);
            this.groupBox4.Controls.Add(this.videoScaleQuality);
            this.groupBox4.Location = new System.Drawing.Point(32, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 170);
            this.groupBox4.TabIndex = 100;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video Options";
            // 
            // includeVideo
            // 
            this.includeVideo.AutoSize = true;
            this.includeVideo.Checked = true;
            this.includeVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeVideo.Location = new System.Drawing.Point(93, 19);
            this.includeVideo.Name = "includeVideo";
            this.includeVideo.Size = new System.Drawing.Size(90, 17);
            this.includeVideo.TabIndex = 56;
            this.includeVideo.Text = "Include video";
            this.includeVideo.UseVisualStyleBackColor = true;
            // 
            // videoResolution
            // 
            this.videoResolution.Location = new System.Drawing.Point(73, 44);
            this.videoResolution.Name = "videoResolution";
            this.videoResolution.Size = new System.Drawing.Size(127, 20);
            this.videoResolution.TabIndex = 50;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 47);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 13);
            this.label35.TabIndex = 46;
            this.label35.Text = "Resolution";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(37, 13);
            this.label34.TabIndex = 47;
            this.label34.Text = "Bitrate";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(5, 104);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 13);
            this.label33.TabIndex = 48;
            this.label33.Text = "Framerate";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(67, 13);
            this.label32.TabIndex = 49;
            this.label32.Text = "Scale quality";
            // 
            // videoBitrate
            // 
            this.videoBitrate.Location = new System.Drawing.Point(73, 75);
            this.videoBitrate.Name = "videoBitrate";
            this.videoBitrate.Size = new System.Drawing.Size(127, 20);
            this.videoBitrate.TabIndex = 51;
            // 
            // videoFramerate
            // 
            this.videoFramerate.Location = new System.Drawing.Point(73, 104);
            this.videoFramerate.Name = "videoFramerate";
            this.videoFramerate.Size = new System.Drawing.Size(127, 20);
            this.videoFramerate.TabIndex = 52;
            // 
            // videoScaleQuality
            // 
            this.videoScaleQuality.FormattingEnabled = true;
            this.videoScaleQuality.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.videoScaleQuality.Location = new System.Drawing.Point(73, 130);
            this.videoScaleQuality.Name = "videoScaleQuality";
            this.videoScaleQuality.Size = new System.Drawing.Size(127, 21);
            this.videoScaleQuality.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "ConverTo";
            // 
            // btnDelVideoMPlayer2
            // 
            this.btnDelVideoMPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelVideoMPlayer2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelVideoMPlayer2.ImageIndex = 2;
            this.btnDelVideoMPlayer2.ImageList = this.imageList1;
            this.btnDelVideoMPlayer2.Location = new System.Drawing.Point(117, 337);
            this.btnDelVideoMPlayer2.Name = "btnDelVideoMPlayer2";
            this.btnDelVideoMPlayer2.Size = new System.Drawing.Size(115, 28);
            this.btnDelVideoMPlayer2.TabIndex = 97;
            this.btnDelVideoMPlayer2.Text = "      Delete Video";
            this.btnDelVideoMPlayer2.UseVisualStyleBackColor = true;
            this.btnDelVideoMPlayer2.Click += new System.EventHandler(this.btnDelVideoMPlayer2_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(649, 35);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(289, 278);
            this.axWindowsMediaPlayer2.TabIndex = 96;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(780, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 42);
            this.button2.TabIndex = 93;
            this.button2.Text = "        Vol +";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList2;
            this.button3.Location = new System.Drawing.Point(713, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 42);
            this.button3.TabIndex = 92;
            this.button3.Text = "       Mute";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.imageList2;
            this.button4.Location = new System.Drawing.Point(647, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 42);
            this.button4.TabIndex = 94;
            this.button4.Text = "       Vol -";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPlayFile
            // 
            this.btnPlayFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayFile.BackColor = System.Drawing.Color.White;
            this.btnPlayFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayFile.ImageIndex = 19;
            this.btnPlayFile.ImageList = this.imageList2;
            this.btnPlayFile.Location = new System.Drawing.Point(854, 321);
            this.btnPlayFile.Name = "btnPlayFile";
            this.btnPlayFile.Size = new System.Drawing.Size(84, 42);
            this.btnPlayFile.TabIndex = 70;
            this.btnPlayFile.Text = "        Play File";
            this.btnPlayFile.UseVisualStyleBackColor = false;
            this.btnPlayFile.Click += new System.EventHandler(this.btnPlayFile_Click);
            // 
            // applyAudioNormalizationFilter
            // 
            this.applyAudioNormalizationFilter.AutoSize = true;
            this.applyAudioNormalizationFilter.Checked = true;
            this.applyAudioNormalizationFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyAudioNormalizationFilter.Location = new System.Drawing.Point(300, 125);
            this.applyAudioNormalizationFilter.Margin = new System.Windows.Forms.Padding(2);
            this.applyAudioNormalizationFilter.Name = "applyAudioNormalizationFilter";
            this.applyAudioNormalizationFilter.Size = new System.Drawing.Size(111, 17);
            this.applyAudioNormalizationFilter.TabIndex = 69;
            this.applyAudioNormalizationFilter.Text = "Normalization filter";
            this.applyAudioNormalizationFilter.UseVisualStyleBackColor = true;
            this.applyAudioNormalizationFilter.CheckedChanged += new System.EventHandler(this.applyAudioNormalizationFilter_CheckedChanged);
            // 
            // conversionFormats
            // 
            this.conversionFormats.FormattingEnabled = true;
            this.conversionFormats.Location = new System.Drawing.Point(86, 122);
            this.conversionFormats.Name = "conversionFormats";
            this.conversionFormats.Size = new System.Drawing.Size(66, 21);
            this.conversionFormats.TabIndex = 68;
            this.conversionFormats.SelectedIndexChanged += new System.EventHandler(this.conversionFormats_SelectedIndexChanged);
            // 
            // checkBoxBatchMode
            // 
            this.checkBoxBatchMode.AutoSize = true;
            this.checkBoxBatchMode.Location = new System.Drawing.Point(158, 125);
            this.checkBoxBatchMode.Name = "checkBoxBatchMode";
            this.checkBoxBatchMode.Size = new System.Drawing.Size(126, 17);
            this.checkBoxBatchMode.TabIndex = 67;
            this.checkBoxBatchMode.Text = "Batch mode (Folders)";
            this.checkBoxBatchMode.UseVisualStyleBackColor = true;
            // 
            // presets
            // 
            this.presets.FormattingEnabled = true;
            this.presets.Location = new System.Drawing.Point(529, 121);
            this.presets.Margin = new System.Windows.Forms.Padding(2);
            this.presets.Name = "presets";
            this.presets.Size = new System.Drawing.Size(94, 21);
            this.presets.TabIndex = 64;
            this.presets.SelectedIndexChanged += new System.EventHandler(this.presets_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(427, 125);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 13);
            this.label36.TabIndex = 45;
            this.label36.Text = "Advanced options ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(29, 83);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 13);
            this.label37.TabIndex = 44;
            this.label37.Text = "Output file";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(29, 45);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 13);
            this.label38.TabIndex = 43;
            this.label38.Text = "Input file";
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseOutputButton.ImageIndex = 15;
            this.browseOutputButton.ImageList = this.imageList2;
            this.browseOutputButton.Location = new System.Drawing.Point(525, 77);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(98, 30);
            this.browseOutputButton.TabIndex = 42;
            this.browseOutputButton.Text = "      Browse";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // outputFileName
            // 
            this.outputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileName.Location = new System.Drawing.Point(96, 83);
            this.outputFileName.Name = "outputFileName";
            this.outputFileName.Size = new System.Drawing.Size(419, 20);
            this.outputFileName.TabIndex = 41;
            // 
            // inputFileName
            // 
            this.inputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileName.Location = new System.Drawing.Point(96, 45);
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.Size = new System.Drawing.Size(419, 20);
            this.inputFileName.TabIndex = 40;
            this.inputFileName.TextChanged += new System.EventHandler(this.inputFileName_TextChanged);
            // 
            // browseInputButton
            // 
            this.browseInputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInputButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseInputButton.ImageIndex = 17;
            this.browseInputButton.ImageList = this.imageList2;
            this.browseInputButton.Location = new System.Drawing.Point(524, 39);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(98, 30);
            this.browseInputButton.TabIndex = 39;
            this.browseInputButton.Text = "      Browse";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip2.Location = new System.Drawing.Point(3, 474);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 38;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel2.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.CausesValidation = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(500, 19);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // startConversionButton
            // 
            this.startConversionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startConversionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startConversionButton.ImageIndex = 22;
            this.startConversionButton.ImageList = this.imageList2;
            this.startConversionButton.Location = new System.Drawing.Point(423, 335);
            this.startConversionButton.Name = "startConversionButton";
            this.startConversionButton.Size = new System.Drawing.Size(115, 30);
            this.startConversionButton.TabIndex = 37;
            this.startConversionButton.Text = "      Start Conversion";
            this.startConversionButton.UseVisualStyleBackColor = true;
            this.startConversionButton.Click += new System.EventHandler(this.startConversionButton_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControl1);
            this.tabPage6.Controls.Add(this.btnMainTRiM);
            this.tabPage6.ImageIndex = 4;
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1015, 499);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Edit / Trim MP3 ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(8, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 423);
            this.tabControl1.TabIndex = 85;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.mP3SliderSongTrim);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(975, 397);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Trim Song";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(156, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(495, 36);
            this.label16.TabIndex = 52;
            this.label16.Text = "MP3 Platinum Edition MP3 Song Trimmer";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.mP3SliderAlbumSplitter);
            this.tabPage9.Controls.Add(this.label15);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(975, 397);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Split Album";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(213, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(507, 36);
            this.label15.TabIndex = 53;
            this.label15.Text = "MP3 Platinum Edition MP3 Album Splitter";
            // 
            // btnMainTRiM
            // 
            this.btnMainTRiM.BackColor = System.Drawing.Color.White;
            this.btnMainTRiM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainTRiM.ImageIndex = 0;
            this.btnMainTRiM.ImageList = this.imageList2;
            this.btnMainTRiM.Location = new System.Drawing.Point(909, 440);
            this.btnMainTRiM.Name = "btnMainTRiM";
            this.btnMainTRiM.Size = new System.Drawing.Size(78, 42);
            this.btnMainTRiM.TabIndex = 84;
            this.btnMainTRiM.Text = "         Main";
            this.btnMainTRiM.UseVisualStyleBackColor = false;
            this.btnMainTRiM.Click += new System.EventHandler(this.btnMainTRiM_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnMainTE);
            this.tabPage7.Controls.Add(this.label18);
            this.tabPage7.Controls.Add(this.lblTagEditFilePath);
            this.tabPage7.Controls.Add(this.btnTagSaveTag);
            this.tabPage7.Controls.Add(this.btnTagOpenMP3);
            this.tabPage7.Controls.Add(this.ucID3v2);
            this.tabPage7.ImageIndex = 41;
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1015, 499);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "MP3 Tag Editor";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnMainTE
            // 
            this.btnMainTE.BackColor = System.Drawing.Color.White;
            this.btnMainTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainTE.ImageIndex = 0;
            this.btnMainTE.ImageList = this.imageList2;
            this.btnMainTE.Location = new System.Drawing.Point(900, 423);
            this.btnMainTE.Name = "btnMainTE";
            this.btnMainTE.Size = new System.Drawing.Size(78, 42);
            this.btnMainTE.TabIndex = 83;
            this.btnMainTE.Text = "         Main";
            this.btnMainTE.UseVisualStyleBackColor = false;
            this.btnMainTE.Click += new System.EventHandler(this.btnMainTE_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Location = new System.Drawing.Point(146, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(521, 33);
            this.label18.TabIndex = 50;
            this.label18.Text = "MP3 Platinum Edition ID3v2 MP3 Tag Editor";
            // 
            // lblTagEditFilePath
            // 
            this.lblTagEditFilePath.AutoSize = true;
            this.lblTagEditFilePath.Location = new System.Drawing.Point(29, 404);
            this.lblTagEditFilePath.Name = "lblTagEditFilePath";
            this.lblTagEditFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblTagEditFilePath.TabIndex = 49;
            this.lblTagEditFilePath.Visible = false;
            // 
            // btnTagSaveTag
            // 
            this.btnTagSaveTag.BackColor = System.Drawing.Color.White;
            this.btnTagSaveTag.Enabled = false;
            this.btnTagSaveTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTagSaveTag.ImageIndex = 9;
            this.btnTagSaveTag.ImageList = this.imageList2;
            this.btnTagSaveTag.Location = new System.Drawing.Point(577, 422);
            this.btnTagSaveTag.Name = "btnTagSaveTag";
            this.btnTagSaveTag.Size = new System.Drawing.Size(137, 44);
            this.btnTagSaveTag.TabIndex = 48;
            this.btnTagSaveTag.Text = "      Save MP3 Tag";
            this.toolTip1.SetToolTip(this.btnTagSaveTag, "Saves the tag edits o MP3");
            this.btnTagSaveTag.UseVisualStyleBackColor = false;
            this.btnTagSaveTag.Click += new System.EventHandler(this.btnTagSaveTag_Click);
            // 
            // btnTagOpenMP3
            // 
            this.btnTagOpenMP3.BackColor = System.Drawing.Color.White;
            this.btnTagOpenMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTagOpenMP3.ImageIndex = 8;
            this.btnTagOpenMP3.ImageList = this.imageList2;
            this.btnTagOpenMP3.Location = new System.Drawing.Point(18, 422);
            this.btnTagOpenMP3.Name = "btnTagOpenMP3";
            this.btnTagOpenMP3.Size = new System.Drawing.Size(108, 44);
            this.btnTagOpenMP3.TabIndex = 45;
            this.btnTagOpenMP3.Text = "      Load MP3";
            this.toolTip1.SetToolTip(this.btnTagOpenMP3, "Load MP3 file to edit or add MP3 tags");
            this.btnTagOpenMP3.UseVisualStyleBackColor = false;
            this.btnTagOpenMP3.Click += new System.EventHandler(this.btnTagOpenMP3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMainBurn);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.ImageIndex = 26;
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1015, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CD/DVD Burn Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMainBurn
            // 
            this.btnMainBurn.BackColor = System.Drawing.Color.White;
            this.btnMainBurn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainBurn.ImageIndex = 0;
            this.btnMainBurn.ImageList = this.imageList2;
            this.btnMainBurn.Location = new System.Drawing.Point(918, 407);
            this.btnMainBurn.Name = "btnMainBurn";
            this.btnMainBurn.Size = new System.Drawing.Size(78, 42);
            this.btnMainBurn.TabIndex = 84;
            this.btnMainBurn.Text = "         Main";
            this.btnMainBurn.UseVisualStyleBackColor = false;
            this.btnMainBurn.Click += new System.EventHandler(this.btnMainBurn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Location = new System.Drawing.Point(35, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(606, 33);
            this.label19.TabIndex = 52;
            this.label19.Text = "MP3 Platinum Edition CDR-CDRW Burnning Program";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btnBurnCD);
            this.groupBox3.Location = new System.Drawing.Point(41, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 394);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Burn MP3 Sound Files TO CD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNoAutoLoad);
            this.groupBox2.Controls.Add(this.rbAutoLoad);
            this.groupBox2.Location = new System.Drawing.Point(19, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 83);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Burn Options";
            // 
            // rbNoAutoLoad
            // 
            this.rbNoAutoLoad.AutoSize = true;
            this.rbNoAutoLoad.Location = new System.Drawing.Point(6, 25);
            this.rbNoAutoLoad.Name = "rbNoAutoLoad";
            this.rbNoAutoLoad.Size = new System.Drawing.Size(94, 17);
            this.rbNoAutoLoad.TabIndex = 5;
            this.rbNoAutoLoad.Text = "No Auto Load ";
            this.toolTip1.SetToolTip(this.rbNoAutoLoad, "Manually select files to to burm");
            this.rbNoAutoLoad.UseVisualStyleBackColor = true;
            // 
            // rbAutoLoad
            // 
            this.rbAutoLoad.AutoSize = true;
            this.rbAutoLoad.Checked = true;
            this.rbAutoLoad.Location = new System.Drawing.Point(6, 50);
            this.rbAutoLoad.Name = "rbAutoLoad";
            this.rbAutoLoad.Size = new System.Drawing.Size(120, 17);
            this.rbAutoLoad.TabIndex = 3;
            this.rbAutoLoad.TabStop = true;
            this.rbAutoLoad.Text = "Auto Load MP3 files";
            this.toolTip1.SetToolTip(this.rbAutoLoad, "Loads burner with all MP3 file in the default directory.");
            this.rbAutoLoad.UseVisualStyleBackColor = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(19, 161);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(301, 178);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 4;
            this.pictureBox9.TabStop = false;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(16, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(304, 35);
            this.label17.TabIndex = 1;
            this.label17.Text = "Burn M{3 files to CD Recomended usage is a CDR or CDRW";
            // 
            // btnBurnCD
            // 
            this.btnBurnCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBurnCD.ImageIndex = 26;
            this.btnBurnCD.ImageList = this.imageList1;
            this.btnBurnCD.Location = new System.Drawing.Point(97, 353);
            this.btnBurnCD.Name = "btnBurnCD";
            this.btnBurnCD.Size = new System.Drawing.Size(143, 32);
            this.btnBurnCD.TabIndex = 0;
            this.btnBurnCD.Text = "    Burn MP3 Files";
            this.btnBurnCD.UseVisualStyleBackColor = true;
            this.btnBurnCD.Click += new System.EventHandler(this.btnBurnCD_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.llCheckForUpdates);
            this.tabPage2.Controls.Add(this.llemailSupport);
            this.tabPage2.Controls.Add(this.linkLabel2);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.btnMainHelp);
            this.tabPage2.ImageIndex = 42;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1015, 499);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Help/About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // llCheckForUpdates
            // 
            this.llCheckForUpdates.AutoSize = true;
            this.llCheckForUpdates.Location = new System.Drawing.Point(683, 65);
            this.llCheckForUpdates.Name = "llCheckForUpdates";
            this.llCheckForUpdates.Size = new System.Drawing.Size(94, 13);
            this.llCheckForUpdates.TabIndex = 86;
            this.llCheckForUpdates.TabStop = true;
            this.llCheckForUpdates.Text = "Check for updates";
            this.llCheckForUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCheckForUpdates_LinkClicked);
            // 
            // llemailSupport
            // 
            this.llemailSupport.AutoSize = true;
            this.llemailSupport.Location = new System.Drawing.Point(846, 63);
            this.llemailSupport.Name = "llemailSupport";
            this.llemailSupport.Size = new System.Drawing.Size(72, 13);
            this.llemailSupport.TabIndex = 85;
            this.llemailSupport.TabStop = true;
            this.llemailSupport.Text = "Email Support";
            this.llemailSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llemailSupport_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(472, 63);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(166, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Donations are greatly appreciated";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(296, 63);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.productfast.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 95);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1015, 404);
            this.webBrowser1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(924, 73);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnMainHelp
            // 
            this.btnMainHelp.BackColor = System.Drawing.Color.White;
            this.btnMainHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainHelp.ImageIndex = 0;
            this.btnMainHelp.ImageList = this.imageList2;
            this.btnMainHelp.Location = new System.Drawing.Point(934, 13);
            this.btnMainHelp.Name = "btnMainHelp";
            this.btnMainHelp.Size = new System.Drawing.Size(74, 40);
            this.btnMainHelp.TabIndex = 84;
            this.btnMainHelp.Text = "         Main";
            this.btnMainHelp.UseVisualStyleBackColor = false;
            this.btnMainHelp.Click += new System.EventHandler(this.btnMainHelp_Click);
            // 
            // ofdMP3
            // 
            this.ofdMP3.Filter = "MP3 files (*.mp3)|*.mp3";
            // 
            // tmrVideo
            // 
            this.tmrVideo.Interval = 500;
            // 
            // tmrMarquee
            // 
            this.tmrMarquee.Interval = 250;
            this.tmrMarquee.Tick += new System.EventHandler(this.tmrMarquee_Tick);
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
            this.openFileDialog.Multiselect = true;
            // 
            // backgroundFormatWorker
            // 
            this.backgroundFormatWorker.WorkerReportsProgress = true;
            this.backgroundFormatWorker.WorkerSupportsCancellation = true;
            // 
            // audioOpenFileDialog
            // 
            this.audioOpenFileDialog.Filter = "*.mp3|*.mp3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitButton1
            // 
            this.splitButton1.AutoSize = true;
            this.splitButton1.BackColor = System.Drawing.Color.White;
            this.splitButton1.ContextMenuStrip = this.cmsAudioVideoButton;
            this.splitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitButton1.ImageIndex = 10;
            this.splitButton1.ImageList = this.imageList1;
            this.splitButton1.Location = new System.Drawing.Point(688, 342);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Size = new System.Drawing.Size(308, 28);
            this.splitButton1.SplitMenuStrip = this.cmsAudioVideoButton;
            this.splitButton1.TabIndex = 70;
            this.splitButton1.Text = "       Click Arrow for Audio / Video Options";
            this.toolTip1.SetToolTip(this.splitButton1, "Ckick here for audio video options");
            this.splitButton1.UseVisualStyleBackColor = false;
            // 
            // textProgressBarMax
            // 
            this.textProgressBarMax.BackColor = System.Drawing.Color.White;
            this.textProgressBarMax.CustomText = "Testing";
            this.textProgressBarMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textProgressBarMax.Location = new System.Drawing.Point(685, 302);
            this.textProgressBarMax.MarqueeAnimationSpeed = 10;
            this.textProgressBarMax.Maximum = 688;
            this.textProgressBarMax.Name = "textProgressBarMax";
            this.textProgressBarMax.ProgressColor = System.Drawing.Color.LawnGreen;
            this.textProgressBarMax.Size = new System.Drawing.Size(310, 25);
            this.textProgressBarMax.TabIndex = 88;
            this.textProgressBarMax.TextColor = System.Drawing.Color.Black;
            this.textProgressBarMax.TextFont = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProgressBarMax.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            // 
            // textProgressBar1
            // 
            this.textProgressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textProgressBar1.CustomText = "Testing";
            this.textProgressBar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textProgressBar1.Location = new System.Drawing.Point(6, 345);
            this.textProgressBar1.MarqueeAnimationSpeed = 10;
            this.textProgressBar1.Maximum = 110;
            this.textProgressBar1.Name = "textProgressBar1";
            this.textProgressBar1.ProgressColor = System.Drawing.Color.LawnGreen;
            this.textProgressBar1.Size = new System.Drawing.Size(362, 25);
            this.textProgressBar1.TabIndex = 84;
            this.textProgressBar1.TextColor = System.Drawing.Color.DarkBlue;
            this.textProgressBar1.TextFont = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textProgressBar1.Visible = false;
            this.textProgressBar1.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            this.textProgressBar1.VisibleChanged += new System.EventHandler(this.textProgressBar1_VisibleChanged);
            // 
            // mP3SliderSongTrim
            // 
            this.mP3SliderSongTrim.Location = new System.Drawing.Point(117, 58);
            this.mP3SliderSongTrim.Margin = new System.Windows.Forms.Padding(4);
            this.mP3SliderSongTrim.Name = "mP3SliderSongTrim";
            this.mP3SliderSongTrim.Size = new System.Drawing.Size(763, 307);
            this.mP3SliderSongTrim.TabIndex = 52;
            this.toolTip1.SetToolTip(this.mP3SliderSongTrim, "Load MP3 file that needs trimmed.");
            // 
            // mP3SliderAlbumSplitter
            // 
            this.mP3SliderAlbumSplitter.Location = new System.Drawing.Point(111, 73);
            this.mP3SliderAlbumSplitter.Margin = new System.Windows.Forms.Padding(4);
            this.mP3SliderAlbumSplitter.Name = "mP3SliderAlbumSplitter";
            this.mP3SliderAlbumSplitter.Size = new System.Drawing.Size(763, 307);
            this.mP3SliderAlbumSplitter.TabIndex = 54;
            this.toolTip1.SetToolTip(this.mP3SliderAlbumSplitter, "Load MP3 file that needs trimmed.");
            // 
            // ucID3v2
            // 
            this.ucID3v2.Controls.Add(this.imageBindingNavigator);
            this.ucID3v2.Location = new System.Drawing.Point(18, 39);
            this.ucID3v2.Margin = new System.Windows.Forms.Padding(4);
            this.ucID3v2.Name = "ucID3v2";
            this.ucID3v2.Size = new System.Drawing.Size(704, 375);
            this.ucID3v2.TabIndex = 44;
            // 
            // imageBindingNavigator
            // 
            this.imageBindingNavigator.AddNewItem = null;
            this.imageBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageBindingNavigator.CountItem = null;
            this.imageBindingNavigator.DeleteItem = null;
            this.imageBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.imageBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.imageBindingNavigator.Location = new System.Drawing.Point(410, 339);
            this.imageBindingNavigator.MoveFirstItem = null;
            this.imageBindingNavigator.MoveLastItem = null;
            this.imageBindingNavigator.MoveNextItem = null;
            this.imageBindingNavigator.MovePreviousItem = null;
            this.imageBindingNavigator.Name = "imageBindingNavigator";
            this.imageBindingNavigator.PositionItem = null;
            this.imageBindingNavigator.Size = new System.Drawing.Size(111, 25);
            this.imageBindingNavigator.TabIndex = 124;
            this.imageBindingNavigator.Text = "bindingNavigator1";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 530);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Video / MP3 Platinum Edition ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAudioVideo)).EndInit();
            this.cmsAudioVideoButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIsConnected)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControlAudioVideo.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.csListMP3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.cmsMP3AddFiles.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.csVideos.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlRenameMP3.ResumeLayout(false);
            this.pnlRenameMP3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbNail)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodingOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingOptionsBindingSource1)).EndInit();
            this.ucID3v2.ResumeLayout(false);
            this.ucID3v2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip cmsMP3AddFiles;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip csVideos;
        private System.Windows.Forms.ToolStripMenuItem csPlayVideo;
        private System.Windows.Forms.ToolStripMenuItem csDeleteVideo;
        private System.Windows.Forms.ToolStripMenuItem csRenameVideo;
        private System.Windows.Forms.OpenFileDialog ofdMP3;
        private System.Windows.Forms.Timer tmrVideo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip csListMP3;
        private System.Windows.Forms.ToolStripMenuItem csmPlayMP3;
        private System.Windows.Forms.ToolStripMenuItem csmDeleteMP3;
        private System.Windows.Forms.ToolStripMenuItem cmsPlayAllMp3Files;
        private System.Windows.Forms.ContextMenuStrip cmsAudioVideoButton;
        private System.Windows.Forms.ToolStripMenuItem CsConvertMP4ToMP3;
        private System.Windows.Forms.ToolStripMenuItem CSselectVideoFile;
        private System.Windows.Forms.ToolStripMenuItem selectVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CsDeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem addMP3FilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVideoFilesToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelDownload;
        private wyDay.Controls.SplitButton splitButton1;
        private System.Windows.Forms.CheckBox ckbAudioOnly;
        private System.Windows.Forms.Button btnPasteURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.TextBox txtSaveVideoAs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbAutoPlay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnDownLoadNSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtVideoTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileURL;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckIConnection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblFolderSize;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnMainVolDown;
        private System.Windows.Forms.Button btnMainVolUp;
        private System.Windows.Forms.Button btnMainMute;
        private ProgressBarSample.TextProgressBar textProgressBar1;
        private System.Windows.Forms.Timer tmrMarquee;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessages;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnBurnCD;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label lblSongCount;
        private ProgressBarSample.TextProgressBar textProgressBarMax;
        private System.Windows.Forms.Timer tmrBrowserPBar;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnTagSaveTag;
        private System.Windows.Forms.Button btnTagOpenMP3;
        private IdSharp.Tagging.Harness.WinForms.UserControls.ID3v2UserControl ucID3v2;
        private System.Windows.Forms.BindingNavigator imageBindingNavigator;
        private System.Windows.Forms.OpenFileDialog audioOpenFileDialog;
        private System.Windows.Forms.Label lblTagEditFilePath;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabControl tabControlAudioVideo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstMP3s;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddMP3;
        private System.Windows.Forms.Button btnRemoveMP3;
        private System.Windows.Forms.Button btnMoveMP3Down;
        private System.Windows.Forms.Button btnMoveMP3Up;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox lstVideoFiles;
        private System.Windows.Forms.PictureBox picIsConnected;
        private System.Windows.Forms.ToolStripMenuItem cmsRnameMP3;
        private System.Windows.Forms.Panel pnlRenameMP3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRenameMP3;
        private System.Windows.Forms.Button btnCancelRename;
        private System.Windows.Forms.TextBox txtNewMP3FileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurMP3Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private UserControls.MP3Slider mP3SliderSongTrim;
        private System.Windows.Forms.PictureBox picAudioVideo;
        private System.Windows.Forms.Button btnRefreshMP3List;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNoAutoLoad;
        private System.Windows.Forms.RadioButton rbAutoLoad;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem openMP3FolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVideoFolderToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnVideoFullScreen;
        private System.Windows.Forms.Button btnMainTE;
        private System.Windows.Forms.Button btnMainTRiM;
        private System.Windows.Forms.Button btnMainBurn;
        private System.Windows.Forms.Button btnMainHelp;
        private System.Windows.Forms.LinkLabel llemailSupport;
        private System.Windows.Forms.LinkLabel llCheckForUpdates;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label15;
        private UserControls.MP3Slider mP3SliderAlbumSplitter;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RadioButton rbAudioAndVideo;
        private System.Windows.Forms.RadioButton rbVideoFileOnly;
        private System.Windows.Forms.RadioButton rbMp3Only;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem mmuConvertVideo;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.OpenFileDialog ofdVideos;
        private System.Windows.Forms.PictureBox picThumbNail;
        private System.Windows.Forms.Button btnPlayFile;
        private System.Windows.Forms.CheckBox applyAudioNormalizationFilter;
        private System.Windows.Forms.ComboBox conversionFormats;
        private System.Windows.Forms.CheckBox checkBoxBatchMode;
        private System.Windows.Forms.ComboBox audioScaleQuality;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox presets;
        private System.Windows.Forms.TextBox txtaudioBitrate;
        private System.Windows.Forms.TextBox audioSamplerate;
        private System.Windows.Forms.ComboBox audioChannels;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox includeAudio;
        private System.Windows.Forms.CheckBox includeVideo;
        private System.Windows.Forms.ComboBox videoScaleQuality;
        private System.Windows.Forms.TextBox videoFramerate;
        private System.Windows.Forms.TextBox videoBitrate;
        private System.Windows.Forms.MaskedTextBox videoResolution;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.TextBox outputFileName;
        private System.Windows.Forms.TextBox inputFileName;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button startConversionButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.BindingSource encodingOptionsBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource encodingOptionsBindingSource1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDelVideoMPlayer2;
        private System.Windows.Forms.ComboBox cmbAudioBitrate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}