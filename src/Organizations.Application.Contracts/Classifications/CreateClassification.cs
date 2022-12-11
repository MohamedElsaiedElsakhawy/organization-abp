using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Organizations.Classifications
{
    public class CreateClassification
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
