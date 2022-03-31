using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        int[] sayilar = { 66, 90, 100, 55,852,986 };
           
        private void button1_Click(object sender, EventArgs e)
        {

            Array.Sort(sayilar);
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayilar);
            listBox1.Items.Clear();
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           label4.Text=sayilar.Max().ToString();
           label5.Text=sayilar.Min().ToString();
           listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = sayilar.Sum().ToString();
        }

   

           
        }
    }