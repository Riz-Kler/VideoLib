using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoLib.Models;
using VideoLib.ViewModels;

namespace VideoLib.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random() //ViewResult
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //      ViewData["RandomMovie"] = movie;
            //      ViewBag.RandomMovie = movie;

            //       var viewResult = new ViewResult();
            //      viewResult.ViewData.Model

            //           return View(movie);

            return View(ViewModel);


            //return View(movie);


            //    return new ViewResult();

            //           return Content("Hello World!");

            //           return HttpNotFound();

            //          return new EmptyResult();

            //   return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
            //  }

            /*      [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")] //powerful attribute routes
                  public ActionResult ByReleaseYear(int year, int month) //could use byte for month as largest month is 12
                  {
                      return Content(year + "/" + month);
                  }
                  public ActionResult Edit(int id)
                  {
                      return Content("id = " + id);
                  }
                  // movies
                  public ActionResult Index(int? pageIndex, string sortBy) //string type is a referecne type so it's nullable
                  {
                      if (!pageIndex.HasValue)
                      {
                          pageIndex = 1;
          
                      }
          
                      if (String.IsNullOrWhiteSpace(sortBy))
                          sortBy = "Name";
          
                      return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
                      */
        }
    }
}