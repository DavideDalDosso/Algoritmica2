using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramPlaylist
{
    public static void Main(string[] args)
    {
        Playlist playlist = new Playlist();
        Track track1 = new Track();
        track1.name = "Never gonna give you up";
        track1.description = "You know the rules, and so do I";
        Track track2 = new Track();
        track2.name = "Iron Lotus";
        track2.description = "I AM FIIIIIIIIIIIIRE, burn those who dare to care for me.";
        Track track3 = new Track();
        track3.name = "SmashMouth - All star";
        track3.description = "Somebody once told me the world was gonna roll me";
        Track track4 = new Track();
        track4.name = "Gorillaz - DARE";
        track4.description = "It's coming up, It's coming up It's coming up";
        Track track5 = new Track();
        track5.name = "Harder Better Faster Stronger";
        track5.description = "Work it harder, make it better, do it faster, makes us stronger";
        Track track6 = new Track();
        track6.name = "Roland Style - Library of Ruina + Gagnam Style Mashup";
        track6.description = "You must gagnam... just like I have...";
        Track track7 = new Track();
        track7.name = "Smooth Criminal";
        track7.description = "You've been hit by- A smooth criminal";
        Track track8 = new Track();
        track8.name = "In the Belly of a Shark";
        track8.description = "So here I lie in the belly of a shark";

        playlist.AddTrack(track1);
        playlist.AddTrack(track2);
        playlist.AddTrack(track3);
        playlist.AddTrack(track4);
        playlist.AddTrack(track5);
        playlist.AddTrack(track6);
        playlist.AddTrack(track7);
        playlist.AddTrack(track8);

        playlist.Shuffle();

        foreach(var track in playlist.GetTracks())
        {
            Console.WriteLine(track.name);
            Console.WriteLine(track.description);
        }
    }
}
