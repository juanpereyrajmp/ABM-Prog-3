using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public Articulo()
        {
            Id = 0;
            Codigo = "";
            Nombre = "";
            Descripcion = "";
            Marca = new Marca();
            Categoria = new Categoria();
            Imagenes = new List<Imagen> ();
            Precio = 0;
        }
        public Articulo(string codigoArt, string nombreArt, string descripcionArt, Marca marcaArt, Categoria categoriaArt, List<Imagen> imagenes, decimal precio)
        {
            Codigo = codigoArt;
            Nombre = nombreArt;
            Descripcion = descripcionArt;
            Marca = marcaArt;
            Categoria = categoriaArt;
            //List<Imagen> = imagenes.Url;
            Imagenes = imagenes;
            Precio = precio;
        }
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        [DisplayName("Imágenes")]
        public List<Imagen> Imagenes { get; set; }
        //public string Imagen { get; set; }
        public decimal Precio { get; set; }

    }
}
