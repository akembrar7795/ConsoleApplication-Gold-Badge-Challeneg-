using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Repository_Pattern_1
{
    /// <summary>
    /// This class will only have properties, custom type, constructors.
    /// </summary>

    // making custom type
    public enum GenreType
    {
        Drama = 1, Romance, Horror, Comedy, Bromance
    }
    internal class Netflix
    {
        // constructor-1
        public Netflix()
        {

        }

        //constructor -2
        public Netflix(string t, int sr, string r, bool hw, GenreType g) 
        {
            Title = t;
            StarRating = sr;
            Rating = r;
            HasWatched = hw;
            Genre = g;

        }

        // properties
        public string Title { get; set; }
        public int StarRating { get; set; }
        public string Rating { get; set; }
        public bool HasWatched { get; set; }
        public GenreType Genre { get; set; }
    }
}
