using PrepForMSCD.Events;
using System;

namespace PrepwayMSCD.Events
{
    public class Youtube
    {
        public delegate void Publisher(object source,VideoEventArgs args);

        public event Publisher VideoUploaded;
        public void UploadVideo(Video video)
        {
            Console.WriteLine("New video is successfully uploaded");
            OnVideoUploaded(video);
        }

        protected virtual void OnVideoUploaded(Video video)
        {
            if(VideoUploaded != null)
                VideoUploaded(this,new VideoEventArgs { Video = video});
        }
    }
}
