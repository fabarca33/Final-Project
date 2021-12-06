using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Author a1 = new Author();
    a1.DisplayInfo();

    Author a2 = new Author();
    a2.DisplayInfo();

    Book b1 = new Book("1", "book1", "Author 1", DateTime.Today, "Unknown");

    Book b2 = new Book("2", "book2", "Author 2", DateTime.Today, "Unknown");

    Book b3 = new Book("3", "book3", "Author 1", DateTime.Today, "Unknown");

    Book b4 = new Book("4", "Book4", "Author 2", DateTime.Today, "Unknown");

    Book b5 = new Book("5", "Book5", "Author 1", DateTime.Today, "Unknown");
    
    Book b6 = new Book("6", "Book6", "Author 2", DateTime.Today, "Unknown");

    a1.AddBook(b1);
    a1.AddBook(b3);
    a1.AddBook(b5);
    
    a1.DisplayBooks();    

    a2.AddBook(b2);
    a2.AddBook(b4);
    a2.AddBook(b6);

    a2.DisplayBooks();

    a1.RemoveBook("1");
    a1.DisplayBooks();


    Patron p1 = new Patron("Morty", "Smith", "10001");

    Patron p2 = new Patron ("Tony", "Stark", "10002");

    Patron p3 = new Patron ("Steve", "Rogers", "10003");

    Patron p4 = new Patron ("Natasha", "Romanov", "10004");

    Patron p5 = new Patron ("Obi-Wan", "Kenobi", "10005");
    

    p1.AddToRentalCart(b1, Convert.ToDateTime("12/20/2021"));

    p1.RemoveFromRentalCart(b3);

    p1.Display();

        

  }
}