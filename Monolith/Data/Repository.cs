﻿using Monolith.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monolith.Data
{
	public class Repository
	{
		private IEnumerable<Author> _authors { get; set; }
		private IEnumerable<Book> _books { get; set; }

		public Repository()
		{
			_authors = new[]
			{
				new Author
				{
					AuthorId = 1,
					Name = "John Doe"
				},
				new Author
				{
					AuthorId = 2,
					Name = "Jane Smith"
				}
			};

			_books = new[]
			{
				new Book
				{
					BookId = 1,
					AuthorId = 1,
					Name = "The Fallen Shore",
					NumberOfPages = 123
				},
				new Book
				{
					BookId = 2,
					AuthorId = 1,
					Name = "Harmony of Joy",
					NumberOfPages = 211
				},
				new Book
				{
					BookId = 3,
					AuthorId = 2,
					Name = "Aliens vs Robots",
					NumberOfPages = 345
				}
			};
		}

		public IEnumerable<Author> GetAuthors() => _authors;
		public IEnumerable<Book> GetBooks() => _books;
	}
}
