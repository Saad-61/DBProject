using System;
using System.Windows.Forms;

namespace DBProject
{
     partial class AdminForm : Form
    {
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnProductsPage;
        private System.Windows.Forms.Button btnOrdersList;
        private System.Windows.Forms.Button btnOrdersDetails;
        private System.Windows.Forms.Button btnInventoryPage;
        private System.Windows.Forms.Button btnLogistics;

        private PictureBox amazonLogo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label adminNameLabel;
        private Label countryLabel;
        private FlowLayoutPanel sidebar;
        private FlowLayoutPanel rightSidebar;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            amazonLogo = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            adminNameLabel = new Label();
            countryLabel = new Label();
            sidebar = new FlowLayoutPanel();
            btnNewProduct = new Button();
            btnEditProduct = new Button();
            btnProductsPage = new Button();
            btnOrdersList = new Button();
            btnOrdersDetails = new Button();
            btnInventoryPage = new Button();
            btnLogistics = new Button();
            rightSidebar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)amazonLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // amazonLogo
            // 
            amazonLogo.BackColor = Color.LightGray;
            amazonLogo.Image = (Image)resources.GetObject("amazonLogo.Image");
            amazonLogo.Location = new Point(946, 3);
            amazonLogo.Name = "amazonLogo";
            amazonLogo.Size = new Size(174, 78);
            amazonLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            amazonLogo.TabIndex = 1;
            amazonLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(adminNameLabel);
            panel1.Controls.Add(countryLabel);
            panel1.Controls.Add(amazonLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 85);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // adminNameLabel
            // 
            adminNameLabel.Font = new Font("Segoe UI", 12F);
            adminNameLabel.ForeColor = Color.DimGray;
            adminNameLabel.Location = new Point(500, 25);
            adminNameLabel.Name = "adminNameLabel";
            adminNameLabel.Size = new Size(268, 35);
            adminNameLabel.TabIndex = 4;
            adminNameLabel.Text = "Welcome, Admin Name";
            adminNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // countryLabel
            // 
            countryLabel.Font = new Font("Segoe UI", 25F);
            countryLabel.Location = new Point(95, 12);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(268, 63);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Admin Page";
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(btnNewProduct);
            sidebar.Controls.Add(btnEditProduct);
            sidebar.Controls.Add(btnProductsPage);
            sidebar.Controls.Add(btnOrdersList);
            sidebar.Controls.Add(btnOrdersDetails);
            sidebar.Controls.Add(btnInventoryPage);
            sidebar.Controls.Add(btnLogistics);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 85);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(258, 970);
            sidebar.TabIndex = 3;
            // 
            // btnNewProduct
            // 
            btnNewProduct.BackColor = Color.White;
            btnNewProduct.Font = new Font("Segoe UI", 12F);
            btnNewProduct.Location = new Point(3, 3);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(250, 50);
            btnNewProduct.TabIndex = 0;
            btnNewProduct.Text = "New Product";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += BtnNewProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.White;
            btnEditProduct.Font = new Font("Segoe UI", 12F);
            btnEditProduct.Location = new Point(3, 59);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(250, 50);
            btnEditProduct.TabIndex = 1;
            btnEditProduct.Text = "Edit Product";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += BtnEditProduct_Click;
            // 
            // btnProductsPage
            // 
            btnProductsPage.BackColor = Color.White;
            btnProductsPage.Font = new Font("Segoe UI", 12F);
            btnProductsPage.Location = new Point(3, 115);
            btnProductsPage.Name = "btnProductsPage";
            btnProductsPage.Size = new Size(250, 50);
            btnProductsPage.TabIndex = 2;
            btnProductsPage.Text = "Products Page";
            btnProductsPage.UseVisualStyleBackColor = false;
            btnProductsPage.Click += BtnProductsPage_Click;
            // 
            // btnOrdersList
            // 
            btnOrdersList.BackColor = Color.White;
            btnOrdersList.Font = new Font("Segoe UI", 12F);
            btnOrdersList.Location = new Point(3, 171);
            btnOrdersList.Name = "btnOrdersList";
            btnOrdersList.Size = new Size(250, 50);
            btnOrdersList.TabIndex = 3;
            btnOrdersList.Text = "Orders List";
            btnOrdersList.UseVisualStyleBackColor = false;
            btnOrdersList.Click += BtnOrdersList_Click;
            // 
            // btnOrdersDetails
            // 
            btnOrdersDetails.BackColor = Color.White;
            btnOrdersDetails.Font = new Font("Segoe UI", 12F);
            btnOrdersDetails.Location = new Point(3, 227);
            btnOrdersDetails.Name = "btnOrdersDetails";
            btnOrdersDetails.Size = new Size(250, 50);
            btnOrdersDetails.TabIndex = 4;
            btnOrdersDetails.Text = "Orders Details";
            btnOrdersDetails.UseVisualStyleBackColor = false;
            btnOrdersDetails.Click += BtnOrdersDetails_Click;
            // 
            // btnInventoryPage
            // 
            btnInventoryPage.BackColor = Color.White;
            btnInventoryPage.Font = new Font("Segoe UI", 12F);
            btnInventoryPage.Location = new Point(3, 283);
            btnInventoryPage.Name = "btnInventoryPage";
            btnInventoryPage.Size = new Size(250, 50);
            btnInventoryPage.TabIndex = 5;
            btnInventoryPage.Text = "Inventory Page";
            btnInventoryPage.UseVisualStyleBackColor = false;
            btnInventoryPage.Click += BtnInventoryPage_Click;
            // 
            // btnLogistics
            // 
            btnLogistics.BackColor = Color.White;
            btnLogistics.Font = new Font("Segoe UI", 12F);
            btnLogistics.Location = new Point(3, 339);
            btnLogistics.Name = "btnLogistics";
            btnLogistics.Size = new Size(250, 50);
            btnLogistics.TabIndex = 6;
            btnLogistics.Text = "Logistics";
            btnLogistics.UseVisualStyleBackColor = false;
            btnLogistics.Click += BtnLogistics_Click;
            // 
            // rightSidebar
            // 
            rightSidebar.BackColor = Color.White;
            rightSidebar.Dock = DockStyle.Fill;
            rightSidebar.Location = new Point(258, 85);
            rightSidebar.Name = "rightSidebar";
            rightSidebar.Size = new Size(865, 970);
            rightSidebar.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 1055);
            Controls.Add(rightSidebar);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)amazonLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Button Click Event Handlers
        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            // Handle New Product
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            // Handle Edit Product
        }

        private void BtnProductsPage_Click(object sender, EventArgs e)
        {
            // Handle Products Page
        }

        private void BtnOrdersList_Click(object sender, EventArgs e)
        {
            // Handle Orders List
        }

        private void BtnOrdersDetails_Click(object sender, EventArgs e)
        {
            // Handle Orders Details
        }

        private void BtnInventoryPage_Click(object sender, EventArgs e)
        {
            // Handle Inventory Page
        }

        private void BtnLogistics_Click(object sender, EventArgs e)
        {
            // Handle Logistics
        }
    }
}
