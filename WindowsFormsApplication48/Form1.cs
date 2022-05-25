using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.White;

            pictureBox1.Image = Properties.Resources.manzara_06_;
            pictureBox2.Image = Properties.Resources.manzara_01_;
            pictureBox3.Image = Properties.Resources.manzara_02_;
            pictureBox4.Image = Properties.Resources.manzara_05_;
            pictureBox5.Image = Properties.Resources.manzara_03_;
            pictureBox6.Image = Properties.Resources.manzara_08_;
            pictureBox7.Image = Properties.Resources.manzara_04_;
            pictureBox8.Image = Properties.Resources.manzara_07_;
            pictureBox9.Image = Properties.Resources.manzara_00_;



           



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.BackColor==Color.White)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.manzara_00_;
                pictureBox2.BackColor = Color.White;
            }
            if(pictureBox3.BackColor==Color.White)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.manzara_00_;
                pictureBox2.BackColor = Color.White;
            }
            if(pictureBox5.BackColor==Color.White)
            {
                pictureBox5.Image = pictureBox2.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.manzara_00_;
                pictureBox2.BackColor = Color.White;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox2.BackColor==Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources.manzara_00_;
                pictureBox1.BackColor = Color.White;
            }
            if(pictureBox4.BackColor==Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources.manzara_00_;
                pictureBox1.BackColor = Color.White;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(pictureBox2.BackColor==Color.White)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.manzara_00_;
                pictureBox3.BackColor = Color.White;
            }
            if(pictureBox6.BackColor==Color.White)
            {
                pictureBox6.Image = pictureBox3.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.manzara_00_;
                pictureBox3.BackColor = Color.White;
            }
        }
         
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(pictureBox1.BackColor==Color.White)
            {
                pictureBox1.Image = pictureBox4.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.manzara_00_;
                pictureBox4.BackColor = Color.White;
            }
            if(pictureBox5.BackColor==Color.White)
            {
                pictureBox5.Image = pictureBox4.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.manzara_00_;
                pictureBox4.BackColor = Color.White;
            }
            if(pictureBox7.BackColor==Color.White)
            {
                pictureBox7.Image = pictureBox4.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.manzara_00_;
                pictureBox4.BackColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(pictureBox2.BackColor==Color.White)
            {

                pictureBox2.Image = pictureBox5.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.manzara_00_;
                pictureBox5.BackColor = Color.White;
            }
            if(pictureBox4.BackColor==Color.White)
            {

                pictureBox4.Image = pictureBox5.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.manzara_00_;
                pictureBox5.BackColor = Color.White;
            }
            if(pictureBox6.BackColor==Color.White)
            {

                pictureBox6.Image = pictureBox5.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.manzara_00_;
                pictureBox5.BackColor = Color.White;
            }
            if(pictureBox8.BackColor==Color.White)
            {

                pictureBox8.Image = pictureBox5.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.manzara_00_;
                pictureBox5.BackColor = Color.White;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(pictureBox3.BackColor==Color.White)
            {

                pictureBox3.Image = pictureBox6.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.manzara_00_;
                pictureBox6.BackColor = Color.White;
            }
            if(pictureBox5.BackColor==Color.White)
            {

                pictureBox5.Image = pictureBox6.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.manzara_00_;
                pictureBox6.BackColor = Color.White;

            }
            if(pictureBox9.BackColor==Color.White)
            {

                pictureBox9.Image = pictureBox6.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.manzara_00_;
                pictureBox6.BackColor = Color.White;

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(pictureBox4.BackColor==Color.White)
            {

                pictureBox4.Image = pictureBox7.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.manzara_00_;
                pictureBox7.BackColor = Color.White;

            }
            if (pictureBox8.BackColor==Color.White)
            {

                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.manzara_00_;
                pictureBox7.BackColor = Color.White;

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(pictureBox5.BackColor==Color.White)
            {

                pictureBox5.Image = pictureBox8.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.manzara_00_;
                pictureBox8.BackColor = Color.White;

            }
            if (pictureBox7.BackColor==Color.White)
            {

                pictureBox7.Image = pictureBox8.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.manzara_00_;
                pictureBox8.BackColor = Color.White;

            }
            if (pictureBox9.BackColor==Color.White)
            {

                pictureBox9.Image = pictureBox8.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.manzara_00_;
                pictureBox8.BackColor = Color.White;

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if(pictureBox6.BackColor==Color.White)
            {
                pictureBox6.Image = pictureBox9.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.manzara_00_;
                pictureBox9.BackColor = Color.White;
            }
            if(pictureBox8.BackColor==Color.White)
            {
                pictureBox8.Image = pictureBox9.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.manzara_00_;
                pictureBox9.BackColor = Color.White;
            }
        }
    }
}
