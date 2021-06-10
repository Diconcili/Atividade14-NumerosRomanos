using System.Collections.Generic;

namespace Numeros_Romanos
{
    class ConversorRomanos 
    {
        public int nArabico { get; private set; }
        public string nRomano { get; private set; }

        private Dictionary<string, int> dicionário = new Dictionary<string, int>()
        {
            {"x", 10000},
            {"ix", 9000},
            {"viii", 8000},
            {"vii", 7000},
            {"vi", 6000},
            {"v", 5000 },
            {"iv", 4000},
            {"MMM", 3000},
            {"MM", 2000},
            {"M", 1000},
            {"CM", 900},
            {"DCCC", 800},
            {"DCC", 700},
            {"DC", 600},
            {"D", 500},
            {"CD", 400},
            {"CCC", 300},
            {"CC", 200},
            {"C", 100},
            {"XC", 90},
            {"LXXX", 80},
            {"LXX", 70},
            {"LX", 60},
            {"L", 50},
            {"XL", 40},
            {"XXX", 30},
            {"XX", 20},
            {"X", 10},
            {"IX", 9},
            {"VIII", 8},
            {"VII", 7},
            {"VI", 6},
            {"V", 5},
            {"IV", 4},
            {"III", 3},
            {"II", 2},
            {"I", 1},
        };

        public ConversorRomanos(string numeroRomano)
        {            
            nRomano = numeroRomano;
            nArabico = Converter(nRomano);
        }

        private List<string> valoresQuePodemDiminuir = new List<string>()
        {
            "I",
            "X",
            "C", 
            "i",
            "v",
            "x"
        };
               
        private bool ProximoValorÉMaiorQueOAtual(string valor, string proximoValor)
        {
            return dicionário[proximoValor] > dicionário[valor];
        }

        private static bool PodeAvancarMaisUmaPosicao(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }

        private static string Normalizar(string corrigir)
        {
            corrigir = corrigir.ToUpper();

            corrigir = corrigir.Replace("Ī", "i");
            corrigir = corrigir.Replace("V̄", "v");
            corrigir = corrigir.Replace("X̄", "x");

            return corrigir;
        }

        public int Converter(string numeroRomano)
        {
            numeroRomano = Normalizar(numeroRomano);

            char[] valoresParaConverter = numeroRomano.ToCharArray();
            int resultado = 0;
            

            for (int i = 0; i < valoresParaConverter.Length; i++)
            {
                string valor = valoresParaConverter[i].ToString();
                int valorAAdicionar = 0;                

                if(PodeAvancarMaisUmaPosicao(valoresParaConverter, i))
                {
                    string proximoValor = valoresParaConverter[i + 1].ToString();

                    if(valoresQuePodemDiminuir.Contains(valor) && ProximoValorÉMaiorQueOAtual(valor, proximoValor))
                    {
                        valorAAdicionar = dicionário[proximoValor] - dicionário[valor];
                        i++;
                    }
                }
                
                if(valorAAdicionar == 0)
                {
                    valorAAdicionar = dicionário[valor];
                }

                resultado += valorAAdicionar;
            }

            return resultado;
        }
    }
}
