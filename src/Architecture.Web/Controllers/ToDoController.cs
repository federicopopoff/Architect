using Architecture.Core;
using Architecture.Core.Entities;
using Architecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Web.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IRepository<ToDoItem> _todoRepository;

        public ToDoController(IRepository<ToDoItem> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            var items = _todoRepository.List();
            return View(items);
        }

        public IActionResult Populate()
        {
            int recordsAdded = DatabasePopulator.PopulateDatabase(_todoRepository);
            return Ok(recordsAdded);
        }
    }
}
