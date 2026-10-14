using System;
using mvcDotNetTrainingGround.Models;
using Microsoft.AspNetCore.Mvc;

namespace mvcDotNetTrainingGround.Controllers;

public class DevelopersController : Controller
{
    private Db _db;

    public DevelopersController(Db db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View(_db.Developers);
    }
}


