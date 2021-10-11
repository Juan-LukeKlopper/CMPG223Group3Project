
namespace CMPG223GroupProject
{
    partial class AddMemberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.surnameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOfMembershipTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.booksBorrowedTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookLimitTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Location = new System.Drawing.Point(12, 44);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(260, 23);
            this.nameTxtbox.TabIndex = 1;
            // 
            // surnameTxtbox
            // 
            this.surnameTxtbox.Location = new System.Drawing.Point(12, 103);
            this.surnameTxtbox.Name = "surnameTxtbox";
            this.surnameTxtbox.Size = new System.Drawing.Size(260, 23);
            this.surnameTxtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member Surname:";
            // 
            // dateOfMembershipTxtbox
            // 
            this.dateOfMembershipTxtbox.Location = new System.Drawing.Point(12, 164);
            this.dateOfMembershipTxtbox.Name = "dateOfMembershipTxtbox";
            this.dateOfMembershipTxtbox.Size = new System.Drawing.Size(260, 23);
            this.dateOfMembershipTxtbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Membership:";
            // 
            // booksBorrowedTxtbox
            // 
            this.booksBorrowedTxtbox.Location = new System.Drawing.Point(12, 224);
            this.booksBorrowedTxtbox.Name = "booksBorrowedTxtbox";
            this.booksBorrowedTxtbox.Size = new System.Drawing.Size(260, 23);
            this.booksBorrowedTxtbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Books Borrowed:";
            // 
            // bookLimitTxtbox
            // 
            this.bookLimitTxtbox.Location = new System.Drawing.Point(12, 290);
            this.bookLimitTxtbox.Name = "bookLimitTxtbox";
            this.bookLimitTxtbox.Size = new System.Drawing.Size(260, 23);
            this.bookLimitTxtbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Limit:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookLimitTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.booksBorrowedTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateOfMembershipTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtbox);
            this.Controls.Add(this.label1);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.TextBox surnameTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateOfMembershipTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox booksBorrowedTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookLimitTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}