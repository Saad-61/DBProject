
namespace DBProject
{
    partial class SignUP
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUP));
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelRePassword = new Label();
            textBoxRePassword = new TextBox();
            buttonContinue = new Button();
            labelSignIn = new LinkLabel();
            label2 = new Label();
            linkLabelConditions = new LinkLabel();
            label3 = new Label();
            linkLabelPrivacy = new LinkLabel();
            labelNewToAmazon = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            linkLabel3 = new LinkLabel();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(476, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(367, 120);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(431, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Create account";
            // 
            // labelName
            // 
            labelName.Font = new Font("Microsoft Sans Serif", 12F);
            labelName.Location = new Point(367, 160);
            labelName.Name = "labelName";
            labelName.Size = new Size(200, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Your name";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxName.Location = new Point(367, 196);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "First and last name";
            textBoxName.Size = new Size(488, 26);
            textBoxName.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Microsoft Sans Serif", 12F);
            labelEmail.Location = new Point(367, 238);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(240, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Mobile number or email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxEmail.Location = new Point(367, 272);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(488, 26);
            textBoxEmail.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Microsoft Sans Serif", 12F);
            labelPassword.Location = new Point(367, 315);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 20);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxPassword.Location = new Point(367, 352);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "At least 6 characters";
            textBoxPassword.Size = new Size(488, 26);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelRePassword
            // 
            labelRePassword.Font = new Font("Microsoft Sans Serif", 12F);
            labelRePassword.Location = new Point(367, 398);
            labelRePassword.Name = "labelRePassword";
            labelRePassword.Size = new Size(150, 20);
            labelRePassword.TabIndex = 8;
            labelRePassword.Text = "Re-enter password";
            // 
            // textBoxRePassword
            // 
            textBoxRePassword.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxRePassword.Location = new Point(367, 438);
            textBoxRePassword.Name = "textBoxRePassword";
            textBoxRePassword.Size = new Size(488, 26);
            textBoxRePassword.TabIndex = 9;
            textBoxRePassword.UseSystemPasswordChar = true;
            // 
            // buttonContinue
            // 
            buttonContinue.BackColor = Color.Gold;
            buttonContinue.FlatStyle = FlatStyle.Flat;
            buttonContinue.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonContinue.Location = new Point(367, 488);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(488, 40);
            buttonContinue.TabIndex = 10;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = false;
            // 
            // labelSignIn
            // 
            labelSignIn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Underline);
            labelSignIn.ForeColor = Color.Blue;
            labelSignIn.Location = new Point(604, 670);
            labelSignIn.Name = "labelSignIn";
            labelSignIn.Size = new Size(238, 23);
            labelSignIn.TabIndex = 13;
            labelSignIn.TabStop = true;
            labelSignIn.Text = "Sign in";
            labelSignIn.LinkClicked += labelSignIn_LinkClicked;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(367, 546);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 29);
            label2.TabIndex = 14;
            label2.Text = "By continuing, you agree to Amazon's";
            // 
            // linkLabelConditions
            // 
            linkLabelConditions.AutoSize = true;
            linkLabelConditions.Location = new Point(703, 550);
            linkLabelConditions.Margin = new Padding(4, 0, 4, 0);
            linkLabelConditions.Name = "linkLabelConditions";
            linkLabelConditions.Size = new Size(152, 20);
            linkLabelConditions.TabIndex = 15;
            linkLabelConditions.TabStop = true;
            linkLabelConditions.Text = "Terms and Conditions";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(369, 575);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 29);
            label3.TabIndex = 16;
            label3.Text = "and";
            // 
            // linkLabelPrivacy
            // 
            linkLabelPrivacy.AutoSize = true;
            linkLabelPrivacy.Location = new Point(409, 579);
            linkLabelPrivacy.Margin = new Padding(4, 0, 4, 0);
            linkLabelPrivacy.Name = "linkLabelPrivacy";
            linkLabelPrivacy.Size = new Size(97, 20);
            linkLabelPrivacy.TabIndex = 17;
            linkLabelPrivacy.TabStop = true;
            linkLabelPrivacy.Text = "Privacy Policy";
            // 
            // labelNewToAmazon
            // 
            labelNewToAmazon.Font = new Font("Microsoft Sans Serif", 10F);
            labelNewToAmazon.ForeColor = Color.DimGray;
            labelNewToAmazon.Location = new Point(369, 631);
            labelNewToAmazon.Name = "labelNewToAmazon";
            labelNewToAmazon.Size = new Size(486, 25);
            labelNewToAmazon.TabIndex = 18;
            labelNewToAmazon.Text = "-----------------------------New to Amazon?-----------------------------";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(369, 665);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 29);
            label1.TabIndex = 19;
            label1.Text = "Already have an account?";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Underline);
            linkLabel1.ForeColor = Color.Blue;
            linkLabel1.Location = new Point(554, 844);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(238, 23);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign in";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(319, 839);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(249, 29);
            label4.TabIndex = 37;
            label4.Text = "Already have an account?";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(319, 805);
            label5.Name = "label5";
            label5.Size = new Size(486, 25);
            label5.TabIndex = 36;
            label5.Text = "-----------------------------New to Amazon?-----------------------------";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(359, 753);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(97, 20);
            linkLabel2.TabIndex = 35;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Privacy Policy";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(319, 749);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 29);
            label6.TabIndex = 34;
            label6.Text = "and";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(653, 724);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(152, 20);
            linkLabel3.TabIndex = 33;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Terms and Conditions";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(317, 720);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(350, 29);
            label7.TabIndex = 32;
            label7.Text = "By continuing, you agree to Amazon's";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(426, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label8.Location = new Point(317, 294);
            label8.Name = "label8";
            label8.Size = new Size(431, 40);
            label8.TabIndex = 21;
            label8.Text = "Create account";
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(317, 334);
            label9.Name = "label9";
            label9.Size = new Size(200, 20);
            label9.TabIndex = 22;
            label9.Text = "Your name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F);
            textBox1.Location = new Point(317, 370);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First and last name";
            textBox1.Size = new Size(488, 26);
            textBox1.TabIndex = 23;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(317, 412);
            label10.Name = "label10";
            label10.Size = new Size(240, 20);
            label10.TabIndex = 24;
            label10.Text = "Mobile number or email";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10F);
            textBox2.Location = new Point(317, 446);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(488, 26);
            textBox2.TabIndex = 25;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(317, 489);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 26;
            label11.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 10F);
            textBox3.Location = new Point(317, 526);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "At least 6 characters";
            textBox3.Size = new Size(488, 26);
            textBox3.TabIndex = 27;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 12F);
            label12.Location = new Point(317, 572);
            label12.Name = "label12";
            label12.Size = new Size(150, 20);
            label12.TabIndex = 28;
            label12.Text = "Re-enter password";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 10F);
            textBox4.Location = new Point(317, 612);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(488, 26);
            textBox4.TabIndex = 29;
            textBox4.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.Location = new Point(317, 662);
            button1.Name = "button1";
            button1.Size = new Size(488, 40);
            button1.TabIndex = 30;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            // 
            // SignUP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 1055);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(linkLabel3);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(textBox3);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(labelSignIn);
            Controls.Add(label1);
            Controls.Add(labelNewToAmazon);
            Controls.Add(linkLabelPrivacy);
            Controls.Add(label3);
            Controls.Add(linkLabelConditions);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelRePassword);
            Controls.Add(textBoxRePassword);
            Controls.Add(buttonContinue);
            Name = "SignUP";
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void labelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitle;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelRePassword;
        private TextBox textBoxRePassword;
        private Button buttonContinue;
        private LinkLabel labelSignIn;
        private Label label2;
        private LinkLabel linkLabelConditions;
        private Label label3;
        private LinkLabel linkLabelPrivacy;
        private Label labelNewToAmazon;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel2;
        private Label label6;
        private LinkLabel linkLabel3;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private Label label10;
        private TextBox textBox2;
        private Label label11;
        private TextBox textBox3;
        private Label label12;
        private TextBox textBox4;
        private Button button1;
    }
}
