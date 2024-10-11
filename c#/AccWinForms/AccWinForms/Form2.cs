using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction list = new Transaction();

            list.Title = textTitle.Text;
            list.Value = Convert.ToDecimal(textPrice.Text);
            list.Description = richText.Text;

            Form1.trans.Add(list);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
