﻿namespace RocksmithToolkitGUI.DLCPackageCreator
{
    partial class ArrangementForm
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
            this.songXmlBrowseButton = new System.Windows.Forms.Button();
            this.addArrangementButton = new System.Windows.Forms.Button();
            this.arrangementTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toneBaseCombo = new System.Windows.Forms.ComboBox();
            this.scrollSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scrollSpeedDisplay = new System.Windows.Forms.Label();
            this.Picked = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arrangementNameCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tuningComboBox = new System.Windows.Forms.ComboBox();
            this.gbTone = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toneDCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toneCCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toneMultiplayerCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toneBCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toneACombo = new System.Windows.Forms.ComboBox();
            this.lblToneA = new System.Windows.Forms.Label();
            this.gbDLCId = new System.Windows.Forms.GroupBox();
            this.PersistentId = new RocksmithToolkitGUI.CueTextBox();
            this.MasterId = new RocksmithToolkitGUI.CueTextBox();
            this.gbXmlDefinition = new System.Windows.Forms.GroupBox();
            this.XmlFilePath = new RocksmithToolkitGUI.CueTextBox();
            this.gbArrInfo = new System.Windows.Forms.GroupBox();
            this.gbScrollSpeed = new System.Windows.Forms.GroupBox();
            this.RelativeDifficulty = new RocksmithToolkitGUI.CueTextBox();
            this.gbGameplayPath = new System.Windows.Forms.GroupBox();
            this.pathBassCheckbox = new System.Windows.Forms.CheckBox();
            this.pathRhythmCheckbox = new System.Windows.Forms.CheckBox();
            this.pathLeadCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scrollSpeedTrackBar)).BeginInit();
            this.gbTone.SuspendLayout();
            this.gbDLCId.SuspendLayout();
            this.gbXmlDefinition.SuspendLayout();
            this.gbArrInfo.SuspendLayout();
            this.gbScrollSpeed.SuspendLayout();
            this.gbGameplayPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // songXmlBrowseButton
            // 
            this.songXmlBrowseButton.Location = new System.Drawing.Point(363, 16);
            this.songXmlBrowseButton.Name = "songXmlBrowseButton";
            this.songXmlBrowseButton.Size = new System.Drawing.Size(62, 23);
            this.songXmlBrowseButton.TabIndex = 1;
            this.songXmlBrowseButton.Text = "Browse";
            this.songXmlBrowseButton.UseVisualStyleBackColor = true;
            this.songXmlBrowseButton.Click += new System.EventHandler(this.songXmlBrowseButton_Click);
            // 
            // addArrangementButton
            // 
            this.addArrangementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addArrangementButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addArrangementButton.Location = new System.Drawing.Point(291, 391);
            this.addArrangementButton.Name = "addArrangementButton";
            this.addArrangementButton.Size = new System.Drawing.Size(72, 29);
            this.addArrangementButton.TabIndex = 19;
            this.addArrangementButton.Text = "Ok";
            this.addArrangementButton.UseVisualStyleBackColor = false;
            this.addArrangementButton.Click += new System.EventHandler(this.addArrangementButton_Click);
            // 
            // arrangementTypeCombo
            // 
            this.arrangementTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrangementTypeCombo.FormattingEnabled = true;
            this.arrangementTypeCombo.Location = new System.Drawing.Point(54, 18);
            this.arrangementTypeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.arrangementTypeCombo.Name = "arrangementTypeCombo";
            this.arrangementTypeCombo.Size = new System.Drawing.Size(134, 21);
            this.arrangementTypeCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cancelButton.Location = new System.Drawing.Point(369, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 29);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // toneBaseCombo
            // 
            this.toneBaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneBaseCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneBaseCombo.FormattingEnabled = true;
            this.toneBaseCombo.Location = new System.Drawing.Point(72, 19);
            this.toneBaseCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneBaseCombo.Name = "toneBaseCombo";
            this.toneBaseCombo.Size = new System.Drawing.Size(134, 21);
            this.toneBaseCombo.TabIndex = 11;
            // 
            // scrollSpeedTrackBar
            // 
            this.scrollSpeedTrackBar.AutoSize = false;
            this.scrollSpeedTrackBar.Location = new System.Drawing.Point(42, 18);
            this.scrollSpeedTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.scrollSpeedTrackBar.Maximum = 45;
            this.scrollSpeedTrackBar.Minimum = 10;
            this.scrollSpeedTrackBar.Name = "scrollSpeedTrackBar";
            this.scrollSpeedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scrollSpeedTrackBar.Size = new System.Drawing.Size(130, 23);
            this.scrollSpeedTrackBar.TabIndex = 5;
            this.scrollSpeedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scrollSpeedTrackBar.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Slowest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(169, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fastest";
            // 
            // scrollSpeedDisplay
            // 
            this.scrollSpeedDisplay.AutoSize = true;
            this.scrollSpeedDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scrollSpeedDisplay.Location = new System.Drawing.Point(71, 39);
            this.scrollSpeedDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrollSpeedDisplay.Name = "scrollSpeedDisplay";
            this.scrollSpeedDisplay.Size = new System.Drawing.Size(71, 13);
            this.scrollSpeedDisplay.TabIndex = 36;
            this.scrollSpeedDisplay.Text = "{Scroll Value}";
            // 
            // Picked
            // 
            this.Picked.AutoSize = true;
            this.Picked.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Picked.Location = new System.Drawing.Point(340, 79);
            this.Picked.Name = "Picked";
            this.Picked.Size = new System.Drawing.Size(85, 17);
            this.Picked.TabIndex = 7;
            this.Picked.Text = "Bass Picked";
            this.Picked.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Name:";
            // 
            // arrangementNameCombo
            // 
            this.arrangementNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrangementNameCombo.FormattingEnabled = true;
            this.arrangementNameCombo.Location = new System.Drawing.Point(54, 47);
            this.arrangementNameCombo.Margin = new System.Windows.Forms.Padding(2);
            this.arrangementNameCombo.Name = "arrangementNameCombo";
            this.arrangementNameCombo.Size = new System.Drawing.Size(134, 21);
            this.arrangementNameCombo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tuning:";
            // 
            // tuningComboBox
            // 
            this.tuningComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tuningComboBox.FormattingEnabled = true;
            this.tuningComboBox.Location = new System.Drawing.Point(54, 76);
            this.tuningComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tuningComboBox.Name = "tuningComboBox";
            this.tuningComboBox.Size = new System.Drawing.Size(134, 21);
            this.tuningComboBox.TabIndex = 4;
            // 
            // gbTone
            // 
            this.gbTone.Controls.Add(this.label10);
            this.gbTone.Controls.Add(this.toneDCombo);
            this.gbTone.Controls.Add(this.label11);
            this.gbTone.Controls.Add(this.toneCCombo);
            this.gbTone.Controls.Add(this.label12);
            this.gbTone.Controls.Add(this.toneMultiplayerCombo);
            this.gbTone.Controls.Add(this.label9);
            this.gbTone.Controls.Add(this.toneBCombo);
            this.gbTone.Controls.Add(this.label8);
            this.gbTone.Controls.Add(this.toneACombo);
            this.gbTone.Controls.Add(this.lblToneA);
            this.gbTone.Controls.Add(this.toneBaseCombo);
            this.gbTone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbTone.Location = new System.Drawing.Point(6, 226);
            this.gbTone.Name = "gbTone";
            this.gbTone.Size = new System.Drawing.Size(435, 101);
            this.gbTone.TabIndex = 42;
            this.gbTone.TabStop = false;
            this.gbTone.Text = "Tone Selector";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(217, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tone D:";
            // 
            // toneDCombo
            // 
            this.toneDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneDCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneDCombo.FormattingEnabled = true;
            this.toneDCombo.Location = new System.Drawing.Point(291, 69);
            this.toneDCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneDCombo.Name = "toneDCombo";
            this.toneDCombo.Size = new System.Drawing.Size(134, 21);
            this.toneDCombo.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(217, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tone C:";
            // 
            // toneCCombo
            // 
            this.toneCCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneCCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneCCombo.FormattingEnabled = true;
            this.toneCCombo.Location = new System.Drawing.Point(291, 44);
            this.toneCCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneCCombo.Name = "toneCCombo";
            this.toneCCombo.Size = new System.Drawing.Size(134, 21);
            this.toneCCombo.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(217, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Multiplayer:";
            // 
            // toneMultiplayerCombo
            // 
            this.toneMultiplayerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneMultiplayerCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneMultiplayerCombo.FormattingEnabled = true;
            this.toneMultiplayerCombo.Location = new System.Drawing.Point(291, 19);
            this.toneMultiplayerCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneMultiplayerCombo.Name = "toneMultiplayerCombo";
            this.toneMultiplayerCombo.Size = new System.Drawing.Size(134, 21);
            this.toneMultiplayerCombo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Tone B:";
            // 
            // toneBCombo
            // 
            this.toneBCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneBCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneBCombo.FormattingEnabled = true;
            this.toneBCombo.Location = new System.Drawing.Point(72, 69);
            this.toneBCombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneBCombo.Name = "toneBCombo";
            this.toneBCombo.Size = new System.Drawing.Size(134, 21);
            this.toneBCombo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tone A:";
            // 
            // toneACombo
            // 
            this.toneACombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toneACombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toneACombo.FormattingEnabled = true;
            this.toneACombo.Location = new System.Drawing.Point(72, 44);
            this.toneACombo.Margin = new System.Windows.Forms.Padding(2);
            this.toneACombo.Name = "toneACombo";
            this.toneACombo.Size = new System.Drawing.Size(134, 21);
            this.toneACombo.TabIndex = 12;
            // 
            // lblToneA
            // 
            this.lblToneA.AutoSize = true;
            this.lblToneA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToneA.Location = new System.Drawing.Point(6, 22);
            this.lblToneA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToneA.Name = "lblToneA";
            this.lblToneA.Size = new System.Drawing.Size(34, 13);
            this.lblToneA.TabIndex = 45;
            this.lblToneA.Text = "Base:";
            // 
            // gbDLCId
            // 
            this.gbDLCId.Controls.Add(this.PersistentId);
            this.gbDLCId.Controls.Add(this.MasterId);
            this.gbDLCId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbDLCId.Location = new System.Drawing.Point(6, 333);
            this.gbDLCId.Name = "gbDLCId";
            this.gbDLCId.Size = new System.Drawing.Size(435, 47);
            this.gbDLCId.TabIndex = 33;
            this.gbDLCId.TabStop = false;
            this.gbDLCId.Text = "DLC ID (MasterID / PersistentID)";
            this.gbDLCId.Enter += new System.EventHandler(this.GroupBox3Enter);
            // 
            // PersistentId
            // 
            this.PersistentId.Cue = "PersistentID";
            this.PersistentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PersistentId.ForeColor = System.Drawing.Color.Gray;
            this.PersistentId.Location = new System.Drawing.Point(156, 19);
            this.PersistentId.Name = "PersistentId";
            this.PersistentId.Size = new System.Drawing.Size(269, 20);
            this.PersistentId.TabIndex = 18;
            // 
            // MasterId
            // 
            this.MasterId.Cue = "MasterID";
            this.MasterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MasterId.ForeColor = System.Drawing.Color.Gray;
            this.MasterId.Location = new System.Drawing.Point(6, 19);
            this.MasterId.Name = "MasterId";
            this.MasterId.Size = new System.Drawing.Size(144, 20);
            this.MasterId.TabIndex = 17;
            // 
            // gbXmlDefinition
            // 
            this.gbXmlDefinition.Controls.Add(this.XmlFilePath);
            this.gbXmlDefinition.Controls.Add(this.songXmlBrowseButton);
            this.gbXmlDefinition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbXmlDefinition.Location = new System.Drawing.Point(6, 11);
            this.gbXmlDefinition.Name = "gbXmlDefinition";
            this.gbXmlDefinition.Size = new System.Drawing.Size(435, 46);
            this.gbXmlDefinition.TabIndex = 44;
            this.gbXmlDefinition.TabStop = false;
            this.gbXmlDefinition.Text = "Song XML File";
            // 
            // XmlFilePath
            // 
            this.XmlFilePath.Cue = "Song Xml File (*.xml)";
            this.XmlFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.XmlFilePath.ForeColor = System.Drawing.Color.Gray;
            this.XmlFilePath.Location = new System.Drawing.Point(10, 17);
            this.XmlFilePath.Name = "XmlFilePath";
            this.XmlFilePath.Size = new System.Drawing.Size(347, 20);
            this.XmlFilePath.TabIndex = 0;
            // 
            // gbArrInfo
            // 
            this.gbArrInfo.Controls.Add(this.gbScrollSpeed);
            this.gbArrInfo.Controls.Add(this.label4);
            this.gbArrInfo.Controls.Add(this.arrangementTypeCombo);
            this.gbArrInfo.Controls.Add(this.label1);
            this.gbArrInfo.Controls.Add(this.Picked);
            this.gbArrInfo.Controls.Add(this.arrangementNameCombo);
            this.gbArrInfo.Controls.Add(this.label6);
            this.gbArrInfo.Controls.Add(this.tuningComboBox);
            this.gbArrInfo.Controls.Add(this.RelativeDifficulty);
            this.gbArrInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbArrInfo.Location = new System.Drawing.Point(6, 64);
            this.gbArrInfo.Name = "gbArrInfo";
            this.gbArrInfo.Size = new System.Drawing.Size(435, 106);
            this.gbArrInfo.TabIndex = 45;
            this.gbArrInfo.TabStop = false;
            this.gbArrInfo.Text = "Arrangement Information";
            // 
            // gbScrollSpeed
            // 
            this.gbScrollSpeed.Controls.Add(this.scrollSpeedTrackBar);
            this.gbScrollSpeed.Controls.Add(this.label5);
            this.gbScrollSpeed.Controls.Add(this.label3);
            this.gbScrollSpeed.Controls.Add(this.scrollSpeedDisplay);
            this.gbScrollSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbScrollSpeed.Location = new System.Drawing.Point(201, 12);
            this.gbScrollSpeed.Name = "gbScrollSpeed";
            this.gbScrollSpeed.Size = new System.Drawing.Size(224, 60);
            this.gbScrollSpeed.TabIndex = 42;
            this.gbScrollSpeed.TabStop = false;
            this.gbScrollSpeed.Text = "Scroll Speed";
            // 
            // RelativeDifficulty
            // 
            this.RelativeDifficulty.Cue = "Difficulty";
            this.RelativeDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RelativeDifficulty.ForeColor = System.Drawing.Color.Gray;
            this.RelativeDifficulty.Location = new System.Drawing.Point(201, 77);
            this.RelativeDifficulty.Name = "RelativeDifficulty";
            this.RelativeDifficulty.Size = new System.Drawing.Size(126, 20);
            this.RelativeDifficulty.TabIndex = 6;
            // 
            // gbGameplayPath
            // 
            this.gbGameplayPath.Controls.Add(this.pathBassCheckbox);
            this.gbGameplayPath.Controls.Add(this.pathRhythmCheckbox);
            this.gbGameplayPath.Controls.Add(this.pathLeadCheckbox);
            this.gbGameplayPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbGameplayPath.Location = new System.Drawing.Point(6, 176);
            this.gbGameplayPath.Name = "gbGameplayPath";
            this.gbGameplayPath.Size = new System.Drawing.Size(435, 44);
            this.gbGameplayPath.TabIndex = 34;
            this.gbGameplayPath.TabStop = false;
            this.gbGameplayPath.Text = "Gameplay Path";
            // 
            // pathBassCheckbox
            // 
            this.pathBassCheckbox.AutoSize = true;
            this.pathBassCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathBassCheckbox.Location = new System.Drawing.Point(278, 19);
            this.pathBassCheckbox.Name = "pathBassCheckbox";
            this.pathBassCheckbox.Size = new System.Drawing.Size(49, 17);
            this.pathBassCheckbox.TabIndex = 10;
            this.pathBassCheckbox.Text = "Bass";
            this.pathBassCheckbox.UseVisualStyleBackColor = true;
            // 
            // pathRhythmCheckbox
            // 
            this.pathRhythmCheckbox.AutoSize = true;
            this.pathRhythmCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathRhythmCheckbox.Location = new System.Drawing.Point(187, 19);
            this.pathRhythmCheckbox.Name = "pathRhythmCheckbox";
            this.pathRhythmCheckbox.Size = new System.Drawing.Size(62, 17);
            this.pathRhythmCheckbox.TabIndex = 9;
            this.pathRhythmCheckbox.Text = "Rhythm";
            this.pathRhythmCheckbox.UseVisualStyleBackColor = true;
            // 
            // pathLeadCheckbox
            // 
            this.pathLeadCheckbox.AutoSize = true;
            this.pathLeadCheckbox.Checked = true;
            this.pathLeadCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pathLeadCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathLeadCheckbox.Location = new System.Drawing.Point(100, 19);
            this.pathLeadCheckbox.Name = "pathLeadCheckbox";
            this.pathLeadCheckbox.Size = new System.Drawing.Size(50, 17);
            this.pathLeadCheckbox.TabIndex = 8;
            this.pathLeadCheckbox.Text = "Lead";
            this.pathLeadCheckbox.UseVisualStyleBackColor = true;
            // 
            // ArrangementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 432);
            this.Controls.Add(this.gbGameplayPath);
            this.Controls.Add(this.gbArrInfo);
            this.Controls.Add(this.gbXmlDefinition);
            this.Controls.Add(this.gbDLCId);
            this.Controls.Add(this.gbTone);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addArrangementButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrangementForm";
            this.Text = "Add Arrangement";
            ((System.ComponentModel.ISupportInitialize)(this.scrollSpeedTrackBar)).EndInit();
            this.gbTone.ResumeLayout(false);
            this.gbTone.PerformLayout();
            this.gbDLCId.ResumeLayout(false);
            this.gbDLCId.PerformLayout();
            this.gbXmlDefinition.ResumeLayout(false);
            this.gbXmlDefinition.PerformLayout();
            this.gbArrInfo.ResumeLayout(false);
            this.gbArrInfo.PerformLayout();
            this.gbScrollSpeed.ResumeLayout(false);
            this.gbScrollSpeed.PerformLayout();
            this.gbGameplayPath.ResumeLayout(false);
            this.gbGameplayPath.PerformLayout();
            this.ResumeLayout(false);

        }
        private RocksmithToolkitGUI.CueTextBox PersistentId;
        private RocksmithToolkitGUI.CueTextBox MasterId;
        private System.Windows.Forms.GroupBox gbDLCId;

        #endregion

        private CueTextBox XmlFilePath;
        private System.Windows.Forms.Button songXmlBrowseButton;
        private System.Windows.Forms.Button addArrangementButton;
        private CueTextBox RelativeDifficulty;
        private System.Windows.Forms.ComboBox arrangementTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox toneBaseCombo;
        private System.Windows.Forms.TrackBar scrollSpeedTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scrollSpeedDisplay;
        private System.Windows.Forms.CheckBox Picked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox arrangementNameCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tuningComboBox;
        private System.Windows.Forms.GroupBox gbTone;
        
        void GroupBox3Enter(object sender, System.EventArgs e)
        {
        	
        }

        private System.Windows.Forms.Label lblToneA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox toneDCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox toneCCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox toneMultiplayerCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox toneBCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox toneACombo;
        private System.Windows.Forms.GroupBox gbXmlDefinition;
        private System.Windows.Forms.GroupBox gbArrInfo;
        private System.Windows.Forms.GroupBox gbScrollSpeed;
        private System.Windows.Forms.GroupBox gbGameplayPath;
        private System.Windows.Forms.CheckBox pathBassCheckbox;
        private System.Windows.Forms.CheckBox pathRhythmCheckbox;
        private System.Windows.Forms.CheckBox pathLeadCheckbox;
    }
}