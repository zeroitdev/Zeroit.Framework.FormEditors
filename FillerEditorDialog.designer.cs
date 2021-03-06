// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-19-2017
// ***********************************************************************
// <copyright file="FillerEditorDialog.designer.cs" company="Zeroit Dev Technologies">
//    This program is that contains various editors for drawing and painting.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.FormEditors
{
    partial class FillerEditorDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillerEditorDialog));
            System.Drawing.Drawing2D.ColorBlend colorBlend1 = new System.Drawing.Drawing2D.ColorBlend();
            this.emptyRadioButton = new System.Windows.Forms.RadioButton();
            this.solidRadioButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.gradientRadioButton = new System.Windows.Forms.RadioButton();
            this.hatchRadioButton = new System.Windows.Forms.RadioButton();
            this.solidGroupBox = new System.Windows.Forms.GroupBox();
            this.sampleSolidPanel = new System.Windows.Forms.Label();
            this.opacityPreLabel = new System.Windows.Forms.Label();
            this.solidAlphaNud = new System.Windows.Forms.NumericUpDown();
            this.solidColorButton = new System.Windows.Forms.Button();
            this.solidColorLabel = new System.Windows.Forms.Label();
            this.solidColorTextLabel = new System.Windows.Forms.Label();
            this.hatchGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backAlphaNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hatchAlphaNud = new System.Windows.Forms.NumericUpDown();
            this.hatchComboBox = new Zeroit.Framework.FormEditors.HatchStyleComboBox();
            this.sampleHatchPanel = new Zeroit.Framework.FormEditors.HatchStylePanel();
            this.hatchPatternTextLabel = new System.Windows.Forms.Label();
            this.backColorButton = new System.Windows.Forms.Button();
            this.backColorLabel = new System.Windows.Forms.Label();
            this.backColorTextLabel = new System.Windows.Forms.Label();
            this.hatchColorButton = new System.Windows.Forms.Button();
            this.hatchColorLabel = new System.Windows.Forms.Label();
            this.hatchColorTextLabel = new System.Windows.Forms.Label();
            this.gradientGroupBox = new System.Windows.Forms.GroupBox();
            this.gradientTypeComboBox = new System.Windows.Forms.ComboBox();
            this.gradientAngleNud = new System.Windows.Forms.NumericUpDown();
            this.gradientAngleTextLabel = new System.Windows.Forms.Label();
            this.gradientTypeTextLabel = new System.Windows.Forms.Label();
            this.gradientEditor = new Zeroit.Framework.FormEditors.ColorGradientEditor();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.dragControl1 = new Zeroit.Framework.FormEditors.DragControl(this.components);
            this.typeGroupBox.SuspendLayout();
            this.solidGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solidAlphaNud)).BeginInit();
            this.hatchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backAlphaNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hatchAlphaNud)).BeginInit();
            this.gradientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientAngleNud)).BeginInit();
            this.SuspendLayout();
            // 
            // emptyRadioButton
            // 
            this.emptyRadioButton.Location = new System.Drawing.Point(16, 16);
            this.emptyRadioButton.Name = "emptyRadioButton";
            this.emptyRadioButton.Size = new System.Drawing.Size(128, 24);
            this.emptyRadioButton.TabIndex = 0;
            this.emptyRadioButton.TabStop = true;
            this.emptyRadioButton.Text = "Empty (transparent)";
            this.emptyRadioButton.UseVisualStyleBackColor = true;
            // 
            // solidRadioButton
            // 
            this.solidRadioButton.ForeColor = System.Drawing.Color.White;
            this.solidRadioButton.Location = new System.Drawing.Point(16, 48);
            this.solidRadioButton.Name = "solidRadioButton";
            this.solidRadioButton.Size = new System.Drawing.Size(120, 24);
            this.solidRadioButton.TabIndex = 1;
            this.solidRadioButton.TabStop = true;
            this.solidRadioButton.Text = "Solid (one color)";
            this.solidRadioButton.UseVisualStyleBackColor = true;
            this.solidRadioButton.CheckedChanged += new System.EventHandler(this.fillerTypeChanged);
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.ForeColor = System.Drawing.Color.White;
            this.noneRadioButton.Location = new System.Drawing.Point(16, 24);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(120, 24);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None (transparent)";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            this.noneRadioButton.CheckedChanged += new System.EventHandler(this.fillerTypeChanged);
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.gradientRadioButton);
            this.typeGroupBox.Controls.Add(this.hatchRadioButton);
            this.typeGroupBox.Controls.Add(this.noneRadioButton);
            this.typeGroupBox.Controls.Add(this.solidRadioButton);
            this.typeGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.typeGroupBox.Location = new System.Drawing.Point(8, 44);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(144, 128);
            this.typeGroupBox.TabIndex = 0;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = " Fill Type ";
            // 
            // gradientRadioButton
            // 
            this.gradientRadioButton.ForeColor = System.Drawing.Color.White;
            this.gradientRadioButton.Location = new System.Drawing.Point(16, 96);
            this.gradientRadioButton.Name = "gradientRadioButton";
            this.gradientRadioButton.Size = new System.Drawing.Size(120, 24);
            this.gradientRadioButton.TabIndex = 3;
            this.gradientRadioButton.TabStop = true;
            this.gradientRadioButton.Text = "Gradient";
            this.gradientRadioButton.UseVisualStyleBackColor = true;
            this.gradientRadioButton.CheckedChanged += new System.EventHandler(this.fillerTypeChanged);
            // 
            // hatchRadioButton
            // 
            this.hatchRadioButton.ForeColor = System.Drawing.Color.White;
            this.hatchRadioButton.Location = new System.Drawing.Point(16, 72);
            this.hatchRadioButton.Name = "hatchRadioButton";
            this.hatchRadioButton.Size = new System.Drawing.Size(120, 24);
            this.hatchRadioButton.TabIndex = 2;
            this.hatchRadioButton.TabStop = true;
            this.hatchRadioButton.Text = "Hatch pattern";
            this.hatchRadioButton.UseVisualStyleBackColor = true;
            this.hatchRadioButton.CheckedChanged += new System.EventHandler(this.fillerTypeChanged);
            // 
            // solidGroupBox
            // 
            this.solidGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.solidGroupBox.Controls.Add(this.sampleSolidPanel);
            this.solidGroupBox.Controls.Add(this.opacityPreLabel);
            this.solidGroupBox.Controls.Add(this.solidAlphaNud);
            this.solidGroupBox.Controls.Add(this.solidColorButton);
            this.solidGroupBox.Controls.Add(this.solidColorLabel);
            this.solidGroupBox.Controls.Add(this.solidColorTextLabel);
            this.solidGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.solidGroupBox.Location = new System.Drawing.Point(160, 45);
            this.solidGroupBox.Name = "solidGroupBox";
            this.solidGroupBox.Size = new System.Drawing.Size(352, 88);
            this.solidGroupBox.TabIndex = 3;
            this.solidGroupBox.TabStop = false;
            this.solidGroupBox.Text = " Solid (one color) ";
            // 
            // sampleSolidPanel
            // 
            this.sampleSolidPanel.Location = new System.Drawing.Point(208, 24);
            this.sampleSolidPanel.Name = "sampleSolidPanel";
            this.sampleSolidPanel.Size = new System.Drawing.Size(128, 48);
            this.sampleSolidPanel.TabIndex = 11;
            this.sampleSolidPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opacityPreLabel
            // 
            this.opacityPreLabel.ForeColor = System.Drawing.Color.White;
            this.opacityPreLabel.Location = new System.Drawing.Point(48, 52);
            this.opacityPreLabel.Name = "opacityPreLabel";
            this.opacityPreLabel.Size = new System.Drawing.Size(48, 21);
            this.opacityPreLabel.TabIndex = 9;
            this.opacityPreLabel.Text = "Alpha:";
            this.opacityPreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // solidAlphaNud
            // 
            this.solidAlphaNud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.solidAlphaNud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solidAlphaNud.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.solidAlphaNud.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.solidAlphaNud.Location = new System.Drawing.Point(96, 55);
            this.solidAlphaNud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.solidAlphaNud.Name = "solidAlphaNud";
            this.solidAlphaNud.Size = new System.Drawing.Size(48, 18);
            this.solidAlphaNud.TabIndex = 10;
            this.solidAlphaNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.solidAlphaNud.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.solidAlphaNud.ValueChanged += new System.EventHandler(this.solidAlphaNud_ValueChanged);
            // 
            // solidColorButton
            // 
            this.solidColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("solidColorButton.BackgroundImage")));
            this.solidColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.solidColorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.solidColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solidColorButton.Location = new System.Drawing.Point(168, 24);
            this.solidColorButton.Name = "solidColorButton";
            this.solidColorButton.Size = new System.Drawing.Size(24, 23);
            this.solidColorButton.TabIndex = 3;
            this.solidColorButton.UseVisualStyleBackColor = true;
            this.solidColorButton.Click += new System.EventHandler(this.solidColorButton_Click);
            this.solidColorButton.MouseEnter += new System.EventHandler(this.solidColorButton_MouseEnter);
            this.solidColorButton.MouseLeave += new System.EventHandler(this.solidColorButton_MouseLeave);
            // 
            // solidColorLabel
            // 
            this.solidColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solidColorLabel.Location = new System.Drawing.Point(96, 24);
            this.solidColorLabel.Name = "solidColorLabel";
            this.solidColorLabel.Size = new System.Drawing.Size(72, 23);
            this.solidColorLabel.TabIndex = 2;
            this.solidColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solidColorTextLabel
            // 
            this.solidColorTextLabel.ForeColor = System.Drawing.Color.White;
            this.solidColorTextLabel.Location = new System.Drawing.Point(8, 24);
            this.solidColorTextLabel.Name = "solidColorTextLabel";
            this.solidColorTextLabel.Size = new System.Drawing.Size(88, 23);
            this.solidColorTextLabel.TabIndex = 1;
            this.solidColorTextLabel.Text = "Color: ";
            this.solidColorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hatchGroupBox
            // 
            this.hatchGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hatchGroupBox.Controls.Add(this.label4);
            this.hatchGroupBox.Controls.Add(this.backAlphaNud);
            this.hatchGroupBox.Controls.Add(this.label1);
            this.hatchGroupBox.Controls.Add(this.hatchAlphaNud);
            this.hatchGroupBox.Controls.Add(this.hatchComboBox);
            this.hatchGroupBox.Controls.Add(this.sampleHatchPanel);
            this.hatchGroupBox.Controls.Add(this.hatchPatternTextLabel);
            this.hatchGroupBox.Controls.Add(this.backColorButton);
            this.hatchGroupBox.Controls.Add(this.backColorLabel);
            this.hatchGroupBox.Controls.Add(this.backColorTextLabel);
            this.hatchGroupBox.Controls.Add(this.hatchColorButton);
            this.hatchGroupBox.Controls.Add(this.hatchColorLabel);
            this.hatchGroupBox.Controls.Add(this.hatchColorTextLabel);
            this.hatchGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.hatchGroupBox.Location = new System.Drawing.Point(160, 141);
            this.hatchGroupBox.Name = "hatchGroupBox";
            this.hatchGroupBox.Size = new System.Drawing.Size(352, 168);
            this.hatchGroupBox.TabIndex = 4;
            this.hatchGroupBox.TabStop = false;
            this.hatchGroupBox.Text = " Hatch pattern ";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alpha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backAlphaNud
            // 
            this.backAlphaNud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.backAlphaNud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backAlphaNud.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.backAlphaNud.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.backAlphaNud.Location = new System.Drawing.Point(96, 111);
            this.backAlphaNud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.backAlphaNud.Name = "backAlphaNud";
            this.backAlphaNud.Size = new System.Drawing.Size(48, 18);
            this.backAlphaNud.TabIndex = 16;
            this.backAlphaNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.backAlphaNud.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.backAlphaNud.ValueChanged += new System.EventHandler(this.backAlphaNud_ValueChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alpha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hatchAlphaNud
            // 
            this.hatchAlphaNud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hatchAlphaNud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hatchAlphaNud.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.hatchAlphaNud.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.hatchAlphaNud.Location = new System.Drawing.Point(96, 55);
            this.hatchAlphaNud.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.hatchAlphaNud.Name = "hatchAlphaNud";
            this.hatchAlphaNud.Size = new System.Drawing.Size(48, 18);
            this.hatchAlphaNud.TabIndex = 13;
            this.hatchAlphaNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hatchAlphaNud.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.hatchAlphaNud.ValueChanged += new System.EventHandler(this.hatchAlphaNud_ValueChanged);
            // 
            // hatchComboBox
            // 
            this.hatchComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hatchComboBox.FormattingEnabled = true;
            this.hatchComboBox.Location = new System.Drawing.Point(96, 136);
            this.hatchComboBox.Name = "hatchComboBox";
            this.hatchComboBox.SelectedHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            this.hatchComboBox.Size = new System.Drawing.Size(96, 21);
            this.hatchComboBox.TabIndex = 10;
            this.hatchComboBox.SelectedIndexChanged += new System.EventHandler(this.hatchComboBox_SelectedIndexChanged);
            // 
            // sampleHatchPanel
            // 
            this.sampleHatchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.sampleHatchPanel.HatchColor = System.Drawing.Color.Black;
            this.sampleHatchPanel.HatchStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.sampleHatchPanel.Location = new System.Drawing.Point(208, 24);
            this.sampleHatchPanel.Name = "sampleHatchPanel";
            this.sampleHatchPanel.Size = new System.Drawing.Size(128, 132);
            this.sampleHatchPanel.TabIndex = 9;
            // 
            // hatchPatternTextLabel
            // 
            this.hatchPatternTextLabel.ForeColor = System.Drawing.Color.White;
            this.hatchPatternTextLabel.Location = new System.Drawing.Point(8, 136);
            this.hatchPatternTextLabel.Name = "hatchPatternTextLabel";
            this.hatchPatternTextLabel.Size = new System.Drawing.Size(88, 23);
            this.hatchPatternTextLabel.TabIndex = 7;
            this.hatchPatternTextLabel.Text = "Hatch pattern:";
            this.hatchPatternTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backColorButton
            // 
            this.backColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backColorButton.BackgroundImage")));
            this.backColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backColorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.backColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backColorButton.Location = new System.Drawing.Point(168, 80);
            this.backColorButton.Name = "backColorButton";
            this.backColorButton.Size = new System.Drawing.Size(24, 23);
            this.backColorButton.TabIndex = 6;
            this.backColorButton.UseVisualStyleBackColor = true;
            this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
            this.backColorButton.MouseEnter += new System.EventHandler(this.backColorButton_MouseEnter);
            this.backColorButton.MouseLeave += new System.EventHandler(this.backColorButton_MouseLeave);
            // 
            // backColorLabel
            // 
            this.backColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backColorLabel.Location = new System.Drawing.Point(96, 80);
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(72, 23);
            this.backColorLabel.TabIndex = 5;
            this.backColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backColorTextLabel
            // 
            this.backColorTextLabel.ForeColor = System.Drawing.Color.White;
            this.backColorTextLabel.Location = new System.Drawing.Point(8, 80);
            this.backColorTextLabel.Name = "backColorTextLabel";
            this.backColorTextLabel.Size = new System.Drawing.Size(88, 23);
            this.backColorTextLabel.TabIndex = 4;
            this.backColorTextLabel.Text = "Back color: ";
            this.backColorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hatchColorButton
            // 
            this.hatchColorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hatchColorButton.BackgroundImage")));
            this.hatchColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hatchColorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hatchColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hatchColorButton.Location = new System.Drawing.Point(168, 24);
            this.hatchColorButton.Name = "hatchColorButton";
            this.hatchColorButton.Size = new System.Drawing.Size(24, 23);
            this.hatchColorButton.TabIndex = 3;
            this.hatchColorButton.UseVisualStyleBackColor = true;
            this.hatchColorButton.Click += new System.EventHandler(this.hatchColorButton_Click);
            this.hatchColorButton.MouseEnter += new System.EventHandler(this.hatchColorButton_MouseEnter);
            this.hatchColorButton.MouseLeave += new System.EventHandler(this.hatchColorButton_MouseLeave);
            // 
            // hatchColorLabel
            // 
            this.hatchColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hatchColorLabel.Location = new System.Drawing.Point(96, 24);
            this.hatchColorLabel.Name = "hatchColorLabel";
            this.hatchColorLabel.Size = new System.Drawing.Size(72, 24);
            this.hatchColorLabel.TabIndex = 2;
            this.hatchColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hatchColorTextLabel
            // 
            this.hatchColorTextLabel.ForeColor = System.Drawing.Color.White;
            this.hatchColorTextLabel.Location = new System.Drawing.Point(8, 24);
            this.hatchColorTextLabel.Name = "hatchColorTextLabel";
            this.hatchColorTextLabel.Size = new System.Drawing.Size(88, 23);
            this.hatchColorTextLabel.TabIndex = 1;
            this.hatchColorTextLabel.Text = "Hatch color: ";
            this.hatchColorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientGroupBox
            // 
            this.gradientGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.gradientGroupBox.Controls.Add(this.gradientTypeComboBox);
            this.gradientGroupBox.Controls.Add(this.gradientAngleNud);
            this.gradientGroupBox.Controls.Add(this.gradientAngleTextLabel);
            this.gradientGroupBox.Controls.Add(this.gradientTypeTextLabel);
            this.gradientGroupBox.Controls.Add(this.gradientEditor);
            this.gradientGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradientGroupBox.Location = new System.Drawing.Point(160, 317);
            this.gradientGroupBox.Name = "gradientGroupBox";
            this.gradientGroupBox.Size = new System.Drawing.Size(352, 192);
            this.gradientGroupBox.TabIndex = 5;
            this.gradientGroupBox.TabStop = false;
            this.gradientGroupBox.Text = " Gradient ";
            // 
            // gradientTypeComboBox
            // 
            this.gradientTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradientTypeComboBox.FormattingEnabled = true;
            this.gradientTypeComboBox.Items.AddRange(new object[] {
            "Linear",
            "PathRect",
            "PathRadial"});
            this.gradientTypeComboBox.Location = new System.Drawing.Point(96, 160);
            this.gradientTypeComboBox.Name = "gradientTypeComboBox";
            this.gradientTypeComboBox.Size = new System.Drawing.Size(104, 21);
            this.gradientTypeComboBox.TabIndex = 2;
            this.gradientTypeComboBox.SelectedValueChanged += new System.EventHandler(this.gradientTypeComboBox_SelectedValueChanged);
            // 
            // gradientAngleNud
            // 
            this.gradientAngleNud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.gradientAngleNud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientAngleNud.DecimalPlaces = 1;
            this.gradientAngleNud.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gradientAngleNud.Location = new System.Drawing.Point(272, 164);
            this.gradientAngleNud.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.gradientAngleNud.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.gradientAngleNud.Name = "gradientAngleNud";
            this.gradientAngleNud.Size = new System.Drawing.Size(64, 18);
            this.gradientAngleNud.TabIndex = 4;
            this.gradientAngleNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gradientAngleTextLabel
            // 
            this.gradientAngleTextLabel.ForeColor = System.Drawing.Color.White;
            this.gradientAngleTextLabel.Location = new System.Drawing.Point(224, 160);
            this.gradientAngleTextLabel.Name = "gradientAngleTextLabel";
            this.gradientAngleTextLabel.Size = new System.Drawing.Size(48, 23);
            this.gradientAngleTextLabel.TabIndex = 3;
            this.gradientAngleTextLabel.Text = "Angle: ";
            this.gradientAngleTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientTypeTextLabel
            // 
            this.gradientTypeTextLabel.ForeColor = System.Drawing.Color.White;
            this.gradientTypeTextLabel.Location = new System.Drawing.Point(16, 160);
            this.gradientTypeTextLabel.Name = "gradientTypeTextLabel";
            this.gradientTypeTextLabel.Size = new System.Drawing.Size(80, 23);
            this.gradientTypeTextLabel.TabIndex = 1;
            this.gradientTypeTextLabel.Text = "Gradient type: ";
            this.gradientTypeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gradientEditor
            // 
            this.gradientEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            colorBlend1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))))};
            colorBlend1.Positions = new float[] {
        0F,
        0.5F,
        1F};
            this.gradientEditor.Blend = colorBlend1;
            this.gradientEditor.GradientBackColor = System.Drawing.Color.White;
            this.gradientEditor.GradientBorderColor = System.Drawing.Color.DarkGray;
            this.gradientEditor.GradientHatchColor = System.Drawing.Color.Black;
            this.gradientEditor.Location = new System.Drawing.Point(16, 24);
            this.gradientEditor.MarkerBorderColor = System.Drawing.Color.Black;
            this.gradientEditor.MarkerFillColor = System.Drawing.Color.White;
            this.gradientEditor.MinimumSize = new System.Drawing.Size(322, 120);
            this.gradientEditor.Name = "gradientEditor";
            this.gradientEditor.SelMarkerFillColor = System.Drawing.Color.Yellow;
            this.gradientEditor.Size = new System.Drawing.Size(322, 120);
            this.gradientEditor.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SlateGray;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(80, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 34);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okButton.Location = new System.Drawing.Point(8, 180);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(67, 34);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseBtn.Location = new System.Drawing.Point(512, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 27);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.formName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.formName.Location = new System.Drawing.Point(1, 3);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(91, 21);
            this.formName.TabIndex = 16;
            this.formName.Text = "Filler Editor";
            // 
            // dragControl1
            // 
            this.dragControl1.Caption = 32;
            this.dragControl1.Fixed = true;
            this.dragControl1.Horizontal = true;
            this.dragControl1.SizeGrip = 10;
            this.dragControl1.TargetControl = this;
            this.dragControl1.Vertical = true;
            // 
            // FillerEditorDialog
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(540, 523);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gradientGroupBox);
            this.Controls.Add(this.hatchGroupBox);
            this.Controls.Add(this.solidGroupBox);
            this.Controls.Add(this.typeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FillerEditorDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Filler Editor";
            this.Load += new System.EventHandler(this.FillerEditorDialog_Load);
            this.typeGroupBox.ResumeLayout(false);
            this.solidGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.solidAlphaNud)).EndInit();
            this.hatchGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backAlphaNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hatchAlphaNud)).EndInit();
            this.gradientGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientAngleNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton emptyRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.RadioButton solidRadioButton;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.RadioButton gradientRadioButton;
        private System.Windows.Forms.RadioButton hatchRadioButton;
        private System.Windows.Forms.GroupBox solidGroupBox;
        private System.Windows.Forms.Button solidColorButton;
        private System.Windows.Forms.Label solidColorLabel;
        private System.Windows.Forms.Label solidColorTextLabel;
        private System.Windows.Forms.GroupBox hatchGroupBox;
        private System.Windows.Forms.Button backColorButton;
        private System.Windows.Forms.Label backColorLabel;
        private System.Windows.Forms.Label backColorTextLabel;
        private System.Windows.Forms.Button hatchColorButton;
        private System.Windows.Forms.Label hatchColorLabel;
        private System.Windows.Forms.Label hatchColorTextLabel;
        private System.Windows.Forms.Label hatchPatternTextLabel;
        private System.Windows.Forms.GroupBox gradientGroupBox;
        private ColorGradientEditor gradientEditor;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private HatchStylePanel sampleHatchPanel;
        private HatchStyleComboBox hatchComboBox;
        private System.Windows.Forms.Label gradientTypeTextLabel;
        private System.Windows.Forms.NumericUpDown gradientAngleNud;
        private System.Windows.Forms.Label gradientAngleTextLabel;
        private System.Windows.Forms.ComboBox gradientTypeComboBox;
        private System.Windows.Forms.Label opacityPreLabel;
        private System.Windows.Forms.NumericUpDown solidAlphaNud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown backAlphaNud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hatchAlphaNud;
        private System.Windows.Forms.Label sampleSolidPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label formName;
        private DragControl dragControl1;
    }
}