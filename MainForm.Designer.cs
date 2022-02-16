namespace NHS_Toolbox
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtGenerator = new System.Windows.Forms.TextBox();
            this.lblGenerator = new System.Windows.Forms.Label();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnNHS = new System.Windows.Forms.Button();
            this.btnTempPin = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnInc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGenerator
            // 
            this.txtGenerator.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenerator.Location = new System.Drawing.Point(94, 11);
            this.txtGenerator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenerator.Name = "txtGenerator";
            this.txtGenerator.ReadOnly = true;
            this.txtGenerator.Size = new System.Drawing.Size(79, 25);
            this.txtGenerator.TabIndex = 0;
            // 
            // lblGenerator
            // 
            this.lblGenerator.AutoSize = true;
            this.lblGenerator.Location = new System.Drawing.Point(12, 13);
            this.lblGenerator.Name = "lblGenerator";
            this.lblGenerator.Size = new System.Drawing.Size(78, 20);
            this.lblGenerator.TabIndex = 1;
            this.lblGenerator.Text = "Generator:";
            // 
            // btnAD
            // 
            this.btnAD.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAD.Location = new System.Drawing.Point(15, 45);
            this.btnAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(158, 32);
            this.btnAD.TabIndex = 2;
            this.btnAD.Text = "Generate AD Password";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.Location = new System.Drawing.Point(179, 11);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 25);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnNHS
            // 
            this.btnNHS.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNHS.Location = new System.Drawing.Point(179, 45);
            this.btnNHS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNHS.Name = "btnNHS";
            this.btnNHS.Size = new System.Drawing.Size(134, 32);
            this.btnNHS.TabIndex = 4;
            this.btnNHS.Text = "Generate NHS.Net Password";
            this.btnNHS.UseVisualStyleBackColor = true;
            this.btnNHS.Click += new System.EventHandler(this.btnNHS_Click);
            // 
            // btnTempPin
            // 
            this.btnTempPin.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTempPin.Location = new System.Drawing.Point(15, 84);
            this.btnTempPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTempPin.Name = "btnTempPin";
            this.btnTempPin.Size = new System.Drawing.Size(158, 32);
            this.btnTempPin.TabIndex = 5;
            this.btnTempPin.Text = "Generate Temporary Pin";
            this.btnTempPin.UseVisualStyleBackColor = true;
            this.btnTempPin.Click += new System.EventHandler(this.btnTempPin_Click);
            // 
            // btnPA
            // 
            this.btnPA.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPA.Location = new System.Drawing.Point(179, 123);
            this.btnPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(134, 32);
            this.btnPA.TabIndex = 6;
            this.btnPA.Text = "Phonetic Alphabet";
            this.btnPA.UseVisualStyleBackColor = true;
            this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(328, 48);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(93, 27);
            this.txtCounter.TabIndex = 9;
            this.txtCounter.Text = "0";
            this.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(327, 19);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(93, 20);
            this.lblCounter.TabIndex = 10;
            this.lblCounter.Text = "Call Counter:";
            // 
            // btnInc
            // 
            this.btnInc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInc.Location = new System.Drawing.Point(381, 84);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(40, 32);
            this.btnInc.TabIndex = 11;
            this.btnInc.Text = "+";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDec.Location = new System.Drawing.Point(327, 84);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(40, 32);
            this.btnDec.TabIndex = 12;
            this.btnDec.Text = "−";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.Location = new System.Drawing.Point(179, 84);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(134, 32);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLog.Location = new System.Drawing.Point(16, 123);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(157, 32);
            this.btnLog.TabIndex = 14;
            this.btnLog.Text = "Ticket Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(327, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 163);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnInc);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.btnTempPin);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.btnPA);
            this.Controls.Add(this.btnNHS);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblGenerator);
            this.Controls.Add(this.txtGenerator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 210);
            this.MinimumSize = new System.Drawing.Size(450, 210);
            this.Name = "MainForm";
            this.Text = "SDA Toolbox";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGenerator;
        private Label lblGenerator;
        private Button btnAD;
        private Button btnCopy;
        private Button btnNHS;
        private Button btnTempPin;
        private Button btnPA;
        private TextBox txtCounter;
        private Label lblCounter;
        private Button btnInc;
        private Button btnDec;
        private Button btnHistory;
        private Button btnLog;
        private Button btnReset;
    }
}