using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
   

public class StudentController : Controller
{
    public IActionResult Index()
    {
        List<StudentViewModel> userList = StudentUtils.GetStudentViews();
        return View(userList);
    }
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit(string id)
    {
        StudentViewModel? StudentViewModel = StudentUtils.GetStudent(Convert.ToInt32(id));
        return View(StudentViewModel);
    }
    public IActionResult Details(string id)
    {
        StudentViewModel? StudentViewModel = StudentUtils.GetStudent(Convert.ToInt32(id));
        return View(StudentViewModel);
    }
    public IActionResult Delete(string id)
    {
        StudentViewModel StudentViewModel = StudentUtils.GetStudent(Convert.ToInt32(id));
        StudentUtils.DeleteStudent(StudentViewModel);
        return Redirect("/Student/Index");
    }
    [HttpPost]
    public IActionResult Edit(StudentViewModel StudentViewModel)
    {
        StudentUtils.UpdateStudent(StudentViewModel);
        return Redirect("/Student/Index");
    }
    [HttpPost]
    public IActionResult Create(StudentViewModel StudentViewModel)
    {
        StudentUtils.AddStudent(StudentViewModel);
        return Redirect("/Student/Index");
        //return View();
    }
}
}