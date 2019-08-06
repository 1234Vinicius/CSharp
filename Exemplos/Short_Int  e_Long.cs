using System;

namespace short_Int_e_Long
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO AS VARIÁVEIS
            short minhaVarDoTipoShort = 10;
            System.Int16 minhaVarDoTipoShortDois = 20;
            int minhaVardoTipoInteiro;
            long minhaVarDoTipoLong;

            // SOMANDO VALORES DE VARIÁVEIS

            // minhaVarDoTipoShort + minhaVarDoTipoShortDois;
            // EU NÃO POSSO SIMPLESMENTE SOMAR VALORES, OU FAZER QUALQUER OUTRA OPERAÇÃO CONFORME ACIMA,
            // DEVO SEMPRE ATRIBUIR O RESULTADO DE UMA OPERAÇÃO A UMA OUTRA VARIÁVEL
            // OU JÁ IMPRIMIR NA TELA O RESULTADO, CONFORME ABAIXO.
            Console.WriteLine(minhaVarDoTipoShort + minhaVarDoTipoShortDois);
            Console.ReadKey();
        }
    }
}
