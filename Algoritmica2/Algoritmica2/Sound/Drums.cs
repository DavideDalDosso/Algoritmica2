using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Drums : IPlayable
{
    public string GetSound(Random random)
    {
        switch (random.Next(14))
        {
            case 0: return "DUN";
            case 1: return "BUM";
            case 2: return "BAM";
            case 3: return "TSHU";
            case 4: return "SH";
            case 5: return "STRT";
            case 6: return "TCHSH";
            case 7: return "TUN";
            case 8: return "TANTANTUN";
            case 9: return "TIRITTU";
            case 10: return "TRTRT";
            case 11: return "BAAAAAAAM";
            case 12: return "BOOOOOOOOM";
            case 13: return "BMMMMM";
        }
        return "";
    }
}
