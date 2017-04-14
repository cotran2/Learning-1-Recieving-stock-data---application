using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;

namespace StockRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getValue(string requestMethod, string symbol)
        {
            string prefixURL = "http://finance.yahoo.com/d/quotes.csv?s=";
            string urlParams = "&f=" + requestMethod;

            string urlAddress = prefixURL;
            urlAddress += symbol;
            urlAddress += urlParams;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string data = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (data != "N/A")
            {
                return data;
            }
            else
            {
                return "false";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(this.stockNameTextBox.Text);
            try
            {
                this.askTextBox.Text = this.getValue("a", this.stockNameTextBox.Text);
                this.bidTextBox.Text = this.getValue("b", this.stockNameTextBox.Text);
                this.button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Invalid Stock Name");
            }




            /*         List<string> symbols = new List<string> { "GOOG", "MSFT" };
                     string prefixURL = "http://finance.yahoo.com/d/quotes.csv?s=";
                     string urlParams = "&f=a";
                     for(int i = 0; i < symbols.Count; i++)
                     {

                         string urlAddress = prefixURL;
                         urlAddress += symbols[i];
                         urlAddress += urlParams;
                         HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                         HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                         string data = new StreamReader(response.GetResponseStream()).ReadToEnd();
                         StockDatabaseDataSet.StocksRow newStockRow;
                         newStockRow = stockDatabaseDataSet.Stocks.NewStocksRow();
                         newStockRow.StockName = symbols[i];
                         //MessageBox.Show(data);
                         //float Value;
                         try
                         {
                             newStockRow.Ask = float.Parse(data);
                         }
                         catch
                         {
                           //  MessageBox.Show("Failed");
                         }
                         //newStockRow.Ask = Int32.Parse(data);
                         this.stockDatabaseDataSet.Stocks.Rows.Add(newStockRow);
                         this.stocksTableAdapter.Update(this.stockDatabaseDataSet.Stocks);
                     }*/
        }
        private void stocksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stocksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stockDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDatabaseDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stockDatabaseDataSet.Stocks);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockDatabaseDataSet.StocksRow newStockRow;
            newStockRow = stockDatabaseDataSet.Stocks.NewStocksRow();
            newStockRow.StockName = this.stockNameTextBox.Text;
            newStockRow.Ask = float.Parse(this.getValue("a", this.stockNameTextBox.Text));
            newStockRow.Bid = float.Parse(this.getValue("b", this.stockNameTextBox.Text));
            this.stockDatabaseDataSet.Stocks.Rows.Add(newStockRow);
            this.stocksTableAdapter.Update(this.stockDatabaseDataSet.Stocks);
        }
    }
}
