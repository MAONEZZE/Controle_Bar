using ControleBar.Compartilhado;
using ControleBar.ModuloGarcom;
using ControleBar.ModuloMesa;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ModuloConta
{
    internal class Conta: EntidadeBase
    {
        public decimal valorTotalDia;
        public bool contaAberta;
        public ArrayList listaPedidos = new ArrayList();
        public Garcom garc;
        public Mesa mesa;

        public Conta(Pedido pedidos, Garcom garc, Mesa mesa)
        {
            this.contaAberta = true;
            this.listaPedidos.Add(pedidos);
            this.garc = garc;
            this.mesa = mesa;
        }

        public decimal PegarValorPedidos()
        {
            decimal somaTotal = 0;

            foreach(Pedido ped in listaPedidos)
            {
                somaTotal = somaTotal + ped.valorPedido;
            }

            return somaTotal;
        }
        public override void Editar(EntidadeBase entAlterada, EntidadeBase entAntiga)
        {
        }

        public override string MostrarEnt(EntidadeBase entidade)
        {
            return null;
        }
    }
}
