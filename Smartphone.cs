using System;

namespace SmartphoneInterface
{
    public class Smartphone : ICanCamera, ICanAudio, ICanText
    {
        public string TextMessage {get;set;}
        public string Picture {get;set;}
        public string Song {get;set;}

        public void AlbumName()
        {
            Console.WriteLine("Showing Album Name.");

        }

        public void ArtistName()
        {
            Console.WriteLine("Showing Artist name.");
        }

        public void EditPic()
        {
            Console.WriteLine("Editing Picture.");

        }

        public void PlaySong()
        {
            Console.WriteLine("Playing Song.");
        }

        public void ReceiveText()
        {
            Console.WriteLine("Receiving Message.");

        }

        public void SavePic()
        {
            Console.WriteLine("Saving Picture.");
            
        }

        public void SendImageMessage()
        {
            Console.WriteLine("Sending Image Message.");
            
        }

        public void SendText()
        {
            Console.WriteLine("Sending Text.");
        }

        public void TakePic()
        {
            Console.WriteLine("Taking Picture");
        }
    }
}