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
            CBOuts = new ComboBox();
            openFile = new OpenFileDialog();
            buttonSelect1 = new Button();
            scrollVolumeAudio1 = new TrackBar();
            labelAudio1 = new Label();
            Grabar1 = new Button();
            labelVoice1 = new Label();
            scrollVolumeMic1 = new TrackBar();
            labelSelect1 = new Label();
            Block1 = new CheckBox();
            Stop1 = new Button();
            Play1 = new Button();
            labelChannel1 = new Label();
            labelChannel2 = new Label();
            labelSelect2 = new Label();
            CBOuts2 = new ComboBox();
            buttonSelect2 = new Button();
            Play2 = new Button();
            Stop2 = new Button();
            Grabar2 = new Button();
            Block2 = new CheckBox();
            scrollVolumeAudio2 = new TrackBar();
            scrollVolumeMic2 = new TrackBar();
            labelAudio2 = new Label();
            labelVoice2 = new Label();
            openFile2 = new OpenFileDialog();
            labelChannel3 = new Label();
            labelSelect3 = new Label();
            CBOuts3 = new ComboBox();
            Block3 = new CheckBox();
            buttonSelect3 = new Button();
            Play3 = new Button();
            Stop3 = new Button();
            Grabar3 = new Button();
            scrollVolumeAudio3 = new TrackBar();
            scrollVolumeMic3 = new TrackBar();
            labelAudio3 = new Label();
            labelVoice3 = new Label();
            labelChannel4 = new Label();
            labelSelect4 = new Label();
            CBOuts4 = new ComboBox();
            buttonSelect4 = new Button();
            Play4 = new Button();
            Stop4 = new Button();
            Grabar4 = new Button();
            Block4 = new CheckBox();
            scrollVolumeAudio4 = new TrackBar();
            scrollVolumeMic4 = new TrackBar();
            labelAudio4 = new Label();
            labelVoice4 = new Label();
            openFile3 = new OpenFileDialog();
            openFile4 = new OpenFileDialog();
            recordSettings1 = new Button();
            settings1 = new ContextMenuStrip(components);
            qualityLow = new ToolStripMenuItem();
            qualityMedium = new ToolStripMenuItem();
            qualityHigh = new ToolStripMenuItem();
            qualityUltra = new ToolStripMenuItem();
            recordSettings2 = new Button();
            settings2 = new ContextMenuStrip(components);
            qualityLow2 = new ToolStripMenuItem();
            qualityMedium2 = new ToolStripMenuItem();
            qualityHigh2 = new ToolStripMenuItem();
            qualityUltra2 = new ToolStripMenuItem();
            recordSettings3 = new Button();
            settings3 = new ContextMenuStrip(components);
            qualityLow3 = new ToolStripMenuItem();
            qualityMedium3 = new ToolStripMenuItem();
            qualityHigh3 = new ToolStripMenuItem();
            qualityUltra3 = new ToolStripMenuItem();
            recordSettings4 = new Button();
            settings4 = new ContextMenuStrip(components);
            qualityLow4 = new ToolStripMenuItem();
            qualityMedium4 = new ToolStripMenuItem();
            qualityHigh4 = new ToolStripMenuItem();
            qualityUltra4 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic4).BeginInit();
            settings1.SuspendLayout();
            settings2.SuspendLayout();
            settings3.SuspendLayout();
            settings4.SuspendLayout();
            SuspendLayout();
            // 
            // CBOuts
            // 
            CBOuts.BackColor = SystemColors.WindowFrame;
            CBOuts.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOuts.DropDownWidth = 266;
            CBOuts.ForeColor = SystemColors.MenuText;
            CBOuts.FormattingEnabled = true;
            CBOuts.Location = new Point(12, 83);
            CBOuts.Name = "CBOuts";
            CBOuts.Size = new Size(266, 33);
            CBOuts.TabIndex = 1;
            CBOuts.SelectedIndexChanged += CBOuts_SelectedIndexChanged;
            // 
            // openFile
            // 
            openFile.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // buttonSelect1
            // 
            buttonSelect1.BackColor = Color.DimGray;
            buttonSelect1.FlatAppearance.BorderColor = Color.Gray;
            buttonSelect1.FlatStyle = FlatStyle.Popup;
            buttonSelect1.Location = new Point(12, 122);
            buttonSelect1.Name = "buttonSelect1";
            buttonSelect1.Size = new Size(266, 34);
            buttonSelect1.TabIndex = 3;
            buttonSelect1.Text = "Select audio file";
            buttonSelect1.UseVisualStyleBackColor = false;
            buttonSelect1.Click += buttonSelect_Click;
            // 
            // scrollVolumeAudio1
            // 
            scrollVolumeAudio1.Location = new Point(325, 55);
            scrollVolumeAudio1.Maximum = 100;
            scrollVolumeAudio1.Name = "scrollVolumeAudio1";
            scrollVolumeAudio1.Orientation = Orientation.Vertical;
            scrollVolumeAudio1.Size = new Size(69, 118);
            scrollVolumeAudio1.TabIndex = 4;
            scrollVolumeAudio1.Tag = "waveOutDevice";
            scrollVolumeAudio1.TickFrequency = 5;
            scrollVolumeAudio1.TickStyle = TickStyle.Both;
            scrollVolumeAudio1.Value = 20;
            scrollVolumeAudio1.Scroll += scrollVolumeAudio_Scroll;
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
            // scrollVolumeMic1
            // 
            scrollVolumeMic1.Location = new Point(400, 55);
            scrollVolumeMic1.Maximum = 100;
            scrollVolumeMic1.Name = "scrollVolumeMic1";
            scrollVolumeMic1.Orientation = Orientation.Vertical;
            scrollVolumeMic1.Size = new Size(69, 118);
            scrollVolumeMic1.TabIndex = 8;
            scrollVolumeMic1.Tag = "waveOutDevice2";
            scrollVolumeMic1.TickFrequency = 5;
            scrollVolumeMic1.TickStyle = TickStyle.Both;
            scrollVolumeMic1.Value = 80;
            scrollVolumeMic1.Scroll += scrollVolumeMic_Scroll;
            // 
            // labelSelect1
            // 
            labelSelect1.AutoSize = true;
            labelSelect1.ForeColor = SystemColors.ControlDark;
            labelSelect1.Location = new Point(12, 55);
            labelSelect1.Name = "labelSelect1";
            labelSelect1.Size = new Size(171, 25);
            labelSelect1.TabIndex = 9;
            labelSelect1.Text = "Select audio output:";
            // 
            // Block1
            // 
            Block1.AutoSize = true;
            Block1.FlatAppearance.BorderColor = Color.DimGray;
            Block1.FlatAppearance.CheckedBackColor = Color.DimGray;
            Block1.FlatStyle = FlatStyle.Popup;
            Block1.ForeColor = SystemColors.ControlDark;
            Block1.Location = new Point(284, 90);
            Block1.Name = "Block1";
            Block1.Size = new Size(18, 17);
            Block1.TabIndex = 10;
            Block1.UseVisualStyleBackColor = true;
            Block1.CheckedChanged += block_CheckedChanged;
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
            // labelChannel1
            // 
            labelChannel1.AutoSize = true;
            labelChannel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelChannel1.ForeColor = SystemColors.ControlDark;
            labelChannel1.Location = new Point(180, 10);
            labelChannel1.Name = "labelChannel1";
            labelChannel1.Size = new Size(150, 36);
            labelChannel1.TabIndex = 13;
            labelChannel1.Text = "CHANNEL 1";
            // 
            // labelChannel2
            // 
            labelChannel2.AutoSize = true;
            labelChannel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelChannel2.ForeColor = SystemColors.ControlDark;
            labelChannel2.Location = new Point(171, 235);
            labelChannel2.Name = "labelChannel2";
            labelChannel2.Size = new Size(150, 36);
            labelChannel2.TabIndex = 14;
            labelChannel2.Text = "CHANNEL 2";
            // 
            // labelSelect2
            // 
            labelSelect2.AutoSize = true;
            labelSelect2.ForeColor = SystemColors.ControlDark;
            labelSelect2.Location = new Point(12, 283);
            labelSelect2.Name = "labelSelect2";
            labelSelect2.Size = new Size(171, 25);
            labelSelect2.TabIndex = 15;
            labelSelect2.Text = "Select audio output:";
            // 
            // CBOuts2
            // 
            CBOuts2.BackColor = SystemColors.WindowFrame;
            CBOuts2.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOuts2.DropDownWidth = 266;
            CBOuts2.ForeColor = SystemColors.MenuText;
            CBOuts2.FormattingEnabled = true;
            CBOuts2.Location = new Point(12, 311);
            CBOuts2.Name = "CBOuts2";
            CBOuts2.Size = new Size(266, 33);
            CBOuts2.TabIndex = 16;
            CBOuts2.SelectedIndexChanged += CBOuts2_SelectedIndexChanged;
            // 
            // buttonSelect2
            // 
            buttonSelect2.BackColor = Color.DimGray;
            buttonSelect2.FlatAppearance.BorderColor = Color.Gray;
            buttonSelect2.FlatStyle = FlatStyle.Popup;
            buttonSelect2.Location = new Point(12, 350);
            buttonSelect2.Name = "buttonSelect2";
            buttonSelect2.Size = new Size(266, 34);
            buttonSelect2.TabIndex = 17;
            buttonSelect2.Text = "Select audio file";
            buttonSelect2.UseVisualStyleBackColor = false;
            buttonSelect2.Click += buttonSelect2_Click;
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
            // Block2
            // 
            Block2.AutoSize = true;
            Block2.FlatAppearance.BorderColor = Color.DimGray;
            Block2.FlatAppearance.CheckedBackColor = Color.DimGray;
            Block2.FlatStyle = FlatStyle.Popup;
            Block2.ForeColor = SystemColors.ControlDark;
            Block2.Location = new Point(284, 318);
            Block2.Name = "Block2";
            Block2.Size = new Size(18, 17);
            Block2.TabIndex = 21;
            Block2.UseVisualStyleBackColor = true;
            Block2.CheckedChanged += block2_CheckedChanged;
            // 
            // scrollVolumeAudio2
            // 
            scrollVolumeAudio2.Location = new Point(325, 283);
            scrollVolumeAudio2.Maximum = 100;
            scrollVolumeAudio2.Name = "scrollVolumeAudio2";
            scrollVolumeAudio2.Orientation = Orientation.Vertical;
            scrollVolumeAudio2.Size = new Size(69, 118);
            scrollVolumeAudio2.TabIndex = 22;
            scrollVolumeAudio2.Tag = "waveOutDevice";
            scrollVolumeAudio2.TickFrequency = 5;
            scrollVolumeAudio2.TickStyle = TickStyle.Both;
            scrollVolumeAudio2.Value = 20;
            scrollVolumeAudio2.Scroll += scrollVolumeAudio2_Scroll;
            // 
            // scrollVolumeMic2
            // 
            scrollVolumeMic2.Location = new Point(400, 283);
            scrollVolumeMic2.Maximum = 100;
            scrollVolumeMic2.Name = "scrollVolumeMic2";
            scrollVolumeMic2.Orientation = Orientation.Vertical;
            scrollVolumeMic2.Size = new Size(69, 118);
            scrollVolumeMic2.TabIndex = 23;
            scrollVolumeMic2.Tag = "waveOutDevice2";
            scrollVolumeMic2.TickFrequency = 5;
            scrollVolumeMic2.TickStyle = TickStyle.Both;
            scrollVolumeMic2.Value = 80;
            scrollVolumeMic2.Scroll += scrollVolumeMic2_Scroll;
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
            // openFile2
            // 
            openFile2.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // labelChannel3
            // 
            labelChannel3.AutoSize = true;
            labelChannel3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelChannel3.ForeColor = SystemColors.ControlDark;
            labelChannel3.Location = new Point(662, 10);
            labelChannel3.Name = "labelChannel3";
            labelChannel3.Size = new Size(150, 36);
            labelChannel3.TabIndex = 26;
            labelChannel3.Text = "CHANNEL 3";
            // 
            // labelSelect3
            // 
            labelSelect3.AutoSize = true;
            labelSelect3.ForeColor = SystemColors.ControlDark;
            labelSelect3.Location = new Point(498, 55);
            labelSelect3.Name = "labelSelect3";
            labelSelect3.Size = new Size(171, 25);
            labelSelect3.TabIndex = 27;
            labelSelect3.Text = "Select audio output:";
            // 
            // CBOuts3
            // 
            CBOuts3.BackColor = SystemColors.WindowFrame;
            CBOuts3.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOuts3.DropDownWidth = 266;
            CBOuts3.ForeColor = SystemColors.MenuText;
            CBOuts3.FormattingEnabled = true;
            CBOuts3.Location = new Point(498, 83);
            CBOuts3.Name = "CBOuts3";
            CBOuts3.Size = new Size(266, 33);
            CBOuts3.TabIndex = 28;
            CBOuts3.SelectedIndexChanged += CBOuts3_SelectedIndexChanged;
            // 
            // Block3
            // 
            Block3.AutoSize = true;
            Block3.FlatAppearance.BorderColor = Color.DimGray;
            Block3.FlatAppearance.CheckedBackColor = Color.DimGray;
            Block3.FlatStyle = FlatStyle.Popup;
            Block3.ForeColor = SystemColors.ControlDark;
            Block3.Location = new Point(770, 90);
            Block3.Name = "Block3";
            Block3.Size = new Size(18, 17);
            Block3.TabIndex = 29;
            Block3.UseVisualStyleBackColor = true;
            Block3.CheckedChanged += block3_CheckedChanged;
            // 
            // buttonSelect3
            // 
            buttonSelect3.BackColor = Color.DimGray;
            buttonSelect3.FlatAppearance.BorderColor = Color.Gray;
            buttonSelect3.FlatStyle = FlatStyle.Popup;
            buttonSelect3.Location = new Point(498, 122);
            buttonSelect3.Name = "buttonSelect3";
            buttonSelect3.Size = new Size(266, 34);
            buttonSelect3.TabIndex = 30;
            buttonSelect3.Text = "Select audio file";
            buttonSelect3.UseVisualStyleBackColor = false;
            buttonSelect3.Click += buttonSelect3_Click;
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
            // scrollVolumeAudio3
            // 
            scrollVolumeAudio3.Location = new Point(813, 55);
            scrollVolumeAudio3.Maximum = 100;
            scrollVolumeAudio3.Name = "scrollVolumeAudio3";
            scrollVolumeAudio3.Orientation = Orientation.Vertical;
            scrollVolumeAudio3.Size = new Size(69, 118);
            scrollVolumeAudio3.TabIndex = 34;
            scrollVolumeAudio3.Tag = "waveOutDevice";
            scrollVolumeAudio3.TickFrequency = 5;
            scrollVolumeAudio3.TickStyle = TickStyle.Both;
            scrollVolumeAudio3.Value = 20;
            scrollVolumeAudio3.Scroll += scrollVolumeAudio3_Scroll;
            // 
            // scrollVolumeMic3
            // 
            scrollVolumeMic3.Location = new Point(888, 55);
            scrollVolumeMic3.Maximum = 100;
            scrollVolumeMic3.Name = "scrollVolumeMic3";
            scrollVolumeMic3.Orientation = Orientation.Vertical;
            scrollVolumeMic3.Size = new Size(69, 118);
            scrollVolumeMic3.TabIndex = 35;
            scrollVolumeMic3.Tag = "waveOutDevice2";
            scrollVolumeMic3.TickFrequency = 5;
            scrollVolumeMic3.TickStyle = TickStyle.Both;
            scrollVolumeMic3.Value = 80;
            scrollVolumeMic3.Scroll += scrollVolumeMic3_Scroll;
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
            // labelChannel4
            // 
            labelChannel4.AutoSize = true;
            labelChannel4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelChannel4.ForeColor = SystemColors.ControlDark;
            labelChannel4.Location = new Point(662, 235);
            labelChannel4.Name = "labelChannel4";
            labelChannel4.Size = new Size(150, 36);
            labelChannel4.TabIndex = 38;
            labelChannel4.Text = "CHANNEL 4";
            // 
            // labelSelect4
            // 
            labelSelect4.AutoSize = true;
            labelSelect4.ForeColor = SystemColors.ControlDark;
            labelSelect4.Location = new Point(498, 283);
            labelSelect4.Name = "labelSelect4";
            labelSelect4.Size = new Size(171, 25);
            labelSelect4.TabIndex = 39;
            labelSelect4.Text = "Select audio output:";
            // 
            // CBOuts4
            // 
            CBOuts4.BackColor = SystemColors.WindowFrame;
            CBOuts4.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOuts4.DropDownWidth = 266;
            CBOuts4.ForeColor = SystemColors.MenuText;
            CBOuts4.FormattingEnabled = true;
            CBOuts4.Location = new Point(498, 311);
            CBOuts4.Name = "CBOuts4";
            CBOuts4.Size = new Size(266, 33);
            CBOuts4.TabIndex = 40;
            CBOuts4.SelectedIndexChanged += CBOuts4_SelectedIndexChanged;
            // 
            // buttonSelect4
            // 
            buttonSelect4.BackColor = Color.DimGray;
            buttonSelect4.FlatAppearance.BorderColor = Color.Gray;
            buttonSelect4.FlatStyle = FlatStyle.Popup;
            buttonSelect4.Location = new Point(498, 350);
            buttonSelect4.Name = "buttonSelect4";
            buttonSelect4.Size = new Size(266, 34);
            buttonSelect4.TabIndex = 41;
            buttonSelect4.Text = "Select audio file";
            buttonSelect4.UseVisualStyleBackColor = false;
            buttonSelect4.Click += buttonSelect4_Click;
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
            // Block4
            // 
            Block4.AutoSize = true;
            Block4.FlatAppearance.BorderColor = Color.DimGray;
            Block4.FlatAppearance.CheckedBackColor = Color.DimGray;
            Block4.FlatStyle = FlatStyle.Popup;
            Block4.ForeColor = SystemColors.ControlDark;
            Block4.Location = new Point(770, 318);
            Block4.Name = "Block4";
            Block4.Size = new Size(18, 17);
            Block4.TabIndex = 45;
            Block4.UseVisualStyleBackColor = true;
            Block4.CheckedChanged += block4_CheckedChanged;
            // 
            // scrollVolumeAudio4
            // 
            scrollVolumeAudio4.Location = new Point(813, 283);
            scrollVolumeAudio4.Maximum = 100;
            scrollVolumeAudio4.Name = "scrollVolumeAudio4";
            scrollVolumeAudio4.Orientation = Orientation.Vertical;
            scrollVolumeAudio4.Size = new Size(69, 118);
            scrollVolumeAudio4.TabIndex = 46;
            scrollVolumeAudio4.Tag = "waveOutDevice";
            scrollVolumeAudio4.TickFrequency = 5;
            scrollVolumeAudio4.TickStyle = TickStyle.Both;
            scrollVolumeAudio4.Value = 20;
            scrollVolumeAudio4.Scroll += scrollVolumeAudio4_Scroll;
            // 
            // scrollVolumeMic4
            // 
            scrollVolumeMic4.Location = new Point(888, 283);
            scrollVolumeMic4.Maximum = 100;
            scrollVolumeMic4.Name = "scrollVolumeMic4";
            scrollVolumeMic4.Orientation = Orientation.Vertical;
            scrollVolumeMic4.Size = new Size(69, 118);
            scrollVolumeMic4.TabIndex = 47;
            scrollVolumeMic4.Tag = "waveOutDevice2";
            scrollVolumeMic4.TickFrequency = 5;
            scrollVolumeMic4.TickStyle = TickStyle.Both;
            scrollVolumeMic4.Value = 80;
            scrollVolumeMic4.Scroll += scrollVolumeMic4_Scroll;
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
            // openFile3
            // 
            openFile3.Filter = "\"|*.wav;*.mp3;*.ogg\"";
            // 
            // openFile4
            // 
            openFile4.Filter = "\"|*.wav;*.mp3;*.ogg\"";
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
            settings1.Items.AddRange(new ToolStripItem[] { qualityLow, qualityMedium, qualityHigh, qualityUltra });
            settings1.Name = "contextMenuStrip1";
            settings1.Size = new Size(301, 132);
            // 
            // qualityLow
            // 
            qualityLow.Name = "qualityLow";
            qualityLow.Size = new Size(300, 32);
            qualityLow.Text = "11025 Hz 8 bits (Low)";
            qualityLow.Click += qualityLow_Click;
            // 
            // qualityMedium
            // 
            qualityMedium.Name = "qualityMedium";
            qualityMedium.Size = new Size(300, 32);
            qualityMedium.Text = "22050 Hz 16 bits (Medium)";
            qualityMedium.Click += qualityMedium_Click;
            // 
            // qualityHigh
            // 
            qualityHigh.Name = "qualityHigh";
            qualityHigh.Size = new Size(300, 32);
            qualityHigh.Text = "44100 Hz 16 bits (High)";
            qualityHigh.Click += qualityHigh_Click;
            // 
            // qualityUltra
            // 
            qualityUltra.Name = "qualityUltra";
            qualityUltra.Size = new Size(300, 32);
            qualityUltra.Text = "96000 Hz 24 bits (Ultra)";
            qualityUltra.Click += qualityUltra_Click;
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
            settings2.Items.AddRange(new ToolStripItem[] { qualityLow2, qualityMedium2, qualityHigh2, qualityUltra2 });
            settings2.Name = "contextMenuStrip1";
            settings2.Size = new Size(301, 132);
            // 
            // qualityLow2
            // 
            qualityLow2.Name = "qualityLow2";
            qualityLow2.Size = new Size(300, 32);
            qualityLow2.Text = "11025 Hz 8 bits (Low)";
            qualityLow2.Click += qualityLow2_Click;
            // 
            // qualityMedium2
            // 
            qualityMedium2.Name = "qualityMedium2";
            qualityMedium2.Size = new Size(300, 32);
            qualityMedium2.Text = "22050 Hz 16 bits (Medium)";
            qualityMedium2.Click += qualityMedium2_Click;
            // 
            // qualityHigh2
            // 
            qualityHigh2.Name = "qualityHigh2";
            qualityHigh2.Size = new Size(300, 32);
            qualityHigh2.Text = "44100 Hz 16 bits (High)";
            qualityHigh2.Click += qualityHigh2_Click;
            // 
            // qualityUltra2
            // 
            qualityUltra2.Name = "qualityUltra2";
            qualityUltra2.Size = new Size(300, 32);
            qualityUltra2.Text = "96000 Hz 24 bits (Ultra)";
            qualityUltra2.Click += qualityUltra2_Click;
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
            settings3.Items.AddRange(new ToolStripItem[] { qualityLow3, qualityMedium3, qualityHigh3, qualityUltra3 });
            settings3.Name = "contextMenuStrip1";
            settings3.Size = new Size(301, 132);
            // 
            // qualityLow3
            // 
            qualityLow3.Name = "qualityLow3";
            qualityLow3.Size = new Size(300, 32);
            qualityLow3.Text = "11025 Hz 8 bits (Low)";
            qualityLow3.Click += qualityLow3_Click;
            // 
            // qualityMedium3
            // 
            qualityMedium3.Name = "qualityMedium3";
            qualityMedium3.Size = new Size(300, 32);
            qualityMedium3.Text = "22050 Hz 16 bits (Medium)";
            qualityMedium3.Click += qualityMedium3_Click;
            // 
            // qualityHigh3
            // 
            qualityHigh3.Name = "qualityHigh3";
            qualityHigh3.Size = new Size(300, 32);
            qualityHigh3.Text = "44100 Hz 16 bits (High)";
            qualityHigh3.Click += qualityHigh3_Click;
            // 
            // qualityUltra3
            // 
            qualityUltra3.Name = "qualityUltra3";
            qualityUltra3.Size = new Size(300, 32);
            qualityUltra3.Text = "96000 Hz 24 bits (Ultra)";
            qualityUltra3.Click += qualityUltra3_Click;
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
            settings4.Items.AddRange(new ToolStripItem[] { qualityLow4, qualityMedium4, qualityHigh4, qualityUltra4 });
            settings4.Name = "contextMenuStrip1";
            settings4.Size = new Size(301, 132);
            // 
            // qualityLow4
            // 
            qualityLow4.Name = "qualityLow4";
            qualityLow4.Size = new Size(300, 32);
            qualityLow4.Text = "11025 Hz 8 bits (Low)";
            qualityLow4.Click += qualityLow4_Click;
            // 
            // qualityMedium4
            // 
            qualityMedium4.Name = "qualityMedium4";
            qualityMedium4.Size = new Size(300, 32);
            qualityMedium4.Text = "22050 Hz 16 bits (Medium)";
            qualityMedium4.Click += qualityMedium4_Click;
            // 
            // qualityHigh4
            // 
            qualityHigh4.Name = "qualityHigh4";
            qualityHigh4.Size = new Size(300, 32);
            qualityHigh4.Text = "44100 Hz 16 bits (High)";
            qualityHigh4.Click += qualityHigh4_Click;
            // 
            // qualityUltra4
            // 
            qualityUltra4.Name = "qualityUltra4";
            qualityUltra4.Size = new Size(300, 32);
            qualityUltra4.Text = "96000 Hz 24 bits (Ultra)";
            qualityUltra4.Click += qualityUltra4_Click;
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
            Controls.Add(scrollVolumeMic4);
            Controls.Add(scrollVolumeAudio4);
            Controls.Add(Block4);
            Controls.Add(Grabar4);
            Controls.Add(Stop4);
            Controls.Add(Play4);
            Controls.Add(buttonSelect4);
            Controls.Add(CBOuts4);
            Controls.Add(labelSelect4);
            Controls.Add(labelChannel4);
            Controls.Add(labelVoice3);
            Controls.Add(labelAudio3);
            Controls.Add(scrollVolumeMic3);
            Controls.Add(scrollVolumeAudio3);
            Controls.Add(Grabar3);
            Controls.Add(Stop3);
            Controls.Add(Play3);
            Controls.Add(buttonSelect3);
            Controls.Add(Block3);
            Controls.Add(CBOuts3);
            Controls.Add(labelSelect3);
            Controls.Add(labelChannel3);
            Controls.Add(labelVoice2);
            Controls.Add(labelAudio2);
            Controls.Add(scrollVolumeMic2);
            Controls.Add(scrollVolumeAudio2);
            Controls.Add(Block2);
            Controls.Add(Grabar2);
            Controls.Add(Stop2);
            Controls.Add(Play2);
            Controls.Add(buttonSelect2);
            Controls.Add(CBOuts2);
            Controls.Add(labelSelect2);
            Controls.Add(labelChannel2);
            Controls.Add(labelChannel1);
            Controls.Add(Play1);
            Controls.Add(Stop1);
            Controls.Add(Block1);
            Controls.Add(labelSelect1);
            Controls.Add(scrollVolumeMic1);
            Controls.Add(labelVoice1);
            Controls.Add(Grabar1);
            Controls.Add(labelAudio1);
            Controls.Add(scrollVolumeAudio1);
            Controls.Add(buttonSelect1);
            Controls.Add(CBOuts);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audio Controller";
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio1).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio2).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio3).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeAudio4).EndInit();
            ((System.ComponentModel.ISupportInitialize)scrollVolumeMic4).EndInit();
            settings1.ResumeLayout(false);
            settings2.ResumeLayout(false);
            settings3.ResumeLayout(false);
            settings4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CBOuts;
        private OpenFileDialog openFile;
        private Button buttonSelect1;
        private TrackBar scrollVolumeAudio1;
        private Label labelAudio1;
        private Button Grabar1;
        private Label labelVoice1;
        private TrackBar scrollVolumeMic1;
        private Label labelSelect1;
        private CheckBox Block1;
        private Button Stop1;
        private Button Play1;
        private Label labelChannel1;
        private Label labelChannel2;
        private Label labelSelect2;
        private ComboBox CBOuts2;
        private Button buttonSelect2;
        private Button Play2;
        private Button Stop2;
        private Button Grabar2;
        private CheckBox Block2;
        private TrackBar scrollVolumeAudio2;
        private TrackBar scrollVolumeMic2;
        private Label labelAudio2;
        private Label labelVoice2;
        private OpenFileDialog openFile2;
        private Label labelChannel3;
        private Label labelSelect3;
        private ComboBox CBOuts3;
        private CheckBox Block3;
        private Button buttonSelect3;
        private Button Play3;
        private Button Stop3;
        private Button Grabar3;
        private TrackBar scrollVolumeAudio3;
        private TrackBar scrollVolumeMic3;
        private Label labelAudio3;
        private Label labelVoice3;
        private Label labelChannel4;
        private Label labelSelect4;
        private ComboBox CBOuts4;
        private Button buttonSelect4;
        private Button Play4;
        private Button Stop4;
        private Button Grabar4;
        private CheckBox Block4;
        private TrackBar scrollVolumeAudio4;
        private TrackBar scrollVolumeMic4;
        private Label labelAudio4;
        private Label labelVoice4;
        private OpenFileDialog openFile3;
        private OpenFileDialog openFile4;
        private Button recordSettings1;
        private ContextMenuStrip settings1;
        private ToolStripMenuItem qualityLow;
        private ToolStripMenuItem qualityMedium;
        private ToolStripMenuItem qualityHigh;
        private ToolStripMenuItem qualityUltra;
        private Button recordSettings2;
        private ContextMenuStrip settings2;
        private ToolStripMenuItem qualityLow2;
        private ToolStripMenuItem qualityMedium2;
        private ToolStripMenuItem qualityHigh2;
        private ToolStripMenuItem qualityUltra2;
        private Button recordSettings3;
        private ContextMenuStrip settings3;
        private ToolStripMenuItem qualityLow3;
        private ToolStripMenuItem qualityMedium3;
        private ToolStripMenuItem qualityHigh3;
        private ToolStripMenuItem qualityUltra3;
        private Button recordSettings4;
        private ContextMenuStrip settings4;
        private ToolStripMenuItem qualityLow4;
        private ToolStripMenuItem qualityMedium4;
        private ToolStripMenuItem qualityHigh4;
        private ToolStripMenuItem qualityUltra4;
    }
}