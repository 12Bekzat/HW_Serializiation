using Seriazialation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HW_Serializiation
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Book> books = new List<Book>()
      {
        new Book {
          Name = "Robinzon Kruzo",
          Price = 1000,
          Author = "Daniel Defo",
          Year = 1719,
        },
        new Book {
          Name = "Harry Potter",
          Price = 1500,
          Author = "JK Rowling",
          Year = 2000,
        },
        new Book {
          Name = "A Little Life",
          Price = 3000,
          Author = "Hanya Yanagihara",
          Year = 2015,
        },
        new Book {
          Name = "Darkmans",
          Price = 1300,
          Author = "Nicola Barker",
          Year = 2007,
        },
        new Book {
          Name = "Bad Blood",
          Price = 2000,
          Author = "Lorna Sage",
          Year = 2000,
        },
      };

      var serializier = new BinaryFormatter();

      using (var stream = File.OpenWrite("Book.bin"))
      {
        serializier.Serialize(stream, books);
      }
    }
  }
}
