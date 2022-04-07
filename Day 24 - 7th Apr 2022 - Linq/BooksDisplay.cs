using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24___7th_Apr_2022___Linq
{
    public class BooksDisplay
    {
        List<Book> books = new List<Book>()
        {
            new Book() {bookId =1,author = "JKRowling" ,title = "HarryPotter" , price = 500},
            new Book() {bookId =2,author = "Chetan Bhagat" ,title = "2 States" , price = 800},
            new Book() {bookId =3,author = "Lewis Carooll" ,title = "Alice in the wonderland" , price = 600},
            new Book() {bookId =4,author = "Richard Button" ,title = "ArabianNights" , price = 400},
            new Book() {bookId =5,author = "Artahshastra" ,title = "Kautilya" , price = 900}
        };

        public void DisplayAll()
        {
            //Display all the data.
            var res = books.Select(y => y);
            res.ToList().ForEach(x => Console.WriteLine(x.title + " " + x.author + " " + x.bookId + " " + x.price));
            Console.WriteLine("\n");

            //Display books by a particular author
            Book ba = books.Find(x => x.author == "JKRowling");
            Console.WriteLine(ba.title + " " + ba.author + " " + ba.bookId + " " + ba.price);
            Console.WriteLine("\n");


            //Display books by Price lowest to highest value
            var os = books.Select(y => y).OrderBy(x => x.price);
            os.ToList().ForEach(x => Console.WriteLine(x.title + " " + x.author + " " + x.bookId + " " + x.price));
            Console.WriteLine("\n");


            //Display books by Authors in Ascending order – show Author Name Book Title
            var ob = books.Select(y => y).OrderBy(x => x.author);
            ob.ToList().ForEach(x => Console.WriteLine(x.title + " " + x.author ));

            Console.ReadLine();
           

        }
    }
}
