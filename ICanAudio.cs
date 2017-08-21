namespace SmartphoneInterface
{
    interface ICanAudio
    {
        string Song {get; set;}
        void PlaySong();
        void ArtistName();
        void AlbumName();
    }
}