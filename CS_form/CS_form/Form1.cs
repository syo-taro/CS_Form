using System;
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
        TestLabel _testLabel;

        TestTextBox _textBox;
        public Form1()
        {
            InitializeComponent();

            string[] strs =
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ピンク",
                "むらさき",
                "きみどり"
            };


            for (int i = 0; i < 10; i++)
            {



                testbutton testButton = new testbutton(this,strs[i], (i % 5) * 100, (i / 5) * 100, 100, 100);

                Controls.Add(testButton);
            }
            TestLabel testLabel = new TestLabel("らべるです。", 10, 250, 500,100);
            Controls.Add((testLabel));

            _textBox = new TestTextBox(
             "てきすとぼっくすです", 10, 300, 500, 100);

            Controls.Add(_textBox);

        }
        private void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate  (str);
        }
        public string ButtonLabelReplacement(string str)
        {
            string s = _textBox.TextReplacement(str);

            return s;
        }

    }
}
