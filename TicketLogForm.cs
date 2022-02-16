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


    public partial class TicketLogForm : Form
    {
        private static readonly IntPtr HWDND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")] [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        public MainForm ActiveMainForm;

        public TicketLogForm(MainForm mf)
        {
            InitializeComponent();
            ActiveMainForm = mf;
        }



        private void TicketLogForm_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWDND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            PopulateList();
        }

        private void TicketLogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActiveMainForm.CloseOpenLog();
        }

        public void PopulateList()
        {
            List<ListViewItem> lvil = TicketLog.PopulateListViewItemList();

            foreach (ListViewItem lvi in lvil)
            {
                lvTicketLog.Items.Add(lvi);
            }
        }

        public void Add(ListViewItem lvi)
        {
            lvTicketLog.Items.Add(lvi);
        }

        private void BtnAddTicket_Click(object sender, EventArgs e)
        {
            AddTicketForm addForm = new(this);
            addForm.Show();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= lvTicketLog.Items.Count; i++)
            {
                lvTicketLog.Items.RemoveAt(0);
            }

            TicketLog.TicketList.Clear();
        }


    }
}
