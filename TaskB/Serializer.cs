using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Serializer
{
    private static List<Student> students = new List<Student>();
    public static void ReadStudents(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                students.Add(Student.Create(line));
            }
        }
    }

    public static void SerializeStudents(string path)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, students);
        }
    }
}