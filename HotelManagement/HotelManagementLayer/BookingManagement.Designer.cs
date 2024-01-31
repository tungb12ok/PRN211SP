namespace HotelManagementLayer
{
    partial class BookingManagement
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvCus = new DataGridView();
            dgvRooms = new DataGridView();
            dgvBooking = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtRoomID = new TextBox();
            label7 = new Label();
            txtCustomerID = new TextBox();
            label8 = new Label();
            txtBookingID = new TextBox();
            label9 = new Label();
            dateIn = new DateTimePicker();
            dateOut = new DateTimePicker();
            label10 = new Label();
            numPrice = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // dgvCus
            // 
            dgvCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCus.Location = new Point(24, 107);
            dgvCus.Name = "dgvCus";
            dgvCus.RowTemplate.Height = 25;
            dgvCus.Size = new Size(178, 536);
            dgvCus.TabIndex = 0;
            dgvCus.CellClick += dgvCus_CellClick;
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(225, 107);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowTemplate.Height = 25;
            dgvRooms.Size = new Size(445, 134);
            dgvRooms.TabIndex = 1;
            dgvRooms.CellClick += dgvRooms_CellClick;
            // 
            // dgvBooking
            // 
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(225, 297);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.RowTemplate.Height = 25;
            dgvBooking.Size = new Size(445, 346);
            dgvBooking.TabIndex = 2;
            dgvBooking.CellClick += dgvBooking_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(386, 9);
            label4.Name = "label4";
            label4.Size = new Size(211, 25);
            label4.TabIndex = 9;
            label4.Text = "Booking Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(730, 272);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 56;
            label5.Text = "CheckOutDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(730, 233);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 54;
            label6.Text = "CheckInDate";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(903, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(812, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(720, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 51;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtRoomID
            // 
            txtRoomID.Enabled = false;
            txtRoomID.Location = new Point(821, 188);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(130, 23);
            txtRoomID.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(730, 191);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 49;
            label7.Text = "RoomID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(821, 149);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(130, 23);
            txtCustomerID.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(730, 152);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 47;
            label8.Text = "CustomerID";
            // 
            // txtBookingID
            // 
            txtBookingID.Enabled = false;
            txtBookingID.Location = new Point(821, 107);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(130, 23);
            txtBookingID.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(730, 110);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 45;
            label9.Text = "BookingID";
            // 
            // dateIn
            // 
            dateIn.Location = new Point(821, 233);
            dateIn.Name = "dateIn";
            dateIn.Size = new Size(200, 23);
            dateIn.TabIndex = 57;
            // 
            // dateOut
            // 
            dateOut.Location = new Point(823, 268);
            dateOut.Name = "dateOut";
            dateOut.Size = new Size(200, 23);
            dateOut.TabIndex = 58;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(732, 312);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 59;
            label10.Text = "TotalPrice";
            // 
            // numPrice
            // 
            numPrice.Hexadecimal = true;
            numPrice.Location = new Point(821, 310);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(130, 23);
            numPrice.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 268);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Search Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 79);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 6;
            label2.Text = "Search Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 79);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Search Customer";
            // 
            // BookingManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 680);
            Controls.Add(numPrice);
            Controls.Add(label10);
            Controls.Add(dateOut);
            Controls.Add(dateIn);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtRoomID);
            Controls.Add(label7);
            Controls.Add(txtCustomerID);
            Controls.Add(label8);
            Controls.Add(txtBookingID);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBooking);
            Controls.Add(dgvRooms);
            Controls.Add(dgvCus);
            Name = "BookingManagement";
            Text = "BookingManagement";
            Load += BookingManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvCus;
        private DataGridView dgvRooms;
        private DataGridView dgvBooking;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtRoomID;
        private Label label7;
        private TextBox txtCustomerID;
        private Label label8;
        private TextBox txtBookingID;
        private Label label9;
        private DateTimePicker dateIn;
        private DateTimePicker dateOut;
        private Label label10;
        private NumericUpDown numPrice;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}