using System;

namespace StaticClassesMethods
{
    class Song
    {
        private string name;
        private string artist;
        private int duration;

        // static attributes can not be changed from outside, even if they are public.
        // But htey can be accessed as CLASSANME.STATISVALUE unlike other variables;
        // you can either make them PUBLIC or do PRIVATE and use get/set;
        public static int songCount = 0;

        /// <summary>
        /// Construct a new song
        /// </summary>
        /// <param name="aName">Song name</param>
        /// <param name="aArtist">Artist name</param>
        public Song(string aName, string aArtist)
        {
            this.name = aName;
            this.artist = aArtist;
            songCount++;
        }

        /// <summary>
        /// Construct a new song with duration
        /// </summary>
        /// <param name="aName">Song name</param>
        /// <param name="aArtist">Artist name</param>
        public Song(string aName, string aArtist, int aDuration)
        {
            try
            {
                this.name = aName;
                this.artist = aArtist;
                this.duration = aDuration;
                songCount++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }

        /// <summary>
        /// Get/set song name
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;

                // can add logic here, for example regex and then do an excepion if the input doesnt match regex.
            }
        }

        /// <summary>
        /// Get/set artist name
        /// </summary>
        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                this.artist = value;
            }
        }

        /// <summary>
        /// Get/set duration. MUST BE IN SECONDS, aka INT.
        /// </summary>
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                try
                {
                    this.duration = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
            }
        }

        /// <summary>
        /// This would be used for example, if an album has many songs. unlike static songCount, this can only be used on a created object, not a class.
        /// Static methods can be accessed on CLASS level.
        /// </summary>
        /// <returns></returns>
        public int getSongCount()
        {
            // you can not access static variables with this. attribute.,
            return songCount;
        }
    }
}
