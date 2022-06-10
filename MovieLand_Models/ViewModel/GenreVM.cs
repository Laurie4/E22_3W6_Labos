using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand_Models.ViewModel
{
    public class GenreVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MovieGenre> MovieGenre { get; set; }

    }
}
