using System;
using System.Collections.Generic;
using System.Text;

namespace DataSandAassignment2
{
    public class Student
    {
        string firstName;
        string lastName;
        string studentNumber;
        float averageScore;

        public Student(string First, string Last, string SNumber, float Score)
        {
            this.firstName = First;
            this.lastName = Last;
            this.studentNumber = SNumber;
            this.averageScore = Score;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("First name cannot be empty!");
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Last name cannot be empty!");
                else
                    lastName = value;
            }
        }
        public string StudentNumber
        {
            get { return studentNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Student number cannot be empty!");
                else
                    studentNumber = value;
            }
        }
        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }
        public override string ToString()
        {
            string StudentInformation =
                $"First name: {FirstName}\n" +
                $"Last name: {LastName}\n" +
                $"Student number: {StudentNumber}\n" +
                $"Average score: {AverageScore}\n";
            return StudentInformation;
        }
    }
}