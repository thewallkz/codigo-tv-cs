/* Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume, ligar, desligar e trocar os canais da televisão. 
O controle de volume permite:
aumentar ou diminuir o volume de som em uma unidade de cada vez com limite em 100 ? (“Volume Máximo”); caso 0 (“MUDO”)
aumentar e diminuir o número do canal em uma unidade
trocar para um canal indicado;
consultar o valor do volume de som, canal selecionado e status ligada ou desligada. */

// MAIN

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
    //int input = int.Parse(Console.ReadLine());

}