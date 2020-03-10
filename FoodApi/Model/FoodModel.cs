using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApi.Model
{
    public class FoodModel
    {
        public string Name { get; set; }

        public int Weight { get; set; }
    }

    public class PotatoModel: FoodModel
    {
        public int Amount { get; set; }
    }
}
