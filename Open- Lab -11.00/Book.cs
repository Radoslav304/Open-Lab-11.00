using System;

namespace Open_Lab__10._05
{

    class Book
    {
        /// <summary>
        /// created list with categories.
        /// </summary>
        public static List<string> categoryList = new List<string>
        {"detské", "romantické", "náučné", "sci-fi", "dobrodružné"};

        public string Title { get; set; }
        public string Category { private get; set; }
        public string Autor { get; set; }


        private int pages;
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }

        public int releaseDate;
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 1450 && value > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }



        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Autor = "-1";
            ReleaseDate = -1;
        }

        public Book(string title, int pages)
        {
            this.Title = title;
            this.Pages = pages;
            Category = "-1";
            Autor = "-1";
            ReleaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.Title = title;
            this.Pages = pages;
            this.Category = category;
            this.Autor = Autor;
            this.ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            string output = "";
            output = (Title);
            output += (Pages);
            output += (Category);
            output += (Autor);
            output += (ReleaseDate);
            return output;


        }
    }

}
