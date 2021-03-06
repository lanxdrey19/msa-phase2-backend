﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AislesAPI.Models
{
    public class Aisle
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AisleID { get; set; }

        [Required]
        public string AisleName { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
    }
}
