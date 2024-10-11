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

            list.title = textTitle.Text;
            list.value= Convert.ToDecimal(textPrice.Text);
            list.description = richText.Text;

            Form1.trans.Add(list);
            this.Close();

        }


    }
}
