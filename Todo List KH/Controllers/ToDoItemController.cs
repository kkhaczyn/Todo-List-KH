using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Todo_List_KH.AppContext;
using Todo_List_KH.Models;
using Todo_List_KH.Models.Application;

namespace Todo_List_KH.Controllers
{
    public class ToDoItemController : Controller
    {
        WebAppContext webAppContext;

        public ToDoItemController(WebAppContext webAppContext)
        {
            this.webAppContext = webAppContext;
        }

        [HttpGet]
        public async Task<IActionResult> UpdateItem(int id)
        {
            ToDoItem toDoItem = await webAppContext.ToDoItems.FindAsync(id);

            if (toDoItem is null)
            {
                return RedirectToAction("Index", "Home", new { message = "Coś poszło nie tak" });
            }
            else
            {
                return View(toDoItem);
            }

        }

        [HttpPost]
        public async Task<IActionResult> UpdateItem(ToDoItem updatedItem)
        {
            if (updatedItem is not null)
            {
                ToDoItem toDoItemBase = await webAppContext.ToDoItems.FindAsync(updatedItem.Id);

                if (toDoItemBase is not null)
                {
                    if (updatedItem.ExecutionTime > DateTime.Now)
                    {
                        try
                        {
                            toDoItemBase.Name = updatedItem.Name;
                            toDoItemBase.ExecutionTime = updatedItem.ExecutionTime;
                            webAppContext.ToDoItems.Update(toDoItemBase);
                            await webAppContext.SaveChangesAsync();
                        }
                        catch (Exception e)
                        {
                            ViewData["Message"] = e.Message;
                            return View(updatedItem);
                        }
                    }
                    else
                    {
                        ViewData["Message"] = "Data musi być większa niż obecna";
                        return View(updatedItem);
                    }
                }
                else
                {
                    ViewData["Message"] = "Coś poszło nie tak";
                    return View(updatedItem);
                }
            }
            else
            {
                ViewData["Message"] = "Coś poszło nie tak";
                return View(updatedItem);
            }

            return RedirectToAction("Index", "Home", new { dateTime = updatedItem.ExecutionTime.Date, message = "Pomyślnie zaktualizowano zadanie" });
        }

        public async Task<IActionResult> DeleteItem(int id)
        {
            try
            {
                ToDoItem toDoItem = await webAppContext.ToDoItems.FindAsync(id);
                if (toDoItem is not null)
                {
                    webAppContext.Remove(toDoItem);
                    await webAppContext.SaveChangesAsync();
                    return RedirectToAction("Index", "Home", new { dateTime = toDoItem.ExecutionTime.Date, message = "Pomyślnie usunięto zadanie"});
                }

            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home", new { message = $"Coś poszło nie tak. {e.Message}" });
            }

            return RedirectToAction("Index", "Home", new { message = $"Coś poszło nie tak." });
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(ToDoItem toDoItem)
        {
            if (toDoItem is not null)
            {
                if (toDoItem.ExecutionTime > DateTime.Now)
                {
                    try
                    {
                        await webAppContext.ToDoItems.AddAsync(toDoItem);
                        await webAppContext.SaveChangesAsync();
                    }
                    catch (Exception e)
                    {
                        ViewData["Message"] = e.Message;
                        return View(toDoItem);
                    }

                }
                else
                {
                    ViewData["Message"] = "Data musi być większa niż obecna";
                    return View(toDoItem);
                }
            }
            else
            {
                ViewData["Message"] = "Coś poszło nie tak";
                return View(toDoItem);
            }

            return RedirectToAction("Index", "Home", new { dateTime = toDoItem.ExecutionTime.Date, message = "Pomyślnie dodano zadanie" });
        }

        public async Task<IActionResult> ChangeStatus(int id)
        {
            try
            {
                ToDoItem toDoItem = await webAppContext.ToDoItems.FindAsync(id);
                if (toDoItem is not null)
                {
                    if (toDoItem.IsCompleted)
                    {
                        toDoItem.IsCompleted = false;
                    }
                    else
                    {
                        toDoItem.IsCompleted = true;
                    }
                    webAppContext.ToDoItems.Update(toDoItem);
                    await webAppContext.SaveChangesAsync();
                    return RedirectToAction("Index", "Home", new { dateTime = toDoItem.ExecutionTime.Date, message = "Pomyślnie zmieniono status zadania" });
                }
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home", new { message = $"Coś poszło nie tak. {e.Message}" });
            }
            return RedirectToAction("Index", "Home", new { message = "Coś poszło nie tak." });
        }
    }
}
