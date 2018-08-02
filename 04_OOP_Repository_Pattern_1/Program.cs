using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Repository_Pattern_1
{
    class Program
    {
        /// <summary>
        /// console statments go in here.
        /// method call go in here.
        /// object creation happen here.
        /// the program runs from here.
        /// </summary>
        
        

        static void Main(string[] args)
        {
            Netflix strangerThings = new Netflix();
            strangerThings.Title = "Stranger Things";
            strangerThings.Genre = GenreType.Horror;
            strangerThings.Rating = "M";
            strangerThings.StarRating = 3;
            strangerThings.HasWatched = true;

            
            

            Netflix hawaiiFive0 = new Netflix("hawaiifive0", 9, "PG", true, GenreType.Drama);
            Netflix theCrown = new Netflix("the crown", 9, "PG", false, GenreType.Comedy);
            
            NetflixRepository netflixRepo = new NetflixRepository();
            netflixRepo.AddShowToList(hawaiiFive0);
            netflixRepo.AddShowToList(strangerThings);
            netflixRepo.AddShowToList(theCrown);

            List<Netflix> shows = netflixRepo.GetList();

            //foreach (Netflix show in shows)
            //{
            //    Console.WriteLine(show.Title);

            //}

            netflixRepo.RemoveShowFromList(hawaiiFive0);


            foreach (Netflix show in shows)
            {
                Console.WriteLine($"Title: {show.Title}\n" +
                    $"Rating: {show.Rating}\n" +
                    $"Star Rating: {show.StarRating}\n" +
                    $"Has Watched: {show.HasWatched}\n" +
                    $"Genre: {show.Genre}\n");
            }

            //Console.WriteLine("Name the movie title that you'd like to watch");
            //var movieTitle = Console.ReadLine();

            //var showFoundFromFindShowByTitle = netflixRepo.FindShowByName(movieTitle);




        }
    }
    
}
