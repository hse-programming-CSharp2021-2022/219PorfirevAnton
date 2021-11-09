using System;

namespace Task01
{
    class VideoFile
    {
        string name;
        int duration;
        int quality;
        public VideoFile(string name_, int duration_, int quality_)
        {
            name = name_;
            duration = duration_;
            quality = quality_;
        }
        public int Size { set { int size = value; } get { return duration * quality; } }
        public string Name { set { name = value; } get { return name; } }
        public int Quality { set { quality = value; } get { return quality; } }
        public int Duration { set { duration = value; } get { return duration; } }
        public override string ToString()
        {
            return $"Имя: {name}, Длительность: {duration}, Качество: {quality}, Размер: {this.Size}";
        }
        public string GetInfo()
        {
            return this.ToString();
        }
    }
    class Program
    {
        public static void Main()
        {
            string com = "Yes";
            while (com != "No")
            {
                VideoFile video = new VideoFile("hello", 180, 480);
                Random rnd = new Random();
                int n = rnd.Next(5, 16);
                VideoFile[] videos = new VideoFile[n];
                for (int i = 0; i < n; ++i)
                {
                    int dur = rnd.Next(60, 360);
                    int qua = rnd.Next(100, 1000);
                    videos[i] = new VideoFile($"video{i + 1}", dur, qua);
                }
                //Console.WriteLine(video);
                for (int i = 0; i < n; ++i)
                {
                    //Console.WriteLine(videos[i]);
                    if (videos[i].Size > video.Size)
                    {
                        Console.WriteLine(videos[i]);
                    }
                }
                Console.WriteLine("Хотите продолжить?(Yes/No)");
                com = Console.ReadLine();
            }
        }
    }
}
