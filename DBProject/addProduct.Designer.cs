/*
namespace DBProject
{
    partial class addProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            amazonLogo = new PictureBox();
            productInfoLabel = new Label();
            weightTextBox = new TextBox();
            descriptionLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            sizesLabel = new Label();
            sizesComboBox = new ComboBox();
            nextButton = new Button();
            labelTitle = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)amazonLogo).BeginInit();
            SuspendLayout();
            // 
            // amazonLogo
            // 
            amazonLogo.BackColor = Color.LightGray;
            amazonLogo.Image = (Image)resources.GetObject("amazonLogo.Image");
            amazonLogo.Location = new Point(455, 12);
            amazonLogo.Name = "amazonLogo";
            amazonLogo.Size = new Size(174, 78);
            amazonLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            amazonLogo.TabIndex = 2;
            amazonLogo.TabStop = false;
            // 
            // productInfoLabel
            // 
            productInfoLabel.ForeColor = Color.White;
            productInfoLabel.Location = new Point(50, 135);
            productInfoLabel.Name = "productInfoLabel";
            productInfoLabel.Size = new Size(100, 23);
            productInfoLabel.TabIndex = 9;
            productInfoLabel.Text = "1. PRODUCT INFO";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(400, 188);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.PlaceholderText = "Weight";
            weightTextBox.Size = new Size(300, 27);
            weightTextBox.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(50, 246);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(155, 20);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "Description (optional)";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionRichTextBox.Location = new Point(50, 281);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(300, 100);
            descriptionRichTextBox.TabIndex = 18;
            descriptionRichTextBox.Text = "";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(400, 246);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(69, 20);
            categoryLabel.TabIndex = 19;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Items.AddRange(new object[] { "Clothing", "Women Fashion", "Men Fashion", "Baby Fashion", "Accesory" });
            categoryComboBox.Location = new Point(400, 281);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(300, 28);
            categoryComboBox.TabIndex = 20;
            // 
            // sizesLabel
            // 
            sizesLabel.AutoSize = true;
            sizesLabel.Location = new Point(400, 324);
            sizesLabel.Name = "sizesLabel";
            sizesLabel.Size = new Size(42, 20);
            sizesLabel.TabIndex = 21;
            sizesLabel.Text = "Sizes";
            // 
            // sizesComboBox
            // 
            sizesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizesComboBox.Items.AddRange(new object[] { "Small", "Medium", "Large", "Extra Large" });
            sizesComboBox.Location = new Point(400, 353);
            sizesComboBox.Name = "sizesComboBox";
            sizesComboBox.Size = new Size(300, 28);
            sizesComboBox.TabIndex = 22;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(40, 40, 40);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(874, 671);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(100, 35);
            nextButton.TabIndex = 23;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(50, 118);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(431, 40);
            labelTitle.TabIndex = 24;
            labelTitle.Text = "Product Information";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label1.Location = new Point(50, 446);
            label1.Name = "label1";
            label1.Size = new Size(181, 40);
            label1.TabIndex = 25;
            label1.Text = "Pricing";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxName.Location = new Point(50, 188);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(300, 26);
            textBoxName.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F);
            textBox1.Location = new Point(50, 510);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Price";
            textBox1.Size = new Size(155, 26);
            textBox1.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "PKR", "USD", "INR", "EUR", "CNY" });
            comboBox1.Location = new Point(250, 510);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 476);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 29;
            label2.Text = "Currency";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10F);
            textBox2.Location = new Point(609, 512);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "SKU";
            textBox2.Size = new Size(300, 26);
            textBox2.TabIndex = 30;
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 1055);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(amazonLogo);
            Controls.Add(productInfoLabel);
            Controls.Add(weightTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(sizesLabel);
            Controls.Add(sizesComboBox);
            Controls.Add(nextButton);
            Name = "addProduct";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)amazonLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox amazonLogo;
        private Label productInfoLabel;
        private TextBox weightTextBox;
        private Label descriptionLabel;
        private RichTextBox descriptionRichTextBox;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Label sizesLabel;
        private ComboBox sizesComboBox;
        private Button nextButton;
        private Label labelTitle;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
    }
}*/


namespace DBProject
{
    partial class addProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            amazonLogo = new PictureBox();
            productInfoLabel = new Label();
            weightTextBox = new TextBox();
            descriptionLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            sizesLabel = new Label();
            sizesComboBox = new ComboBox();
            nextButton = new Button();
            labelTitle = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            tagsLabel = new Label();
            tagsTextBox = new TextBox();
            tagsListBox = new ListBox();
            addTagButton = new Button();
            removeTagButton = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)amazonLogo).BeginInit();
            SuspendLayout();
            // 
            // amazonLogo
            // 
            amazonLogo.BackColor = Color.LightGray;
            amazonLogo.Image = (Image)resources.GetObject("amazonLogo.Image");
            amazonLogo.Location = new Point(455, 12);
            amazonLogo.Name = "amazonLogo";
            amazonLogo.Size = new Size(174, 78);
            amazonLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            amazonLogo.TabIndex = 2;
            amazonLogo.TabStop = false;
            // 
            // productInfoLabel
            // 
            productInfoLabel.ForeColor = Color.White;
            productInfoLabel.Location = new Point(50, 135);
            productInfoLabel.Name = "productInfoLabel";
            productInfoLabel.Size = new Size(100, 23);
            productInfoLabel.TabIndex = 9;
            productInfoLabel.Text = "1. PRODUCT INFO";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(400, 188);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.PlaceholderText = "Weight (kg)";
            weightTextBox.Size = new Size(300, 27);
            weightTextBox.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(50, 246);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(155, 20);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "Description (optional)";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionRichTextBox.Location = new Point(50, 281);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(300, 100);
            descriptionRichTextBox.TabIndex = 18;
            descriptionRichTextBox.Text = "";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(400, 246);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(69, 20);
            categoryLabel.TabIndex = 19;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Items.AddRange(new object[] { "Clothing", "Women Fashion", "Men Fashion", "Baby Fashion", "Accesory" });
            categoryComboBox.Location = new Point(400, 281);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(300, 28);
            categoryComboBox.TabIndex = 20;
            // 
            // sizesLabel
            // 
            sizesLabel.AutoSize = true;
            sizesLabel.Location = new Point(400, 324);
            sizesLabel.Name = "sizesLabel";
            sizesLabel.Size = new Size(42, 20);
            sizesLabel.TabIndex = 21;
            sizesLabel.Text = "Sizes";
            // 
            // sizesComboBox
            // 
            sizesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sizesComboBox.Items.AddRange(new object[] { "Small", "Medium", "Large", "Extra Large" });
            sizesComboBox.Location = new Point(400, 353);
            sizesComboBox.Name = "sizesComboBox";
            sizesComboBox.Size = new Size(300, 28);
            sizesComboBox.TabIndex = 22;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(40, 40, 40);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(797, 649);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(100, 35);
            nextButton.TabIndex = 23;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(50, 118);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(431, 40);
            labelTitle.TabIndex = 24;
            labelTitle.Text = "Product Information";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label1.Location = new Point(50, 446);
            label1.Name = "label1";
            label1.Size = new Size(181, 40);
            label1.TabIndex = 25;
            label1.Text = "Pricing";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxName.Location = new Point(50, 188);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(300, 26);
            textBoxName.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F);
            textBox1.Location = new Point(50, 510);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Price";
            textBox1.Size = new Size(155, 26);
            textBox1.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "PKR", "USD", "INR", "EUR", "CNY" });
            comboBox1.Location = new Point(250, 510);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 476);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 29;
            label2.Text = "Currency";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10F);
            textBox2.Location = new Point(609, 512);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "SKU";
            textBox2.Size = new Size(300, 26);
            textBox2.TabIndex = 30;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Location = new Point(50, 570);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new Size(38, 20);
            tagsLabel.TabIndex = 31;
            tagsLabel.Text = "Tags";
            // 
            // tagsTextBox
            // 
            tagsTextBox.Font = new Font("Microsoft Sans Serif", 10F);
            tagsTextBox.Location = new Point(50, 600);
            tagsTextBox.Name = "tagsTextBox";
            tagsTextBox.PlaceholderText = "Enter tag";
            tagsTextBox.Size = new Size(200, 26);
            tagsTextBox.TabIndex = 32;
            // 
            // tagsListBox
            // 
            tagsListBox.FormattingEnabled = true;
            tagsListBox.Location = new Point(300, 600);
            tagsListBox.Name = "tagsListBox";
            tagsListBox.Size = new Size(250, 84);
            tagsListBox.TabIndex = 33;
            tagsListBox.SelectedIndexChanged += tagsListBox_SelectedIndexChanged;
            // 
            // addTagButton
            // 
            addTagButton.Location = new Point(50, 640);
            addTagButton.Name = "addTagButton";
            addTagButton.Size = new Size(94, 29);
            addTagButton.TabIndex = 34;
            addTagButton.Text = "Add Tag";
            addTagButton.UseVisualStyleBackColor = true;
            // 
            // removeTagButton
            // 
            removeTagButton.Location = new Point(156, 640);
            removeTagButton.Name = "removeTagButton";
            removeTagButton.Size = new Size(94, 29);
            removeTagButton.TabIndex = 35;
            removeTagButton.Text = "Remove";
            removeTagButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 570);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 36;
            label3.Text = "Current Tags";
            // 
            // addProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 1055);
            Controls.Add(label3);
            Controls.Add(removeTagButton);
            Controls.Add(addTagButton);
            Controls.Add(tagsListBox);
            Controls.Add(tagsTextBox);
            Controls.Add(tagsLabel);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(amazonLogo);
            Controls.Add(productInfoLabel);
            Controls.Add(weightTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(sizesLabel);
            Controls.Add(sizesComboBox);
            Controls.Add(nextButton);
            Name = "addProduct";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)amazonLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox amazonLogo;
        private Label productInfoLabel;
        private TextBox weightTextBox;
        private Label descriptionLabel;
        private RichTextBox descriptionRichTextBox;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Label sizesLabel;
        private ComboBox sizesComboBox;
        private Button nextButton;
        private Label labelTitle;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
        private Label tagsLabel;
        private TextBox tagsTextBox;
        private ListBox tagsListBox;
        private Button addTagButton;
        private Button removeTagButton;
        private Label label3;
    }
}