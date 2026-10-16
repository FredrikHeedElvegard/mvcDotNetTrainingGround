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

    public IActionResult Details(int id)
    {
        return View(_db.Developers[id - 1]);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateNewDeveloperViewModel viewModel)
    {
        var nextID = _db.Developers.Count + 1;
        var developerToAdd = new Developer()
        {
            Id = nextID,
            Name = viewModel.Name,
            Email = viewModel.Email
        };
        _db.Developers.Add(developerToAdd);

        return RedirectToAction(nameof(Index));        
    }
}


