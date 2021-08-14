
namespace LibraryProgram
{
    partial class Borrow_info
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.book_title = new System.Windows.Forms.Label();
            this.writerNpublisher = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 292);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // book_title
            // 
            this.book_title.AutoSize = true;
            this.book_title.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_title.Location = new System.Drawing.Point(346, 51);
            this.book_title.Name = "book_title";
            this.book_title.Size = new System.Drawing.Size(95, 32);
            this.book_title.TabIndex = 2;
            this.book_title.Text = "책 이름";
            // 
            // writerNpublisher
            // 
            this.writerNpublisher.AutoSize = true;
            this.writerNpublisher.CausesValidation = false;
            this.writerNpublisher.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.writerNpublisher.Location = new System.Drawing.Point(348, 95);
            this.writerNpublisher.Name = "writerNpublisher";
            this.writerNpublisher.Size = new System.Drawing.Size(111, 23);
            this.writerNpublisher.TabIndex = 3;
            this.writerNpublisher.Text = "저자 · 출판사";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(636, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "대출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_borrow_click);
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(349, 128);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(153, 15);
            this.stock.TabIndex = 5;
            this.stock.Text = "대출 가능 권수 : 00권";
            // 
            // Borrow_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.writerNpublisher);
            this.Controls.Add(this.book_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Borrow_info";
            this.Text = "Borrow_info";
            this.Load += new System.EventHandler(this.Borrow_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label book_title;
        private System.Windows.Forms.Label writerNpublisher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label stock;
    }
}