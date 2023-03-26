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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CBSalidas = new ComboBox();
            AbrirArchivo = new OpenFileDialog();
            BotónSeleccionar = new Button();
            BarraVolumenAudio = new TrackBar();
            labelAudio = new Label();
            Grabar = new Button();
            label2 = new Label();
            BarraVolumenMic = new TrackBar();
            label1 = new Label();
            Bloquear = new CheckBox();
            Stop = new Button();
            Play = new Button();
            NombreCanal = new Label();
            label3 = new Label();
            label4 = new Label();
            CBSalidas2 = new ComboBox();
            BotónSeleccionar2 = new Button();
            Play2 = new Button();
            Stop2 = new Button();
            Grabar2 = new Button();
            Bloquear2 = new CheckBox();
            BarraVolumenAudio2 = new TrackBar();
            BarraVolumenMic2 = new TrackBar();
            labelAudio2 = new Label();
            label6 = new Label();
            AbrirArchivo2 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic2).BeginInit();
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
            // BotónSeleccionar
            // 
            BotónSeleccionar.BackColor = Color.DimGray;
            BotónSeleccionar.FlatAppearance.BorderColor = Color.Gray;
            BotónSeleccionar.FlatStyle = FlatStyle.Popup;
            BotónSeleccionar.Location = new Point(12, 122);
            BotónSeleccionar.Name = "BotónSeleccionar";
            BotónSeleccionar.Size = new Size(266, 34);
            BotónSeleccionar.TabIndex = 3;
            BotónSeleccionar.Text = "Seleccionar archivo de audio";
            BotónSeleccionar.UseVisualStyleBackColor = false;
            BotónSeleccionar.Click += BotónSeleccionar_Click;
            // 
            // BarraVolumenAudio
            // 
            BarraVolumenAudio.Location = new Point(326, 55);
            BarraVolumenAudio.Maximum = 100;
            BarraVolumenAudio.Name = "BarraVolumenAudio";
            BarraVolumenAudio.Orientation = Orientation.Vertical;
            BarraVolumenAudio.Size = new Size(69, 118);
            BarraVolumenAudio.TabIndex = 4;
            BarraVolumenAudio.Tag = "waveOutDevice";
            BarraVolumenAudio.TickFrequency = 5;
            BarraVolumenAudio.TickStyle = TickStyle.Both;
            BarraVolumenAudio.Value = 20;
            BarraVolumenAudio.Scroll += BarraVolumenAudio_Scroll;
            // 
            // labelAudio
            // 
            labelAudio.AutoSize = true;
            labelAudio.ForeColor = SystemColors.ControlDark;
            labelAudio.Location = new Point(326, 171);
            labelAudio.Name = "labelAudio";
            labelAudio.Size = new Size(60, 25);
            labelAudio.TabIndex = 5;
            labelAudio.Text = "Audio";
            labelAudio.Click += labelAudio_Click;
            // 
            // Grabar
            // 
            Grabar.BackColor = Color.DimGray;
            Grabar.FlatAppearance.BorderColor = Color.Gray;
            Grabar.FlatStyle = FlatStyle.Popup;
            Grabar.ForeColor = SystemColors.ActiveCaptionText;
            Grabar.Location = new Point(162, 162);
            Grabar.Name = "Grabar";
            Grabar.Size = new Size(116, 34);
            Grabar.TabIndex = 6;
            Grabar.Text = "Grabar";
            Grabar.UseVisualStyleBackColor = false;
            Grabar.Click += Grabar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(401, 171);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 7;
            label2.Text = "Voice";
            // 
            // BarraVolumenMic
            // 
            BarraVolumenMic.Location = new Point(401, 55);
            BarraVolumenMic.Maximum = 100;
            BarraVolumenMic.Name = "BarraVolumenMic";
            BarraVolumenMic.Orientation = Orientation.Vertical;
            BarraVolumenMic.Size = new Size(69, 118);
            BarraVolumenMic.TabIndex = 8;
            BarraVolumenMic.Tag = "waveOutDevice2";
            BarraVolumenMic.TickFrequency = 5;
            BarraVolumenMic.TickStyle = TickStyle.Both;
            BarraVolumenMic.Value = 80;
            BarraVolumenMic.Scroll += BarraVolumenMic_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 9;
            label1.Text = "Seleccionar salida de audio:";
            // 
            // Bloquear
            // 
            Bloquear.AutoSize = true;
            Bloquear.FlatAppearance.BorderColor = Color.DimGray;
            Bloquear.FlatAppearance.CheckedBackColor = Color.DimGray;
            Bloquear.FlatStyle = FlatStyle.Popup;
            Bloquear.ForeColor = SystemColors.ControlDark;
            Bloquear.Location = new Point(284, 90);
            Bloquear.Name = "Bloquear";
            Bloquear.Size = new Size(18, 17);
            Bloquear.TabIndex = 10;
            Bloquear.UseVisualStyleBackColor = true;
            Bloquear.CheckedChanged += Bloquear_CheckedChanged;
            // 
            // Stop
            // 
            Stop.BackColor = Color.DimGray;
            Stop.FlatAppearance.BorderColor = Color.Gray;
            Stop.FlatStyle = FlatStyle.Popup;
            Stop.Location = new Point(87, 162);
            Stop.Name = "Stop";
            Stop.Size = new Size(69, 34);
            Stop.TabIndex = 11;
            Stop.Text = "◼";
            Stop.UseVisualStyleBackColor = false;
            Stop.Click += Stop_Click;
            // 
            // Play
            // 
            Play.BackColor = Color.DimGray;
            Play.FlatAppearance.BorderColor = Color.Gray;
            Play.FlatStyle = FlatStyle.Popup;
            Play.Location = new Point(12, 162);
            Play.Name = "Play";
            Play.Size = new Size(69, 34);
            Play.TabIndex = 12;
            Play.Text = "▶";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click_1;
            // 
            // NombreCanal
            // 
            NombreCanal.AutoSize = true;
            NombreCanal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            NombreCanal.ForeColor = SystemColors.ControlDark;
            NombreCanal.Location = new Point(179, 9);
            NombreCanal.Name = "NombreCanal";
            NombreCanal.Size = new Size(117, 36);
            NombreCanal.TabIndex = 13;
            NombreCanal.Text = "CANAL 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(179, 236);
            label3.Name = "label3";
            label3.Size = new Size(117, 36);
            label3.TabIndex = 14;
            label3.Text = "CANAL 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(229, 25);
            label4.TabIndex = 15;
            label4.Text = "Seleccionar salida de audio:";
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
            BotónSeleccionar2.Text = "Seleccionar archivo de audio";
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
            Grabar2.Size = new Size(116, 34);
            Grabar2.TabIndex = 20;
            Grabar2.Text = "Grabar";
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
            BarraVolumenAudio2.Location = new Point(326, 283);
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
            BarraVolumenMic2.Location = new Point(401, 283);
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
            labelAudio2.Location = new Point(326, 395);
            labelAudio2.Name = "labelAudio2";
            labelAudio2.Size = new Size(60, 25);
            labelAudio2.TabIndex = 24;
            labelAudio2.Text = "Audio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(401, 395);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 25;
            label6.Text = "Voice";
            // 
            // AbrirArchivo2
            // 
            AbrirArchivo2.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(474, 440);
            Controls.Add(label6);
            Controls.Add(labelAudio2);
            Controls.Add(BarraVolumenMic2);
            Controls.Add(BarraVolumenAudio2);
            Controls.Add(Bloquear2);
            Controls.Add(Grabar2);
            Controls.Add(Stop2);
            Controls.Add(Play2);
            Controls.Add(BotónSeleccionar2);
            Controls.Add(CBSalidas2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NombreCanal);
            Controls.Add(Play);
            Controls.Add(Stop);
            Controls.Add(Bloquear);
            Controls.Add(label1);
            Controls.Add(BarraVolumenMic);
            Controls.Add(label2);
            Controls.Add(Grabar);
            Controls.Add(labelAudio);
            Controls.Add(BarraVolumenAudio);
            Controls.Add(BotónSeleccionar);
            Controls.Add(CBSalidas);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controlador de Audio";
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenAudio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BarraVolumenMic2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CBSalidas;
        private OpenFileDialog AbrirArchivo;
        private Button BotónSeleccionar;
        private TrackBar BarraVolumenAudio;
        private Label labelAudio;
        private Button Grabar;
        private Label label2;
        private TrackBar BarraVolumenMic;
        private Label label1;
        private CheckBox Bloquear;
        private Button Stop;
        private Button Play;
        private Label NombreCanal;
        private Label label3;
        private Label label4;
        private ComboBox CBSalidas2;
        private Button BotónSeleccionar2;
        private Button Play2;
        private Button Stop2;
        private Button Grabar2;
        private CheckBox Bloquear2;
        private TrackBar BarraVolumenAudio2;
        private TrackBar BarraVolumenMic2;
        private Label labelAudio2;
        private Label label6;
        private OpenFileDialog AbrirArchivo2;
    }
}