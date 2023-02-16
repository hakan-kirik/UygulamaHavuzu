using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu2.Models;

namespace UygulamaHavuzu2.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.TodoModels.ToListAsync());
        }
        public async Task<IActionResult> EditAndAdd(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var todoModel = await _context.TodoModels.FindAsync(id);

            if (todoModel == null)
            {
                return NotFound();
            }
            todoModel.IsDone = todoModel.IsDone ? false : true;
            await _context.SaveChangesAsync();

            return PartialView("TodoList", await _context.TodoModels.ToListAsync());
        }

        public async Task<IActionResult> Remove(int id)
        {
            var todoModel = await _context.TodoModels.FindAsync(id);
            if (todoModel != null)
            {
                _context.Remove(todoModel);
            }

            await _context.SaveChangesAsync();


            return Ok();
        }
        public async Task<IActionResult> AddTodo(TodoModel todoModel)
        {
            if (!ModelState.IsValid)
            {
                return Ok();
            }
            await _context.AddAsync(todoModel);

            await _context.SaveChangesAsync();
            //await _context.

            return PartialView("TodoLi", todoModel);
        }
    }
}
