using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class UserLogInViewModel 
    {
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [DisplayName("User Password")]
        [Required]
        public string UserPassword { get; set; }

    }
}