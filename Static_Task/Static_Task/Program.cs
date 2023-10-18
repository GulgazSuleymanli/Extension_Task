using Static_Task.Models;

namespace Static_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1_Call
            //int a = 8;
            //Console.WriteLine(a.IsPrime());
            //Console.WriteLine(a.IsPowOfTwo());
            #endregion

            #region Console_App
            //bool check=true;
            //Book[] books=new Book[0];
            //Library library = new Library(8);
            //do
            //{
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine("====== Operation Menyu ======");
            //    Console.WriteLine("1 - Show all books");
            //    Console.WriteLine("2 - Add new book");
            //    Console.WriteLine("3 - Search book by id");
            //    Console.WriteLine("4 - Exit");
            //    Console.WriteLine("-----------------------------");

            //    string imput = Console.ReadLine();

            //    switch (imput)
            //    {
            //        case "1":
            //            if(library != null)
            //            {
            //                foreach (var item in books)
            //                {
            //                    item.ShowInfo();
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please, first add book");
            //            }
            //            break;

            //        case "2":
            //            Console.WriteLine("Insert name of book");
            //            string name = Console.ReadLine();

            //            Console.WriteLine("Insert price of book");
            //            double price = double.Parse(Console.ReadLine());

            //            Console.WriteLine("Insert author name of book");
            //            string authorname= Console.ReadLine();

            //            Console.WriteLine("Insert page count of book");
            //            int count=int.Parse(Console.ReadLine());

            //            Book book = new Book(name, price, authorname, count);

            //            library.AddBook(book);

            //            Console.WriteLine("Book added to library");
            //            break;

            //        case "3":
            //            if (library != null)
            //            {
            //                Console.WriteLine("Insert search by id");
            //                int id = int.Parse(Console.ReadLine());
            //                library.GetBookById(id);
            //            }
            //            break;

            //        case "4":
            //            check=false; 
            //            break;
            //    }
            //}
            //while (check); 
            #endregion

            //Book book = new Book("White teeth", 18.80, "Jack London", 321);
            //book.Sell(2);
            //Console.WriteLine(Book.TotalInCome);
            //book.ShowInfo();

            //Library library = new Library(8);
            //library.AddBook(book);
            //Book books=library.GetBookById(1);
            //Console.WriteLine(books.Name);
        }
    }
}