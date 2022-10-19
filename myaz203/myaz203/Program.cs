class Program
{
    public static void Main()
    {
        Student student = new Student(0, "Ali", "Dag");
        Student student1 = new Student(1, "Mehmet", "Dag");
        Student student2 = new Student(2, "Deniz", "Dag");
        Student student3 = new Student(3, "Veli", "Dag");
        Student student4 = new Student(4, "Fırat", "Dag");
        StudentManager studentManager = new StudentManager(student);
        studentManager.CreateStudent(student1);
        studentManager.CreateStudent(student2);
        studentManager.CreateStudent(student3);
        studentManager.CreateStudent(student4);
        studentManager.DeleteStudent(0);
        studentManager.ReadList();
    }
}

