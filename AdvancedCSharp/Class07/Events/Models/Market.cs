using Events.Enums;

namespace Events.Models
{
    public class Market
    {
        //definiranje ne event so klucen zbor event
        //sekoj event mora da znae so kakvi subscriberi kje raboti
        //so kakvi metodi odnosno akcii ovoj event kje raboti
        //kakov tip na metoda znaci so delegati
        //SEKOJ EVENT TREBA DA ZNAE SO KAKOV TIP METODI KJE RABOTI
        public delegate void PromptionHandler(ProductType productType);
        private event PromptionHandler OnPromotionSent;//gromot znaci deka stanuva zbor za event
         
        //MNOZESTVO NA POVEKJE FUNKCII E OVA EVENT
        //sto ekaat da se izvrsat so INVOKE

        //metodata mora da e ista so eventot

        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductTypeOnPromotion { get; set; }
        List<string> SubscribersEmails { get; set; } = [];
        List<string> UnsubscribeReasons { get; set; } = [];

        //da si kreirame soodvetni metodi sto kje pomognat da se subsrvibne userto na event i da se kreira samiot event,
        //kako da se triggerne itn.
        
        public void SubscribeForPromotion(PromptionHandler handler, string email)
        {
            //na ovoj event go dodavame handlerot znaci vikame subscribe
            OnPromotionSent += handler;
            SubscribersEmails.Add(email);
        }
        

        public void SendPromotions()
        {
            Console.WriteLine("==========");
            Console.WriteLine($"Market {Name} is sending promotions for {ProductTypeOnPromotion}");
            Console.WriteLine("...Sending...");
            Thread.Sleep(2000);
            NotifySubscribers();
        }

        //treba da se trigerne eventot
        private void NotifySubscribers()
        {
            //da go tirgenreme i site sto se subnati da dobijat infomacija
            //OnPromotionSent(ProductTypeOnPromotion);
            OnPromotionSent?.Invoke(ProductTypeOnPromotion);

        }



    }
}
