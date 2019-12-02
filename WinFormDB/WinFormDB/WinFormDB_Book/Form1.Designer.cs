namespace WinFormDB_Book
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.TextBox();
            this.label_book = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_customer = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.TextBox();
            this.saleprice2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.saleprice1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_orders = new System.Windows.Forms.Label();
            this.f_bookid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.f_custid = new System.Windows.Forms.TextBox();
            this.orderid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrders = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price2);
            this.panel1.Controls.Add(this.label_book);
            this.panel1.Controls.Add(this.price1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.publisher);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bookname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bookid);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Location = new System.Drawing.Point(28, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 189);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(91, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "Insert / Update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "<=";
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(203, 139);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(67, 25);
            this.price2.TabIndex = 8;
            // 
            // label_book
            // 
            this.label_book.AutoSize = true;
            this.label_book.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_book.Location = new System.Drawing.Point(5, 10);
            this.label_book.Name = "label_book";
            this.label_book.Size = new System.Drawing.Size(76, 24);
            this.label_book.TabIndex = 7;
            this.label_book.Text = "BOOK";
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(105, 139);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(67, 25);
            this.price1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Publisher";
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(105, 108);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(165, 25);
            this.publisher.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(105, 77);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(165, 25);
            this.bookname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name";
            // 
            // bookid
            // 
            this.bookid.Location = new System.Drawing.Point(105, 46);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(165, 25);
            this.bookid.TabIndex = 1;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(29, 49);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(60, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Book ID";
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(0, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 46);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(128, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(122, 46);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(256, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 46);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(384, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 46);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_customer);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.custid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(28, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 174);
            this.panel2.TabIndex = 8;
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_customer.Location = new System.Drawing.Point(5, 10);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(141, 24);
            this.label_customer.TabIndex = 7;
            this.label_customer.Text = "CUSTOMER";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(105, 139);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(165, 25);
            this.phone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(105, 108);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(165, 25);
            this.address.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phone";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(105, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 25);
            this.name.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // custid
            // 
            this.custid.Location = new System.Drawing.Point(105, 46);
            this.custid.Name = "custid";
            this.custid.Size = new System.Drawing.Size(165, 25);
            this.custid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cust ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.orderdate);
            this.panel3.Controls.Add(this.saleprice2);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.saleprice1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label_orders);
            this.panel3.Controls.Add(this.f_bookid);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.f_custid);
            this.panel3.Controls.Add(this.orderid);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(28, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 221);
            this.panel3.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(173, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "<=";
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(105, 189);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(165, 25);
            this.orderdate.TabIndex = 12;
            // 
            // saleprice2
            // 
            this.saleprice2.Location = new System.Drawing.Point(203, 139);
            this.saleprice2.Name = "saleprice2";
            this.saleprice2.Size = new System.Drawing.Size(67, 25);
            this.saleprice2.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(91, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Insert / Update";
            // 
            // saleprice1
            // 
            this.saleprice1.Location = new System.Drawing.Point(105, 139);
            this.saleprice1.Name = "saleprice1";
            this.saleprice1.Size = new System.Drawing.Size(67, 25);
            this.saleprice1.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Order Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Order ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cust ID";
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_orders.Location = new System.Drawing.Point(5, 10);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(107, 24);
            this.label_orders.TabIndex = 7;
            this.label_orders.Text = "ORDERS";
            // 
            // f_bookid
            // 
            this.f_bookid.Location = new System.Drawing.Point(105, 108);
            this.f_bookid.Name = "f_bookid";
            this.f_bookid.Size = new System.Drawing.Size(165, 25);
            this.f_bookid.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sale Price";
            // 
            // f_custid
            // 
            this.f_custid.Location = new System.Drawing.Point(105, 77);
            this.f_custid.Name = "f_custid";
            this.f_custid.Size = new System.Drawing.Size(165, 25);
            this.f_custid.TabIndex = 3;
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(105, 46);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(165, 25);
            this.orderid.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Book ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnInsert);
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Location = new System.Drawing.Point(321, 604);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 61);
            this.panel4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(481, 455);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrders);
            this.groupBox1.Controls.Add(this.rbCustomer);
            this.groupBox1.Controls.Add(this.rbBook);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(333, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 64);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
            // 
            // rbOrders
            // 
            this.rbOrders.AutoSize = true;
            this.rbOrders.Location = new System.Drawing.Point(253, 28);
            this.rbOrders.Name = "rbOrders";
            this.rbOrders.Size = new System.Drawing.Size(91, 21);
            this.rbOrders.TabIndex = 2;
            this.rbOrders.TabStop = true;
            this.rbOrders.Text = "ORDERS";
            this.rbOrders.UseVisualStyleBackColor = true;
            this.rbOrders.CheckedChanged += new System.EventHandler(this.rbOrders_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(123, 28);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(115, 21);
            this.rbCustomer.TabIndex = 1;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "CUSTOMER";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Location = new System.Drawing.Point(33, 28);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(73, 21);
            this.rbBook.TabIndex = 0;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "BOOK";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(692, 37);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(122, 46);
            this.clear.TabIndex = 5;
            this.clear.Text = "TextBox Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 692);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label_book;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.TextBox f_bookid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox f_custid;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbOrders;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox orderdate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox saleprice2;
        private System.Windows.Forms.TextBox saleprice1;
    }
}
