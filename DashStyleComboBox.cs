// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="DashStyleComboBox.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors
{
    /// <summary>
    ///     Represents a ComboBox control from which the user can select a dash style.
    /// </summary>
    public class DashStyleComboBox : ComboBox
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
		public DashStyleComboBox()
		{
            base.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.this_DrawItem);

			base.BeginUpdate();
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			base.DrawMode = DrawMode.OwnerDrawFixed;
            base.Items.Clear();
			foreach (DashStyle hs in dashStyles)
			{
				base.Items.Add(hs);
			}
			base.SelectedIndex = 0;
			base.EndUpdate();
		}

        private void this_DrawItem(object sender, DrawItemEventArgs e)
        {
			SolidBrush br = new SolidBrush(e.BackColor);
			e.Graphics.FillRectangle(br, e.Bounds);
			br.Dispose();

			float y = (float)e.Bounds.Top + (int)(e.Bounds.Height / 2) + 0.5f;
			Pen pen = new Pen(e.ForeColor, 3);
			pen.DashStyle = dashStyles[e.Index];
			e.Graphics.DrawLine(pen, e.Bounds.Left, y, e.Bounds.Right, y);
			pen.Dispose();
        }

        /// <summary>
		/// 	Gets list of selectable items.
        ///     Overridden member to prevent designer from re-adding list of dash styles.
        /// </summary>
        /// <value>
		/// 	List of selectable items.
        /// </value>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new System.Windows.Forms.ComboBox.ObjectCollection Items
		{
			get { return base.Items; }
		}

        /// <summary>
		/// 	Gets the current drop down style.
        ///     Overridden to prevent changing drop down style.
        /// </summary>
        /// <value>
		/// 	The current drop down style.
        /// </value>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new ComboBoxStyle DropDownStyle
		{
			get	{ return base.DropDownStyle; }
		}

        /// <summary>
        ///     Gets the current draw mode.
        /// 	Overridden to prevent changing draw mode.
        /// </summary>
        /// <value>
        ///     Current draw mode.
        /// </value>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DrawMode DrawMode
		{
			get	{ return base.DrawMode; }
		}

        /// <summary>
        ///     Gets index specifying the currently selected item.
        /// 	Overridden to prevent an index of -1.
        /// </summary>
		/// <value>
		/// 	Index specifying the currently selected item.
		/// </value>
		public new int SelectedIndex
		{
			get { return base.SelectedIndex; }
			set
			{
				base.SelectedIndex = Math.Min(Math.Max(0, value), dashStyles.Length - 1);
			}
		}

        /// <summary>
        ///     Gets or sets currently selected dash style.
        /// </summary>
        /// <value>
        ///     Currently selected dash style.
        /// </value>
		public DashStyle SelectedDashStyle
		{
            get
            {
                if (base.SelectedItem == null)
                {												
                    return DashStyle.Solid;
                }
                return (DashStyle)base.SelectedItem;
            }
			set
			{
				for (int i = 0; i < dashStyles.Length; i++)
				{
					if (value == dashStyles[i])
					{
						base.SelectedIndex = i;
						return;
					}
				}
				base.SelectedIndex = 0;
			}
		}

		private static DashStyle[] dashStyles = 
		{
			DashStyle.Solid,
			DashStyle.Dash,
			DashStyle.Dot,
			DashStyle.DashDot,
			DashStyle.DashDotDot
		};
    }
}
