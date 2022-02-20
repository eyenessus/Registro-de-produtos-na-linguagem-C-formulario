using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV1.Models;
namespace ATV1
{
    public class Pedido
    {
        private List<ItemPedido> listadeItens = new List<ItemPedido>();
        public void AdicionarPedido(ItemPedido Item){
            listadeItens.Add(Item);
        }
        public double TotalPedido(){
            double totalPedido = 0;
            foreach (var lista in listadeItens){
                totalPedido += lista.quantidade * lista.valor;
            }
            return totalPedido;
        }
        public List<ItemPedido> ListaPedido(){
            return listadeItens;
        }
    }
}