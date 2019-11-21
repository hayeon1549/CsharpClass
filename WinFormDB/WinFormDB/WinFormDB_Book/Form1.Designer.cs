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
            this.label_book = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
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
            this.labeel_customer = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.custid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orderdate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_orders = new System.Windows.Forms.Label();
            this.saleprice = new System.Windows.Forms.TextBox();
            this.f_bookid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.f_custid = new System.Windows.Forms.TextBox();
            this.orderid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbOrders = new System.Windows.Forms.RadioButton();
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
            this.panel1.Controls.Add(this.label_book);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.publisher);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bookname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bookid);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Location = new System.Drawing.Point(28, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 174);
            this.panel1.TabIndex = 0;
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
            // price
            // 
            this.price.Location = new System.Drawing.Point(105, 139);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(165, 25);
            this.price.TabIndex = 7;
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
            this.btnSelect.Location = new System.Drawing.Point(33, 26);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(161, 62);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(227, 27);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(161, 62);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(33, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 62);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 62);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labeel_customer);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.adress);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.custid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(28, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 174);
            this.panel2.TabIndex = 8;
            // 
            // labeel_customer
            // 
            this.labeel_customer.AutoSize = true;
            this.labeel_customer.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labeel_customer.Location = new System.Drawing.Point(5, 10);
            this.labeel_customer.Name = "labeel_customer";
            this.labeel_customer.Size = new System.Drawing.Size(141, 24);
            this.labeel_customer.TabIndex = 7;
            this.labeel_customer.Text = "CUSTOMER";
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
            this.label7.Location = new System.Drawing.Point(37, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adress";
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(105, 108);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(165, 25);
            this.adress.TabIndex = 5;
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(105, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 25);
            this.textBox7.TabIndex = 3;
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
            this.panel3.Controls.Add(this.orderdate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label_orders);
            this.panel3.Controls.Add(this.saleprice);
            this.panel3.Controls.Add(this.f_bookid);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.f_custid);
            this.panel3.Controls.Add(this.orderid);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(28, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 204);
            this.panel3.TabIndex = 8;
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(105, 170);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(165, 25);
            this.orderdate.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 173);
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
            // saleprice
            // 
            this.saleprice.Location = new System.Drawing.Point(105, 139);
            this.saleprice.Name = "saleprice";
            this.saleprice.Size = new System.Drawing.Size(165, 25);
            this.saleprice.TabIndex = 7;
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
            this.panel4.Location = new System.Drawing.Point(333, 461);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 204);
            this.panel4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 343);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrders);
            this.groupBox1.Controls.Add(this.rbCustomer);
            this.groupBox1.Controls.Add(this.rbBook);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(333, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table";
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
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(146, 28);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(115, 21);
            this.rbCustomer.TabIndex = 1;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "CUSTOMER";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbOrders
            // 
            this.rbOrders.AutoSize = true;
            this.rbOrders.Location = new System.Drawing.Point(303, 28);
            this.rbOrders.Name = "rbOrders";
            this.rbOrders.Size = new System.Drawing.Size(91, 21);
            this.rbOrders.TabIndex = 2;
            this.rbOrders.TabStop = true;
            this.rbOrders.Text = "ORDERS";
            this.rbOrders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 692);
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
        private System.Windows.Forms.TextBox price;
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
        private System.Windows.Forms.Label labeel_customer;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox custid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.TextBox saleprice;
        private System.Windows.Forms.TextBox f_bookid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox f_custid;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox orderdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbOrders;
        private System.Windows.Forms.RadioButton rbCustomer;
    }
}
