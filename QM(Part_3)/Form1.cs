using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QM_Part_3_
{
    public partial class Form1 : Form
    {
        private CashierClass Cashier = new CashierClass();
        public Form1()
        {
            InitializeComponent();
            Cashier = new CashierClass();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string generatedNumber = Cashier.CashierGeneratedNumber("P - ");
            label2.Text = generatedNumber;
            CashierClass.getNumberInQueue = generatedNumber;
            CashierClass.cashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }
        // Display current date and time in the label
        lblDateTime.Text = DateTime.Now.ToString();

    }
}
