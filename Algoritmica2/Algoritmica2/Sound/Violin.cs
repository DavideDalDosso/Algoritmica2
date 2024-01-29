using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Violin : IPlayable
{
    public string GetSound(Random random)
    {
        switch (random.Next(15))
        {
            case 0: return "Vimu";
            case 1: return "Vamu";
            case 2: return "Vuiiimu";
            case 3: return "Vomu";
            case 4: return "Vuuumu";
            case 5: return "Vuuuu";
            case 6: return "Vavivivuuum";
            case 7: return "Vavivuvom";
            case 8: return "Viiivuuuviiim";
            case 9: return "Va vivivummm";
            case 10: return "Vavim vum";
            case 11: return "Va va va va va vim vum";
            case 12: return "Vum vum vum vam vam vim vum";
            case 13: return "Vuvvuruvum vam vuruvum";
            case 14: return "Vavivum Vuvvruruvum vam vavavam";
        }
        return "";
    }
}
