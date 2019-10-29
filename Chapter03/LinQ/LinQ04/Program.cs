using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 495p 예제
namespace LINQ04 //Group_by
{
    class Profile
    {
        public string name { get; set; }
        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrProfile =
            {
                new Profile(){name="정우성", Height=186},
                new Profile(){name="김태희", Height=158},
                new Profile(){name="고현정", Height=172},
                new Profile(){name="이문세", Height=178},
                new Profile(){name="정해인", Height=190}
            };

            #region 키(175)로 분류, inchHeight 추가
            // 2. 쿼리 만들기(키 175 이상과 미만으로 그룹을 분류)
            //group A by B into C => A를 B에 따라 분류하여 C 에 저장
            var profileList = from profile in arrProfile
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            // 3. 쿼리 실행
            foreach (var Group in profileList)
            {
                Console.WriteLine($"175미만 그룹인가 ? {Group.GroupKey}");
                foreach (var item in Group.Profiles)
                {
                    Console.WriteLine($"{item.name}, {item.Height}");
                }
                Console.WriteLine();
            }
            #endregion

            #region 이름으로 분류
            #endregion

            #region 그룹 조건 사용
            #endregion
        }
    }
}