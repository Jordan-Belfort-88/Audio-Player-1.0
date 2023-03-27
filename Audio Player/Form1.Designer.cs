namespace Audio_Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CBSalidas = new ComboBox();
            AbrirArchivo = new OpenFileDialog();
            BotónSeleccionar1 = new Button();
            BarraVolumenAudio1 = new TrackBar();
            labelAudio1 = new Label();
            Grabar1 = new Button();
            labelVoice1 = new Label();
            BarraVolumenMic1 = new TrackBar();
            labelSeleccionar1 = new Label();
            Bloquear1 = new CheckBox();
            Stop1 = new Button();
            Play1 = new Button();
            NombreCanal = new Label();
            NombreCanal2 = new Label();
            labelSeleccionar2 = new Label();
            CBSalidas2 = new ComboBox();
            BotónSeleccionar2 = new Button();
            Play2 = new Button();
            Stop2 = new Button();
            Grabar2 = new Button();
            Bloquear2 = new CheckBox();
            BarraVolumenAudio2 = new TrackBar();
            BarraVolumenMic2 = new TrackBar();
            labelAudio2 = new Label();
            labelVoice2 = new Label();
            AbrirArchivo2 = new OpenFileDialog();
            NombreCanal3 = new Label();
            labelSeleccionar3 = new Label();
            CBSalidas3 = new ComboBox();
            Bloquear3 = new CheckBox();
            BotónSeleccionar3 = new Button();
            Play3 = new Button();
            Stop3 = new Button();
            Grabar3 = new Button();
            BarraVolumenAudio3 = new TrackBar();
            BarraVolumenMic3 = new TrackBar();
            labelAudio3 = new Label();
            labelVoice3 = new Label();
            NombreCanal4 = new Label();
            labelSeleccionar4 = new Label();
            CBSalidas4 = new ComboBox();
            BotónSeleccionar4 = new Button();
            Play4 = new Button();
            Stop4 = new Button();
            Grabar4 = new Button();
            Bloquear4 = new CheckBox();
            BarraVolumenAudio4 = new TrackBar();
            BarraVolumenMic4 = new TrackBar();
            labelAudio4 = new Label();
            labelVoice4 = new Label();
            AbrirArchivo3 = new OpenFileDialog();
            AbrirArchivo4 = new OpenFileDialog();
            recordSettings1 = new Button();
            settings1 = new ContextMenuStrip(components);
            calidadBaja = new ToolStripMenuItem();
            calidadMedia = new ToolStripMenuItem();
            calidadAlta = new ToolStripMenuItem();
            calidadUltra = new ToolStripMenuItem();
            recordSettings2 = new Button();
            settings2 = new ContextMenuStrip(components);
            calidadBaja2 = new ToolStripMenuItem();
            calidadMedia2 = new ToolStripMenuItem();
            calidadAlta2 = new ToolStripMenuItem();
            calidadUltra2 = new ToolStripMenuItem();
            recordSettings3 = new Button();
            settings3 = new ContextMenuStrip(components);
            calidadBaja3 = new ToolStripMenuItem();
            calidadMedia3 = new ToolStripMenuItem();
            calidadAlta3 = new ToolStripMenuItem();
            calidadUltra3 = new ToolStripMenuItem();
            recordSettings4 = new Button();
            settings4 = new ContextMenuStrip(components);
            calidadBaja4 = new ToolStripMenuItem();
            calidadMedia4 = new ToolStripMenuItem();
            calidadAlta4 = new ToolStripMenuItem();
            calidadUltra4 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic4).BeginInit();
            settings1.SuspendLayout();
            settings2.SuspendLayout();
            settings3.SuspendLayout();
            settings4.SuspendLayout();
            SuspendLayout();
            // 
            // CBSalidas
            // 
            CBSalidas.BackColor = SystemColors.WindowFrame;
            CBSalidas.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSalidas.DropDownWidth = 266;
            CBSalidas.ForeColor = SystemColors.MenuText;
            CBSalidas.FormattingEnabled = true;
            CBSalidas.Location = new Point(12, 83);
            CBSalidas.Name = "CBSalidas";
            CBSalidas.Size = new Size(266, 33);
            CBSalidas.TabIndex = 1;
            CBSalidas.SelectedIndexChanged += CBSalidas_SelectedIndexChanged;
            // 
            // AbrirArchivo
            // 
            AbrirArchivo.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // BotónSeleccionar1
            // 
            BotónSeleccionar1.BackColor = Color.DimGray;
            BotónSeleccionar1.FlatAppearance.BorderColor = Color.Gray;
            BotónSeleccionar1.FlatStyle = FlatStyle.Popup;
            BotónSeleccionar1.Location = new Point(12, 122);
            BotónSeleccionar1.Name = "BotónSeleccionar1";
            BotónSeleccionar1.Size = new Size(266, 34);
            BotónSeleccionar1.TabIndex = 3;
            BotónSeleccionar1.Text = "Select audio file";
            BotónSeleccionar1.UseVisualStyleBackColor = false;
            BotónSeleccionar1.Click += BotónSeleccionar_Click;
            // 
            // BarraVolumenAudio1
            // 
            BarraVolumenAudio1.Location = new Point(325, 55);
            BarraVolumenAudio1.Maximum = 100;
            BarraVolumenAudio1.Name = "BarraVolumenAudio1";
            BarraVolumenAudio1.Orientation = Orientation.Vertical;
            BarraVolumenAudio1.Size = new Size(69, 118);
            BarraVolumenAudio1.TabIndex = 4;
            BarraVolumenAudio1.Tag = "waveOutDevice";
            BarraVolumenAudio1.TickFrequency = 5;
            BarraVolumenAudio1.TickStyle = TickStyle.Both;
            BarraVolumenAudio1.Value = 20;
            BarraVolumenAudio1.Scroll += BarraVolumenAudio_Scroll;
            // 
            // labelAudio1
            // 
            labelAudio1.AutoSize = true;
            labelAudio1.ForeColor = SystemColors.ControlDark;
            labelAudio1.Location = new Point(325, 170);
            labelAudio1.Name = "labelAudio1";
            labelAudio1.Size = new Size(60, 25);
            labelAudio1.TabIndex = 5;
            labelAudio1.Text = "Audio";
            labelAudio1.Click += labelAudio_Click;
            // 
            // Grabar1
            // 
            Grabar1.BackColor = Color.DimGray;
            Grabar1.FlatAppearance.BorderColor = Color.Gray;
            Grabar1.FlatStyle = FlatStyle.Popup;
            Grabar1.ForeColor = SystemColors.ActiveCaptionText;
            Grabar1.Location = new Point(162, 162);
            Grabar1.Name = "Grabar1";
            Grabar1.Size = new Size(81, 34);
            Grabar1.TabIndex = 6;
            Grabar1.Text = "Record";
            Grabar1.UseVisualStyleBackColor = false;
            Grabar1.Click += Grabar_Click;
            // 
            // labelVoice1
            // 
            labelVoice1.AutoSize = true;
            labelVoice1.ForeColor = SystemColors.ControlDark;
            labelVoice1.Location = new Point(400, 170);
            labelVoice1.Name = "labelVoice1";
            labelVoice1.Size = new Size(54, 25);
            labelVoice1.TabIndex = 7;
            labelVoice1.Text = "Voice";
            // 
            // BarraVolumenMic1
            // 
            BarraVolumenMic1.Location = new Point(400, 55);
            BarraVolumenMic1.Maximum = 100;
            BarraVolumenMic1.Name = "BarraVolumenMic1";
            BarraVolumenMic1.Orientation = Orientation.Vertical;
            BarraVolumenMic1.Size = new Size(69, 118);
            BarraVolumenMic1.TabIndex = 8;
            BarraVolumenMic1.Tag = "waveOutDevice2";
            BarraVolumenMic1.TickFrequency = 5;
            BarraVolumenMic1.TickStyle = TickStyle.Both;
            BarraVolumenMic1.Value = 80;
            BarraVolumenMic1.Scroll += BarraVolumenMic_Scroll;
            // 
            // labelSeleccionar1
            // 
            labelSeleccionar1.AutoSize = true;
            labelSeleccionar1.ForeColor = SystemColors.ControlDark;
            labelSeleccionar1.Location = new Point(12, 55);
            labelSeleccionar1.Name = "labelSeleccionar1";
            labelSeleccionar1.Size = new Size(171, 25);
            labelSeleccionar1.TabIndex = 9;
            labelSeleccionar1.Text = "Select audio output:";
            // 
            // Bloquear1
            // 
            Bloquear1.AutoSize = true;
            Bloquear1.FlatAppearance.BorderColor = Color.DimGray;
            Bloquear1.FlatAppearance.CheckedBackColor = Color.DimGray;
            Bloquear1.FlatStyle = FlatStyle.Popup;
            Bloquear1.ForeColor = SystemColors.ControlDark;
            Bloquear1.Location = new Point(284, 90);
            Bloquear1.Name = "Bloquear1";
            Bloquear1.Size = new Size(18, 17);
            Bloquear1.TabIndex = 10;
            Bloquear1.UseVisualStyleBackColor = true;
            Bloquear1.CheckedChanged += Bloquear_CheckedChanged;
            // 
            // Stop1
            // 
            Stop1.BackColor = Color.DimGray;
            Stop1.FlatAppearance.BorderColor = Color.Gray;
            Stop1.FlatStyle = FlatStyle.Popup;
            Stop1.Location = new Point(87, 162);
            Stop1.Name = "Stop1";
            Stop1.Size = new Size(69, 34);
            Stop1.TabIndex = 11;
            Stop1.Text = "◼";
            Stop1.UseVisualStyleBackColor = false;
            Stop1.Click += Stop_Click;
            // 
            // Play1
            // 
            Play1.BackColor = Color.DimGray;
            Play1.FlatAppearance.BorderColor = Color.Gray;
            Play1.FlatStyle = FlatStyle.Popup;
            Play1.Location = new Point(12, 162);
            Play1.Name = "Play1";
            Play1.Size = new Size(69, 34);
            Play1.TabIndex = 12;
            Play1.Text = "▶";
            Play1.UseVisualStyleBackColor = false;
            Play1.Click += Play_Click_1;
            // 
            // NombreCanal
            // 
            NombreCanal.AutoSize = true;
            NombreCanal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NombreCanal.ForeColor = SystemColors.ControlDark;
            NombreCanal.Location = new Point(180, 10);
            NombreCanal.Name = "NombreCanal";
            NombreCanal.Size = new Size(150, 36);
            NombreCanal.TabIndex = 13;
            NombreCanal.Text = "CHANNEL 1";
            // 
            // NombreCanal2
            // 
            NombreCanal2.AutoSize = true;
            NombreCanal2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NombreCanal2.ForeColor = SystemColors.ControlDark;
            NombreCanal2.Location = new Point(171, 235);
            NombreCanal2.Name = "NombreCanal2";
            NombreCanal2.Size = new Size(150, 36);
            NombreCanal2.TabIndex = 14;
            NombreCanal2.Text = "CHANNEL 2";
            // 
            // labelSeleccionar2
            // 
            labelSeleccionar2.AutoSize = true;
            labelSeleccionar2.ForeColor = SystemColors.ControlDark;
            labelSeleccionar2.Location = new Point(12, 283);
            labelSeleccionar2.Name = "labelSeleccionar2";
            labelSeleccionar2.Size = new Size(171, 25);
            labelSeleccionar2.TabIndex = 15;
            labelSeleccionar2.Text = "Select audio output:";
            // 
            // CBSalidas2
            // 
            CBSalidas2.BackColor = SystemColors.WindowFrame;
            CBSalidas2.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSalidas2.DropDownWidth = 266;
            CBSalidas2.ForeColor = SystemColors.MenuText;
            CBSalidas2.FormattingEnabled = true;
            CBSalidas2.Location = new Point(12, 311);
            CBSalidas2.Name = "CBSalidas2";
            CBSalidas2.Size = new Size(266, 33);
            CBSalidas2.TabIndex = 16;
            CBSalidas2.SelectedIndexChanged += CBSalidas2_SelectedIndexChanged;
            // 
            // BotónSeleccionar2
            // 
            BotónSeleccionar2.BackColor = Color.DimGray;
            BotónSeleccionar2.FlatAppearance.BorderColor = Color.Gray;
            BotónSeleccionar2.FlatStyle = FlatStyle.Popup;
            BotónSeleccionar2.Location = new Point(12, 350);
            BotónSeleccionar2.Name = "BotónSeleccionar2";
            BotónSeleccionar2.Size = new Size(266, 34);
            BotónSeleccionar2.TabIndex = 17;
            BotónSeleccionar2.Text = "Select audio file";
            BotónSeleccionar2.UseVisualStyleBackColor = false;
            BotónSeleccionar2.Click += BotónSeleccionar2_Click;
            // 
            // Play2
            // 
            Play2.BackColor = Color.DimGray;
            Play2.FlatAppearance.BorderColor = Color.Gray;
            Play2.FlatStyle = FlatStyle.Popup;
            Play2.Location = new Point(12, 390);
            Play2.Name = "Play2";
            Play2.Size = new Size(69, 34);
            Play2.TabIndex = 18;
            Play2.Text = "▶";
            Play2.UseVisualStyleBackColor = false;
            Play2.Click += Play_Click2;
            // 
            // Stop2
            // 
            Stop2.BackColor = Color.DimGray;
            Stop2.FlatAppearance.BorderColor = Color.Gray;
            Stop2.FlatStyle = FlatStyle.Popup;
            Stop2.Location = new Point(87, 390);
            Stop2.Name = "Stop2";
            Stop2.Size = new Size(69, 34);
            Stop2.TabIndex = 19;
            Stop2.Text = "◼";
            Stop2.UseVisualStyleBackColor = false;
            Stop2.Click += Stop_Click2;
            // 
            // Grabar2
            // 
            Grabar2.BackColor = Color.DimGray;
            Grabar2.FlatAppearance.BorderColor = Color.Gray;
            Grabar2.FlatStyle = FlatStyle.Popup;
            Grabar2.ForeColor = SystemColors.ActiveCaptionText;
            Grabar2.Location = new Point(162, 390);
            Grabar2.Name = "Grabar2";
            Grabar2.Size = new Size(81, 34);
            Grabar2.TabIndex = 20;
            Grabar2.Text = "Record";
            Grabar2.UseVisualStyleBackColor = false;
            Grabar2.Click += Grabar_Click2;
            // 
            // Bloquear2
            // 
            Bloquear2.AutoSize = true;
            Bloquear2.FlatAppearance.BorderColor = Color.DimGray;
            Bloquear2.FlatAppearance.CheckedBackColor = Color.DimGray;
            Bloquear2.FlatStyle = FlatStyle.Popup;
            Bloquear2.ForeColor = SystemColors.ControlDark;
            Bloquear2.Location = new Point(284, 318);
            Bloquear2.Name = "Bloquear2";
            Bloquear2.Size = new Size(18, 17);
            Bloquear2.TabIndex = 21;
            Bloquear2.UseVisualStyleBackColor = true;
            Bloquear2.CheckedChanged += Bloquear2_CheckedChanged;
            // 
            // BarraVolumenAudio2
            // 
            BarraVolumenAudio2.Location = new Point(325, 283);
            BarraVolumenAudio2.Maximum = 100;
            BarraVolumenAudio2.Name = "BarraVolumenAudio2";
            BarraVolumenAudio2.Orientation = Orientation.Vertical;
            BarraVolumenAudio2.Size = new Size(69, 118);
            BarraVolumenAudio2.TabIndex = 22;
            BarraVolumenAudio2.Tag = "waveOutDevice";
            BarraVolumenAudio2.TickFrequency = 5;
            BarraVolumenAudio2.TickStyle = TickStyle.Both;
            BarraVolumenAudio2.Value = 20;
            BarraVolumenAudio2.Scroll += BarraVolumenAudio2_Scroll;
            // 
            // BarraVolumenMic2
            // 
            BarraVolumenMic2.Location = new Point(400, 283);
            BarraVolumenMic2.Maximum = 100;
            BarraVolumenMic2.Name = "BarraVolumenMic2";
            BarraVolumenMic2.Orientation = Orientation.Vertical;
            BarraVolumenMic2.Size = new Size(69, 118);
            BarraVolumenMic2.TabIndex = 23;
            BarraVolumenMic2.Tag = "waveOutDevice2";
            BarraVolumenMic2.TickFrequency = 5;
            BarraVolumenMic2.TickStyle = TickStyle.Both;
            BarraVolumenMic2.Value = 80;
            BarraVolumenMic2.Scroll += BarraVolumenMic2_Scroll;
            // 
            // labelAudio2
            // 
            labelAudio2.AutoSize = true;
            labelAudio2.ForeColor = SystemColors.ControlDark;
            labelAudio2.Location = new Point(325, 395);
            labelAudio2.Name = "labelAudio2";
            labelAudio2.Size = new Size(60, 25);
            labelAudio2.TabIndex = 24;
            labelAudio2.Text = "Audio";
            // 
            // labelVoice2
            // 
            labelVoice2.AutoSize = true;
            labelVoice2.ForeColor = SystemColors.ControlDark;
            labelVoice2.Location = new Point(400, 395);
            labelVoice2.Name = "labelVoice2";
            labelVoice2.Size = new Size(54, 25);
            labelVoice2.TabIndex = 25;
            labelVoice2.Text = "Voice";
            // 
            // AbrirArchivo2
            // 
            AbrirArchivo2.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // NombreCanal3
            // 
            NombreCanal3.AutoSize = true;
            NombreCanal3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NombreCanal3.ForeColor = SystemColors.ControlDark;
            NombreCanal3.Location = new Point(662, 10);
            NombreCanal3.Name = "NombreCanal3";
            NombreCanal3.Size = new Size(150, 36);
            NombreCanal3.TabIndex = 26;
            NombreCanal3.Text = "CHANNEL 3";
            // 
            // labelSeleccionar3
            // 
            labelSeleccionar3.AutoSize = true;
            labelSeleccionar3.ForeColor = SystemColors.ControlDark;
            labelSeleccionar3.Location = new Point(498, 55);
            labelSeleccionar3.Name = "labelSeleccionar3";
            labelSeleccionar3.Size = new Size(171, 25);
            labelSeleccionar3.TabIndex = 27;
            labelSeleccionar3.Text = "Select audio output:";
            // 
            // CBSalidas3
            // 
            CBSalidas3.BackColor = SystemColors.WindowFrame;
            CBSalidas3.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSalidas3.DropDownWidth = 266;
            CBSalidas3.ForeColor = SystemColors.MenuText;
            CBSalidas3.FormattingEnabled = true;
            CBSalidas3.Location = new Point(498, 83);
            CBSalidas3.Name = "CBSalidas3";
            CBSalidas3.Size = new Size(266, 33);
            CBSalidas3.TabIndex = 28;
            CBSalidas3.SelectedIndexChanged += CBSalidas3_SelectedIndexChanged;
            // 
            // Bloquear3
            // 
            Bloquear3.AutoSize = true;
            Bloquear3.FlatAppearance.BorderColor = Color.DimGray;
            Bloquear3.FlatAppearance.CheckedBackColor = Color.DimGray;
            Bloquear3.FlatStyle = FlatStyle.Popup;
            Bloquear3.ForeColor = SystemColors.ControlDark;
            Bloquear3.Location = new Point(770, 90);
            Bloquear3.Name = "Bloquear3";
            Bloquear3.Size = new Size(18, 17);
            Bloquear3.TabIndex = 29;
            Bloquear3.UseVisualStyleBackColor = true;
            Bloquear3.CheckedChanged += Bloquear3_CheckedChanged;
            // 
            // BotónSeleccionar3
            // 
            BotónSeleccionar3.BackColor = Color.DimGray;
            BotónSeleccionar3.FlatAppearance.BorderColor = Color.Gray;
            BotónSeleccionar3.FlatStyle = FlatStyle.Popup;
            BotónSeleccionar3.Location = new Point(498, 122);
            BotónSeleccionar3.Name = "BotónSeleccionar3";
            BotónSeleccionar3.Size = new Size(266, 34);
            BotónSeleccionar3.TabIndex = 30;
            BotónSeleccionar3.Text = "Select audio file";
            BotónSeleccionar3.UseVisualStyleBackColor = false;
            BotónSeleccionar3.Click += BotónSeleccionar3_Click;
            // 
            // Play3
            // 
            Play3.BackColor = Color.DimGray;
            Play3.FlatAppearance.BorderColor = Color.Gray;
            Play3.FlatStyle = FlatStyle.Popup;
            Play3.Location = new Point(498, 162);
            Play3.Name = "Play3";
            Play3.Size = new Size(69, 34);
            Play3.TabIndex = 31;
            Play3.Text = "▶";
            Play3.UseVisualStyleBackColor = false;
            Play3.Click += Play_Click3;
            // 
            // Stop3
            // 
            Stop3.BackColor = Color.DimGray;
            Stop3.FlatAppearance.BorderColor = Color.Gray;
            Stop3.FlatStyle = FlatStyle.Popup;
            Stop3.Location = new Point(573, 162);
            Stop3.Name = "Stop3";
            Stop3.Size = new Size(69, 34);
            Stop3.TabIndex = 32;
            Stop3.Text = "◼";
            Stop3.UseVisualStyleBackColor = false;
            Stop3.Click += Stop_Click3;
            // 
            // Grabar3
            // 
            Grabar3.BackColor = Color.DimGray;
            Grabar3.FlatAppearance.BorderColor = Color.Gray;
            Grabar3.FlatStyle = FlatStyle.Popup;
            Grabar3.ForeColor = SystemColors.ActiveCaptionText;
            Grabar3.Location = new Point(648, 162);
            Grabar3.Name = "Grabar3";
            Grabar3.Size = new Size(81, 34);
            Grabar3.TabIndex = 33;
            Grabar3.Text = "Record";
            Grabar3.UseVisualStyleBackColor = false;
            Grabar3.Click += Grabar_Click3;
            // 
            // BarraVolumenAudio3
            // 
            BarraVolumenAudio3.Location = new Point(813, 55);
            BarraVolumenAudio3.Maximum = 100;
            BarraVolumenAudio3.Name = "BarraVolumenAudio3";
            BarraVolumenAudio3.Orientation = Orientation.Vertical;
            BarraVolumenAudio3.Size = new Size(69, 118);
            BarraVolumenAudio3.TabIndex = 34;
            BarraVolumenAudio3.Tag = "waveOutDevice";
            BarraVolumenAudio3.TickFrequency = 5;
            BarraVolumenAudio3.TickStyle = TickStyle.Both;
            BarraVolumenAudio3.Value = 20;
            BarraVolumenAudio3.Scroll += BarraVolumenAudio3_Scroll;
            // 
            // BarraVolumenMic3
            // 
            BarraVolumenMic3.Location = new Point(888, 55);
            BarraVolumenMic3.Maximum = 100;
            BarraVolumenMic3.Name = "BarraVolumenMic3";
            BarraVolumenMic3.Orientation = Orientation.Vertical;
            BarraVolumenMic3.Size = new Size(69, 118);
            BarraVolumenMic3.TabIndex = 35;
            BarraVolumenMic3.Tag = "waveOutDevice2";
            BarraVolumenMic3.TickFrequency = 5;
            BarraVolumenMic3.TickStyle = TickStyle.Both;
            BarraVolumenMic3.Value = 80;
            BarraVolumenMic3.Scroll += BarraVolumenMic3_Scroll;
            // 
            // labelAudio3
            // 
            labelAudio3.AutoSize = true;
            labelAudio3.ForeColor = SystemColors.ControlDark;
            labelAudio3.Location = new Point(813, 167);
            labelAudio3.Name = "labelAudio3";
            labelAudio3.Size = new Size(60, 25);
            labelAudio3.TabIndex = 36;
            labelAudio3.Text = "Audio";
            // 
            // labelVoice3
            // 
            labelVoice3.AutoSize = true;
            labelVoice3.ForeColor = SystemColors.ControlDark;
            labelVoice3.Location = new Point(888, 167);
            labelVoice3.Name = "labelVoice3";
            labelVoice3.Size = new Size(54, 25);
            labelVoice3.TabIndex = 37;
            labelVoice3.Text = "Voice";
            // 
            // NombreCanal4
            // 
            NombreCanal4.AutoSize = true;
            NombreCanal4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NombreCanal4.ForeColor = SystemColors.ControlDark;
            NombreCanal4.Location = new Point(662, 235);
            NombreCanal4.Name = "NombreCanal4";
            NombreCanal4.Size = new Size(150, 36);
            NombreCanal4.TabIndex = 38;
            NombreCanal4.Text = "CHANNEL 4";
            // 
            // labelSeleccionar4
            // 
            labelSeleccionar4.AutoSize = true;
            labelSeleccionar4.ForeColor = SystemColors.ControlDark;
            labelSeleccionar4.Location = new Point(498, 283);
            labelSeleccionar4.Name = "labelSeleccionar4";
            labelSeleccionar4.Size = new Size(171, 25);
            labelSeleccionar4.TabIndex = 39;
            labelSeleccionar4.Text = "Select audio output:";
            // 
            // CBSalidas4
            // 
            CBSalidas4.BackColor = SystemColors.WindowFrame;
            CBSalidas4.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSalidas4.DropDownWidth = 266;
            CBSalidas4.ForeColor = SystemColors.MenuText;
            CBSalidas4.FormattingEnabled = true;
            CBSalidas4.Location = new Point(498, 311);
            CBSalidas4.Name = "CBSalidas4";
            CBSalidas4.Size = new Size(266, 33);
            CBSalidas4.TabIndex = 40;
            CBSalidas4.SelectedIndexChanged += CBSalidas4_SelectedIndexChanged;
            // 
            // BotónSeleccionar4
            // 
            BotónSeleccionar4.BackColor = Color.DimGray;
            BotónSeleccionar4.FlatAppearance.BorderColor = Color.Gray;
            BotónSeleccionar4.FlatStyle = FlatStyle.Popup;
            BotónSeleccionar4.Location = new Point(498, 350);
            BotónSeleccionar4.Name = "BotónSeleccionar4";
            BotónSeleccionar4.Size = new Size(266, 34);
            BotónSeleccionar4.TabIndex = 41;
            BotónSeleccionar4.Text = "Select audio file";
            BotónSeleccionar4.UseVisualStyleBackColor = false;
            BotónSeleccionar4.Click += BotónSeleccionar4_Click;
            // 
            // Play4
            // 
            Play4.BackColor = Color.DimGray;
            Play4.FlatAppearance.BorderColor = Color.Gray;
            Play4.FlatStyle = FlatStyle.Popup;
            Play4.Location = new Point(498, 390);
            Play4.Name = "Play4";
            Play4.Size = new Size(69, 34);
            Play4.TabIndex = 42;
            Play4.Text = "▶";
            Play4.UseVisualStyleBackColor = false;
            Play4.Click += Play_Click4;
            // 
            // Stop4
            // 
            Stop4.BackColor = Color.DimGray;
            Stop4.FlatAppearance.BorderColor = Color.Gray;
            Stop4.FlatStyle = FlatStyle.Popup;
            Stop4.Location = new Point(573, 390);
            Stop4.Name = "Stop4";
            Stop4.Size = new Size(69, 34);
            Stop4.TabIndex = 43;
            Stop4.Text = "◼";
            Stop4.UseVisualStyleBackColor = false;
            Stop4.Click += Stop_Click4;
            // 
            // Grabar4
            // 
            Grabar4.BackColor = Color.DimGray;
            Grabar4.FlatAppearance.BorderColor = Color.Gray;
            Grabar4.FlatStyle = FlatStyle.Popup;
            Grabar4.ForeColor = SystemColors.ActiveCaptionText;
            Grabar4.Location = new Point(648, 390);
            Grabar4.Name = "Grabar4";
            Grabar4.Size = new Size(81, 34);
            Grabar4.TabIndex = 44;
            Grabar4.Text = "Record";
            Grabar4.UseVisualStyleBackColor = false;
            Grabar4.Click += Grabar_Click4;
            // 
            // Bloquear4
            // 
            Bloquear4.AutoSize = true;
            Bloquear4.FlatAppearance.BorderColor = Color.DimGray;
            Bloquear4.FlatAppearance.CheckedBackColor = Color.DimGray;
            Bloquear4.FlatStyle = FlatStyle.Popup;
            Bloquear4.ForeColor = SystemColors.ControlDark;
            Bloquear4.Location = new Point(770, 318);
            Bloquear4.Name = "Bloquear4";
            Bloquear4.Size = new Size(18, 17);
            Bloquear4.TabIndex = 45;
            Bloquear4.UseVisualStyleBackColor = true;
            Bloquear4.CheckedChanged += Bloquear4_CheckedChanged;
            // 
            // BarraVolumenAudio4
            // 
            BarraVolumenAudio4.Location = new Point(813, 283);
            BarraVolumenAudio4.Maximum = 100;
            BarraVolumenAudio4.Name = "BarraVolumenAudio4";
            BarraVolumenAudio4.Orientation = Orientation.Vertical;
            BarraVolumenAudio4.Size = new Size(69, 118);
            BarraVolumenAudio4.TabIndex = 46;
            BarraVolumenAudio4.Tag = "waveOutDevice";
            BarraVolumenAudio4.TickFrequency = 5;
            BarraVolumenAudio4.TickStyle = TickStyle.Both;
            BarraVolumenAudio4.Value = 20;
            BarraVolumenAudio4.Scroll += BarraVolumenAudio4_Scroll;
            // 
            // BarraVolumenMic4
            // 
            BarraVolumenMic4.Location = new Point(888, 283);
            BarraVolumenMic4.Maximum = 100;
            BarraVolumenMic4.Name = "BarraVolumenMic4";
            BarraVolumenMic4.Orientation = Orientation.Vertical;
            BarraVolumenMic4.Size = new Size(69, 118);
            BarraVolumenMic4.TabIndex = 47;
            BarraVolumenMic4.Tag = "waveOutDevice2";
            BarraVolumenMic4.TickFrequency = 5;
            BarraVolumenMic4.TickStyle = TickStyle.Both;
            BarraVolumenMic4.Value = 80;
            BarraVolumenMic4.Scroll += BarraVolumenMic4_Scroll;
            // 
            // labelAudio4
            // 
            labelAudio4.AutoSize = true;
            labelAudio4.ForeColor = SystemColors.ControlDark;
            labelAudio4.Location = new Point(813, 395);
            labelAudio4.Name = "labelAudio4";
            labelAudio4.Size = new Size(60, 25);
            labelAudio4.TabIndex = 48;
            labelAudio4.Text = "Audio";
            // 
            // labelVoice4
            // 
            labelVoice4.AutoSize = true;
            labelVoice4.ForeColor = SystemColors.ControlDark;
            labelVoice4.Location = new Point(888, 395);
            labelVoice4.Name = "labelVoice4";
            labelVoice4.Size = new Size(54, 25);
            labelVoice4.TabIndex = 49;
            labelVoice4.Text = "Voice";
            // 
            // AbrirArchivo3
            // 
            AbrirArchivo3.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // AbrirArchivo4
            // 
            AbrirArchivo4.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // recordSettings1
            // 
            recordSettings1.BackColor = Color.DimGray;
            recordSettings1.ContextMenuStrip = settings1;
            recordSettings1.FlatAppearance.BorderColor = Color.Gray;
            recordSettings1.FlatStyle = FlatStyle.Popup;
            recordSettings1.ForeColor = SystemColors.ActiveCaptionText;
            recordSettings1.Location = new Point(249, 162);
            recordSettings1.Name = "recordSettings1";
            recordSettings1.Size = new Size(29, 34);
            recordSettings1.TabIndex = 50;
            recordSettings1.Text = "⚙️";
            recordSettings1.UseVisualStyleBackColor = false;
            recordSettings1.Click += RecordSettings1_Click;
            // 
            // settings1
            // 
            settings1.BackColor = SystemColors.ControlDark;
            settings1.ImageScalingSize = new Size(24, 24);
            settings1.Items.AddRange(new ToolStripItem[] { calidadBaja, calidadMedia, calidadAlta, calidadUltra });
            settings1.Name = "contextMenuStrip1";
            settings1.Size = new Size(301, 132);
            // 
            // calidadBaja
            // 
            calidadBaja.Name = "calidadBaja";
            calidadBaja.Size = new Size(300, 32);
            calidadBaja.Text = "11025 Hz 8 bits (Low)";
            calidadBaja.Click += calidadBaja_Click;
            // 
            // calidadMedia
            // 
            calidadMedia.Name = "calidadMedia";
            calidadMedia.Size = new Size(300, 32);
            calidadMedia.Text = "22050 Hz 16 bits (Medium)";
            calidadMedia.Click += calidadMedia_Click;
            // 
            // calidadAlta
            // 
            calidadAlta.Name = "calidadAlta";
            calidadAlta.Size = new Size(300, 32);
            calidadAlta.Text = "44100 Hz 16 bits (High)";
            calidadAlta.Click += calidadAlta_Click;
            // 
            // calidadUltra
            // 
            calidadUltra.Name = "calidadUltra";
            calidadUltra.Size = new Size(300, 32);
            calidadUltra.Text = "96000 Hz 24 bits (Ultra)";
            calidadUltra.Click += calidadUltra_Click;
            // 
            // recordSettings2
            // 
            recordSettings2.BackColor = Color.DimGray;
            recordSettings2.ContextMenuStrip = settings2;
            recordSettings2.FlatAppearance.BorderColor = Color.Gray;
            recordSettings2.FlatStyle = FlatStyle.Popup;
            recordSettings2.ForeColor = SystemColors.ActiveCaptionText;
            recordSettings2.Location = new Point(249, 390);
            recordSettings2.Name = "recordSettings2";
            recordSettings2.Size = new Size(29, 34);
            recordSettings2.TabIndex = 51;
            recordSettings2.Text = "⚙️";
            recordSettings2.UseVisualStyleBackColor = false;
            recordSettings2.Click += recordSettings2_Click;
            // 
            // settings2
            // 
            settings2.BackColor = SystemColors.ControlDark;
            settings2.ImageScalingSize = new Size(24, 24);
            settings2.Items.AddRange(new ToolStripItem[] { calidadBaja2, calidadMedia2, calidadAlta2, calidadUltra2 });
            settings2.Name = "contextMenuStrip1";
            settings2.Size = new Size(301, 165);
            // 
            // calidadBaja2
            // 
            calidadBaja2.Name = "calidadBaja2";
            calidadBaja2.Size = new Size(300, 32);
            calidadBaja2.Text = "11025 Hz 8 bits (Low)";
            calidadBaja2.Click += calidadBaja2_Click;
            // 
            // calidadMedia2
            // 
            calidadMedia2.Name = "calidadMedia2";
            calidadMedia2.Size = new Size(300, 32);
            calidadMedia2.Text = "22050 Hz 16 bits (Medium)";
            calidadMedia2.Click += calidadMedia2_Click;
            // 
            // calidadAlta2
            // 
            calidadAlta2.Name = "calidadAlta2";
            calidadAlta2.Size = new Size(300, 32);
            calidadAlta2.Text = "44100 Hz 16 bits (High)";
            calidadAlta2.Click += calidadAlta2_Click;
            // 
            // calidadUltra2
            // 
            calidadUltra2.Name = "calidadUltra2";
            calidadUltra2.Size = new Size(300, 32);
            calidadUltra2.Text = "96000 Hz 24 bits (Ultra)";
            calidadUltra2.Click += calidadUltra2_Click;
            // 
            // recordSettings3
            // 
            recordSettings3.BackColor = Color.DimGray;
            recordSettings3.ContextMenuStrip = settings3;
            recordSettings3.FlatAppearance.BorderColor = Color.Gray;
            recordSettings3.FlatStyle = FlatStyle.Popup;
            recordSettings3.ForeColor = SystemColors.ActiveCaptionText;
            recordSettings3.Location = new Point(735, 162);
            recordSettings3.Name = "recordSettings3";
            recordSettings3.Size = new Size(29, 34);
            recordSettings3.TabIndex = 52;
            recordSettings3.Text = "⚙️";
            recordSettings3.UseVisualStyleBackColor = false;
            recordSettings3.Click += recordSettings3_Click;
            // 
            // settings3
            // 
            settings3.BackColor = SystemColors.ControlDark;
            settings3.ImageScalingSize = new Size(24, 24);
            settings3.Items.AddRange(new ToolStripItem[] { calidadBaja3, calidadMedia3, calidadAlta3, calidadUltra3 });
            settings3.Name = "contextMenuStrip1";
            settings3.Size = new Size(301, 132);
            // 
            // calidadBaja3
            // 
            calidadBaja3.Name = "calidadBaja3";
            calidadBaja3.Size = new Size(300, 32);
            calidadBaja3.Text = "11025 Hz 8 bits (Low)";
            calidadBaja3.Click += calidadBaja3_Click;
            // 
            // calidadMedia3
            // 
            calidadMedia3.Name = "calidadMedia3";
            calidadMedia3.Size = new Size(300, 32);
            calidadMedia3.Text = "22050 Hz 16 bits (Medium)";
            calidadMedia3.Click += calidadMedia3_Click;
            // 
            // calidadAlta3
            // 
            calidadAlta3.Name = "calidadAlta3";
            calidadAlta3.Size = new Size(300, 32);
            calidadAlta3.Text = "44100 Hz 16 bits (High)";
            calidadAlta3.Click += calidadAlta3_Click;
            // 
            // calidadUltra3
            // 
            calidadUltra3.Name = "calidadUltra3";
            calidadUltra3.Size = new Size(300, 32);
            calidadUltra3.Text = "96000 Hz 24 bits (Ultra)";
            calidadUltra3.Click += calidadUltra3_Click;
            // 
            // recordSettings4
            // 
            recordSettings4.BackColor = Color.DimGray;
            recordSettings4.ContextMenuStrip = settings3;
            recordSettings4.FlatAppearance.BorderColor = Color.Gray;
            recordSettings4.FlatStyle = FlatStyle.Popup;
            recordSettings4.ForeColor = SystemColors.ActiveCaptionText;
            recordSettings4.Location = new Point(735, 390);
            recordSettings4.Name = "recordSettings4";
            recordSettings4.Size = new Size(29, 34);
            recordSettings4.TabIndex = 53;
            recordSettings4.Text = "⚙️";
            recordSettings4.UseVisualStyleBackColor = false;
            recordSettings4.Click += recordSettings4_Click;
            // 
            // settings4
            // 
            settings4.BackColor = SystemColors.ControlDark;
            settings4.ImageScalingSize = new Size(24, 24);
            settings4.Items.AddRange(new ToolStripItem[] { calidadBaja4, calidadMedia4, calidadAlta4, calidadUltra4 });
            settings4.Name = "contextMenuStrip1";
            settings4.Size = new Size(301, 132);
            // 
            // calidadBaja4
            // 
            calidadBaja4.Name = "calidadBaja4";
            calidadBaja4.Size = new Size(300, 32);
            calidadBaja4.Text = "11025 Hz 8 bits (Low)";
            calidadBaja4.Click += calidadBaja4_Click;
            // 
            // calidadMedia4
            // 
            calidadMedia4.Name = "calidadMedia4";
            calidadMedia4.Size = new Size(300, 32);
            calidadMedia4.Text = "22050 Hz 16 bits (Medium)";
            calidadMedia4.Click += calidadMedia4_Click;
            // 
            // calidadAlta4
            // 
            calidadAlta4.Name = "calidadAlta4";
            calidadAlta4.Size = new Size(300, 32);
            calidadAlta4.Text = "44100 Hz 16 bits (High)";
            calidadAlta4.Click += calidadAlta4_Click;
            // 
            // calidadUltra4
            // 
            calidadUltra4.Name = "calidadUltra4";
            calidadUltra4.Size = new Size(300, 32);
            calidadUltra4.Text = "96000 Hz 24 bits (Ultra)";
            calidadUltra4.Click += calidadUltra4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(974, 440);
            Controls.Add(recordSettings4);
            Controls.Add(recordSettings3);
            Controls.Add(recordSettings2);
            Controls.Add(recordSettings1);
            Controls.Add(labelVoice4);
            Controls.Add(labelAudio4);
            Controls.Add(BarraVolumenMic4);
            Controls.Add(BarraVolumenAudio4);
            Controls.Add(Bloquear4);
            Controls.Add(Grabar4);
            Controls.Add(Stop4);
            Controls.Add(Play4);
            Controls.Add(BotónSeleccionar4);
            Controls.Add(CBSalidas4);
            Controls.Add(labelSeleccionar4);
            Controls.Add(NombreCanal4);
            Controls.Add(labelVoice3);
            Controls.Add(labelAudio3);
            Controls.Add(BarraVolumenMic3);
            Controls.Add(BarraVolumenAudio3);
            Controls.Add(Grabar3);
            Controls.Add(Stop3);
            Controls.Add(Play3);
            Controls.Add(BotónSeleccionar3);
            Controls.Add(Bloquear3);
            Controls.Add(CBSalidas3);
            Controls.Add(labelSeleccionar3);
            Controls.Add(NombreCanal3);
            Controls.Add(labelVoice2);
            Controls.Add(labelAudio2);
            Controls.Add(BarraVolumenMic2);
            Controls.Add(BarraVolumenAudio2);
            Controls.Add(Bloquear2);
            Controls.Add(Grabar2);
            Controls.Add(Stop2);
            Controls.Add(Play2);
            Controls.Add(BotónSeleccionar2);
            Controls.Add(CBSalidas2);
            Controls.Add(labelSeleccionar2);
            Controls.Add(NombreCanal2);
            Controls.Add(NombreCanal);
            Controls.Add(Play1);
            Controls.Add(Stop1);
            Controls.Add(Bloquear1);
            Controls.Add(labelSeleccionar1);
            Controls.Add(BarraVolumenMic1);
            Controls.Add(labelVoice1);
            Controls.Add(Grabar1);
            Controls.Add(labelAudio1);
            Controls.Add(BarraVolumenAudio1);
            Controls.Add(BotónSeleccionar1);
            Controls.Add(CBSalidas);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audio Controller";
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio4).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic4).EndInit();
            settings1.ResumeLayout(false);
            settings2.ResumeLayout(false);
            settings3.ResumeLayout(false);
            settings4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CBSalidas;
        private OpenFileDialog AbrirArchivo;
        private Button BotónSeleccionar1;
        private TrackBar BarraVolumenAudio1;
        private Label labelAudio1;
        private Button Grabar1;
        private Label labelVoice1;
        private TrackBar BarraVolumenMic1;
        private Label labelSeleccionar1;
        private CheckBox Bloquear1;
        private Button Stop1;
        private Button Play1;
        private Label NombreCanal;
        private Label NombreCanal2;
        private Label labelSeleccionar2;
        private ComboBox CBSalidas2;
        private Button BotónSeleccionar2;
        private Button Play2;
        private Button Stop2;
        private Button Grabar2;
        private CheckBox Bloquear2;
        private TrackBar BarraVolumenAudio2;
        private TrackBar BarraVolumenMic2;
        private Label labelAudio2;
        private Label labelVoice2;
        private OpenFileDialog AbrirArchivo2;
        private Label NombreCanal3;
        private Label labelSeleccionar3;
        private ComboBox CBSalidas3;
        private CheckBox Bloquear3;
        private Button BotónSeleccionar3;
        private Button Play3;
        private Button Stop3;
        private Button Grabar3;
        private TrackBar BarraVolumenAudio3;
        private TrackBar BarraVolumenMic3;
        private Label labelAudio3;
        private Label labelVoice3;
        private Label NombreCanal4;
        private Label labelSeleccionar4;
        private ComboBox CBSalidas4;
        private Button BotónSeleccionar4;
        private Button Play4;
        private Button Stop4;
        private Button Grabar4;
        private CheckBox Bloquear4;
        private TrackBar BarraVolumenAudio4;
        private TrackBar BarraVolumenMic4;
        private Label labelAudio4;
        private Label labelVoice4;
        private OpenFileDialog AbrirArchivo3;
        private OpenFileDialog AbrirArchivo4;
        private Button recordSettings1;
        private ContextMenuStrip settings1;
        private ToolStripMenuItem calidadBaja;
        private ToolStripMenuItem calidadMedia;
        private ToolStripMenuItem calidadAlta;
        private ToolStripMenuItem calidadUltra;
        private Button recordSettings2;
        private ContextMenuStrip settings2;
        private ToolStripMenuItem calidadBaja2;
        private ToolStripMenuItem calidadMedia2;
        private ToolStripMenuItem calidadAlta2;
        private ToolStripMenuItem calidadUltra2;
        private Button recordSettings3;
        private ContextMenuStrip settings3;
        private ToolStripMenuItem calidadBaja3;
        private ToolStripMenuItem calidadMedia3;
        private ToolStripMenuItem calidadAlta3;
        private ToolStripMenuItem calidadUltra3;
        private Button recordSettings4;
        private ContextMenuStrip settings4;
        private ToolStripMenuItem calidadBaja4;
        private ToolStripMenuItem calidadMedia4;
        private ToolStripMenuItem calidadAlta4;
        private ToolStripMenuItem calidadUltra4;
    }
}