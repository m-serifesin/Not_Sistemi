﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_sınav_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ort;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            proje = Convert.ToInt32(textBox5.Text);

            ort = ( (s1 *0.3 ) + (s2 * 0.5) + (proje * 0.2) ) / 3 ;
            

            listBox1.Items.Add(ad + " " + soyad + " " + "Ortalama: " + ort);
        }
    }
}
