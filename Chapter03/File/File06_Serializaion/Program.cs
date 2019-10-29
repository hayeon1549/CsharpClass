using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace File06_Serialization
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.txt", FileMode.Create);
            //객체를 직렬화/역렬화 하는 클래스
            BinaryFormatter serializer = new BinaryFormatter();

            NameCard nc = new NameCard();
            nc.Name = "정해인";
            nc.Phone = "010-9279-9721";
            nc.Age = 30;

            // 클래스 직렬화 -> FileStream에 기록
            serializer.Serialize(ws, nc); //nc 객체를 직렬화하여 ws에 작성
            ws.Close();

            // FileStream에서 클래스 역직렬화
            Stream rs = new FileStream("a.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);
            rs.Close();

            Console.WriteLine(nc2.Name);
            Console.WriteLine(nc2.Phone);
            Console.WriteLine(nc2.Age);
        }
    }
}