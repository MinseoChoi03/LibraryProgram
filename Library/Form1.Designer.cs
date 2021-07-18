
namespace Library
{
    partial class 도서관
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(도서관));
            this.borrowAndreturn = new System.Windows.Forms.Button();
            this.makeCard = new System.Windows.Forms.Button();
            this.giveOrbuy = new System.Windows.Forms.Button();
            this.myPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borrowAndreturn
            // 
            this.borrowAndreturn.BackColor = System.Drawing.Color.White;
            this.borrowAndreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.borrowAndreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowAndreturn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.borrowAndreturn.FlatAppearance.BorderSize = 0;
            this.borrowAndreturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.borrowAndreturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.borrowAndreturn.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.borrowAndreturn.Location = new System.Drawing.Point(320, 400);
            this.borrowAndreturn.Name = "borrowAndreturn";
            this.borrowAndreturn.Size = new System.Drawing.Size(320, 60);
            this.borrowAndreturn.TabIndex = 0;
            this.borrowAndreturn.TabStop = false;
            this.borrowAndreturn.Text = "대출 및 반납";
            this.borrowAndreturn.UseVisualStyleBackColor = false;
            this.borrowAndreturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // makeCard
            // 
            this.makeCard.BackColor = System.Drawing.Color.White;
            this.makeCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.makeCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.makeCard.FlatAppearance.BorderSize = 0;
            this.makeCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.makeCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.makeCard.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.makeCard.Location = new System.Drawing.Point(320, 470);
            this.makeCard.Name = "makeCard";
            this.makeCard.Size = new System.Drawing.Size(320, 60);
            this.makeCard.TabIndex = 1;
            this.makeCard.TabStop = false;
            this.makeCard.Text = "대출(회원) 카드 만들기";
            this.makeCard.UseVisualStyleBackColor = false;
            // 
            // giveOrbuy
            // 
            this.giveOrbuy.BackColor = System.Drawing.Color.White;
            this.giveOrbuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.giveOrbuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giveOrbuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.giveOrbuy.FlatAppearance.BorderSize = 0;
            this.giveOrbuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.giveOrbuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.giveOrbuy.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.giveOrbuy.Location = new System.Drawing.Point(320, 540);
            this.giveOrbuy.Name = "giveOrbuy";
            this.giveOrbuy.Size = new System.Drawing.Size(320, 60);
            this.giveOrbuy.TabIndex = 2;
            this.giveOrbuy.TabStop = false;
            this.giveOrbuy.Text = "도서 기부 및 구매";
            this.giveOrbuy.UseVisualStyleBackColor = false;
            // 
            // myPage
            // 
            this.myPage.BackColor = System.Drawing.Color.White;
            this.myPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myPage.FlatAppearance.BorderSize = 0;
            this.myPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.myPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.myPage.Font = new System.Drawing.Font("에스코어 드림 6 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.myPage.Location = new System.Drawing.Point(320, 610);
            this.myPage.Name = "myPage";
            this.myPage.Size = new System.Drawing.Size(320, 60);
            this.myPage.TabIndex = 3;
            this.myPage.TabStop = false;
            this.myPage.Text = "마이 페이지";
            this.myPage.UseVisualStyleBackColor = false;
            // 
            // 도서관
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 733);
            this.Controls.Add(this.myPage);
            this.Controls.Add(this.giveOrbuy);
            this.Controls.Add(this.makeCard);
            this.Controls.Add(this.borrowAndreturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "도서관";
            this.Text = "도서관";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button borrowAndreturn;
        private System.Windows.Forms.Button makeCard;
        private System.Windows.Forms.Button giveOrbuy;
        private System.Windows.Forms.Button myPage;
    }
}

