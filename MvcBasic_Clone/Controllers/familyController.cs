using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class familyController : Controller
    {
        // GET: family
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FamilyList()
        {
            List<family> families = new List<family>
            {
            new family{ Id=10001,Name="大衛李",Phone="0933-154228",Age="25",City="Taipei"},
            new family{ Id=10002,Name="Davi",Phone="0933-154228",Age="24",City="Taipei"},
            new family{ Id=10003,Name="Dav",Phone="0933-154228",Age="23",City="Taipei"},
            new family{ Id=10004,Name="Da",Phone="0933-154228",Age="22",City="Taipei"},
            new family{ Id=10005,Name="D",Phone="0933-154228",Age="21",City="Taipei"}
            };



            return View(families);
        }
    }
}