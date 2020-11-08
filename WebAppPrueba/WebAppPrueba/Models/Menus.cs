using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPrueba.Models
{
    public class Menus
    {
        Int32 _id;
        string _titulo;
        string _descripcion;
        string _url;

        public Menus()
        {
        }

        public Menus(Int32 id, string titulo, string descripcion, string estado, string url)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Url = url;
        }


        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Url { get => _url; set => _url = value; }
    }
}