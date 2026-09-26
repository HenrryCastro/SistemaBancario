using System;
using SistemaBancario.models;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DE RENDIMIENTO FINANCIERO ===");

            // Cuenta de Ahorros
            CuentaAhorros cuentaA = new CuentaAhorros();
            cuentaA.Saldo = 5000.00m;
            cuentaA.TasaPromocional = 0.02m; 
            
            Console.WriteLine($"Interés Cuenta Ahorros: {cuentaA.CalcularInteresMensual()}");

            // Cuenta de Inversión
            CuentaInversion cuentaI = new CuentaInversion();
            cuentaI.Saldo = 12000.00m;
            cuentaI.FactorRiesgo = 0.085; 
            
            Console.WriteLine($"Interés Cuenta Inversión: {cuentaI.CalcularInteresMensual()}");
        }
    }
}
