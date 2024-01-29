using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramSound
{
    public static void Main(string[] args)
    {
        var piano = new Piano();
        var drums = new Drums();
        var mayo = new Mayo();
        var violin = new Violin();
        var trumpet = new Trumpet();

        var silentOrchestra = new Orchestra();
        var piano1 = new Musician();
        piano1.name = "Piano1";
        piano1.instrument = piano;
        var piano2 = new Musician();
        piano2.name = "Piano2";
        piano2.instrument = piano;
        var trumpet1 = new Musician();
        trumpet1.name = "Trumpet1";
        trumpet1.instrument = trumpet;
        var trumpet2 = new Musician();
        trumpet2.name = "Trumpet2";
        trumpet2.instrument = trumpet;
        var violin1 = new Musician();
        violin1.name = "Violin1";
        violin1.instrument = violin;
        var violin2 = new Musician();
        violin2.name = "Violin2";
        violin2.instrument = violin;
        var drums1 = new Musician();
        drums1.name = "Drums1";
        drums1.instrument = drums;
        var drums2 = new Musician();
        drums2.name = "Drums2";
        drums2.instrument = drums;
        var mayo1 = new Musician();
        mayo1.name = "Mayo1";
        mayo1.instrument = mayo;

        Console.WriteLine("From break and ruin, the most beautiful performance begins\n\n");

        Console.WriteLine("The conductor begins to direct the apocalypse\n\n");
        silentOrchestra.AddMusician(trumpet1);
        silentOrchestra.AddMusician(violin1);
        silentOrchestra.AddMusician(violin2 );

        Console.WriteLine(silentOrchestra.PlayMusic(20));
        Console.WriteLine("\n\n");
        Console.WriteLine("Spectators start to forget everything and show fervent adoration toward the symphony. The emotion soon turns into internal insanity, driving them to attack anyone near them\n\n");
        silentOrchestra.RemoveMusician(trumpet1);
        silentOrchestra.AddMusician(piano1);
        silentOrchestra.AddMusician(piano2);
        silentOrchestra.AddMusician(drums1);

        Console.WriteLine(silentOrchestra.PlayMusic(40));
        Console.WriteLine("\n\n");
        Console.WriteLine("The orchestra gives impetus to the music, bringing the entire department to its demise\n\n");
        silentOrchestra.RemoveMusician(violin1);
        silentOrchestra.RemoveMusician(violin2);
        silentOrchestra.RemoveMusician(piano1);
        silentOrchestra.RemoveMusician(piano2);
        silentOrchestra.AddMusician(drums2);
        silentOrchestra.AddMusician(mayo1);

        Console.WriteLine(silentOrchestra.PlayMusic(80));
        Console.WriteLine("\n\n");
        Console.WriteLine("When all the performers have gathered, the music that no one can hear but everyone can listen to begins\n\n");
        silentOrchestra.AddMusician(violin1);
        silentOrchestra.AddMusician(violin2);
        silentOrchestra.AddMusician(piano1);
        silentOrchestra.AddMusician(piano2);
        silentOrchestra.RemoveMusician(mayo1);

        Console.WriteLine(silentOrchestra.PlayMusic(80));
        Console.WriteLine("\n\n");
        Console.WriteLine("~ THE FINALE ~");
        silentOrchestra.AddMusician(trumpet1);
        silentOrchestra.AddMusician(trumpet2);
        silentOrchestra.AddMusician(mayo1);
        silentOrchestra.RemoveMusician(piano1);
        silentOrchestra.RemoveMusician(piano2);

        Console.WriteLine(silentOrchestra.PlayMusic(40));


    }
}
