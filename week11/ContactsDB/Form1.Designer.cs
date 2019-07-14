namespace ContactsDB
{
    partial class Form1
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.prebtn = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.numbertextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(12, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(84, 39);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "LOAD";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(102, 12);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(72, 39);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(511, 374);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(82, 34);
            this.nextbtn.TabIndex = 3;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            // 
            // prebtn
            // 
            this.prebtn.Location = new System.Drawing.Point(200, 374);
            this.prebtn.Name = "prebtn";
            this.prebtn.Size = new System.Drawing.Size(84, 34);
            this.prebtn.TabIndex = 4;
            this.prebtn.Text = "Previous";
            this.prebtn.UseVisualStyleBackColor = true;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(252, 216);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(302, 56);
            this.nametextBox.TabIndex = 5;
            // 
            // numbertextBox
            // 
            this.numbertextBox.Location = new System.Drawing.Point(261, 297);
            this.numbertextBox.Multiline = true;
            this.numbertextBox.Name = "numbertextBox";
            this.numbertextBox.Size = new System.Drawing.Size(283, 41);
            this.numbertextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numbertextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.prebtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button prebtn;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox numbertextBox;
    }
}

