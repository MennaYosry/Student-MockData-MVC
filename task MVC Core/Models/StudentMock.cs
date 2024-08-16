namespace task_MVC_Core.Models
{
    public class StudentMock
    {
        List<Student> students;
        public StudentMock()
        {
            students = new List<Student>();
            students.Add(new Student() { Id=1,Name="Menna" , Address="AlHaram" ,Img="menna.jpg"});
            students.Add(new Student() { Id = 2, Name = "Salma", Address = "minia", Img = "salma.jpg" });
            students.Add(new Student() { Id = 3, Name = "Ali", Address = "badr", Img = "ali.jpg" });

        }
        public List<Student> AllStudents() { 
             return students;
        }
        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }
    }
}
