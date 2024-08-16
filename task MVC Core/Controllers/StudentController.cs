using Microsoft.AspNetCore.Mvc;
using task_MVC_Core.Models;

namespace task_MVC_Core.Controllers
{
    public class StudentController : Controller
    {
       public IActionResult AllStudents()
        {
            StudentMock studentMock = new StudentMock();
            var students = studentMock.AllStudents();
            return View("AllStudents",students);
        }
      public IActionResult studentByid(int id)
        {
            StudentMock studentMock= new StudentMock();
            var student = studentMock.GetStudent(id);
            return View("student", student);
        }
    }
}
