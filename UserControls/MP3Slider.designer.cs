using iGreen.Controls.uControls.uLabelX;

namespace YoutubeDownloader.UserControls
{
    partial class MP3Slider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3Slider));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnLoadMP3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LblTimeFormat1 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblTimeDesc = new System.Windows.Forms.Label();
            this.LblTimeFormat2 = new System.Windows.Forms.Label();
            this.LblTotalTime = new System.Windows.Forms.Label();
            this.LblTotalTimeDesc = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblEndTrimEnd = new System.Windows.Forms.Label();
            this.btnTrimEnd = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.btnTrimStart = new System.Windows.Forms.Button();
            this.lblEndTrimStart = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnTrimMP3 = new System.Windows.Forms.Button();
            this.btnUndoStart = new System.Windows.Forms.Button();
            this.btnUndoEnd = new System.Windows.Forms.Button();
            this.btnSaveTrimMP3 = new System.Windows.Forms.Button();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.lblTempFilePath = new System.Windows.Forms.Label();
            this.lblTrackBarLine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MP3PositionTimer = new System.Windows.Forms.Timer(this.components);
            this.colorTrackBar1 = new GradientControls.ColorTrackBar();
            this.lblTrimStart = new System.Windows.Forms.Label();
            this.lblTrimEnd = new System.Windows.Forms.Label();
            this.lblSongTitle = new iGreen.Controls.uControls.uLabelX.uLabelX();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblTrimmedFilePath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.btnLoadMP3);
            this.panel1.Controls.Add(this.LblTimeFormat1);
            this.panel1.Controls.Add(this.LblTime);
            this.panel1.Controls.Add(this.LblTimeDesc);
            this.panel1.Controls.Add(this.LblTimeFormat2);
            this.panel1.Controls.Add(this.LblTotalTime);
            this.panel1.Controls.Add(this.LblTotalTimeDesc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(344, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(79, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 62;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btnLoadMP3
            // 
            this.btnLoadMP3.BackColor = System.Drawing.Color.White;
            this.btnLoadMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadMP3.ImageIndex = 12;
            this.btnLoadMP3.ImageList = this.imageList1;
            this.btnLoadMP3.Location = new System.Drawing.Point(167, 13);
            this.btnLoadMP3.Name = "btnLoadMP3";
            this.btnLoadMP3.Size = new System.Drawing.Size(120, 44);
            this.btnLoadMP3.TabIndex = 31;
            this.btnLoadMP3.Text = "        Load MP3 File";
            this.btnLoadMP3.UseVisualStyleBackColor = false;
            this.btnLoadMP3.Click += new System.EventHandler(this.btnEditOpenMP3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "UndoIcon.png");
            this.imageList1.Images.SetKeyName(1, "Open-file-icon.png");
            this.imageList1.Images.SetKeyName(2, "CutFile.png");
            this.imageList1.Images.SetKeyName(3, "MediaStop.png");
            this.imageList1.Images.SetKeyName(4, "Save.png");
            this.imageList1.Images.SetKeyName(5, "audio-button-pink-flat.png");
            this.imageList1.Images.SetKeyName(6, "Aqua-Restart-icon.png");
            this.imageList1.Images.SetKeyName(7, "Red_Checkmark.png");
            this.imageList1.Images.SetKeyName(8, "small-green-check-mark1.png");
            this.imageList1.Images.SetKeyName(9, "pause.png");
            this.imageList1.Images.SetKeyName(10, "music_folder.png");
            this.imageList1.Images.SetKeyName(11, "small-green-check-mark1.png");
            this.imageList1.Images.SetKeyName(12, "load-md.png");
            this.imageList1.Images.SetKeyName(13, "");
            // 
            // LblTimeFormat1
            // 
            this.LblTimeFormat1.AutoSize = true;
            this.LblTimeFormat1.BackColor = System.Drawing.Color.Transparent;
            this.LblTimeFormat1.Enabled = false;
            this.LblTimeFormat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeFormat1.Location = new System.Drawing.Point(12, 50);
            this.LblTimeFormat1.Name = "LblTimeFormat1";
            this.LblTimeFormat1.Size = new System.Drawing.Size(88, 13);
            this.LblTimeFormat1.TabIndex = 30;
            this.LblTimeFormat1.Text = "hh:  mm:  ss:  ms:";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(9, 30);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(93, 20);
            this.LblTime.TabIndex = 29;
            this.LblTime.Text = "00:00.00:00";
            // 
            // LblTimeDesc
            // 
            this.LblTimeDesc.AutoSize = true;
            this.LblTimeDesc.BackColor = System.Drawing.Color.Transparent;
            this.LblTimeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeDesc.Location = new System.Drawing.Point(9, 10);
            this.LblTimeDesc.Name = "LblTimeDesc";
            this.LblTimeDesc.Size = new System.Drawing.Size(65, 20);
            this.LblTimeDesc.TabIndex = 28;
            this.LblTimeDesc.Text = "Position";
            // 
            // LblTimeFormat2
            // 
            this.LblTimeFormat2.AutoSize = true;
            this.LblTimeFormat2.BackColor = System.Drawing.Color.Transparent;
            this.LblTimeFormat2.Enabled = false;
            this.LblTimeFormat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeFormat2.Location = new System.Drawing.Point(466, 50);
            this.LblTimeFormat2.Name = "LblTimeFormat2";
            this.LblTimeFormat2.Size = new System.Drawing.Size(88, 13);
            this.LblTimeFormat2.TabIndex = 27;
            this.LblTimeFormat2.Text = "hh:  mm:  ss:  ms:";
            // 
            // LblTotalTime
            // 
            this.LblTotalTime.AutoSize = true;
            this.LblTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTime.Location = new System.Drawing.Point(460, 30);
            this.LblTotalTime.Name = "LblTotalTime";
            this.LblTotalTime.Size = new System.Drawing.Size(93, 20);
            this.LblTotalTime.TabIndex = 25;
            this.LblTotalTime.Text = "00:00.00:00";
            // 
            // LblTotalTimeDesc
            // 
            this.LblTotalTimeDesc.AutoSize = true;
            this.LblTotalTimeDesc.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalTimeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTimeDesc.Location = new System.Drawing.Point(459, 10);
            this.LblTotalTimeDesc.Name = "LblTotalTimeDesc";
            this.LblTotalTimeDesc.Size = new System.Drawing.Size(82, 20);
            this.LblTotalTimeDesc.TabIndex = 26;
            this.LblTotalTimeDesc.Text = "Total Time";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(560, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 68;
            this.label19.Text = "Trim Poisition";
            // 
            // lblEndTrimEnd
            // 
            this.lblEndTrimEnd.AutoSize = true;
            this.lblEndTrimEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTrimEnd.Location = new System.Drawing.Point(559, 29);
            this.lblEndTrimEnd.Name = "lblEndTrimEnd";
            this.lblEndTrimEnd.Size = new System.Drawing.Size(73, 16);
            this.lblEndTrimEnd.TabIndex = 69;
            this.lblEndTrimEnd.Text = "00:00:00:00";
            // 
            // btnTrimEnd
            // 
            this.btnTrimEnd.BackColor = System.Drawing.Color.White;
            this.btnTrimEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrimEnd.ImageIndex = 2;
            this.btnTrimEnd.ImageList = this.imageList1;
            this.btnTrimEnd.Location = new System.Drawing.Point(639, 9);
            this.btnTrimEnd.Name = "btnTrimEnd";
            this.btnTrimEnd.Size = new System.Drawing.Size(106, 40);
            this.btnTrimEnd.TabIndex = 67;
            this.btnTrimEnd.Text = "        Set\r\n         Trim End";
            this.btnTrimEnd.UseVisualStyleBackColor = false;
            this.btnTrimEnd.Click += new System.EventHandler(this.btnTrimEnd_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(97, 12);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 64;
            this.label27.Text = "Trim Poisition";
            // 
            // btnTrimStart
            // 
            this.btnTrimStart.BackColor = System.Drawing.Color.White;
            this.btnTrimStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrimStart.ImageIndex = 2;
            this.btnTrimStart.ImageList = this.imageList1;
            this.btnTrimStart.Location = new System.Drawing.Point(5, 9);
            this.btnTrimStart.Name = "btnTrimStart";
            this.btnTrimStart.Size = new System.Drawing.Size(90, 40);
            this.btnTrimStart.TabIndex = 65;
            this.btnTrimStart.Text = "         Set \r\n        Trim Start";
            this.btnTrimStart.UseVisualStyleBackColor = false;
            this.btnTrimStart.Click += new System.EventHandler(this.btnTrimStart_Click);
            // 
            // lblEndTrimStart
            // 
            this.lblEndTrimStart.AutoSize = true;
            this.lblEndTrimStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTrimStart.Location = new System.Drawing.Point(96, 29);
            this.lblEndTrimStart.Name = "lblEndTrimStart";
            this.lblEndTrimStart.Size = new System.Drawing.Size(73, 16);
            this.lblEndTrimStart.TabIndex = 66;
            this.lblEndTrimStart.Text = "00:00:00:00";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnTrimMP3);
            this.pnlButtons.Controls.Add(this.btnUndoStart);
            this.pnlButtons.Controls.Add(this.btnUndoEnd);
            this.pnlButtons.Controls.Add(this.btnSaveTrimMP3);
            this.pnlButtons.Controls.Add(this.btnPlaySong);
            this.pnlButtons.Controls.Add(this.label19);
            this.pnlButtons.Controls.Add(this.btnTrimStart);
            this.pnlButtons.Controls.Add(this.lblEndTrimEnd);
            this.pnlButtons.Controls.Add(this.lblEndTrimStart);
            this.pnlButtons.Controls.Add(this.btnTrimEnd);
            this.pnlButtons.Controls.Add(this.label27);
            this.pnlButtons.Enabled = false;
            this.pnlButtons.Location = new System.Drawing.Point(0, 187);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(749, 101);
            this.pnlButtons.TabIndex = 70;
            // 
            // btnTrimMP3
            // 
            this.btnTrimMP3.BackColor = System.Drawing.Color.White;
            this.btnTrimMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrimMP3.ImageIndex = 7;
            this.btnTrimMP3.ImageList = this.imageList1;
            this.btnTrimMP3.Location = new System.Drawing.Point(324, 10);
            this.btnTrimMP3.Name = "btnTrimMP3";
            this.btnTrimMP3.Size = new System.Drawing.Size(103, 40);
            this.btnTrimMP3.TabIndex = 76;
            this.btnTrimMP3.Text = "       Trim MP3";
            this.btnTrimMP3.UseVisualStyleBackColor = false;
            this.btnTrimMP3.Click += new System.EventHandler(this.btnTrimMP3_Click);
            // 
            // btnUndoStart
            // 
            this.btnUndoStart.BackColor = System.Drawing.Color.White;
            this.btnUndoStart.ImageIndex = 0;
            this.btnUndoStart.ImageList = this.imageList1;
            this.btnUndoStart.Location = new System.Drawing.Point(172, 16);
            this.btnUndoStart.Name = "btnUndoStart";
            this.btnUndoStart.Size = new System.Drawing.Size(30, 30);
            this.btnUndoStart.TabIndex = 75;
            this.btnUndoStart.UseVisualStyleBackColor = false;
            this.btnUndoStart.Click += new System.EventHandler(this.btnUndoStart_Click);
            // 
            // btnUndoEnd
            // 
            this.btnUndoEnd.BackColor = System.Drawing.Color.White;
            this.btnUndoEnd.ImageIndex = 0;
            this.btnUndoEnd.ImageList = this.imageList1;
            this.btnUndoEnd.Location = new System.Drawing.Point(526, 15);
            this.btnUndoEnd.Name = "btnUndoEnd";
            this.btnUndoEnd.Size = new System.Drawing.Size(30, 30);
            this.btnUndoEnd.TabIndex = 74;
            this.btnUndoEnd.UseVisualStyleBackColor = false;
            this.btnUndoEnd.Click += new System.EventHandler(this.btnUndoEnd_Click);
            // 
            // btnSaveTrimMP3
            // 
            this.btnSaveTrimMP3.BackColor = System.Drawing.Color.White;
            this.btnSaveTrimMP3.Enabled = false;
            this.btnSaveTrimMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTrimMP3.ImageIndex = 4;
            this.btnSaveTrimMP3.ImageList = this.imageList1;
            this.btnSaveTrimMP3.Location = new System.Drawing.Point(639, 57);
            this.btnSaveTrimMP3.Name = "btnSaveTrimMP3";
            this.btnSaveTrimMP3.Size = new System.Drawing.Size(106, 40);
            this.btnSaveTrimMP3.TabIndex = 73;
            this.btnSaveTrimMP3.Text = "        Save Edits";
            this.btnSaveTrimMP3.UseVisualStyleBackColor = false;
            this.btnSaveTrimMP3.Click += new System.EventHandler(this.btnSaveTrimMP3_Click);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.BackColor = System.Drawing.Color.White;
            this.btnPlaySong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaySong.ImageIndex = 5;
            this.btnPlaySong.ImageList = this.imageList1;
            this.btnPlaySong.Location = new System.Drawing.Point(5, 57);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(106, 40);
            this.btnPlaySong.TabIndex = 71;
            this.btnPlaySong.Text = "           Play MP3";
            this.btnPlaySong.UseVisualStyleBackColor = false;
            this.btnPlaySong.Click += new System.EventHandler(this.btnEditPlayMP3_Click);
            // 
            // lblTempFilePath
            // 
            this.lblTempFilePath.AutoSize = true;
            this.lblTempFilePath.Location = new System.Drawing.Point(-3, 326);
            this.lblTempFilePath.Name = "lblTempFilePath";
            this.lblTempFilePath.Size = new System.Drawing.Size(56, 13);
            this.lblTempFilePath.TabIndex = 71;
            this.lblTempFilePath.Text = "TempPath";
            // 
            // lblTrackBarLine
            // 
            this.lblTrackBarLine.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblTrackBarLine.Location = new System.Drawing.Point(1, 94);
            this.lblTrackBarLine.Name = "lblTrackBarLine";
            this.lblTrackBarLine.Size = new System.Drawing.Size(3, 65);
            this.lblTrackBarLine.TabIndex = 72;
            this.lblTrackBarLine.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // MP3PositionTimer
            // 
            this.MP3PositionTimer.Interval = 200;
            this.MP3PositionTimer.Tick += new System.EventHandler(this.MP3PositionTimer_Tick);
            // 
            // colorTrackBar1
            // 
            this.colorTrackBar1.BarBorderColor = System.Drawing.Color.DimGray;
            this.colorTrackBar1.BarColor = System.Drawing.Color.White;
            this.colorTrackBar1.BarOrientation = GradientControls.Orientations.Horizontal;
            this.colorTrackBar1.ControlCornerStyle = GradientControls.CornerStyles.Square;
            this.colorTrackBar1.Location = new System.Drawing.Point(0, 162);
            this.colorTrackBar1.Maximum = 100;
            this.colorTrackBar1.MaximumValueSide = GradientControls.Poles.Right;
            this.colorTrackBar1.Minimum = 0;
            this.colorTrackBar1.Name = "colorTrackBar1";
            this.colorTrackBar1.Size = new System.Drawing.Size(752, 25);
            this.colorTrackBar1.TabIndex = 2;
            this.colorTrackBar1.ThumbLocation = 1;
            this.colorTrackBar1.TrackerBorderColor = System.Drawing.Color.LightSteelBlue;
            this.colorTrackBar1.TrackerColor = System.Drawing.Color.DarkBlue;
            this.colorTrackBar1.TrackerSize = 5;
            this.colorTrackBar1.Value = 0;
            this.colorTrackBar1.ValueChanged += new GradientControls.ColorTrackBar.ValueChangedEventHandler(this.colorTrackBar1_ValueChanged);
            this.colorTrackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorTrackBar1_MouseDown);
            this.colorTrackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorTrackBar1_MouseUp);
            // 
            // lblTrimStart
            // 
            this.lblTrimStart.BackColor = System.Drawing.Color.DarkRed;
            this.lblTrimStart.Location = new System.Drawing.Point(107, 94);
            this.lblTrimStart.Name = "lblTrimStart";
            this.lblTrimStart.Size = new System.Drawing.Size(3, 65);
            this.lblTrimStart.TabIndex = 74;
            this.lblTrimStart.Visible = false;
            // 
            // lblTrimEnd
            // 
            this.lblTrimEnd.BackColor = System.Drawing.Color.DarkRed;
            this.lblTrimEnd.Location = new System.Drawing.Point(116, 94);
            this.lblTrimEnd.Name = "lblTrimEnd";
            this.lblTrimEnd.Size = new System.Drawing.Size(3, 65);
            this.lblTrimEnd.TabIndex = 75;
            this.lblTrimEnd.Visible = false;
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.BorderColor = System.Drawing.Color.Black;
            this.lblSongTitle.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lblSongTitle.BorderStyle = iGreen.Controls.uControls.uLabelX.Common.BorderStyles.None;
            this.lblSongTitle.BorderWidth = 1F;
            this.lblSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblSongTitle.Image = null;
            this.lblSongTitle.Location = new System.Drawing.Point(0, 142);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(562, 21);
            this.lblSongTitle.Text = null;
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(0, 307);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(45, 13);
            this.lblFilePath.TabIndex = 76;
            this.lblFilePath.Text = "FilePath";
            // 
            // lblTrimmedFilePath
            // 
            this.lblTrimmedFilePath.AutoSize = true;
            this.lblTrimmedFilePath.Location = new System.Drawing.Point(-5, 346);
            this.lblTrimmedFilePath.Name = "lblTrimmedFilePath";
            this.lblTrimmedFilePath.Size = new System.Drawing.Size(85, 13);
            this.lblTrimmedFilePath.TabIndex = 78;
            this.lblTrimmedFilePath.Text = "TrimmedFilePath";
            // 
            // MP3Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTrimmedFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.lblTrimEnd);
            this.Controls.Add(this.lblTrimStart);
            this.Controls.Add(this.lblTrackBarLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTempFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.colorTrackBar1);
            this.Controls.Add(this.panel1);
            this.Name = "MP3Slider";
            this.Size = new System.Drawing.Size(752, 379);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblEndTrimEnd;
        private System.Windows.Forms.Button btnTrimEnd;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnTrimStart;
        private System.Windows.Forms.Label lblEndTrimStart;
        private System.Windows.Forms.Panel pnlButtons;
        internal System.Windows.Forms.Label LblTimeFormat2;
        internal System.Windows.Forms.Label LblTotalTime;
        internal System.Windows.Forms.Label LblTotalTimeDesc;
        internal System.Windows.Forms.Label LblTimeFormat1;
        internal System.Windows.Forms.Label LblTime;
        internal System.Windows.Forms.Label LblTimeDesc;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.Button btnSaveTrimMP3;
        private System.Windows.Forms.Button btnLoadMP3;
        private System.Windows.Forms.Label lblTempFilePath;
        private GradientControls.ColorTrackBar colorTrackBar1;
        private System.Windows.Forms.Label lblTrackBarLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MP3PositionTimer;
        private System.Windows.Forms.Label lblTrimStart;
        private System.Windows.Forms.Label lblTrimEnd;
        private System.Windows.Forms.Button btnUndoStart;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnUndoEnd;
        private iGreen.Controls.uControls.uLabelX.uLabelX lblSongTitle;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnTrimMP3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblTrimmedFilePath;
    }
}
