using System;
namespace GraphQLAssignment.Model
{

    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class StarwarsApi
    {
        public string title { get; set; }
        public string director { get; set; }
        public string id { get; set; }
        public string releaseDate { get; set; }

        public string directorAndreleaseDate { get { return "Director  " +director + "|| Release Date  " + releaseDate + "||ID-" + id; } }

    }



    //public partial class Data
    //{
    //    public allFilms allFilms { get; set; }
    //}

    //public partial class allFilms
    //{
    //    public List<Film> Films { get; set; }
    //}

    //public partial class Film
    //{

    //}
}
