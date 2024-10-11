namespace Ejercicio1.1;

public partial class resultado : ContentPage
{
    public resultado(double resultado)
    {
        InitializeComponent();
        EtiquetaResultado.Text = $"Resultado: {resultado}";
    }
}