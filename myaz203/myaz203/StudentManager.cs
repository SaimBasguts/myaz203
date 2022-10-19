public class StudentManager
{
    List<Student> students;
    public StudentManager()
    {
        students = new List<Student>();
    }

    public StudentManager(Student student)
    {
        students = new List<Student>();
        CreateStudent(student);
    }
    // Create
    public void CreateStudent(Student student)
    {
        students.Add(student);
    }
    // Read
    public Student ReadStudent(int id)
    {
        return students[id];
    }
    // Update
    public void UpdateStudent(int id, string? firstName = null, string?
   lastName = null)
    {
        if (firstName != null)
            students[id].FirstName = firstName;
        if (lastName != null)
            students[id].LastName = lastName;
    }
    // Delete
    public Student DeleteStudent(int id)
    {
        var std = ReadStudent(id);
        students.RemoveAt(id);
        return std;
    }
    public void ReadList()
    {
        foreach (var item in students)
            Console.WriteLine(item.ToString());
    }
}

