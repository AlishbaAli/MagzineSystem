namespace Domain
{
    public class MagPublishedEventArgs : EventArgs
    {
        public string linktoMag { get; set; }

        public MagPublishedEventArgs(string linktoMag)
        {
            this.linktoMag = linktoMag;
        }
    }
}