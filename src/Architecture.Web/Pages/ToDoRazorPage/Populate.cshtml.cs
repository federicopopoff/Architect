using Architecture.Core;
using Architecture.Core.Entities;
using Architecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Architecture.Web.Pages.ToDoRazorPage
{
    public class PopulateModel : PageModel
    {
        private readonly IRepository<ToDoItem> _todoRepository;

        public PopulateModel(IRepository<ToDoItem> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public int RecordsAdded { get; set; }

        public void OnGet()
        {
            RecordsAdded = DatabasePopulator.PopulateDatabase(_todoRepository);
        }
    }
}
