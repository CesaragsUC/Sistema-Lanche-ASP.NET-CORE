﻿using SitemaLanche.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitemaLanche.Repository
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
