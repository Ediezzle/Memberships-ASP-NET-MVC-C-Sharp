﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("Part")]
    public class Part
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //value incremented for each row added to the table, will be a Primary Key  and cannot be nullable
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Tittle { get; set; }
    }
}