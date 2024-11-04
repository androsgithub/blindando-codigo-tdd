using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.App
{
    public class Calculadora
    {
        private List<string> _historico { get; set; }
        public Calculadora()
        {
            _historico = new List<string>();
        }
        public int Somar(int valor1, int valor2)
        {
            var result = valor1 + valor2;
            _historico.Insert(0, $"Soma: {valor1} + {valor2} = {result}");
            return result;
        }
        public int Subtrair(int valor1, int valor2)
        {
            var result = valor1 - valor2;
            _historico.Insert(0, $"Subtrair: {valor1} - {valor2} = {result}");
            return result;
        }
        public int Multiplicar(int valor1, int valor2)
        {
            var result = valor1 * valor2;
            _historico.Insert(0, $"Multiplicar: {valor1} * {valor2} = {result}");
            return result;
        }
        public int Dividir(int valor1, int valor2)
        {
            var result = valor1 / valor2;
            _historico.Insert(0, $"Multiplicar: {valor1} / {valor2} = {result}");
            return result;
        }

        public List<string> Historico()
        {
            if (_historico.Count > 3)
            {
                _historico.RemoveRange(3, _historico.Count);
            }
            return _historico;
        }

    }
}