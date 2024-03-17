using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LR_3
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title)
        {
            this.title = title;
            author = new Author();
            content = new Content();
        }

        public Title GetTitle()
        {
            return title;
        }

        public void SetAuthor(string authorName)
        {
            author.SetAuthor(authorName);
        }

        public void SetContent(string bookContent)
        {
            content.SetContent(bookContent);
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
