﻿using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFProject.Models
{
    [Table("Item")]
    public class Item
    {

        [Key]
        public int Item_Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Item_name { get; set; }

        public int? Item_price { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
