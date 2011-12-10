using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] lottery_numbers;
            lottery_numbers = new int[49];

            for (int i = 0; i != (lottery_numbers.Length); i++)
            {
                lottery_numbers[i] = i + 1;
                listBox1.Items.Add(lottery_numbers[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int aNumber = int.Parse(textBox1.Text);

            int[] arraySize;
            arraySize = new int[aNumber];

            for (int i = 0; i != (arraySize.Length); i++)
            {
                arraySize[i] = i + 1;

                listBox1.Items.Add(arraySize[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] aryTimes;
            aryTimes = new int[11];

            int times = int.Parse(textBox1.Text);

            for (int i = 1; i != (aryTimes.Length); i++)
            {
                aryTimes[i] = i * times;
                listBox1.Items.Add(times + " times " + i + " = " + aryTimes[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int arrayRows = 5;
            int arrayCols = 3;

            int[,] arrayTimes;
            arrayTimes = new int[arrayRows, arrayCols];

            int mult = 0;

            for (int i = 0; i != arrayRows; i++)
            {
                mult = mult + 10;

                for (int j = 0; j != arrayCols; j++)
                {
                    arrayTimes[i, j] = mult;
                    mult = mult * 10;
                }

                mult = mult / 1000;
            }

            for (int i = 0; i != arrayRows; i++)
            {
                for (int j = 0; j != arrayCols; j++)
                {
                    listBox1.Items.Add("arrayPos = " + i + "," + j + " val = " + arrayTimes[i, j]);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] arrayStrings;
            arrayStrings = new string[5];

            arrayStrings[0] = "This";
            arrayStrings[1] = "is";
            arrayStrings[2] = "a";
            arrayStrings[3] = "string";
            arrayStrings[4] = "array";

            foreach (string arrayElement in arrayStrings)
            {
                listBox1.Items.Add(arrayElement);
            }
        }
    }
}
