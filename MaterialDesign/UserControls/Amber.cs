// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Amber.cs" company="Zeroit Dev Technologies">
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
    public partial class Amber : UserControl
    {
        public Amber()
        {
            InitializeComponent();
        }


        #region Private Field

        private Control control = new Control();

        private Color getColor = Colors.Amber.amber_header_500;

        #endregion

        #region Private Methods
        public Color Color
        {
            get { return getColor; }
            
        }

        //public Color SelectedColor(Control control)
        //{
        //    this.control = control;
        //    this.//control.BackColor = getColor;

        //    return this.//control.BackColor;
        //}
        #endregion


        #region Events


        private void Amber_500_Header_MouseEnter(object sender, EventArgs e)
        {
            //Amber_500_Header.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel20.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel21.BackColor = Color.FromArgb(0, 122, 204);
            swatchNameLabel.BackColor = Color.FromArgb(0, 122, 204);

            zeroitLabel20.Visible = false;
            zeroitLabel21.Visible = false;
            swatchNameLabel.Visible = false;

            zeroitObjectAnimator1.Control = Amber_500_Header;
            zeroitObjectAnimator1.Start();

            

        }

        private void Amber_500_Header_MouseLeave(object sender, EventArgs e)
        {
            zeroitLabel20.Visible = true;
            zeroitLabel21.Visible = true;
            swatchNameLabel.Visible = true;

            Amber_500_Header.BackColor = Colors.Amber.amber_header_500;
            zeroitLabel20.BackColor = Colors.Amber.amber_header_500;
            zeroitLabel21.BackColor = Colors.Amber.amber_header_500;
            swatchNameLabel.BackColor = Colors.Amber.amber_header_500;



        }

        
        private void Amber_50_MouseEnter(object sender, EventArgs e)
        {
            Amber_50.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel18.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel19.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_50_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }
        

        private void Amber_50_MouseLeave(object sender, EventArgs e)
        {
            Amber_50.BackColor = Colors.Amber.amber_50;
            zeroitLabel18.BackColor = Colors.Amber.amber_50;
            zeroitLabel19.BackColor = Colors.Amber.amber_50;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_50_Label")
                {
                    c.BackColor = Colors.Amber.amber_50;

                }
            }
        }

        private void Amber_500_Header_Click(object sender, EventArgs e)
        {
            Amber_500_Header.BackColor = Colors.Amber.amber_header_500;
            zeroitLabel20.BackColor = Colors.Amber.amber_header_500;
            zeroitLabel21.BackColor = Colors.Amber.amber_header_500;
            swatchNameLabel.BackColor = Colors.Amber.amber_header_500;
        }

        private void Amber_500_Header_MouseClick(object sender, MouseEventArgs e)
        {
            Amber_500_Header.BackColor = Colors.Amber.amber_header_500;
            zeroitLabel20.BackColor = Colors.Amber.amber_header_500;
            zeroitLabel21.BackColor = Colors.Amber.amber_header_500;
            swatchNameLabel.BackColor = Colors.Amber.amber_header_500;
        }

        private void Amber_100_MouseEnter(object sender, EventArgs e)
        {
            Amber_100.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel16.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel17.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_100_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_100_MouseLeave(object sender, EventArgs e)
        {
            Amber_100.BackColor = Colors.Amber.amber_100;
            zeroitLabel16.BackColor = Colors.Amber.amber_100;
            zeroitLabel17.BackColor = Colors.Amber.amber_100;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_100_Label")
                {
                    c.BackColor = Colors.Amber.amber_100;

                }
            }
        }

        private void Amber_200_MouseEnter(object sender, EventArgs e)
        {
            Amber_200.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel14.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel15.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_200_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_200_MouseLeave(object sender, EventArgs e)
        {
            Amber_200.BackColor = Colors.Amber.amber_200;
            zeroitLabel14.BackColor = Colors.Amber.amber_200;
            zeroitLabel15.BackColor = Colors.Amber.amber_200;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_200_Label")
                {
                    c.BackColor = Colors.Amber.amber_200;

                }
            }
        }

        private void Amber_300_MouseEnter(object sender, EventArgs e)
        {
            Amber_300.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel13.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel2.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_300_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_300_MouseLeave(object sender, EventArgs e)
        {
            Amber_300.BackColor = Colors.Amber.amber_300;
            zeroitLabel13.BackColor = Colors.Amber.amber_300;
            zeroitLabel2.BackColor = Colors.Amber.amber_300;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_300_Label")
                {
                    c.BackColor = Colors.Amber.amber_300;

                }
            }
        }

        private void Amber_400_MouseEnter(object sender, EventArgs e)
        {
            Amber_400.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel23.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel24.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_400_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_400_MouseLeave(object sender, EventArgs e)
        {
            Amber_400.BackColor = Colors.Amber.amber_400;
            zeroitLabel23.BackColor = Colors.Amber.amber_400;
            zeroitLabel24.BackColor = Colors.Amber.amber_400;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_400_Label")
                {
                    c.BackColor = Colors.Amber.amber_400;

                }
            }
        }

        private void Amber_500_MouseEnter(object sender, EventArgs e)
        {
            Amber_500.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel25.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel26.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_500_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_500_MouseLeave(object sender, EventArgs e)
        {
            Amber_500.BackColor = Colors.Amber.amber_500;
            zeroitLabel25.BackColor = Colors.Amber.amber_500;
            zeroitLabel26.BackColor = Colors.Amber.amber_500;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_500_Label")
                {
                    c.BackColor = Colors.Amber.amber_500;

                }
            }
        }

        private void Amber_600_MouseEnter(object sender, EventArgs e)
        {
            Amber_600.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel27.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel28.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_600_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_600_MouseLeave(object sender, EventArgs e)
        {
            Amber_600.BackColor = Colors.Amber.amber_600;
            zeroitLabel27.BackColor = Colors.Amber.amber_600;
            zeroitLabel28.BackColor = Colors.Amber.amber_600;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_600_Label")
                {
                    c.BackColor = Colors.Amber.amber_600;

                }
            }
        }

        private void Amber_700_MouseEnter(object sender, EventArgs e)
        {
            Amber_700.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel29.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel30.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_700_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_700_MouseLeave(object sender, EventArgs e)
        {
            Amber_700.BackColor = Colors.Amber.amber_700;
            zeroitLabel29.BackColor = Colors.Amber.amber_700;
            zeroitLabel30.BackColor = Colors.Amber.amber_700;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_700_Label")
                {
                    c.BackColor = Colors.Amber.amber_700;

                }
            }
        }

        private void Amber_800_MouseEnter(object sender, EventArgs e)
        {
            Amber_800.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel31.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel32.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_800_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_800_MouseLeave(object sender, EventArgs e)
        {
            Amber_800.BackColor = Colors.Amber.amber_800;
            zeroitLabel31.BackColor = Colors.Amber.amber_800;
            zeroitLabel32.BackColor = Colors.Amber.amber_800;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_800_Label")
                {
                    c.BackColor = Colors.Amber.amber_800;

                }
            }
        }

        private void Amber_900_MouseEnter(object sender, EventArgs e)
        {
            Amber_900.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel33.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel34.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_900_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_900_MouseLeave(object sender, EventArgs e)
        {
            Amber_900.BackColor = Colors.Amber.amber_900;
            zeroitLabel33.BackColor = Colors.Amber.amber_900;
            zeroitLabel34.BackColor = Colors.Amber.amber_900;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_900_Label")
                {
                    c.BackColor = Colors.Amber.amber_900;

                }
            }
        }

        private void Amber_A100_MouseEnter(object sender, EventArgs e)
        {
            Amber_A100.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel35.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel36.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A100_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_A100_MouseLeave(object sender, EventArgs e)
        {
            Amber_A100.BackColor = Colors.Amber.amber_A100;
            zeroitLabel35.BackColor = Colors.Amber.amber_A100;
            zeroitLabel36.BackColor = Colors.Amber.amber_A100;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A100_Label")
                {
                    c.BackColor = Colors.Amber.amber_A100;

                }
            }
        }

        private void Amber_A200_MouseEnter(object sender, EventArgs e)
        {
            Amber_A200.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel37.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel38.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A200_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_A200_MouseLeave(object sender, EventArgs e)
        {
            Amber_A200.BackColor = Colors.Amber.amber_A200;
            zeroitLabel37.BackColor = Colors.Amber.amber_A200;
            zeroitLabel38.BackColor = Colors.Amber.amber_A200;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A200_Label")
                {
                    c.BackColor = Colors.Amber.amber_A200;

                }
            }
        }

        private void Amber_A400_MouseEnter(object sender, EventArgs e)
        {
            Amber_A400.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel39.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel40.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A400_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_A400_MouseLeave(object sender, EventArgs e)
        {
            Amber_A400.BackColor = Colors.Amber.amber_A400;
            zeroitLabel39.BackColor = Colors.Amber.amber_A400;
            zeroitLabel40.BackColor = Colors.Amber.amber_A400;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A400_Label")
                {
                    c.BackColor = Colors.Amber.amber_A400;

                }
            }
        }

        private void Amber_A700_MouseEnter(object sender, EventArgs e)
        {
            Amber_A700.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel41.BackColor = Color.FromArgb(0, 122, 204);
            zeroitLabel42.BackColor = Color.FromArgb(0, 122, 204);

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A700_Label")
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);

                }
            }
        }

        private void Amber_A700_MouseLeave(object sender, EventArgs e)
        {
            Amber_A700.BackColor = Colors.Amber.amber_A700;
            zeroitLabel41.BackColor = Colors.Amber.amber_A700;
            zeroitLabel42.BackColor = Colors.Amber.amber_A700;

            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Section_A700_Label")
                {
                    c.BackColor = Colors.Amber.amber_A700;

                }
            }
        }
        
        private void Amber_500_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Amber_500_Header_Click_1(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_header_500;
            //control.BackColor = Colors.Amber.amber_header_500;

        }

        private void Amber_50_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_50;
            //control.BackColor = Colors.Amber.amber_50;
        }

        private void Amber_100_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_100;
            //control.BackColor = Colors.Amber.amber_100;
        }

        private void Amber_200_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_200;
            //control.BackColor = Colors.Amber.amber_200;
        }

        private void Amber_300_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_300;
            //control.BackColor = Colors.Amber.amber_300;
        }

        private void Amber_400_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_400;
            //control.BackColor = Colors.Amber.amber_400;
        }

        private void Amber_500_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_500;
            //control.BackColor = Colors.Amber.amber_500;
        }


        private void Amber_600_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_600;
            //control.BackColor = Colors.Amber.amber_600;
        }

        private void Amber_700_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_700;
            //control.BackColor = Colors.Amber.amber_700;
        }

        private void Amber_800_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_800;
            //control.BackColor = Colors.Amber.amber_800;
        }

        private void Amber_900_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_900;
            //control.BackColor = Colors.Amber.amber_900;
        }

        private void Amber_A100_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_A100;
            //control.BackColor = Colors.Amber.amber_A100;
        }

        private void Amber_A200_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_A200;
            //control.BackColor = Colors.Amber.amber_A200;
        }

        private void Amber_A400_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_A400;
            //control.BackColor = Colors.Amber.amber_A400;
        }

        private void Amber_A700_Click(object sender, EventArgs e)
        {
            getColor = Colors.Amber.amber_A700;
            //control.BackColor = Colors.Amber.amber_A700;
        }

        private void AmberControl_Paint(object sender, PaintEventArgs e)
        {
            //formTransition.Start();

        }
        #endregion
    }
}
