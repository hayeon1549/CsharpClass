using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=mydb;uid=root;pwd=1010";
            conn = new MySqlConnection(connStr);
            dataSet = new DataSet(); // 메모리상의 가상 DataTable 관리
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            istable();
            string sql = $"SELECT * FROM {tableName}";
            adapter.SelectCommand = new MySqlCommand(sql, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@bookid", bookid.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@bookname", bookname.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@publisher", publisher.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@price", price.Text);

            //try
            //{
            //    conn.Open();
            //    // select 결과를 dataSet에 "city"라는 이름의 테이블로 만들어라.
            //    if (adapter.Fill(dataSet, tableName) > 0)  // 검색된 데이터의 행숫자 반환
            //        dataGridView1.DataSource = dataSet.Tables["city"];
            //    else
            //        MessageBox.Show("검색된 데이터가 없습니다.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //string sql = "INSERT INTO city (name, countrycode, district, population) " +
            //    "VALUES(@name, @countrycode, @district, @population)";

            //adapter.InsertCommand = new MySqlCommand(sql, conn);
            //adapter.InsertCommand.Parameters.AddWithValue("@name", textBox2.Text);
            //adapter.InsertCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);
            //adapter.InsertCommand.Parameters.AddWithValue("@district", textBox4.Text);
            //adapter.InsertCommand.Parameters.AddWithValue("@population", textBox5.Text);

            //#region DataSet을 먼저 수정하고, DB로 Update()처리
            //// 메모리에서 새로운 행(row)를 만들고, 테이블에 추가
            //DataRow newRow = dataSet.Tables["city"].NewRow();
            //newRow["name"] = textBox2.Text;
            //newRow["countrycode"] = textBox3.Text;
            //newRow["district"] = textBox4.Text;
            //newRow["population"] = textBox5.Text;
            //dataSet.Tables["city"].Rows.Add(newRow);

            //try
            //{
            //    conn.Open();
            //    adapter.Update(dataSet, "city"); // 메모리 -> DB에 반영
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            //#endregion
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string sql = "UPDATE city SET district=@district WHERE countrycode=@countrycode";
            //adapter.UpdateCommand = new MySqlCommand(sql, conn);
            //adapter.UpdateCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);
            //adapter.UpdateCommand.Parameters.AddWithValue("@district", textBox4.Text);

            //#region Update()를 이용한 처리
            //int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            //string filter = "id=" + id;
            //DataRow[] findRows = dataSet.Tables["city"].Select(filter);
            //findRows[0]["id"] = id;
            //findRows[0]["name"] = textBox2.Text;
            //findRows[0]["countrycode"] = textBox3.Text;
            //findRows[0]["district"] = textBox4.Text;
            //findRows[0]["population"] = textBox5.Text;

            //try
            //{
            //    conn.Open();
            //    adapter.Update(dataSet, "city");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Open();
            //}
            //#endregion
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string sql = "DELETE FROM city WHERE id=@id";

            //adapter.DeleteCommand = new MySqlCommand(sql, conn);
            //int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            //adapter.DeleteCommand.Parameters.AddWithValue("@id", id);

            //try
            //{
            //    conn.Open();
            //    if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
            //    {
            //        dataSet.Clear();
            //        adapter.Fill(dataSet, "city");
            //        dataGridView1.DataSource = dataSet.Tables["city"];
            //    }
            //    else
            //    {
            //        MessageBox.Show("삭제된 데이터가 없습니다.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void istable()
        {
            if (rbBook.Checked)
                tableName = "book";
            else if (rbCustomer.Checked)
                tableName = "customer";
            else
                tableName = "orders";
        }
    }
}
