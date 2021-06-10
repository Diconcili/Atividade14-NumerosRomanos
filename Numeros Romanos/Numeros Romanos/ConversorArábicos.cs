using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numeros_Romanos
{
    class ConversorArábicos
    {
        public int nArabico { get; private set; }
        public string nRomano { get; private set; }

        private Dictionary<int, string> conversão = new Dictionary<int, string>()
        {
            {10000, "X̄" },
            {9000, "ĪX̄" },
            {8000, "V̄ĪĪĪ"},
            {7000, "V̄ĪĪ"},
            {6000, "V̄Ī"},
            {5000, "V̄" },
            {4000, "ĪV̄" },
            {3000, "MMM" },
            {2000, "MM"},
            {1000, "M"},
            {900, "CM"},
            {800, "DCCC"},
            {700, "DCC"},
            {600, "DC"},
            {500, "D"},
            {400, "CD" },
            {300, "CCC" },
            {200, "CC" },
            {100, "C"},
            {90, "XC" },
            {80, "LXXX"},
            {70, "LXX"},
            {60, "LX"},
            {50, "L" },
            {40, "XL" },
            {30, "XXX" },
            {20, "XX" },
            {10, "X" },
            {9, "IX" },            
            {8, "VIII" },
            {7, "VII" },
            {6, "VI" },
            {5, "V" },
            {4, "IV" },
            {3, "III" },
            {2, "II" },
            {1, "I" },
        };

        public ConversorArábicos(int numeroArabico)
        {
            nArabico = numeroArabico;
            nRomano = Converter(nArabico);
        }

        private string Converter(int numeroArabico)
        {
            StringBuilder resultado = new StringBuilder();
            int valorParaConversao = numeroArabico;

            foreach(int valor in conversão.Keys)
            {
                while(valorParaConversao >= valor)
                {
                    resultado.Append(conversão[valor]);
                    valorParaConversao -= valor;
                }
            }
            return resultado.ToString();
        }
    }
}
