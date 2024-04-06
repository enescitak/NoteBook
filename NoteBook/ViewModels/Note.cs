using System;
using System.ComponentModel.DataAnnotations.Schema;
using NoteBook.Models;

namespace NoteBook.ViewModels
{
	public class Note
	{
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

    }
}