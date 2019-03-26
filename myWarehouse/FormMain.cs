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
        private myWarehouse.data.dataSqlite m_myData;
        public FormMain()
        {
            InitializeComponent();
            m_myData = new myWarehouse.data.dataSqlite();
            m_myData.createTable();
            m_myData.initTable();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            m_myData.insertCount(textBox1.Text, textBox2.Text);
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
