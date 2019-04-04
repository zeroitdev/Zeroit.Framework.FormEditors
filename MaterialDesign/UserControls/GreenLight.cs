﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="GreenLight.cs" company="Zeroit Dev Technologies">
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
    public partial class GreenLight : UserControl
    {
        public GreenLight()
        {
            InitializeComponent();
        }
        
        #region Private Fields


        private Color getColor = Colors.LightGreen.lightgreen_header_500;

        public Color Color
        {
            get { return getColor; }
        }

        #endregion
        
        #region Events
        private void LightGreen_500_Header_MouseEnter(object sender, EventArgs e)
        {
            //LightGreen_500_Header.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel20.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel21.BackColor = Color.FromArgb(0, 122, 204);
            swatchNameLabel.BackColor = Color.FromArgb(0, 122, 204);

            zeroitLabel20.Visible = false;
            zeroitLabel21.Visible = false;
            swatchNameLabel.Visible = false;

            zeroitObjectAnimator1.Control = LightGreen_500_Header;
            zeroitObjectAnimator1.Start();

        }

        private void LightGreen_500_Header_MouseLeave(object sender, EventArgs e)
        {
            zeroitLabel20.Visible = true;
            zeroitLabel21.Visible = true;
            swatchNameLabel.Visible = true;

            LightGreen_500_Header.BackColor = Colors.LightGreen.lightgreen_header_500;
            zeroitLabel20.BackColor = Colors.LightGreen.lightgreen_header_500;
            zeroitLabel21.BackColor = Colors.LightGreen.lightgreen_header_500;
            swatchNameLabel.BackColor = Colors.LightGreen.lightgreen_header_500;
        }

        private void LightGreen_500_Header_Click_1(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_header_500;
            //control.BackColor = Colors.LightGreen.lightgreen_header_500;

        }

        private void LightGreen_500_Header_Click(object sender, EventArgs e)
        {
            LightGreen_500_Header.BackColor = Colors.LightGreen.lightgreen_header_500;
            zeroitLabel20.BackColor = Colors.LightGreen.lightgreen_header_500;
            zeroitLabel21.BackColor = Colors.LightGreen.lightgreen_header_500;
            swatchNameLabel.BackColor = Colors.LightGreen.lightgreen_header_500;
        }

        private void LightGreen_500_Header_MouseClick(object sender, MouseEventArgs e)
        {
            LightGreen_500_Header.BackColor = Colors.LightGreen.lightgreen_header_500;
            zeroitLabel20.BackColor = Colors.LightGreen.lightgreen_header_500;
            zeroitLabel21.BackColor = Colors.LightGreen.lightgreen_header_500;
            swatchNameLabel.BackColor = Colors.LightGreen.lightgreen_header_500;
        }


        private void LightGreen_50_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_50.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel18.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel19.BackColor = Color.FromArgb(0, 122, 204);
        }


        private void LightGreen_50_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_50.BackColor = Colors.LightGreen.lightgreen_50;
            zeroitLabel18.BackColor = Colors.LightGreen.lightgreen_50;
            zeroitLabel19.BackColor = Colors.LightGreen.lightgreen_50;
        }



        private void LightGreen_100_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_100.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel16.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel17.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_100_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_100.BackColor = Colors.LightGreen.lightgreen_100;
            zeroitLabel16.BackColor = Colors.LightGreen.lightgreen_100;
            zeroitLabel17.BackColor = Colors.LightGreen.lightgreen_100;
        }

        private void LightGreen_200_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_200.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel14.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel15.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_200_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_200.BackColor = Colors.LightGreen.lightgreen_200;
            zeroitLabel14.BackColor = Colors.LightGreen.lightgreen_200;
            zeroitLabel15.BackColor = Colors.LightGreen.lightgreen_200;
        }

        private void LightGreen_300_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_300.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel13.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel2.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_300_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_300.BackColor = Colors.LightGreen.lightgreen_300;
            zeroitLabel13.BackColor = Colors.LightGreen.lightgreen_300;
            zeroitLabel2.BackColor = Colors.LightGreen.lightgreen_300;
        }

        private void LightGreen_400_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_400.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel23.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel24.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_400_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_400.BackColor = Colors.LightGreen.lightgreen_400;
            zeroitLabel23.BackColor = Colors.LightGreen.lightgreen_400;
            zeroitLabel24.BackColor = Colors.LightGreen.lightgreen_400;
        }

        private void LightGreen_500_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_500.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel25.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel26.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_500_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_500.BackColor = Colors.LightGreen.lightgreen_500;
            zeroitLabel25.BackColor = Colors.LightGreen.lightgreen_500;
            zeroitLabel26.BackColor = Colors.LightGreen.lightgreen_500;
        }

        private void LightGreen_600_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_600.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel27.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel28.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_600_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_600.BackColor = Colors.LightGreen.lightgreen_600;
            zeroitLabel27.BackColor = Colors.LightGreen.lightgreen_600;
            zeroitLabel28.BackColor = Colors.LightGreen.lightgreen_600;
        }

        private void LightGreen_700_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_700.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel29.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel30.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_700_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_700.BackColor = Colors.LightGreen.lightgreen_700;
            zeroitLabel29.BackColor = Colors.LightGreen.lightgreen_700;
            zeroitLabel30.BackColor = Colors.LightGreen.lightgreen_700;
        }

        private void LightGreen_800_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_800.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel31.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel32.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_800_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_800.BackColor = Colors.LightGreen.lightgreen_800;
            zeroitLabel31.BackColor = Colors.LightGreen.lightgreen_800;
            zeroitLabel32.BackColor = Colors.LightGreen.lightgreen_800;
        }

        private void LightGreen_900_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_900.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel33.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel34.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_900_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_900.BackColor = Colors.LightGreen.lightgreen_900;
            zeroitLabel33.BackColor = Colors.LightGreen.lightgreen_900;
            zeroitLabel34.BackColor = Colors.LightGreen.lightgreen_900;
        }

        private void LightGreen_A100_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_A100.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel35.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel36.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_A100_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_A100.BackColor = Colors.LightGreen.lightgreen_A100;
            zeroitLabel35.BackColor = Colors.LightGreen.lightgreen_A100;
            zeroitLabel36.BackColor = Colors.LightGreen.lightgreen_A100;
        }

        private void LightGreen_A200_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_A200.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel37.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel38.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_A200_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_A200.BackColor = Colors.LightGreen.lightgreen_A200;
            zeroitLabel37.BackColor = Colors.LightGreen.lightgreen_A200;
            zeroitLabel38.BackColor = Colors.LightGreen.lightgreen_A200;
        }

        private void LightGreen_A400_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_A400.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel39.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel40.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_A400_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_A400.BackColor = Colors.LightGreen.lightgreen_A400;
            zeroitLabel39.BackColor = Colors.LightGreen.lightgreen_A400;
            zeroitLabel40.BackColor = Colors.LightGreen.lightgreen_A400;
        }

        private void LightGreen_A700_MouseEnter(object sender, EventArgs e)
        {
            LightGreen_A700.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel41.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel42.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void LightGreen_A700_MouseLeave(object sender, EventArgs e)
        {
            LightGreen_A700.BackColor = Colors.LightGreen.lightgreen_A700;
            zeroitLabel41.BackColor = Colors.LightGreen.lightgreen_A700;
            zeroitLabel42.BackColor = Colors.LightGreen.lightgreen_A700;
        }





        private void LightGreen_50_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_50;
            //control.BackColor = Colors.LightGreen.lightgreen_50;
        }


        private void LightGreen_100_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_100;
            //control.BackColor = Colors.LightGreen.lightgreen_100;
        }

        private void LightGreen_200_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_200;
            //control.BackColor = Colors.LightGreen.lightgreen_200;
        }

        private void LightGreen_300_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_300;
            //control.BackColor = Colors.LightGreen.lightgreen_300;
        }

        private void LightGreen_400_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_400;
            //control.BackColor = Colors.LightGreen.lightgreen_400;
        }

        private void LightGreen_500_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_500;
            //control.BackColor = Colors.LightGreen.lightgreen_500;
        }


        private void LightGreen_600_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_600;
            //control.BackColor = Colors.LightGreen.lightgreen_600;
        }

        private void LightGreen_700_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_700;
            //control.BackColor = Colors.LightGreen.lightgreen_700;
        }

        private void LightGreen_800_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_800;
            //control.BackColor = Colors.LightGreen.lightgreen_800;
        }

        private void LightGreen_900_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_900;
            //control.BackColor = Colors.LightGreen.lightgreen_900;
        }

        private void LightGreen_A100_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_A100;
            //control.BackColor = Colors.LightGreen.lightgreen_A100;
        }

        private void LightGreen_A200_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_A200;
            //control.BackColor = Colors.LightGreen.lightgreen_A200;
        }

        private void LightGreen_A400_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_A400;
            //control.BackColor = Colors.LightGreen.lightgreen_A400;
        }

        private void LightGreen_A700_Click(object sender, EventArgs e)
        {
            getColor = Colors.LightGreen.lightgreen_A700;
            //control.BackColor = Colors.LightGreen.lightgreen_A700;
        }

        #endregion
        

    }
}
