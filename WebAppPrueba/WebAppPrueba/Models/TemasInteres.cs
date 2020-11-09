using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPrueba.Models
{
    public class TemasInteres
    {
        Int32 _id;
        string _titulo;
        string _descripcion;
        string _comentario;
        string _imagen;
        string _url;

        public TemasInteres()
        {
        }

        public TemasInteres(Int32 id, string titulo, string descripcion, string comentario, string imagen, string url)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Comentario = comentario;
            Imagen = imagen;
            Url = url;
        }


        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }
        public string Url { get => _url; set => _url = value; }


    }
}