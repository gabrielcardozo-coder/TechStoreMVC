namespace TechStoreMVC.Models;

public class Categoria
{
    public int Id { get; set; } //get para obter um id = identificador
    //set para definir um id
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public bool Ativa { get; set; }


    public Categoria(int id, string nome, string descricao, bool ativa)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Ativa = ativa;
    }
}