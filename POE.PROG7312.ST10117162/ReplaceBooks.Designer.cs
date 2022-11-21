namespace POE.PROG7312_ST10117162
{
    partial class ReplaceBooks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBooks));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsBar = new System.Windows.Forms.ToolStripMenuItem();
            this.correct20CoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incorrect5CoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upCallBtn = new System.Windows.Forms.Button();
            this.downCallBtn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.callNumBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SpringGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.coinsBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(423, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.goBackToolStripMenuItem.Text = "Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.GoBackToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // coinsBar
            // 
            this.coinsBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.coinsBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correct20CoinsToolStripMenuItem,
            this.incorrect5CoinsToolStripMenuItem});
            this.coinsBar.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsBar.Name = "coinsBar";
            this.coinsBar.Size = new System.Drawing.Size(86, 24);
            this.coinsBar.Text = "Coins: 699";
            // 
            // correct20CoinsToolStripMenuItem
            // 
            this.correct20CoinsToolStripMenuItem.Enabled = false;
            this.correct20CoinsToolStripMenuItem.Name = "correct20CoinsToolStripMenuItem";
            this.correct20CoinsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.correct20CoinsToolStripMenuItem.Text = "Correct: +20 coins";
            // 
            // incorrect5CoinsToolStripMenuItem
            // 
            this.incorrect5CoinsToolStripMenuItem.Enabled = false;
            this.incorrect5CoinsToolStripMenuItem.Name = "incorrect5CoinsToolStripMenuItem";
            this.incorrect5CoinsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.incorrect5CoinsToolStripMenuItem.Text = "Incorrect: -5 coins";
            // 
            // upCallBtn
            // 
            this.upCallBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.upCallBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.upCallBtn.FlatAppearance.BorderSize = 2;
            this.upCallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upCallBtn.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upCallBtn.ForeColor = System.Drawing.Color.Black;
            this.upCallBtn.Location = new System.Drawing.Point(21, 277);
            this.upCallBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.upCallBtn.Name = "upCallBtn";
            this.upCallBtn.Size = new System.Drawing.Size(80, 45);
            this.upCallBtn.TabIndex = 4;
            this.upCallBtn.Text = "Move Up";
            this.upCallBtn.UseVisualStyleBackColor = false;
            this.upCallBtn.Click += new System.EventHandler(this.UpCallBtn_Click);
            // 
            // downCallBtn
            // 
            this.downCallBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.downCallBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.downCallBtn.FlatAppearance.BorderSize = 2;
            this.downCallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downCallBtn.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downCallBtn.ForeColor = System.Drawing.Color.Black;
            this.downCallBtn.Location = new System.Drawing.Point(21, 328);
            this.downCallBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.downCallBtn.Name = "downCallBtn";
            this.downCallBtn.Size = new System.Drawing.Size(80, 43);
            this.downCallBtn.TabIndex = 5;
            this.downCallBtn.Text = "Move Down";
            this.downCallBtn.UseVisualStyleBackColor = false;
            this.downCallBtn.Click += new System.EventHandler(this.DownCallBtn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(125, 348);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(251, 44);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Check Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // callNumBox
            // 
            this.callNumBox.AllowDrop = true;
            this.callNumBox.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callNumBox.FormattingEnabled = true;
            this.callNumBox.IntegralHeight = false;
            this.callNumBox.ItemHeight = 23;
            this.callNumBox.Items.AddRange(new object[] {
            "Dewey Decimal Classification ",
            "system",
            "",
            "",
            "",
            "Place Holder text"});
            this.callNumBox.Location = new System.Drawing.Point(125, 93);
            this.callNumBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.callNumBox.Name = "callNumBox";
            this.callNumBox.Size = new System.Drawing.Size(250, 234);
            this.callNumBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort the call numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sort digit by digit, not as whole numbers";
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(423, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.downCallBtn);
            this.Controls.Add(this.upCallBtn);
            this.Controls.Add(this.callNumBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 599);
            this.MinimumSize = new System.Drawing.Size(439, 456);
            this.Name = "ReplaceBooks";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian Training - Replace Books";
            this.Load += new System.EventHandler(this.ReplaceBooks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsBar;
        private System.Windows.Forms.Button upCallBtn;
        private System.Windows.Forms.Button downCallBtn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListBox callNumBox;
        private System.Windows.Forms.ToolStripMenuItem correct20CoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incorrect5CoinsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}