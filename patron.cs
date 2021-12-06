using System;
using System.Collections.Generic;

class Patron : Person
{
  string LibraryId {get; set;}
  DateTime StartDate {get; set;}
  DateTime EndDate {get; set;}
  bool IsAccountActive {get; set;}
  double FineAmountDue {get; set;}
  
  List<Rental> RentalCart = new List<Rental>();

  public Patron(string fname, string lname, string id) : base (fname, lname, id)
  {
    FirstName = fname;
    LastName = lname;
    Id = id;
    FineAmountDue = 0.0;
    StartDate = DateTime.Today;
    IsAccountActive = true;
  }

  public void Display()
  {
  Console.WriteLine("Patron Id = " +Id +" Name = " +FirstName + " " +LastName);
  }

  public void AddToRentalCart(Book book, DateTime datedue)
  {
  Rental re = new Rental(book, DateTime.Today, datedue);
  RentalCart.Add(re);

  Console.WriteLine("Added to rental cart " +book.Title +" for Patron " +FirstName +" " +LastName);

  }

  public void RemoveFromRentalCart(Book boo)
  {

  Rental r = RentalCart.Find(o => o.Book == boo);
  RentalCart.Remove(r);

  Console.WriteLine("Removed from rental cart " +boo.Title +" for Patron " +FirstName +" " +LastName);

  }


}