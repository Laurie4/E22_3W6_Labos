using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand_Models.ViewModel
{
    public class MovieVm
    {
        public MovieVm()
        {

        }
        public MovieVm(Movie m)
        {
            Id = m.MovieId;
            Title = m.Title;
            Poster = m.Poster;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
    }
}
