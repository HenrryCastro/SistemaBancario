namespace SistemaBancario.models
{
    public class CuentaAhorros : CuentaBancaria 
    {
        public decimal TasaPromocional { get; set; }

        public override decimal CalcularInteresMensual() 
        {
            return Saldo * TasaPromocional;
        }
    }
}