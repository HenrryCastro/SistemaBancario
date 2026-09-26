namespace SistemaBancario.models
{
    public abstract class CuentaBancaria 
    {
        public decimal Saldo { get; set; }

        // Método abstracto para aplicar polimorfismo
        public abstract decimal CalcularInteresMensual();
    }
}