using System;
using System.IO;

// 파일을 복사하고 파일의 크기를 반환한다.
namespace Task09_AsyncAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\하연\Desktop\공부\2학년\수업\C#";

            // 파일 생성 및 텍스트 기록
            CreateFile(path + @"\source.txt");

            #region 동기식 파일 복제
            // 1. StreamReader, StreamWriter 사용
            Console.WriteLine(CopySync(path + @"\source.txt", path + @"\target1.txt"));
            #endregion

            #region 비동기식 파일 복제
            // 1. StreamReader, StreamWriter 사용
            CopyAsync(path + @"\source.txt", path + @"\target1.txt");
            #endregion
        }

        private static void CopyAsync(string fromPath, string toPath)
        {
            using (var sr = new StreamReader(fromPath))
            {
                using (var sw = new StreamWriter(toPath))
                {
                    string line;
                    line = await sr.ReadToEndAsync();
                }
            }
        }

        private static int CopySync(string fromPath, string toPath)
        {
            using (StreamWriter sr = new StreamWriter(fromPath)) // source.txt
            {
                using (StreamWriter sw = new StreamWriter(toPath)) // target1.txt
                {
                    string line;
                    line = sr.ReadToEnd();
                    sw.Write(line);
                    return line.Length; // 복사한 글자 길이 반환
                }
            }
        }

        private static void CreateFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.Write("Hello World");
            }
        }
    }
}
