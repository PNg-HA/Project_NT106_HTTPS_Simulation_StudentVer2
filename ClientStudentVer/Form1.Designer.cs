﻿
namespace ClientStudentVer
{
    partial class Form1
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
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RespHeadTextBox = new System.Windows.Forms.TextBox();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.UpdateButt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DeliLabel = new System.Windows.Forms.Label();
            this.FinishSignUpButt = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SignInButton.Location = new System.Drawing.Point(98, 196);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(116, 46);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Đăng nhập";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SignUpButton.Location = new System.Drawing.Point(233, 196);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(112, 46);
            this.SignUpButton.TabIndex = 3;
            this.SignUpButton.Text = "Đăng ký";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(105, 82);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(240, 34);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.Text = "Tên tài khoản";
            this.usernameTextBox.Click += new System.EventHandler(this.usernameTextBox_Click);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(105, 141);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(240, 34);
            this.passTextBox.TabIndex = 7;
            this.passTextBox.Text = "Mật khẩu";
            this.passTextBox.Click += new System.EventHandler(this.passTextBox_Click);
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            this.passTextBox.Leave += new System.EventHandler(this.passTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(853, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.statusLabel.Location = new System.Drawing.Point(934, 35);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(222, 29);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "<code-description>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Response:";
            // 
            // RespHeadTextBox
            // 
            this.RespHeadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespHeadTextBox.Location = new System.Drawing.Point(461, 69);
            this.RespHeadTextBox.Multiline = true;
            this.RespHeadTextBox.Name = "RespHeadTextBox";
            this.RespHeadTextBox.ReadOnly = true;
            this.RespHeadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RespHeadTextBox.Size = new System.Drawing.Size(694, 230);
            this.RespHeadTextBox.TabIndex = 20;
            // 
            // SignOutButton
            // 
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SignOutButton.Location = new System.Drawing.Point(154, 873);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(111, 43);
            this.SignOutButton.TabIndex = 33;
            this.SignOutButton.Text = "Đăng xuất";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // UpdateButt
            // 
            this.UpdateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateButt.Location = new System.Drawing.Point(283, 873);
            this.UpdateButt.Name = "UpdateButt";
            this.UpdateButt.Size = new System.Drawing.Size(111, 43);
            this.UpdateButt.TabIndex = 25;
            this.UpdateButt.Text = "Cập nhật";
            this.UpdateButt.UseVisualStyleBackColor = true;
            this.UpdateButt.Click += new System.EventHandler(this.UpdateButt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1186, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Log:";
            // 
            // DeliLabel
            // 
            this.DeliLabel.AutoSize = true;
            this.DeliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliLabel.ForeColor = System.Drawing.Color.Blue;
            this.DeliLabel.Location = new System.Drawing.Point(26, 270);
            this.DeliLabel.Name = "DeliLabel";
            this.DeliLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeliLabel.Size = new System.Drawing.Size(403, 29);
            this.DeliLabel.TabIndex = 36;
            this.DeliLabel.Text = "______________________________";
            // 
            // FinishSignUpButt
            // 
            this.FinishSignUpButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FinishSignUpButt.Location = new System.Drawing.Point(200, 922);
            this.FinishSignUpButt.Name = "FinishSignUpButt";
            this.FinishSignUpButt.Size = new System.Drawing.Size(273, 46);
            this.FinishSignUpButt.TabIndex = 37;
            this.FinishSignUpButt.Text = "Hoàn tất đăng ký";
            this.FinishSignUpButt.UseVisualStyleBackColor = true;
            this.FinishSignUpButt.Click += new System.EventHandler(this.FinishSignUpButt_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.Location = new System.Drawing.Point(1191, 69);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(357, 230);
            this.LogTextBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Render:";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SendButton.Location = new System.Drawing.Point(194, 396);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(109, 43);
            this.SendButton.TabIndex = 44;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Items.AddRange(new object[] {
            "GET",
            "HEAD",
            "DELETE"});
            this.MethodComboBox.Location = new System.Drawing.Point(75, 399);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(120, 37);
            this.MethodComboBox.TabIndex = 43;
            this.MethodComboBox.Text = "GET";
            this.MethodComboBox.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(461, 354);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1087, 339);
            this.webBrowser.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 864);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MethodComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.FinishSignUpButt);
            this.Controls.Add(this.DeliLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.UpdateButt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RespHeadTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInButton);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RespHeadTextBox;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button UpdateButt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DeliLabel;
        private System.Windows.Forms.Button FinishSignUpButt;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

