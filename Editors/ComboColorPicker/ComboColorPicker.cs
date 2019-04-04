// ***********************************************************************
// Assembly         : Zeroit.Framework.FormEditors
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ComboColorPicker.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormEditors.Editors.ComboColorPicker
{
    [ToolboxItem(true)]
    public partial class ComboColorPicker : BaseColorPicker
    {
        private Color selectedColor;

        private bool webColorSelected = false;
        private bool customColorSelected = false;
        private bool systemColorSelected = false;
        private bool materialColorSelected = false;

        #region Material Colors

        private MaterialDesignColors.UserControls.Amber amber =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Amber();

        private MaterialDesignColors.UserControls.Blue blue =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Blue();

        private MaterialDesignColors.UserControls.BlueGrey blueGray =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.BlueGrey();

        private MaterialDesignColors.UserControls.Brown brown =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Brown();

        private MaterialDesignColors.UserControls.Cyan cyan =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Cyan();

        private MaterialDesignColors.UserControls.Green green =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Green();

        private MaterialDesignColors.UserControls.GreenLight greenLight =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.GreenLight();

        private MaterialDesignColors.UserControls.Grey grey =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Grey();

        private MaterialDesignColors.UserControls.Indigo indigo =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Indigo();

        private MaterialDesignColors.UserControls.LightBlue lightBlue =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.LightBlue();

        private MaterialDesignColors.UserControls.Lime lime =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Lime();

        private MaterialDesignColors.UserControls.Orange orange =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Orange();

        private MaterialDesignColors.UserControls.OrangeDeep orangeDeep =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.OrangeDeep();

        private MaterialDesignColors.UserControls.Pink pink =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Pink();

        private MaterialDesignColors.UserControls.Purple purple =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Purple();

        private MaterialDesignColors.UserControls.PurpleDeep purpleDeep =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.PurpleDeep();

        private MaterialDesignColors.UserControls.Red red =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Red();

        private MaterialDesignColors.UserControls.Teal teal =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Teal();

        private MaterialDesignColors.UserControls.Yellow yellow =
            new Zeroit.Framework.FormEditors.MaterialDesignColors.UserControls.Yellow();


        #endregion

        #region Private Methods


        #region Amber

        public void Add_Amber()
        {
            this.Controls.Add(this.amber);
            this.amber.Visible = true;
            this.amber.Location = new System.Drawing.Point(131, 8);
            //this.amber.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Amber()
        {
            this.amber.Visible = false;
            this.Controls.Remove(amber);
        }

        #endregion

        #region Blue

        public void Add_Blue()
        {
            this.Controls.Add(this.blue);
            this.blue.Visible = true;
            this.blue.Location = new System.Drawing.Point(131, 8);
            //this.blue.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Blue()
        {
            this.blue.Visible = false;
            this.Controls.Remove(blue);
        }

        #endregion

        #region Blue Gray

        public void Add_BlueGray()
        {
            this.Controls.Add(this.blueGray);
            this.blueGray.Visible = true;
            this.blueGray.Location = new System.Drawing.Point(131, 8);
            //this.blueGray.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_BlueGray()
        {
            this.blueGray.Visible = false;
            this.Controls.Remove(blueGray);
        }

        #endregion

        #region Brown

        public void Add_Brown()
        {
            this.Controls.Add(this.brown);
            this.brown.Visible = true;
            this.brown.Location = new System.Drawing.Point(131, 8);
            //this.brown.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Brown()
        {
            this.brown.Visible = false;
            this.Controls.Remove(brown);
        }

        #endregion

        #region Cyan

        public void Add_Cyan()
        {
            this.Controls.Add(this.cyan);
            this.cyan.Visible = true;
            this.cyan.Location = new System.Drawing.Point(131, 8);
            //this.cyan.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Cyan()
        {
            this.cyan.Visible = false;
            this.Controls.Remove(cyan);
        }

        #endregion

        #region Green

        public void Add_Green()
        {
            this.Controls.Add(this.green);
            this.green.Visible = true;
            this.green.Location = new System.Drawing.Point(131, 8);
            //this.green.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Green()
        {
            this.green.Visible = false;
            this.Controls.Remove(green);
        }

        #endregion

        #region Green Light

        public void Add_GreenLight()
        {
            this.Controls.Add(this.greenLight);
            this.greenLight.Visible = true;
            this.greenLight.Location = new System.Drawing.Point(131, 8);
            //this.greenLight.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_GreenLight()
        {
            this.greenLight.Visible = false;
            this.Controls.Remove(greenLight);
        }

        #endregion

        #region Gray

        public void Add_Gray()
        {
            this.Controls.Add(this.grey);
            this.grey.Visible = true;
            this.grey.Location = new System.Drawing.Point(131, 8);
            //this.grey.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Gray()
        {
            this.grey.Visible = false;
            this.Controls.Remove(grey);
        }

        #endregion

        #region Indigo

        public void Add_Indigo()
        {
            this.Controls.Add(this.indigo);
            this.indigo.Visible = true;
            this.indigo.Location = new System.Drawing.Point(131, 8);
            //this.indigo.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Indigo()
        {
            this.indigo.Visible = false;
            this.Controls.Remove(indigo);
        }

        #endregion

        #region Light Blue

        public void Add_LightBlue()
        {
            this.Controls.Add(this.lightBlue);
            this.lightBlue.Visible = true;
            this.lightBlue.Location = new System.Drawing.Point(131, 8);
            //this.lightBlue.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_LightBlue()
        {
            this.lightBlue.Visible = false;
            this.Controls.Remove(lightBlue);
        }

        #endregion

        #region Lime

        public void Add_Lime()
        {
            this.Controls.Add(this.lime);
            this.lime.Visible = true;
            this.lime.Location = new System.Drawing.Point(131, 8);
            //this.lime.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Lime()
        {
            this.lime.Visible = false;
            this.Controls.Remove(lime);
        }

        #endregion

        #region Orange

        public void Add_Orange()
        {
            this.Controls.Add(this.orange);
            this.orange.Visible = true;
            this.orange.Location = new System.Drawing.Point(131, 8);
            //this.orange.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Orange()
        {
            this.orange.Visible = false;
            this.Controls.Remove(orange);
        }

        #endregion

        #region Orange Deep

        public void Add_OrangeDeep()
        {
            this.Controls.Add(this.orangeDeep);
            this.orangeDeep.Visible = true;
            this.orangeDeep.Location = new System.Drawing.Point(131, 8);
            //this.orangeDeep.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_OrangeDeep()
        {
            this.orangeDeep.Visible = false;
            this.Controls.Remove(orangeDeep);
        }

        #endregion

        #region Pink

        public void Add_Pink()
        {
            this.Controls.Add(this.pink);
            this.pink.Visible = true;
            this.pink.Location = new System.Drawing.Point(131, 8);
            //this.pink.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Pink()
        {
            this.pink.Visible = false;
            this.Controls.Remove(pink);
        }

        #endregion

        #region Purple

        public void Add_Purple()
        {
            this.Controls.Add(this.purple);
            this.purple.Visible = true;
            this.purple.Location = new System.Drawing.Point(131, 8);
            //this.purple.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Purple()
        {
            this.purple.Visible = false;
            this.Controls.Remove(purple);
        }

        #endregion

        #region Purple Deep

        public void Add_PurpleDeep()
        {
            this.Controls.Add(this.purpleDeep);
            this.purpleDeep.Visible = true;
            this.purpleDeep.Location = new System.Drawing.Point(131, 8);
            //this.purpleDeep.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_PurpleDeep()
        {
            this.purpleDeep.Visible = false;
            this.Controls.Remove(purpleDeep);
        }

        #endregion

        #region Red

        public void Add_Red()
        {
            this.Controls.Add(this.red);
            this.red.Visible = true;
            this.red.Location = new System.Drawing.Point(131, 8);
            //this.red.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Red()
        {
            this.red.Visible = false;
            this.Controls.Remove(red);
        }

        #endregion

        #region Teal

        public void Add_Teal()
        {
            this.Controls.Add(this.teal);
            this.teal.Visible = true;
            this.teal.Location = new System.Drawing.Point(131, 8);
            //this.teal.Size = new System.Drawing.Size(398, 626);

        }

        private void Remove_Teal()
        {
            this.teal.Visible = false;
            this.Controls.Remove(teal);
        }

        #endregion

        #region Yellow

        public void Add_Yellow()
        {
            this.Controls.Add(this.yellow);
            this.yellow.Visible = true;
            this.yellow.Location = new System.Drawing.Point(131, 8);
            //this.yellow.Size = new System.Drawing.Size(398, 626);
            
        }

        private void Remove_Yellow()
        {
            this.yellow.Visible = false;
            this.Controls.Remove(yellow);
        }

        #endregion

        #endregion

        /// <summary>
        /// 	Constructor with no starting color.
        /// </summary>
        public ComboColorPicker() : this(Color.Empty)
        {
        }

        /// <summary>
        /// 	Constructor with starting color.
        /// </summary>
        /// <param name="color">Starting color.</param>
        public ComboColorPicker(Color color)
        {
            InitializeComponent();
            webColorPicker.BorderStyle = BorderStyle.None;
            customColorPicker.BorderStyle = BorderStyle.None;
            systemColorPicker.BorderStyle = BorderStyle.None;

            webColorPicker.Location = new Point(140, 10);
            customColorPicker.Location = new Point(140, 10);
            systemColorPicker.Location = new Point(140, 10);

            selectedColor = webColorPicker.Color;
            webColorSelected = true;

            SetColor(color);
        }

        /// <summary>
        /// 	Set current selected color.
        /// </summary>
        /// <param name="color">Current color.</param>
        /// <returns><c>True</c>.</returns>
        public override bool SetColor(Color color)
        {
            customColorPicker.SetColor(color);

            if (webColorPicker.SetColor(color))
            {
                webColorPicker.Visible = true;
                customColorPicker.Visible = false;
                systemColorPicker.Visible = false;
                mainColor_MaterialColors.Visible = false;
            }
            else if (systemColorPicker.SetColor(color))
            {
                webColorPicker.Visible = false;
                customColorPicker.Visible = false;
                systemColorPicker.Visible = true;
                mainColor_MaterialColors.Visible = false;
            }
            else if(customColorPicker.Visible == true)
            {
                webColorPicker.Visible = false;
                customColorPicker.Visible = true;
                systemColorPicker.Visible = false;
                mainColor_MaterialColors.Visible = false;
            }
            else if (mainColor_MaterialColors.Visible == true)
            {
                webColorPicker.Visible = false;
                customColorPicker.Visible = true;
                systemColorPicker.Visible = false;
                mainColor_MaterialColors.Visible = true;
            }
            return true;
        }

        public Color Color
        {
            get { return selectedColor; }
            //set
            //{
            //    selectedColor = value;
            //}
        }

        
        private Color GetColor()
        {
             
            if (webColorSelected == true)
            {
                
                selectedColor = webColorPicker.Color;
            }
            else if (customColorSelected == true)
            {
                selectedColor = customColorPicker.Color;
            }
            else if (systemColorSelected == true)
            {
                selectedColor = systemColorPicker.Color;
            }
            else
            {
                materialColorSelected = true;

                if (amber.Visible == true)
                {
                    selectedColor = amber.Color;
                    preview_Panel.BackColor = amber.Color;
                }
                else if (blue.Visible == true)
                {
                    selectedColor = blue.Color;
                    preview_Panel.BackColor = blue.Color;
                }
                else if (blueGray.Visible == true)
                {
                    selectedColor = blueGray.Color;
                    preview_Panel.BackColor = blueGray.Color;
                }
                else if (brown.Visible == true)
                {
                    selectedColor = brown.Color;
                    preview_Panel.BackColor = brown.Color;
                }
                else if (cyan.Visible == true)
                {
                    selectedColor = cyan.Color;
                    preview_Panel.BackColor = cyan.Color;
                }
                else if (green.Visible == true)
                {
                    selectedColor = green.Color;
                    preview_Panel.BackColor = green.Color;
                }
                else if (greenLight.Visible == true)
                {
                    selectedColor = greenLight.Color;
                    preview_Panel.BackColor = greenLight.Color;
                }
                else if (grey.Visible == true)
                {
                    selectedColor = grey.Color;
                    preview_Panel.BackColor = grey.Color;
                }
                else if (indigo.Visible == true)
                {
                    selectedColor = indigo.Color;
                    preview_Panel.BackColor = indigo.Color;
                }
                else if (lightBlue.Visible == true)
                {
                    selectedColor = lightBlue.Color;
                    preview_Panel.BackColor = lightBlue.Color;
                }
                else if (lime.Visible == true)
                {
                    selectedColor = lime.Color;
                    preview_Panel.BackColor = lime.Color;
                }
                else if (orange.Visible == true)
                {
                    selectedColor = orange.Color;
                    preview_Panel.BackColor = orange.Color;
                }
                else if (orangeDeep.Visible == true)
                {
                    selectedColor = orangeDeep.Color;
                    preview_Panel.BackColor = orangeDeep.Color;
                }
                else if (pink.Visible == true)
                {
                    selectedColor = pink.Color;
                    preview_Panel.BackColor = pink.Color;
                }
                else if (purple.Visible == true)
                {
                    selectedColor = purple.Color;
                    preview_Panel.BackColor = purple.Color;
                }
                else if (purpleDeep.Visible == true)
                {
                    selectedColor = purpleDeep.Color;
                    preview_Panel.BackColor = purpleDeep.Color;
                }
                else if (red.Visible == true)
                {
                    selectedColor = red.Color;
                    preview_Panel.BackColor = red.Color;
                }
                else if (teal.Visible == true)
                {
                    selectedColor = teal.Color;
                    preview_Panel.BackColor = teal.Color;
                }
                else 
                {
                    selectedColor = yellow.Color;
                    preview_Panel.BackColor = yellow.Color;
                }

            }

            return selectedColor;
        }


        private void webColor_Btn_MouseEnter(object sender, EventArgs e)
        {
            webColor_Btn.FlatAppearance.BorderSize = 1;
            webColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void webColor_Btn_MouseLeave(object sender, EventArgs e)
        {
            webColor_Btn.FlatAppearance.BorderSize = 0;
            webColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }


        private void customColor_Btn_MouseEnter(object sender, EventArgs e)
        {
            customColor_Btn.FlatAppearance.BorderSize = 1;
            customColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void customColor_Btn_MouseLeave(object sender, EventArgs e)
        {
            customColor_Btn.FlatAppearance.BorderSize = 0;
            customColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void systemColor_Btn_MouseEnter(object sender, EventArgs e)
        {
            systemColor_Btn.FlatAppearance.BorderSize = 1;
            systemColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void systemColor_Btn_MouseLeave(object sender, EventArgs e)
        {
            systemColor_Btn.FlatAppearance.BorderSize = 0;
            systemColor_Btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void material_Btn_MouseEnter(object sender, EventArgs e)
        {
            material_Btn.FlatAppearance.BorderSize = 1;
            material_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void material_Btn_MouseLeave(object sender, EventArgs e)
        {
            material_Btn.FlatAppearance.BorderSize = 0;
            material_Btn.FlatAppearance.BorderColor = Color.FromArgb(22, 22, 22);
        }

        private void tab_ColorSelected(object sender, ColorSelectedEventArgs args)
        {
            SelectColor(args);
        }

        private void webColor_Btn_Click(object sender, EventArgs e)
        {
            webColorPicker.Visible = true;
            customColorPicker.Visible = false;
            systemColorPicker.Visible = false;
            mainColor_MaterialColors.Visible = false;

            webColorSelected = true;
            customColorSelected = false;
            systemColorSelected = false;
            materialColorSelected = false;

            preview_Panel.Visible = false;
            select_Btn.Visible = false;

            GetColor();

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();

        }

        private void systemColor_Btn_Click(object sender, EventArgs e)
        {
            webColorPicker.Visible = false;
            customColorPicker.Visible = false;
            systemColorPicker.Visible = true;
            mainColor_MaterialColors.Visible = false;

            webColorSelected = false;
            customColorSelected = false;
            systemColorSelected = true;
            materialColorSelected = false;

            preview_Panel.Visible = false;
            select_Btn.Visible = false;

            GetColor();

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();

        }

        private void customColor_Btn_Click(object sender, EventArgs e)
        {
            webColorPicker.Visible = false;
            customColorPicker.Visible = true;
            systemColorPicker.Visible = false;
            mainColor_MaterialColors.Visible = false;

            webColorSelected = false;
            customColorSelected = true;
            systemColorSelected = false;
            materialColorSelected = false;

            preview_Panel.Visible = false;
            select_Btn.Visible = false;

            GetColor();

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void zeroitLabel8_Click(object sender, EventArgs e)
        {

        }

        private void zeroitLabel9_Click(object sender, EventArgs e)
        {

        }

        private void material_Btn_Click(object sender, EventArgs e)
        {
            webColorPicker.Visible = false;
            customColorPicker.Visible = false;
            systemColorPicker.Visible = false;
            mainColor_MaterialColors.Visible = true;

            webColorSelected = false;
            customColorSelected = false;
            systemColorSelected = false;
            materialColorSelected = true;

            preview_Panel.Visible = true;
            select_Btn.Visible = true;

            GetColor();

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Amber_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Add_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Blue_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Add_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_BlueGray_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Add_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Brown_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Add_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Cyan_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Add_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Green_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Add_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_LightGreen_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Add_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Gray_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Add_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Indigo_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Add_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_LightBlue_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Add_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Lime_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Add_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Orange_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Add_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_DeepOrange_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Add_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Pink_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Add_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Purple_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Add_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_DeepPurple_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Add_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Red_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Add_Red();
            Remove_Teal();
            Remove_Yellow();
        }

        private void mainColor_Teal_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Add_Teal();
            Remove_Yellow();
        }

        private void mainColor_Yellow_Click(object sender, EventArgs e)
        {
            mainColor_MaterialColors.Visible = false;

            Remove_Amber();
            Remove_Blue();
            Remove_BlueGray();
            Remove_Brown();
            Remove_Cyan();
            Remove_Green();
            Remove_GreenLight();
            Remove_Gray();
            Remove_Indigo();
            Remove_LightBlue();
            Remove_Lime();
            Remove_Orange();
            Remove_OrangeDeep();
            Remove_Pink();
            Remove_Purple();
            Remove_PurpleDeep();
            Remove_Red();
            Remove_Teal();
            Add_Yellow();
        }
    }
}
