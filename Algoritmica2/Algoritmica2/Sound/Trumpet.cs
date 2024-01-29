using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trumpet : IPlayable
{
    public string GetSound(Random random)
    {
        switch (random.Next(10))
        {
            case 0: return "Veeem";
            case 1: return "Beeem";
            case 2: return "Deeeem";
            case 3: return "ZUUUUUUUN";
            case 4: return "Vruuum";
            case 5: return "Vreeem";
            case 6: return "Vuruvuruvum vuvum";
            case 7: return "Vrum";
            case 8: return "VamVAVAVAAAAAM";
            case 9: return "Vuruvum";
        }
        return "";
    }
}
