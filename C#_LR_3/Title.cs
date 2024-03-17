using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LR_3
{
    internal class Title
    {
        private string title;

        public void SetTitle(string bookTitle)
        {
            title = bookTitle;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Назва книги: {title}");
            Console.ResetColor();
        }
    }
}
