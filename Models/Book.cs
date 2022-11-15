﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Goldan_Maria_Valentina_lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display (Name = "Book Title")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul cartii trebuie sa aiba mai mult de 3 caractere.")]

        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        [Column (TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType (DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
