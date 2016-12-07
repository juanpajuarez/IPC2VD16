using System;
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
        public static int contador;
        public static int contadorv;
        public static string palabrass;
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
        public static string palabramayor(string palabra1, string palabra2)
        {
            if (palabra1.Length>palabra2.Length)
            {
                resultado = "La palabra mas larga es: \""+palabra1+"\". Tiene"+palabra1.Length+" caracteres";
            }
            else if (palabra2.Length > palabra1.Length)
            {
                resultado = "La palabra mas larga es: \"" + palabra2 + "\". Tiene " + palabra2.Length + " caracteres";
            }
            else if (palabra1.Length==palabra2.Length)
            {
                resultado = "Las dos palabras tienen "+palabra1.Length+" caracteres.";
            }
            
            return resultado;
        }
        public static string mayusculas(string palabra1, string palabra2)
        {
            foreach (char letra in palabra1)
            {
                if (char.IsUpper(letra))
                {
                    contador++;
                }
            }
            foreach (char letra in palabra2)
            {
                if (char.IsUpper(letra))
                {
                    contador++;
                }
            }
            resultado = "Las palabras tienen un total de "+contador.ToString()+" palabras en mayuscula.";
            return resultado;
        }
        public static string vocales(string palabra1, string palabra2)
        {
            palabrass = palabra1 + palabra2;
            foreach (char letra in palabrass)
            {
                if (letra.Equals('a')|| letra.Equals('e') || letra.Equals('i') || letra.Equals('o') || letra.Equals('u'))
                {
                    contadorv++;
                }
            }
            resultado="Las palabras tienen un total de " + contadorv.ToString() + " vocales.";
            return resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            palabramayor(richTextBox2.Text, richTextBox1.Text);
            richTextBox3.Text = resultado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mayusculas(richTextBox2.Text, richTextBox1.Text);
            richTextBox3.Text = resultado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vocales(richTextBox2.Text, richTextBox1.Text);
            richTextBox3.Text = resultado;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
        }
    }
    

}

