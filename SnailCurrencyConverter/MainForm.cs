using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace SnailCurrencyConverter
{
    public partial class MainForm : Form
    {
        private Dictionary<string, float> currencyData = new Dictionary<string, float>();
        public MainForm()
        {
            InitializeComponent();
            this.UpdateECBData();
            this.UpdateSelectionCBs();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Source Currency";
            dataGridView1.Columns[1].Name = "Destination Currency";
            dataGridView1.Columns[2].Name = "Source Amount";
            dataGridView1.Columns[3].Name = "Destination Amount";
            dataGridView1.Columns[4].Name = "Time Stamp";
            dataGridView1.Refresh();
            this.resetCurrencyTbs();
        }

        private void UpdateECBData()
        {
            XmlDocument ecbData = new XmlDocument();
            ecbData.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            foreach (XmlNode data in ecbData.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                this.currencyData.Add(data.Attributes["currency"].Value.ToString(), float.Parse(data.Attributes["rate"].Value.ToString()));
            }
        }

        private void UpdateSelectionCBs()
        {
            var currencies = this.currencyData.Keys.ToArray();
            this.src_currencyCb.Items.AddRange(currencies);
            this.dest_currencyCb.Items.AddRange(currencies);
        }

        private void convert_bt_Click(object sender, EventArgs e)
        {
            string src_currency = this.src_currencyCb.Text;
            string dest_currency = this.dest_currencyCb.Text;
            if (!currencyData.ContainsKey(src_currency))
            {
                MessageBox.Show("Source currency is not correct! Please choose from the available list!");
            }
            if (!currencyData.ContainsKey(dest_currency))
            {
                MessageBox.Show("Destination currency is not correct! Please choose from the available list!");
            }
            if (currencyData.ContainsKey(src_currency) && currencyData.ContainsKey(dest_currency))
            {
                float src_amount = float.Parse(this.src_amountTb.Text);
                float src_rate_euro = currencyData[src_currency];
                float dest_rate_euro = currencyData[dest_currency];
                float dest_amount = src_amount * (dest_rate_euro / src_rate_euro);
                this.dest_amountTb.Text = dest_amount.ToString();
                string time_stamp = DateTime.Now.ToString("HH:mm:ss");
                string[] row = new string[] { src_currency, dest_currency, src_amount.ToString(), dest_amount.ToString(), time_stamp };
                dataGridView1.Rows.Add(row);
                dataGridView1.Refresh();
            }
        }

        private void resetCurrencyTbs()
        {
            this.src_amountTb.Text = "0";
            this.dest_amountTb.Text = "0";
        }

        private void src_amountTb_Enter(object sender, EventArgs e)
        {
            this.src_amountTb.Text = "";
        }

        private void dest_amountTb_Enter(object sender, EventArgs e)
        {
            this.dest_amountTb.Text = "";
        }

        private void src_amountTb_Leave(object sender, EventArgs e)
        {
            if (this.src_amountTb.Text == "")
            {
                this.src_amountTb.Text = "0";
            }
        }

        private void dest_amountTb_Leave(object sender, EventArgs e)
        {
            if (this.dest_amountTb.Text == "")
            {
                this.dest_amountTb.Text = "0";
            }
        }
    }
}
