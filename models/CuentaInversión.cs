namespace SistemaBancario.models
{
    public class CuentaInversion : CuentaBancaria 
    {
        public double FactorRiesgo { get; set; }

        public override decimal CalcularInteresMensual() 
        {
            return Saldo * (decimal)FactorRiesgo;
        }
    }
}