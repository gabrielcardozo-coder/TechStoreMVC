using System.ComponentModel.DataAnnotations;

namespace TechStoreMVC.Models;

public class categorias
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
    public string Descricao { get; set; }
    


    public categorias(int id, string nome, string descricao)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
    }
        
}