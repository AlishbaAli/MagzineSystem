using Domain;

namespace Subscribers
{
    public class people
    {
        public void OnMagpublished(object? sender, MagPublishedEventArgs e)
        {
            
            Console.WriteLine("Email was recived for Magzine publishing");
        }
    }
}