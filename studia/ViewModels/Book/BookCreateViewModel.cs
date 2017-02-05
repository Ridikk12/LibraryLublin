using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.ViewModels.Book
{
    public class BookCreateViewModel
    {
        [Required]
        [DisplayName("Name")]
        public string BookName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        [DisplayName("Number of page")]
        public int BookSize { get; set; }
        [Required]
        [DisplayName("Author")]
        public string BookAuthor { get; set; }
        [Required]
        [DisplayName("Publishing house")]
        public string PublishingHouse { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [DisplayName("Image")]
        public HttpPostedFileBase Image { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "The value must be greater than 0")]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
    }
}