// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 07-06-2018
// ***********************************************************************
// <copyright file="ComboColorPickerDialog.Designer.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormEditors.Editors.ComboColorPicker
{
    partial class ComboColorPickerDialog
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
            this.thematic1501 = new HelperControls.ThemeManagers.SpicyLips();
            this.customColor_Btn = new System.Windows.Forms.Button();
            this.systemColor_Btn = new System.Windows.Forms.Button();
            this.comboColorPicker = new Zeroit.Framework.FormEditors.Editors.ComboColorPicker.ComboColorPicker();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.thematic1501.SuspendLayout();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Controls.Add(this.customColor_Btn);
            this.thematic1501.Controls.Add(this.systemColor_Btn);
            this.thematic1501.Controls.Add(this.comboColorPicker);
            this.thematic1501.Controls.Add(this.exit_Btn);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thematic1501.ForeColor = System.Drawing.SystemColors.InfoText;
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Sizable = true;
            this.thematic1501.Size = new System.Drawing.Size(831, 688);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "Combo Color Picker";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Empty;
            this.thematic1501.Transparent = false;
            // 
            // customColor_Btn
            // 
            this.customColor_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.customColor_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.customColor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customColor_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customColor_Btn.Location = new System.Drawing.Point(714, 627);
            this.customColor_Btn.Name = "customColor_Btn";
            this.customColor_Btn.Size = new System.Drawing.Size(98, 49);
            this.customColor_Btn.TabIndex = 13;
            this.customColor_Btn.Text = "Cancel";
            this.customColor_Btn.UseVisualStyleBackColor = false;
            this.customColor_Btn.Click += new System.EventHandler(this.customColor_Btn_Click);
            // 
            // systemColor_Btn
            // 
            this.systemColor_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.systemColor_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.systemColor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.systemColor_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.systemColor_Btn.Location = new System.Drawing.Point(610, 627);
            this.systemColor_Btn.Name = "systemColor_Btn";
            this.systemColor_Btn.Size = new System.Drawing.Size(98, 49);
            this.systemColor_Btn.TabIndex = 12;
            this.systemColor_Btn.Text = "OK";
            this.systemColor_Btn.UseVisualStyleBackColor = false;
            this.systemColor_Btn.Click += new System.EventHandler(this.systemColor_Btn_Click);
            // 
            // comboColorPicker
            // 
            this.comboColorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.comboColorPicker.Location = new System.Drawing.Point(18, 26);
            this.comboColorPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboColorPicker.Name = "comboColorPicker";
            this.comboColorPicker.Size = new System.Drawing.Size(794, 594);
            this.comboColorPicker.TabIndex = 7;
            this.comboColorPicker.ColorSelected += new Zeroit.Framework.FormEditors.BaseColorPicker.ColorSelectedEventHandler(this.comboColorPicker_ColorSelected);
            this.comboColorPicker.Load += new System.EventHandler(this.comboColorPicker_Load);
            // 
            // exit_Btn
            // 
            this.exit_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.exit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Btn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.exit_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit_Btn.Location = new System.Drawing.Point(809, 1);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(19, 20);
            this.exit_Btn.TabIndex = 6;
            this.exit_Btn.Text = "x";
            this.exit_Btn.UseCompatibleTextRendering = true;
            this.exit_Btn.UseVisualStyleBackColor = false;
            this.exit_Btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ComboColorPickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 688);
            this.Controls.Add(this.thematic1501);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComboColorPickerDialog";
            this.Text = "ComboColorPicker";
            this.thematic1501.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HelperControls.ThemeManagers.SpicyLips thematic1501;
        private System.Windows.Forms.Button exit_Btn;
        private ComboColorPicker comboColorPicker;
        private System.Windows.Forms.Button customColor_Btn;
        private System.Windows.Forms.Button systemColor_Btn;
    }
}