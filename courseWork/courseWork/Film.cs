using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace courseWork
{
    public class Film 
    {
        
        public string Title { get; set; }

        public string Company { get; set; }

        public string Year { get; set; }

        public string Genre { get; set; }

        public string Duration { get; set; }

        public string Format { get; set; }

        public string Quality { get; set; }

        public string Director { get; set; }

        public string Picture_Type { get; set; }       

        [XmlIgnore]
        public Image Poster { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", Title, Company, Year, Genre, Duration, Format, Quality, Director);
        }

        public Film()
        {
 
        }

        public Film (string Title, string Company, string Year, string Genre, string Duration, string Format, string Quality, string Director, string Picture_Type, Image Poster)
        {
            this.Title = Title;
            this.Company = Company;
            this.Year = Year;
            this.Genre = Genre;
            this.Duration = Duration;
            this.Format = Format;
            this.Quality = Quality;
            this.Director = Director;
            this.Picture_Type = Picture_Type;
            this.Poster = Poster;
        }


    }
}
     