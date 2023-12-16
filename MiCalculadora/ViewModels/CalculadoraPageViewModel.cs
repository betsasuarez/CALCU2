using MiCalculadora.Models;
using MiCalculadora.Services.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiCalculadora.ViewModels;

public class CalculadoraPageViewModel : INotifyPropertyChanged
{
    private readonly ICalculadoraService calculadoraService;
    private int resultado;

    public int Numero1 { get; set; }
    public int Numero2 { get; set; }
    public Operaciones.Operacion SeleccionOperacion { get; set; }
    public int Resultado
    {
        get => resultado; set
        {
            resultado = value;
            OnPropertyChanged();
        }
    }
    public Command HacerCalculoCommand { get; set; }
    public Command SeleccionaSumaCommand { get; set; }
    public Command SeleccionaRestaCommand { get; set; }
    public Command SeleccionaMultiplicarCommand { get; set; }
    public Command SeleccionarDividirCommand { get; set; }





    public CalculadoraPageViewModel(ICalculadoraService calculadoraService )
    {
        this.calculadoraService = calculadoraService;

        HacerCalculoCommand = new Command(CalcularDosNumeros);
        SeleccionaSumaCommand = new Command(SeleccionarOperacionSuma);
        SeleccionaRestaCommand = new Command(SeleccionarOperacionResta);
        SeleccionaMultiplicarCommand = new Command(SeleccionarOperacionMutiplicaion); 
        SeleccionarDividirCommand = new Command(SeleccionarOperacionDivision);
       

    }

    private void CalcularDosNumeros()
    {
        Resultado = calculadoraService.CalcularDosNumeros(Numero1, Numero2, SeleccionOperacion);
        
    }

    private void SeleccionarOperacionSuma() 
    {
        SeleccionOperacion = Operaciones.Operacion.Suma;
    
    }

    private void SeleccionarOperacionResta()
    {
        SeleccionOperacion = Operaciones.Operacion.Resta;

    }
    private void SeleccionarOperacionDivision()
    {
        SeleccionOperacion = Operaciones.Operacion.Division;

    }
    private void SeleccionarOperacionMutiplicaion()
    {
        SeleccionOperacion = Operaciones.Operacion.Multiplicacion;

    }
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    public event PropertyChangedEventHandler PropertyChanged;
}
