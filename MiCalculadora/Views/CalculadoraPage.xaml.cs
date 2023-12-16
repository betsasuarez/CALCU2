using MiCalculadora.ViewModels;

namespace MiCalculadora.Views;

public partial class CalculadoraPage : ContentPage
{
    public CalculadoraPage(CalculadoraPageViewModel calculadoraPageViewModel)
    {
        InitializeComponent();
        BindingContext = calculadoraPageViewModel;
    }
}
