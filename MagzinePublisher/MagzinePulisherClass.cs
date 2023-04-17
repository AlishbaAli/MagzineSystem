using Domain;

namespace MagzinePublisher
{
    public class MagzinePulisherClass
    {
        public event EventHandler<MagPublishedEventArgs> NewMagzinePublished;

        public void OnMagpublished(string linktoMag)
        {
            
            var newmag = new MagPublishedEventArgs(linktoMag);

            Published(this, newmag);
        }

        public void Published(object? sender, MagPublishedEventArgs e)
        {
            NewMagzinePublished?.Invoke(sender, e);
        }
    }

}
}