
namespace Library_management_system
{
    partial class SubBorrower
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
            this.Borrow_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.borrowerBook_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(222, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower Interface";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Borrow_button
            // 
            this.Borrow_button.BackColor = System.Drawing.Color.Tan;
            this.Borrow_button.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Borrow_button.Location = new System.Drawing.Point(394, 114);
            this.Borrow_button.Name = "Borrow_button";
            this.Borrow_button.Size = new System.Drawing.Size(253, 44);
            this.Borrow_button.TabIndex = 1;
            this.Borrow_button.Text = "Borrow Book";
            this.Borrow_button.UseVisualStyleBackColor = false;
            this.Borrow_button.Click += new System.EventHandler(this.Borrow_button_Click);
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.Tan;
            this.return_button.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.return_button.Location = new System.Drawing.Point(76, 114);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(274, 44);
            this.return_button.TabIndex = 2;
            this.return_button.Text = "Return Book";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // borrowerBook_button
            // 
            this.borrowerBook_button.BackColor = System.Drawing.Color.Tan;
            this.borrowerBook_button.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerBook_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.borrowerBook_button.Location = new System.Drawing.Point(76, 194);
            this.borrowerBook_button.Name = "borrowerBook_button";
            this.borrowerBook_button.Size = new System.Drawing.Size(274, 50);
            this.borrowerBook_button.TabIndex = 3;
            this.borrowerBook_button.Text = "View borrowerd book";
            this.borrowerBook_button.UseVisualStyleBackColor = false;
            this.borrowerBook_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Tan;
            this.Search_button.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search_button.Location = new System.Drawing.Point(394, 194);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(253, 50);
            this.Search_button.TabIndex = 4;
            this.Search_button.Text = "Search for book";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.return_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Borrow_button);
            this.groupBox1.Controls.Add(this.borrowerBook_button);
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Location = new System.Drawing.Point(56, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // SubBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubBorrower";
            this.Text = "SubBorrower";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Borrow_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button borrowerBook_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}