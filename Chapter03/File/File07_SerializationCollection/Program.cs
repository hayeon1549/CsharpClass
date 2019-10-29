﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// p.601 예제
namespace File07_SerializationCollection
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;

        public NameCard(string name, string phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.txt", FileMode.Create);
            //객체를 직렬화/역렬화 하는 클래스
            BinaryFormatter serializer = new BinaryFormatter();

            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard("아이유", "010-9279-9721", 28));
            list.Add(new NameCard("정해인", "010-7777-7777", 30));
            list.Add(new NameCard("최연진", "010-1234-1004", 17));

            // 클래스 직렬화 -> FileStream에 기록
            serializer.Serialize(ws, list); //nc 객체를 직렬화하여 ws에 작성
            ws.Close();

            // FileStream에서 클래스 역직렬화
            Stream rs = new FileStream("a.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = deserializer.Deserialize(rs) as List<NameCard>;
            rs.Close();

            foreach (var item in list2)
            {
                Console.WriteLine($"{item.Name},{item.Phone},{item.Age}");
            }
        }
    }
}