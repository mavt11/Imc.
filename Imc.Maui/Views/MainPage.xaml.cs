using Imc.Maui.Models;

namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SitucionNutricionalLabel.Text = string.Empty;
        ImcLabel.Text = string.Empty;
    }

    private void OnCalcularButtonClicked(object sender, EventArgs e)
    {
        decimal peso;
        decimal estatura;
        peso = decimal.Parse(PesoENtry.Text);
        estatura = decimal.Parse(EstaturaEntry.Text);
        decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
        ImcLabel.Text = imc.ToString("F4");
        SitucionNutricionalLabel.Text = CalculadoraImc.SituacionNutricional(imc);

    }

    private void OnLimpiarButtonClicked(object sender, EventArgs e)
    {
        PesoENtry.Text = string.Empty;
        EstaturaEntry.Text = string.Empty;
        SitucionNutricionalLabel.Text = string.Empty;
        ImcLabel.Text = string.Empty;


    }
}