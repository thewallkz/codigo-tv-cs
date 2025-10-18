namespace codigo_tv_cs
{
    public class Televisao
    {
        public int volume  { get; set; }
        public int canal  { get; set; }
        public bool power { get; set; }
        public ControleRemoto controle { get; set; }
        public Televisao()
        {
            volume = 0;
            canal = 0;
            power = false;
        }
        public void Status()
        {
            System.Console.WriteLine($"Ligada [{power}] - Volume [{volume}] - Canal [{canal}]");
        }
    }
}