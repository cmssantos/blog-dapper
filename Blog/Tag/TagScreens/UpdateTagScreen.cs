using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class UpdateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizando uma tag");
        Console.WriteLine("----------------");
        Console.WriteLine("Id: ");
        var id = Console.ReadLine()!;

        Console.WriteLine("Nome: ");
        var nome = Console.ReadLine()!;

        Console.WriteLine("Slug: ");
        var slug = Console.ReadLine()!;

        Update(new Tag { 
            Id = int.Parse(id),
            Name = nome, 
            Slug = slug 
        });

        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Update(Tag tag) {
        var repository = new Repository<Tag>(Database.Connection);
        
        try {
            repository.Update(tag);
            Console.WriteLine("Tag atualizada com sucesso!");
        }
        catch(Exception ex)
        {
             Console.WriteLine("Não foi possível atualizar a tag");
            Console.WriteLine(ex.Message);
        }
    }
}