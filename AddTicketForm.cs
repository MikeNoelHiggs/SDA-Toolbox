using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHS_Toolbox
{
    public partial class AddTicketForm : Form
    {
        private static readonly IntPtr HWDND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private readonly TicketLogForm TicketLogForm;
        


        public AddTicketForm(TicketLogForm ticketLogF)
        {
            InitializeComponent();
            TicketLogForm = ticketLogF;
        }

        private void AddTicketForm_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWDND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTicketID.Text != "" && txtUserName.Text != "")
            {
                TicketLog.TicketList.Add(new Ticket(txtUserName.Text.ToString(), txtTicketID.Text.ToString(), txtDescription.Text.ToString()));

                Ticket t = TicketLog.TicketList[TicketLog.TicketList.Count -1];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = t.UserName;
                lvi.SubItems.Add(t.TicketID);
                lvi.SubItems.Add(t.Description);
                TicketLogForm.Add(lvi);
                this.Close();
            }
            else
            {
                // Show Error Box.
                MessageBox.Show("Invalid Field", "Invalid Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
