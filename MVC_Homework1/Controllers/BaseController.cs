using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Homework1.Models;

namespace MVC_Homework1.Controllers
{
    public class BaseController : Controller
    {
        protected CustomerDBEntities db = new CustomerDBEntities();

  
    }
}