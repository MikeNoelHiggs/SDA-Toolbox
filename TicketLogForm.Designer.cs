namespace NHS_Toolbox
{
    partial class TicketLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketLogForm));
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvTicketLog = new System.Windows.Forms.ListView();
            this.CustomerName = new System.Windows.Forms.ColumnHeader();
            this.TicketNo = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(107, 345);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(133, 30);
            this.btnAddTicket.TabIndex = 1;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.BtnAddTicket_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(246, 345);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Tickets";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lvTicketLog
            // 
            this.lvTicketLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerName,
            this.TicketNo,
            this.Description});
            this.lvTicketLog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvTicketLog.FullRowSelect = true;
            this.lvTicketLog.GridLines = true;
            this.lvTicketLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTicketLog.HideSelection = true;
            this.lvTicketLog.Location = new System.Drawing.Point(12, 12);
            this.lvTicketLog.Name = "lvTicketLog";
            this.lvTicketLog.Size = new System.Drawing.Size(458, 326);
            this.lvTicketLog.TabIndex = 3;
            this.lvTicketLog.UseCompatibleStateImageBehavior = false;
            this.lvTicketLog.View = System.Windows.Forms.View.Details;
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "User";
            this.CustomerName.Width = 130;
            // 
            // TicketNo
            // 
            this.TicketNo.Text = "Ticket No.";
            this.TicketNo.Width = 130;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 192;
            // 
            // TicketLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 384);
            this.Controls.Add(this.lvTicketLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 431);
            this.MinimumSize = new System.Drawing.Size(500, 431);
            this.Name = "TicketLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Log";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicketLogForm_FormClosed);
            this.Load += new System.EventHandler(this.TicketLogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddTicket;
        private Button btnClear;
        private ListView lvTicketLog;
        private ColumnHeader CustomerName;
        private ColumnHeader TicketNo;
        private ColumnHeader Description;
    }
}