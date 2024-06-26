﻿
namespace NoteBook.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }

    }
}