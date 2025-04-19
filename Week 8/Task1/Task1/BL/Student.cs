using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public string Program
        { 
            get { return program;  }
            set { program = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public Student(string name, string address, string program, int year, double fee) :base(name, address) 
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public override string toString()
        {
            return $"Student Name: {Name}, Address: {Address}, Program: {Program}, Year: {Year}, Fee: {Fee}";
        }
        public new static void addToList(Person person)
        {
            DL.PersonDL.personList.Add(person);
        }
    }
}
