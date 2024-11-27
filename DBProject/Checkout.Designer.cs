using System;
using System.Windows.Forms;
using System.Drawing;

namespace DBProject
{
    partial class CheckoutForm : Form
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            addressPanel = new Panel();
            fullNameTextBox = new TextBox();
            addressTitle = new Label();
            countryLabel = new Label();
            countryDropdown = new ComboBox();
            fullNameLabel = new Label();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            amazonLogo = new PictureBox();
            stepOneLabel = new Label();
            summaryPanel = new Panel();
            linkLabelConditions = new LinkLabel();
            label2 = new Label();
            summaryTitle = new Label();
            itemSummary = new Label();
            shippingSummary = new Label();
            taxSummary = new Label();
            totalSummary = new Label();
            placeOrderButton = new Button();
            footerText = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            stepTwoLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel3 = new LinkLabel();
            addressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amazonLogo).BeginInit();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addressPanel
            // 
            addressPanel.BackColor = Color.White;
            addressPanel.BorderStyle = BorderStyle.FixedSingle;
            addressPanel.Controls.Add(fullNameTextBox);
            addressPanel.Controls.Add(addressTitle);
            addressPanel.Controls.Add(countryLabel);
            addressPanel.Controls.Add(countryDropdown);
            addressPanel.Controls.Add(fullNameLabel);
            addressPanel.Controls.Add(phoneLabel);
            addressPanel.Controls.Add(phoneTextBox);
            addressPanel.Controls.Add(addressLabel);
            addressPanel.Controls.Add(addressTextBox);
            addressPanel.Location = new Point(20, 161);
            addressPanel.Name = "addressPanel";
            addressPanel.Size = new Size(700, 250);
            addressPanel.TabIndex = 2;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(221, 100);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(429, 27);
            fullNameTextBox.TabIndex = 4;
            // 
            // addressTitle
            // 
            addressTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            addressTitle.Location = new Point(10, 10);
            addressTitle.Name = "addressTitle";
            addressTitle.Size = new Size(439, 37);
            addressTitle.TabIndex = 0;
            addressTitle.Text = "Add a New Address";
            addressTitle.Click += addressTitle_Click;
            // 
            // countryLabel
            // 
            countryLabel.Location = new Point(10, 59);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(130, 20);
            countryLabel.TabIndex = 1;
            countryLabel.Text = "Country/Region";
            countryLabel.Click += countryLabel_Click;
            // 
            // countryDropdown
            // 
            countryDropdown.Items.AddRange(new object[] { "United States", "Canada", "United Kingdom", "Australia", "India", "Germany", "France", "Japan", "China", "Brazil" });
            countryDropdown.Location = new Point(150, 50);
            countryDropdown.Name = "countryDropdown";
            countryDropdown.Size = new Size(500, 28);
            countryDropdown.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Location = new Point(10, 103);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(234, 20);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full name (First and Last name)";
            fullNameLabel.Click += fullNameLabel_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.Location = new Point(10, 150);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(130, 20);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone number";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(150, 150);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(500, 27);
            phoneTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.Location = new Point(10, 200);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(130, 20);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(150, 200);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(500, 27);
            addressTextBox.TabIndex = 8;
            // 
            // amazonLogo
            // 
            amazonLogo.Image = (Image)resources.GetObject("amazonLogo.Image");
            amazonLogo.Location = new Point(20, 10);
            amazonLogo.Name = "amazonLogo";
            amazonLogo.Size = new Size(174, 78);
            amazonLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            amazonLogo.TabIndex = 0;
            amazonLogo.TabStop = false;
            // 
            // stepOneLabel
            // 
            stepOneLabel.Font = new Font("Arial", 15F, FontStyle.Bold);
            stepOneLabel.ForeColor = Color.FromArgb(192, 64, 0);
            stepOneLabel.Location = new Point(20, 112);
            stepOneLabel.Name = "stepOneLabel";
            stepOneLabel.Size = new Size(431, 46);
            stepOneLabel.TabIndex = 1;
            stepOneLabel.Text = "1. Enter a new shipping address";
            stepOneLabel.Click += stepOneLabel_Click;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.White;
            summaryPanel.BorderStyle = BorderStyle.FixedSingle;
            summaryPanel.Controls.Add(linkLabelConditions);
            summaryPanel.Controls.Add(label2);
            summaryPanel.Controls.Add(summaryTitle);
            summaryPanel.Controls.Add(itemSummary);
            summaryPanel.Controls.Add(shippingSummary);
            summaryPanel.Controls.Add(taxSummary);
            summaryPanel.Controls.Add(totalSummary);
            summaryPanel.Location = new Point(750, 80);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(350, 271);
            summaryPanel.TabIndex = 3;
            // 
            // linkLabelConditions
            // 
            linkLabelConditions.AutoSize = true;
            linkLabelConditions.Location = new Point(10, 231);
            linkLabelConditions.Margin = new Padding(4, 0, 4, 0);
            linkLabelConditions.Name = "linkLabelConditions";
            linkLabelConditions.Size = new Size(242, 20);
            linkLabelConditions.TabIndex = 16;
            linkLabelConditions.TabStop = true;
            linkLabelConditions.Text = "How are shipping costs calculated?";
            // 
            // label2
            // 
            label2.Location = new Point(10, 119);
            label2.Name = "label2";
            label2.Size = new Size(300, 20);
            label2.TabIndex = 5;
            label2.Text = "Total before tax:                       --";
            // 
            // summaryTitle
            // 
            summaryTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            summaryTitle.Location = new Point(10, 10);
            summaryTitle.Name = "summaryTitle";
            summaryTitle.Size = new Size(225, 40);
            summaryTitle.TabIndex = 0;
            summaryTitle.Text = "Order Summary";
            // 
            // itemSummary
            // 
            itemSummary.Location = new Point(10, 50);
            itemSummary.Name = "itemSummary";
            itemSummary.Size = new Size(300, 20);
            itemSummary.TabIndex = 1;
            itemSummary.Text = "Items:                                        --";
            // 
            // shippingSummary
            // 
            shippingSummary.Location = new Point(10, 80);
            shippingSummary.Name = "shippingSummary";
            shippingSummary.Size = new Size(300, 20);
            shippingSummary.TabIndex = 2;
            shippingSummary.Text = "Shipping & handling:                  --";
            // 
            // taxSummary
            // 
            taxSummary.Location = new Point(10, 154);
            taxSummary.Name = "taxSummary";
            taxSummary.Size = new Size(300, 20);
            taxSummary.TabIndex = 3;
            taxSummary.Text = "Estimated tax to be collected: --";
            taxSummary.Click += taxSummary_Click;
            // 
            // totalSummary
            // 
            totalSummary.Font = new Font("Arial", 14F, FontStyle.Bold);
            totalSummary.ForeColor = Color.FromArgb(192, 64, 0);
            totalSummary.Location = new Point(10, 184);
            totalSummary.Name = "totalSummary";
            totalSummary.Size = new Size(300, 30);
            totalSummary.TabIndex = 4;
            totalSummary.Text = "Order total: $00.00";
            totalSummary.Click += totalSummary_Click;
            // 
            // placeOrderButton
            // 
            placeOrderButton.BackColor = Color.FromArgb(255, 216, 20);
            placeOrderButton.FlatStyle = FlatStyle.Flat;
            placeOrderButton.Location = new Point(20, 431);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(350, 40);
            placeOrderButton.TabIndex = 4;
            placeOrderButton.Text = "Use this address";
            placeOrderButton.UseVisualStyleBackColor = false;
            // 
            // footerText
            // 
            footerText.Font = new Font("Arial", 8F);
            footerText.Location = new Point(20, 619);
            footerText.Name = "footerText";
            footerText.Size = new Size(255, 20);
            footerText.TabIndex = 5;
            footerText.Text = "Need help? Check our";
            footerText.Click += footerText_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(456, 27);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 6;
            label1.Text = "CHECKOUT";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(171, 616);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Help pages";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(273, 616);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(76, 20);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "contact us";
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 8F);
            label3.Location = new Point(254, 619);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 19;
            label3.Text = "or";
            // 
            // stepTwoLabel
            // 
            stepTwoLabel.Font = new Font("Arial", 15F, FontStyle.Bold);
            stepTwoLabel.ForeColor = Color.DimGray;
            stepTwoLabel.Location = new Point(20, 496);
            stepTwoLabel.Name = "stepTwoLabel";
            stepTwoLabel.Size = new Size(431, 60);
            stepTwoLabel.TabIndex = 21;
            stepTwoLabel.Text = "2. Payment Method";
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 15F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(20, 556);
            label4.Name = "label4";
            label4.Size = new Size(431, 60);
            label4.TabIndex = 22;
            label4.Text = "3. Items and Shipping";
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 8F);
            label5.Location = new Point(20, 668);
            label5.Name = "label5";
            label5.Size = new Size(204, 20);
            label5.TabIndex = 23;
            label5.Text = "Need to add more items? go to";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(221, 665);
            linkLabel3.Margin = new Padding(4, 0, 4, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(172, 20);
            linkLabel3.TabIndex = 24;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Amazon.com homepage";
            // 
            // CheckoutForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1123, 1055);
            Controls.Add(linkLabel3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(stepTwoLabel);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(stepOneLabel);
            Controls.Add(amazonLogo);
            Controls.Add(addressPanel);
            Controls.Add(summaryPanel);
            Controls.Add(placeOrderButton);
            Controls.Add(footerText);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amazon Checkout";
            addressPanel.ResumeLayout(false);
            addressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amazonLogo).EndInit();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel addressPanel;
        private PictureBox amazonLogo;
        private Label stepOneLabel;
        private Label addressTitle;
        private Label countryLabel;
        private ComboBox countryDropdown;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Panel summaryPanel;
        private Label summaryTitle;
        private Label itemSummary;
        private Label shippingSummary;
        private Label taxSummary;
        private Label totalSummary;
        private Button placeOrderButton;
        private Label footerText;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabelConditions;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label3;
        private Label stepTwoLabel;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel3;
    }
}
