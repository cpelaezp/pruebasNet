using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPrueba.Models
{
    public class Tramites
    {
        Int32 _id;
        string _descripcion;
        string _entidad;
        string _estado;
        string _url;

        public Tramites()
        {
        }

        public Tramites(Int32 id, string descripcion, string entidad, string estado, string url)
        {
            Id = id;
            Descripcion = descripcion;
            Entidad = entidad;
            Estado = estado;
            Url = url;
        }


        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Entidad { get => _entidad; set => _entidad = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Url { get => _url; set => _url = value; }


    }
}