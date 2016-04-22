using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilityMvc.ViewModels
{
    public class CreateProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
