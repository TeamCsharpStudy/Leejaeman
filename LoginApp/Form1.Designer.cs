namespace LoginApp
{
    partial class Login
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(64, 24);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(31, 13);
            this.ID_Label.TabIndex = 0;
            this.ID_Label.Text = "ID :";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(6, 51);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(94, 13);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Password : ";
            // 
            // ID_Text
            // 
            this.ID_Text.Location = new System.Drawing.Point(105, 21);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(114, 22);
            this.ID_Text.TabIndex = 2;
            // 
            // Password_Text
            // 
            this.Password_Text.Location = new System.Drawing.Point(105, 49);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(114, 22);
            this.Password_Text.TabIndex = 3;
            this.Password_Text.UseSystemPasswordChar = true;
            this.Password_Text.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_Text_KeyUp);
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(228, 21);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(94, 49);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Log In";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 89);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.ID_Text);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.ID_Label);
            this.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox ID_Text;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.Button Login_Button;

        private string m_id;
        private string m_password;
    }
}

