using Assignment4.Classes;
using Assignment4.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class CurrencyRateView : Form
    {
        List<string> PairNames;
        public CurrencyRateView()
        {
            CurrencyRateController.Tick();
            PairNames = new List<string>(CurrencyRateController.CurrencyData.Keys);
            Timer timer = new Timer
            {
                //Interval is in miliseconds
                Interval = CurrencyRateController.UpdateRate * 1000
            };
            timer.Tick += new EventHandler(Tick);
            timer.Enabled = true;
            InitializeComponent();
            listBox1.DataSource = PairNames;
        }
        private void Tick(object Sender, EventArgs e)
        {
            CurrencyRateController.Tick();
            label1.Text = CompareTargetRate.PairWatching.Bid.ToString();
        }
        public static void TargetNotification()
        {
            MessageBox.Show("Reached Target");
            Application.Exit();
        }

        private void CurrencyRateView_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string targetName = listBox1.GetItemText(listBox1.SelectedItem);
            float targetValue = (float)Convert.ToDouble(textBox1.Text);
            CompareTargetRate.SetTarget(targetName, targetValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
