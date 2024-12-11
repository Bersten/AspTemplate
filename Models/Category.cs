using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercice.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relation avec Product
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
