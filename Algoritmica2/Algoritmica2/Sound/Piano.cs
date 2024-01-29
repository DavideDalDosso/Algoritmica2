using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Piano : IPlayable
{
    public string GetSound(Random random)
    {
        switch (random.Next(14))
        {
            case 0: return "Dun dun";
            case 1: return "Din dun";
            case 2: return "Dan dan";
            case 3: return "Do do";
            case 4: return "Dididu";
            case 5: return "Dadidu";
            case 6: return "Ddddd";
            case 7: return "Bram";
            case 8: return "Brrrmam";
            case 9: return "Dubram";
            case 10: return "Bramdu";
            case 11: return "didudadidu";
            case 12: return "Brambrambram";
            case 13: return "Dududududidudadidu";
        }
        return "";
    }
}
