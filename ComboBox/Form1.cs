﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox1.Text = "Odabrana stavka: " + comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Odaberite stavku iz ComboBox-a.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Odabrana stavka: " + comboBox1.SelectedItem.ToString();
        }
    }
}
