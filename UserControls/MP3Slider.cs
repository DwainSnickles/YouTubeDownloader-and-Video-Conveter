using System;
using System.Drawing;
using System.Windows.Forms;
using static GradientControls.ColorTrackBar;
using System.IO;
using NAudio.Wave;

namespace YoutubeDownloader.UserControls
{
    public partial class MP3Slider : UserControl
    {

        string MP3TempFolderPath = AppDomain.CurrentDomain.BaseDirectory + "MP3Temp\\";
        string MP3FolderPath = AppDomain.CurrentDomain.BaseDirectory + "MP3s\\";
        Silence.Audio PlayMP3File;
        int intSongLenght = 0;
        TimeSpan TrimStart; TimeSpan TrimEndEnd; TimeSpan SongLenght;
        Boolean SongPlaying = false;
        Boolean TestingEdits;
        int EditNumber = 0;
        String OrgFileName = String.Empty;
        String DestFilePath = String.Empty; //holds the last edited file to send to MP3 Folder is saved

        public MP3Slider()
        {
            InitializeComponent();
            colorTrackBar1.ValueChanged += new ValueChangedEventHandler(CustomTrackbar1_ValueChanged);
        }

        private void CustomTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(colorTrackBar1.Value);
            lblTrackBarLine.Location = new Point(colorTrackBar1.ThumbLocation + 1, 90);
            lblTrackBarLine.Refresh();
        }

        private void btnEditOpenMP3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 File (*.mp3)|*.mp3";
            if (open.ShowDialog() != DialogResult.OK) return;
            if (!open.FileName.EndsWith(".mp3")) { return; }
            if (PlayMP3File != null) { PlayMP3File.Dispose(); }
            PlayMP3File = new Silence.Audio(open.FileName);
            DeleteTempFolder();
            String FilePath = open.FileName;
            OrgFileName = Path.GetFileNameWithoutExtension(FilePath);
            lblFilePath.Text = FilePath;
            colorTrackBar1.Value = 0;
            lblTrimStart.Visible = false;
            lblEndTrimStart.Text = "00:00:00:00";
            lblTrimEnd.Visible = false;
            lblEndTrimEnd.Text = "00:00:00:00";
            lblTempFilePath.Text = MP3TempFolderPath + Path.GetFileName(FilePath);
            lblSongTitle.Text = Path.GetFileNameWithoutExtension(FilePath);
            colorTrackBar1.Maximum = Convert.ToInt32(PlayMP3File.TotalDuration.TotalSeconds + 1);
            TimeSpan ts = Silence.Audio.SongLenght(FilePath);
            intSongLenght = Convert.ToInt32(PlayMP3File.TotalDuration.TotalSeconds);
            SongLenght = PlayMP3File.TotalDuration;
            SetLabelText(LblTotalTime, ts);
            LoadWaveForm(FilePath);
            pnlButtons.Enabled = true;
            btnTrimMP3.Enabled = false;
        }

        private void SetLabelText(Label LabelName, TimeSpan ts)
        {
            LabelName.Text = ts.ToString("mm\\:ss\\:ff");
        }

        private void DeleteTempFolder()
        {
            string[] files = Directory.GetFiles(MP3TempFolderPath);
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
        }

        private void LoadWaveForm(String MP3FilePath)
        {
            string strPath = MP3FilePath;
            string SongID = "2";
            byte[] bytes = File.ReadAllBytes(strPath);
            WriteToFile(SongID, strPath, bytes);
        }

        private void WriteToFile(string SongID, string strPath, byte[] Buffer)
        {
            try
            {
                int samplesPerPixel = 128;
                long startPosition = 0;
                float[] data = FloatArrayFromByteArray(Buffer);

                Bitmap bmp = new Bitmap(1170, 200);

                int BORDER_WIDTH = 5;
                int width = bmp.Width - (2 * BORDER_WIDTH);
                int height = bmp.Height - (2 * BORDER_WIDTH);

                NAudio.Wave.Mp3FileReader reader = new NAudio.Wave.Mp3FileReader(strPath, wf => new NAudio.FileFormats.Mp3.DmoMp3FrameDecompressor(wf));
                NAudio.Wave.WaveChannel32 channelStream = new NAudio.Wave.WaveChannel32(reader);

                int bytesPerSample = (reader.WaveFormat.BitsPerSample / 8) * channelStream.WaveFormat.Channels;

                using (Graphics g = Graphics.FromImage(bmp))
                {

                    g.Clear(Color.White);
                    Pen pen1 = new Pen(Color.Gray);
                    int size = data.Length;

                    string hexValue1 = "#009adf";
                    Color colour1 = System.Drawing.ColorTranslator.FromHtml(hexValue1);
                    pen1.Color = colour1;

                    Stream wavestream = new NAudio.Wave.Mp3FileReader(strPath, wf => new NAudio.FileFormats.Mp3.DmoMp3FrameDecompressor(wf));

                    wavestream.Position = 0;
                    int bytesRead1;
                    byte[] waveData1 = new byte[samplesPerPixel * bytesPerSample];
                    wavestream.Position = startPosition + (width * bytesPerSample * samplesPerPixel);

                    for (float x = 0; x < width; x++)
                    {
                        short low = 0;
                        short high = 0;
                        bytesRead1 = wavestream.Read(waveData1, 0, samplesPerPixel * bytesPerSample);
                        if (bytesRead1 == 0)
                            break;
                        for (int n = 0; n < bytesRead1; n += 2)
                        {
                            short sample = BitConverter.ToInt16(waveData1, n);
                            if (sample < low) low = sample;
                            if (sample > high) high = sample;
                        }
                        float lowPercent = ((((float)low) - short.MinValue) / ushort.MaxValue);
                        float highPercent = ((((float)high) - short.MinValue) / ushort.MaxValue);
                        float lowValue = height * lowPercent;
                        float highValue = height * highPercent;
                        g.DrawLine(pen1, x, lowValue, x, highValue);
                    }
                   
                }

                pictureBox1.Image = bmp;
                reader.Close();
                channelStream.Close();
            }
            catch
            {

            }
        }

        public float[] FloatArrayFromStream(System.IO.MemoryStream stream)
        {
            return FloatArrayFromByteArray(stream.GetBuffer());
        }

        public float[] FloatArrayFromByteArray(byte[] input)
        {
            float[] output = new float[input.Length / 4];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = BitConverter.ToSingle(input, i * 4);
            }
            return output;
        }

        private void btnEditPlayMP3_Click(object sender, EventArgs e)
        {
            if (PlayMP3File == null) return;

            switch (PlayMP3File.State)
            {
                case Silence.Audio.PlayBackState.Paused:
                    MP3PositionTimer.Enabled = true;
                    btnPlaySong.Text = "    Pause";
                    PlayMP3File.Play();
                    SongPlaying = false;
                    btnPlaySong.ImageIndex = 9;
                    break;

                case Silence.Audio.PlayBackState.Playing:
                    MP3PositionTimer.Enabled = false;
                    btnPlaySong.Text = "           Play MP3";
                    PlayMP3File.Pause();
                    SongPlaying = true;
                    btnPlaySong.ImageIndex = 5;
                    break;

                case Silence.Audio.PlayBackState.Stopped:
                    btnPlaySong.Text = "    Pause";
                    MP3PositionTimer.Enabled = true;
                    PlayMP3File.Play();
                    SongPlaying = false;
                    btnPlaySong.ImageIndex = 9;
                    break;
            }
        }

        private void MP3PositionTimer_Tick(object sender, EventArgs e)
        {
                TimeSpan currentTime = (PlayMP3File.State == Silence.Audio.PlayBackState.Stopped) ? TimeSpan.Zero : PlayMP3File.TimePosition;
                SetLabelText(LblTime, currentTime);
                colorTrackBar1.Value = Convert.ToInt32(PlayMP3File.TimePosition.TotalSeconds);

                if (colorTrackBar1.Value >= intSongLenght)
                {
                    MP3PositionTimer.Enabled = false;
                    PlayMP3File.Stop();
                }
        }

        private void btnTrimStart_Click(object sender, EventArgs e)
        {
            if (PlayMP3File == null) { return; }
            if (SongPlaying == true) { btnPlaySong.PerformClick();}
            lblEndTrimStart.Text = PlayMP3File.TimePosition.ToString("hh\\:mm\\:ss\\:ff");
            if (PlayMP3File.TimePosition == TimeSpan.Zero) { return; }
            TrimStart = PlayMP3File.TimePosition;
            btnTrimStart.ImageIndex = 11;
            btnTrimStart.Text = "         Position          Set";
            btnTrimMP3.ImageIndex = 8;
            lblTrimStart.Location = new Point(lblTrackBarLine.Location.X, 90);
            lblTrimStart.Visible = true;
            lblTrimStart.Refresh();
            colorTrackBar1.Value = 0;
            btnTrimMP3.Enabled = true;
        }

        private void colorTrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (PlayMP3File == null)
            {
                colorTrackBar1.Value = 0;
                return;
            }
        }

        private void colorTrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (PlayMP3File == null)
            {
                colorTrackBar1.Value = 0;
                return;
            }
            if (SongPlaying == false) { PlayMP3File.TimePosition = TimeSpan.FromSeconds(colorTrackBar1.Value + 5); }
            if (SongPlaying == true) { btnPlaySong.PerformClick(); }
            PlayMP3File.TimePosition = TimeSpan.FromSeconds(colorTrackBar1.Value);
            SetLabelText(LblTime, PlayMP3File.TimePosition);
        }


        private void btnTrimEnd_Click(object sender, EventArgs e)
        {
            if (PlayMP3File == null) { return; }
            if (PlayMP3File.TimePosition == SongLenght) { return; }
            btnTrimMP3.ImageIndex = 8;
            btnTrimEnd.ImageIndex = 11;
            colorTrackBar1.Value = 0;
            lblEndTrimEnd.Text = PlayMP3File.TimePosition.ToString("hh\\:mm\\:ss\\:ff");
            TrimEndEnd = PlayMP3File.TimePosition;
            btnTrimEnd.Text = "         Position          Set";
            lblTrimEnd.Location = new Point(lblTrackBarLine.Location.X, 90);
            lblTrimEnd.Visible = true;
            lblTrimEnd.Refresh();
            btnTrimMP3.Enabled = true;
        }

        private void btnSaveTrimMP3_Click(object sender, EventArgs e)
        {
            PlayMP3File.Dispose();
            string SourceFilePath = @DestFilePath; // Full path of old file
            string DesFilePath = @MP3FolderPath + OrgFileName + ".mp3"; // Full path of new file

            File.Copy(SourceFilePath, DesFilePath, true);
          
            btnSaveTrimMP3.Enabled = false;
            EditNumber = 0;
        }

        private void btnUndoStart_Click(object sender, EventArgs e)
        {
            TrimStart = TimeSpan.Zero;
            btnTrimStart.Text = "             Set              Trim Start";
            lblTrimStart.Visible = false;
            lblEndTrimStart.Text = "00:00:00:00";
            if (lblTrimStart.Visible == false && lblTrimEnd.Visible == false)
            {
                btnTrimMP3.Enabled = false;
            }
            btnTrimStart.ImageIndex = 2;
            if (lblEndTrimEnd.Text == "00:00:00:00") { btnTrimMP3.ImageIndex = 7; }
        }

        private void btnUndoEnd_Click(object sender, EventArgs e)
        {
            TrimEndEnd = TimeSpan.Zero;
            lblTrimEnd.Visible = false;
            lblEndTrimEnd.Text = "00:00:00:00";
            btnTrimEnd.Text = "            Set                Trim End";
            btnTrimEnd.ImageIndex = 2;
            if (lblEndTrimStart.Text == "00:00:00:00") { btnTrimMP3.ImageIndex = 7; }
            if (lblTrimStart.Visible == false && lblTrimEnd.Visible == false)
            {
                btnTrimMP3.Enabled = false;
            }
        }

        private void btnEditRestart_Click(object sender, EventArgs e)
        {
            if (TestingEdits)
            {
                PlayMP3File.TimePosition = TrimStart;
            }
            else
            {
                colorTrackBar1.Value = 0;
                lblTrackBarLine.Location = new Point(1, 83);
                PlayMP3File.TimePosition = TimeSpan.Zero;
                LblTime.Text = "00:00.00:00";
            }
        }

        void TrimMp3(string inputPath, string outputPath, TimeSpan? begin, TimeSpan? end)
        {
            if (begin.HasValue && end.HasValue && begin > end)
                throw new ArgumentOutOfRangeException("end", "end should be greater than begin");

            if (PlayMP3File != null) { PlayMP3File.Dispose(); }
                if (File.Exists(outputPath))
                {
                    EditNumber += 1;
                    outputPath = MP3TempFolderPath + Path.GetFileNameWithoutExtension(outputPath) + EditNumber + ".mp3";
            }

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

        private void btnTrimMP3_Click(object sender, EventArgs e)
        {
            if (SongPlaying == true){ return; }

            if (lblTrimStart.Visible != true && lblTrimEnd.Visible != true) { return; }

            if (lblEndTrimEnd.Text == "00:00:00:00" && lblEndTrimStart.Text == "00:00:00:00") { return; }

            btnSaveTrimMP3.Enabled = true;

            EditNumber += 1;
            btnTrimStart.ImageIndex = 2;
            btnTrimEnd.ImageIndex = 2;
            btnTrimMP3.ImageIndex = 7;

            var mp3Path = lblFilePath.Text;
            var outputPath = MP3TempFolderPath; 
            var Newmp3Path = String.Empty;
            var NewOutPutPath = String.Empty;

            outputPath = MP3TempFolderPath + OrgFileName + EditNumber + ".mp3";

            if (lblEndTrimStart.Text != "00:00:00:00")
            {
              TrimMp3(mp3Path, outputPath, TrimStart, PlayMP3File.TotalDuration);
              Newmp3Path = outputPath; // this name is empty do a normal cut or else adjust 
            }


            if (lblEndTrimEnd.Text != "00:00:00:00")
            {
                EditNumber += 1;

                if (Newmp3Path == String.Empty) //Start was not trimmed just trim end
                {
                    TrimMp3(mp3Path, outputPath,TimeSpan.Zero, TrimEndEnd);
                }
                else //Start was trimmed adjust as needed
                {
                    TrimEndEnd = TrimEndEnd - TrimStart;
                    //Change Output path to prevent file in use
                    NewOutPutPath = MP3TempFolderPath + OrgFileName + EditNumber + ".mp3";
                    TrimMp3(outputPath, NewOutPutPath, TimeSpan.Zero, TrimEndEnd);

                }
            }

            if (NewOutPutPath != String.Empty)
            {
                TimeSpan ts = Silence.Audio.SongLenght(NewOutPutPath);
                SetLabelText(LblTotalTime, ts);
                PlayMP3File = new Silence.Audio(NewOutPutPath);
                SongLenght = PlayMP3File.TotalDuration;
                lblSongTitle.Text = Path.GetFileName(NewOutPutPath);
                LoadWaveForm(NewOutPutPath);
                DestFilePath = NewOutPutPath;
            }
            else
            {
                TimeSpan ts = Silence.Audio.SongLenght(outputPath);
                SetLabelText(LblTotalTime, ts);
                PlayMP3File = new Silence.Audio(outputPath);
                lblSongTitle.Text = Path.GetFileName(outputPath);
                LoadWaveForm(outputPath);
                DestFilePath = outputPath;
            }

            lblTrimEnd.Visible = false;
            lblEndTrimEnd.Text = "00:00.00:00";
            lblTrimStart.Visible = false;
            lblEndTrimStart.Text = "00:00.00:00";
            btnTrimStart.Text = "             Set              Trim Start";
            btnTrimEnd.Text = "            Set                Trim End";
            LblTime.Text = "00:00.00:00";
            colorTrackBar1.Value = 0;
        }

        private void colorTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (PlayMP3File == null)
            {
                return;
            }

            if (TestingEdits == true)
            {
                TimeSpan t = TimeSpan.Parse(lblEndTrimEnd.Text);
                if (t == TrimEndEnd)
                {
                    btnPlaySong.PerformClick();
                    TestingEdits = false;
                    //label2.Text = GetTimeSpanFromTicks(colorTrackBar1.Value)
                }
            }
        }

        private void btnStopSong_Click(object sender, EventArgs e)
        {
            if (SongPlaying == true) { btnPlaySong.PerformClick(); }
            PlayMP3File.Stop();
            btnPlaySong.Text = "           Play MP3";
            btnPlaySong.ImageIndex = 5;
        }

        static void GetTimeSpanFromTicks(long ticks)
        {
            // Create a TimeSpan object and TimeSpan string from 
            // a number of ticks.
            TimeSpan interval = TimeSpan.FromTicks(ticks);
            string timeInterval = interval.ToString();

            // Pad the end of the TimeSpan string with spaces if it 
            // does not contain milliseconds.
            int pIndex = timeInterval.IndexOf(':');
            pIndex = timeInterval.IndexOf('.', pIndex);
            if (pIndex < 0) timeInterval += "        ";

            Console.WriteLine("{0,21}{1,26}", ticks, timeInterval);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}


