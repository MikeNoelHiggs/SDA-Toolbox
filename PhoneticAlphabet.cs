using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHS_Toolbox
{
    public partial class PhoneticAlphabet : Form
    {
        public PhoneticAlphabet()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtPhoneticWord.Text = Generator.PhoneticAlphabet((Button)sender);
        }

    }
}
