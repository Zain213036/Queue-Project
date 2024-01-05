using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QM_Part_3_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int startpoint = 0;

        public static int Value { get; private set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Form3.Value = startpoint;
            if (Form3.Value == 60)
            {
                Form3.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
