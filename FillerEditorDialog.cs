// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="FillerEditorDialog.cs" company="Zeroit Dev Technologies">
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors
{
    /// <summary>
    /// 	Implements a dialog which allows design and editing of a <c>Filler</c> object.
	/// 	May be used in designer.
    /// </summary>
    public partial class FillerEditorDialog : System.Windows.Forms.Form
    {
		private const int gradientLinear = 0;
		private const int gradientPathRect = 1;
		private const int gradientPathRadial = 2;

        /// <summary>
		///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
		/// 	at the default window position.
        /// </summary>
        public FillerEditorDialog() : this(Filler.Empty())
        {
        }

        /// <summary>
		/// 	Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
		/// 	at the default window position.
        /// </summary>
        /// <param name="filler">Existing <c>Filler</c> object.</param>
		/// <exception cref="System.ArgumentNullException">
		///		Thrown if <paramref name="filler" /> is null.
		///	</exception>
        public FillerEditorDialog(Filler filler)
        {
			if (filler == null)
			{
				throw new ArgumentNullException("filler");
			}

            InitializeComponent();
			FillGradientComboBox();
			AdjustDialogSize();
			SetControlsToInitialValues(filler);
        }

        /// <summary>
		///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
		///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public FillerEditorDialog(Control c) : this(Filler.Empty(), c)
        {
        }

        /// <summary>
		///		Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
		///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="filler">Existing <c>Filler</c> object.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
		/// <exception cref="System.ArgumentNullException">
		///		Thrown if <paramref name="filler" /> is null.
		///	</exception>
        public FillerEditorDialog(Filler filler, Control c) : this(filler)
        {
			Utils.SetStartPositionBelowControl(this, c);
        }

		private void FillGradientComboBox()
		{
			gradientTypeComboBox.Items.Clear();
			gradientTypeComboBox.Items.Add("Linear");
			gradientTypeComboBox.Items.Add("Path Rect");
			gradientTypeComboBox.Items.Add("Path Radial");
		}

		private void AdjustDialogSize()
		{
			// Three different possible group boxes - move them all to one coordinate
			int x = solidGroupBox.Location.X;
			int y = typeGroupBox.Location.Y;

			solidGroupBox.Location = new Point(x, y);
			hatchGroupBox.Location = new Point(x, y);
			gradientGroupBox.Location = new Point(x, y);
            //formName.Location = new Point(typeGroupBox.Location.X, formName.Location.Y - 5);

            int bottomY = Math.Max(solidGroupBox.Bounds.Bottom,
                          Math.Max(hatchGroupBox.Bounds.Bottom,
                             Math.Max(gradientGroupBox.Bounds.Bottom,
                                   typeGroupBox.Bounds.Bottom)));



            int newHeight = bottomY + typeGroupBox.Location.Y;

			this.Size = new Size(Size.Width, Size.Height - (ClientSize.Height - newHeight));
		}

		private void SetControlsToInitialValues(Filler filler)
		{
			// Fill with defaults
			Init(filler.SolidColor, solidColorLabel, solidAlphaNud);
			Init(filler.HatchColor, hatchColorLabel, hatchAlphaNud);
			Init(filler.BackColor, backColorLabel, backAlphaNud);
            gradientEditor.Blend = filler.GradientColors;

			if (filler.FillType == FillerType.PathGradient)
			{
				if (filler.PathGradientType == PathGradientType.Rect)
				{
					gradientTypeComboBox.SelectedIndex = gradientPathRect;
				}
				else
				{
					gradientTypeComboBox.SelectedIndex = gradientPathRadial;
				}
			}
			else
			{
				gradientTypeComboBox.SelectedIndex = gradientLinear;
				gradientAngleNud.Value = (decimal)filler.LinearGradientAngle;
			}
			UpdateGradient();

			hatchComboBox.SelectedIndex = 0;
			for (int i = 0; i < hatchComboBox.Items.Count; i++)
			{
				if (filler.HatchStyle == (HatchStyle)(hatchComboBox.Items[i]))
				{
					hatchComboBox.SelectedIndex = i;
				}
			}
			UpdateHatch();

			UpdateSolid();

			if (filler.FillType == FillerType.None)
			{
				noneRadioButton.Checked = true;
			}
			else if (filler.FillType == FillerType.Solid)
			{
				solidRadioButton.Checked = true;
			}
            else if (filler.FillType == FillerType.Hatch)
			{
				hatchRadioButton.Checked = true;
			}
            else
			{
				gradientRadioButton.Checked = true;
			}
		}

		private void Init(Color c, Label label, NumericUpDown alphaNud)
		{
			label.BackColor = RGB(c);
			alphaNud.Value = (decimal)c.A;
		}

		private Color FromLabelNud(Label label, NumericUpDown alphaNud)
		{
			return Color.FromArgb((int)alphaNud.Value, label.BackColor);
		}

		private Color RGB(Color c)
		{
			return Color.FromArgb(255, c);
		}

        private Filler filler;
        /// <summary>
        /// 	Gets current filler.
        /// </summary>
        /// <value>
        /// 	Current filler.
        /// </value>
        public Filler Filler
		{
			get { return filler; }
		}

		private void UpdateSolid()
		{
			sampleSolidPanel.BackColor = FromLabelNud(solidColorLabel, solidAlphaNud);
		}

		private void UpdateHatch()
		{
			sampleHatchPanel.Set(hatchComboBox.SelectedHatchStyle,
								 FromLabelNud(hatchColorLabel, hatchAlphaNud),
								 FromLabelNud(backColorLabel, backAlphaNud));
		}						 
		
		private void UpdateGradient()
		{
			gradientAngleTextLabel.Enabled = gradientTypeComboBox.SelectedIndex == gradientLinear;
			gradientAngleNud.Enabled       = gradientTypeComboBox.SelectedIndex == gradientLinear;
		}

        private void solidColorButton_Click(object sender, EventArgs e)
        {
            ComboColorPickerDialog d = new ComboColorPickerDialog(solidColorLabel.BackColor, solidColorButton);
			if (d.ShowDialog() == DialogResult.OK)
			{
				solidColorLabel.BackColor = d.Color;
			}
			UpdateSolid();
        }

        private void solidAlphaNud_ValueChanged(object sender, EventArgs e)
        {
			UpdateSolid();
        }

        private void hatchColorButton_Click(object sender, EventArgs e)
        {
            ComboColorPickerDialog d = new ComboColorPickerDialog(hatchColorLabel.BackColor, hatchColorButton);
			if (d.ShowDialog() == DialogResult.OK)
			{
				hatchColorLabel.BackColor = Color.FromArgb((int)hatchAlphaNud.Value, d.Color);
			}
			UpdateHatch();
        }

        private void hatchAlphaNud_ValueChanged(object sender, EventArgs e)
        {
			UpdateHatch();
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            ComboColorPickerDialog d = new ComboColorPickerDialog(backColorLabel.BackColor, backColorButton);
			if (d.ShowDialog() == DialogResult.OK)
			{
				backColorLabel.BackColor = d.Color;
			}
			UpdateHatch();
        }

        private void backAlphaNud_ValueChanged(object sender, EventArgs e)
        {
			UpdateHatch();
        }

        private void hatchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
			UpdateHatch();
        }

        private void gradientTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateGradient();
        }

        private void fillerTypeChanged(object sender, EventArgs e)
        {
			solidGroupBox.Visible = false;
			hatchGroupBox.Visible = false;
			gradientGroupBox.Visible = false;
            

			if (solidRadioButton.Checked)
			{
				solidGroupBox.Visible = true;
                
			}
			else if (hatchRadioButton.Checked)
			{
				hatchGroupBox.Visible = true;
			}
			else if (gradientRadioButton.Checked)
			{
				gradientGroupBox.Visible = true;
			}
        }

        private void okButton_Click(object sender, EventArgs e)
        {
			if (solidRadioButton.Checked)
			{
				filler = new Filler(FromLabelNud(solidColorLabel, solidAlphaNud));
			}
			else if (hatchRadioButton.Checked)
			{
				filler = new Filler(hatchComboBox.SelectedHatchStyle,
									 FromLabelNud(hatchColorLabel, hatchAlphaNud),
									 FromLabelNud(backColorLabel, backAlphaNud));
			}
			else if (gradientRadioButton.Checked)
			{
				if (gradientTypeComboBox.SelectedIndex == gradientLinear)
				{
					filler = new Filler((float)gradientAngleNud.Value, gradientEditor.Blend);
				}
				else if (gradientTypeComboBox.SelectedIndex == gradientPathRect)
				{
					filler = new Filler(PathGradientType.Rect, gradientEditor.Blend);
				}
				else
				{
					filler = new Filler(PathGradientType.Radial, gradientEditor.Blend);
				}
			}
			else
			{
				filler = Filler.Empty();
			}
			DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void solidColorButton_MouseEnter(object sender, EventArgs e)
        {
            solidColorButton.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
        }

        private void solidColorButton_MouseLeave(object sender, EventArgs e)
        {
            solidColorButton.FlatAppearance.BorderColor = Color.FromArgb(56,56,56);
        }

        private void hatchColorButton_MouseEnter(object sender, EventArgs e)
        {
            hatchColorButton.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
        }

        private void hatchColorButton_MouseLeave(object sender, EventArgs e)
        {
            hatchColorButton.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 56);
        }

        private void backColorButton_MouseEnter(object sender, EventArgs e)
        {
            backColorButton.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
        }

        private void backColorButton_MouseLeave(object sender, EventArgs e)
        {
            backColorButton.FlatAppearance.BorderColor = Color.FromArgb(56, 56, 56);
        }

        private void FillerEditorDialog_Load(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    ///     The <c>UITypeEditor</c> derived class which indicates how a <c>Filler</c>
    ///     object can be edited directly from Visual Studio Designer.
    /// </summary>
    /// <remarks>
    ///     Note that this class is <b>NOT</b> meant to be invoked directly
    /// </remarks>
	public class FillerEditor : System.Drawing.Design.UITypeEditor
	{
	    /// <summary>
	    ///     Gets the editor style used by the <c>EditValue</c> method.
	    /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
	    /// <returns><c>UITypeEditorEditStyle.Modal</c></returns>
		public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

        /// <summary>
        ///     Creates and displays a <c>FillerEditorDialog</c> dialog if <c>value</c> is a <c>Filler</c>.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <param name="provider">An IServiceProvider through which editing services may be obtained.</param>
        /// <param name="value">An instance of <c>Filler</c> being edited.</param>
        /// <returns>The new value of the <c>Filler</c> being edited.</returns>
		public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
										 System.IServiceProvider provider,
										 object value)
		{
			if (value is Filler)
			{
				FillerEditorDialog dialog = new FillerEditorDialog((Filler)value);
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					return dialog.Filler;
				}
			}
			return value;
		}

        /// <summary>
        ///     Indicates that painting is supported.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns><c>true</c>.</returns>
		public override bool GetPaintValueSupported(ITypeDescriptorContext context)
		{
			return true;
		}

        /// <summary>
        ///     Paint a representation of the simple filler (usually in designer).
        /// </summary>
        /// <param name="e">A <c>PaintValueEventArgs</c> that indicates what to paint and where to paint it.</param>
		public override void PaintValue(PaintValueEventArgs e)
		{   
			if (e.Value is Filler)
			{
				Brush br = ((Filler)e.Value).GetUITypeEditorBrush(e.Bounds);
				if (br != null)
				{
					e.Graphics.FillRectangle(br, e.Bounds /*r*/);
				}
			}
		}
	}
}
