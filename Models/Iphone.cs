namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {

        }
        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Iphone.");
        }
    }
}