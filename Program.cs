using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JsonApi.University;

namespace JsonApi
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassUniversities university1 = new ClassUniversities();

            university1.universities = new Universities();

            university1.universities.university = "Karadeniz Teknik Üniversitesi";

            List<Student> listStudent = new List<Student>();

            Student student1 = new Student
            {
                name="Mustafa Kemal Tunca",
                number="571",
                faculty="Fen Fakültesi",
                department="Matematik"
            };
            Student student2 = new Student
            {
                name = "Bünyamin Kömür",
                number = "572",
                faculty = "Fen Fakültesi",
                department = "Matematik"
            };
            Student student3 = new Student
            {
                name = "Yasin Yalgın",
                number = "600",
                faculty = "Mühendislik",
                department = "Malzeme Metalurji"
            };
            Student student4 = new Student
            {
                name = "Gürel",
                number = "601",
                faculty = "Mühendislik",
                department = "Orman Mühendisliği"
            };

            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            university1.universities.students = listStudent;
            string json = JsonConvert.SerializeObject(university1);

            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
