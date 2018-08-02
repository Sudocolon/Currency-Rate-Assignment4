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
        public CurrencyRateView()
        {
            Timer timer = new Timer
            {
                //Interval is in miliseconds
                Interval = CurrencyRateController.UpdateRate * 1000
            };
            timer.Tick += new EventHandler(Tick);
            timer.Enabled = true;
            InitializeComponent();
        }
        private void Tick(object Sender, EventArgs e)
        {
            CurrencyRateController.Tick();
        }

        private void CurrencyRateView_Load(object sender, EventArgs e)
        {

        }
    }
}
