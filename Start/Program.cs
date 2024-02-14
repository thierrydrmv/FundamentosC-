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

            //EstruturaDeRepeticaoDoWhile();
            //var nome = RetornaNomeCompleto("Thierry", "Varela", 25);
            //var nome2 = RetornaNomeCompleto("Roberto", "Marins", 25);
            //Console.WriteLine(nome);
            //TiposDeValor();
            //TiposDeReferencia();
            Product cadeira = new Product();
            cadeira.Id = 1;
            cadeira.Price = 400.50;
            cadeira.Title = "Cadeira gamer";
            cadeira.Size = ESize.Medium;
            Product xicara = new Product(2, "Xícara preta", 25, ESize.Small);
            Console.WriteLine("Cadeira gamer: ");
            Console.WriteLine(cadeira.Size);
            Console.WriteLine((int)cadeira.Size);
            Console.WriteLine($"Preço em dolar: {cadeira.PriceInDolar(5)}");
            Console.WriteLine("Xícara preta: ");
            Console.WriteLine(xicara.Size);
            Console.WriteLine((int)xicara.Size);
            Console.WriteLine($"Preço em dolar: {xicara.PriceInDolar(5)}");
        }

        static int Variavel()
        {
            //int idade;
            int idade2 = 25;
            var idade3 = 21;
            //var idade4; Errado
            return idade2 + idade3;
        }

        static void Constante()
        {
            const int IDADE = 11;
            //const var IDADE2 = 2; variaveis implicitas n podem ser const
            Console.WriteLine(IDADE % 2);
        }

        static void PalavrasReservadas()
        {
            string reference = "https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/";
            Console.WriteLine("\r\n\r\nabstract\r\nas\r\nbase\r\nbool\r\nbreak\r\nbyte\r\ncase\r\ncatch\r\nchar\r\nchecked\r\nclass\r\nconst\r\ncontinue\r\ndecimal\r\ndefault\r\ndelegate\r\ndo\r\ndouble\r\nelse\r\nenum\r\n\r\nevent\r\nexplicit\r\nextern\r\nfalse\r\nfinally\r\nfixed\r\nfloat\r\nfor\r\nforeach\r\ngoto\r\nif\r\nimplicit\r\nin\r\nint\r\ninterface\r\ninternal\r\nis\r\nlock\r\nlong\r\n\r\nnamespace\r\nnew\r\nnull\r\nobject\r\noperator\r\nout\r\noverride\r\nparams\r\nprivate\r\nprotected\r\npublic\r\nreadonly\r\nref\r\nreturn\r\nsbyte\r\nsealed\r\nshort\r\nsizeof\r\nstackalloc\r\n\r\nstatic\r\nstring\r\nstruct\r\nswitch\r\nthis\r\nthrow\r\ntrue\r\ntry\r\ntypeof\r\nuint\r\nulong\r\nunchecked\r\nunsafe\r\nushort\r\nusing\r\nvirtual\r\nvoid\r\nvolatile\r\nwhile\r\n\r\n\r\nadd\r\nand\r\nalias\r\nascending\r\nargs\r\nasync\r\nawait\r\nby\r\ndescending\r\ndynamic\r\nequals\r\nfile\r\nfrom\r\n\r\nget\r\nglobal\r\ngroup\r\ninit\r\ninto\r\njoin\r\nlet\r\nmanaged (function pointer calling convention)\r\nnameof\r\nnint\r\nnot\r\n\r\nnotnull\r\nnuint\r\non\r\nor\r\norderby\r\npartial (type)\r\npartial (method)\r\nrecord\r\nremove\r\nrequired\r\nscoped\r\n\r\nselect\r\nset\r\nunmanaged (function pointer calling convention)\r\nunmanaged (generic type constraint)\r\nvalue\r\nvar\r\nwhen (filter condition)\r\nwhere (generic type constraint)\r\nwhere (query clause)\r\nwith\r\nyield\r\n");
        }

        static void Comentarios()
        {
            // Comentário em uma linha
            /*Comentário em várias
            linhas*/

            /// Notação XML (metadata) -> Dados adicionais
        }

        static void Exbyte()
        {
            byte valor1 = 122;
            sbyte valor2 = -12;

            Console.WriteLine(valor2 + valor1);
        }

        static void Inteiro()
        {
            // u = unsigned -> só pode ser positivo
            //short/ushort 
            //int/uint -> valor padrão se usar var
            //long/ulong
        }

        static void NumerosReais()
        {
            // float (notação F)
            float salario = 2.222f;
            // double -> valor padrão se usar var
            double salario2 = 2.131;
            // decimal (notação M)
            decimal salario3 = 2.222m;
            Console.WriteLine($"{salario}, {salario2}, {salario3}");
        }

        static void Boolean()
        {
            bool verdadeiro = true;
            bool falso = false;
            Console.WriteLine($"{ verdadeiro} ou { falso }");
        }

        static void Character()
        {
            char inicial = 'T';
            Console.WriteLine(inicial);
        }

        static void Exstring()
        {
            string nome = "Thierry";
            Console.WriteLine(nome);    
        }

        static void Var()
        {
            // Quando a variável é instanciada seu tipo é estipulado
            // e não pode ser alterado
            var nome = "Galileu";
            nome = "Roberto";
            //nome = 11; -> erro
            Console.WriteLine(nome);
        }

        static void ObjecT()
        {
            // object é um tipo genérico que recebe qualquer valor ou objeto
            object idade = 25; // será do tipo object
            idade = "Vinte e cinco";
            Console.WriteLine(idade);
        }

        static void Nulo()
        {
            // void -> vazio/sem retorno
            // null -> vazio/tipo(pode ser nulo)
            int? idade = null;
            Console.WriteLine(idade); // null é vazio (n aparece no log)
        }

        static void ConversaoImplicita()
        {
            float peso = 77.1F;
            int peso2 = 77;
            peso = peso2;

            Console.WriteLine(peso2);
        }

        static void ConversaoExplicita()
        {
            int inteiro = 100;

            uint inteiroSemSinal = (uint)inteiro;
            Console.WriteLine(inteiroSemSinal);
        }

        static void Parse()
        {
            int inteiro = int.Parse("100");
            Console.WriteLine(inteiro);
        }

        static void Converte()
        {
            double numero = Convert.ToDouble("100,3");
            numero += 1;
            Console.WriteLine(numero);
            Console.WriteLine(Convert.ToBoolean(1));
        }

        static void OperacoesAritmeticas()
        {
            int numero1 = 27;
            int numero2 = 9;
            Console.WriteLine($"" +
                $"Soma:{numero1 + numero2}, \n" +
                $"Subtração:{numero1 - numero2}, \n" +
                $"Multiplicação:{numero1 * numero2}, \n" +
                $"divisao:{numero1 / numero2}.");
        }

        static void OperadoresDeAtribuicao()
        {
            int x = 0;
            // soma 4
            x += 4;
            // divide por 2
            x /= 2;
            Console.WriteLine(x);
        }

        static void OperadoresDeComparacao()
        {
            int x = 19;
            // sempre retorna true ou false
            // igual ==
            Console.WriteLine(x == 0); //False
            // diferente !=
            Console.WriteLine(x != 0); //True
            // maior que >
            Console.WriteLine(x > 0); //True
            // menor que <
            Console.WriteLine(x < 0); //False
            // maior ou igual a >=
            Console.WriteLine(x >= 0); //True
            // menor ou igual que <=
            Console.WriteLine(x <= 0); //False
        }

        static void OperadoresLogicos()
        {
            int number = 22;
            // E - and - &&
            bool entre = (number > 19) && (number < 40);
            // OU - or - ||
            bool ou = (number > 20) || (number < 40);
            // NEGAÇÂO - not - ! 
            bool negacao = !(number < 25);
            Console.WriteLine($"" +
                $"{number} está entre 19 e 40: {entre}, \n" +
                $"{number} é maior que 20 Ou menor que 40 : {ou}, \n" +
                $"Negacao ({number} não é menor que 25): {negacao}.");
        }

        static void CondicionalIf()
        {
            int idade = 17;
            if (idade == 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else if (idade > 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }

        static void CondicionalSwitch()
        {
            string carne = "frango";
            switch (carne)
            {
                case "porco": Console.WriteLine("Mignon"); break;
                case "frango": Console.WriteLine("Peito"); break;
                default: Console.WriteLine("Custo benefício"); break;
            }
        }

        static void EstruturaDeRepeticaoFor()
        {
            for (var i = 12; i >= 0; i--)
                Console.WriteLine($"index = {i}");
        }

        static void EstruturaDeRepeticaoWhile()
        {
            // checa a condição antes de executar
            var valor = 0;
            while (valor <= 4)
            {
                valor++;
                Console.WriteLine(valor);
            }
        }

        static void EstruturaDeRepeticaoDoWhile()
        {
            // checa a condição depois de executar
            var valor = 0;
            do
            {
                Console.WriteLine(valor);
                valor++;
            } while (valor < 5);
        }

        static string RetornaNomeCompleto(
            string nome,
            string sobrenome,
            int idade = 18
            )
        {
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }

        static void TiposDeValor()
        {
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void TiposDeReferencia()
        {
            var arr = new string[2];
            arr[0] = "Azul";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Amarelo";

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }

    }
    struct Product
    {
        public int Id;
        public string Title;
        public double Price;
        public ESize Size;

        public Product() { }

        public Product(int id, string title, double price, ESize size)
        {
            Id = id;
            Title = title;
            Price = price;
            Size = size;
        }
        public double PriceInDolar(double dolar)
        {
            return Price / dolar;
        }
    }
    enum ESize
    { 
        Small = 1,
        Medium = 2,
        Big = 3
    }

}
