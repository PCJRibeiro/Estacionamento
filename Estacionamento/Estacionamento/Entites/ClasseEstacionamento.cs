using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entites
{
    internal class ClasseEstacionamento
    {
        public int Hora {  get; set; }
        public int PrecoInicial { get; set; }
        public int PrecoHora { get; set; }

        public List<string> Carros = new List<string>();

        public ClasseEstacionamento() { }
        public ClasseEstacionamento(int precoInicial,int precoHora)
        {
             PrecoInicial = precoInicial;
             PrecoHora = precoHora;
        }

        public void AdicionarCarro(string placa)
        {           
            Carros.Add(placa);
        }
        public string RemoverCarro(string placa,int hora)
        {           
            Hora = hora;
            Carros.Remove(placa);
            return "O valor a pagar é de R$"+(PrecoInicial +PrecoHora*Hora);
        }
        public void ListarCarros()
        {
            foreach(string carro in Carros)
            {
                Console.WriteLine(carro);
            }
        }
    }
}
