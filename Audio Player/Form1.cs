using NAudio.Wave;

namespace Audio_Player
{


    public partial class Form1 : Form
    {
        // Canal 1
        private WaveOutEvent waveOutAudio;
        private WaveOutEvent waveOutMic;
        private string rutaArchivo;
        private WaveInEvent waveInDevice;
        private bool reproduciendo = false;
        private long pausePosition = 0;
        private AudioFileReader reader;
        private float volumen = 1f;
        private WaveFormat waveFormatSeleccionado;

        // Canal 2
        private WaveOutEvent waveOutAudio2;
        private WaveOutEvent waveOutMic2;
        private string rutaArchivo2;
        private WaveInEvent waveInDevice2;
        private bool reproduciendo2 = false;
        private long pausePosition2 = 0;
        private AudioFileReader reader2;
        private float volumen2 = 1f;
        private WaveFormat waveFormatSeleccionado2;

        // Canal 3
        private WaveOutEvent waveOutAudio3;
        private WaveOutEvent waveOutMic3;
        private string rutaArchivo3;
        private WaveInEvent waveInDevice3;
        private bool reproduciendo3 = false;
        private long pausePosition3 = 0;
        private AudioFileReader reader3;
        private float volumen3 = 1f;
        private WaveFormat waveFormatSeleccionado3;

        // Canal 4
        private WaveOutEvent waveOutAudio4;
        private WaveOutEvent waveOutMic4;
        private string rutaArchivo4;
        private WaveInEvent waveInDevice4;
        private bool reproduciendo4 = false;
        private long pausePosition4 = 0;
        private AudioFileReader reader4;
        private float volumen4 = 1f;
        private WaveFormat waveFormatSeleccionado4;

        public Form1()
        {
            InitializeComponent();
            LlenarComboBoxSalidas();

            // Establecer el valor por defecto
            waveFormatSeleccionado = new WaveFormat(22050, 16, 1);
            waveFormatSeleccionado2 = new WaveFormat(22050, 16, 1);
            waveFormatSeleccionado3 = new WaveFormat(22050, 16, 1);
            waveFormatSeleccionado4 = new WaveFormat(22050, 16, 1);
        }

        private void LlenarComboBoxSalidas()
        {
            // Obtener información sobre los dispositivos de salida de audio disponibles
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                WaveOutCapabilities capabilities = WaveOut.GetCapabilities(i);
                CBSalidas.Items.Add(capabilities.ProductName);
                CBSalidas2.Items.Add(capabilities.ProductName);
                CBSalidas3.Items.Add(capabilities.ProductName);
                CBSalidas4.Items.Add(capabilities.ProductName);
            }
        }

        private void CBSalidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBSalidas2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBSalidas3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBSalidas4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bloquear_CheckedChanged(object sender, EventArgs e)
        {
            if (Bloquear1.Checked)
            {
                CBSalidas.Enabled = false;
            }
            else
            {
                CBSalidas.Enabled = true;
            }
        }
        private void Bloquear2_CheckedChanged(object sender, EventArgs e)
        {
            if (Bloquear2.Checked)
            {
                CBSalidas2.Enabled = false;
            }
            else
            {
                CBSalidas2.Enabled = true;
            }
        }
        private void Bloquear3_CheckedChanged(object sender, EventArgs e)
        {
            if (Bloquear3.Checked)
            {
                CBSalidas3.Enabled = false;
            }
            else
            {
                CBSalidas3.Enabled = true;
            }
        }
        private void Bloquear4_CheckedChanged(object sender, EventArgs e)
        {
            if (Bloquear4.Checked)
            {
                CBSalidas4.Enabled = false;
            }
            else
            {
                CBSalidas4.Enabled = true;
            }
        }


        private void BotónSeleccionar_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo para seleccionar un archivo de audio
            if (AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo de audio seleccionado
                rutaArchivo = AbrirArchivo.FileName;

            }
        }
        private void BotónSeleccionar2_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo para seleccionar un archivo de audio
            if (AbrirArchivo2.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo de audio seleccionado
                rutaArchivo2 = AbrirArchivo2.FileName;

            }
        }
        private void BotónSeleccionar3_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo para seleccionar un archivo de audio
            if (AbrirArchivo3.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo de audio seleccionado
                rutaArchivo3 = AbrirArchivo3.FileName;

            }
        }
        private void BotónSeleccionar4_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo para seleccionar un archivo de audio
            if (AbrirArchivo4.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo de audio seleccionado
                rutaArchivo4 = AbrirArchivo4.FileName;

            }
        }

        private void Play_Click_1(object sender, EventArgs e)
        {
            if (!reproduciendo)
            {
                // Verificar si ya hay una instancia de WaveOut en uso
                if (waveOutAudio != null)
                {
                    waveOutAudio.Stop();
                    waveOutAudio.Dispose();
                    waveOutAudio = null;
                }

                // Crear una instancia de WaveOut para reproducir el archivo de audio
                waveOutAudio = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada = CBSalidas.SelectedIndex;

                if (string.IsNullOrEmpty(rutaArchivo))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Crear una instancia de AudioFileReader para leer el archivo de audio
                reader = new AudioFileReader(rutaArchivo);



                // Conectar el dispositivo de salida con la instancia de AudioFileReader
                waveOutAudio.DeviceNumber = salidaSeleccionada;
                waveOutAudio.Init(reader);

                // Restaurar la posición y el volumen guardados
                reader.Volume = volumen;
                reader.Position = pausePosition;

                // Reproducir el archivo de audio
                waveOutAudio.Play();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play1.Text = "⏸";
                reproduciendo = true;
            }
            else
            {
                // Detener reproducción y liberar recursos
                pausePosition = reader.Position;
                volumen = reader.Volume; // guardar el volumen actual
                waveOutAudio.Stop();
                waveOutAudio.Dispose();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play1.Text = "▶";
                reproduciendo = false;
            }
        }
        private void Play_Click2(object sender, EventArgs e)
        {
            if (!reproduciendo2)
            {
                // Verificar si ya hay una instancia de WaveOut en uso
                if (waveOutAudio2 != null)
                {
                    waveOutAudio2.Stop();
                    waveOutAudio2.Dispose();
                    waveOutAudio2 = null;
                }

                // Crear una instancia de WaveOut para reproducir el archivo de audio
                waveOutAudio2 = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada2 = CBSalidas2.SelectedIndex;

                if (string.IsNullOrEmpty(rutaArchivo2))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Crear una instancia de AudioFileReader para leer el archivo de audio
                reader2 = new AudioFileReader(rutaArchivo2);



                // Conectar el dispositivo de salida con la instancia de AudioFileReader
                waveOutAudio2.DeviceNumber = salidaSeleccionada2;
                waveOutAudio2.Init(reader2);

                // Restaurar la posición y el volumen guardados
                reader2.Volume = volumen2;
                reader2.Position = pausePosition2;

                // Reproducir el archivo de audio
                waveOutAudio2.Play();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play2.Text = "⏸";
                reproduciendo2 = true;
            }
            else
            {
                // Detener reproducción y liberar recursos
                pausePosition2 = reader2.Position;
                volumen2 = reader2.Volume; // guardar el volumen actual
                waveOutAudio2.Stop();
                waveOutAudio2.Dispose();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play2.Text = "▶";
                reproduciendo2 = false;
            }
        }
        private void Play_Click3(object sender, EventArgs e)
        {
            if (!reproduciendo3)
            {
                // Verificar si ya hay una instancia de WaveOut en uso
                if (waveOutAudio3 != null)
                {
                    waveOutAudio3.Stop();
                    waveOutAudio3.Dispose();
                    waveOutAudio3 = null;
                }

                // Crear una instancia de WaveOut para reproducir el archivo de audio
                waveOutAudio3 = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada3 = CBSalidas3.SelectedIndex;

                if (string.IsNullOrEmpty(rutaArchivo3))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Crear una instancia de AudioFileReader para leer el archivo de audio
                reader3 = new AudioFileReader(rutaArchivo3);



                // Conectar el dispositivo de salida con la instancia de AudioFileReader
                waveOutAudio3.DeviceNumber = salidaSeleccionada3;
                waveOutAudio3.Init(reader3);

                // Restaurar la posición y el volumen guardados
                reader3.Volume = volumen3;
                reader3.Position = pausePosition3;

                // Reproducir el archivo de audio
                waveOutAudio3.Play();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play3.Text = "⏸";
                reproduciendo3 = true;
            }
            else
            {
                // Detener reproducción y liberar recursos
                pausePosition3 = reader3.Position;
                volumen3 = reader3.Volume; // guardar el volumen actual
                waveOutAudio3.Stop();
                waveOutAudio3.Dispose();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play3.Text = "▶";
                reproduciendo3 = false;
            }
        }
        private void Play_Click4(object sender, EventArgs e)
        {
            if (!reproduciendo4)
            {
                // Verificar si ya hay una instancia de WaveOut en uso
                if (waveOutAudio4 != null)
                {
                    waveOutAudio4.Stop();
                    waveOutAudio4.Dispose();
                    waveOutAudio4 = null;
                }

                // Crear una instancia de WaveOut para reproducir el archivo de audio
                waveOutAudio4 = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada4 = CBSalidas4.SelectedIndex;

                if (string.IsNullOrEmpty(rutaArchivo4))
                {
                    MessageBox.Show("Please select an audio file.");
                    return;
                }


                // Crear una instancia de AudioFileReader para leer el archivo de audio
                reader4 = new AudioFileReader(rutaArchivo4);



                // Conectar el dispositivo de salida con la instancia de AudioFileReader
                waveOutAudio4.DeviceNumber = salidaSeleccionada4;
                waveOutAudio4.Init(reader4);

                // Restaurar la posición y el volumen guardados
                reader4.Volume = volumen4;
                reader4.Position = pausePosition4;

                // Reproducir el archivo de audio
                waveOutAudio4.Play();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play4.Text = "⏸";
                reproduciendo4 = true;
            }
            else
            {
                // Detener reproducción y liberar recursos
                pausePosition4 = reader4.Position;
                volumen4 = reader4.Volume; // guardar el volumen actual
                waveOutAudio4.Stop();
                waveOutAudio4.Dispose();

                // Cambiar texto del botón y actualizar estado de reproducción
                Play4.Text = "▶";
                reproduciendo4 = false;
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
                reproduciendo = false;
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
                reproduciendo2 = false;
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
                reproduciendo3 = false;
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
                reproduciendo4 = false;
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
                this.waveInDevice.WaveFormat = waveFormatSeleccionado;
                this.waveInDevice.StartRecording();

                // Crear una instancia de WaveOut para reproducir el audio grabado
                waveOutMic = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada = CBSalidas.SelectedIndex;

                // Conectar el dispositivo de salida con la instancia de WaveInProvider
                waveOutMic.DeviceNumber = salidaSeleccionada;
                waveOutMic.Init(new WaveInProvider(waveInDevice));

                // Reproducir el audio grabado en tiempo real
                waveOutMic.Volume = 0.8f;
                waveOutMic.Play();


                // Actualizar la interfaz de usuario
                Grabar1.Text = "Stop";
            }
            else
            {
                this.waveInDevice.StopRecording();

                // Detener la reproducción del audio grabado y liberar los recursos
                waveInDevice.Dispose();
                waveInDevice = null;

                // Actualizar la interfaz de usuario
                Grabar1.Text = "Record";
            }
        }
        private void Grabar_Click2(object sender, EventArgs e)
        {
            if (this.waveInDevice2 == null)
            {
                this.waveInDevice2 = new WaveInEvent();
                this.waveInDevice2.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice2.WaveFormat = waveFormatSeleccionado2;
                this.waveInDevice2.StartRecording();

                // Crear una instancia de WaveOut para reproducir el audio grabado
                waveOutMic2 = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada2 = CBSalidas2.SelectedIndex;

                // Conectar el dispositivo de salida con la instancia de WaveInProvider
                waveOutMic2.DeviceNumber = salidaSeleccionada2;
                waveOutMic2.Init(new WaveInProvider(waveInDevice2));

                // Reproducir el audio grabado en tiempo real
                waveOutMic2.Volume = 0.8f;
                waveOutMic2.Play();


                // Actualizar la interfaz de usuario
                Grabar2.Text = "Stop";
            }
            else
            {
                this.waveInDevice2.StopRecording();

                // Detener la reproducción del audio grabado y liberar los recursos
                waveInDevice2.Dispose();
                waveInDevice2 = null;

                // Actualizar la interfaz de usuario
                Grabar2.Text = "Record";
            }
        }
        private void Grabar_Click3(object sender, EventArgs e)
        {
            if (this.waveInDevice3 == null)
            {
                this.waveInDevice3 = new WaveInEvent();
                this.waveInDevice3.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice3.WaveFormat = waveFormatSeleccionado3;
                this.waveInDevice3.StartRecording();

                // Crear una instancia de WaveOut para reproducir el audio grabado
                waveOutMic3 = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada3 = CBSalidas3.SelectedIndex;

                // Conectar el dispositivo de salida con la instancia de WaveInProvider
                waveOutMic3.DeviceNumber = salidaSeleccionada3;
                waveOutMic3.Init(new WaveInProvider(waveInDevice3));

                // Reproducir el audio grabado en tiempo real
                waveOutMic3.Volume = 0.8f;
                waveOutMic3.Play();


                // Actualizar la interfaz de usuario
                Grabar3.Text = "Stop";
            }
            else
            {
                this.waveInDevice3.StopRecording();

                // Detener la reproducción del audio grabado y liberar los recursos
                waveInDevice3.Dispose();
                waveInDevice3 = null;

                // Actualizar la interfaz de usuario
                Grabar3.Text = "Record";
            }
        }
        private void Grabar_Click4(object sender, EventArgs e)
        {
            if (this.waveInDevice4 == null)
            {
                this.waveInDevice4 = new WaveInEvent();
                this.waveInDevice4.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice4.WaveFormat = waveFormatSeleccionado4;
                this.waveInDevice4.StartRecording();

                // Crear una instancia de WaveOut para reproducir el audio grabado
                waveOutMic4 = new WaveOutEvent();

                // Obtener el índice del dispositivo de salida seleccionado
                int salidaSeleccionada4 = CBSalidas4.SelectedIndex;

                // Conectar el dispositivo de salida con la instancia de WaveInProvider
                waveOutMic4.DeviceNumber = salidaSeleccionada4;
                waveOutMic4.Init(new WaveInProvider(waveInDevice4));

                // Reproducir el audio grabado en tiempo real
                waveOutMic4.Volume = 0.8f;
                waveOutMic4.Play();


                // Actualizar la interfaz de usuario
                Grabar4.Text = "Stop";
            }
            else
            {
                this.waveInDevice4.StopRecording();

                // Detener la reproducción del audio grabado y liberar los recursos
                waveInDevice4.Dispose();
                waveInDevice4 = null;

                // Actualizar la interfaz de usuario
                Grabar4.Text = "Record";
            }
        }

        private void WaveInDevice_DataAvailable(object sender, WaveInEventArgs e)
        {

        }

        public void BarraVolumenAudio_Scroll(object sender, EventArgs e)
        {
            BarraVolumenAudio1.Tag = reader;
            int volumen = BarraVolumenAudio1.Value;
            labelAudio1.Text = "Audio\n   " + volumen.ToString();

            if (waveOutAudio != null)
            {
                reader.Volume = (float)volumen / 100f;
            }
        }
        private void BarraVolumenAudio2_Scroll(object sender, EventArgs e)
        {
            BarraVolumenAudio2.Tag = reader2;
            int volumen2 = BarraVolumenAudio2.Value;
            labelAudio2.Text = "Audio\n   " + volumen2.ToString();

            if (waveOutAudio2 != null)
            {
                reader2.Volume = (float)volumen2 / 100f;
            }
        }
        private void BarraVolumenAudio3_Scroll(object sender, EventArgs e)
        {
            BarraVolumenAudio3.Tag = reader3;
            int volumen3 = BarraVolumenAudio3.Value;
            labelAudio3.Text = "Audio\n   " + volumen3.ToString();

            if (waveOutAudio3 != null)
            {
                reader3.Volume = (float)volumen3 / 100f;
            }
        }
        private void BarraVolumenAudio4_Scroll(object sender, EventArgs e)
        {
            BarraVolumenAudio4.Tag = reader4;
            int volumen4 = BarraVolumenAudio4.Value;
            labelAudio4.Text = "Audio\n   " + volumen4.ToString();

            if (waveOutAudio4 != null)
            {
                reader4.Volume = (float)volumen4 / 100f;
            }
        }
        private void labelAudio_Click(object sender, EventArgs e)
        {

        }

        private void BarraVolumenMic_Scroll(object sender, EventArgs e)
        {
            BarraVolumenMic1.Tag = waveOutMic;
            int volumen3 = BarraVolumenMic1.Value;
            labelVoice1.Text = "Voice\n   " + volumen3.ToString();

            if (waveOutMic != null)
            {
                waveOutMic.Volume = (float)volumen3 / 100f;
            }
        }
        private void BarraVolumenMic2_Scroll(object sender, EventArgs e)
        {
            BarraVolumenMic2.Tag = waveOutMic2;
            int volumen4 = BarraVolumenMic2.Value;
            labelVoice2.Text = "Voice\n   " + volumen4.ToString();

            if (waveOutMic2 != null)
            {
                waveOutMic2.Volume = (float)volumen4 / 100f;
            }
        }
        private void BarraVolumenMic3_Scroll(object sender, EventArgs e)
        {
            BarraVolumenMic3.Tag = waveOutMic3;
            int volumen5 = BarraVolumenMic3.Value;
            labelVoice3.Text = "Voice\n   " + volumen5.ToString();

            if (waveOutMic3 != null)
            {
                waveOutMic3.Volume = (float)volumen5 / 100f;
            }
        }
        private void BarraVolumenMic4_Scroll(object sender, EventArgs e)
        {
            BarraVolumenMic4.Tag = waveOutMic4;
            int volumen6 = BarraVolumenMic4.Value;
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
        private void calidadBaja_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado = new WaveFormat(11025, 8, 1);
        }
        private void calidadMedia_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado = new WaveFormat(22050, 16, 1);
        }
        private void calidadAlta_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado = new WaveFormat(44100, 16, 1);
        }
        private void calidadUltra_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado = new WaveFormat(96000, 24, 1);
        }

        private void recordSettings2_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings2.PointToScreen(new Point(0, recordSettings2.Height));
            settings2.Show(punto);
        }
        private void calidadBaja2_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado2 = new WaveFormat(11025, 8, 1);
        }
        private void calidadMedia2_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado2 = new WaveFormat(22050, 16, 1);
        }
        private void calidadAlta2_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado2 = new WaveFormat(44100, 16, 1);
        }
        private void calidadUltra2_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado2 = new WaveFormat(96000, 24, 1);
        }

        private void recordSettings3_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings3.PointToScreen(new Point(0, recordSettings3.Height));
            settings3.Show(punto);
        }
        private void calidadBaja3_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado3 = new WaveFormat(11025, 8, 1);
        }
        private void calidadMedia3_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado3 = new WaveFormat(22050, 16, 1);
        }
        private void calidadAlta3_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado3 = new WaveFormat(44100, 16, 1);
        }
        private void calidadUltra3_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado3 = new WaveFormat(96000, 24, 1);
        }

        private void recordSettings4_Click(object sender, EventArgs e)
        {
            Point punto = recordSettings4.PointToScreen(new Point(0, recordSettings4.Height));
            settings4.Show(punto);
        }
        private void calidadBaja4_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado4 = new WaveFormat(11025, 8, 1);
        }
        private void calidadMedia4_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado4 = new WaveFormat(22050, 16, 1);
        }
        private void calidadAlta4_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado4 = new WaveFormat(44100, 16, 1);
        }
        private void calidadUltra4_Click(object sender, EventArgs e)
        {
            waveFormatSeleccionado4 = new WaveFormat(96000, 24, 1);
        }
    }

}