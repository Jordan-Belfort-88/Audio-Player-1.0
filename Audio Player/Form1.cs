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

        // Canal 2
        private WaveOutEvent waveOutAudio2;
        private WaveOutEvent waveOutMic2;
        private string rutaArchivo2;
        private WaveInEvent waveInDevice2;
        private bool reproduciendo2 = false;
        private long pausePosition2 = 0;
        private AudioFileReader reader2;
        private float volumen2 = 1f;


        public Form1()
        {
            InitializeComponent();
            LlenarComboBoxSalidas();
        }

        private void LlenarComboBoxSalidas()
        {
            // Obtener información sobre los dispositivos de salida de audio disponibles
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                WaveOutCapabilities capabilities = WaveOut.GetCapabilities(i);
                CBSalidas.Items.Add(capabilities.ProductName);
                CBSalidas2.Items.Add(capabilities.ProductName);
            }

        }

        private void CBSalidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBSalidas2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bloquear_CheckedChanged(object sender, EventArgs e)
        {
            if (Bloquear.Checked)
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
                    MessageBox.Show("Primero debe seleccionar un archivo de audio.");
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
                Play.Text = "⏸";
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
                Play.Text = "▶";
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
                    MessageBox.Show("Primero debe seleccionar un archivo de audio.");
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
        private void Stop_Click(object sender, EventArgs e)
        {
            pausePosition = 0;
            waveOutAudio.Stop();
            waveOutAudio.Dispose();
            waveOutAudio = null;
            reproduciendo = false;
            Play.Text = "▶";
        }
        private void Stop_Click2(object sender, EventArgs e)
        {
            pausePosition2 = 0;
            waveOutAudio2.Stop();
            waveOutAudio2.Dispose();
            waveOutAudio2 = null;
            reproduciendo2 = false;
            Play2.Text = "▶";
        }
        private void Grabar_Click(object sender, EventArgs e)
        {
            if (this.waveInDevice == null)
            {
                this.waveInDevice = new WaveInEvent();
                this.waveInDevice.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice.WaveFormat = new WaveFormat(44100, 16, 1);
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
                Grabar.Text = "Detener";
            }
            else
            {
                this.waveInDevice.StopRecording();

                // Detener la reproducción del audio grabado y liberar los recursos
                waveInDevice.Dispose();
                waveInDevice = null;

                // Actualizar la interfaz de usuario
                Grabar.Text = "Grabar";
            }
        }
        private void Grabar_Click2(object sender, EventArgs e)
        {
            if (this.waveInDevice2 == null)
            {
                this.waveInDevice2 = new WaveInEvent();
                this.waveInDevice2.DataAvailable += WaveInDevice_DataAvailable;
                this.waveInDevice2.WaveFormat = new WaveFormat(44100, 16, 1);
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
                Grabar2.Text = "Detener";
            }
            else
            {
                this.waveInDevice2.StopRecording();

                // Detener la reproducción del audio grabado y liberar los recursos
                waveInDevice2.Dispose();
                waveInDevice2 = null;

                // Actualizar la interfaz de usuario
                Grabar2.Text = "Grabar";
            }
        }

        private void WaveInDevice_DataAvailable(object sender, WaveInEventArgs e)
        {

        }

        public void BarraVolumenAudio_Scroll(object sender, EventArgs e)
        {
            BarraVolumenAudio.Tag = reader;
            int volumen = BarraVolumenAudio.Value;
            labelAudio.Text = "Audio\n   " + volumen.ToString();

            // Obtener la instancia de WaveOutEvent a través del parámetro Tag
            //WaveOutEvent waveOutDevice = (WaveOutEvent)BarraVolumenAudio.Tag;
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

            // Obtener la instancia de WaveOutEvent a través del parámetro Tag
            //WaveOutEvent waveOutDevice = (WaveOutEvent)BarraVolumenAudio.Tag;
            if (waveOutAudio2 != null)
            {
                reader2.Volume = (float)volumen2 / 100f;
            }
        }

        private void labelAudio_Click(object sender, EventArgs e)
        {

        }

        private void BarraVolumenMic_Scroll(object sender, EventArgs e)
        {
            BarraVolumenMic.Tag = waveOutMic;
            int volumen3 = BarraVolumenMic.Value;
            label2.Text = "Voice\n   " + volumen3.ToString();

            // Cambiar el volumen de la reproducción de audio con NAudio
            //WaveOutEvent waveOutDevice2 = (WaveOutEvent)BarraVolumenMic.Tag;
            if (waveOutMic != null)
            {
                waveOutMic.Volume = (float)volumen3 / 100f;
            }
        }
        private void BarraVolumenMic2_Scroll(object sender, EventArgs e)
        {
            BarraVolumenMic2.Tag = waveOutMic2;
            int volumen4 = BarraVolumenMic2.Value;
            label6.Text = "Voice\n   " + volumen4.ToString();

            // Cambiar el volumen de la reproducción de audio con NAudio
            //WaveOutEvent waveOutDevice2 = (WaveOutEvent)BarraVolumenMic.Tag;
            if (waveOutMic2 != null)
            {
                waveOutMic2.Volume = (float)volumen4 / 100f;
            }
        }
    }

}