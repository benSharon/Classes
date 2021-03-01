using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Exercice.Models;

namespace Classes.Exercice
{
    class SchoolData
    {
        private List<Class> Classes { get; set; }
        private List<Student> Students { get; set; }
        private List<Subject> Subjects { get; set; }

        public SchoolData() => InitializeData();

        private void InitializeData()
        {
            Students = new List<Student>();
            Students.AddRange(new List<Student>
            {
                new Student("Whiteford", "Thomas", DateTime.Parse("05/25/2000")),
                new Student("Parks", "Erick", DateTime.Parse("07/11/2000")),
                new Student("Smith", "Emily", DateTime.Parse("01/03/2001")),
                new Student("James", "Bratt", DateTime.Parse("08/30/1995")),
                new Student("Peterson", "Lily", DateTime.Parse("05/31/1999")),
                new Student("Lee", "Mathew", DateTime.Parse("01/03/2001")),
                new Student("Smith", "Alice", DateTime.Parse("08/30/1995")),
                new Student("Hill", "Anna", DateTime.Parse("05/31/1999")),
                new Student("Weldon", "Max", DateTime.Parse("12/05/1998"))
            });

            Subject maths = new Subject("Maths");
            Subject english = new Subject("English");
            Subject french = new Subject("French");

            Subjects = new List<Subject>
            {
                maths,
                english,
                french
            };

            Classes = new List<Class>
            {
                new Class("Calculus 1", "Mr. Brown", maths, Students.Take(3).ToList()),
                new Class("Calculus 2", "Mr. Monroe", maths, Students.Skip(3).ToList()),
                new Class("Learning English from Scratch", "Mr. Roy", english, Students.Skip(4).ToList()),
                new Class("Littérature française", "Mr. Tremblay", french, Students.Take(5).ToList())
            };
        }
        
        public Class GetClass(string className)
        {
            foreach (var item in Classes)
                if (item.Name == className)
                    return item;
            return null;
        }

        public Student GetStudent(string fullName)
        {
            foreach (var item in Students)
                if (item.FullName == fullName)
                    return item;
            return null;
        }

        public List<Class> GetStudentClasses(Student student)
        {
            var classList = new List<Class>();
            foreach (var item in Classes)
                if (item.Students.Contains(student))
                    classList.Add(item);
            return classList;
        }

        public string[] GetAllClassesText()
        {
            string[] stringArrClasses = new string[Classes.Count];
            for (int i = 0; i < Classes.Count; i++)
                stringArrClasses[i] = Classes[i].Name;
            return stringArrClasses;
        }

        public List<Student> GetStudentsFromClass(string className)
            => GetClass(className).Students;

        public void CreateStudent(string firstName, string lastName, string birthday, List<string> classes)
        {
            Student student = new Student(lastName, firstName, DateTime.Parse(birthday));
            Students.Add(student);
            foreach (var item in classes)
                GetClass(item).AddStudent(student);
        }

        public void EditStudent(Student student, List<string> classNames)
        {
            List<Class> oldStudentClasses = GetStudentClasses(student);
            List<Class> newStudentClasses = new List<Class>();
            foreach (var item in classNames)
                newStudentClasses.Add(GetClass(item));

            foreach (var academicalClass in Classes)
                if (oldStudentClasses.Contains(academicalClass) && !newStudentClasses.Contains(academicalClass))
                    academicalClass.RemoveStudent(student);
                else if (!oldStudentClasses.Contains(academicalClass) && newStudentClasses.Contains(academicalClass))
                    academicalClass.AddStudent(student);
        }
    }
}
