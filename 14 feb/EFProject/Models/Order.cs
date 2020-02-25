using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text;

namespace EFProject.Models
{

    [Table("Order")]
    public class Order
    {
        [Key]
        public int Order_id { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? OrderDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DeliveryDate { get; set; }
        public int Item_Id { get; set; }
        [ForeignKey("Item_Id")]
        public Item Item { get; set; }
    }
}
