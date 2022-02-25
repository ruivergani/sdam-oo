using System;
using System.Collections.Generic;
using System.Text;

namespace StaticANDthis
{
    class Song
    {
        // static means that belongs to the class not to the object (about the CLASS not OBJECT)
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; // common to all the class

        public Song(string aTitle, string aArtist, int aDuration) // basic constructor
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++; // increment the static attribute of the class Song
        }
    }
}
