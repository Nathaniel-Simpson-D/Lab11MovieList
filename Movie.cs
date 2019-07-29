using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11MovieList_NateS
{
    public class Movie
    {
        #region Field
        private string movieName;
        private string catagorie;
        #endregion
        #region Properties
        //Constructors
        public Movie()
        {

        }
        public Movie(string title, string type)
        {
            this.movieName = title;
            this.catagorie = type;
        }
        public string Title
        {
            get
            {
                return movieName;
            }
            set
            {
                movieName = value;
            }
        }
        public string Genre
        {
            get
            {
                return catagorie;
            }
            set
            {
                catagorie = value;
            }
        }
           


        #endregion
    }
}
