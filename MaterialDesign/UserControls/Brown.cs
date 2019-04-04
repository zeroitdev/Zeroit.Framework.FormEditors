// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Brown.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls
{
    [ToolboxItem(false)]
    public partial class Brown : UserControl
    {
        public Brown()
        {
            InitializeComponent();
        }


        #region Private Fields



        
        private Color getColor = Colors.Brown.brown_header_500;

        public Color Color
        {
            get { return getColor; }
        }

        #endregion

        #region Private Methods
        
        #endregion

        #region Events
        private void Brown_500_Header_MouseEnter(object sender, EventArgs e)
        {

            //Brown_500_Header.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel20.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel21.BackColor = Color.FromArgb(0, 122, 204);
            swatchNameLabel.BackColor = Color.FromArgb(0, 122, 204);

            zeroitLabel20.Visible = false;
            zeroitLabel21.Visible = false;
            swatchNameLabel.Visible = false;

            zeroitObjectAnimator1.Control = Brown_500_Header;
            zeroitObjectAnimator1.Start();

        }

        private void Brown_500_Header_MouseLeave(object sender, EventArgs e)
        {
            zeroitLabel20.Visible = true;
            zeroitLabel21.Visible = true;
            swatchNameLabel.Visible = true;

            Brown_500_Header.BackColor = Colors.Brown.brown_header_500;
            zeroitLabel20.BackColor = Colors.Brown.brown_header_500;
            zeroitLabel21.BackColor = Colors.Brown.brown_header_500;
            swatchNameLabel.BackColor = Colors.Brown.brown_header_500;
        }

        private void Brown_500_Header_Click_1(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_header_500;
            //control.BackColor = Colors.Brown.brown_header_500;

        }

        private void Brown_500_Header_Click(object sender, EventArgs e)
        {
            Brown_500_Header.BackColor = Colors.Brown.brown_header_500;
            zeroitLabel20.BackColor = Colors.Brown.brown_header_500;
            zeroitLabel21.BackColor = Colors.Brown.brown_header_500;
            swatchNameLabel.BackColor = Colors.Brown.brown_header_500;
        }

        private void Brown_500_Header_MouseClick(object sender, MouseEventArgs e)
        {
            Brown_500_Header.BackColor = Colors.Brown.brown_header_500;
            zeroitLabel20.BackColor = Colors.Brown.brown_header_500;
            zeroitLabel21.BackColor = Colors.Brown.brown_header_500;
            swatchNameLabel.BackColor = Colors.Brown.brown_header_500;
        }


        private void Brown_50_MouseEnter(object sender, EventArgs e)
        {
            Brown_50.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel18.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel19.BackColor = Color.FromArgb(0, 122, 204);
        }


        private void Brown_50_MouseLeave(object sender, EventArgs e)
        {
            Brown_50.BackColor = Colors.Brown.brown_50;
            zeroitLabel18.BackColor = Colors.Brown.brown_50;
            zeroitLabel19.BackColor = Colors.Brown.brown_50;
        }



        private void Brown_100_MouseEnter(object sender, EventArgs e)
        {
            Brown_100.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel16.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel17.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_100_MouseLeave(object sender, EventArgs e)
        {
            Brown_100.BackColor = Colors.Brown.brown_100;
            zeroitLabel16.BackColor = Colors.Brown.brown_100;
            zeroitLabel17.BackColor = Colors.Brown.brown_100;
        }

        private void Brown_200_MouseEnter(object sender, EventArgs e)
        {
            Brown_200.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel14.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel15.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_200_MouseLeave(object sender, EventArgs e)
        {
            Brown_200.BackColor = Colors.Brown.brown_200;
            zeroitLabel14.BackColor = Colors.Brown.brown_200;
            zeroitLabel15.BackColor = Colors.Brown.brown_200;
        }

        private void Brown_300_MouseEnter(object sender, EventArgs e)
        {
            Brown_300.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel13.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel2.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_300_MouseLeave(object sender, EventArgs e)
        {
            Brown_300.BackColor = Colors.Brown.brown_300;
            zeroitLabel13.BackColor = Colors.Brown.brown_300;
            zeroitLabel2.BackColor = Colors.Brown.brown_300;
        }

        private void Brown_400_MouseEnter(object sender, EventArgs e)
        {
            Brown_400.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel23.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel24.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_400_MouseLeave(object sender, EventArgs e)
        {
            Brown_400.BackColor = Colors.Brown.brown_400;
            zeroitLabel23.BackColor = Colors.Brown.brown_400;
            zeroitLabel24.BackColor = Colors.Brown.brown_400;
        }

        private void Brown_500_MouseEnter(object sender, EventArgs e)
        {
            Brown_500.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel25.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel26.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_500_MouseLeave(object sender, EventArgs e)
        {
            Brown_500.BackColor = Colors.Brown.brown_500;
            zeroitLabel25.BackColor = Colors.Brown.brown_500;
            zeroitLabel26.BackColor = Colors.Brown.brown_500;
        }

        private void Brown_600_MouseEnter(object sender, EventArgs e)
        {
            Brown_600.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel27.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel28.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_600_MouseLeave(object sender, EventArgs e)
        {
            Brown_600.BackColor = Colors.Brown.brown_600;
            zeroitLabel27.BackColor = Colors.Brown.brown_600;
            zeroitLabel28.BackColor = Colors.Brown.brown_600;
        }

        private void Brown_700_MouseEnter(object sender, EventArgs e)
        {
            Brown_700.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel29.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel30.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_700_MouseLeave(object sender, EventArgs e)
        {
            Brown_700.BackColor = Colors.Brown.brown_700;
            zeroitLabel29.BackColor = Colors.Brown.brown_700;
            zeroitLabel30.BackColor = Colors.Brown.brown_700;
        }

        private void Brown_800_MouseEnter(object sender, EventArgs e)
        {
            Brown_800.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel31.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel32.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_800_MouseLeave(object sender, EventArgs e)
        {
            Brown_800.BackColor = Colors.Brown.brown_800;
            zeroitLabel31.BackColor = Colors.Brown.brown_800;
            zeroitLabel32.BackColor = Colors.Brown.brown_800;
        }

        private void Brown_900_MouseEnter(object sender, EventArgs e)
        {
            Brown_900.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel33.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel34.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Brown_900_MouseLeave(object sender, EventArgs e)
        {
            Brown_900.BackColor = Colors.Brown.brown_900;
            zeroitLabel33.BackColor = Colors.Brown.brown_900;
            zeroitLabel34.BackColor = Colors.Brown.brown_900;
        }



        private void Brown_50_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_50;
            //control.BackColor = Colors.Brown.brown_50;
        }


        private void Brown_100_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_100;
            //control.BackColor = Colors.Brown.brown_100;
        }

        private void Brown_200_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_200;
            //control.BackColor = Colors.Brown.brown_200;
        }

        private void Brown_300_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_300;
            //control.BackColor = Colors.Brown.brown_300;
        }

        private void Brown_400_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_400;
            //control.BackColor = Colors.Brown.brown_400;
        }

        private void Brown_500_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_500;
            //control.BackColor = Colors.Brown.brown_500;
        }


        private void Brown_600_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_600;
            //control.BackColor = Colors.Brown.brown_600;
        }

        private void Brown_700_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_700;
            //control.BackColor = Colors.Brown.brown_700;
        }

        private void Brown_800_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_800;
            //control.BackColor = Colors.Brown.brown_800;
        }

        private void Brown_900_Click(object sender, EventArgs e)
        {
            getColor = Colors.Brown.brown_900;
            //control.BackColor = Colors.Brown.brown_900;
        }

        
        #endregion


    }
}
