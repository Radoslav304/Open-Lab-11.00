using System;

namespace Open__Lab_11._00
{

    class Library
    {

        public int numberOfStudents;
        public int numberOfBooks = 4;

        public void NumberOfStudents()
        {
            numberOfStudents = StudentsList.Length;
        }


        public string[] StudentsList { get; set; } = new string[2] { "", "" };
        public string[] BooksList = new string[4] { "", "", "", "" };
        public string[] BorrowList = new string[4] { "", "", "", "" };
        public string Borrowedby;
        public string Borrowedbook;

        public void borrow(string borrowedbook, string borrowedby)
        {

            Borrowedby = borrowedby;
            Borrowedbook = borrowedbook;
            BorrowList[numberOfBooks] = borrowedbook + " borrowed by " + borrowedby;
            BooksList[numberOfBooks] = borrowedbook;
            numberOfBooks++;
        }

        public override string ToString()
        {
            string output = "";

            output = ("Number of books in library:" + numberOfBooks);
            output += ("Number of students in library:" + numberOfStudents);
            output += ("Names of students who have borrowed our books:");
            foreach (string student in StudentsList)
            {
                output += (student);
            }
            output += ("Tites of books:");
            foreach (var title in BooksList)
            {
                output += (title);
            }
            return output;
        }



    }
}