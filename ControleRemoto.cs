namespace codigo_tv_cs
{
    // Controlar o volume, ligar, desligar e trocar os canais
    public class ControleRemoto
    {
        public void ligar(Televisao tv)
        {
            if (tv.power)
                tv.power = false;
            else
                tv.power = true;
        }
        public void trocarCanal(Televisao tv)
        {
            if (tv.power)
            {
                System.Console.WriteLine("Digite o canal:");
                var entrada = Console.ReadLine();
                int canal;
                if (Int32.TryParse(entrada, out canal))
                {
                    tv.canal = canal;
                    System.Console.WriteLine("Canal: "+tv.canal);
                }
                else
                {
                    System.Console.WriteLine("Entrada invalida!! Digite numeros!!");
                }
            }
            else
            {
                System.Console.WriteLine("TV desligada");
            }
        }
        public void aumentarVolume(Televisao tv)
        {
            if (tv.power)
            {
                tv.volume++;
                System.Console.WriteLine("Volume: "+tv.volume);
            }
            else
            {
                System.Console.WriteLine("TV desligada");
            }
        }
        public void diminuirVolume(Televisao tv)
        {
            if (tv.power)
            {
                tv.volume--;
                System.Console.WriteLine("Volume: "+tv.volume);
            }
            else
            {
                System.Console.WriteLine("TV desligada");
            }
        }
    }
}