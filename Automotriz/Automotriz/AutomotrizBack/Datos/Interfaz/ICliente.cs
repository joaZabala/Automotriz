﻿using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface ICliente
    {
        List<Cliente> GetAll();
        List<Cliente> Get(string nombre , int tipoCliente);
        bool Nuevo(Cliente cliente);
        bool delete(int codigo);
    }
}
