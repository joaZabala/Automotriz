﻿using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz.Producto
{
    public interface ITipoProducto
    {
        List<TipoProducto> GetAll();
    }
}