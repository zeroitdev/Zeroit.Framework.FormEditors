// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 07-06-2018
// ***********************************************************************
// <copyright file="ColorGradientEditorDialog.Designer.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormEditors.Editors.ColorGradientEditor
{
    partial class ColorGradientEditorDialog
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
            System.Drawing.Drawing2D.ColorBlend colorBlend1 = new System.Drawing.Drawing2D.ColorBlend();
            this.thematic1501 = new HelperControls.ThemeManagers.SpicyLips();
            this.customColor_Btn = new System.Windows.Forms.Button();
            this.systemColor_Btn = new System.Windows.Forms.Button();
            this.colorGradientEditor = new Zeroit.Framework.FormEditors.ColorGradientEditor();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.thematic1501.SuspendLayout();
            this.SuspendLayout();
            // 
            // thematic1501
            // 
            this.thematic1501.BackColor = System.Drawing.Color.White;
            this.thematic1501.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic1501.Controls.Add(this.customColor_Btn);
            this.thematic1501.Controls.Add(this.systemColor_Btn);
            this.thematic1501.Controls.Add(this.colorGradientEditor);
            this.thematic1501.Controls.Add(this.exit_Btn);
            this.thematic1501.Customization = "";
            this.thematic1501.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thematic1501.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thematic1501.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.thematic1501.Image = null;
            this.thematic1501.Location = new System.Drawing.Point(0, 0);
            this.thematic1501.Movable = true;
            this.thematic1501.Name = "thematic1501";
            this.thematic1501.NoRounding = false;
            this.thematic1501.Sizable = false;
            this.thematic1501.Size = new System.Drawing.Size(505, 484);
            this.thematic1501.SmartBounds = true;
            this.thematic1501.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.thematic1501.TabIndex = 0;
            this.thematic1501.Text = "Color Gradient Editor";
            this.thematic1501.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.Transparent = false;
            // 
            // customColor_Btn
            // 
            this.customColor_Btn.BackColor = System.Drawing.Color.Red;
            this.customColor_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.customColor_Btn.FlatAppearance.BorderSize = 0;
            this.customColor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customColor_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customColor_Btn.Location = new System.Drawing.Point(413, 438);
            this.customColor_Btn.Name = "customColor_Btn";
            this.customColor_Btn.Size = new System.Drawing.Size(76, 34);
            this.customColor_Btn.TabIndex = 15;
            this.customColor_Btn.Text = "Cancel";
            this.customColor_Btn.UseVisualStyleBackColor = false;
            this.customColor_Btn.Click += new System.EventHandler(this.customColor_Btn_Click);
            // 
            // systemColor_Btn
            // 
            this.systemColor_Btn.BackColor = System.Drawing.Color.Blue;
            this.systemColor_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.systemColor_Btn.FlatAppearance.BorderSize = 0;
            this.systemColor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.systemColor_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.systemColor_Btn.Location = new System.Drawing.Point(331, 438);
            this.systemColor_Btn.Name = "systemColor_Btn";
            this.systemColor_Btn.Size = new System.Drawing.Size(76, 34);
            this.systemColor_Btn.TabIndex = 14;
            this.systemColor_Btn.Text = "OK";
            this.systemColor_Btn.UseVisualStyleBackColor = false;
            this.systemColor_Btn.Click += new System.EventHandler(this.systemColor_Btn_Click);
            // 
            // colorGradientEditor
            // 
            this.colorGradientEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            colorBlend1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))))};
            colorBlend1.Positions = new float[] {
        0F,
        0.5F,
        1F};
            this.colorGradientEditor.Blend = colorBlend1;
            this.colorGradientEditor.GradientBackColor = System.Drawing.Color.White;
            this.colorGradientEditor.GradientBorderColor = System.Drawing.Color.DarkGray;
            this.colorGradientEditor.GradientHatchColor = System.Drawing.Color.Black;
            this.colorGradientEditor.Location = new System.Drawing.Point(19, 35);
            this.colorGradientEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorGradientEditor.MarkerBorderColor = System.Drawing.Color.Black;
            this.colorGradientEditor.MarkerFillColor = System.Drawing.Color.White;
            this.colorGradientEditor.MinimumSize = new System.Drawing.Size(376, 157);
            this.colorGradientEditor.Name = "colorGradientEditor";
            this.colorGradientEditor.SelMarkerFillColor = System.Drawing.Color.Yellow;
            this.colorGradientEditor.Size = new System.Drawing.Size(470, 396);
            this.colorGradientEditor.TabIndex = 8;
            // 
            // exit_Btn
            // 
            this.exit_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.exit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Btn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.exit_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit_Btn.Location = new System.Drawing.Point(486, 0);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(19, 20);
            this.exit_Btn.TabIndex = 7;
            this.exit_Btn.Text = "x";
            this.exit_Btn.UseCompatibleTextRendering = true;
            this.exit_Btn.UseVisualStyleBackColor = false;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            this.exit_Btn.MouseEnter += new System.EventHandler(this.exit_Btn_MouseEnter);
            this.exit_Btn.MouseLeave += new System.EventHandler(this.exit_Btn_MouseLeave);
            // 
            // ColorGradientEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 484);
            this.Controls.Add(this.thematic1501);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorGradientEditorDialog";
            this.Text = "ColorGradientEditorDialog";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thematic1501.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HelperControls.ThemeManagers.SpicyLips thematic1501;
        private System.Windows.Forms.Button exit_Btn;
        private FormEditors.ColorGradientEditor colorGradientEditor;
        private System.Windows.Forms.Button customColor_Btn;
        private System.Windows.Forms.Button systemColor_Btn;
    }
}