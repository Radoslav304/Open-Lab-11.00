using System;

namespace Open_Lab__10._03
{
    class Program
    {

        static void Main(string[] args)
        {
            Book Lotr = new Book();
            Book Lotr2 = new Book();
            Book Lotr3 = new Book("Janko Hraško", 12);
            Book HOBIT = new Book("Janko Hraško", 12, "Mária Ďuríčková", 2014);
            Lotr.Title = "Janko Hraško";
            Lotr.Pages = 12;
            Lotr.Category = "fairy tale";
            Lotr.Autor = "Mária Ďuríčková";
            Lotr.ReleaseDate = 2014;
            Lotr.ToString();
            Console.WriteLine(Lotr.ToString());



        }