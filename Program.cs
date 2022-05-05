using System;
using System.Collections.Generic;
using System.Text;

namespace DataSandAassignment2
{
    public class CustomDataList
    {
        LinkedList<Student> database;
        public CustomDataList(LinkedList<Student> asssignment)
        {
            this.database = asssignment;
        }

        public CustomDataList()
        {
        }

        public LinkedList<Student> Database
        {
            get { return database; }
            set { database = value; }
        }
        public int Count { get; }

        public void PopulateWithSampleData()
        {
            string first1 = "ISLAM";
            string last1 = "ELSHAKHS";
            string number1 = "6564";
            float av1 = 62;
            Student student1 = new Student(first1, last1, number1, av1);
            database.AddFirst(student1);

            string first2 = "HOSSAM";
            string last2 = "GHALy";
            string number2 = "652";
            float av2 = 25;
            Student student2 = new Student(first2, last2, number2, av2);
            database.AddFirst(student2);

            string first3 = "JOERG";
            string last3 = "TAMER";
            string number3 = "6541";
            float av3 = 85;
            Student student3 = new Student(first3, last3, number3, av3);
            database.AddFirst(student3);

            string first4 = "JHONY";
            string last4 = "DEEB";
            string number4 = "26524";
            float av4 = 42;
            Student student4 = new Student(first4, last4, number4, av4);
            database.AddFirst(student4);

       
        }

        public void Add(Student student)
        {
            database.AddLast(student);
            Console.WriteLine();
            Console.WriteLine("New Student Added!");
        }

        public Student GetElement(int index)
        {
            Student[] copy = new Student[database.Count];
            database.CopyTo(copy, 0);
            return copy[index - 1];
        }

        public void RemoveByIndex(int index)
        {
            Student[] copy = new Student[database.Count];
            database.CopyTo(copy, 0);
            Student removed = copy[index - 1];
            database.Remove(removed);
        }

        public void RemoveFirst()
        {
            database.RemoveFirst();
        }

        public void RemoveLast()
        {
            database.RemoveLast();
        }

        public void DisplayList()
        {
            if (database.Count == 0)
            {
                Console.WriteLine("Database is empty!");
            }
            else
            {
                int c = 1;
                foreach (Student student in database)
                {
                    Console.WriteLine($"({c})");
                    Console.WriteLine(student.ToString());
                    Console.WriteLine();
                    c++;
                }
            }
        }

        public Student GetMaxElement()
        {
            Student[] array = new Student[database.Count];
            database.CopyTo(array, 0);

            Student HighestStudent = array[0];
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (HighestStudent.AverageScore < array[i].AverageScore)
                        HighestStudent = array[i];
                }
            }
            return HighestStudent;
        }
        public Student GetMinElement()
        {
            Student[] array = new Student[database.Count];
            database.CopyTo(array, 0);

            Student LowestStudent = array[0];
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (LowestStudent.AverageScore > array[i].AverageScore)
                        LowestStudent = array[i];
                }
            }
            return LowestStudent;
        }
        public void Sort(int sortDirection, int sortField)
        {
            Student[] copy = new Student[database.Count];
            database.CopyTo(copy, 0);
            switch (sortField)
            {
                case 1:
                    Array.Sort(copy, delegate (Student student1, Student student2)
                    {
                        return student1.FirstName.CompareTo(student2.FirstName);
                    });
                    break;

                case 2:
                    Array.Sort(copy, delegate (Student student1, Student student2)
                    {
                        return student1.LastName.CompareTo(student2.LastName);
                    });
                    break;

                case 3:
                    Array.Sort(copy, delegate (Student student1, Student student2)
                    {
                        return student1.AverageScore.CompareTo(student2.AverageScore);
                    });
                    break;
            }

            database.Clear();

            switch (sortDirection)
            {
                case 1:
                    foreach (Student student in copy)
                    {
                        database.AddLast(student);
                    }
                    break;

                case 2:
                    foreach (Student student in copy)
                    {
                        database.AddFirst(student);
                    }
                    break;
            }
        }
    }
}