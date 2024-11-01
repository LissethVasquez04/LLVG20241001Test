namespace LLVG20241001Test
{
    public class Calculadora
    {
        public double CalcularRaizCuadrada(double numero)
        {
            if (numero < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numero), "El número no puede ser negativo.");
            }
            return Math.Sqrt(numero);
        }
    }
}
