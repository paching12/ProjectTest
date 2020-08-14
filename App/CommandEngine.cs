using System;
using System.Collections.Generic;
using projectTest.Entities;
using projectTest.Util;

namespace projectTest.App
{
    public class CommandEngine
    {
        public List<TvShow> shows { get; set; }

        /*
        *   This method initialize TV Shows and sort them
        *   @params int quanity
        */
        public void init(int quantity = 5)
        {

            shows = new List<TvShow>();

            if (quantity > 10)
            {
                System.Console.WriteLine("Not enough TV Shows");
                return;
            }
            // Shows
            string[] showsName = { "Malcolm in the Middle", "Dragon Ball", "How I Met Your Mother",
                               "Dr. House", "The Mentalist", "Stranger Things",
                               "Game Of Thrones", "Dark", "Modern Love",
                               "\"El chavo del 8\"" };

            for (int i = 0; i < quantity; i++)
                shows.Add(new TvShow(i, showsName[i]));

            shows.Sort( (x, y) => x.name.CompareTo(y.name) );

        }

        /*
        *   This method checks/uncheck a favorite show
        *   @params int id
        */
        public void CheckFav(int id)
        {
            var show = shows.Find(show => show.id == id);
            if( show != null )
                show.favorite = !show.favorite;

        }

        /*
        *   This method prints all of the TV Shows
        *   @params void
        */
        public void PrintTvShows()
        {
            Printer.DrawTitle("List TV Shows");

            foreach (var show in shows)
                System.Console.WriteLine($"Name: { show.name }, Id: { show.id } " + (show.favorite ? "*" : ""));
        }

        /*
        *   This method prints all of the favorite TV Shows
        *   @params int quanity
        */
        public void PrintTvShowsFav()
        {
            Printer.DrawTitle("List favorite TV Shows");

            
            List<TvShow> favShows = shows.FindAll( show => show.favorite == true );

            if( favShows.Count == 0 ) {
                System.Console.WriteLine("Not Favorite TV Shows");
                return;
            }


            foreach (var show in shows)
                if( show.favorite )
                    System.Console.WriteLine($"Name: { show.name }, Id: { show.id } ");
        }

    }
}