



namespace TechStoreMVC.Models;

public class CategoriasDB
{
    //Passo 01- Criar os dados de produtos/trazer do Controller
    //Método que vai listar novos objetos de um produto
    //e armazená-los na variável
    private static readonly List<categorias> categorias = new()
    {
        new categorias(1, "Computador Gamer", ""),  
        new categorias(2, "Periféricos", ""),  
        new categorias(3, "Eletrônicos", ""),  
        new categorias(4, "Monitores", ""),
    };

    //Passo 02- Criar métodos do Crud e remover regra d negocio do controller
    //Responsabilidade do Listar: Devolver/mostrar os produtos. Igual ao Index
    //Controller

    public List<categorias> Listar()
    {
        return categorias;
    }

    public categorias? buscarPorId(int id)
    {
        return categorias.FirstOrDefault(
            categoria => categoria.Id == id
        );
    }
    public void Adicionar(categorias categoria)
    {
        categoria.Id = categorias.Count + 1;
        categorias.Add(categoria);
    }

    public bool Atualizar(categorias produtoAtualizado)
    {
        return true;
    }

    public bool Excluir(int id)
    {
        categorias? categoria = buscarPorId(id);
        if(categoria is null)
        return false;
        categorias.Remove(categoria);

        return true;
    }
}