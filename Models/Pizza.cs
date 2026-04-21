namespace ContosoPizza.Models;

public class Pizza
{
    public int Id { get; set; } = 0;
    public string? Name { get; set; } = string.Empty;
    public bool IsGlutenFree { get; set; }
}