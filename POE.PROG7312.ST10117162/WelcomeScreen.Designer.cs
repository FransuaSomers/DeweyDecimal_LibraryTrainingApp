namespace POE.PROG7312_ST10117162
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.btnReplaceBooks = new System.Windows.Forms.Button();
            this.btnIdentifyAreas = new System.Windows.Forms.Button();
            this.btnFindCallNums = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCoinCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplaceBooks
            // 
            this.btnReplaceBooks.BackColor = System.Drawing.Color.SpringGreen;
            this.btnReplaceBooks.FlatAppearance.BorderSize = 2;
            this.btnReplaceBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceBooks.Font = new System.Drawing.Font("Impact", 15F);
            this.btnReplaceBooks.ForeColor = System.Drawing.Color.Black;
            this.btnReplaceBooks.Location = new System.Drawing.Point(12, 198);
            this.btnReplaceBooks.Name = "btnReplaceBooks";
            this.btnReplaceBooks.Size = new System.Drawing.Size(156, 78);
            this.btnReplaceBooks.TabIndex = 0;
            this.btnReplaceBooks.Text = "Replacing Books";
            this.btnReplaceBooks.UseVisualStyleBackColor = false;
            this.btnReplaceBooks.Click += new System.EventHandler(this.btnReplaceBooks_Click);
            // 
            // btnIdentifyAreas
            // 
            this.btnIdentifyAreas.BackColor = System.Drawing.Color.SpringGreen;
            this.btnIdentifyAreas.FlatAppearance.BorderSize = 2;
            this.btnIdentifyAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentifyAreas.Font = new System.Drawing.Font("Impact", 15F);
            this.btnIdentifyAreas.ForeColor = System.Drawing.Color.Black;
            this.btnIdentifyAreas.Location = new System.Drawing.Point(254, 198);
            this.btnIdentifyAreas.Name = "btnIdentifyAreas";
            this.btnIdentifyAreas.Size = new System.Drawing.Size(156, 78);
            this.btnIdentifyAreas.TabIndex = 1;
            this.btnIdentifyAreas.Text = "Identifying Areas";
            this.btnIdentifyAreas.UseVisualStyleBackColor = false;
            this.btnIdentifyAreas.Click += new System.EventHandler(this.BtnIdentifyAreas_Click);
            // 
            // btnFindCallNums
            // 
            this.btnFindCallNums.BackColor = System.Drawing.Color.SpringGreen;
            this.btnFindCallNums.FlatAppearance.BorderSize = 2;
            this.btnFindCallNums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCallNums.Font = new System.Drawing.Font("Impact", 15F);
            this.btnFindCallNums.ForeColor = System.Drawing.Color.Black;
            this.btnFindCallNums.Location = new System.Drawing.Point(496, 198);
            this.btnFindCallNums.Name = "btnFindCallNums";
            this.btnFindCallNums.Size = new System.Drawing.Size(156, 78);
            this.btnFindCallNums.TabIndex = 2;
            this.btnFindCallNums.Text = "Finding Call Numbers";
            this.btnFindCallNums.UseVisualStyleBackColor = false;
            this.btnFindCallNums.Click += new System.EventHandler(this.btnFindCallNums_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(553, 82);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the Librarian training app!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Impact", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 109);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12);
            this.label2.Size = new System.Drawing.Size(322, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "What would you like to learn?";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 15F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(560, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(150, 96);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20);
            this.label3.Size = new System.Drawing.Size(381, 79);
            this.label3.TabIndex = 10;
            this.label3.Text = "                                    ";
            // 
            // lblCoinCount
            // 
            this.lblCoinCount.AutoSize = true;
            this.lblCoinCount.BackColor = System.Drawing.Color.Black;
            this.lblCoinCount.Font = new System.Drawing.Font("Impact", 18F);
            this.lblCoinCount.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblCoinCount.Location = new System.Drawing.Point(284, 301);
            this.lblCoinCount.Name = "lblCoinCount";
            this.lblCoinCount.Size = new System.Drawing.Size(122, 29);
            this.lblCoinCount.TabIndex = 11;
            this.lblCoinCount.Text = "Coins: ###";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(664, 357);
            this.Controls.Add(this.lblCoinCount);
            this.Controls.Add(this.btnFindCallNums);
            this.Controls.Add(this.btnReplaceBooks);
            this.Controls.Add(this.btnIdentifyAreas);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian Training - Main Menu";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplaceBooks;
        private System.Windows.Forms.Button btnIdentifyAreas;
        private System.Windows.Forms.Button btnFindCallNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCoinCount;
    }
}

