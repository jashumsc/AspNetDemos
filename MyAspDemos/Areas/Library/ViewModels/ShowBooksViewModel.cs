﻿using MyAspDemos.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAspDemos.Areas.Library.ViewModels
{
    public class ShowBooksViewModel
    {
        [Display(Name = "Select Category:")]
        [Required(ErrorMessage = "Please select a category for displaying the books")]
        public int CategoryId { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}