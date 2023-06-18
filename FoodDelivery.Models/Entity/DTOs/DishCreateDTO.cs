﻿using FoodDelivery.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Models.Entity.DTOs
{
    public class DishCreateDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        //public short Amount { get; set; }
        public Category Category { get; set; }
    }
}