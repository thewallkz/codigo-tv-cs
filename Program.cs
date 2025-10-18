using System.Runtime.CompilerServices;
using codigo_tv_cs;

System.Console.WriteLine("Controle");

Televisao tv = new Televisao();
ControleRemoto controle = new ControleRemoto();

bool loop = true;
while (loop)
{
    System.Console.WriteLine("[1] Ligar/Desligar\n[2] Trocar canal\n[3] Aumentar volume\n[4] Diminuir volume\n[5] Status\n[6] Sair");
    int input;
    if (int.TryParse(Console.ReadLine(), out input))
    {
        switch (input)
        {
            case 1:
                controle.ligar(tv);
                break;
            case 2:
                controle.trocarCanal(tv);
                break;
            case 3:
                controle.aumentarVolume(tv);
                break;
            case 4:
                controle.diminuirVolume(tv);
                break;
            case 5:
                tv.Status();
                break;
            case 6:
                loop = false;
                break;
            default:
                System.Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    else
    {
        System.Console.WriteLine("Entrada invalida!! Digite numeros!!");
    }
}