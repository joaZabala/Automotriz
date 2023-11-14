﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class ProductoAuto
    {
        public int Id { get; set; }
        public string Productos { get; set; }
        public TipoProducto IdTipoProducto { get; set; }
        public int NumSerie { get; set; }
        public float Precio { get; set; }
        public DateTime? FechaFab { get; set; }
        public int VidaUtil { get; set; }
        public float Peso { get; set; }
        public UnidadPeso IdUnidadPeso { get; set; }
        public float Largo { get; set; }
        public float Ancho { get; set; }
        public float Alto { get; set; }
        public UnidadesMedida IdUnidadMedida { get; set; }
        public Tipo_material IdTipoMaterial { get; set; }
        public Pais IdPais { get; set; }
        public Marcas IdMarca { get; set; }
        public ProductoAuto()
        {
            Id = 0;
            Productos = string.Empty;
            IdTipoProducto = new TipoProducto();
            NumSerie = 0;
            Precio = 0;
            FechaFab = null;
            VidaUtil = 0;
            Peso = 0;
            IdUnidadPeso = new UnidadPeso();
            Largo = 0;
            Ancho = 0;
            Alto = 0;
            IdTipoMaterial = new Tipo_material();
            IdUnidadMedida = new UnidadesMedida();
            IdPais = new Pais();
            IdMarca = new Marcas();
        }
        public ProductoAuto(int id, string pro, TipoProducto idTipoProducto, int numserie, float pre, DateTime fecfab, int vida, float peso, UnidadPeso idUnidadPeso, float largo, float ancho, float alto, UnidadesMedida idUnidadMedida, Tipo_material idTipoMaterial, Pais idPais, Marcas idMarca)
        {
            Id = id;
            Productos = pro;
            IdTipoProducto = idTipoProducto;
            NumSerie = numserie;
            Precio = pre;
            FechaFab = fecfab;
            VidaUtil = vida;
            Peso = peso;
            IdUnidadPeso = idUnidadPeso;
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
            IdTipoMaterial = idTipoMaterial;
            IdUnidadMedida = idUnidadMedida;
            IdPais = idPais;
            IdMarca = idMarca;
        }
    }
}