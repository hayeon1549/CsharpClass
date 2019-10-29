using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hashtable,Dictionary */
/* (key, value) 쌍 형태의 데이터 저장 */
namespace Collections04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Systme.Collections.Hashtable
            Hashtable ht = new Hashtable()
            {
                [1] = "하나",
                [2] = "둘",
                [3] = "셋"
            };
            ht.Add("Name", "아이유");
            ht["Age"] = 26;
            PrintHashtable(ht);

            if (ht.ContainsKey("Name"))
                ht["Name"] = "장만월";
            else
                ht.Add("Name", "장만월");
            PrintHashtable(ht);

            if (ht.ContainsValue("넷"))
                Console.WriteLine("이미 존재하는 값");
            else
                ht.Add(4, "넷");

            #endregion

            #region Systme.Collections..Generic.Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                [1] = "하나",
                [2] = "둘"
            };
            dic[3] = "셋";
            dic.Add(4, "넷");
            PrintDictionary(dic);

            #endregion
        }

        private static void PrintDictionary(Dictionary<int, string> dic)
        {
            foreach (var item in dic.Keys)
                Console.Write($"{dic[item]} ");
            Console.WriteLine('\n');
        }

        private static void PrintHashtable(Hashtable ht)
        {
            foreach (var item in ht.Keys)
                Console.Write($"{ht[item]} ");
            Console.WriteLine('\n');
        }
    }
}