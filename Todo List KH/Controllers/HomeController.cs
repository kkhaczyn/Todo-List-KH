using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Todo_List_KH.AppContext;
using Todo_List_KH.Models;
using Todo_List_KH.Models.Application;

namespace Todo_List_KH.Controllers
{
    public class HomeController : Controller
    {
        WebAppContext webAppContext;

        public HomeController(WebAppContext webAppContext)
        {
            this.webAppContext = webAppContext;
        }

        public IActionResult Index(DatePickerModel datePickerModel, string? message, DateTime? dateTime)
        {
            //var toDoItemsList = from t in webAppContext.ToDoItems
            //                    where t.ExecutionTime > DateTime.Now
            //                    && t.IsCompleted == false
            //                    orderby t.ExecutionTime ascending
            //                    select new
            //                    {
            //                        t.Id,
            //                        t.Name,
            //                        t.ExecutionTime,
            //                        t.IsCompleted
            //                    }

            //tasks for specific day
            if (!String.IsNullOrWhiteSpace(datePickerModel.DateTime.ToString()) && String.IsNullOrWhiteSpace(dateTime.ToString()))
            {
                ViewBag.pickedDate = datePickerModel.DateTime.Date.ToShortDateString();
                List<ToDoItem> toDoListInPickedDate = webAppContext.ToDoItems.Where
                (
                    x => x.ExecutionTime.Date.Equals(datePickerModel.DateTime.Date)
                ).OrderBy
                (
                    x => x.ExecutionTime
                ).ToList();
                if (toDoListInPickedDate.Count().Equals(0))
                {
                    ViewBag.toDoListInPickedDate = null;
                }
                else
                {
                    ViewBag.toDoListInPickedDate = toDoListInPickedDate;
                }
            }
            else if (!String.IsNullOrWhiteSpace(dateTime.ToString()))
            {
                ViewBag.pickedDate = dateTime.ToString().Substring(0,dateTime.ToString().IndexOf(" "));
                List<ToDoItem> toDoListInPickedDate = webAppContext.ToDoItems.Where
                (
                    x => x.ExecutionTime.Date.Equals(dateTime)
                ).OrderBy
                (
                    x => x.ExecutionTime
                ).ToList();
                if (toDoListInPickedDate.Count().Equals(0))
                {
                    ViewBag.toDoListInPickedDate = null;
                }
                else
                {
                    ViewBag.toDoListInPickedDate = toDoListInPickedDate;
                }
            }

            //the fastest tasks to do
            List<ToDoItem> theFastestTasksToDo = webAppContext.ToDoItems.Where
                (
                    x => x.ExecutionTime > DateTime.Now
                    && x.IsCompleted.Equals(false)
                ).OrderBy
                (
                    x => x.ExecutionTime
                ).Take(5).ToList();

            if (theFastestTasksToDo != null)
            {
                ViewBag.theFastestTasksToDo = theFastestTasksToDo;
                //notifications
                ViewBag.notifications = theFastestTasksToDo.Take(2);
            }
            else
            {
                ViewBag.theFastestTasksToDo = theFastestTasksToDo;
                //notifications
                ViewBag.notifications = null;
            }

            //message to show
            if (message is not null)
            {
                ViewData["Message"] = message;
            }

            
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
