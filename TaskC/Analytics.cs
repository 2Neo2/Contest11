using System;
using System.Collections.Generic;
using System.IO;

public static class Analytics
{
    public static double FindGpa(List<Student> students)
    {
        double sumGpa = 0;
        foreach (var student in students)
        {
            double studentGpa = 0;
            double sumGrades = 0;
            foreach (var grade in student.Grades)
            {
                sumGrades += grade;
            }
            studentGpa = sumGrades / student.Grades.Count;
            sumGpa += studentGpa;
        }
        double gpa = sumGpa / students.Count;
        return gpa;
    }


    public static void WriteStudentsWithGpaNoLessThanAverage(List<Student> students, string path, double gpa)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(Math.Round(gpa, 2));
            foreach (var student in students)
            {
                double sumGrades = 0;
                foreach (var grade in student.Grades)
                {
                    sumGrades += grade;
                }
                double studentGpa = sumGrades / student.Grades.Count;
                
                if (studentGpa >= gpa)
                    sw.WriteLine(student.Name + " " + student.LastName + " " + student.GroupNumber);
            }
        }
    }
}