using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial6OOPObject
{
    public static class StudentsGen
    {
        private static Random ran = new Random();
        private static List<string> names = new List<string>()
        {
            "David",
            "Lenka",
            "Katka",
            "Pepa",
            "Tereza",
            "Milan",
            "Bobicek"
        };

        private static List<string> surnames = new List<string>()
        {
            "Posera",
            "Kozihl8vek",
            "Kobliha",
            "Bobika",
            "Kohout",
            "Macek",
            "Pupik"
        };


        public static List<Student> GetStudents(int count)
        {
            List<Student> res = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                res.Add(new Student()
                {
                    jmeno = names.GetRandom(),
                    prijmeni = surnames.GetRandom(),
                    vek = ran.Next(99)
                });
            }
            return res;

        }

        private static T GetRandom<T>(this List<T> list)
        {
            return list[ran.Next(list.Count - 1)];
        }
    }
}
