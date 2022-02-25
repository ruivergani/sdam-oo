using System;

public class Book
{
	public string title;
	public string author;
	public string pages;

	public Book() // you can use the class normal with the constructor or not
    {

    }

	public Book(string name) // constructor method
	{
		Console.WriteLine(name + " has created a book.");
	}

}
