using BookStore.Tests;

////Console.WriteLine("------ Variable Start -------");
////string fullName = "Emri Mbiemri";
////int age = 20;
////Console.WriteLine($"Emri:{fullName} Mosha: {age}"); //string interpolation

////char gender = 'M';
////DateTime dob = DateTime.Now.AddDays(-20);

////var firstName = "Emri";
////var lastName = 10;
////Console.WriteLine("------ Variable End -------");

////Console.WriteLine("------ Class Start -------");

////var newBook = new Book();
////newBook.Id = 1;
////newBook.Title = "Book Title";
////Console.WriteLine($"Book Id: {newBook.Id} Title: {newBook.Title}");

////var secondBook = new Book(2, "Second Book");
////Console.WriteLine($"Book Id: {secondBook.Id} Title: {secondBook.Title}");

//using BookStore.Tests;

//var emriStudenti1 = "Studenti 01";
//var emriStudenti2 = "Studenti 02";
//var emriStudenti3 = "Studenti 03";
//var emriStudenti4 = "Studenti 04";
//var emriStudenti5 = "Studenti 05";

//Console.WriteLine("-------> CONSOLE <-------");
//Console.WriteLine(emriStudenti1);
//Console.WriteLine(emriStudenti2);
//Console.WriteLine(emriStudenti3);
//Console.WriteLine(emriStudenti4);
//Console.WriteLine(emriStudenti5);


//var emriStudenteve = new List<string>
//{
//    "Studenti 01",
//    "Studenti 02",
//    "Studenti 03",
//    "Studenti 04",
//    "Studenti 05"
//};

//Console.WriteLine("-------> FOR <-------");

//for (int i = 0; i < emriStudenteve.Count; i++)
//{
//    Console.WriteLine(emriStudenteve[i]);
//}

//Console.WriteLine("-------> FOREACH <-------");

//foreach (var emriStudentit in emriStudenteve)
//{
//    Console.WriteLine(emriStudentit);
//}


////Krijo nje liste per librat
//var libriIPreferuar = new Book(1, "Hyrje ne Statistike", 123);

//var libratEPreferuar = new List<Book> 
//{
//    new Book(1, "Hyrje ne Statistike", 123),
//    new Book(2, "Hyrje ne Matemetike", 345),
//    new Book(3, "Hyrje", 678)
//};

//Console.WriteLine("-------> FOREACH (LIBRAT) <-------");
//foreach (var libri in libratEPreferuar)
//{
//    Console.WriteLine($"Book Id: {libri.Id}, Title: {libri.Title}, Nr Faqeve: {libri.NrOfPages}");
//}

//string stopHere = "";


// Thirrje e klases jo-statike (metodes)

var newBook = new Book();
var newBookDetails = newBook.GetBookDetails("Algjebra Lineare", 20);
Console.WriteLine(newBookDetails);

// Thirrje e klases statike (metodes)
var authorFullName = Author.GetAuthorFullName("Emri", "Mbiemri");
Console.WriteLine(authorFullName);

var shuma = MathHelper.Add(1, 2);
Console.WriteLine(shuma);

string stopHere = "";
