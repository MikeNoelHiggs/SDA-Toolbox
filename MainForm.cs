using NHS_Toolbox.Forms;
using System.Runtime.InteropServices;

namespace NHS_Toolbox
{
    public partial class MainForm : Form
    {

        private static readonly IntPtr HWDND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")] [return: MarshalAs(UnmanagedType.Bool)] 
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        TicketLogForm openTicketLog;
        bool logOpen = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public void CloseOpenLog()
        {
            logOpen = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWDND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            txtGenerator.Text = Generator.GenerateADCode();
            btnCopy.Text = "Copy";
            this.Height = 140;

        }

        private void btnNHS_Click(object sender, EventArgs e)
        {
            txtGenerator.Text = Generator.GenerateNHSMailCode();
            btnCopy.Text = "Copy";
            this.Height = 140;
        }

        private void btnTempPin_Click(object sender, EventArgs e)
        {
            txtGenerator.Text = Generator.GenerateTemporaryPin();
            btnCopy.Text = "Copy";
            this.Height = 140;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtGenerator.Text != "")
            {
                Clipboard.SetText(txtGenerator.Text);
                Generator.AddHistory((txtGenerator.Text.ToString()));
                btnCopy.Text = "Copied!";
                this.Height = 195;
            }  
        }

        private void btnPA_Click(object sender, EventArgs e)
        {
            PhoneticAlphabet PAForm = new PhoneticAlphabet();
            PAForm.Show();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            Generator.IncCounter();
            txtCounter.Text = Generator.GetCounter().ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            Generator.DecCounter();
            txtCounter.Text = Generator.GetCounter().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Generator.ResetCounter();
            txtCounter.Text = Generator.GetCounter().ToString();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            
            if (!logOpen)
            {
                logOpen = true;
                openTicketLog = new TicketLogForm(this);
                openTicketLog.Show();
            }
            else
            {
                openTicketLog.WindowState = FormWindowState.Normal;
            }
        }


    }
}