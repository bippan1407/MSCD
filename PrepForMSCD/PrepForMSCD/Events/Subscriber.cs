using PrepForMSCD.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepwayMSCD.Events
{
    public class Subscriber
    {
    public void OnVideoUploaded(object source,VideoEventArgs args)
        {
            Console.WriteLine("Uploaded new video " +args.Video.Title);
        } 
    }
}
