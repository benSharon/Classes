using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exercice.Models
{
    class Class
    {
        private string _name;
        private string _teacher;
        private List<Student> _students;
        private Subject _subject;

        public string Name { get => _name; }
        public string Teacher { get => _teacher; }
        public List<Student> Students { get => _students; }
        public Subject Subject { get => _subject; }

        public Class(string name, string teacher, Subject subject, List<Student> students)
        {
            _name = name;
            _teacher = teacher;
            _students = students;
            _subject = subject;
        }

        public void AddStudent(Student student) => Students.Add(student);
        public void RemoveStudent(Student student) => Students.Remove(student);
    }
}
