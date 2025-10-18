namespace codigo_tv_cs
{
    public class Televisao
    {
        public int volume  { get; set; }
        public int canal  { get; set; }
        public bool power { get; set; }
        public ControleRemoto? controle { get; set; } // Tornar nullable
        public Televisao()
        {
            volume = 0;
            canal = 0;
            power = false;
            controle = new ControleRemoto(); // Inicializar
        }
        public int volumeMaximo(int volume)
        {
            if (volume >= 100)
            {
                System.Console.WriteLine("Volume máximo");
                return 100;
            }
            else
            {
                return volume;
            }
        }
        public int volumeMinimo(int volume)
        {
            if (volume <= 0)
            {
                System.Console.WriteLine("Mudo");
                return 0;
            }
            else
            {
                return volume;
            }
        }
        public void Status()
        {
            System.Console.WriteLine($"Ligada [{power}] - Volume [{volume}] - Canal [{canal}]");
        }
    }
}