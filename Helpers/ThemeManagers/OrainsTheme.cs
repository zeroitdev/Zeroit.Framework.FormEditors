﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="OrainsTheme.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.FormEditors.HelperControls.ThemeManagers
{


    /// <summary>
    /// Class Orains.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormEditors.HelperControls.ThemeManagers.ThemeContainer" />
    [ToolboxItem(false)]
    public class Orains : ThemeContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orains"/> class.
        /// </summary>
        public Orains()
        {
            TransparencyKey = Color.Fuchsia;
            BackColor = Color.FromArgb(20, 20, 20);
            Font = new Font("Segoe UI", 9);
            
        }

        /// <summary>
        /// The border
        /// </summary>
        Color Border = Color.Black;
        /// <summary>
        /// The text color
        /// </summary>
        Color TextColor = Color.Orange;
        /// <summary>
        /// The r1
        /// </summary>
        Color R1 = Color.FromArgb(14, 14, 14);
        /// <summary>
        /// The r2
        /// </summary>
        Color R2 = Color.FromArgb(20, 20, 20);
        /// <summary>
        /// The inner border
        /// </summary>
        Color InnerBorder = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The outerborder
        /// </summary>
        Color outerborder = Color.Black;
        /// <summary>
        /// The bg color
        /// </summary>
        Color BGColor = Color.FromArgb(20, 20, 20);

        /// <summary>
        /// The header c
        /// </summary>
        Color HeaderC = Color.FromArgb(22, 22, 22);

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            G = e.Graphics;

            G.Clear(R1);
            
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), R1, R2, -90);
            G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));


            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(75, Color.Black), Color.Transparent);
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));

            // w x 2 + 1 =  , w + h = 
            G.FillRectangle(new SolidBrush(BGColor), new Rectangle(8, 28, Width - 17, Height - 36));
            G.DrawRectangle(new Pen(InnerBorder), 9, 29, Width - 19, Height - 38);
            G.DrawRectangle(new Pen(outerborder), new Rectangle(8, 28, Width - 17, Height - 36));

            G.DrawRectangle(new Pen(outerborder), new Rectangle(0, 0, Width - 1, Height - 1));
            // OuterBorder of BackColor

            //  G.FillRectangle(HeaderC, New Rectangle(0, 0, Width - 1, 15))
            //  Dim BodyHatch2 As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch2, New Rectangle(0, 0, Width - 1, 15))

            G.DrawRectangle(new Pen(InnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
            //InnerBorder of BackCOlor' 


            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(TextColor), new Point(35, 7));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 4, 22, 22));

            // DrawCorners(Color.Fuchsia)
        }
    }
    

}


