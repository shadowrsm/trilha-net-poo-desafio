namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado 👍🏼
    public class Nokia : Smartphone
    {
        // Implementado 👍🏼
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado 👍🏼
        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"Instalando o aplicativo \"{app}\" no Nokia...");
            Console.WriteLine();
        }
    }
}