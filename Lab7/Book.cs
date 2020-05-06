using System;

public class Book
{
	public String Title;
	public String Author;
	public int Year;
	public void Display()
	{
		Console.WriteLine($"Title: {Title}");
		Console.WriteLine($"Author: {Author}");
	}
	public Book()
	{
	}
}
