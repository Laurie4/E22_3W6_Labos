using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLand_DataAccess.Data;
using MovieLand_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLand.Controllers
{
    public class GenresController : Controller
    {
        private readonly MovieLandDbContext _db;

        public GenresController(MovieLandDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Genres.OrderBy(g => g.Name).ToList());
        }

        //public IActionResult Details(int? id)
        //{
        //    if(id == null)
        //    {
        //        return NotFound();
        //    }

        //    Genre genre = _db.Genres.FirstOrDefault(g => g.GenreId == id);

        //    if (genre == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(genre);
        //}
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //GenreVM GenreVM = new GenreVM();
            //{
            //    Genre genre = _db.Genres.FirstOrDefault(g => g.GenreId == id),
                var genre = _db.Genres
                            .Include(m => m.Name)
                            .Include(m => m.Movies.ToList())
                                .FirstOrDefault(m => m.GenreId == id);

            //}
            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }
    }
}
