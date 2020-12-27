﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    

    public class Library : IEnumerable<Book>
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        

        private class LibraryIterator : IEnumerator<Book>
        {
            public LibraryIterator(List<Book> books)
            {
                this.Books = books;
                this.Books.Sort(new BookComparator());
            }

            private int index = -1;
            public List<Book> Books { get; set; }

            public Book Current => Books[index];

            object IEnumerator.Current => Books[index];

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++index < Books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
