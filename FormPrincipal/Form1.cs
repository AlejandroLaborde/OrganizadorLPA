using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class Form1 : Form
    {
        private float totalPesos1 = 23456;
        private float totalDolares1 = 88992;

        public Form1()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            this.totalPesos.Text = "$ "+ this.totalPesos1.ToString();
            this.totalDolares.Text = "u$d " + this.totalDolares1.ToString();


        }
    }
}
