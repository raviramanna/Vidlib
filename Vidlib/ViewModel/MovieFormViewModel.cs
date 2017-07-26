using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Vidlib.Models;

namespace Vidlib.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres{ get; set; }
        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }
    }
}