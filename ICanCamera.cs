namespace SmartphoneInterface
{
    interface ICanCamera
    {
        string Picture {get; set;}
        void TakePic();
        void SavePic();
        void EditPic();
    }
}