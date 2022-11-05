using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_OX
{
    public partial class Form2 : Form
    {
        public bool isXPlaying = true;
        public int[,] game = new int[3, 3];
        public Form2(string xPlayerName, string oxPlayerName)
        {
            InitializeComponent();
            this.lblXPlayerName.Text = xPlayerName; 
            this.lblOXPlayerName.Text = oxPlayerName;

            ////this.btnGame00.Click += ButtonClick;
            ////this.btnGame01.Click += ButtonClick;
            ////this.btnGame02.Click += ButtonClick;
            ////this.btnGame10.Click += ButtonClick;
            ////this.btnGame11.Click += ButtonClick;
            ////this.btnGame12.Click += ButtonClick;
            ////this.btnGame20.Click += ButtonClick;
            ////this.btnGame21.Click += ButtonClick;
            ////this.btnGame22.Click += ButtonClick;
            ///

            foreach(ColumnStyle column in tblMainLayout.ColumnStyles)
            {
                column.SizeType = SizeType.Percent;
                column.Width = 33.3f;
                //column.Width = (100 / tblMainLayout.ColumnStyles.Count);
            }

            foreach(RowStyle row in tblMainLayout.RowStyles)
            {
                row.SizeType = SizeType.Percent;
                row.Height = 20;

            }

            
            foreach(Control c in this.tblMainLayout.Controls)
            {   
                // c - Control
                if(c is Button)
                {   
                    // if(c is Button && c.Name.StartsWith("btnGame")
                    // moze i konverzija u dugme
                    c.Click += ButtonClick;
                }
            } 
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] parts = btn.Tag.ToString().Split(',');
            int iPos = Convert.ToInt32(parts[0]);
            int jPos = Convert.ToInt32(parts[1]);
            
            if (this.isXPlaying)
            {
                btn.Text = "X";
                this.game[iPos, jPos] = 1; // X
            }
            else
            {
                btn.Text = "O";
                this.game[iPos, jPos] = -1; // O
                
            }
            
            this.isXPlaying = !this.isXPlaying; // alternacija true/false
            btn.Enabled = false; // gasi dugme
            // Time osiguravamo da se na to dugme moze kliknuti samo jednom
            CheckGame();

        }

        private void CheckGame()
        {
            int x = 0, o = 0;
            // po vrstama

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(this.game[i, j] == 1) x++;
                    if(this.game[i, j] == -1) o++;
                }

                if (x == 3)
                {
                    MessageBox.Show("X je pobjednik");
                    return;
                }
                else if (o == 3)
                {
                    MessageBox.Show("O je pobjednik");
                    return;
                }
                else
                {
                    x = 0;
                    o = 0;
                }
            }

            // po kolonama

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (this.game[j, i] == 1) x++;
                    if (this.game[j, i] == -1) o++;
                }

                if (x == 3)
                {
                    MessageBox.Show("X je pobjednik");
                    return;
                }
                else if (o == 3)
                {
                    MessageBox.Show("O je pobjednik");
                    return;
                }
                else
                {
                    x = 0;
                    o = 0;
                }
            }

            // po glavnoj dijagonali
            for (int i = 0; i < 3; i++)
            {
                if (this.game[i, i] == 1) x++;
                if (this.game[i, i] == -1) o++;
            }

            if (x == 3)
            {
                MessageBox.Show("X je pobjednik");
                return;
            }
            else if (o == 3)
            {
                MessageBox.Show("O je pobjednik");
                return;
            }
            else
            {
                x = 0;
                o = 0;
            }



            // po sporednoj dijagonali
            for (int i = 0; i < 3; i++)
            {
                if (this.game[i, 3 - i - 1] == 1) x++;
                if (this.game[i, 3 - i - 1] == -1) o++;
            }

            if (x == 3)
            {
                MessageBox.Show("X je pobjednik");
                return;
            }
            else if (o == 3)
            {
                MessageBox.Show("O je pobjednik");
                return;
            }
            else
            {
                x = 0;
                o = 0;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGame02_Click(object sender, EventArgs e)
        {

        }
    }
}
