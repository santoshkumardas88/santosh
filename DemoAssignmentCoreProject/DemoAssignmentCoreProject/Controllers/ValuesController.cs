using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoAssignmentCoreProject.Models;
using DemoAssignmentCoreProject.Contexts;

namespace DemoAssignmentCoreProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DemoContext _demoContext;
        public ValuesController(DemoContext demoContext)
        {
            this._demoContext = demoContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            var itemList = this._demoContext.Items.ToList();
            return new List<Item>(itemList);
        }
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            var categoryToDelete = this._demoContext.Categories.Where(x => x.Name == name).FirstOrDefault();
            this._demoContext.Categories.Remove(categoryToDelete);
            this._demoContext.SaveChanges();
        }
    }
}
