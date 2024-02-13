// using responsável pela importação e organização da aplicação
// Tudo entre as chaves está no escopo do namespace Start
// Não podem ter duas classes dentro do mesmo namespace com o msm nome
namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Carlos = new Person("Carlos", 22, 1.70);
            //Carlos.talk();
            //Console.WriteLine(variavel());
            //constante();
            //palavrasReservadas();
            //exbyte();
            numerosReais();
            boolean();
            character();
            exstring();
            var();
            objecT();
        }

        static int variavel()
        {
            //int idade;
            int idade2 = 25;
            var idade3 = 21;
            //var idade4; Errado
            return idade2 + idade3;
        }

        static void constante()
        {
            const int IDADE = 11;
            //const var IDADE2 = 2; variaveis implicitas n podem ser const
            Console.WriteLine(IDADE % 2);
        }

        static void palavrasReservadas()
        {
            string reference = "https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/";
            Console.WriteLine("\r\n\r\nabstract\r\nas\r\nbase\r\nbool\r\nbreak\r\nbyte\r\ncase\r\ncatch\r\nchar\r\nchecked\r\nclass\r\nconst\r\ncontinue\r\ndecimal\r\ndefault\r\ndelegate\r\ndo\r\ndouble\r\nelse\r\nenum\r\n\r\nevent\r\nexplicit\r\nextern\r\nfalse\r\nfinally\r\nfixed\r\nfloat\r\nfor\r\nforeach\r\ngoto\r\nif\r\nimplicit\r\nin\r\nint\r\ninterface\r\ninternal\r\nis\r\nlock\r\nlong\r\n\r\nnamespace\r\nnew\r\nnull\r\nobject\r\noperator\r\nout\r\noverride\r\nparams\r\nprivate\r\nprotected\r\npublic\r\nreadonly\r\nref\r\nreturn\r\nsbyte\r\nsealed\r\nshort\r\nsizeof\r\nstackalloc\r\n\r\nstatic\r\nstring\r\nstruct\r\nswitch\r\nthis\r\nthrow\r\ntrue\r\ntry\r\ntypeof\r\nuint\r\nulong\r\nunchecked\r\nunsafe\r\nushort\r\nusing\r\nvirtual\r\nvoid\r\nvolatile\r\nwhile\r\n\r\n\r\nadd\r\nand\r\nalias\r\nascending\r\nargs\r\nasync\r\nawait\r\nby\r\ndescending\r\ndynamic\r\nequals\r\nfile\r\nfrom\r\n\r\nget\r\nglobal\r\ngroup\r\ninit\r\ninto\r\njoin\r\nlet\r\nmanaged (function pointer calling convention)\r\nnameof\r\nnint\r\nnot\r\n\r\nnotnull\r\nnuint\r\non\r\nor\r\norderby\r\npartial (type)\r\npartial (method)\r\nrecord\r\nremove\r\nrequired\r\nscoped\r\n\r\nselect\r\nset\r\nunmanaged (function pointer calling convention)\r\nunmanaged (generic type constraint)\r\nvalue\r\nvar\r\nwhen (filter condition)\r\nwhere (generic type constraint)\r\nwhere (query clause)\r\nwith\r\nyield\r\n");
        }

        static void comentarios()
        {
            // Comentário em uma linha
            /*Comentário em várias
            linhas*/

            /// Notação XML (metadata) -> Dados adicionais
        }

        static void exbyte()
        {
            byte valor1 = 122;
            sbyte valor2 = -12;

            Console.WriteLine(valor2 + valor1);
        }

        static void inteiro()
        {
            // u = unsigned -> só pode ser positivo
            //short/ushort 
            //int/uint -> valor padrão se usar var
            //long/ulong
        }

        static void numerosReais()
        {
            // float (notação F)
            float salario = 2.222f;
            // double -> valor padrão se usar var
            double salario2 = 2.131;
            // decimal (notação M)
            decimal salario3 = 2.222m;
            Console.WriteLine($"{salario}, {salario2}, {salario3}");
        }

        static void boolean()
        {
            bool verdadeiro = true;
            bool falso = false;
            Console.WriteLine($"{ verdadeiro} ou { falso }");
        }

        static void character()
        {
            char inicial = 'T';
            Console.WriteLine(inicial);
        }

        static void exstring()
        {
            string nome = "Thierry";
            Console.WriteLine(nome);    
        }

        static void var()
        {
            // Quando a variável é instanciada seu tipo é estipulado
            // e não pode ser alterado
            var nome = "Galileu";
            nome = "Roberto";
            //nome = 11; -> erro
            Console.WriteLine(nome);
        }

        static void objecT()
        {
            // object é um tipo genérico que recebe qualquer valor ou objeto
            object idade = 25; // será do tipo object
            idade = "Vinte e cinco";
            Console.WriteLine(idade);
        }

        static void nulo()
        {
            // void -> vazio/sem retorno
            // null -> vazio/tipo(pode ser nulo)
            int? idade = null;
            Console.WriteLine(idade); // null é vazio (n aparece no log)
        }
    }
}
