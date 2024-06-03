namespace atleag.Models;

public class Recipe
{
    public string Title { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Equipment { get; set; }
    public List<string> Steps { get; set; }
    public string Comment { get; set; }
    public List<string> Sources { get; set; }
}