using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace TempConverterApp_AvaloniaUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        Debug.WriteLine($"Button Clicked......!!!! Celsius={Celsius.Text}");
        // var C = CelsiusToFahrenheit(Celsius.Text);
    }

    private void Celsius_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(Celsius.Text) || Celsius.Text == "-")
        {
            Fahrenheit.Text = "";
        }
        else if (double.TryParse(Celsius.Text, out double C))
        {
            var F = CelsiusToFahrenheit(C);
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
    
    private double CelsiusToFahrenheit(double CelsiusValue)
    {
        var  F = CelsiusValue * (9d / 5d) + 32;
        return F;
    }
    
    
}