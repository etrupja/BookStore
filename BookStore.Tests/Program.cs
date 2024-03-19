using BookStore.Tests;

Console.WriteLine("------ Variable Start -------");
string fullName = "Emri Mbiemri";
int age = 20;
Console.WriteLine($"Emri:{fullName} Mosha: {age}"); //string interpolation

char gender = 'M';
DateTime dob = DateTime.Now.AddDays(-20);

var firstName = "Emri";
var lastName = 10;
Console.WriteLine("------ Variable End -------");

Console.WriteLine("------ Class Start -------");

var newBook = new Book();
newBook.Id = 1;
newBook.Title = "Book Title";
Console.WriteLine($"Book Id: {newBook.Id} Title: {newBook.Title}");

var secondBook = new Book(2, "Second Book");
Console.WriteLine($"Book Id: {secondBook.Id} Title: {secondBook.Title}");

string stopHere = "";