using CESI_CSharp_WebApp.Data;
using CESI_CSharp_WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CESI_CSharp_WebApp.Controllers
{
    public class UsersController : Controller
    {
        // GET: UsersController
        public ActionResult Index()
        {
            return View(DataUtilisateur.getInstance().usersList);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            foreach (User user in DataUtilisateur.getInstance().usersList)
            {
                if (user.Id == id)
                {
                    return View(user);
                }
            }

            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View(new User());
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]User user)
        {
            try
            {
                DataUtilisateur.getInstance().usersList.Add(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            foreach (User user in DataUtilisateur.getInstance().usersList)
            {
                if (user.Id == id)
                {
                    return View(user);
                }
            }

            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] User editedUser)
        {
            try
            {
                for (int index = 0; index < DataUtilisateur.getInstance().usersList.Count(); index++)
                {
                    if (DataUtilisateur.getInstance().usersList[index].Id == editedUser.Id)
                    {
                        DataUtilisateur.getInstance().usersList[index] = editedUser;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            foreach (User user in DataUtilisateur.getInstance().usersList)
            {
                if (user.Id == id)
                {
                    return View(user);
                }
            }

            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([FromForm] User userToDelete)
        {
            try
            {
                for (int index = 0; index < DataUtilisateur.getInstance().usersList.Count(); index++)
                {
                    if (DataUtilisateur.getInstance().usersList[index].Id == userToDelete.Id)
                    {
                        DataUtilisateur.getInstance().usersList.RemoveAt(index);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
