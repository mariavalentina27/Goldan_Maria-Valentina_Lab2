﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Goldan_Maria_Valentina_lab2.Models
{
    public class Member
    {   
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu majuscula.")]
        [StringLength(30, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Numele trebuie sa inceapa cu majuscula.")]
        [StringLength(30, MinimumLength = 3)]
        public string? LastName { get; set; }

        [StringLength(70)]
        public string? Adress { get; set; }
        public string Email { get; set; }

        [RegularExpression(@"^\(?([0]{1})([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123'")]

        public string? Phone { get; set; }
        
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Borrowing>? Borrowings { get; set; }

    }
}
