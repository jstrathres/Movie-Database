using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    public class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }

        //Constructor
        public Movie(string _title, string _category, string _year, string _runtime) 
        { 
        Title= _title;
        Category= _category;
        Year = _year;
        Runtime = _runtime;    
        }
        
        //Method
        public string GetDetails()
        {
            return Title;
        }
    }
}
