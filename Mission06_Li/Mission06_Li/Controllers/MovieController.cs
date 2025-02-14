using Microsoft.AspNetCore.Mvc;
using Mission06_Li.Models;

namespace Mission06_Li.Controllers;

public class MovieController : Controller
{
    private readonly MovieContext _context;

    public MovieController(MovieContext temp)
    {
        _context = temp;
    }
    
    public IActionResult AddMovie()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
        return View(movie);
    }
    
    public IActionResult MovieList()
    {
        var movies = _context.Movies.ToList();
        return View(movies);
    }
}
