using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models.Entity;
using Portfolio.Repositories;

namespace Portfolio.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<TblIletisim> repo = new GenericRepository<TblIletisim>();

        public ActionResult Index()
        {
            var mesaj = repo.List();
            return View(mesaj);
        }
    }
}