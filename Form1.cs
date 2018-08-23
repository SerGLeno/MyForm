using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(tb1.Text)+Convert.ToInt32(tb2.Text);
            MessageBox.Show("Сумма этих чисел "+Convert.ToString(a1), "Сумма чисел");
            tb1.Focus();
        }
    }
}
