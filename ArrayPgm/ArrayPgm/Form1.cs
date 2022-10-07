﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ArrayPgm
{
    public partial class Form1 : Form
    {
        public class Bottle
        {
            int[] height;
            int[] volume;



            public Bottle()
            {
                height = new int[] { 12, 13, 14, 15, 16 };
                volume = new int[] { 4, 8, 12, 16, 20 };
            }


            public void ShowLength()
            {
                for (int i = 0; i < height.Length - 1; i++)
                {
                    MessageBox.Show("Height of bottle : " + height[i]);
                }
            }
            public void ShowVolume()
            {
                for (int i = 0; i < volume.Length - 1; i++)
                {
                    MessageBox.Show("Volume of bottle : " + volume[i] + " litres");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Bottle Bb = new Bottle();
            Bb.ShowLength();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Bottle Bb = new Bottle();
            Bb.ShowVolume();
        }
    }
}
