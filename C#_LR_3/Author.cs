using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LR_3
{
    internal class Author
    {
        private string author;

        public void SetAuthor(string authorName)
        {
            author = authorName;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Автор: {author}");
            Console.ResetColor();
        }
    }
}
