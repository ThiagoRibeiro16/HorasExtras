/* Escreva uma função que calcule o salário de um funcionário a partir salário-hora base, 
o total de horas trabalhadas e número de horas-extras executadas. Considere que cada hora-extra é 
paga com acréscimo de 40%.*/

Console.Clear();

double CalcularSalario(double salarioHora, double horasTotais, double horasExtras)
{
    double horasNormais = horasTotais - horasExtras;
    double salarioNormais = horasNormais * salarioHora;
    double salarioExtras = horasExtras * salarioHora * 1.4;
    return salarioNormais + salarioExtras;
}

Console.Write("Informe o salário-hora: ");
double salarioHora = double.Parse(Console.ReadLine());

Console.Write("Informe o total de horas trabalhadas: ");
double horasTotais = double.Parse(Console.ReadLine());

Console.Write("Informe o número de horas extras: ");
double horasExtras = double.Parse(Console.ReadLine());

double salario = CalcularSalario(salarioHora, horasTotais, horasExtras);

Console.WriteLine($"O salário total é: R$ {salario:F2}");

