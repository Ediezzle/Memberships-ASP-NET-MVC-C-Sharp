﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("Subscription")]
    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //value incremented for each row added to the table, will be a Primary Key  and cannot be nullable
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Tittle { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(20)]
        public string RegistrationCode { get; set; }


    }
}