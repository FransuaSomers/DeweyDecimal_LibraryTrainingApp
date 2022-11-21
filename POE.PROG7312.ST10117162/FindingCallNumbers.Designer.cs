
namespace POE.PROG7312_ST10117162
{
    partial class FindingCallNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingCallNumbers));
            this.answerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.correct20PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incorrect5PointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.firstLevelList = new System.Windows.Forms.ListBox();
            this.secondLevelList = new System.Windows.Forms.ListBox();
            this.thirdLevelList = new System.Windows.Forms.ListBox();
            this.btnNextFirst = new System.Windows.Forms.Button();
            this.btnNextSecond = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.answerLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(208, 129);
            this.answerLabel.MaximumSize = new System.Drawing.Size(250, 250);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.answerLabel.Size = new System.Drawing.Size(212, 76);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "This is dummy text used to fill  space";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SpringGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.coinsBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.goBackToolStripMenuItem.Text = "Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // coinsBar
            // 
            this.coinsBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.coinsBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.correct20PointsToolStripMenuItem,
            this.incorrect5PointsToolStripMenuItem});
            this.coinsBar.Name = "coinsBar";
            this.coinsBar.Size = new System.Drawing.Size(91, 24);
            this.coinsBar.Text = "Coins: 699";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 24);
            this.toolStripMenuItem1.Text = "Correct 1st/2nd: +5 coins";
            // 
            // correct20PointsToolStripMenuItem
            // 
            this.correct20PointsToolStripMenuItem.Enabled = false;
            this.correct20PointsToolStripMenuItem.Name = "correct20PointsToolStripMenuItem";
            this.correct20PointsToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.correct20PointsToolStripMenuItem.Text = "Correct 3rd: +10 coins";
            // 
            // incorrect5PointsToolStripMenuItem
            // 
            this.incorrect5PointsToolStripMenuItem.Enabled = false;
            this.incorrect5PointsToolStripMenuItem.Name = "incorrect5PointsToolStripMenuItem";
            this.incorrect5PointsToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.incorrect5PointsToolStripMenuItem.Text = "Incorrect: -5 coins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(268, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Goal is:";
            // 
            // firstLevelList
            // 
            this.firstLevelList.Font = new System.Drawing.Font("Impact", 12F);
            this.firstLevelList.FormattingEnabled = true;
            this.firstLevelList.ItemHeight = 20;
            this.firstLevelList.Items.AddRange(new object[] {
            "First Level List:"});
            this.firstLevelList.Location = new System.Drawing.Point(105, 288);
            this.firstLevelList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstLevelList.Name = "firstLevelList";
            this.firstLevelList.Size = new System.Drawing.Size(390, 84);
            this.firstLevelList.TabIndex = 5;
            // 
            // secondLevelList
            // 
            this.secondLevelList.BackColor = System.Drawing.SystemColors.Control;
            this.secondLevelList.Font = new System.Drawing.Font("Impact", 12F);
            this.secondLevelList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.secondLevelList.FormattingEnabled = true;
            this.secondLevelList.ItemHeight = 20;
            this.secondLevelList.Items.AddRange(new object[] {
            "Second Level List:"});
            this.secondLevelList.Location = new System.Drawing.Point(105, 383);
            this.secondLevelList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondLevelList.Name = "secondLevelList";
            this.secondLevelList.Size = new System.Drawing.Size(390, 84);
            this.secondLevelList.TabIndex = 6;
            this.secondLevelList.Visible = false;
            // 
            // thirdLevelList
            // 
            this.thirdLevelList.BackColor = System.Drawing.SystemColors.Control;
            this.thirdLevelList.Font = new System.Drawing.Font("Impact", 12F);
            this.thirdLevelList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thirdLevelList.FormattingEnabled = true;
            this.thirdLevelList.ItemHeight = 20;
            this.thirdLevelList.Items.AddRange(new object[] {
            "Third Level List:"});
            this.thirdLevelList.Location = new System.Drawing.Point(243, 478);
            this.thirdLevelList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdLevelList.Name = "thirdLevelList";
            this.thirdLevelList.Size = new System.Drawing.Size(115, 84);
            this.thirdLevelList.TabIndex = 7;
            this.thirdLevelList.Visible = false;
            // 
            // btnNextFirst
            // 
            this.btnNextFirst.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNextFirst.FlatAppearance.BorderSize = 2;
            this.btnNextFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFirst.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFirst.Location = new System.Drawing.Point(511, 313);
            this.btnNextFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextFirst.Name = "btnNextFirst";
            this.btnNextFirst.Size = new System.Drawing.Size(90, 35);
            this.btnNextFirst.TabIndex = 8;
            this.btnNextFirst.Text = "Next";
            this.btnNextFirst.UseVisualStyleBackColor = false;
            this.btnNextFirst.Click += new System.EventHandler(this.btnNextFirst_Click);
            // 
            // btnNextSecond
            // 
            this.btnNextSecond.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNextSecond.FlatAppearance.BorderSize = 2;
            this.btnNextSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextSecond.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSecond.Location = new System.Drawing.Point(511, 408);
            this.btnNextSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextSecond.Name = "btnNextSecond";
            this.btnNextSecond.Size = new System.Drawing.Size(90, 35);
            this.btnNextSecond.TabIndex = 9;
            this.btnNextSecond.Text = "Next";
            this.btnNextSecond.UseVisualStyleBackColor = false;
            this.btnNextSecond.Visible = false;
            this.btnNextSecond.Click += new System.EventHandler(this.btnNextSecond_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(511, 503);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 35);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(1, 37);
            this.label2.MaximumSize = new System.Drawing.Size(10000, 10001);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select the answer you think will get you to your goal, and then click Next";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 10F);
            this.label3.Location = new System.Drawing.Point(49, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(600, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "5 coins are awarded for a correct answer and 10 coins are awarded for a correct s" +
    "et of answers.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14F);
            this.label4.Location = new System.Drawing.Point(281, 253);
            this.label4.MaximumSize = new System.Drawing.Size(500, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Good luck!";
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(664, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNextSecond);
            this.Controls.Add(this.btnNextFirst);
            this.Controls.Add(this.thirdLevelList);
            this.Controls.Add(this.secondLevelList);
            this.Controls.Add(this.firstLevelList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.answerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.Name = "FindingCallNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian Training - Find Call Numbers";
            this.Load += new System.EventHandler(this.FindingCallNumbers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsBar;
        private System.Windows.Forms.ToolStripMenuItem correct20PointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incorrect5PointsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox firstLevelList;
        private System.Windows.Forms.ListBox secondLevelList;
        private System.Windows.Forms.ListBox thirdLevelList;
        private System.Windows.Forms.Button btnNextFirst;
        private System.Windows.Forms.Button btnNextSecond;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}