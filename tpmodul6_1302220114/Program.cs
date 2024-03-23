
using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int increaseAmount)
    {
        playCount += increaseAmount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("Judul: {0}", title);
        Console.WriteLine("Jumlah Tayangan: {0}", playCount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Masukkan nama praktikan
        string namaPraktikan = "Alif Adani Rahmat";

        var video = new SayaTubeVideo("Tutorial Design By Contract - " + namaPraktikan);
        video.PrintVideoDetails();

        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}


public class SayaTubeVideo
{
    // ...

    public void IncreasePlayCount(int increaseAmount)
    {
        if (increaseAmount > 10000000)
        {
            throw new ArgumentException("Penambahan play count maksimal 10.000.000 per panggilan method");
        }

        try
        {
            checked
            {
                playCount += increaseAmount;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Jumlah play count melebihi batas integer");
        }
    }

}


