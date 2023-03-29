using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Siticone.Desktop.UI.WinForms;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        private int volumeMic1;
        private float currentAmplitude1 = 0.0f;
        private VolumeMeter volumenMeterMic1;
        private TimeSpan currentTime;

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
        private int volumeMic2;
        private VolumeMeter volumenMeterMic2;
        private float currentAmplitude2 = 0.0f;

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
        private int volumeMic3;
        private VolumeMeter volumenMeterMic3;
        private float currentAmplitude3 = 0.0f;

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
        private int volumeMic4;
        private VolumeMeter volumenMeterMic4;
        private float currentAmplitude4 = 0.0f;

        public Form1()
        {
            InitializeComponent();
            FillComboBoxOuts();

            // Set default value
            waveFormatSelected = new WaveFormat(22050, 16, 1);
            waveFormatSelected2 = new WaveFormat(22050, 16, 1);
            waveFormatSelected3 = new WaveFormat(22050, 16, 1);
            waveFormatSelected4 = new WaveFormat(22050, 16, 1);

            volumenMeterMic1 = new VolumeMeter();
            volumenMeterMic2 = new VolumeMeter();
            volumenMeterMic3 = new VolumeMeter();
            volumenMeterMic4 = new VolumeMeter();
        }

        private void FillComboBoxOuts()
        {
            // Get avaible devices information
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                WaveOutCapabilities capabilities = WaveOut.GetCapabilities(i);
                CBOuts1.Items.Add(capabilities.ProductName);
                CBOuts2.Items.Add(capabilities.ProductName);
                CBOuts3.Items.Add(capabilities.ProductName);
                CBOuts4.Items.Add(capabilities.ProductName);
            }
        }

        private void CBOuts1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBOuts2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBOuts3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBOuts4_OnSelectedIndexChanged(object sender, EventArgs e)
        {

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
                int salidaSeleccionada = CBOuts1.SelectedIndex;

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

                // Create a MeteringSampleProvider and add it to the audio chain
                MeteringSampleProvider meteringProvider = new MeteringSampleProvider(reader);
                AttachVolumeMeter(meteringProvider, volumeMeter1);
                waveOutAudio.Init(meteringProvider);


                // Restore saved position and volume
                reader.Volume = volumen;
                reader.Position = pausePosition;

                // Set up event handlers
                string totalTimeString = TimeSpan.FromSeconds(reader.TotalTime.TotalSeconds).ToString(@"mm\:ss");
                labelTT1.Text = totalTimeString;

                // Suscribe al evento Tick del temporizador
                timer1.Tick += timer1_Tick_1;

                // Inicia el temporizador
                timer1.Start();

                // Play audio file
                waveOutAudio.Play();

                // Changes button text and update playing state
                Play1.IconChar = FontAwesome.Sharp.IconChar.Pause;
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
                volumeMeter1.Amplitude = 0f;
                Play1.IconChar = FontAwesome.Sharp.IconChar.Play;
                playing = false;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (reader != null)
            {
                labelCT1.Text = reader.CurrentTime.ToString(@"mm\:ss");
            }
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (reader2 != null)
            {
                labelCT2.Text = reader2.CurrentTime.ToString(@"mm\:ss");
            }
        }
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (reader3 != null)
            {
                labelCT3.Text = reader3.CurrentTime.ToString(@"mm\:ss");
            }
        }
        private void timer4_Tick_1(object sender, EventArgs e)
        {
            if (reader4 != null)
            {
                labelCT4.Text = reader4.CurrentTime.ToString(@"mm\:ss");
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

                MeteringSampleProvider meteringProvider2 = new MeteringSampleProvider(reader2);
                AttachVolumeMeter(meteringProvider2, volumeMeter2);
                waveOutAudio2.Init(meteringProvider2);

                // Restore saved position and volume
                reader2.Volume = volumen2;
                reader2.Position = pausePosition2;

                // Set up event handlers
                string totalTimeString2 = TimeSpan.FromSeconds(reader2.TotalTime.TotalSeconds).ToString(@"mm\:ss");
                labelTT2.Text = totalTimeString2;

                // Suscribe al evento Tick del temporizador
                timer2.Tick += timer2_Tick_1;

                // Inicia el temporizador
                timer2.Start();

                // Play audio file
                waveOutAudio2.Play();

                // Changes button text and update playing state
                Play2.IconChar = FontAwesome.Sharp.IconChar.Pause;
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
                volumeMeter2.Amplitude = 0f;
                Play2.IconChar = FontAwesome.Sharp.IconChar.Play;
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

                MeteringSampleProvider meteringProvider3 = new MeteringSampleProvider(reader3);
                AttachVolumeMeter(meteringProvider3, volumeMeter3);
                waveOutAudio3.Init(meteringProvider3);

                // Restore saved position and volume
                reader3.Volume = volumen3;
                reader3.Position = pausePosition3;

                // Set up event handlers
                string totalTimeString3 = TimeSpan.FromSeconds(reader3.TotalTime.TotalSeconds).ToString(@"mm\:ss");
                labelTT3.Text = totalTimeString3;

                // Suscribe al evento Tick del temporizador
                timer3.Tick += timer3_Tick_1;

                // Inicia el temporizador
                timer3.Start();

                // Play audio file
                waveOutAudio3.Play();

                // Changes button text and update playing state
                volumeMeter3.Amplitude = 0f;
                Play3.IconChar = FontAwesome.Sharp.IconChar.Pause;
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
                Play3.IconChar = FontAwesome.Sharp.IconChar.Play;
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

                MeteringSampleProvider meteringProvider4 = new MeteringSampleProvider(reader4);
                AttachVolumeMeter(meteringProvider4, volumeMeter4);
                waveOutAudio4.Init(meteringProvider4);

                // Restore saved position and volume
                reader4.Volume = volumen4;
                reader4.Position = pausePosition4;

                // Set up event handlers
                string totalTimeString4 = TimeSpan.FromSeconds(reader4.TotalTime.TotalSeconds).ToString(@"mm\:ss");
                labelTT4.Text = totalTimeString4;

                // Suscribe al evento Tick del temporizador
                timer4.Tick += timer4_Tick_1;

                // Inicia el temporizador
                timer4.Start();

                // Play audio file
                waveOutAudio4.Play();

                // Changes button text and update playing state
                Play4.IconChar = FontAwesome.Sharp.IconChar.Pause;
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
                volumeMeter4.Amplitude = 0f;
                Play4.IconChar = FontAwesome.Sharp.IconChar.Play;
                playing4 = false;
            }
        }
        private void AttachVolumeMeter(MeteringSampleProvider meteringProvider, VolumeMeter volumeMeter)
        {
            // Subscribe to the StreamVolume event of the MeteringSampleProvider
            meteringProvider.StreamVolume += (sender, e) =>
            {
                // Get the maximum sample value in the stream
                float max = e.MaxSampleValues[0];

                for (int i = 1; i < e.MaxSampleValues.Length; i++)
                {
                    if (e.MaxSampleValues[i] > max)
                        max = e.MaxSampleValues[i];
                }

                // Normalize the maximum value to the desired range
                float normalizedVolume = Math.Min(8, max / 0.1f);

                // Update the volume meter
                volumeMeter.Amplitude = normalizedVolume;
            };
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (waveOutAudio != null)
            {
                pausePosition = 0;
                waveOutAudio.Stop();
                waveOutAudio.Dispose();
                waveOutAudio = null;
                volumeMeter1.Amplitude = 0f;
                playing = false;
                Play1.IconChar = FontAwesome.Sharp.IconChar.Play;
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
                volumeMeter2.Amplitude = 0f;
                playing2 = false;
                Play2.IconChar = FontAwesome.Sharp.IconChar.Play;
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
                volumeMeter3.Amplitude = 0f;
                playing3 = false;
                Play3.IconChar = FontAwesome.Sharp.IconChar.Play;
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
                volumeMeter4.Amplitude = 0f;
                playing4 = false;
                Play4.IconChar = FontAwesome.Sharp.IconChar.Play;
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
                int salidaSeleccionada = CBOuts1.SelectedIndex;

                // Connect the output device with the WaveInProvider instance
                waveOutMic.DeviceNumber = salidaSeleccionada;
                waveOutMic.Init(new WaveInProvider(waveInDevice));

                // Plays the recorded audio in real time
                waveOutMic.Volume = 0.8f;
                waveOutMic.Play();

                // Update UI
                Grabar1.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            }
            else
            {
                this.waveInDevice.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice.Dispose();
                waveInDevice = null;

                // Update UI
                Grabar1.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            }
        }
        private void Grabar_Click2(object sender, EventArgs e)
        {
            if (this.waveInDevice2 == null)
            {
                this.waveInDevice2 = new WaveInEvent();
                this.waveInDevice2.DataAvailable += WaveInDevice2_DataAvailable;
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
              //  Grabar2.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            }
            else
            {
                this.waveInDevice2.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice2.Dispose();
                waveInDevice2 = null;

                // Update UI
               // Grabar2.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            }
        }
        private void Grabar_Click3(object sender, EventArgs e)
        {
            if (this.waveInDevice3 == null)
            {
                this.waveInDevice3 = new WaveInEvent();
                this.waveInDevice3.DataAvailable += WaveInDevice3_DataAvailable;
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
                Grabar1.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            }
            else
            {
                this.waveInDevice3.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice3.Dispose();
                waveInDevice3 = null;

                // Update UI
                Grabar3.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            }
        }
        private void Grabar_Click4(object sender, EventArgs e)
        {
            if (this.waveInDevice4 == null)
            {
                this.waveInDevice4 = new WaveInEvent();
                this.waveInDevice4.DataAvailable += WaveInDevice4_DataAvailable;
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
                Grabar3.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            }
            else
            {
                this.waveInDevice4.StopRecording();

                // Stops playing the recorded audio and free resources
                waveInDevice4.Dispose();
                waveInDevice4 = null;

                // Update UI
                Grabar3.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            }
        }

        private void WaveInDevice_DataAvailable(object sender, WaveInEventArgs e)
        {
            float max = 0;
            // Iterate through each sample and find the maximum amplitude
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = BitConverter.ToInt16(e.Buffer, i);
                float sample32 = sample / 32768f;
                if (sample32 < 0) sample32 = -sample32;
                if (sample32 > max) max = sample32;
            }
            currentAmplitude1 = max;

            volumeMeterMic1.Amplitude = currentAmplitude1;
        }
        private void WaveInDevice2_DataAvailable(object sender, WaveInEventArgs e)
        {
            float max = 0;
            // Iterate through each sample and find the maximum amplitude
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = BitConverter.ToInt16(e.Buffer, i);
                float sample32 = sample / 32768f;
                if (sample32 < 0) sample32 = -sample32;
                if (sample32 > max) max = sample32;
            }
            currentAmplitude2 = max;

            volumeMeterMic2.Amplitude = currentAmplitude2;
        }
        private void WaveInDevice3_DataAvailable(object sender, WaveInEventArgs e)
        {
            float max = 0;
            // Iterate through each sample and find the maximum amplitude
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = BitConverter.ToInt16(e.Buffer, i);
                float sample32 = sample / 32768f;
                if (sample32 < 0) sample32 = -sample32;
                if (sample32 > max) max = sample32;
            }
            currentAmplitude3 = max;

            volumeMeterMic3.Amplitude = currentAmplitude3;
        }
        private void WaveInDevice4_DataAvailable(object sender, WaveInEventArgs e)
        {
            float max = 0;
            // Iterate through each sample and find the maximum amplitude
            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = BitConverter.ToInt16(e.Buffer, i);
                float sample32 = sample / 32768f;
                if (sample32 < 0) sample32 = -sample32;
                if (sample32 > max) max = sample32;
            }
            currentAmplitude4 = max;

            volumeMeterMic4.Amplitude = currentAmplitude4;
        }

        // Audio scroll
        private void ScrollVolumeAudio_Scroll(object sender, EventArgs e) => VolumeAudioFunction(scrollVolumeAudio1, volumen, reader, labelAudio1);
        private void ScrollVolumeAudio2_Scroll(object sender, EventArgs e) => VolumeAudioFunction(scrollVolumeAudio2, volumen2, reader2, labelAudio2);
        private void scrollVolumeAudio3_Scroll(object sender, EventArgs e) => VolumeAudioFunction(scrollVolumeAudio3, volumen3, reader3, labelAudio3);
        private void scrollVolumeAudio4_Scroll(object sender, EventArgs e) => VolumeAudioFunction(scrollVolumeAudio4, volumen4, reader4, labelAudio4);
        private void VolumeAudioFunction(SiticoneTrackBar scroll, float volume, AudioFileReader reader, Label labelAudio)
        {
            scroll.Tag = reader;
            volume = scroll.Value;

            if (scroll.Value >= 65)
            {
                labelAudio.Text = "🔊";
            }

            else if (scroll.Value > 0 && scroll.Value < 65)
            {
                labelAudio.Text = "🔉";
            }

            else if (scroll.Value == 0)
            {
                labelAudio.Text = "🔈";
            }

            if (reader != null)
            {
                reader.Volume = volume / 100f;
            }
        }

        // Mic scroll
        private void scrollVolumeMic_Scroll(object sender, EventArgs e) => VolumeMicFunction(scrollVolumeMic1, volumeMic1, waveOutMic);
        private void scrollVolumeMic2_Scroll(object sender, EventArgs e) => VolumeMicFunction(scrollVolumeMic2, volumeMic2, waveOutMic2);
        private void scrollVolumeMic3_Scroll(object sender, EventArgs e) => VolumeMicFunction(scrollVolumeMic3, volumeMic3, waveOutMic3);
        private void scrollVolumeMic4_Scroll(object sender, EventArgs e) => VolumeMicFunction(scrollVolumeMic4, volumeMic4, waveOutMic4);
        private void VolumeMicFunction(SiticoneTrackBar scroll, int volume, WaveOutEvent waveOutMic)
        {
            scroll.Tag = waveOutMic;
            volume = scroll.Value;

            if (waveOutMic != null)
            {
                waveOutMic.Volume = (float)volume / 100f;
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void siticoneContainerControl5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}