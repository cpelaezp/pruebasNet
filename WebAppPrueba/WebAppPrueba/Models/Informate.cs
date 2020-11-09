using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPrueba.Models
{
    public class Informate
    {
        Int32 _id;
        string _titulo;
        string _descripcion;
        string _imagen;
        string _fecha;
        string _url;

        public Informate()
        {
        }

        public Informate(Int32 id, string titulo, string descripcion, string imagen, string fecha, string url)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Imagen = imagen;
            Fecha = fecha;
            Url = url;
        }


        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Imagen { get => _imagen; set => _imagen = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Url { get => _url; set => _url = value; }


    }
}