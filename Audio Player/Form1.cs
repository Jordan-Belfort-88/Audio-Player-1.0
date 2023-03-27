using NAudio.Wave;

namespace Audio_Player
{


    public partial class Form1 : Form
    {
        // Channel 1
        private WaveOutEvent waveOutAudio;
        private WaveOutEvent waveOutMic;
        private string fileRoute;
        private WaveInEvent waveInDevice;
        private bool playing = false;
        private long pausePosition = 0;
        private AudioFileReader reader;
        private float volumen = 1f;
        private WaveFormat waveFormatSelected;

        // Channel 2
        private WaveOutEvent waveOutAudio2;
        private WaveOutEvent waveOutMic2;
        private string fileRoute2;
        private WaveInEvent waveInDevice2;
        private bool playing2 = false;
        private long pausePosition2 = 0;
        private AudioFileReader reader2;
        private float volumen2 = 1f;
        private WaveFormat waveFormatSelected2;

        // Channel 3
        private WaveOutEvent waveOutAudio3;
        private WaveOutEvent waveOutMic3;
        private string fileRoute3;
        private WaveInEvent waveInDevice3;
        private bool playing3 = false;
        private long pausePosition3 = 0;
        private AudioFileReader reader3;
        private float volumen3 = 1f;
        private WaveFormat waveFormatSelected3;

        // Channel 4
        private WaveOutEvent waveOutAudio4;
        private WaveOutEvent waveOutMic4;
        private string fileRoute4;
        private WaveInEvent waveInDevice4;
        private bool playing4 = false;
        private long pausePosition4 = 0;
        private AudioFileReader reader4;
        private float volumen4 = 1f;
        private WaveFormat waveFormatSelected4;

        public Form1()
        {
            InitializeComponent();
            FillComboBoxOuts();

            // Set default value
            waveFormatSelected = new WaveFormat(22050, 16, 1);
            waveFormatSelected2 = new WaveFormat(22050, 16, 1);
            waveFormatSelected3 = new WaveFormat(22050, 16, 1);
            waveFormatSelected4 = new WaveFormat(22050, 16, 1);
        }

        private void FillComboBoxOuts()
        {
            // Get avaible devices information
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                WaveOutCapabilities capabilities = WaveOut.GetCapabilities(i);
                CBOuts.Items.Add(capabilities.ProductName);
                CBOuts2.Items.Add(capabilities.ProductName);
                CBOuts3.Items.Add(capabilities.ProductName);
                CBOuts4.Items.Add(capabilities.ProductName);
            }
        }

        private void CBOuts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBOuts2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBOuts3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBOuts4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void block_CheckedChanged(object sender, EventArgs e)
        {
            if (Block1.Checked)
            {
                CBOuts.Enabled = false;
            }
            else
            {
                CBOuts.Enabled = true;
            }
        }
        private void block2_CheckedChanged(object sender, EventArgs e)
        {
            if (Block2.Checked)
            {
                CBOuts2.Enabled = false;
            }
            else
            {
                CBOuts2.Enabled = true;
            }
        }
        private void block3_CheckedChanged(object sender, EventArgs e)
        {
            if (Block3.Checked)
            {
                CBOuts3.Enabled = false;
            }
            else
            {
                CBOuts3.Enabled = true;
            }
        }
        private void block4_CheckedChanged(object sender, EventArgs e)
        {
            if (Block4.Checked)
            {
                CBOuts4.Enabled = false;
            }
            else
            {
                CBOuts4.Enabled = true;
            }
        }


        private void buttonSelect_Click(object sender, EventArgs e)
        {
            // Show dialog to select an audio file
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file route
                fileRoute = openFile.FileName;

            }
        }
        private void buttonSelect2_Click(object sender, EventArgs e)
        {
            // Show dialog to select an audio file
            if (openFile2.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file route
                fileRoute2 = openFile2.FileName;

            }
        }
        private void buttonSelect3_Click(object sender, EventArgs e)
        {
            // Show dialog to select an audio file
            if (openFile3.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file route
                fileRoute3 = openFile3.FileName;

            }
        }
        private void buttonSelect4_Click(object sender, EventArgs e)
        {
            // Show dialog to select an audio file
            if (openFile4.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file route
                fileRoute4 = openFile4.FileName;

            }
        }

        private void Play_Click_1(object sender, EventArgs e)
        {
            if (!playing)
            {
                // Check if there is a WaveOut instance in use
                if (waveOutAudio != null)
                {
                    waveOutAudio.Stop();
                    waveOutAudio.Dispose();
                    waveOutAudio = null;
                }

                // Generates a WaveOut instance to play the audio file
                waveOutAudio = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada = CBOuts.SelectedIndex;

                if (string.IsNullOrEmpty(fileRoute))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Generates an AudioFileReade instance to read the audio file
                reader = new AudioFileReader(fileRoute);



                // Connects the output device with the AudioFileReader instance
                waveOutAudio.DeviceNumber = salidaSeleccionada;
                waveOutAudio.Init(reader);

                // Restore saved position and volume
                reader.Volume = volumen;
                reader.Position = pausePosition;

                // Play audio file
                waveOutAudio.Play();

                // Changes button text and update playing state
                Play1.Text = "⏸";
                playing = true;
            }
            else
            {
                // Stop play and free resources
                pausePosition = reader.Position;
                volumen = reader.Volume; // save current volume
                waveOutAudio.Stop();
                waveOutAudio.Dispose();

                // Changes button text and update playing state
                Play1.Text = "▶";
                playing = false;
            }
        }
        private void Play_Click2(object sender, EventArgs e)
        {
            if (!playing2)
            {
                // Check if there is a WaveOut instance in use
                if (waveOutAudio2 != null)
                {
                    waveOutAudio2.Stop();
                    waveOutAudio2.Dispose();
                    waveOutAudio2 = null;
                }

                // Generates a WaveOut instance to play the audio file
                waveOutAudio2 = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada2 = CBOuts2.SelectedIndex;

                if (string.IsNullOrEmpty(fileRoute2))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Generates an AudioFileReade instance to read the audio file
                reader2 = new AudioFileReader(fileRoute2);



                // Connects the output device with the AudioFileReader instance
                waveOutAudio2.DeviceNumber = salidaSeleccionada2;
                waveOutAudio2.Init(reader2);

                // Restore saved position and volume
                reader2.Volume = volumen2;
                reader2.Position = pausePosition2;

                // Play audio file
                waveOutAudio2.Play();

                // Changes button text and update playing state
                Play2.Text = "⏸";
                playing2 = true;
            }
            else
            {
                // Stop play and free resources
                pausePosition2 = reader2.Position;
                volumen2 = reader2.Volume; // save current volume
                waveOutAudio2.Stop();
                waveOutAudio2.Dispose();

                // Changes button text and update playing state
                Play2.Text = "▶";
                playing2 = false;
            }
        }
        private void Play_Click3(object sender, EventArgs e)
        {
            if (!playing3)
            {
                // Check if there is a WaveOut instance in use
                if (waveOutAudio3 != null)
                {
                    waveOutAudio3.Stop();
                    waveOutAudio3.Dispose();
                    waveOutAudio3 = null;
                }

                // Generates a WaveOut instance to play the audio file
                waveOutAudio3 = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada3 = CBOuts3.SelectedIndex;

                if (string.IsNullOrEmpty(fileRoute3))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Generates an AudioFileReade instance to read the audio file
                reader3 = new AudioFileReader(fileRoute3);



                // Connects the output device with the AudioFileReader instance
                waveOutAudio3.DeviceNumber = salidaSeleccionada3;
                waveOutAudio3.Init(reader3);

                // Restore saved position and volume
                reader3.Volume = volumen3;
                reader3.Position = pausePosition3;

                // Play audio file
                waveOutAudio3.Play();

                // Changes button text and update playing state
                Play3.Text = "⏸";
                playing3 = true;
            }
            else
            {
                // Stop play and free resources
                pausePosition3 = reader3.Position;
                volumen3 = reader3.Volume; // save current volume
                waveOutAudio3.Stop();
                waveOutAudio3.Dispose();

                // Changes button text and update playing state
                Play3.Text = "▶";
                playing3 = false;
            }
        }
        private void Play_Click4(object sender, EventArgs e)
        {
            if (!playing4)
            {
                // Check if there is a WaveOut instance in use
                if (waveOutAudio4 != null)
                {
                    waveOutAudio4.Stop();
                    waveOutAudio4.Dispose();
                    waveOutAudio4 = null;
                }

                // Generates a WaveOut instance to play the audio file
                waveOutAudio4 = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada4 = CBOuts4.SelectedIndex;

                if (string.IsNullOrEmpty(fileRoute4))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Generates an AudioFileReade instance to read the audio file
                reader4 = new AudioFileReader(fileRoute4);



                // Connects the output device with the AudioFileReader instance
                waveOutAudio4.DeviceNumber = salidaSeleccionada4;
                waveOutAudio4.Init(reader4);

                // Restore saved position and volume
                reader4.Volume = volumen4;
                reader4.Position = pausePosition4;

                // Play audio file
                waveOutAudio4.Play();

                // Changes button text and update playing state
                Play4.Text = "⏸";
                playing4 = true;
            }
            else
            {
                // Stop play and free resources
                pausePosition4 = reader4.Position;
                volumen4 = reader4.Volume; // save current volume
                waveOutAudio4.Stop();
                waveOutAudio4.Dispose();

                // Changes button text and update playing state
                Play4.Text = "▶";
                playing4 = false;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (waveOutAudio != null)
            {
                pausePosition = 0;
                waveOutAudio.Stop();
                waveOutAudio.Dispose();
                waveOutAudio = null;
                playing = false;
                Play1.Text = "▶";
            }
            else
                return;
        }
        private void Stop_Click2(object sender, EventArgs e)
        {
            if (waveOutAudio2 != null)
            {
                pausePosition2 = 0;
                waveOutAudio2.Stop();
                waveOutAudio2.Dispose();
                waveOutAudio2 = null;
                playing2 = false;
                Play2.Text = "▶";
            }
            else
                return;
        }
        private void Stop_Click3(object sender, EventArgs e)
        {
            if (waveOutAudio3 != null)
            {
                pausePosition3 = 0;
                waveOutAudio3.Stop();
                waveOutAudio3.Dispose();
                waveOutAudio3 = null;
                playing3 = false;
                Play3.Text = "▶";
            }
            else
                return;
        }
        private void Stop_Click4(object sender, EventArgs e)
        {
            if (waveOutAudio4 != null)
            {
                pausePosition4 = 0;
                waveOutAudio4.Stop();
                waveOutAudio4.Dispose();
                waveOutAudio4 = null;
                playing4 = false;
                Play4.Text = "▶";
            }
            else
                return;
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            if (this.waveInDevice == null)
            {
                this.waveInDevice = new WaveInEvent();
                this.waveInDevice.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice.WaveFormat = waveFormatSelected;
                this.waveInDevice.StartRecording();

                // Generates a WaveOut instance to play the recorded audio
                waveOutMic = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada = CBOuts.SelectedIndex;

                // Connect the output device with the WaveInProvider instance
                waveOutMic.DeviceNumber = salidaSeleccionada;
                waveOutMic.Init(new WaveInProvider(waveInDevice));

                // Plays the recorded audio in real time
                waveOutMic.Volume = 0.8f;
                waveOutMic.Play();


                // Update UI
                Grabar1.Text = "Stop";
            }
            else
            {
                this.waveInDevice.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice.Dispose();
                waveInDevice = null;

                // Update UI
                Grabar1.Text = "Record";
            }
        }
        private void Grabar_Click2(object sender, EventArgs e)
        {
            if (this.waveInDevice2 == null)
            {
                this.waveInDevice2 = new WaveInEvent();
                this.waveInDevice2.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice2.WaveFormat = waveFormatSelected2;
                this.waveInDevice2.StartRecording();

                // Generates a WaveOut instance to play the recorded audio
                waveOutMic2 = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada2 = CBOuts2.SelectedIndex;

                // Connect the output device with the WaveInProvider instance
                waveOutMic2.DeviceNumber = salidaSeleccionada2;
                waveOutMic2.Init(new WaveInProvider(waveInDevice2));

                // Plays the recorded audio in real time
                waveOutMic2.Volume = 0.8f;
                waveOutMic2.Play();


                // Update UI
                Grabar2.Text = "Stop";
            }
            else
            {
                this.waveInDevice2.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice2.Dispose();
                waveInDevice2 = null;

                // Update UI
                Grabar2.Text = "Record";
            }
        }
        private void Grabar_Click3(object sender, EventArgs e)
        {
            if (this.waveInDevice3 == null)
            {
                this.waveInDevice3 = new WaveInEvent();
                this.waveInDevice3.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice3.WaveFormat = waveFormatSelected3;
                this.waveInDevice3.StartRecording();

                // Generates a WaveOut instance to play the recorded audio
                waveOutMic3 = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada3 = CBOuts3.SelectedIndex;

                // Connect the output device with the WaveInProvider instance
                waveOutMic3.DeviceNumber = salidaSeleccionada3;
                waveOutMic3.Init(new WaveInProvider(waveInDevice3));

                // Plays the recorded audio in real time
                waveOutMic3.Volume = 0.8f;
                waveOutMic3.Play();


                // Update UI
                Grabar3.Text = "Stop";
            }
            else
            {
                this.waveInDevice3.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice3.Dispose();
                waveInDevice3 = null;

                // Update UI
                Grabar3.Text = "Record";
            }
        }
        private void Grabar_Click4(object sender, EventArgs e)
        {
            if (this.waveInDevice4 == null)
            {
                this.waveInDevice4 = new WaveInEvent();
                this.waveInDevice4.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice4.WaveFormat = waveFormatSelected4;
                this.waveInDevice4.StartRecording();

                // Generates a WaveOut instance to play the recorded audio
                waveOutMic4 = new WaveOutEvent();

                // Gets the selected output device index
                int salidaSeleccionada4 = CBOuts4.SelectedIndex;

                // Connect the output device with the WaveInProvider instance
                waveOutMic4.DeviceNumber = salidaSeleccionada4;
                waveOutMic4.Init(new WaveInProvider(waveInDevice4));

                // Plays the recorded audio in real time
                waveOutMic4.Volume = 0.8f;
                waveOutMic4.Play();


                // Update UI
                Grabar4.Text = "Stop";
            }
            else
            {
                this.waveInDevice4.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice4.Dispose();
                waveInDevice4 = null;

                // Update UI
                Grabar4.Text = "Record";
            }
        }

        private void WaveInDevice_DataAvailable(object sender, WaveInEventArgs e)
        {

        }

        public void scrollVolumeAudio_Scroll(object sender, EventArgs e)
        {
            scrollVolumeAudio1.Tag = reader;
            int volumen = scrollVolumeAudio1.Value;
            labelAudio1.Text = "Audio\n   " + volumen.ToString();

            if (waveOutAudio != null)
            {
                reader.Volume = (float)volumen / 100f;
            }
        }
        private void scrollVolumeAudio2_Scroll(object sender, EventArgs e)
        {
            scrollVolumeAudio2.Tag = reader2;
            int volumen2 = scrollVolumeAudio2.Value;
            labelAudio2.Text = "Audio\n   " + volumen2.ToString();

            if (waveOutAudio2 != null)
            {
                reader2.Volume = (float)volumen2 / 100f;
            }
        }
        private void scrollVolumeAudio3_Scroll(object sender, EventArgs e)
        {
            scrollVolumeAudio3.Tag = reader3;
            int volumen3 = scrollVolumeAudio3.Value;
            labelAudio3.Text = "Audio\n   " + volumen3.ToString();

            if (waveOutAudio3 != null)
            {
                reader3.Volume = (float)volumen3 / 100f;
            }
        }
        private void scrollVolumeAudio4_Scroll(object sender, EventArgs e)
        {
            scrollVolumeAudio4.Tag = reader4;
            int volumen4 = scrollVolumeAudio4.Value;
            labelAudio4.Text = "Audio\n   " + volumen4.ToString();

            if (waveOutAudio4 != null)
            {
                reader4.Volume = (float)volumen4 / 100f;
            }
        }
        private void labelAudio_Click(object sender, EventArgs e)
        {

        }

        private void scrollVolumeMic_Scroll(object sender, EventArgs e)
        {
            scrollVolumeMic1.Tag = waveOutMic;
            int volumen3 = scrollVolumeMic1.Value;
            labelVoice1.Text = "Voice\n   " + volumen3.ToString();

            if (waveOutMic != null)
            {
                waveOutMic.Volume = (float)volumen3 / 100f;
            }
        }
        private void scrollVolumeMic2_Scroll(object sender, EventArgs e)
        {
            scrollVolumeMic2.Tag = waveOutMic2;
            int volumen4 = scrollVolumeMic2.Value;
            labelVoice2.Text = "Voice\n   " + volumen4.ToString();

            if (waveOutMic2 != null)
            {
                waveOutMic2.Volume = (float)volumen4 / 100f;
            }
        }
        private void scrollVolumeMic3_Scroll(object sender, EventArgs e)
        {
            scrollVolumeMic3.Tag = waveOutMic3;
            int volumen5 = scrollVolumeMic3.Value;
            labelVoice3.Text = "Voice\n   " + volumen5.ToString();

            if (waveOutMic3 != null)
            {
                waveOutMic3.Volume = (float)volumen5 / 100f;
            }
        }
        private void scrollVolumeMic4_Scroll(object sender, EventArgs e)
        {
            scrollVolumeMic4.Tag = waveOutMic4;
            int volumen6 = scrollVolumeMic4.Value;
            labelVoice4.Text = "Voice\n   " + volumen6.ToString();

            if (waveOutMic4 != null)
            {
                waveOutMic4.Volume = (float)volumen6 / 100f;
            }
        }

        private void RecordSettings1_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings1.PointToScreen(new Point(0, recordSettings1.Height));
            settings1.Show(punto);
        }
        private void qualityLow_Click(object sender, EventArgs e)
        {
            waveFormatSelected = new WaveFormat(11025, 8, 1);
        }
        private void qualityMedium_Click(object sender, EventArgs e)
        {
            waveFormatSelected = new WaveFormat(22050, 16, 1);
        }
        private void qualityHigh_Click(object sender, EventArgs e)
        {
            waveFormatSelected = new WaveFormat(44100, 16, 1);
        }
        private void qualityUltra_Click(object sender, EventArgs e)
        {
            waveFormatSelected = new WaveFormat(96000, 24, 1);
        }

        private void recordSettings2_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings2.PointToScreen(new Point(0, recordSettings2.Height));
            settings2.Show(punto);
        }
        private void qualityLow2_Click(object sender, EventArgs e)
        {
            waveFormatSelected2 = new WaveFormat(11025, 8, 1);
        }
        private void qualityMedium2_Click(object sender, EventArgs e)
        {
            waveFormatSelected2 = new WaveFormat(22050, 16, 1);
        }
        private void qualityHigh2_Click(object sender, EventArgs e)
        {
            waveFormatSelected2 = new WaveFormat(44100, 16, 1);
        }
        private void qualityUltra2_Click(object sender, EventArgs e)
        {
            waveFormatSelected2 = new WaveFormat(96000, 24, 1);
        }

        private void recordSettings3_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings3.PointToScreen(new Point(0, recordSettings3.Height));
            settings3.Show(punto);
        }
        private void qualityLow3_Click(object sender, EventArgs e)
        {
            waveFormatSelected3 = new WaveFormat(11025, 8, 1);
        }
        private void qualityMedium3_Click(object sender, EventArgs e)
        {
            waveFormatSelected3 = new WaveFormat(22050, 16, 1);
        }
        private void qualityHigh3_Click(object sender, EventArgs e)
        {
            waveFormatSelected3 = new WaveFormat(44100, 16, 1);
        }
        private void qualityUltra3_Click(object sender, EventArgs e)
        {
            waveFormatSelected3 = new WaveFormat(96000, 24, 1);
        }

        private void recordSettings4_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings4.PointToScreen(new Point(0, recordSettings4.Height));
            settings4.Show(punto);
        }
        private void qualityLow4_Click(object sender, EventArgs e)
        {
            waveFormatSelected4 = new WaveFormat(11025, 8, 1);
        }
        private void qualityMedium4_Click(object sender, EventArgs e)
        {
            waveFormatSelected4 = new WaveFormat(22050, 16, 1);
        }
        private void qualityHigh4_Click(object sender, EventArgs e)
        {
            waveFormatSelected4 = new WaveFormat(44100, 16, 1);
        }
        private void qualityUltra4_Click(object sender, EventArgs e)
        {
            waveFormatSelected4 = new WaveFormat(96000, 24, 1);
        }
    }

}