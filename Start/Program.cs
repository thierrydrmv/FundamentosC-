// using responsável pela importação e organização da aplicação
// Tudo entre as chaves está no escopo do namespace Start
// Não podem ter duas classes dentro do mesmo namespace com o msm nome
namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Carlos = new Person("Carlos", 22, "1.70");
            Console.WriteLine(Carlos.name);
        }
    }
}
