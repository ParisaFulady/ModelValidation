using Microsoft.AspNetCore.Mvc;
using ModelValidation.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Models
{
    public class Appointmen
    {
       [Remote("ValidateUserName", "Home")]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string ClientName { get; set; }
        [UIHint("Date")]
        public DateTime Date { get; set; }
        [MustBeTrue(ErrorMessage = "asdfsadfsdf", IsRequired = true)]
        public bool TermsAccepted { get; set; }
    }
}
