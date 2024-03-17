using System;

namespace C__LR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            title.SetTitle("TitleN");
            Book myBook = new Book(title);
            
            myBook.SetAuthor("Ім'я автора");
            myBook.SetContent("Це зміст книги");


            myBook.Show();
        }
    }
}

