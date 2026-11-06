namespace Tests
{
    partial class Lucky_Cafe_Order
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
            btnCalculate = new Button();
            lbltotal = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbJuice = new RadioButton();
            rbCoffee = new RadioButton();
            rbTea = new RadioButton();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            lblMessegeLucky = new Label();
            checkStudent = new CheckBox();
            orderList = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            orderList.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightGray;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculate.Location = new Point(99, 457);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(188, 50);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate Order";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lbltotal
            // 
            lbltotal.BackColor = SystemColors.Control;
            lbltotal.BorderStyle = BorderStyle.FixedSingle;
            lbltotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(72, 533);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(1036, 40);
            lbltotal.TabIndex = 10;
            lbltotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGray;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(342, 457);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 50);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save to File";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightGray;
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoad.Location = new Point(593, 457);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(188, 50);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load from File";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(845, 457);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 50);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 14;
            label1.Text = "Lacky Cafe Order";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(39, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(562, 318);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbJuice);
            groupBox2.Controls.Add(rbCoffee);
            groupBox2.Controls.Add(rbTea);
            groupBox2.ForeColor = Color.RoyalBlue;
            groupBox2.Location = new Point(33, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(513, 150);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Drink Type";
            // 
            // rbJuice
            // 
            rbJuice.AutoSize = true;
            rbJuice.Font = new Font("Segoe UI", 10F);
            rbJuice.ForeColor = Color.Black;
            rbJuice.Location = new Point(20, 108);
            rbJuice.Name = "rbJuice";
            rbJuice.Size = new Size(118, 32);
            rbJuice.TabIndex = 20;
            rbJuice.TabStop = true;
            rbJuice.Text = "Juice ($3)";
            rbJuice.UseVisualStyleBackColor = true;
            // 
            // rbCoffee
            // 
            rbCoffee.AutoSize = true;
            rbCoffee.Font = new Font("Segoe UI", 10F);
            rbCoffee.ForeColor = Color.Black;
            rbCoffee.Location = new Point(20, 73);
            rbCoffee.Name = "rbCoffee";
            rbCoffee.Size = new Size(132, 32);
            rbCoffee.TabIndex = 19;
            rbCoffee.TabStop = true;
            rbCoffee.Text = "Coffee ($2)";
            rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbTea
            // 
            rbTea.AutoSize = true;
            rbTea.Font = new Font("Segoe UI", 10F);
            rbTea.ForeColor = Color.Black;
            rbTea.Location = new Point(20, 38);
            rbTea.Name = "rbTea";
            rbTea.Size = new Size(104, 32);
            rbTea.TabIndex = 18;
            rbTea.TabStop = true;
            rbTea.Text = "Tea ($1)";
            rbTea.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(33, 88);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(513, 34);
            txtCustomerName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 46);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 0;
            label2.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 386);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 1;
            label3.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(148, 383);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(117, 42);
            txtQuantity.TabIndex = 17;
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMessegeLucky
            // 
            lblMessegeLucky.BackColor = SystemColors.Control;
            lblMessegeLucky.BorderStyle = BorderStyle.FixedSingle;
            lblMessegeLucky.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessegeLucky.Location = new Point(72, 582);
            lblMessegeLucky.Name = "lblMessegeLucky";
            lblMessegeLucky.Size = new Size(1036, 34);
            lblMessegeLucky.TabIndex = 18;
            lblMessegeLucky.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkStudent
            // 
            checkStudent.AutoSize = true;
            checkStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkStudent.Location = new Point(352, 386);
            checkStudent.Name = "checkStudent";
            checkStudent.Size = new Size(267, 29);
            checkStudent.TabIndex = 19;
            checkStudent.Text = "Student Member (10% off)";
            checkStudent.UseVisualStyleBackColor = true;
            // 
            // orderList
            // 
            orderList.BackColor = SystemColors.GradientInactiveCaption;
            orderList.Controls.Add(listBox1);
            orderList.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderList.ForeColor = Color.RoyalBlue;
            orderList.Location = new Point(632, 97);
            orderList.Name = "orderList";
            orderList.Size = new Size(499, 277);
            orderList.TabIndex = 20;
            orderList.TabStop = false;
            orderList.Text = "Order List";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 228);
            listBox1.TabIndex = 0;
            // 
            // Lucky_Cafe_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 625);
            Controls.Add(orderList);
            Controls.Add(checkStudent);
            Controls.Add(lblMessegeLucky);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lbltotal);
            Controls.Add(btnCalculate);
            Name = "Lucky_Cafe_Order";
            Text = "Lucky_Cafe_Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            orderList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalculate;
        private Label lbltotal;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClear;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerName;
        private TextBox txtQuantity;
        private RadioButton rbTea;
        private RadioButton rbCoffee;
        private RadioButton rbJuice;
        private GroupBox groupBox2;
        private Label lblMessegeLucky;
        private CheckBox checkStudent;
        private GroupBox orderList;
        private ListBox listBox1;
    }
}