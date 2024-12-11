using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercice.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        // Clé étrangère vers Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
