using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHS_Toolbox.Forms
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (Generator.GetHistory() != null)
            {
                lbHistory.DataSource = Generator.GetHistory();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Generator.ClearHistory();
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lbHistory.SelectedItem != null && lbHistory.SelectedIndex < Generator.GetHistory().Count)
            {
                Clipboard.SetText(lbHistory.SelectedItem.ToString());
                btnCopy.Text = "Copied!";
            }
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCopy.Text = "Copy";
        }
    }
}
