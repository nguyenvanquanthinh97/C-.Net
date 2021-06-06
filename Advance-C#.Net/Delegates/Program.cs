using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            /*PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness*/;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += ApplyRemoveRedEyes;
            processor.Process("photo.jpg", filterHandler);
        }

        public static void ApplyRemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Remove Red Eyes...");
        }
    }
}
