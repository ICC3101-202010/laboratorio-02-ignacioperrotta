using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laboratorio2
{
    public class Espotifai
    {
        List<String> songsList = new List<String>();
        public Espotifai()
        {
        }
        public bool AgregarCancion(String cancion)
        {
            if (songsList.Contains(cancion))
            {
                return false;
            }
            else
            {
                songsList.Add(cancion);
                return true;
            }


        }
        public void VerCanciones()
        {
            for (int i = 0; i < songsList.Count; i++)
            {
                Console.WriteLine(songsList[i]);
            }
        }
        //incremento 2
        public string[] canciones = { };

        public String[] CancionesPorCriterio(String criterio, String valor)
        {
            if (criterio == "nombre")
            {
                int i = 0;
                while (i < songsList.Count)
                {
                    if (songsList[i].Contains(valor))
                    {
                        Console.WriteLine(songsList[i]);
                        canciones.Append(songsList[i]);
                        i++;
                    }
                    else
                    {

                        i++;
                    }

                }



            }
            if (criterio == "album")
            {
                int i = 0;
                while (i < songsList.Count)
                {
                    if (songsList[i].Contains(valor))
                    {
                        Console.WriteLine(songsList[i]);
                        canciones.Append(songsList[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }

                }



            }
            if (criterio == "artista")
            {
                int i = 0;
                while (i < songsList.Count)
                {
                    if (songsList[i].Contains(valor))
                    {
                        Console.WriteLine(songsList[i]);
                        canciones.Append(songsList[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }

                }



            }
            if (criterio == "genero")
            {
                int i = 0;
                while (i < songsList.Count)
                {
                    if (songsList[i].Contains(valor))
                    {
                        Console.WriteLine(songsList[i]);
                        canciones.Append(songsList[i]);
                        i++;
                    }
                    else
                    {
                        i++;
                    }

                }



            }
            return canciones;


        }

    }




}
