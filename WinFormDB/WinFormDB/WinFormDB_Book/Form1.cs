using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormDB_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataSet dataSet;
        string tableName;
        int selectedRowIndex;

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=mydb;uid=root;pwd=1010";
            conn = new MySqlConnection(connStr);
            dataSet = new DataSet(); // 메모리상의 가상 DataTable 관리

            book_enabled();
            customer_enabled();
            orders_enabled();
        }

        #region RadioButton에 따라 DB 연결 및 DataGridView 데이터 불러오기
        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            tableName = "book";
            adapterFunc(tableName);

            panel1.BackColor = Color.LightYellow;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;

            label_book.ForeColor = Color.Green;
            label_customer.ForeColor = Color.Black;
            label_orders.ForeColor = Color.Black;

            textboxClear();

            bookid.Enabled = true;
            bookname.Enabled = true;
            publisher.Enabled = true;
            price1.Enabled = true;
            price2.Enabled = true;

            customer_enabled();
            orders_enabled();
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            tableName = "customer";
            adapterFunc(tableName);

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.LightYellow;
            panel3.BackColor = Color.White;

            label_book.ForeColor = Color.Black;
            label_customer.ForeColor = Color.Green;
            label_orders.ForeColor = Color.Black;

            textboxClear();

            custid.Enabled = true;
            name.Enabled = true;
            address.Enabled = true;
            phone.Enabled = true;

            book_enabled();
            orders_enabled();
        }

        private void rbOrders_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            tableName = "orders";
            adapterFunc(tableName);

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.LightYellow;

            label_book.ForeColor = Color.Black;
            label_customer.ForeColor = Color.Black;
            label_orders.ForeColor = Color.Green;

            textboxClear();
            
            orderid.Enabled = true;
            f_custid.Enabled = true;
            f_bookid.Enabled = true;
            saleprice1.Enabled = true;
            saleprice2.Enabled = true;
            orderdate.Enabled = true;

            book_enabled();
            customer_enabled();
        }

        private void textboxClear()
        {
            //book
            bookid.Clear();
            bookname.Clear();
            publisher.Clear();
            price1.Clear();
            price2.Clear();
            //customer
            custid.Clear();
            name.Clear();
            address.Clear();
            phone.Clear();
            //orders
            orderid.Clear();
            f_custid.Clear();
            f_bookid.Clear();
            saleprice1.Clear();
            saleprice2.Clear();
            orderdate.Clear();
        }

        private void book_enabled()
        {
            bookid.Enabled = false;
            bookname.Enabled = false;
            publisher.Enabled = false;
            price1.Enabled = false;
            price2.Enabled = false;
        }

        private void customer_enabled()
        {
            custid.Enabled = false;
            name.Enabled = false;
            address.Enabled = false;
            phone.Enabled = false;
        }

        private void orders_enabled()
        {
            orderid.Enabled = false;
            f_custid.Enabled = false;
            f_bookid.Enabled = false;
            saleprice1.Enabled = false;
            saleprice2.Enabled = false;
            orderdate.Enabled = false;
        }

        private void adapterFunc(string tableName)
        {
            dataSet.Clear();
            adapter = new MySqlDataAdapter($"SELECT * FROM {tableName}", conn);  // DataSet과 DB 연결(명령 수행)
            adapter.Fill(dataSet, tableName);
            dataGridView1.DataSource = dataSet.Tables[tableName];
        }
        #endregion

        #region Select
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (tableName == "book")
                book_select();
            else if (tableName == "customer")
                customer_select();
            else
                orders_select();

            try
            {
                conn.Open();
                dataSet.Clear();
                if (adapter.Fill(dataSet, tableName) > 0)
                    dataGridView1.DataSource = dataSet.Tables[tableName];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void book_select()
        {
            #region select문 만들기
            string queryStr="";

            string[] conditions = new string[4];
            conditions[0] = (bookid.Text != "") ? "bookid=@bookid" : null;
            conditions[1] = (bookname.Text != "") ? "bookname=@bookname" : null;
            conditions[2] = (publisher.Text != "") ? "publisher=@publisher" : null;

            //price
            string condition_population = "";
            if (price1.Text != "" && price2.Text != "")
            {
                condition_population = "price>=@price1 and price<=@price2";
            }
            else if (price1.Text != "" || price2.Text != "")
            {
                if (price1.Text != "")
                    condition_population = "price>=@price1";
                else
                    condition_population = "price <= @price2";
            }
            else
            {
                condition_population = null;
            }
            conditions[3] = condition_population;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = queryFunc(conditions);
            }
            else
            {
                queryStr = $"SELECT * FROM {tableName}";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            adapter.SelectCommand = new MySqlCommand(queryStr, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@bookid", bookid.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@bookname", bookname.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@publisher", publisher.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@price1", price1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@price2", price2.Text);
            #endregion
        }

        private void customer_select()
        {
            #region select문 만들기
            string queryStr = "";

            string[] conditions = new string[4];
            conditions[0] = (custid.Text != "") ? "custid=@custid" : null;
            conditions[1] = (name.Text != "") ? "name=@name" : null;
            conditions[2] = (address.Text != "") ? "address=@address" : null;
            conditions[3] = (phone.Text != "") ? "phone=@phone" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = queryFunc(conditions);
            }
            else
            {
                queryStr = $"SELECT * FROM {tableName}";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            adapter.SelectCommand = new MySqlCommand(queryStr, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@custid", custid.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@name", name.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@address", address.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@phone", phone.Text);
            #endregion
        }

        private void orders_select()
        {
            #region select문 만들기
            string queryStr = "";

            string[] conditions = new string[5];
            conditions[0] = (orderid.Text != "") ? "orderid=@orderid" : null;
            conditions[1] = (f_custid.Text != "") ? "custid=@custid" : null;
            conditions[2] = (f_bookid.Text != "") ? "bookid=@bookid" : null;

            //saleprice
            string condition_population = "";
            if (saleprice1.Text != "" && saleprice2.Text != "")
            {
                condition_population = "saleprice>=@saleprice1 and saleprice<=@saleprice2";
            }
            else if (saleprice1.Text != "" || saleprice2.Text != "")
            {
                if (saleprice1.Text != "")
                    condition_population = "saleprice>=@saleprice1";
                else
                    condition_population = "saleprice <= @saleprice2";
            }
            else
            {
                condition_population = null;
            }

            conditions[3] = condition_population;

            conditions[4] = (orderdate.Text != "") ? "orderdate=@orderdate" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = queryFunc(conditions);
            }
            else
            {
                queryStr = $"SELECT * FROM {tableName}";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            adapter.SelectCommand = new MySqlCommand(queryStr, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@orderid", orderid.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@custid", f_custid.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@bookid", f_bookid.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@saleprice1", saleprice1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@saleprice2", saleprice2.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@orderdate", orderdate.Text);
            #endregion
        }

        private string queryFunc(string[] conditions)
        {
            string queryStr;

            queryStr = $"SELECT * FROM {tableName} WHERE ";
            bool firstCondition = true;
            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i] != null)
                    if (firstCondition)
                    {
                        queryStr += conditions[i];
                        firstCondition = false;
                    }
                    else
                    {
                        queryStr += " and " + conditions[i];
                    }
            }

            return queryStr;
        }
        #endregion

        #region Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableName == "book")
                    book_insert();
                else if (tableName == "customer")
                    customer_insert();
                else
                    orders_insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.Open();
                adapter.Update(dataSet, tableName); // 메모리 -> DB에 반영
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }   

        private void book_insert()
        {
            string sql = $"INSERT INTO {tableName}(bookid, bookname, publisher, price) VALUES (@bookid, @bookname, @publisher, @price)";

            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@bookid", bookid.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@bookname", bookname.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@publisher", publisher.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@price", price1.Text);

            // 메모리에서 새로운 행(row)를 만들고, 테이블에 추가
            DataRow newRow = dataSet.Tables[tableName].NewRow();
            newRow["bookid"] = bookid.Text;
            newRow["bookname"] = bookname.Text;
            newRow["publisher"] = publisher.Text;
            newRow["price"] = price1.Text;
            dataSet.Tables[tableName].Rows.Add(newRow);
        }

        private void customer_insert()
        {
            string sql = $"INSERT INTO {tableName}(custid, name, address, phone) VALUES (@custid, @name, @address, @phone)";

            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@custid", custid.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@name", name.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@address", address.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@phone", phone.Text);

            // 메모리에서 새로운 행(row)를 만들고, 테이블에 추가
            DataRow newRow = dataSet.Tables[tableName].NewRow();
            newRow["custid"] = custid.Text;
            newRow["name"] = name.Text;
            newRow["address"] = address.Text;
            newRow["phone"] = phone.Text;
            dataSet.Tables[tableName].Rows.Add(newRow);
        }

        private void orders_insert()
        {
            string sql = $"INSERT INTO {tableName}(orderid, custid, bookid, saleprice, orderdate) VALUES (@orderid, @custid, @bookid, @saleprice, @orderdate)";

            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@orderid", orderid.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@custid", f_custid.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@bookid", f_bookid.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@saleprice", saleprice1.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@orderdate", orderdate.Text);

            // 메모리에서 새로운 행(row)를 만들고, 테이블에 추가
            DataRow newRow = dataSet.Tables[tableName].NewRow();
            newRow["orderid"] = orderid.Text;
            newRow["custid"] = f_custid.Text;
            newRow["bookid"] = f_bookid.Text;
            newRow["saleprice"] = saleprice1.Text;
            newRow["orderdate"] = orderdate.Text;
            dataSet.Tables[tableName].Rows.Add(newRow);
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tableName == "book")
            {
                string sql = $"UPDATE {tableName} SET bookid=@bookid, bookname=@bookname, publisher=@publisher, price=@price WHERE bookid=@bookid";
                adapter.UpdateCommand = new MySqlCommand(sql, conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@bookid", bookid.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@bookname", bookname.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@publisher", publisher.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@price", price1.Text);
            }
            else if (tableName == "customer")
            {
                string sql = $"UPDATE {tableName} SET custid=@custid, name=@name, address=@address, phone=@phone WHERE custid=@custid";
                adapter.UpdateCommand = new MySqlCommand(sql, conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@custid", custid.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@name", name.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@address", address.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@phone", phone.Text);
            }
            else
            {
                string sql = $"UPDATE {tableName} SET orderid=@orderid, custid=@custid, bookid=@bookid, saleprice=@saleprice, orderdate=@orderdate WHERE orderid=@orderid";
                adapter.UpdateCommand = new MySqlCommand(sql, conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@orderid", orderid.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@custid", f_custid.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@bookid", f_bookid.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@saleprice", saleprice1.Text);
                adapter.UpdateCommand.Parameters.AddWithValue("@orderdate", orderdate.Text);
            }

            try
            {
                conn.Open();
                adapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear(); 
                adapter.Fill(dataSet, tableName);
                dataGridView1.DataSource = dataSet.Tables[tableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM {tableName} WHERE";

            if (tableName == "book")
            {
                sql += " bookid=@bookid";
                adapter.DeleteCommand = new MySqlCommand(sql, conn);
                adapter.DeleteCommand.Parameters.AddWithValue("@bookid", bookid.Text);
            }
            else if (tableName == "customer")
            {
                sql += " custid=@custid";
                adapter.DeleteCommand = new MySqlCommand(sql, conn);
                adapter.DeleteCommand.Parameters.AddWithValue("@custid", custid.Text);
            }  
            else
            {
                sql += " orderid=@orderid";
                adapter.DeleteCommand = new MySqlCommand(sql, conn);
                adapter.DeleteCommand.Parameters.AddWithValue("@orderid", orderid.Text);
            }

            try
            {
                conn.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
                dataSet.Clear();

                if (adapter.Fill(dataSet, tableName) > 0)
                    dataGridView1.DataSource = dataSet.Tables[tableName];
                else
                    MessageBox.Show("삭제할 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            if (tableName == "book")
            {
                bookid.Text = row.Cells[0].Value.ToString();
                bookname.Text = row.Cells[1].Value.ToString();
                publisher.Text = row.Cells[2].Value.ToString();
                price1.Text = row.Cells[3].Value.ToString();
                price2.Clear();
            }
            else if (tableName == "customer")
            {
                custid.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                address.Text = row.Cells[2].Value.ToString();
                phone.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                orderid.Text = row.Cells[0].Value.ToString();
                f_custid.Text = row.Cells[1].Value.ToString();
                f_bookid.Text = row.Cells[2].Value.ToString();
                saleprice1.Text = row.Cells[3].Value.ToString();
                saleprice2.Clear();
                orderdate.Text = row.Cells[4].Value.ToString().Substring(0, 10);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textboxClear();
        }
    }
}