using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LR_3
{
    internal class Content
    {
        private string content;

        public void SetContent(string bookContent)
        {
            content = bookContent;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Зміст: {content}");
            Console.ResetColor();
        }
    }
}
