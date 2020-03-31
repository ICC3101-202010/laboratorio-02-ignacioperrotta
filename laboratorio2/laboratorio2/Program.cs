using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laboratorio2;

namespace laboratorio2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Cancion c1 = new Cancion("Sorry", "Purpose", "Justin Bieber", "Pop");
            Cancion c2 = new Cancion("Love Yourself", "Purpose", "Justin Bieber", "Pop");
            Cancion c3 = new Cancion("What do you mean?", "Purpose", "Justin Bieber", "Pop");


            Espotifai lista2 = new Espotifai();
            lista2.AgregarCancion(c1.informacion());
            lista2.AgregarCancion(c2.informacion());
            lista2.AgregarCancion(c3.informacion());
            Console.WriteLine("Welcome to espotifai");
            Console.WriteLine("Elija una de las siguientes opciones");
            Console.WriteLine("(1) Ver todas las canciones");
            Console.WriteLine("(2) Agregar una canción");
            Console.WriteLine("(3) Canciones por criterio");
            Console.WriteLine("(4) Salir del programa");
            string input_usuario;
            input_usuario = Console.ReadLine();
            while (input_usuario == "1" || input_usuario == "2" || input_usuario == "3")
            {
                if (input_usuario == "1")
                {
                    lista2.VerCanciones();
                }
                else if (input_usuario == "2")
                {
                    Console.WriteLine("nombre");
                    string n_nombre;
                    n_nombre = Console.ReadLine();
                    Console.WriteLine("album");
                    string n_album;
                    n_album = Console.ReadLine();
                    Console.WriteLine("artista");
                    string n_artista;
                    n_artista = Console.ReadLine();
                    Console.WriteLine("genero");
                    string n_genero;
                    n_genero = Console.ReadLine();
                    Cancion c4 = new Cancion(n_nombre, n_album, n_artista, n_genero);
                    lista2.AgregarCancion(c4.informacion());
                    Console.WriteLine("the song has been added");
                }

                else if (input_usuario == "4")
                {
                    break;
                }
                else if (input_usuario == "3")
                {
                    Console.WriteLine("Ingrese un criterio");
                    Console.WriteLine("nombre, album, artista, genero");
                    string criterio_igresado;
                    criterio_igresado = Console.ReadLine();
                    if (criterio_igresado == "nombre" || criterio_igresado == "album" || criterio_igresado == "artista" || criterio_igresado == "genero")
                    {
                        Console.WriteLine("Para este criterio, ingrese un valor");
                        string valor_igresado;
                        valor_igresado = Console.ReadLine();

                        lista2.CancionesPorCriterio(criterio_igresado, valor_igresado);

                    }
                    else
                    {
                        Console.WriteLine("El criterio ingresado no es válido");
                    }

                }

                Console.WriteLine("Welcome to espotifai");
                Console.WriteLine("Elija una de las siguientes opciones");
                Console.WriteLine("(1) Ver todas las canciones");
                Console.WriteLine("(2) Agregar una canción");
                Console.WriteLine("(3) Canciones por criterio");
                Console.WriteLine("(4) Salir del programa");
                input_usuario = Console.ReadLine();
            }

        }


    }
}
