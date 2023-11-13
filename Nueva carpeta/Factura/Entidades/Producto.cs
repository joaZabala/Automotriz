using System;
using System.Security.Policy;

namespace Factura
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public int IdTipoProducto { get; set;}
        public int NumSerie { get; set;}
        public decimal Precio { get; set;}
        public DateTime? FechaFab { get ; set;}
        public int VidaUtil { get ; set;}
        public decimal Peso { get; set;}
        public int IdUnidadPeso { get; set;}
        public decimal Largo { get; set;}
        public decimal Ancho { get; set;}
        public decimal Alto { get ; set;}
        public int IdUnidadMedida { get; set;}
        public int IdTipoMaterial { get ; set;}
        public int IdPais { get; set;}
        public int IdMarca { get; set;}
        public Producto()
        {
            Id = 0;
            Nombre = string.Empty;
            IdTipoProducto = 0;
            NumSerie = 0;
            Precio = 0;
            FechaFab = null;
            VidaUtil = 0;
            Peso = 0;
            IdUnidadPeso = 0;
            Largo = 0;
            Ancho = 0;
            Alto = 0;
            IdTipoMaterial = 0;
            IdUnidadPeso = 0;
            IdPais = 0;
            IdMarca = 0;
        }
        public Producto(int id, string nom, int idTipoProducto, int numserie, decimal pre, DateTime fecfab, int vida, decimal peso, int idUnidadPeso, decimal largo, decimal ancho, decimal alto, int idUnidadMedida, int idTipoMaterial, int idPais, int idMarca)
        {
            Id = id;
            Nombre = nom;
            IdTipoProducto= idTipoProducto;
            NumSerie = numserie;
            Precio = pre;
            FechaFab = fecfab;
            VidaUtil = vida;
            Peso = peso;
            IdUnidadPeso= idUnidadPeso;
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
            IdTipoMaterial = idTipoMaterial;
            IdUnidadPeso = idUnidadPeso;
            IdPais= idPais;
            IdMarca= idMarca;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}