using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
public class TamagotchiController : Controller
{
    private static List<TamagotchiPet> tamagotchis = new List<TamagotchiPet>();

     [HttpGet("/")]
    public ActionResult Index()
    {
        return View(TamagotchiPet.GetAll());
    }

     [HttpGet("/tamagotchi/new")]
     public ActionResult New()
     {
        return View();
     }

     [HttpPost("/tamagotchi")]
     public ActionResult Create(string name, int food, int attention, int rest)
     {
        TamagotchiPet tamagotchi = new TamagotchiPet(name, food, attention, rest);
        tamagotchis.Add(tamagotchi);
        return RedirectToAction("Index");
     }
 }
}