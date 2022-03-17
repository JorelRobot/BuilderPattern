
/*
Torta t1 = new Torta();
t1.setPan("Telera");
t1.setFrijoles("Negros");
t1.setQueso("Amarillo");

string[] ingredientes = new string[] { "Milanesa", "Rajas" };
t1.setIngredientes(ingredientes);

t1.preparar();
*/

using ProfeCodigo;

TortaDirector director = new TortaDirector();

TortaBuilder builder = new TortaBuilder();
//director.constructTortaTapaAerterias(builder);

int opc = 0;

do
{
    Console.WriteLine("[1] Torta sencilla");
    Console.WriteLine("[2] Torta de milanesa");
    Console.WriteLine("[3] Torta la tapaarterias");
    Console.WriteLine("[4] Torta perzonalizada");
    Console.WriteLine("[0] Salir de la aplicacion");

    Console.Write("\nDigita el numero de la opcion que desees: ");
    opc = Convert.ToInt32(Console.ReadLine());

    switch(opc)
    {
        case 0:
            Console.WriteLine("Hasta pronto :)");
            break;
        case 1:
            Console.WriteLine("\n\n\n");
            director.constructTortaSencilla(builder);
            builder.getResult().preparar();
            Console.WriteLine(" \n\n\n");
            break;
        case 2:
            Console.WriteLine("\n\n\n");
            director.constructTortaDeMilanesa(builder);
            builder.getResult().preparar();
            break;
            Console.WriteLine("\n\n\n");
        case 3:
            Console.WriteLine("\n\n\n");
            director.constructTortaTapaAerterias(builder);
            builder.getResult().preparar();
            Console.WriteLine("\n\n\n");
            break;
        case 4:
            string pan = "";
            string frijoles = "";
            string queso = "";
            string[] extras;
            int num_extras = 0;

            Console.Write("Escribe el tipo de pan que deseas: ");
            pan = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Escribe el tipo de frijoles que deseas: ");
            frijoles = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Escribe el tipo de queso que deseas: ");
            queso = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("¿Cuantos ingredientes extra deseas? : ");
            num_extras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            extras = new string[num_extras];

            for (int i = 0; i < num_extras; i++)
            {
                Console.Write($"Escribe el ingrediente {i}: ");
                extras[i] = Console.ReadLine();
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n\n");
            director.constructTortaPerzonalizada(builder, pan, frijoles, queso, extras);
            builder.getResult().preparar();
            Console.WriteLine("\n\n\n");
            break;
            /*
        default:
            Console.WriteLine("Opcion incorrecta, intente de nuevo :)");*/

    }


} while (opc != 0);
