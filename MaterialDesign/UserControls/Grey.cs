// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Grey.cs" company="Zeroit Dev Technologies">
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
    public partial class Grey : UserControl
    {
        public Grey()
        {
            InitializeComponent();
        }



        #region Private Fields


        private Color getColor = Colors.Grey.grey_header_500;

        public Color Color
        {
            get { return getColor; }
        }

        #endregion

        
        #region Events
        private void Grey_500_Header_MouseEnter(object sender, EventArgs e)
        {
            //Grey_500_Header.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel20.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel21.BackColor = Color.FromArgb(0, 122, 204);
            swatchNameLabel.BackColor = Color.FromArgb(0, 122, 204);

            zeroitLabel20.Visible = false;
            zeroitLabel21.Visible = false;
            swatchNameLabel.Visible = false;

            zeroitObjectAnimator1.Control = Grey_500_Header;
            zeroitObjectAnimator1.Start();

        }

        private void Grey_500_Header_MouseLeave(object sender, EventArgs e)
        {
            zeroitLabel20.Visible = true;
            zeroitLabel21.Visible = true;
            swatchNameLabel.Visible = true;

            Grey_500_Header.BackColor = Colors.Grey.grey_header_500;
            zeroitLabel20.BackColor = Colors.Grey.grey_header_500;
            zeroitLabel21.BackColor = Colors.Grey.grey_header_500;
            swatchNameLabel.BackColor = Colors.Grey.grey_header_500;
        }

        private void Grey_500_Header_Click_1(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_header_500;
            //control.BackColor = Colors.Grey.grey_header_500;

        }

        private void Grey_500_Header_Click(object sender, EventArgs e)
        {
            Grey_500_Header.BackColor = Colors.Grey.grey_header_500;
            zeroitLabel20.BackColor = Colors.Grey.grey_header_500;
            zeroitLabel21.BackColor = Colors.Grey.grey_header_500;
            swatchNameLabel.BackColor = Colors.Grey.grey_header_500;
        }

        private void Grey_500_Header_MouseClick(object sender, MouseEventArgs e)
        {
            Grey_500_Header.BackColor = Colors.Grey.grey_header_500;
            zeroitLabel20.BackColor = Colors.Grey.grey_header_500;
            zeroitLabel21.BackColor = Colors.Grey.grey_header_500;
            swatchNameLabel.BackColor = Colors.Grey.grey_header_500;
        }


        private void Grey_50_MouseEnter(object sender, EventArgs e)
        {
            Grey_50.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel18.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel19.BackColor = Color.FromArgb(0, 122, 204);
        }


        private void Grey_50_MouseLeave(object sender, EventArgs e)
        {
            Grey_50.BackColor = Colors.Grey.grey_50;
            zeroitLabel18.BackColor = Colors.Grey.grey_50;
            zeroitLabel19.BackColor = Colors.Grey.grey_50;
        }



        private void Grey_100_MouseEnter(object sender, EventArgs e)
        {
            Grey_100.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel16.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel17.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_100_MouseLeave(object sender, EventArgs e)
        {
            Grey_100.BackColor = Colors.Grey.grey_100;
            zeroitLabel16.BackColor = Colors.Grey.grey_100;
            zeroitLabel17.BackColor = Colors.Grey.grey_100;
        }

        private void Grey_200_MouseEnter(object sender, EventArgs e)
        {
            Grey_200.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel14.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel15.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_200_MouseLeave(object sender, EventArgs e)
        {
            Grey_200.BackColor = Colors.Grey.grey_200;
            zeroitLabel14.BackColor = Colors.Grey.grey_200;
            zeroitLabel15.BackColor = Colors.Grey.grey_200;
        }

        private void Grey_300_MouseEnter(object sender, EventArgs e)
        {
            Grey_300.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel13.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel2.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_300_MouseLeave(object sender, EventArgs e)
        {
            Grey_300.BackColor = Colors.Grey.grey_300;
            zeroitLabel13.BackColor = Colors.Grey.grey_300;
            zeroitLabel2.BackColor = Colors.Grey.grey_300;
        }

        private void Grey_400_MouseEnter(object sender, EventArgs e)
        {
            Grey_400.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel23.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel24.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_400_MouseLeave(object sender, EventArgs e)
        {
            Grey_400.BackColor = Colors.Grey.grey_400;
            zeroitLabel23.BackColor = Colors.Grey.grey_400;
            zeroitLabel24.BackColor = Colors.Grey.grey_400;
        }

        private void Grey_500_MouseEnter(object sender, EventArgs e)
        {
            Grey_500.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel25.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel26.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_500_MouseLeave(object sender, EventArgs e)
        {
            Grey_500.BackColor = Colors.Grey.grey_500;
            zeroitLabel25.BackColor = Colors.Grey.grey_500;
            zeroitLabel26.BackColor = Colors.Grey.grey_500;
        }

        private void Grey_600_MouseEnter(object sender, EventArgs e)
        {
            Grey_600.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel27.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel28.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_600_MouseLeave(object sender, EventArgs e)
        {
            Grey_600.BackColor = Colors.Grey.grey_600;
            zeroitLabel27.BackColor = Colors.Grey.grey_600;
            zeroitLabel28.BackColor = Colors.Grey.grey_600;
        }

        private void Grey_700_MouseEnter(object sender, EventArgs e)
        {
            Grey_700.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel29.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel30.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_700_MouseLeave(object sender, EventArgs e)
        {
            Grey_700.BackColor = Colors.Grey.grey_700;
            zeroitLabel29.BackColor = Colors.Grey.grey_700;
            zeroitLabel30.BackColor = Colors.Grey.grey_700;
        }

        private void Grey_800_MouseEnter(object sender, EventArgs e)
        {
            Grey_800.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel31.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel32.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_800_MouseLeave(object sender, EventArgs e)
        {
            Grey_800.BackColor = Colors.Grey.grey_800;
            zeroitLabel31.BackColor = Colors.Grey.grey_800;
            zeroitLabel32.BackColor = Colors.Grey.grey_800;
        }

        private void Grey_900_MouseEnter(object sender, EventArgs e)
        {
            Grey_900.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel33.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel34.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void Grey_900_MouseLeave(object sender, EventArgs e)
        {
            Grey_900.BackColor = Colors.Grey.grey_900;
            zeroitLabel33.BackColor = Colors.Grey.grey_900;
            zeroitLabel34.BackColor = Colors.Grey.grey_900;
        }



        private void Grey_50_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_50;
            //control.BackColor = Colors.Grey.grey_50;
        }


        private void Grey_100_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_100;
            //control.BackColor = Colors.Grey.grey_100;
        }

        private void Grey_200_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_200;
            //control.BackColor = Colors.Grey.grey_200;
        }

        private void Grey_300_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_300;
            //control.BackColor = Colors.Grey.grey_300;
        }

        private void Grey_400_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_400;
            //control.BackColor = Colors.Grey.grey_400;
        }

        private void Grey_500_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_500;
            //control.BackColor = Colors.Grey.grey_500;
        }


        private void Grey_600_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_600;
            //control.BackColor = Colors.Grey.grey_600;
        }

        private void Grey_700_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_700;
            //control.BackColor = Colors.Grey.grey_700;
        }

        private void Grey_800_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_800;
            //control.BackColor = Colors.Grey.grey_800;
        }

        private void Grey_900_Click(object sender, EventArgs e)
        {
            getColor = Colors.Grey.grey_900;
            //control.BackColor = Colors.Grey.grey_900;
        }

        
        #endregion


    }
}
