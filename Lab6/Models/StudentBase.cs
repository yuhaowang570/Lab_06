using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class StudentBase
    {
        [Required]
        [DisplayName("First Name")]
        [StringLength(50, MinimumLength = 1)]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(50, MinimumLength = 1)]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Program
        {
            get;
            set;
        }
    }
}
