﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laboratorio2
{
    public class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;
        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;
        }


        public string informacion()
        {
            return "genero: " + genero + ", artista: " + artista + ", album: " + album + ", nombre: " + nombre;
        }
    }
}