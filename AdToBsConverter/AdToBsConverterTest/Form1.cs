using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdToBsConverter;

namespace AdToBsConverterTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdToBsConverte_Click(object sender, EventArgs e)
        {
            string date = dtpAd.Text;
            DateTime dateTime = Convert.ToDateTime(date);
            NepDate nepDate = NepDateConverter.EngToNep(dateTime);
            txtBS.Text = nepDate.ToLongDateString();
        }
    }
}
