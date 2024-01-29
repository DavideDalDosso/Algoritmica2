using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Musician
{
    public string name { get; set; }
    public IPlayable instrument { get; set; }
    public string PlaySound(Random random)
    {
        return instrument.GetSound(random);
    }
}
