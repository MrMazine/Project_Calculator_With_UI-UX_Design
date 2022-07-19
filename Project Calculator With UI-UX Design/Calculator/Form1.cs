using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form_Calculator : Form
    {
        public Form_Calculator()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;  

        private void gunaElipsePanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGradientTileButton12_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = string.Empty;
            Lbl_Complete_Results.Text = string.Empty;
        }

        private void Panel_MenuStrip_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 0;
        }

        private void Btn_Dot_Click(object sender, EventArgs e)
        {

            int c = Lbl_Results.Text.Length;
            // MessageBox.Show(c.ToString());
            bool flag = false;
            string Str = Lbl_Results.Text;
            for (int i = 0; i < c; i++)
            {
                if (Str[i].ToString() == ".")
                {
                    flag = true; break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == false)
            {
                Lbl_Results.Text = Lbl_Results.Text + ".";
            }  
        }

        private void Btn_Plus_And_Substraction_Click(object sender, EventArgs e)
        {

        }

   // Numbers Session : ====================================

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 1;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 2;  
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 3;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 4;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 5;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 6;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 7;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 8;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Lbl_Results.Text = Lbl_Results.Text + 9;
        }

   // Operations Session : ====================================

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            num = float.Parse(Lbl_Results.Text);
            Lbl_Results.Text = string.Empty;
            //Lbl_Results.Focus();  
            count = 2; 
        }

        private void Btn_Sub_Click(object sender, EventArgs e)
        {
            if (Lbl_Results.Text != "")
            {
                num = float.Parse(Lbl_Results.Text);
                //Lbl_Results.Clear();
                //Lbl_Results.Focus();
                count = 1;
            }  
        }

        private void Btn_Mult_Click(object sender, EventArgs e)
        {
            num = float.Parse(Lbl_Results.Text);
            //Lbl_Results.Clear();
            //Lbl_Results.Focus();
            count = 3;
        }

        private void Btn_Div_Click(object sender, EventArgs e)
        {
            num = float.Parse(Lbl_Results.Text);
            //Lbl_Results.Clear();
            //Lbl_Results.Focus();
            count = 4;
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            Calc(count);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (Lbl_Results.Text.Length != 0)
            Lbl_Results.Text = Lbl_Results.Text.Remove(Lbl_Results.Text.Length - 1);
        }

        private void Btn_Per_Click(object sender, EventArgs e)
        {

        }



    // functions : ====================================

        public void Calc(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(Lbl_Results.Text);
                    Lbl_Results.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(Lbl_Results.Text);
                    Lbl_Results.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(Lbl_Results.Text);
                    Lbl_Results.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(Lbl_Results.Text);
                    Lbl_Results.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        } 
    }
}
