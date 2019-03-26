using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myWarehouse
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            myWarehouse.data.dataSqlite myData = new myWarehouse.data.dataSqlite();
            myData.createTable();
            myData.initTable();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
