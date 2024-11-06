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
        public testbutton(Form1 form, int id, int x, int y, int width, int height)
        {
            _form1 = form;

            Click += OnClick;

            Text = id.ToString();

            Location = new Point(x, y);

            Size = new Size(width, height); 
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }
    }
}
