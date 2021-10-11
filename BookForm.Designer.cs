
namespace CMPG223GroupProject
{
    partial class BookForm
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
            this.SuspendLayout();
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ResumeLayout(false);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSearchBooks = new System.Windows.Forms.Label();
            this.textBoxAddBook = new System.Windows.Forms.TextBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.textBoxSearchBook = new System.Windows.Forms.TextBox();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxOrderedBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.LabelStudents = new System.Windows.Forms.Label();
            this.textBoxAddBookStudents = new System.Windows.Forms.TextBox();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAddbookStudent = new System.Windows.Forms.Button();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxSearchBookStudent = new System.Windows.Forms.TextBox();
            this.listBoxBooksAvailable = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.labelSearchBooks);
            this.tabPage1.Controls.Add(this.textBoxAddBook);
            this.tabPage1.Controls.Add(this.buttonDeleteBook);
            this.tabPage1.Controls.Add(this.buttonAddBook);
            this.tabPage1.Controls.Add(this.buttonSearchBook);
            this.tabPage1.Controls.Add(this.textBoxSearchBook);
            this.tabPage1.Controls.Add(this.listBoxBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Manage Books";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(818, 433);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSearchBooks
            // 
            this.labelSearchBooks.Location = new System.Drawing.Point(27, 80);
            this.labelSearchBooks.Name = "labelSearchBooks";
            this.labelSearchBooks.Size = new System.Drawing.Size(409, 66);
            this.labelSearchBooks.TabIndex = 8;
            // 
            // textBoxAddBook
            // 
            this.textBoxAddBook.Location = new System.Drawing.Point(453, 158);
            this.textBoxAddBook.Name = "textBoxAddBook";
            this.textBoxAddBook.Size = new System.Drawing.Size(219, 27);
            this.textBoxAddBook.TabIndex = 6;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(698, 433);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(114, 29);
            this.buttonDeleteBook.TabIndex = 4;
            this.buttonDeleteBook.Text = "Delete Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(678, 158);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(114, 29);
            this.buttonAddBook.TabIndex = 3;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(342, 46);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(94, 29);
            this.buttonSearchBook.TabIndex = 2;
            this.buttonSearchBook.Text = "Search";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // textBoxSearchBook
            // 
            this.textBoxSearchBook.Location = new System.Drawing.Point(27, 46);
            this.textBoxSearchBook.Name = "textBoxSearchBook";
            this.textBoxSearchBook.Size = new System.Drawing.Size(309, 27);
            this.textBoxSearchBook.TabIndex = 1;
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 20;
            this.listBoxBooks.Items.AddRange(new object[] {
            "Geography 698-589-539",
            "Chemistry 789-286-007",
            "Biology 689-895-696",
            "Business Management 134-749-468",
            "Mathematics 332-456-987",
            "C# 998-112-664",
            "System analysis 333-154-014"});
            this.listBoxBooks.Location = new System.Drawing.Point(27, 158);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(409, 304);
            this.listBoxBooks.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.listBoxOrderedBooks);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.LabelStudents);
            this.tabPage2.Controls.Add(this.textBoxAddBookStudents);
            this.tabPage2.Controls.Add(this.buttonDeleteStudent);
            this.tabPage2.Controls.Add(this.buttonAddbookStudent);
            this.tabPage2.Controls.Add(this.buttonSearchStudent);
            this.tabPage2.Controls.Add(this.textBoxSearchBookStudent);
            this.tabPage2.Controls.Add(this.listBoxBooksAvailable);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Students";
            // 
            // listBoxOrderedBooks
            // 
            this.listBoxOrderedBooks.FormattingEnabled = true;
            this.listBoxOrderedBooks.ItemHeight = 20;
            this.listBoxOrderedBooks.Location = new System.Drawing.Point(423, 194);
            this.listBoxOrderedBooks.Name = "listBoxOrderedBooks";
            this.listBoxOrderedBooks.Size = new System.Drawing.Size(351, 204);
            this.listBoxOrderedBooks.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Form";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(789, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LabelStudents
            // 
            this.LabelStudents.Location = new System.Drawing.Point(28, 76);
            this.LabelStudents.Name = "LabelStudents";
            this.LabelStudents.Size = new System.Drawing.Size(388, 56);
            this.LabelStudents.TabIndex = 7;
            // 
            // textBoxAddBookStudents
            // 
            this.textBoxAddBookStudents.Location = new System.Drawing.Point(423, 147);
            this.textBoxAddBookStudents.Name = "textBoxAddBookStudents";
            this.textBoxAddBookStudents.Size = new System.Drawing.Size(225, 27);
            this.textBoxAddBookStudents.TabIndex = 5;
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(654, 422);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(120, 29);
            this.buttonDeleteStudent.TabIndex = 4;
            this.buttonDeleteStudent.Text = "Delete book";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonAddbookStudent
            // 
            this.buttonAddbookStudent.Location = new System.Drawing.Point(654, 147);
            this.buttonAddbookStudent.Name = "buttonAddbookStudent";
            this.buttonAddbookStudent.Size = new System.Drawing.Size(120, 29);
            this.buttonAddbookStudent.TabIndex = 3;
            this.buttonAddbookStudent.Text = "Add Book";
            this.buttonAddbookStudent.UseVisualStyleBackColor = true;
            this.buttonAddbookStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.Location = new System.Drawing.Point(295, 44);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(121, 29);
            this.buttonSearchStudent.TabIndex = 2;
            this.buttonSearchStudent.Text = "Search Book";
            this.buttonSearchStudent.UseVisualStyleBackColor = true;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // textBoxSearchBookStudent
            // 
            this.textBoxSearchBookStudent.Location = new System.Drawing.Point(28, 46);
            this.textBoxSearchBookStudent.Name = "textBoxSearchBookStudent";
            this.textBoxSearchBookStudent.Size = new System.Drawing.Size(261, 27);
            this.textBoxSearchBookStudent.TabIndex = 1;
            // 
            // listBoxBooksAvailable
            // 
            this.listBoxBooksAvailable.FormattingEnabled = true;
            this.listBoxBooksAvailable.ItemHeight = 20;
            this.listBoxBooksAvailable.Items.AddRange(new object[] {
            "Geography 698-589-539",
            "Chemistry 789-286-007",
            "Biology 689-895-696",
            "Business Management 134-749-468",
            "Mathematics 332-456-987",
            "C# 998-112-664",
            "System analysis 333-154-014"});
            this.listBoxBooksAvailable.Location = new System.Drawing.Point(28, 147);
            this.listBoxBooksAvailable.Name = "listBoxBooksAvailable";
            this.listBoxBooksAvailable.Size = new System.Drawing.Size(388, 304);
            this.listBoxBooksAvailable.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(866, 538);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 579);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelSearchBooks;
        private System.Windows.Forms.TextBox textBoxAddBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.TextBox textBoxSearchBook;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LabelStudents;
        private System.Windows.Forms.TextBox textBoxAddBookStudents;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonAddbookStudent;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxSearchBookStudent;
        private System.Windows.Forms.ListBox listBoxBooksAvailable;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrderedBooks;
    }
}
