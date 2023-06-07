//---------------------LAB 5 - DEYNNI ALMAZAN ---------------------------------------------------------

using System;
using System.Collections.Generic;

//Sources used to find information related with stacks and queue:
//https://social.technet.microsoft.com/wiki/contents/articles/51479.c-implementation-of-stack-and-queue-using-linked-list.aspx
//https://medium.com/codex/how-to-use-c-stacks-and-queues-55843872c319

Stack<string> previousSongs = new Stack<string>(); //last in, first out
Queue<string> upcomingSongs = new Queue<string>(); //first in, first out

bool activePlaylist = true;

while (activePlaylist)

{
    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit\n");


    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Enter Song Name:");
            string songName = Console.ReadLine();

            upcomingSongs.Enqueue(songName);
            Console.WriteLine($"\"{songName}\" added to your playlist.");
            Console.WriteLine("Next song - \"" + upcomingSongs.Peek() + "\"");
            break;

        case "2":

            if (upcomingSongs.Count > 0)
            {
                string currentSong = upcomingSongs.Dequeue();
                previousSongs.Push(currentSong);
                Console.WriteLine("Now playing \"" + currentSong + "\"");

                if (upcomingSongs.Count > 0)
                {
                    Console.WriteLine("Next song \"" + upcomingSongs.Peek() + "\"");
                }
                else
                {
                    Console.WriteLine("Next song: none queued");
                }
            }
            else
            {
                Console.WriteLine("There are no songs in the playlist.");
            }
            break;

        case "3":
            if (upcomingSongs.Count > 0)
            {
                upcomingSongs.Dequeue();
                if (upcomingSongs.Count > 0)
                {
                    Console.WriteLine("Next song \"" + upcomingSongs.Peek() + "\"");
                }
                else
                {
                    Console.WriteLine("Next song: none queued");
                }
            }
            else
            {
                Console.WriteLine("There are no songs in the playlist.");
            }
            break;

        case "4":
            if (previousSongs.Count > 0)
            {
                string previousSong = previousSongs.Pop();
                upcomingSongs.Enqueue(previousSong);
                Console.WriteLine("Rewinded to \"" + previousSong + "\"");
                Console.WriteLine("Next song \"" + upcomingSongs.Peek() + "\"");
            }
            else
            {
                Console.WriteLine("There are no previous songs in the playlist.");
            }
            break;

        case "5":
            Console.WriteLine("Exit");
            activePlaylist = false;
            return;

        default:
            Console.WriteLine("Invalid input. Please try again.");
            break;
    }

}
