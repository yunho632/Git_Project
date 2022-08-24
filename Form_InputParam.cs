using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WVision;

namespace WVision
{
    public partial class Form_InputParam : Form
    {
        public string result = "";

        KeyValuePair<string, CToolParam> Params;
        public Form_InputParam(KeyValuePair<string, CToolParam> vParam)
        {
            this.Params = vParam;
            InitializeComponent();

            this.InitControls();
            this.UpdateControl();

            this.result = this.Params.Value.strValue;

            if (this.Params.Value.ControlType == enum_ControlType.COMBO) this.panel_Combo.Tag = this.Params.Value.cmbValue;

        }

        private void InitControls()
        {
            foreach (Control C in panel_Number.Controls)
            {
                if (C.GetType() == typeof(Button))
                {
                    ((Button)C).Click += Number_InputParam_Click;
                    if (Params.Value.DecimalCount == "0")
                    {
                        if (((Button)C).Text.IndexOf(".") > -1)
                        {
                            ((Button)C).Enabled = false;
                        }
                    }
                }

            }
            // 키보드
            foreach (Control C in panel_Text.Controls)
            {
                if (C.GetType() == typeof(Button))
                {
                    ((Button)C).Click += TEXT_InputParam_Click;

                }

            }


            this.panel_Combo.Controls.Clear();
            if (Params.Value.ControlType == enum_ControlType.COMBO)
            {
                string[] ComboItems = Params.Value.ComboData.Split(',');
                for (int i = 0; i < ComboItems.Length; i++)
                {
                    Button btnCombo = new Button();

                    int cboIndex = 0;

                    if (!int.TryParse(Params.Value.strValue,out cboIndex))
                    {
                        for (int x = 0; x < ComboItems.Length; x++)
                        {
                            if (Params.Value.strValue == ComboItems[x])
                            {
                                cboIndex = x;
                            }
                        }
                    }
                    
                    

                    btnCombo.BackColor = cboIndex == i ? System.Drawing.Color.Aqua : System.Drawing.Color.White;
                    btnCombo.ForeColor = cboIndex == i ? System.Drawing.Color.Black : System.Drawing.Color.Red;
                    btnCombo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    btnCombo.FlatAppearance.BorderSize = 0;
                    btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

                    btnCombo.Location = new System.Drawing.Point(3, 3 + (36 * i));
                    btnCombo.Name = "button_cb" + i.ToString();
                    btnCombo.Size = new System.Drawing.Size(panel_Combo.Width - 6, 34);
                    btnCombo.TabIndex = 3;
                    btnCombo.Text = ComboItems[i];
                    btnCombo.Tag = i;
                    btnCombo.UseVisualStyleBackColor = false;
                    btnCombo.Click += btnCombo_Click;

                    this.panel_Combo.Controls.Add(btnCombo);
                }

            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            int idx = (int)((Button)sender).Tag;

            this.panel_Combo.Tag = ((Button)sender).Text;

            foreach (Control C in panel_Combo.Controls)
            {
                if (C.GetType() == typeof(Button))
                {
                    C.BackColor = (int)C.Tag == idx ? System.Drawing.Color.Aqua : System.Drawing.Color.White;
                    C.ForeColor = (int)C.Tag == idx ? System.Drawing.Color.Black : System.Drawing.Color.Red;

                }

            }
        }

        private void TEXT_InputParam_Click(object sender, EventArgs e)
        {
            string v = ((Button)sender).Text;

            if (v == "BS(<-)")
            {
                if (textBox1.Text.Length == 0) textBox1.Text = "";
                if (textBox1.Text.Length == 1) textBox1.Text = "";
                if (textBox1.Text.Length > 1) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else if (v == "CLEAR")
            {
                textBox1.Text = "";
            }
            else
            {
                textBox1.Text += v;
            }
        }

        private void Number_InputParam_Click(object sender, EventArgs e)
        {
            string v = ((Button)sender).Text;

            decimal nValue = numericUpDown_Value.Value + Convert.ToDecimal(v);

            if (nValue >= numericUpDown_Value.Minimum && nValue <= numericUpDown_Value.Maximum)
            {
                numericUpDown_Value.Value = nValue;
            }
        }

        private void UpdateControl()
        {
            this.panel_Combo.Visible = false;
            this.panel_Number.Visible = false;
            this.panel_Text.Visible = false;

            if (Params.Value.ControlType == enum_ControlType.COMBO)
            {
                this.panel_Combo.Location = new Point(1, 1);
                this.panel_Combo.Visible = true;


                this.vScrollBar1.Minimum = 0;
                this.vScrollBar1.Maximum = (this.Params.Value.ComboData.Split(',').Length) * 10;

                int combValue;
                if (int.TryParse(this.Params.Value.strValue, out combValue))
                {
                    this.vScrollBar1.Value = combValue;
                }
                else
                {
                    this.vScrollBar1.Value = 0;
                }



                this.Size = new Size(this.panel_Combo.Width + 2 + 100, this.panel_Combo.Height + 99);
            }
            if (Params.Value.ControlType == enum_ControlType.NUMBER)
            {
                this.panel_Number.Location = new Point(2, 2);
                this.panel_Number.Visible = true;

                this.numericUpDown_Value.Minimum = decimal.Parse(this.Params.Value.RangeMin);
                this.numericUpDown_Value.Maximum = decimal.Parse(this.Params.Value.RangeMax);
                this.numericUpDown_Value.Value = decimal.Parse(this.Params.Value.strValue);
                this.numericUpDown_Value.DecimalPlaces = Convert.ToInt16(this.Params.Value.DecimalCount);

                string strdecimal = "";
                decimal nRatio = 1000;
                if (Params.Value.DecimalCount != "0")
                {
                    strdecimal = "1";
                    strdecimal = strdecimal.PadRight(int.Parse(Params.Value.DecimalCount) + 1, '0');

                    nRatio = Convert.ToDecimal(strdecimal);
                }


                this.vScrollBar1.Minimum = Convert.ToInt32(Decimal.Parse(Params.Value.RangeMin) * nRatio);
                this.vScrollBar1.Maximum = Convert.ToInt32(Decimal.Parse(Params.Value.RangeMax) * nRatio);
                this.vScrollBar1.Value = Convert.ToInt32(this.numericUpDown_Value.Value * nRatio);

                this.Size = new Size(this.panel_Number.Width + 2 + 100, this.panel_Number.Height + 99);
            }
            if (Params.Value.ControlType == enum_ControlType.TEXT || Params.Value.ControlType == enum_ControlType.PASSWORD)
            {

                this.panel_Text.Location = new Point(2, 2);
                this.panel_Text.Visible = true;

                if (Params.Value.ControlType == enum_ControlType.PASSWORD) this.textBox1.PasswordChar = '*';
                this.textBox1.Text = this.Params.Value.strValue;


                this.vScrollBar1.Enabled = false;
                this.vScrollBar1.Visible = false;


                this.Size = new Size(this.panel_Text.Width + 2 + 100, this.panel_Text.Height + 99);
            }
            if (Params.Value.ControlType == enum_ControlType.DECIMAL)
            {
                this.panel_Decimal.Location = new Point(2, 2);
                this.panel_Decimal.Visible = true;


                this.textBox_DValue.Text = this.Params.Value.strValue;


                this.vScrollBar1.Enabled = false;
                this.vScrollBar1.Visible = false;

                this.label_InputRange.Text = string.Format("label_InputRange {0} ~ {1}", this.Params.Value.RangeMin, this.Params.Value.RangeMax);
                this.Size = new Size(this.panel_Decimal.Width + 2 + 100, this.panel_Decimal.Height + 99);
            }

        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.panel_Number.Visible)
            {
                this.numericUpDown_Value.Value = Convert.ToDecimal(e.NewValue / 1000);
            }

            if (this.panel_Combo.Visible)
            {
                int idx = e.NewValue / 10;

                foreach (Control C in panel_Combo.Controls)
                {
                    if (C.GetType() == typeof(Button))
                    {
                        if (C.Tag != null)
                        {
                            C.BackColor = (int)C.Tag == idx ? System.Drawing.Color.Aqua : System.Drawing.Color.White;
                            C.ForeColor = (int)C.Tag == idx ? System.Drawing.Color.Black : System.Drawing.Color.Red;

                            if ((int)C.Tag == idx)
                            {
                                this.panel_Combo.Tag = C.Text;
                            }
                        }


                    }

                }
            }

        }

        private void Form_InputParam_Shown(object sender, EventArgs e)
        {

        }

        private void Form_InputParam_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        #region "결과"
        private void button_Apply_Click(object sender, EventArgs e)
        {
            this.result = this.getResult();
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.result = this.getResult();
            this.DialogResult = DialogResult.Cancel;
        }

        private string getResult()
        {
            if (Params.Value.ControlType == enum_ControlType.COMBO)
            {
                return panel_Combo.Tag.ToString();
            }
            else if (Params.Value.ControlType == enum_ControlType.NUMBER)
            {
                return numericUpDown_Value.Value.ToString();
            }
            else if (Params.Value.ControlType == enum_ControlType.TEXT)
            {
                return textBox1.Text;

            }
            else if (Params.Value.ControlType == enum_ControlType.DECIMAL)
            {
                return textBox_DValue.Text;
            }
            else
            {
                return "";
            }
        }

        #endregion

        private void button_Num_Click(object sender, EventArgs e)
        {
            this.textBox_DValue.HideSelection = true;

            string sValue = ((Button)sender).Text;
            string vValue = "";

            if (sValue == "CE") { this.textBox_DValue.Text = "0"; return; }

            if (sValue == "<-")
            {

                if (this.textBox_DValue.Text.Length == 1) { this.textBox_DValue.Text = "0"; return; }

                vValue = this.textBox_DValue.Text.Substring(0, this.textBox_DValue.Text.Length - 1);


            }
            else if (sValue == "-")
            {
                if (this.textBox1.Text.StartsWith("-"))
                {
                    vValue = this.textBox_DValue.Text.Replace("-", "");
                }
                else
                {
                    vValue = sValue + this.textBox_DValue.Text;
                }
            }
            else if (sValue == ".")
            {
                if (this.textBox_DValue.Text.IndexOf(".") == -1)
                {
                    this.textBox_DValue.Text += ".";
                    return;
                }
            }
            else
            {
                if (textBox_DValue.Text == "0")
                {
                    vValue = sValue;
                }
                else if (textBox_DValue.Text == "-0")
                {
                    vValue = "-" + sValue;
                }
                else
                {
                    vValue = textBox_DValue.Text + sValue;
                }

            }


            decimal dValue;
            if (decimal.TryParse(vValue, out dValue))
            {
                if (dValue >= Convert.ToDecimal(this.Params.Value.RangeMin) &&
                    dValue <= Convert.ToDecimal(this.Params.Value.RangeMax))
                {
                    textBox_DValue.Text = dValue.ToString();
                }
            }
        }
    }
    /*
    public partial class Form_InputParam : Form
    {
        public string result="";

        KeyValuePair<string, CToolParam> Params;
        public Form_InputParam(KeyValuePair<string, CToolParam> vParam)
        {
            this.Params = vParam;
            InitializeComponent();

            this.InitControls();
            this.UpdateControl();

            this.result = this.Params.Value.strValue;
            
            if(this.Params.Value.ControlType == enum_ControlType.COMBO) this.panel_Combo.Tag = this.Params.Value.cmbValue;

        }

        private void InitControls()
        {
            foreach (Control C in panel_Number.Controls)
            {
                if (C.GetType() == typeof(Button))
                {
                    ((Button)C).Click += Number_InputParam_Click;
                    if (Params.Value.DecimalCount == "0")
                    {
                        if (((Button)C).Text.IndexOf(".") > -1)
                        {
                            ((Button)C).Enabled = false;
                        }
                    }
                }
                
            }
            // 키보드
            foreach (Control C in panel_Text.Controls)
            {
                if (C.GetType() == typeof(Button))
                {
                    ((Button)C).Click += TEXT_InputParam_Click;
                   
                }

            }


            this.panel_Combo.Controls.Clear();
            if(Params.Value.ControlType == enum_ControlType.COMBO)
            {
                string[] ComboItems = Params.Value.ComboData.Split(',');
                for(int i=0;i<ComboItems.Length;i++)
                {
                    Button btnCombo = new Button();

                    
                    btnCombo.BackColor = Params.Value.strValue == i.ToString() ? System.Drawing.Color.Aqua : System.Drawing.Color.White;
                    btnCombo.ForeColor = Params.Value.strValue == i.ToString() ? System.Drawing.Color.Black : System.Drawing.Color.Red;
                    btnCombo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    btnCombo.FlatAppearance.BorderSize = 0;
                    btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    
                    btnCombo.Location = new System.Drawing.Point(3, 3 + (36*i));
                    btnCombo.Name = "button_cb" + i.ToString();
                    btnCombo.Size = new System.Drawing.Size(panel_Combo.Width - 6, 34);
                    btnCombo.TabIndex = 3;
                    btnCombo.Text = ComboItems[i];
                    btnCombo.Tag = i;
                    btnCombo.UseVisualStyleBackColor = false;
                    btnCombo.Click += btnCombo_Click;

                    this.panel_Combo.Controls.Add(btnCombo);
                }
                
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            int idx = (int)((Button)sender).Tag;

            this.panel_Combo.Tag = ((Button)sender).Text;

            foreach (Control C in panel_Combo.Controls)
            {
                if (C.GetType() == typeof(Button))
                {
                    C.BackColor = (int)C.Tag == idx ? System.Drawing.Color.Aqua : System.Drawing.Color.White;
                    C.ForeColor = (int)C.Tag == idx ? System.Drawing.Color.Black : System.Drawing.Color.Red;

                }

            }
        }

        private void TEXT_InputParam_Click(object sender, EventArgs e)
        {
            string v = ((Button)sender).Text;

            if (v == "BS(<-)")
            {
                if (textBox1.Text.Length == 0) textBox1.Text = "";
                if (textBox1.Text.Length == 1) textBox1.Text = "";
                if (textBox1.Text.Length > 1) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            } else if (v == "CLEAR")
            {
                textBox1.Text = "";
            } else
            {
                textBox1.Text += v;
            }
        }

        private void Number_InputParam_Click(object sender, EventArgs e)
        {
            string v = ((Button)sender).Text;

            decimal nValue = numericUpDown_Value.Value + Convert.ToDecimal(v);

            if(nValue >= numericUpDown_Value.Minimum && nValue <= numericUpDown_Value.Maximum)
            {
                numericUpDown_Value.Value = nValue;

                this.vScrollBar1.Value = Convert.ToInt32(nValue);
            }
        }

        private void UpdateControl()
        {
            this.panel_Combo.Visible = false;
            this.panel_Number.Visible = false;
            this.panel_Text.Visible = false;

            if (Params.Value.ControlType == enum_ControlType.COMBO)
            {
                this.panel_Combo.Location = new Point(1, 1);
                this.panel_Combo.Visible = true;


                this.vScrollBar1.Minimum = 0;
                this.vScrollBar1.Maximum = (this.Params.Value.ComboData.Split(',').Length) * 10;                
                this.vScrollBar1.Value = Convert.ToInt16(this.Params.Value.strValue);

                this.Size = new Size(this.panel_Combo.Width + 2 + 100, this.panel_Combo.Height + 99);
            }
            if (Params.Value.ControlType == enum_ControlType.NUMBER)
            {
                this.panel_Number.Location = new Point(2, 2);
                this.panel_Number.Visible = true;
                
                this.numericUpDown_Value.Minimum = decimal.Parse(this.Params.Value.RangeMin);
                this.numericUpDown_Value.Maximum = decimal.Parse(this.Params.Value.RangeMax);
                this.numericUpDown_Value.Value = decimal.Parse(this.Params.Value.strValue);
                this.numericUpDown_Value.DecimalPlaces = Convert.ToInt16(this.Params.Value.DecimalCount);

                this.vScrollBar1.Minimum = Convert.ToInt32(this.numericUpDown_Value.Minimum );
                this.vScrollBar1.Maximum = Convert.ToInt32(this.numericUpDown_Value.Maximum ) + Convert.ToInt32(this.numericUpDown_Value.Maximum / 7); // 15% 스크롤 max 버튼 영역 예외처리
                this.vScrollBar1.Value = Convert.ToInt32(this.numericUpDown_Value.Value);

                this.Size = new Size(this.panel_Number.Width + 2 + 100, this.panel_Number.Height + 99);
            }
            if (Params.Value.ControlType == enum_ControlType.TEXT || Params.Value.ControlType == enum_ControlType.PASSWORD)
            {

                this.panel_Text.Location = new Point(2, 2);
                this.panel_Text.Visible = true;
                
                if (Params.Value.ControlType == enum_ControlType.PASSWORD) this.textBox1.PasswordChar = '*';
                this.textBox1.Text = this.Params.Value.strValue;

                this.Size = new Size(this.panel_Text.Width + 2 + 100, this.panel_Text.Height + 99);
            }

        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if(this.panel_Number.Visible)
            {
                decimal nValue = Convert.ToDecimal(e.NewValue);

                if (nValue >= numericUpDown_Value.Minimum && nValue <= numericUpDown_Value.Maximum)
                {
                    numericUpDown_Value.Value = nValue;

                }

                System.Diagnostics.Debug.Print(e.NewValue.ToString());
            }

            if (this.panel_Combo.Visible)
            {
                int idx = e.NewValue / 10;

                foreach (Control C in panel_Combo.Controls)
                {
                    if (C.GetType() == typeof(Button))
                    {
                        if (C.Tag != null)
                        {
                            C.BackColor = (int)C.Tag == idx ? System.Drawing.Color.Aqua : System.Drawing.Color.White;
                            C.ForeColor = (int)C.Tag == idx ? System.Drawing.Color.Black : System.Drawing.Color.Red;

                            if((int)C.Tag == idx)
                            {
                                this.panel_Combo.Tag = C.Text;
                            }
                        }
                        

                    }

                }
            }

        }

        private void Form_InputParam_Shown(object sender, EventArgs e)
        {

        }

        private void Form_InputParam_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        #region "결과"
        private void button_Apply_Click(object sender, EventArgs e)
        {
            this.result = this.getResult();
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.result = this.getResult();
            this.DialogResult = DialogResult.Cancel;
        }

        private string getResult()
        {
            if (Params.Value.ControlType == enum_ControlType.COMBO)
            {
                return panel_Combo.Tag.ToString();
            }
            else if (Params.Value.ControlType == enum_ControlType.NUMBER)
            {
                return numericUpDown_Value.Value.ToString();
            }
            else if (Params.Value.ControlType == enum_ControlType.TEXT)
            {
                return textBox1.Text;
            } else
            {
                return "";
            }
        }

        #endregion
    }

    */
}
