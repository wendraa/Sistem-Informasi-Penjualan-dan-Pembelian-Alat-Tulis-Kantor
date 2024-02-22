using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Progress.Increment(8);
            if (Progress.Value >= Progress.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Beranda beranda = new Beranda();
                beranda.Show();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
