namespace MagzineSystem
{
   
        public class Program
        {
            static void Main(string[] args)
            {
                
                Subscribers subs = new Subscribers();
               
                MagzinePublisherClass  mag = new MagzinePublisherClass();
              
                mag.NewMagzinePublished += subs.OnCallTo911;
               
                
        }

    
}