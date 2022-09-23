// See https://aka.ms/new-console-template for more information
using MediaPlayerAdapterExample;

Console.WriteLine("Hello, Media Player Adapter Pattern !");


AudioPlayer audioPlayer = new AudioPlayer();

audioPlayer.Play("mp3", "beyond the horizon.mp3");
audioPlayer.Play("mp4", "alone.mp4");
audioPlayer.Play("vlc", "far far away.vlc");
audioPlayer.Play("avi", "mind me.avi");