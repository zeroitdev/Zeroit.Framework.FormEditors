// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="FillerPanel.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors
{
    /// <summary>
    /// 	Represents a control for displaying a <c>Filler</c> value.
    /// </summary>
    public partial class FillerPanel : UserControl
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public FillerPanel()
        {
            InitializeComponent();

			this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
						  ControlStyles.AllPaintingInWmPaint |
						  ControlStyles.ResizeRedraw |
						  ControlStyles.UserPaint, true);

			this.UpdateStyles();
        }

        private Filler filler = new Filler();
        /// <summary>
        ///     Gets or sets the simple filler.
        /// </summary>
        /// <value>
        ///     The simple filler.
        /// </value>
        public Filler Filler
        {
            get { return filler; }
            set
            {
                filler = value;
                Invalidate();
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void this_Paint(object sender, PaintEventArgs e)
        {
            if (filler != null)
            {
                Brush brush = filler.GetBrush(ClientRectangle);
                if (brush != null)
                {
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                    brush.Dispose();
                }
            }
        }
    }
}
