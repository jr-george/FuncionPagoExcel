// See https://aka.ms/new-console-template for more information
using FuncionPagoExcel;

Console.WriteLine("Funcion pago de Excel implementada en C#");
double pago=0;
double tasa = 10; //Tasa del 10%
int plazo = 12; //Plazo en meses
double valorActual = 100000; //Valor actual del bien
double valorFuturo = 0; //Valor futuro o esperado

pago = Finanzas.Pago(tasa / 100, 12, valorActual, valorFuturo);
Console.WriteLine("Pago: " + pago);