namespace ContactsDB
{
    partial class CreateContactForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstnametxtbox = new System.Windows.Forms.TextBox();
            this.middlenametxtbox = new System.Windows.Forms.TextBox();
            this.lastnametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 26);
            this.textBox1.TabIndex = 0;
            // 
            // firstnametxtbox
            // 
            this.firstnametxtbox.Location = new System.Drawing.Point(249, 131);
            this.firstnametxtbox.Name = "firstnametxtbox";
            this.firstnametxtbox.Size = new System.Drawing.Size(197, 26);
            this.firstnametxtbox.TabIndex = 1;
            // 
            // middlenametxtbox
            // 
            this.middlenametxtbox.Location = new System.Drawing.Point(249, 219);
            this.middlenametxtbox.Name = "middlenametxtbox";
            this.middlenametxtbox.Size = new System.Drawing.Size(197, 26);
            this.middlenametxtbox.TabIndex = 2;
            // 
            // lastnametxtbox
            // 
            this.lastnametxtbox.Location = new System.Drawing.Point(249, 303);
            this.lastnametxtbox.Name = "lastnametxtbox";
            this.lastnametxtbox.Size = new System.Drawing.Size(197, 26);
            this.lastnametxtbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(208, 377);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(93, 61);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // CreateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnametxtbox);
            this.Controls.Add(this.middlenametxtbox);
            this.Controls.Add(this.firstnametxtbox);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateStudentForm";
            this.Text = "CreateStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox firstnametxtbox;
        private System.Windows.Forms.TextBox middlenametxtbox;
        private System.Windows.Forms.TextBox lastnametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
    }
}