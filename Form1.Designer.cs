
namespace AlgoSub2
{
    partial class Form1
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
            this.startBox = new System.Windows.Forms.ComboBox();
            this.destBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startBox
            // 
            this.startBox.FormattingEnabled = true;
            this.startBox.Location = new System.Drawing.Point(397, 23);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(121, 20);
            this.startBox.TabIndex = 0;
            this.startBox.SelectedIndexChanged += new System.EventHandler(this.StartBox_SelectedIndexChanged);
            // 
            // destBox
            // 
            this.destBox.FormattingEnabled = true;
            this.destBox.Location = new System.Drawing.Point(565, 23);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(121, 20);
            this.destBox.TabIndex = 1;
            this.destBox.SelectedIndexChanged += new System.EventHandler(this.DestBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 695);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.startBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.BgClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox startBox;
        private System.Windows.Forms.ComboBox destBox;
    }
}

