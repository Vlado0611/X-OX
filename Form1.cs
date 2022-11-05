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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnStart.Click += ButtonClick;
            //this.btnStart.Click += ButtonClick2;

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Text);
            //MessageBox.Show("Button1");
            //throw new NotImplementedException();
            if(string.IsNullOrEmpty(this.txtXPlayer.Text) ||
                string.IsNullOrEmpty(this.txtOPlayer.Text))
            {
                MessageBox.Show("Molimo unesite sve podatke!");
                return;
            }

            Form2 frmGame = new Form2(this.txtXPlayer.Text,this.txtOPlayer.Text);
            // Ne dozvoljavamo minimize i maximize, i ne dozvoljavamo resize forme      
            /*frmGame.MaximizeBox = false;
            frmGame.MinimizeBox = false;
            frmGame.FormBorderStyle = FormBorderStyle.FixedDialog;*/
            frmGame.Show(); // ShowDialog ako zelimo da prozor ne mozemo da zamijenimo sa drugim
            
        }

        private void ButtonClick2(object sender, EventArgs e)
        {
            MessageBox.Show("Button2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }*/




    }
}
