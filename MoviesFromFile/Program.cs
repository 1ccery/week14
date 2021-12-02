using System;
using System.Collections.Generic;
using System.IO;


namespace MoviesFromFile
{
    class Program
    {
        class Movie
        {
            string title;
            string rateing;
            string year;
        }
        public Movies(string _title, string _rateing, string _year)
        {
            title = _title;
            rateing = _rateing;
            year = _year;
        }

        public string Title
        {
            get { return title; }
        }
        public string Rateing
        {
            get { return rateing; }
        }
        public void Year
        {
            get { return year; }
        }
        static void Main(string[] args)
        {
            List<string> movielistfromfile = getMoviesFromFile().ToList();
            List<Movie> lisofMovies = new List<Movie>();

            foreach(string movieRecord in movielistfromfile)
            {
                string[] tempArray = movieRecord.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[3]);

                lostOfMovies.Add(newMovie);
            }
            foreach(Movie movie in lisofMovies)
            {
                Console.WriteLine($"Title: {movie.Title} - Rateing: {movie.Rateing} - Year: {movie.Year}");
            }
        }
        public static string[] getMoviesFromFile()
        {
            string filepath = @"C:\Users\opilane\samples\movies.txt";
            string[] datafromfile = File.ReadAllLines(filepath);
            return datafromfile;
                
        }
  
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach(string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
    
    
    
    }   
    
}
