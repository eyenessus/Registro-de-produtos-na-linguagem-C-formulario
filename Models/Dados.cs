using ATV1.Models;
namespace ATV1.Controllers
{


    public static class Dados
    {

        public static Pedido PedidoAtual { get; set; }

        static Dados()

        {

            PedidoAtual = new Pedido();

        }

    }
}