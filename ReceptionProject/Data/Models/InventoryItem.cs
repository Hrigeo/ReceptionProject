﻿using System.ComponentModel.DataAnnotations;

namespace ReceptionProject.Data.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
