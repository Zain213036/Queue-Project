using Guna.UI.WinForms;
using System;
using System.Collections;
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

    public partial class Form2 : Form
    {
        CashierClass obj = new CashierClass();
        public Form2()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Timer1_Tick);
            timer.Start();
        }
        lblDateTime.Text = DateTime.Now.ToString();
        private void displayCashierQueue(IEnumerable list)
        {
            listView1.Items.Clear();
            foreach (object obj in list)
            {
                listView1.Items.Add(obj.ToString());
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Refreshbtn.PerformClick();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            CashierClass.cashierQueue.Dequeue();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            displayCashierQueue(CashierClass.cashierQueue);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            listView1.View = View.Details; // Set the view to show details (columns)
            listView1.Columns.Add("Ticket Number", 100);

            // Example ticket numbers (you should fetch your actual data from listView1)
            List<string> ticketNumbers = new List<string>();
            foreach (ListViewItem item in listView1.Items)
            {
                ticketNumbers.Add(item.SubItems[0].Text); // Assuming the ticket number is in the first subitem
            }

            e.Graphics.DrawString("BANKING TICKET SYSTEM", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.DarkRed, new Point(230));

            // Display ticket numbers
            int yPos = 70;
            foreach (string ticketNumber in ticketNumbers)
            {
                e.Graphics.DrawString("Ticket Number: " + ticketNumber, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, yPos));
                yPos += 30; // Adjust vertical position for the next ticket number
            }
        }


        int flag = 0;
        private int i;

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = 1;
        }
    }
}
