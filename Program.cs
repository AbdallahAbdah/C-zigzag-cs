// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http.Headers;

public class Books
{

    public int id;
    public string title;
    public string auther;
    public int publishYear;
    public Books(int id,string title,string auther,int pY)
    {
    
    this.id = id;
    this.title = title;
    this.auther = auther;
    this.publishYear = pY;
    }
    public Books() { }
}

public class Library : Books
{
 private List <Books> books= new List<Books> ();

    public void addBook (int id, string title, string auther, int pY) { Books book = new Books(id,title,auther,pY);  books.Add (book); }
    public void displayBooks() { foreach (Books i in books) { Console.WriteLine("ID : "+i.id+" \tTitle : "+i.title+" \tAuther : "+i.auther+" \tPublished in : "+i.publishYear); } }

    static void Main(string[] args)
    {
        Library myLib = new Library();
        myLib.addBook(10,"Sugar","Abdah",2023);
        myLib.displayBooks();
    }
}

