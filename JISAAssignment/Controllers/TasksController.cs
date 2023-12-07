using JISAAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JISAAssignment.Controllers
{
    public class TasksController : Controller
    {

        public TaskDal dal;

        public TasksController()
        {
            dal = new TaskDal();   
        }
        // GET: TasksController
        public ActionResult Index()
        {
            var model = dal.GetAllTasks();
            return View(model);
        }

        // GET: TasksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TasksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TasksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tasks tasks)
        {
            var result = dal.AddTask(tasks);
            return RedirectToAction("Index");
        }

        // GET: TasksController/Edit/5
        public ActionResult Edit(int id)
        {

            Tasks task = dal.GetAllTasks().Find(t => t.TaskId == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: TasksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tasks task)
        {
            dal.UpdateTask(task);
            return RedirectToAction("Index");


        }

        // GET: TasksController/Delete/5
        public ActionResult Delete(int id)
        {
            Tasks task = dal.GetAllTasks().Find(t => t.TaskId == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // POST: TasksController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(Tasks task)
        {
          
            var result=dal.DeleteTask(task);
            return RedirectToAction("Index");
        }
        
    }
}
