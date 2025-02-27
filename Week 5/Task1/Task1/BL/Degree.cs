using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DL;

namespace Task1.BL
{
    internal class Degree
    {
        public string name;
        public int duration;
        public int seats;
        public List<Subject> subjects;
        public Degree()
        {
            subjects = new List<Subject>();
        }
        public Degree(string name, int duration, int seats)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        public void AddSubjectD(Subject subject)
        {
            subjects.Add(subject);
        }
        public void RegisterStudentSubject(Student student)
        {
            Console.WriteLine($"Available subjects for {name} degree:");
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {subjects[i].code}");
            }
            Console.Write("Enter the subject code to register in: ");
            string subjectCode = Console.ReadLine();
            Subject selectedSubject = null;
            foreach (Subject s in subjects)
            {
                if (s.code == subjectCode)
                {
                    selectedSubject = s;
                    break;
                }
            }
            if (selectedSubject != null)
            {
                Console.WriteLine($"{student.name} has been registered in {selectedSubject.code}");
            }
            else
            {
                Console.WriteLine("Invalid subject code.");
            }
        }
        public void CalculateFee()
        {
            foreach (Student student in StudentDL.getStudentList())
            {
                float totalFee = 0;
                Console.WriteLine($"Student: {student.name}");
                Console.WriteLine($"Degree: {name}");
                Console.WriteLine("Enrolled Subjects:");
                foreach (Subject subject in subjects)
                {
                    Console.WriteLine($"= {subject.code} (Fee: {subject.subjectFee})");
                    totalFee=totalFee+subject.subjectFee;
                }
                Console.WriteLine($"Total Fee Due: {totalFee}\n");
            }
        }
    }
}
