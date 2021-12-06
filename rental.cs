using System;
using System.Collections.Generic;

class Rental
{
public Book Book {get; set;}
DateTime DateRented {get; set;}
DateTime DateDue {get; set;}



public Rental(Book book, DateTime daterented, DateTime datedue) 
{
Book = book;
DateRented = daterented;
DateDue = datedue;
}
} 