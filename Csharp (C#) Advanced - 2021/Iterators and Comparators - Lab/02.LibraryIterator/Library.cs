﻿
namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }


        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibracyIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibracyIterator : IEnumerator<Book>
        {

            private readonly List<Book> books;
            private int currentIndex;
            public LibracyIterator(List<Book> books)
            {
                this.Reset();
                this.books = new List<Book> ( books );
            }
            public Book Current => this.books[this.currentIndex];
            object IEnumerator.Current => this.currentIndex;
            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }

        }
    }
}
