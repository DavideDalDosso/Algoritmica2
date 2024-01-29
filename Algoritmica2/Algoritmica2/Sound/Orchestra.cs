using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Orchestra
{
    public string name { get; set; }
    private List<Musician> musicians = new List<Musician>();
    public void AddMusician(Musician musician)
    {
        musicians.Add(musician);
    }
    public void RemoveMusician(Musician musician)
    {
        musicians.Remove(musician);
    }
    public string PlayMusic(int amount)
    {
        var result = "";
        Random random = new Random();
        for(int i=0; i < amount; i++)
        {
            result += musicians[random.Next(musicians.Count)].PlaySound(random) + " ";
        }

        return result;
    }
}
