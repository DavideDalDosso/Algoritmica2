using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mayo : IPlayable
{
    public string GetSound(Random random)
    {
        switch (random.Next(11))
        {
            case 0: return "Mayo!";
            case 1: return "Ayy no Mayo!";
            case 2: return "Cirno no Mayo!";
            case 3: return "Pretty no Mayo!";
            case 4: return "Boyo no Mayo!";
            case 5: return "Ayo no Mayo!";
            case 6: return "Banana Koton Ayy Mayo!";
            case 7: return "Ma Mayo!";
            case 8: return "Ay yo no Mayo!";
            case 9: return "Is Mayo an Instrument no Mayo?";
            case 10: return "Mayo Mayo Mayo Mayo";
        }
        return "";
    }
}
