﻿namespace SoundFingerprinting.SoundTools.QueryDb
{
    partial class WinCheckHashBins
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
            this._labConnectionString = new System.Windows.Forms.Label();
            this._cmbConnectionString = new System.Windows.Forms.ComboBox();
            this._nudQueryStrideMax = new System.Windows.Forms.NumericUpDown();
            this._lbQueryStride = new System.Windows.Forms.Label();
            this._numSecondsToAnalyze = new System.Windows.Forms.NumericUpDown();
            this._lbNumberOfFingerprintsToAnalyze = new System.Windows.Forms.Label();
            this._gbSettings = new System.Windows.Forms.GroupBox();
            this.cbFullSong = new System.Windows.Forms.CheckBox();
            this._gbQueryMicrophoneBox = new System.Windows.Forms.GroupBox();
            this._nudSampleRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._nudSecondsToRecord = new System.Windows.Forms.NumericUpDown();
            this._btnQueryFromMicrophone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._numStartAtSecond = new System.Windows.Forms.NumericUpDown();
            this._labMinStride = new System.Windows.Forms.Label();
            this._nudQueryStrideMin = new System.Windows.Forms.NumericUpDown();
            this._labStrideType = new System.Windows.Forms.Label();
            this._cmbStrideType = new System.Windows.Forms.ComboBox();
            this._labTotal = new System.Windows.Forms.Label();
            this._nudTotalSongs = new System.Windows.Forms.NumericUpDown();
            this._btnStart = new System.Windows.Forms.Button();
            this._btnBrowseSong = new System.Windows.Forms.Button();
            this._tbSingleFile = new System.Windows.Forms.TextBox();
            this._labSong = new System.Windows.Forms.Label();
            this._btnBrowseFolder = new System.Windows.Forms.Button();
            this._labSongs = new System.Windows.Forms.Label();
            this._tbRootFolder = new System.Windows.Forms.TextBox();
            this._labAlgorithm = new System.Windows.Forms.Label();
            this._cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this._gbNeuralHasher = new System.Windows.Forms.GroupBox();
            this._btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._tbPathToEnsemble = new System.Windows.Forms.TextBox();
            this._gbMinHash = new System.Windows.Forms.GroupBox();
            this._nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._nudTopWavelets = new System.Windows.Forms.NumericUpDown();
            this._nudKeys = new System.Windows.Forms.NumericUpDown();
            this._nudHashtables = new System.Windows.Forms.NumericUpDown();
            this._labKeys = new System.Windows.Forms.Label();
            this._labHashtables = new System.Windows.Forms.Label();
            this._labThresholdTables = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._nudQueryStrideMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numSecondsToAnalyze)).BeginInit();
            this._gbSettings.SuspendLayout();
            this._gbQueryMicrophoneBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSecondsToRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numStartAtSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudQueryStrideMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudTotalSongs)).BeginInit();
            this._gbNeuralHasher.SuspendLayout();
            this._gbMinHash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudTopWavelets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHashtables)).BeginInit();
            this.SuspendLayout();
            // 
            // _labConnectionString
            // 
            this._labConnectionString.AutoSize = true;
            this._labConnectionString.Location = new System.Drawing.Point(6, 16);
            this._labConnectionString.Name = "_labConnectionString";
            this._labConnectionString.Size = new System.Drawing.Size(103, 13);
            this._labConnectionString.TabIndex = 0;
            this._labConnectionString.Text = "1. Connection String";
            // 
            // _cmbConnectionString
            // 
            this._cmbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbConnectionString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbConnectionString.FormattingEnabled = true;
            this._cmbConnectionString.Location = new System.Drawing.Point(9, 32);
            this._cmbConnectionString.Name = "_cmbConnectionString";
            this._cmbConnectionString.Size = new System.Drawing.Size(536, 21);
            this._cmbConnectionString.TabIndex = 1;
            // 
            // _nudQueryStrideMax
            // 
            this._nudQueryStrideMax.Location = new System.Drawing.Point(9, 111);
            this._nudQueryStrideMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._nudQueryStrideMax.Name = "_nudQueryStrideMax";
            this._nudQueryStrideMax.Size = new System.Drawing.Size(120, 20);
            this._nudQueryStrideMax.TabIndex = 52;
            this._nudQueryStrideMax.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // _lbQueryStride
            // 
            this._lbQueryStride.AutoSize = true;
            this._lbQueryStride.Location = new System.Drawing.Point(6, 95);
            this._lbQueryStride.Name = "_lbQueryStride";
            this._lbQueryStride.Size = new System.Drawing.Size(69, 13);
            this._lbQueryStride.TabIndex = 50;
            this._lbQueryStride.Text = "3. Max Stride";
            // 
            // _numSecondsToAnalyze
            // 
            this._numSecondsToAnalyze.Location = new System.Drawing.Point(9, 72);
            this._numSecondsToAnalyze.Name = "_numSecondsToAnalyze";
            this._numSecondsToAnalyze.Size = new System.Drawing.Size(120, 20);
            this._numSecondsToAnalyze.TabIndex = 47;
            this._numSecondsToAnalyze.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _lbNumberOfFingerprintsToAnalyze
            // 
            this._lbNumberOfFingerprintsToAnalyze.AutoSize = true;
            this._lbNumberOfFingerprintsToAnalyze.Location = new System.Drawing.Point(6, 56);
            this._lbNumberOfFingerprintsToAnalyze.Name = "_lbNumberOfFingerprintsToAnalyze";
            this._lbNumberOfFingerprintsToAnalyze.Size = new System.Drawing.Size(112, 13);
            this._lbNumberOfFingerprintsToAnalyze.TabIndex = 46;
            this._lbNumberOfFingerprintsToAnalyze.Text = "2. Seconds to analyze";
            // 
            // _gbSettings
            // 
            this._gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbSettings.Controls.Add(this.cbFullSong);
            this._gbSettings.Controls.Add(this._gbQueryMicrophoneBox);
            this._gbSettings.Controls.Add(this.label3);
            this._gbSettings.Controls.Add(this._numStartAtSecond);
            this._gbSettings.Controls.Add(this._labMinStride);
            this._gbSettings.Controls.Add(this._nudQueryStrideMin);
            this._gbSettings.Controls.Add(this._labStrideType);
            this._gbSettings.Controls.Add(this._cmbStrideType);
            this._gbSettings.Controls.Add(this._labTotal);
            this._gbSettings.Controls.Add(this._nudTotalSongs);
            this._gbSettings.Controls.Add(this._btnStart);
            this._gbSettings.Controls.Add(this._btnBrowseSong);
            this._gbSettings.Controls.Add(this._tbSingleFile);
            this._gbSettings.Controls.Add(this._labSong);
            this._gbSettings.Controls.Add(this._btnBrowseFolder);
            this._gbSettings.Controls.Add(this._labSongs);
            this._gbSettings.Controls.Add(this._tbRootFolder);
            this._gbSettings.Controls.Add(this._labAlgorithm);
            this._gbSettings.Controls.Add(this._cmbAlgorithm);
            this._gbSettings.Controls.Add(this._gbNeuralHasher);
            this._gbSettings.Controls.Add(this._labConnectionString);
            this._gbSettings.Controls.Add(this._gbMinHash);
            this._gbSettings.Controls.Add(this._nudQueryStrideMax);
            this._gbSettings.Controls.Add(this._cmbConnectionString);
            this._gbSettings.Controls.Add(this._lbQueryStride);
            this._gbSettings.Controls.Add(this._numSecondsToAnalyze);
            this._gbSettings.Controls.Add(this._lbNumberOfFingerprintsToAnalyze);
            this._gbSettings.Location = new System.Drawing.Point(12, 12);
            this._gbSettings.Name = "_gbSettings";
            this._gbSettings.Size = new System.Drawing.Size(554, 455);
            this._gbSettings.TabIndex = 53;
            this._gbSettings.TabStop = false;
            this._gbSettings.Text = "Settings";
            // 
            // cbFullSong
            // 
            this.cbFullSong.AutoSize = true;
            this.cbFullSong.Location = new System.Drawing.Point(294, 72);
            this.cbFullSong.Name = "cbFullSong";
            this.cbFullSong.Size = new System.Drawing.Size(70, 17);
            this.cbFullSong.TabIndex = 77;
            this.cbFullSong.Text = "Full Song";
            this.cbFullSong.UseVisualStyleBackColor = true;
            this.cbFullSong.CheckedChanged += new System.EventHandler(this.CbFullSongCheckedChanged);
            // 
            // _gbQueryMicrophoneBox
            // 
            this._gbQueryMicrophoneBox.Controls.Add(this._nudSampleRate);
            this._gbQueryMicrophoneBox.Controls.Add(this.label5);
            this._gbQueryMicrophoneBox.Controls.Add(this.label4);
            this._gbQueryMicrophoneBox.Controls.Add(this._nudSecondsToRecord);
            this._gbQueryMicrophoneBox.Controls.Add(this._btnQueryFromMicrophone);
            this._gbQueryMicrophoneBox.Location = new System.Drawing.Point(9, 351);
            this._gbQueryMicrophoneBox.Name = "_gbQueryMicrophoneBox";
            this._gbQueryMicrophoneBox.Size = new System.Drawing.Size(257, 88);
            this._gbQueryMicrophoneBox.TabIndex = 76;
            this._gbQueryMicrophoneBox.TabStop = false;
            this._gbQueryMicrophoneBox.Text = "Query from mic";
            // 
            // _nudSampleRate
            // 
            this._nudSampleRate.Location = new System.Drawing.Point(150, 32);
            this._nudSampleRate.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this._nudSampleRate.Name = "_nudSampleRate";
            this._nudSampleRate.Size = new System.Drawing.Size(101, 20);
            this._nudSampleRate.TabIndex = 77;
            this._nudSampleRate.Value = new decimal(new int[] {
            5512,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Sample rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Seconds to record";
            // 
            // _nudSecondsToRecord
            // 
            this._nudSecondsToRecord.Location = new System.Drawing.Point(9, 32);
            this._nudSecondsToRecord.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this._nudSecondsToRecord.Name = "_nudSecondsToRecord";
            this._nudSecondsToRecord.Size = new System.Drawing.Size(91, 20);
            this._nudSecondsToRecord.TabIndex = 75;
            this._nudSecondsToRecord.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _btnQueryFromMicrophone
            // 
            this._btnQueryFromMicrophone.Location = new System.Drawing.Point(150, 58);
            this._btnQueryFromMicrophone.Name = "_btnQueryFromMicrophone";
            this._btnQueryFromMicrophone.Size = new System.Drawing.Size(103, 23);
            this._btnQueryFromMicrophone.TabIndex = 73;
            this._btnQueryFromMicrophone.Text = "Query From Mic";
            this._btnQueryFromMicrophone.UseVisualStyleBackColor = true;
            this._btnQueryFromMicrophone.Click += new System.EventHandler(this.BtnQueryFromMicrophoneClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Start at second";
            // 
            // _numStartAtSecond
            // 
            this._numStartAtSecond.Location = new System.Drawing.Point(142, 72);
            this._numStartAtSecond.Name = "_numStartAtSecond";
            this._numStartAtSecond.Size = new System.Drawing.Size(120, 20);
            this._numStartAtSecond.TabIndex = 71;
            this._numStartAtSecond.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // _labMinStride
            // 
            this._labMinStride.AutoSize = true;
            this._labMinStride.Location = new System.Drawing.Point(139, 95);
            this._labMinStride.Name = "_labMinStride";
            this._labMinStride.Size = new System.Drawing.Size(54, 13);
            this._labMinStride.TabIndex = 70;
            this._labMinStride.Text = "Min Stride";
            // 
            // _nudQueryStrideMin
            // 
            this._nudQueryStrideMin.Location = new System.Drawing.Point(142, 111);
            this._nudQueryStrideMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._nudQueryStrideMin.Name = "_nudQueryStrideMin";
            this._nudQueryStrideMin.Size = new System.Drawing.Size(118, 20);
            this._nudQueryStrideMin.TabIndex = 69;
            this._nudQueryStrideMin.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // _labStrideType
            // 
            this._labStrideType.AutoSize = true;
            this._labStrideType.Location = new System.Drawing.Point(291, 94);
            this._labStrideType.Name = "_labStrideType";
            this._labStrideType.Size = new System.Drawing.Size(57, 13);
            this._labStrideType.TabIndex = 68;
            this._labStrideType.Text = "Stride type";
            // 
            // _cmbStrideType
            // 
            this._cmbStrideType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbStrideType.FormattingEnabled = true;
            this._cmbStrideType.Location = new System.Drawing.Point(294, 110);
            this._cmbStrideType.Name = "_cmbStrideType";
            this._cmbStrideType.Size = new System.Drawing.Size(114, 21);
            this._cmbStrideType.TabIndex = 67;
            // 
            // _labTotal
            // 
            this._labTotal.AutoSize = true;
            this._labTotal.Location = new System.Drawing.Point(402, 316);
            this._labTotal.Name = "_labTotal";
            this._labTotal.Size = new System.Drawing.Size(64, 13);
            this._labTotal.TabIndex = 66;
            this._labTotal.Text = "Total Songs";
            // 
            // _nudTotalSongs
            // 
            this._nudTotalSongs.Enabled = false;
            this._nudTotalSongs.Location = new System.Drawing.Point(472, 314);
            this._nudTotalSongs.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._nudTotalSongs.Name = "_nudTotalSongs";
            this._nudTotalSongs.ReadOnly = true;
            this._nudTotalSongs.Size = new System.Drawing.Size(75, 20);
            this._nudTotalSongs.TabIndex = 65;
            // 
            // _btnStart
            // 
            this._btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnStart.Location = new System.Drawing.Point(470, 340);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(75, 23);
            this._btnStart.TabIndex = 64;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // _btnBrowseSong
            // 
            this._btnBrowseSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBrowseSong.Location = new System.Drawing.Point(294, 311);
            this._btnBrowseSong.Name = "_btnBrowseSong";
            this._btnBrowseSong.Size = new System.Drawing.Size(75, 23);
            this._btnBrowseSong.TabIndex = 63;
            this._btnBrowseSong.Text = "Browse";
            this._btnBrowseSong.UseVisualStyleBackColor = true;
            this._btnBrowseSong.Click += new System.EventHandler(this.BtnBrowseSongClick);
            // 
            // _tbSingleFile
            // 
            this._tbSingleFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSingleFile.Location = new System.Drawing.Point(294, 288);
            this._tbSingleFile.Name = "_tbSingleFile";
            this._tbSingleFile.ReadOnly = true;
            this._tbSingleFile.Size = new System.Drawing.Size(251, 20);
            this._tbSingleFile.TabIndex = 62;
            // 
            // _labSong
            // 
            this._labSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labSong.AutoSize = true;
            this._labSong.Location = new System.Drawing.Point(291, 272);
            this._labSong.Name = "_labSong";
            this._labSong.Size = new System.Drawing.Size(63, 13);
            this._labSong.TabIndex = 61;
            this._labSong.Text = "Select song";
            // 
            // _btnBrowseFolder
            // 
            this._btnBrowseFolder.Location = new System.Drawing.Point(9, 315);
            this._btnBrowseFolder.Name = "_btnBrowseFolder";
            this._btnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this._btnBrowseFolder.TabIndex = 60;
            this._btnBrowseFolder.Text = "Browse";
            this._btnBrowseFolder.UseVisualStyleBackColor = true;
            this._btnBrowseFolder.Click += new System.EventHandler(this.BtnBrowseFolderClick);
            // 
            // _labSongs
            // 
            this._labSongs.AutoSize = true;
            this._labSongs.Location = new System.Drawing.Point(12, 266);
            this._labSongs.Name = "_labSongs";
            this._labSongs.Size = new System.Drawing.Size(203, 13);
            this._labSongs.TabIndex = 59;
            this._labSongs.Text = "5. Select root folder with songs to analyze";
            // 
            // _tbRootFolder
            // 
            this._tbRootFolder.Location = new System.Drawing.Point(9, 288);
            this._tbRootFolder.Name = "_tbRootFolder";
            this._tbRootFolder.ReadOnly = true;
            this._tbRootFolder.Size = new System.Drawing.Size(257, 20);
            this._tbRootFolder.TabIndex = 58;
            // 
            // _labAlgorithm
            // 
            this._labAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labAlgorithm.AutoSize = true;
            this._labAlgorithm.Location = new System.Drawing.Point(413, 94);
            this._labAlgorithm.Name = "_labAlgorithm";
            this._labAlgorithm.Size = new System.Drawing.Size(62, 13);
            this._labAlgorithm.TabIndex = 57;
            this._labAlgorithm.Text = "4. Algorithm";
            // 
            // _cmbAlgorithm
            // 
            this._cmbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbAlgorithm.FormattingEnabled = true;
            this._cmbAlgorithm.Items.AddRange(new object[] {
            "MinHash"});
            this._cmbAlgorithm.Location = new System.Drawing.Point(416, 110);
            this._cmbAlgorithm.Name = "_cmbAlgorithm";
            this._cmbAlgorithm.Size = new System.Drawing.Size(129, 21);
            this._cmbAlgorithm.TabIndex = 56;
            this._cmbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.CmbAlgorithmSelectedIndexChanged);
            // 
            // _gbNeuralHasher
            // 
            this._gbNeuralHasher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gbNeuralHasher.Controls.Add(this._btnSelect);
            this._gbNeuralHasher.Controls.Add(this.label1);
            this._gbNeuralHasher.Controls.Add(this._tbPathToEnsemble);
            this._gbNeuralHasher.Location = new System.Drawing.Point(294, 137);
            this._gbNeuralHasher.Name = "_gbNeuralHasher";
            this._gbNeuralHasher.Size = new System.Drawing.Size(257, 107);
            this._gbNeuralHasher.TabIndex = 55;
            this._gbNeuralHasher.TabStop = false;
            this._gbNeuralHasher.Text = "Neural Hasher";
            // 
            // _btnSelect
            // 
            this._btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSelect.Location = new System.Drawing.Point(176, 58);
            this._btnSelect.Name = "_btnSelect";
            this._btnSelect.Size = new System.Drawing.Size(75, 23);
            this._btnSelect.TabIndex = 31;
            this._btnSelect.Text = "Select";
            this._btnSelect.UseVisualStyleBackColor = true;
            this._btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Path to Ensembled networks";
            // 
            // _tbPathToEnsemble
            // 
            this._tbPathToEnsemble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbPathToEnsemble.Location = new System.Drawing.Point(9, 32);
            this._tbPathToEnsemble.Name = "_tbPathToEnsemble";
            this._tbPathToEnsemble.ReadOnly = true;
            this._tbPathToEnsemble.Size = new System.Drawing.Size(242, 20);
            this._tbPathToEnsemble.TabIndex = 29;
            // 
            // _gbMinHash
            // 
            this._gbMinHash.Controls.Add(this._nudThreshold);
            this._gbMinHash.Controls.Add(this.label2);
            this._gbMinHash.Controls.Add(this._nudTopWavelets);
            this._gbMinHash.Controls.Add(this._nudKeys);
            this._gbMinHash.Controls.Add(this._nudHashtables);
            this._gbMinHash.Controls.Add(this._labKeys);
            this._gbMinHash.Controls.Add(this._labHashtables);
            this._gbMinHash.Controls.Add(this._labThresholdTables);
            this._gbMinHash.Location = new System.Drawing.Point(9, 137);
            this._gbMinHash.Name = "_gbMinHash";
            this._gbMinHash.Size = new System.Drawing.Size(257, 107);
            this._gbMinHash.TabIndex = 54;
            this._gbMinHash.TabStop = false;
            this._gbMinHash.Text = "Min Hash";
            // 
            // _nudThreshold
            // 
            this._nudThreshold.Location = new System.Drawing.Point(6, 33);
            this._nudThreshold.Name = "_nudThreshold";
            this._nudThreshold.Size = new System.Drawing.Size(100, 20);
            this._nudThreshold.TabIndex = 52;
            this._nudThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Top Wavelets";
            // 
            // _nudTopWavelets
            // 
            this._nudTopWavelets.Location = new System.Drawing.Point(6, 72);
            this._nudTopWavelets.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._nudTopWavelets.Name = "_nudTopWavelets";
            this._nudTopWavelets.Size = new System.Drawing.Size(100, 20);
            this._nudTopWavelets.TabIndex = 32;
            this._nudTopWavelets.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // _nudKeys
            // 
            this._nudKeys.Location = new System.Drawing.Point(133, 33);
            this._nudKeys.Name = "_nudKeys";
            this._nudKeys.Size = new System.Drawing.Size(118, 20);
            this._nudKeys.TabIndex = 51;
            this._nudKeys.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // _nudHashtables
            // 
            this._nudHashtables.Location = new System.Drawing.Point(133, 72);
            this._nudHashtables.Name = "_nudHashtables";
            this._nudHashtables.Size = new System.Drawing.Size(118, 20);
            this._nudHashtables.TabIndex = 50;
            this._nudHashtables.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // _labKeys
            // 
            this._labKeys.AutoSize = true;
            this._labKeys.Location = new System.Drawing.Point(130, 56);
            this._labKeys.Name = "_labKeys";
            this._labKeys.Size = new System.Drawing.Size(60, 13);
            this._labKeys.TabIndex = 49;
            this._labKeys.Text = "Hashtables";
            // 
            // _labHashtables
            // 
            this._labHashtables.AutoSize = true;
            this._labHashtables.Location = new System.Drawing.Point(130, 16);
            this._labHashtables.Name = "_labHashtables";
            this._labHashtables.Size = new System.Drawing.Size(30, 13);
            this._labHashtables.TabIndex = 48;
            this._labHashtables.Text = "Keys";
            // 
            // _labThresholdTables
            // 
            this._labThresholdTables.AutoSize = true;
            this._labThresholdTables.Location = new System.Drawing.Point(6, 16);
            this._labThresholdTables.Name = "_labThresholdTables";
            this._labThresholdTables.Size = new System.Drawing.Size(54, 13);
            this._labThresholdTables.TabIndex = 47;
            this._labThresholdTables.Text = "Threshold";
            // 
            // WinCheckHashBins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 479);
            this.Controls.Add(this._gbSettings);
            this.MaximizeBox = false;
            this.Name = "WinCheckHashBins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query database";
            ((System.ComponentModel.ISupportInitialize)(this._nudQueryStrideMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numSecondsToAnalyze)).EndInit();
            this._gbSettings.ResumeLayout(false);
            this._gbSettings.PerformLayout();
            this._gbQueryMicrophoneBox.ResumeLayout(false);
            this._gbQueryMicrophoneBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSecondsToRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numStartAtSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudQueryStrideMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudTotalSongs)).EndInit();
            this._gbNeuralHasher.ResumeLayout(false);
            this._gbNeuralHasher.PerformLayout();
            this._gbMinHash.ResumeLayout(false);
            this._gbMinHash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudTopWavelets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHashtables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labConnectionString;
        private System.Windows.Forms.ComboBox _cmbConnectionString;
        private System.Windows.Forms.NumericUpDown _nudQueryStrideMax;
        private System.Windows.Forms.Label _lbQueryStride;
        private System.Windows.Forms.NumericUpDown _numSecondsToAnalyze;
        private System.Windows.Forms.Label _lbNumberOfFingerprintsToAnalyze;
        private System.Windows.Forms.GroupBox _gbSettings;
        private System.Windows.Forms.ComboBox _cmbAlgorithm;
        private System.Windows.Forms.GroupBox _gbNeuralHasher;
        private System.Windows.Forms.GroupBox _gbMinHash;
        private System.Windows.Forms.Label _labAlgorithm;
        private System.Windows.Forms.NumericUpDown _nudKeys;
        private System.Windows.Forms.NumericUpDown _nudHashtables;
        private System.Windows.Forms.Label _labKeys;
        private System.Windows.Forms.Label _labHashtables;
        private System.Windows.Forms.Label _labThresholdTables;
        private System.Windows.Forms.Button _btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbPathToEnsemble;
        private System.Windows.Forms.Label _labSongs;
        private System.Windows.Forms.TextBox _tbRootFolder;
        private System.Windows.Forms.Label _labSong;
        private System.Windows.Forms.Button _btnBrowseFolder;
        private System.Windows.Forms.TextBox _tbSingleFile;
        private System.Windows.Forms.Button _btnBrowseSong;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.NumericUpDown _nudTotalSongs;
        private System.Windows.Forms.Label _labTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _nudTopWavelets;
        private System.Windows.Forms.NumericUpDown _nudQueryStrideMin;
        private System.Windows.Forms.Label _labStrideType;
        private System.Windows.Forms.ComboBox _cmbStrideType;
        private System.Windows.Forms.Label _labMinStride;
        private System.Windows.Forms.NumericUpDown _nudThreshold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numStartAtSecond;
        private System.Windows.Forms.GroupBox _gbQueryMicrophoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _nudSecondsToRecord;
        private System.Windows.Forms.Button _btnQueryFromMicrophone;
        private System.Windows.Forms.NumericUpDown _nudSampleRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbFullSong;
    }
}
