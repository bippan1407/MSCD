using PrepwayMSCD.Maths;
using PrepwayMSCD.ExtensionMethods;
using System;
using PrepwayMSCD.Events;
using PrepForMSCD.Events;

namespace PrepwayMSCD.Delegates
{
    public static class DelegatesOperation
    {
        public static void Operations()
        {
            Operations operations = new Operations();
            Func<int, int, int> addFunc = operations.Addition;
            int result = addFunc(10, 10);
            Console.WriteLine(result);

            // Func delegate have a return type
            Func<float, float, int> subtractFunc = delegate (float a, float b) { return (int)(a - b); };
            Console.WriteLine(subtractFunc(10.50f, 5.5f));

            // Action delegate does not have return type 
            Action<string> printName = delegate (string name) { Console.WriteLine("This is action delegate " + name); };
            printName("Hello");

            // predicate is used to check  the input value and returns true or false
            Predicate<object> checkIfString = delegate (object name)
          {
              Console.WriteLine("Type of name is " + name.GetType());
              Console.WriteLine("Type of " + typeof(string));
              if (name.GetType().Equals(typeof(string)))
              {
                  return true;
              }
              else
              {
                  return false;
              }
          };
            Console.WriteLine("Input string is of type String " + checkIfString(1));
            int x = 100;
            Console.WriteLine(x.Addition(1));

            //adding video to youtube
            Youtube addVideo = new Youtube();
            Subscriber bippanSubscriber = new Subscriber();
            Subscriber shubhamSubscriber = new Subscriber();
            Video video = new Video() { Title = "Demo Tutorial Video" };
            //Subscribing to Event 
            addVideo.VideoUploaded += bippanSubscriber.OnVideoUploaded;
            addVideo.VideoUploaded += shubhamSubscriber.OnVideoUploaded;
            addVideo.UploadVideo(video);
        }
    }
}
