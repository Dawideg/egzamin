namespace ConsoleApp6
{
    public class Album {
        public string artist;
        public string album;
        public int songsSumber;
        public int year;
        public int downloadNumber;

        public Album(string artist, string album, int songsNumber, int year, int downloadNmber)
        {
            this.artist = artist;
            this.album = album;
            this.songsSumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNmber;
        }

    }
    internal class Program
    {
        public static List<Album> ReadData() {
            List<string> linesList = new List<string>();
            List<Album> albumList = new List<Album>();
            foreach (string line in File.ReadLines("./Data.txt")) {
                if (line == "")
                {
                    Album album = new Album(linesList[0], linesList[1], int.Parse(linesList[2]), int.Parse(linesList[3]), int.Parse(linesList[4]));
                    albumList.Add(album);
                    linesList.Clear();
                }
                else { 
                linesList.Add(line);
                }

            }
            return albumList;
        }

        public static void ShowData(List<Album> albumList) {
            for (int i = 0; i < albumList.Count; i++) {
                Console.WriteLine(albumList[i].artist);
                Console.WriteLine(albumList[i].album);
                Console.WriteLine(albumList[i].songsSumber);
                Console.WriteLine(albumList[i].year);
                Console.WriteLine(albumList[i].downloadNumber);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            var data = ReadData();
            ShowData(data);
        }

    }
}
