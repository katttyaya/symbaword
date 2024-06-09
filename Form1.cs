using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fon.BackColor = Color.Transparent;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 0)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 1150)
                player.Left += speed;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.W)
                player.Width = speed;
        }
    }
}
