// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 02-01-2018
// ***********************************************************************
// <copyright file="PolygonEditorDialog.Designer.cs" company="Zeroit Dev Technologies">
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
    partial class PolygonEditorDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.gridSplit = new System.Windows.Forms.SplitContainer();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.imageSplit = new System.Windows.Forms.SplitContainer();
            this.imagePanel = new Zeroit.Framework.FormEditors.NoFlickerPanel();
            this.controlSplit1 = new System.Windows.Forms.SplitContainer();
            this.controlSplit2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.axesCheckBox = new System.Windows.Forms.CheckBox();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.infoSplit = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.dragControl1 = new Zeroit.Framework.FormEditors.DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplit)).BeginInit();
            this.gridSplit.Panel1.SuspendLayout();
            this.gridSplit.Panel2.SuspendLayout();
            this.gridSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSplit)).BeginInit();
            this.imageSplit.Panel1.SuspendLayout();
            this.imageSplit.Panel2.SuspendLayout();
            this.imageSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlSplit1)).BeginInit();
            this.controlSplit1.Panel1.SuspendLayout();
            this.controlSplit1.Panel2.SuspendLayout();
            this.controlSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlSplit2)).BeginInit();
            this.controlSplit2.Panel1.SuspendLayout();
            this.controlSplit2.Panel2.SuspendLayout();
            this.controlSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSplit)).BeginInit();
            this.infoSplit.Panel1.SuspendLayout();
            this.infoSplit.Panel2.SuspendLayout();
            this.infoSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplit.IsSplitterFixed = true;
            this.mainSplit.Location = new System.Drawing.Point(0, 0);
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.gridSplit);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.imageSplit);
            this.mainSplit.Size = new System.Drawing.Size(408, 301);
            this.mainSplit.SplitterDistance = 97;
            this.mainSplit.TabIndex = 1;
            // 
            // gridSplit
            // 
            this.gridSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.gridSplit.IsSplitterFixed = true;
            this.gridSplit.Location = new System.Drawing.Point(0, 0);
            this.gridSplit.Name = "gridSplit";
            this.gridSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // gridSplit.Panel1
            // 
            this.gridSplit.Panel1.Controls.Add(this.grid);
            // 
            // gridSplit.Panel2
            // 
            this.gridSplit.Panel2.Controls.Add(this.cancelButton);
            this.gridSplit.Panel2.Controls.Add(this.okButton);
            this.gridSplit.Panel2.Controls.Add(this.downButton);
            this.gridSplit.Panel2.Controls.Add(this.addButton);
            this.gridSplit.Panel2.Controls.Add(this.delButton);
            this.gridSplit.Panel2.Controls.Add(this.upButton);
            this.gridSplit.Size = new System.Drawing.Size(97, 301);
            this.gridSplit.SplitterDistance = 194;
            this.gridSplit.TabIndex = 6;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX,
            this.colY});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(97, 194);
            this.grid.TabIndex = 1;
            this.grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValidated);
            this.grid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grid_CellValidating);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // colX
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colX.DefaultCellStyle = dataGridViewCellStyle5;
            this.colX.HeaderText = "X";
            this.colX.Name = "colX";
            // 
            // colY
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colY.DefaultCellStyle = dataGridViewCellStyle6;
            this.colY.HeaderText = "Y";
            this.colY.Name = "colY";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SlateGray;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(16, 77);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okButton.Location = new System.Drawing.Point(16, 52);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(64, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(48, 24);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(48, 25);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "&Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(48, 25);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(48, 0);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(48, 25);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "D&el";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(0, 24);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(48, 25);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "&Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // imageSplit
            // 
            this.imageSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.imageSplit.IsSplitterFixed = true;
            this.imageSplit.Location = new System.Drawing.Point(0, 0);
            this.imageSplit.Name = "imageSplit";
            this.imageSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // imageSplit.Panel1
            // 
            this.imageSplit.Panel1.Controls.Add(this.imagePanel);
            // 
            // imageSplit.Panel2
            // 
            this.imageSplit.Panel2.Controls.Add(this.controlSplit1);
            this.imageSplit.Size = new System.Drawing.Size(307, 301);
            this.imageSplit.SplitterDistance = 248;
            this.imageSplit.TabIndex = 1;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.DimGray;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(307, 248);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.SizeChanged += new System.EventHandler(this.imagePanel_SizeChanged);
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint);
            // 
            // controlSplit1
            // 
            this.controlSplit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSplit1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.controlSplit1.IsSplitterFixed = true;
            this.controlSplit1.Location = new System.Drawing.Point(0, 0);
            this.controlSplit1.Name = "controlSplit1";
            // 
            // controlSplit1.Panel1
            // 
            this.controlSplit1.Panel1.Controls.Add(this.controlSplit2);
            // 
            // controlSplit1.Panel2
            // 
            this.controlSplit1.Panel2.Controls.Add(this.axesCheckBox);
            this.controlSplit1.Panel2.Controls.Add(this.gridCheckBox);
            this.controlSplit1.Size = new System.Drawing.Size(307, 49);
            this.controlSplit1.SplitterDistance = 241;
            this.controlSplit1.TabIndex = 4;
            // 
            // controlSplit2
            // 
            this.controlSplit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSplit2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.controlSplit2.IsSplitterFixed = true;
            this.controlSplit2.Location = new System.Drawing.Point(0, 0);
            this.controlSplit2.Name = "controlSplit2";
            // 
            // controlSplit2.Panel1
            // 
            this.controlSplit2.Panel1.Controls.Add(this.label1);
            this.controlSplit2.Panel1.Controls.Add(this.zoomLabel);
            // 
            // controlSplit2.Panel2
            // 
            this.controlSplit2.Panel2.Controls.Add(this.zoomTrackBar);
            this.controlSplit2.Size = new System.Drawing.Size(241, 49);
            this.controlSplit2.SplitterDistance = 48;
            this.controlSplit2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomLabel
            // 
            this.zoomLabel.Location = new System.Drawing.Point(0, 24);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(48, 21);
            this.zoomLabel.TabIndex = 2;
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomTrackBar.Location = new System.Drawing.Point(0, 0);
            this.zoomTrackBar.Maximum = 23;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(189, 49);
            this.zoomTrackBar.TabIndex = 1;
            this.zoomTrackBar.Value = 10;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // axesCheckBox
            // 
            this.axesCheckBox.Checked = true;
            this.axesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.axesCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.axesCheckBox.Location = new System.Drawing.Point(0, 0);
            this.axesCheckBox.Name = "axesCheckBox";
            this.axesCheckBox.Size = new System.Drawing.Size(56, 21);
            this.axesCheckBox.TabIndex = 2;
            this.axesCheckBox.Text = "Axes";
            this.axesCheckBox.UseVisualStyleBackColor = true;
            this.axesCheckBox.CheckedChanged += new System.EventHandler(this.axesCheckBox_CheckedChanged);
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.Checked = true;
            this.gridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.gridCheckBox.Location = new System.Drawing.Point(0, 24);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(56, 21);
            this.gridCheckBox.TabIndex = 3;
            this.gridCheckBox.Text = "Grid";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.infoSplit);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 39);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(4);
            this.panel.Size = new System.Drawing.Size(416, 345);
            this.panel.TabIndex = 2;
            // 
            // infoSplit
            // 
            this.infoSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.infoSplit.IsSplitterFixed = true;
            this.infoSplit.Location = new System.Drawing.Point(4, 4);
            this.infoSplit.Name = "infoSplit";
            this.infoSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // infoSplit.Panel1
            // 
            this.infoSplit.Panel1.Controls.Add(this.label3);
            // 
            // infoSplit.Panel2
            // 
            this.infoSplit.Panel2.Controls.Add(this.mainSplit);
            this.infoSplit.Size = new System.Drawing.Size(408, 337);
            this.infoSplit.SplitterDistance = 32;
            this.infoSplit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create and edit the polygon by entering the coordinates of the points which make " +
    "up the polygon.";
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.formName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.formName.Location = new System.Drawing.Point(3, 3);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(120, 21);
            this.formName.TabIndex = 18;
            this.formName.Text = "Polygon Editor";
            this.formName.Click += new System.EventHandler(this.formName_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseBtn.Location = new System.Drawing.Point(388, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
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
            // PolygonEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(416, 384);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PolygonEditorDialog";
            this.Text = "Polygon Editor";
            this.Load += new System.EventHandler(this.PolygonEditorDialog_Load);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.gridSplit.Panel1.ResumeLayout(false);
            this.gridSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplit)).EndInit();
            this.gridSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.imageSplit.Panel1.ResumeLayout(false);
            this.imageSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSplit)).EndInit();
            this.imageSplit.ResumeLayout(false);
            this.controlSplit1.Panel1.ResumeLayout(false);
            this.controlSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlSplit1)).EndInit();
            this.controlSplit1.ResumeLayout(false);
            this.controlSplit2.Panel1.ResumeLayout(false);
            this.controlSplit2.Panel2.ResumeLayout(false);
            this.controlSplit2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlSplit2)).EndInit();
            this.controlSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.panel.ResumeLayout(false);
            this.infoSplit.Panel1.ResumeLayout(false);
            this.infoSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSplit)).EndInit();
            this.infoSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.CheckBox axesCheckBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer gridSplit;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private NoFlickerPanel imagePanel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.SplitContainer imageSplit;
        private System.Windows.Forms.SplitContainer infoSplit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer controlSplit1;
        private System.Windows.Forms.SplitContainer controlSplit2;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private DragControl dragControl1;
    }
}