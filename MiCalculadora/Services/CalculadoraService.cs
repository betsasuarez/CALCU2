using MiCalculadora.Models;
using MiCalculadora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadora.Services
{
    public class CalculadoraService : ICalculadoraService
    {
        private bool ValidaNumero(int N)
        {
            if (N == 0) 
            {
                return false;
            }
            return true;
        }
        public int CalcularDosNumeros(int N1, int N2, Operaciones.Operacion operacion)
        {
            if (!ValidaNumero(N1))
            {
                return 0;
            }
            if (!ValidaNumero(N2))
            {
                return 0;
            }
            switch (operacion)
            {
                case Operaciones.Operacion.Suma: 
                    return N1 + N2;
                case Operaciones.Operacion.Resta: 
                    return N1 - N2;
                case Operaciones.Operacion.Multiplicacion:
                    return N1 * N2;
                case Operaciones.Operacion.Division:
                    return N1 / N2; 
                default: 
                    return 0;
            }
        }
        
        public int SumarDosNumeros(int N1, int N2)
        {
            if (!ValidaNumero(N1))
            {
                return 0;
            }
            if (!ValidaNumero(N2))
            {
                return 0;
            }
            return N1 + N2;
        }
    }
}
