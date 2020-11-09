using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPrueba.Models
{
    public class Opiniones
    {
        Int32 _id;
        string _titulo;
        string _descripcion;
        string _entidad;
        string _comentario;
        string _url;

        public Opiniones()
        {
        }

        public Opiniones(Int32 id, string titulo, string descripcion, string entidad, string comentario, string url)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Entidad = entidad;
            Comentario = comentario;
            Url = url;
        }


        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Entidad { get => _entidad; set => _entidad = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }
        public string Url { get => _url; set => _url = value; }


    }
}