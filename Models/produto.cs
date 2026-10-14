namespace TechStoreMVC.Models;

public class Produto
{
    public int Id { get; set; } //get para obter um id = identificador
    //set para definir um id
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }


    public Produto(int id, string nome, decimal preco, int estoque)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}