﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_form
{
    public partial class Form1 : Form
    {
        TestLabel _TestLabel;
        public Form1()
        {
            InitializeComponent();


            for (int i = 0; i < 10; i++)
            {



                testbutton testButton = new testbutton(this,i, (i % 5) * 100, (i / 5) * 100, 100, 100);

                Controls.Add(testButton);
            }
            TestLabel testLabel = new TestLabel("らべるです。", 10, 300, 100, 500);
            Controls.Add((testLabel));
            
        }
        private void LabelTextUpdate(string str)
        {
            _TestLabel.TextUpdate  (str);
        }

    }
}
