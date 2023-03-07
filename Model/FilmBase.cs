using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    internal class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Viewers { get; set; }
        public ICollection<Director> Director { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<Country> Countries { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public Film()
        {
            Director = new List<Director>();
            Genres = new List<Genre>();
            Languages = new List<Language>();
            Countries = new List<Country>();
            Actors = new List<Actor>();
        }
    }
    internal class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
        public Genre()
        {
            Films = new List<Film>();
        }
    }

    internal class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
        public Language()
        {
            Films = new List<Film>();
        }
    }
    internal class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Film> Films { get; set; }
        public Country()
        {
            Films = new List<Film>();
        }
    }
    internal class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string City { get; set; }
        public int Wealth { get; set; }
        public ICollection<Film> Films { get; set; }
        public Actor()
        {
            Films = new List<Film>();
        }
    }
    internal class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string City { get; set; }
        public int Wealth { get; set; }
        public ICollection<Film> Films { get; set; }
        public Director()
        {
            Films = new List<Film>();
        }
    }
}
