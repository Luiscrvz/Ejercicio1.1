namespace Ejercicio1.1;

public partial class principal : ContentPage
{
    Modelos.Operaciones operaciones = new Modelos.OperacionesMatematicas();

    public principal()
    {
        InitializeComponent();
    }

    private async void BotonSumar(object sender, EventArgs e)
    {
        double operador1 = double.Parse(PrimerNumero.Text);
        double operador2 = double.Parse(SegundoNumero.Text);
        double resultado = operaciones.Sumar(operador1, operador2);

        await Navigation.PushAsync(new PaginaResultado(resultado));
    }

    private async void BotonRestar(object sender, EventArgs e)
    {
        double operador1 = double.Parse(PrimerNumero.Text);
        double operador2 = double.Parse(SegundoNumero.Text);
        double resultado = operaciones.Restar(operador1, operador2);

        await Navigation.PushAsync(new PaginaResultado(resultado));
    }

    private async void BotonMultiplicar(object sender, EventArgs e)
    {
        double operador1 = double.Parse(PrimerNumero.Text);
        double operador2 = double.Parse(SegundoNumero.Text);
        double resultado = operaciones.Multiplicar(operador1, operador2);

        await Navigation.PushAsync(new PaginaResultado(resultado));
    }

    private async void BotonDividir(object sender, EventArgs e)
    {
        double operador1 = double.Parse(PrimerNumero.Text);
        double operador2 = double.Parse(SegundoNumero.Text);
        double resultado;

        try
        {
            resultado = operaciones.Dividir(operador1, operador2);
            await Navigation.PushAsync(new PaginaResultado(resultado));
        }
        catch (DivideByZeroException ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
