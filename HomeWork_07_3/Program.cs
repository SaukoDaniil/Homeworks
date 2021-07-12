using System;
using System.Collections.Generic;

namespace HomeWork_07_3
{
   
    class Movie
    {
        public string title;
        public string category;
        public string director;
        public string mainActor;
        public string mainActress;
        public string code;
        public int length;
        public Movie(string movie_title, string movie_category, string movie_director, string movie_mainActor, string movie_mainActress, string movie_code, int movie_length)
        {
            title = movie_title;
            category = movie_category;
            director = movie_director;
            mainActor = movie_mainActor;
            mainActress = movie_mainActress;
            code = movie_code;
            length = movie_length;
        }
    }
    class Music
    {
        public string title;
        public string category;
        public string singer;
        public string code;
        public int length;
        public int size;
        public Music(string music_title, string music_category, string music_singer, string music_code, int music_length, int movie_size)
        {
            title = music_title;
            category = music_category;
            singer = music_singer;
            code = music_code;
            length = music_length;
            size = movie_size;
        }
     }
    class Videogames
    {
        public string title;
        public string category;
        public string developer;
        public string code;
        public int size;
        public Videogames(string videogames_title, string videogames_category, string videogames_developer, string videogames_code,  int videogames_size)
        {
            title = videogames_title;
            category = videogames_category;
            developer = videogames_developer;
            code = videogames_code;
            size = videogames_size;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Movie homeAlone = new Movie("Home Alone", "Comedy", "Chris Columbus", "Macaulay Culkin", "Catherine O'Hara", "BSW-00-2403", 103);
          
            var movieData = new List<string>();
            movieData.Add(homeAlone.title);
            movieData.Add(homeAlone.category);
            movieData.Add(homeAlone.director);
            movieData.Add(homeAlone.mainActor);
            movieData.Add(homeAlone.mainActress);
            movieData.Add(homeAlone.code);
            _ = movieData.ToArray();

            Music music0 = new Music("Desert Rose", "Pop", "Sting", "Macaulay Culkin", 190, 6381);

            var musicData = new List<string>();
            movieData.Add(music0.title);
            movieData.Add(music0.category);
            movieData.Add(music0.singer);
            movieData.Add(music0.code);
            _ = musicData.ToArray();

            Videogames game0 = new Videogames("The Sims 2", "Simulator", "Electronic Arts", "G4ZE69", 18540509);

            var gameData = new List<string>();
            gameData.Add(game0.title);
            gameData.Add(game0.category);
            gameData.Add(game0.developer);
            gameData.Add(game0.code);
            _ = gameData.ToArray();
        }
    }
}