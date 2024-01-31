namespace HotelManagementLayer
{
    partial class CustomerManagement
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
            txtSearch = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtCustomerID = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(221, 89);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 23);
            txtSearch.TabIndex = 46;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 92);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 45;
            label7.Text = "Search";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(635, 296);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(130, 23);
            txtAddress.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 299);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 43;
            label5.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(635, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 260);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 41;
            label6.Text = "Email";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(717, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(626, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(534, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(635, 218);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(130, 23);
            txtPhoneNumber.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 221);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 36;
            label4.Text = "PhoneNumber";
            // 
            // txtName
            // 
            txtName.Location = new Point(635, 179);
            txtName.Name = "txtName";
            txtName.Size = new Size(130, 23);
            txtName.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 182);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 34;
            label3.Text = "Name";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(635, 137);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(130, 23);
            txtCustomerID.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 140);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 32;
            label2.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(519, 322);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 11);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 30;
            label1.Text = "Customer Management";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtCustomerID);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            Load += CustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label7;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtCustomerID;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}