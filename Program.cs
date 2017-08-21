using System;

namespace SmartphoneInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var iPhone = new Smartphone();
            iPhone.AlbumName();
            iPhone.ArtistName();
            iPhone.PlaySong();

            iPhone.SendImageMessage();
            iPhone.SendText();
            iPhone.ReceiveText();

            iPhone.TakePic();
            iPhone.EditPic();
            iPhone.SavePic();
        }
    }
}
