﻿using InventoryManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Web.Models
{
    public class ItemRequestVM : ItemRequestCreateVM
    {
        public int Id { get; set; }

        [Display(Name = "Item Name")]
        public Product Product { get; set; }


        public int ProductQuantity { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
