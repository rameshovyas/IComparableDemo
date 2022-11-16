using System.Collections;

public class Student : IComparable
{
    protected int rno;
    protected string? name;
    protected float marks;

    public int RollNo
    {
        get { return rno; }
        set { rno = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public float Marks
    {
        get { return marks; }
        set { marks = value; }
    }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        Student otherStudent = obj as Student;
        if (otherStudent != null)
        {
            return this.marks.CompareTo(otherStudent.marks);
        }
        else
            throw new ArgumentException("Object is not a student");
    }

}
public class CompareStudents
{   
    public static void Main()
    {
        ArrayList students = new ArrayList();
        // Initialize random number generator.
        Random rnd = new Random();

        // Generate 10 temperatures between 0 and 100 randomly.
        for (int i = 1; i <= 10; i++)
        {
            float marks = rnd.Next(0, 100);
            Student s = new Student();
            s.RollNo = i;
            s.Name = "Student-" + i.ToString();
            s.Marks = marks; 
            students.Add(s);
        }

        // Sort ArrayList.
        students.Sort();

        foreach (Student s in students)
            Console.WriteLine($"{s.RollNo}   {s.Name}   {s.Marks}");
    }
}

