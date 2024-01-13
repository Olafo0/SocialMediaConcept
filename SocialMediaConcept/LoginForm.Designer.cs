namespace SocialMediaConcept
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPanel = new Panel();
            SignUpLB = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordTB = new TextBox();
            UsernameTB = new TextBox();
            SignUpPanel = new Panel();
            LoginLB = new Label();
            CreateAccountBTN = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            CreatePasswordTB = new TextBox();
            groupBox1 = new GroupBox();
            CreateUsernameTB = new TextBox();
            label5 = new Label();
            CreateDisplayTB = new TextBox();
            label4 = new Label();
            EmailGB = new GroupBox();
            EmailTB = new TextBox();
            LoginBTN = new Button();
            LoginPanel.SuspendLayout();
            SignUpPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            EmailGB.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LoginBTN);
            LoginPanel.Controls.Add(SignUpLB);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(PasswordTB);
            LoginPanel.Controls.Add(UsernameTB);
            LoginPanel.Location = new Point(299, 63);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(265, 216);
            LoginPanel.TabIndex = 0;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // SignUpLB
            // 
            SignUpLB.AutoSize = true;
            SignUpLB.Cursor = Cursors.Hand;
            SignUpLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpLB.ForeColor = Color.CornflowerBlue;
            SignUpLB.Location = new Point(163, 180);
            SignUpLB.Name = "SignUpLB";
            SignUpLB.Size = new Size(81, 15);
            SignUpLB.TabIndex = 6;
            SignUpLB.Text = "Sign up here!";
            SignUpLB.Click += SignUpLB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 180);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 4;
            label3.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(75, 107);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(108, 23);
            PasswordTB.TabIndex = 1;
            // 
            // UsernameTB
            // 
            UsernameTB.Location = new Point(75, 52);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(108, 23);
            UsernameTB.TabIndex = 0;
            // 
            // SignUpPanel
            // 
            SignUpPanel.Controls.Add(LoginLB);
            SignUpPanel.Controls.Add(CreateAccountBTN);
            SignUpPanel.Controls.Add(groupBox2);
            SignUpPanel.Controls.Add(groupBox1);
            SignUpPanel.Controls.Add(EmailGB);
            SignUpPanel.Location = new Point(12, 12);
            SignUpPanel.Name = "SignUpPanel";
            SignUpPanel.Size = new Size(284, 405);
            SignUpPanel.TabIndex = 1;
            SignUpPanel.Visible = false;
            // 
            // LoginLB
            // 
            LoginLB.AutoSize = true;
            LoginLB.Cursor = Cursors.Hand;
            LoginLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLB.ForeColor = Color.CornflowerBlue;
            LoginLB.Location = new Point(110, 382);
            LoginLB.Name = "LoginLB";
            LoginLB.Size = new Size(66, 15);
            LoginLB.TabIndex = 7;
            LoginLB.Text = "Login here";
            LoginLB.Click += LoginLB_Click;
            // 
            // CreateAccountBTN
            // 
            CreateAccountBTN.Location = new Point(80, 354);
            CreateAccountBTN.Name = "CreateAccountBTN";
            CreateAccountBTN.Size = new Size(122, 22);
            CreateAccountBTN.TabIndex = 2;
            CreateAccountBTN.Text = "Create account";
            CreateAccountBTN.UseVisualStyleBackColor = true;
            CreateAccountBTN.Click += CreateAccountBTN_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CreatePasswordTB);
            groupBox2.Location = new Point(3, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " Password ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 74);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 1;
            label6.Text = "+ Requirements";
            // 
            // CreatePasswordTB
            // 
            CreatePasswordTB.Location = new Point(55, 35);
            CreatePasswordTB.Name = "CreatePasswordTB";
            CreatePasswordTB.Size = new Size(170, 23);
            CreatePasswordTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CreateUsernameTB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CreateDisplayTB);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(3, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 141);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // CreateUsernameTB
            // 
            CreateUsernameTB.Location = new Point(7, 39);
            CreateUsernameTB.Name = "CreateUsernameTB";
            CreateUsernameTB.Size = new Size(120, 23);
            CreateUsernameTB.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 3;
            label5.Text = "Display name";
            // 
            // CreateDisplayTB
            // 
            CreateDisplayTB.Location = new Point(6, 96);
            CreateDisplayTB.Name = "CreateDisplayTB";
            CreateDisplayTB.Size = new Size(120, 23);
            CreateDisplayTB.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 1;
            label4.Text = "Username - Unique";
            // 
            // EmailGB
            // 
            EmailGB.Controls.Add(EmailTB);
            EmailGB.Location = new Point(3, 3);
            EmailGB.Name = "EmailGB";
            EmailGB.Size = new Size(278, 63);
            EmailGB.TabIndex = 0;
            EmailGB.TabStop = false;
            EmailGB.Text = " Email ";
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(46, 20);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(185, 23);
            EmailTB.TabIndex = 0;
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = SystemColors.ActiveCaption;
            LoginBTN.FlatStyle = FlatStyle.Flat;
            LoginBTN.Location = new Point(87, 141);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(82, 30);
            LoginBTN.TabIndex = 7;
            LoginBTN.Text = "Login";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(SignUpPanel);
            Controls.Add(LoginPanel);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            SignUpPanel.ResumeLayout(false);
            SignUpPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            EmailGB.ResumeLayout(false);
            EmailGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label SignUpLB;
        private Panel SignUpPanel;
        private GroupBox groupBox1;
        private GroupBox EmailGB;
        private TextBox EmailTB;
        private Label label4;
        private Label label5;
        private TextBox CreateDisplayTB;
        private Label LoginLB;
        private Button CreateAccountBTN;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox CreatePasswordTB;
        private TextBox CreateUsernameTB;
        private Button LoginBTN;
    }
}