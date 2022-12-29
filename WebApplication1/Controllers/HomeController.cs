using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Team> team = new List<Team>()
            {
                new Team
                {
                    Id= 1,
                    Name = "seyid",
                    Description = "kjh yrjgdgfrdhrtfg",
                    Photo = "team-1.jpg"
                },
                new Team
                {
                    Id= 1,
                    Name = "seyid",
                    Description = "kjh yrjgdgfrdhrtfg",
                    Photo = "team-1.jpg"
                },
                new Team
                {
                    Id= 1,
                    Name = "seyid",
                    Description = "kjh yrjgdgfrdhrtfg",
                    Photo = "team-1.jpg"
                },
                new Team
                {
                    Id= 1,
                    Name = "seyid",
                    Description = "kjh yrjgdgfrdhrtfg",
                    Photo = "team-1.jpg"
                }
            };
            return View(team);
        }
    }
}
