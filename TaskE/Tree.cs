using System;
using System.Xml.Serialization;

[XmlInclude(typeof(Oak))]
[XmlInclude(typeof(Ash))]

public class Tree : IComparable
{
    public int height;
    public int age;

    public Tree()
    {
    }

    public int CompareTo(object obj)
    {
        var maxTree = obj as Tree;

        if (this.height > maxTree.height)
        {
            return 1;
        }
        else if (this.height < maxTree.height)
        {
            return -1;
        }
        else
            return 0;
    }

    public Tree(int height, int age)
    {
        this.height = height;
        this.age = age;
    }
    
    public override string ToString()
    {
        return $"height:{height} age:{age}";
    }
}