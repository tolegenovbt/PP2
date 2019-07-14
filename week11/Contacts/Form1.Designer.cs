namespace Employees
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
            this.surnametextBox = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.agetxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
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
            this.CreateBtn.Location = new System.Drawing.Point(357, 399);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(72, 39);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(491, 309);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(82, 34);
            this.nextbtn.TabIndex = 3;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // prebtn
            // 
            this.prebtn.Location = new System.Drawing.Point(190, 309);
            this.prebtn.Name = "prebtn";
            this.prebtn.Size = new System.Drawing.Size(84, 34);
            this.prebtn.TabIndex = 4;
            this.prebtn.Text = "Previous";
            this.prebtn.UseVisualStyleBackColor = true;
            this.prebtn.Click += new System.EventHandler(this.prebtn_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(84, 139);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(200, 35);
            this.nametextBox.TabIndex = 5;
            // 
            // surnametextBox
            // 
            this.surnametextBox.Location = new System.Drawing.Point(84, 222);
            this.surnametextBox.Multiline = true;
            this.surnametextBox.Name = "surnametextBox";
            this.surnametextBox.Size = new System.Drawing.Size(200, 39);
            this.surnametextBox.TabIndex = 6;
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(440, 139);
            this.emailtxtbox.Multiline = true;
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(200, 35);
            this.emailtxtbox.TabIndex = 7;
            // 
            // agetxtbox
            // 
            this.agetxtbox.Location = new System.Drawing.Point(440, 222);
            this.agetxtbox.Multiline = true;
            this.agetxtbox.Name = "agetxtbox";
            this.agetxtbox.Size = new System.Drawing.Size(200, 35);
            this.agetxtbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Age";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(346, 73);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(26, 20);
            this.idlbl.TabIndex = 13;
            this.idlbl.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agetxtbox);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.surnametextBox);
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
        private System.Windows.Forms.TextBox surnametextBox;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox agetxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idlbl;
    }
}

