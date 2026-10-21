using System.ComponentModel.DataAnnotations;

namespace TechStoreMVC.Models;

public class Produto
{
    public int Id { get; set; } //get para obter um id = identificador
    //set para definir um id
    [Required(ErrorMessage ="informe o nome")]
    [StringLength(
        100,
        MinimumLength =3,
        ErrorMessage = "o nome deve possuir entre 3 a 100 caracteres."
        )]
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