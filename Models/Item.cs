using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Author { get; set; }
    }
}


//Model voor Item