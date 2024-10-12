namespace Ejercicio1.1;

public partial class Pagina1 : ContentPage
{
    Modelos.Operaciones operaciones = new vistas.Operaciones();

    public Pagina1()
    {
        InitializeComponent();
    }

    private async void BotonSumar(object sender, EventArgs e)
    {
        double operando1 = double.Parse(PrimerNumero.Text);
        double operando2 = double.Parse(SegundoNumero.Text);
        double resultado = operaciones.Sumar(operando1, operando2);

        await Navigation.PushAsync(new resultado1(resultado));
    }

    private async void BotonRestar(object sender, EventArgs e)
    {
        double operando1 = double.Parse(PrimerNumero.Text);
        double operando2 = double.Parse(SegundoNumero.Text);
        double resultado = operaciones.Restar(operando1, operando2);

        await Navigation.PushAsync(new resultado1 (resultado));
    }

    private async void BotonMultiplicar(object sender, EventArgs e)
    {
        double operando1 = double.Parse(PrimerNumero.Text);
        double operando2 = double.Parse(SegundoNumero.Text);
        double resultado = operaciones.Multiplicar(operando1, operando2);

        await Navigation.PushAsync(new resultado1(resultado));
    }

    private async void BotonDividir(object sender, EventArgs e)
    {
        double operando1 = double.Parse(PrimerNumero.Text);
        double operando2 = double.Parse(SegundoNumero.Text);
        double resultado;

        try
        {
            resultado = operaciones.Dividir(operando1, operando2);
            await Navigation.PushAsync(new resultado1(resultado));
        }
        catch (DivideByZeroException ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
