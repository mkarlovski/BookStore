﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public string Author { get; set; }
        [Required]

        public string Genre { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]

        public decimal Price { get; set; }

    }
}
