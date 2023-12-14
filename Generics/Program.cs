// See https://aka.ms/new-console-template for more information

using Generics;

SimplePerson simplePerson = new SimplePerson(546, "Tom");
ObjectPerson objectPerson = new ObjectPerson("abc123", "Bob");

int tomId = simplePerson.Id;
string bobId = (string) objectPerson.Id;

Console.WriteLine($"Tom ID: {tomId}"); 
Console.WriteLine($"Bob ID: {bobId}");