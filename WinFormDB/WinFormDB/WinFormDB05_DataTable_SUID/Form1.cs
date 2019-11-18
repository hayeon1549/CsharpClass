using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB05_DataTable_SUID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable("dataTable"); // 메모리 상의 데이터 테이블
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1단계 : 테이블과 컬럼 만들기
            
            DataColumn col;

            col = new DataColumn("name", typeof(string));
            col.MaxLength = 10;
            col.AllowDBNull = false;
            dataTable.Columns.Add(col);

            col = new DataColumn("age", typeof(int));
            dataTable.Columns.Add(col);

            col = new DataColumn("male", typeof(bool));
            dataTable.Columns.Add(col);

            // 2단계 : 행 만들기, 데이터 입력
            DataRow row = dataTable.NewRow();
            row["name"] = "아이유";
            row["age"] = 26;
            row["male"] = false;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow(); // 참조변수 이름은 그대로 사용하지만 새로운 인스턴스를 생성
            row["name"] = "조승우";
            row["age"] = 39;
            row["male"] = true;
            dataTable.Rows.Add(row);

            row = dataTable.NewRow();
            row["name"] = "장만월";
            row["age"] = 1000;
            row["male"] = false;
            dataTable.Rows.Add(row);

            dataGridView1.DataSource = dataTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            row["name"] = textName.Text;
            row["age"] = textAge.Text;
            if(rbMale.Checked)
                row["male"] = true;
            else
                row["male"] = false;
            dataTable.Rows.Add(row);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int seletedIndex = dataGridView1.SelectedRows[0].Index;
            DataRow row = dataTable.Rows[seletedIndex];
            row["name"] = textName.Text;
            row["age"] = textAge.Text;
            if (rbMale.Checked)
                row["male"] = true;
            else
                row["male"] = false;
            dataTable.Rows.Add(row);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int seletedIndex = dataGridView1.SelectedRows[0].Index;
            DataRow row = dataTable.Rows[seletedIndex];
            row.Delete();
        }
    }
}
