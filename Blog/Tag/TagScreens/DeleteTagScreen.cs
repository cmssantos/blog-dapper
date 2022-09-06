using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class DeleteTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir uma tag");
        Console.WriteLine("----------------");
        Console.WriteLine("Qual o id da Tag que deseja excluir? ");
        var id = Console.ReadLine()!;

        Delete(int.Parse(id));

        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Delete(int id) {
        var repository = new Repository<Tag>(Database.Connection);
        
        try {
            repository.Delete(id);
            Console.WriteLine("Tag excluída com sucesso!");
        }
        catch(Exception ex)
        {
             Console.WriteLine("Não foi possível excluir a tag");
            Console.WriteLine(ex.Message);
        }
    }
}