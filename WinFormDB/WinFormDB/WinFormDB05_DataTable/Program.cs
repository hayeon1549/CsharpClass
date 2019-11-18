using System;
using System.Data;

namespace WinFormDB05_DataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1단계 : 테이블과 컬럼 만들기
            DataTable dataTable = new DataTable("dataTable"); // 메모리 상의 데이터 테이블
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

            // 3단계 : 모든 데이터 출력
            foreach (DataRow item in dataTable.Rows)
            {
                string gender;
                if (item["male"].ToString() == "True")
                    gender = "남자";
                else
                    gender = "여자";
                Console.WriteLine($"Name: {item["name"]}, Age: {item["age"]}, Gender{gender}");
            }
        }
    }
}
