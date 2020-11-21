using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Models
{
    public class Student : StudentBase
    {       
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Display(Name = "VIN Number")]
            public Guid ID { get; set; }
        
    }
}
