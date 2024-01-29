using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Playlist
{
    private List<Track> tracks = new List<Track>();
    public void Shuffle()
    {
        Track[] temp = new Track[tracks.Count];
        Random random = new Random();
        var tempIndex = 0;
        while (tracks.Count > 0)
        {
            var index = random.Next(tracks.Count);
            temp[tempIndex] = tracks[index];
            tracks.RemoveAt(index);
            tempIndex++;
        }
        foreach (var track in temp)
        {
            tracks.Add(track);
        }
    }
    public Track[] GetTracks()
    {
        return tracks.ToArray();
    }
    public void AddTrack(Track track)
    {
        tracks.Add(track);
    }
    public void RemoveTrack(Track track)
    {
        tracks.Remove(track);
    }
}
