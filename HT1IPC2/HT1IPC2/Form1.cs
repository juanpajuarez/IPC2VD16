﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1IPC2
{
    public partial class Form1 : Form
    {
        public static string resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juntarpalabras(richTextBox2.Text,richTextBox1.Text);
            richTextBox3.Text = resultado;
        }
        public static string juntarpalabras(string palabra1, string palabra2)
        {
            resultado = palabra1 + palabra2;
            return resultado;
        }

    }
    

}
