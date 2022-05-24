using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        CheckBox chkBox = new CheckBox();
        public Form1()
        {
            InitializeComponent();
            chkBox.Visible = true;
            chkBox.Location = new System.Drawing.Point(10, 25);
            this.Controls.Add(chkBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            chkBox.Visible = false;
        }
    }
}
