using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace courseWork
{
    public class List_of_films
    {
        public List<Film> Movies = new List<Film>();

        public List<Film> searched = new List<Film>();

        public void Addition (string Title, string Company, string Year, string Genre, string Duration, string Format, string Quality, string Director)
        {
            Movies.Add(new Film(Title, Company, Year, Genre, Duration, Format, Quality, Director));
        }

        public void Search(string text)
        {
            foreach (Film item in Movies)
            {
                if ((item.ToString()).Contains(text))
                {
                    searched.Add(item);
                }
            }

        }
        //public void Search()

        public void Sort(int i)
        {
            switch (i)
            {
                case 0: { Movies.Sort(delegate(Film a, Film b) { return a.Title.CompareTo(b.Title); }); break; }
                case 1: { Movies.Sort(delegate(Film a, Film b) { return a.Company.CompareTo(b.Company); }); break; }
                case 2: { Movies.Sort(delegate(Film a, Film b) { return a.Year.CompareTo(b.Year); }); break;}
                case 3: { Movies.Sort(delegate(Film a, Film b) { return a.Genre.CompareTo(b.Genre); }); break;}
                case 4: { Movies.Sort(delegate(Film a, Film b) { return (Convert.ToInt32(a.Duration)).CompareTo(Convert.ToInt32(b.Duration)); });  break;}
                case 5: { Movies.Sort(delegate(Film a, Film b) { return a.Format.CompareTo(b.Format); });  break;}
                case 6: { Movies.Sort(delegate(Film a, Film b) { return a.Quality.CompareTo(b.Quality); });  break;}
                case 7: { Movies.Sort(delegate(Film a, Film b) { return a.Director.CompareTo(b.Director); });  break;}
            }
        }

        public void Delete(int index)
        {
            Movies.RemoveAt(index);
        }

        public void Save_to_XML()
        {
            using (var writer = new FileStream("Films.xml", FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Film>), new XmlRootAttribute("Film"));
                ser.Serialize(writer, Movies);
                writer.Close();
            }
        }

        public void Read_from_XML()
        {
            using (var reader = new StreamReader("Films.xml"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Film>), new XmlRootAttribute("Film"));
                Movies = (List<Film>)deserializer.Deserialize(reader);
            }
        }
    }
}

