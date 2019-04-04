// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="PolygonEditorDialog.cs" company="Zeroit Dev Technologies">
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
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors
{
    /// <summary>
    ///     Implements a dialog which allows design and editing of a <c>Polygon</c> object.
    /// 	May be used in designer.
    /// </summary>
    public partial class PolygonEditorDialog : System.Windows.Forms.Form
    {
        /// <summary>
        ///     Initializes a new instance of <c>PolygonEditorDialog</c> with an empty polygon
        ///     and default window position.
        /// </summary>
        public PolygonEditorDialog() : this((Polygon)null)
        {
        }

        /// <summary>
        ///     Initializes a new instance of <c>PolygonEditorDialog</c> using an existing polygon
        ///     and default window position.
        /// </summary>
        /// <param name="poly">Existing <c>Polygon</c>.</param>
        public PolygonEditorDialog(Polygon poly)
        {
            InitializeComponent();
			Init(poly);
		}

        /// <summary>
        ///     Initializes a new instance of <c>PolygonEditorDialog</c> with an empty polygon
        ///     and starting beneath a specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public PolygonEditorDialog(Control c) : this(null, c)
        {
        }

        /// <summary>
        ///     Initializes a new instance of <c>PolygonEditorDialog</c> using an existing polygon
        ///     and starting beneath a specified control.
        /// </summary>
        /// <param name="poly">Existing <c>Polygon</c>.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public PolygonEditorDialog(Polygon poly, Control c)
        {
            InitializeComponent();
			Utils.SetStartPositionBelowControl(this, c);
			Init(poly);
        }

		private void Init(Polygon poly)
		{
			gridPen = new Pen(Color.LimeGreen);
			gridPen.DashStyle = DashStyle.Dot;
			axesPen = new Pen(Color.Snow);
			polyPen = new Pen(Color.Cyan, 3.0f);
			markPen = new Pen(Color.White);

			zoomTrackBar.Minimum = 0;
			zoomTrackBar.Maximum = zooms.Length - 1;
			zoomTrackBar.Value = defaultZoomIndex;
			UpdateZoom();

			// Fill in list of coordinates - select first one
			if (poly.Count > 0)
			{
				string[] cols = new string[2];
				for (int i = 0; i < poly.Count; i++)
				{
					cols[colX.Index] = poly[i].X.ToString("F2");
					cols[colY.Index] = poly[i].Y.ToString("F2");
					grid.Rows.Add(cols);
				}
				grid.Rows[0].Cells[0].Selected = true;
			}

			UpdatePoly();
			UpdateControls();
        }

		private static float[] zooms = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f,
										 0.6f, 0.7f, 0.8f, 0.9f, 1.0f,
										 1.1f, 1.2f, 1.3f, 1.4f, 1.5f,
										 2.0f, 2.2f, 2.5f, 3.0f, 3.5f,
										 4.0f, 5.0f, 6.0f, 7.0f, 8.0f };

		private const int defaultZoomIndex = 9;

		private PointF[] points;

		private bool badCells;

        /// <summary>
        ///     Gets the polygon designed by the user.
        /// </summary>
        /// <value>
        ///     The polygon designed by the user.
        /// </value>
		public Polygon Polygon
		{
            get { return new Polygon(points); }
		}

        private void UpdateZoom()
        {
            zoomLabel.Text = zooms[zoomTrackBar.Value].ToString("F1");
        }

		private void UpdatePoly()
		{
			badCells = false;

			List<PointF> list = new List<PointF>();
			foreach (DataGridViewRow row in grid.Rows)
			{
				float x, y;
				if (Single.TryParse(row.Cells[colX.Index].FormattedValue.ToString(), out x) &&
					Single.TryParse(row.Cells[colY.Index].FormattedValue.ToString(), out y))
				{
					list.Add(new PointF(x, y));
				}
				else
				{
					badCells = true;
				}

			}
			points = list.ToArray();

			UpdateImage();
		}

		private void UpdateImage()
		{
			imagePanel.Invalidate();
		}

		private void UpdateControls()
		{
			int sel = grid.SelectedCells.Count;

			delButton.Enabled  = (sel == 1);
			upButton.Enabled   = (sel == 1) && (grid.SelectedCells[0].RowIndex > 0);
			downButton.Enabled = (sel == 1) && (grid.SelectedCells[0].RowIndex < grid.Rows.Count - 1);

            okButton.Enabled = !badCells;
		}

        private void zoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateZoom();
			UpdateImage();
        }

        private void axesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
			UpdateImage();
        }

        private void gridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
			UpdateImage();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
			UpdateImage();
			UpdateControls();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
			string[] cols = new string[grid.Columns.Count];
			if (grid.Rows.Count > 0)
			{
				cols[colX.Index] = grid.Rows[grid.Rows.Count - 1].Cells[colX.Index].FormattedValue.ToString();
				cols[colY.Index] = grid.Rows[grid.Rows.Count - 1].Cells[colY.Index].FormattedValue.ToString();
			}
			else
			{
				cols[colX.Index] = "0.0";
				cols[colY.Index] = "0.0";
			}
			int rowIndex = grid.Rows.Add(cols);

			UpdatePoly();
			grid.Rows[rowIndex].Cells[colX.Index].Selected = true;
			UpdateControls();

			grid.Focus();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
			int selRow = grid.SelectedCells[0].RowIndex;
			int selCol = grid.SelectedCells[0].ColumnIndex;

			grid.Rows.RemoveAt(selRow);
			if (grid.Rows.Count > 0)
			{
				if (grid.Rows.Count <= selRow)
				{
					selRow--;
				}
				grid.Rows[selRow].Cells[selCol].Selected = true;
			}

			UpdatePoly();

			grid.Focus();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
			DataGridViewCell sel = grid.SelectedCells[0];
			SwapRows(sel.RowIndex - 1);
			grid.Rows[sel.RowIndex - 1].Cells[sel.ColumnIndex].Selected = true;
			UpdatePoly();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
			DataGridViewCell sel = grid.SelectedCells[0];
			SwapRows(sel.RowIndex);
			grid.Rows[sel.RowIndex + 1].Cells[sel.ColumnIndex].Selected = true;
			UpdatePoly();
        }

		private void SwapRows(int topRow)
		{
			SwapCells(topRow, colX.Index);
			SwapCells(topRow, colY.Index);
		}

		private void SwapCells(int topRow, int col)
		{
			object o = grid.Rows[topRow].Cells[col].Value;
			grid.Rows[topRow].Cells[col].Value = grid.Rows[topRow + 1].Cells[col].Value;
			grid.Rows[topRow + 1].Cells[col].Value = o;
		}

        private void grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
			float val;
			bool good = Single.TryParse(e.FormattedValue.ToString(), out val);
			grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = good ? DataGridView.DefaultBackColor : Color.LightCoral;
        }

        private void grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
			UpdatePoly();
			UpdateControls();
        }

		private Pen gridPen;
		private Pen axesPen;
		private Pen polyPen;
		private Pen markPen;

		private float markRadius = 5.0f;

		private float zoom;
		private int mx;
		private int my;

		private PointF Tog(PointF p)
		{
			return Tog(p.X, p.Y);
		}

		private PointF Tog(float x, float y)
		{
			return new PointF((float)mx + x * zoom, (float)my - y * zoom);
		}

        private void imagePanel_Paint(object sender, PaintEventArgs e)
        {
			const int gridSize = 10;

			Graphics g = e.Graphics;
			Size cs = imagePanel.ClientSize;

            zoom = zooms[zoomTrackBar.Value] * gridSize;
			mx = cs.Width / 2;
            my = cs.Height / 2;

			if (gridCheckBox.Checked)
			{
				int gx = mx % gridSize;
				while (gx < cs.Width)
				{
					g.DrawLine(gridPen, gx, 0, gx, cs.Height - 1);
					gx += gridSize;
				}

				int gy = my % gridSize;
				while (gy < cs.Height)
				{
					g.DrawLine(gridPen, 0, gy, cs.Width - 1, gy);
					gy += gridSize;
				}
			}

			if (axesCheckBox.Checked)
			{
				g.DrawLine(axesPen, mx, 0, mx, cs.Height - 1);
				g.DrawLine(axesPen, 0, my, cs.Width - 1, my);
			}

            if (points.Length > 0)
            {
				PointF p1 = Tog(points[0]);
				if (points.Length == 1)
				{
                    g.DrawLine(polyPen, p1, p1);
				}
				else
				{
	                for (int i = 1; i < points.Length; i++)
    	            {
						PointF p2 = Tog(points[i]);
            	        g.DrawLine(polyPen, p1, p2);
						p1 = p2;
					}
                }

				if (grid.SelectedCells.Count == 1)
				{
					int row = grid.SelectedCells[0].RowIndex;
					PointF p = Tog(points[row]);
					float diam = 2.0f * markRadius;
					RectangleF r = new RectangleF(p.X - markRadius, p.Y - markRadius, diam, diam);
					g.DrawArc(markPen, r, 0.0f, 360.0f);
				}
            }
        }

        private void imagePanel_SizeChanged(object sender, EventArgs e)
        {
            imagePanel.Invalidate();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PolygonEditorDialog_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formName_Click(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    ///     The <c>UITypeEditor</c> derived class which indicates how a <c>Polygon</c>
    ///     object can be edited directly from Visual Studio Designer.
    /// </summary>
    /// <remarks>
    ///     Note that this class is <b>NOT</b> meant to be invoked directly.
    /// </remarks>

    public class PolygonEditor : System.Drawing.Design.UITypeEditor
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
        ///     Creates and displays a <c>PolygonEditorDialog</c> dialog if <c>value</c> is a <c>Polygon</c>.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <param name="provider">An IServiceProvider through which editing services may be obtained.</param>
        /// <param name="value">An instance of <c>Polygon</c> being edited.</param>
        /// <returns>The new value of the <c>Polygon</c> being edited.</returns>
		public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
										 System.IServiceProvider provider,
										 object value)
		{
			if (value is Polygon)
			{
				PolygonEditorDialog dialog = new PolygonEditorDialog((Polygon)value);
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					return dialog.Polygon;
				}
			}
			return value;
		}
	}
    
}
