namespace KingsRaidCalc4AtkCrtdmg
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
            this.heroPicBox = new System.Windows.Forms.PictureBox();
            this.heroNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heroPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heroPicBox
            // 
            this.heroPicBox.Location = new System.Drawing.Point(12, 13);
            this.heroPicBox.Name = "heroPicBox";
            this.heroPicBox.Size = new System.Drawing.Size(110, 110);
            this.heroPicBox.TabIndex = 0;
            this.heroPicBox.TabStop = false;
            // 
            // heroNameComboBox
            // 
            this.heroNameComboBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.heroNameComboBox.FormattingEnabled = true;
            this.heroNameComboBox.Location = new System.Drawing.Point(128, 45);
            this.heroNameComboBox.Name = "heroNameComboBox";
            this.heroNameComboBox.Size = new System.Drawing.Size(140, 27);
            this.heroNameComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(132, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "영웅 이름";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heroNameComboBox);
            this.Controls.Add(this.heroPicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.heroPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox heroPicBox;
        private System.Windows.Forms.ComboBox heroNameComboBox;
        private System.Windows.Forms.Label label1;
    }
}

