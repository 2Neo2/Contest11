using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Deserializer
{
    public static List<Student> DeserializeStudents(string path)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        List<Student> students = new List<Student>();
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
             students =  (List<Student>)binaryFormatter.Deserialize(fs);
        }
        return students;
    }
}