
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
            this.WeightInputButton = new System.Windows.Forms.Button();
            this.WeightInputBox = new System.Windows.Forms.TextBox();
            this.kruButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBox
            // 
            this.startBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startBox.FormattingEnabled = true;
            this.startBox.Location = new System.Drawing.Point(397, 23);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(121, 27);
            this.startBox.TabIndex = 0;
            this.startBox.SelectedIndexChanged += new System.EventHandler(this.StartBox_SelectedIndexChanged);
            // 
            // destBox
            // 
            this.destBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.destBox.FormattingEnabled = true;
            this.destBox.Location = new System.Drawing.Point(565, 23);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(121, 27);
            this.destBox.TabIndex = 1;
            this.destBox.SelectedIndexChanged += new System.EventHandler(this.DestBox_SelectedIndexChanged);
            // 
            // WeightInputButton
            // 
            this.WeightInputButton.Location = new System.Drawing.Point(847, 20);
            this.WeightInputButton.Name = "WeightInputButton";
            this.WeightInputButton.Size = new System.Drawing.Size(75, 23);
            this.WeightInputButton.TabIndex = 2;
            this.WeightInputButton.Text = "입력";
            this.WeightInputButton.UseVisualStyleBackColor = true;
            this.WeightInputButton.Click += new System.EventHandler(this.WeightInputBox_Button);
            // 
            // WeightInputBox
            // 
            this.WeightInputBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightInputBox.Location = new System.Drawing.Point(717, 22);
            this.WeightInputBox.Name = "WeightInputBox";
            this.WeightInputBox.Size = new System.Drawing.Size(100, 29);
            this.WeightInputBox.TabIndex = 3;
            this.WeightInputBox.TextChanged += new System.EventHandler(this.WeightInput);
            // 
            // kruButton
            // 
            this.kruButton.Location = new System.Drawing.Point(953, 20);
            this.kruButton.Name = "kruButton";
            this.kruButton.Size = new System.Drawing.Size(75, 23);
            this.kruButton.TabIndex = 4;
            this.kruButton.Text = "크루스칼";
            this.kruButton.UseVisualStyleBackColor = true;
            this.kruButton.Click += new System.EventHandler(this.kruButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "크루스칼 중간";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.kruMiddleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kruButton);
            this.Controls.Add(this.WeightInputBox);
            this.Controls.Add(this.WeightInputButton);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.startBox);
            this.Name = "Form1";
            this.Text = "n";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.BgClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox startBox;
        private System.Windows.Forms.ComboBox destBox;
        private System.Windows.Forms.Button WeightInputButton;
        private System.Windows.Forms.TextBox WeightInputBox;
        private System.Windows.Forms.Button kruButton;
        private System.Windows.Forms.Button button1;
    }
}

