// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 07-06-2018
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

namespace Zeroit.Framework.FormEditors.Editors.PolyEditor
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
            this.thematic1501 = new HelperControls.ThemeManagers.SpicyLips();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.axesCheckBox = new System.Windows.Forms.CheckBox();
            this.imagePanel = new Zeroit.Framework.FormEditors.NoFlickerPanel();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.thematic1501.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            this.thematic1501.BackColor = System.Drawing.Color.White;
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Controls.Add(this.zoomTrackBar);
            this.thematic1501.Controls.Add(this.label3);
            this.thematic1501.Controls.Add(this.downButton);
            this.thematic1501.Controls.Add(this.grid);
            this.thematic1501.Controls.Add(this.addButton);
            this.thematic1501.Controls.Add(this.delButton);
            this.thematic1501.Controls.Add(this.cancelButton);
            this.thematic1501.Controls.Add(this.upButton);
            this.thematic1501.Controls.Add(this.zoomLabel);
            this.thematic1501.Controls.Add(this.okButton);
            this.thematic1501.Controls.Add(this.label1);
            this.thematic1501.Controls.Add(this.axesCheckBox);
            this.thematic1501.Controls.Add(this.imagePanel);
            this.thematic1501.Controls.Add(this.gridCheckBox);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Sizable = false;
            this.thematic1501.Size = new System.Drawing.Size(693, 553);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "Polygon Editor";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Empty;
            this.thematic1501.Transparent = false;
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.zoomTrackBar.Location = new System.Drawing.Point(259, 446);
            this.zoomTrackBar.Maximum = 23;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(356, 45);
            this.zoomTrackBar.TabIndex = 6;
            this.zoomTrackBar.Value = 10;
            this.zoomTrackBar.ValueChanged += new System.EventHandler(this.zoomTrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(656, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Create and edit the polygon by entering the coordinates of the points which make " +
    "up the polygon";
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.downButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.downButton.ForeColor = System.Drawing.Color.White;
            this.downButton.Location = new System.Drawing.Point(79, 407);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(58, 31);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "&Down";
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX,
            this.colY});
            this.grid.Location = new System.Drawing.Point(18, 64);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(119, 300);
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
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(18, 370);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(58, 31);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.delButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.Location = new System.Drawing.Point(79, 370);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(58, 31);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "D&el";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelButton.Location = new System.Drawing.Point(128, 501);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 40);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.upButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.upButton.ForeColor = System.Drawing.Color.White;
            this.upButton.Location = new System.Drawing.Point(18, 407);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(58, 31);
            this.upButton.TabIndex = 2;
            this.upButton.Text = "&Up";
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // zoomLabel
            // 
            this.zoomLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.zoomLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomLabel.Location = new System.Drawing.Point(196, 446);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(57, 32);
            this.zoomLabel.TabIndex = 2;
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okButton.Location = new System.Drawing.Point(25, 501);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 40);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(142, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axesCheckBox
            // 
            this.axesCheckBox.AutoSize = true;
            this.axesCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.axesCheckBox.Checked = true;
            this.axesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.axesCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.axesCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.axesCheckBox.Location = new System.Drawing.Point(621, 443);
            this.axesCheckBox.Name = "axesCheckBox";
            this.axesCheckBox.Size = new System.Drawing.Size(56, 23);
            this.axesCheckBox.TabIndex = 2;
            this.axesCheckBox.Text = "Axes";
            this.axesCheckBox.UseVisualStyleBackColor = false;
            this.axesCheckBox.CheckedChanged += new System.EventHandler(this.axesCheckBox_CheckedChanged);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Location = new System.Drawing.Point(144, 64);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(533, 374);
            this.imagePanel.TabIndex = 0;
            this.imagePanel.SizeChanged += new System.EventHandler(this.imagePanel_SizeChanged);
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint);
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gridCheckBox.Checked = true;
            this.gridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.gridCheckBox.Location = new System.Drawing.Point(621, 471);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(54, 23);
            this.gridCheckBox.TabIndex = 3;
            this.gridCheckBox.Text = "Grid";
            this.gridCheckBox.UseVisualStyleBackColor = false;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // PolygonEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 553);
            this.Controls.Add(this.thematic1501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PolygonEditorDialog";
            this.Text = "PolygonEditor";
            this.thematic1501.ResumeLayout(false);
            this.thematic1501.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HelperControls.ThemeManagers.SpicyLips thematic1501;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox axesCheckBox;
        private FormEditors.NoFlickerPanel imagePanel;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.TrackBar zoomTrackBar;
    }
}