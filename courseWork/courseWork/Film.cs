using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace courseWork
{
    public class Film ///: IComparable
    {
        
        public string Title { get; set; }

        public string Company { get; set; }

        public string Year { get; set; }

        public string Genre { get; set; }

        public string Duration { get; set; }

        public string Format { get; set; }

        public string Quality { get; set; }

        public string Director { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", Title, Company, Year, Genre, Duration, Format, Quality, Director);
        }

        public Film()
        {
 
        }

        public Film (string Title, string Company, string Year, string Genre, string Duration, string Format, string Quality, string Director)
        {
            this.Title = Title;
            this.Company = Company;
            this.Year = Year;
            this.Genre = Genre;
            this.Duration = Duration;
            this.Format = Format;
            this.Quality = Quality;
            this.Director = Director;
        }

        //public int CompareTo(object obj)
        //{
        //     return this.Title.CompareTo((obj as Film).Title); 
        //}
    }
}
     