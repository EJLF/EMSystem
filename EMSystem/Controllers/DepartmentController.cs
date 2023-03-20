using EMSystem.Models;
using EMSystem.Repository.MsSQL;
using Microsoft.AspNetCore.Mvc;

namespace EMSystem.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRepository _repo=new DepartmentRepository();
        public IActionResult List()
        {
            var List = _repo.ListOfDepartment();
            return View(List);
        }

        public IActionResult Details(int DeptId)
        {
            var Department = _repo.GetDeptById(DeptId);
            return View(Department);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department newDepartment) // model binded this where the views data is accepted 
        {
            if (ModelState.IsValid)
            {
                var dept = _repo.AddDepartment(newDepartment);
                return RedirectToAction("List");
            }
            ViewData["Message"] = "Data is not valid to Add Department";
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int DeptId)
        {
            var dept = _repo.GetDeptById(DeptId);
            return View(dept);
        }

        [HttpPost]
        public IActionResult Edit(int DeptId, Department newDept)
        {
            var todo = _repo.UpdateDepartment(newDept.DeptId,newDept);
            return RedirectToAction("List");
        }
        
        public IActionResult Delete(int DeptId)
        {
            _repo.DeleteDepartment(DeptId);
            return RedirectToAction("List");
        }
    }
}
