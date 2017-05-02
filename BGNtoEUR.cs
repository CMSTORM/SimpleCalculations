using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGNtoEUR_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN * 1.95583M;
            this.label3.Text = amountBGN + "BGN = " + amountEUR + "EUR";
        }

        private void NumericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
