using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_form
{
     internal class testbutton : Button
    { 
        Form1 _form1;
        public testbutton(Form1 form, string str, int x, int y, int width, int height)
        {
            _form1 = form;

            Click += OnClick;

            Text = str;

            Location = new Point(x, y);

            Size = new Size(width, height); 
        }

        public void OnClick(object sender, EventArgs s)
        {

            string t = _form1.ButtonLabelReplacement(Text);

            Text = t;
           // MessageBox.Show(Text);
        }
    }
}
