using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Models; 

public class Product {
    [Key]
    [Required(ErrorMessage = "Informe o Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")] 
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe a Descrição")] 
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe a Imagem")] 
    public string Image { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o Preço")]
    public double Price { get; set; } 
    
    public int CategoryId { get; set; }

    public Category Category { get; set; } = new();

    public Product() { }

    public Product(int id, string name, string description, string image, 
        double price, int categoryId) {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
        Price = price;
        CategoryId = categoryId;
    }
}
