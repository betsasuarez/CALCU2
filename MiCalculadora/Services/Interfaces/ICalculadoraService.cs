using MiCalculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCalculadora.Services.Interfaces;

public interface ICalculadoraService
{
    public int SumarDosNumeros(int N1, int N2);
    public int CalcularDosNumeros(int N1, int N2, Operaciones.Operacion operacion);
}
