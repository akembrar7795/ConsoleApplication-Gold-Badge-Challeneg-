using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Repository_Pattern_1
{
    class NetflixRepository
    {
        /// <summary>
        /// This repository will only hold methods and some field 
        /// This will not contain any console statements.
        /// </summary>
        //Field
        private List<Netflix> _netflixShows = new List<Netflix>();


        //Methods
        public void AddShowToList(Netflix shows)
        {
            _netflixShows.Add(shows);
        }

        //Accecsor |return type  | name
        public List<Netflix> GetList()
        {
            return _netflixShows;
        }

        public void RemoveShowFromList(Netflix show)
        {
            _netflixShows.Remove(show);
        }

        public Netflix FindShowByName(string name)
        {
            Netflix show = new Netflix();

            foreach (Netflix netflixShow in _netflixShows)
            {
                if (name == netflixShow.Title) 
                    show = netflixShow;
                break;
            }


            return show;
        }

        public List<Netflix> FindListOfShowByRating(string rating)
        {
            List<Netflix> shows = new List<Netflix>();

            foreach ( Netflix netflixShows in _netflixShows)
            {
                if (rating == netflixShows.Rating)
                {
                    shows.Add(netflixShows);

                }

            }
            return shows;
        }

        public List<Netflix> FindListByStarRating(int starrating)
        {
            List<Netflix> shows = new List<Netflix>();

            foreach (Netflix netflixShows in _netflixShows)
            {
                if (starrating == netflixShows.StarRating)
                    shows.Add(netflixShows);
            }

            return shows;
        }



    }
}
