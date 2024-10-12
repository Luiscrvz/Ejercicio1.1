namespace Ejercicio1.1;

public partial class resultado1 : ContentPage
{
    public resultado1(double resultado)
    {
        InitializeComponent();
        EtiquetaResultado.Text = $"Resultado: {resultado}";
    }
}