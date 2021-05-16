using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[Serializable]
public class Student
{
   
    public string Name { get; private set; }

    public string LastName { get; private set; }

    public int GroupNumber { get; private set; }
   
    public List<int> Grades { get; private set; }

    public Student(string name, string lastName, int groupNumber, List<int> grades)
    {
        Name = name;
        LastName = lastName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

   /* public static Student Create(string studentInfo)
    {
        var data = studentInfo.Split();
        string name = data[0];
        string lastName = data[1];
        int groupNumber = int.Parse(data[2]);

        List<int> grades = new List<int>();
        for (int i = 3; i < data.Length; i++)
        {
            grades.Add(int.Parse(data[i]));
        }

        return new Student(name, lastName, groupNumber, grades);
    }*/
}