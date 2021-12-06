using System;
using System.Collections.Generic;

class Author : Person
{
 private List<Book> BookList = new List<Book>();

 public Author() : base()
 {
 }

 public void DisplayInfo() 
 {
 }

 public void DisplayInfo(string fname, string lname)
 {
   Console.WriteLine(fname +" " +lname +". email: " +Email);
 }

 public void DisplayBooks()
 {
  foreach(Book b in BookList)
  {
    b.Display();
  }
 }

 public void AddBook(Book book)
 {
   Book bo = new Book();
   BookList.Add(book);
 }

 public void RemoveBook(string ISBN)
 {
 
 Book e = BookList.Find(o => o.ISBN == ISBN);
 BookList.Remove(e);
 }
 

 
}