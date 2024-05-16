using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models;

public class Category {
    [Key]
    [Required(ErrorMessage = "Informe o Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    public string Name { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = new();

    public Category(){}

    public Category(int id, string name) {
        Id = id;
        Name = name;
    }
}
