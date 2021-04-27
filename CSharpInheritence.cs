using System;

//we can use sealed classes so that it cannot be inherited
//SYNTAX public sealed class subject
public class Subject
{
    
    public string name;
    public int m1, m2, total;
    public Subject(string name,int m1,int m2)
    {
        this.name = name;
        this.m1 = m1;
        this.m2 = m2;
    }
    public void setdefault(String name,int m1,int m2)
    {
        this.name = name;
        this.m1 = m1;
        this.m2 = m2;
    }
    public void gettotal()
    {
        total = m1 + m2;
        Console.WriteLine("Total is {0}", total);
    }
}

class Student : Subject
{
    public string student_name;
    public void SetName(string student_name)
    {
        this.student_name = student_name;
    }
}
class CSharpInheritence
{
    // Main Method
    static void Main(string[] args)
    {
        Student s = new Student();
        s.SetName("pankaj");
        s.setdefault("English", 30, 45);
        s.gettotal();
    }
}