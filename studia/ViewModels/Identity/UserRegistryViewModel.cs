using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class UserRegistryViewModel
    {
        
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [DisplayName("User Email")]
        public string UserEmail { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [DisplayName("User Password")]
        [Required]
        public string UserPassword { get; set; }
    }
}
