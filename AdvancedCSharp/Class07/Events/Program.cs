//Da izgradime market
//koristnici i mushterii
//publisher i subscriber
//clasa sto e publisher i clasa sto e subsriber
//user e subscribne kje se subne na supermarketot a
//supermarketot kje bide publisher
//site sto se subnati si doagjaat infomaciite kaj niv


//Kje ni treba event i delegati


//za sub treba PromotionHandler(ProductType productType)


//kreirame entiteti
using Events.Enums;
using Events.Models;

Market market = new Market
{
    Id = 1,
    Name = "Super Market",
    ProductTypeOnPromotion = ProductType.Electronics
};

User user1 = new User(1, "Bob Bobsky", "bobsky@gmail.com", 24,ProductType.Electronics);
User user2 = new User(2, "John Doe", "john@gmail.com",26 ,ProductType.Food);
User user3 = new User(3, "Jane Bobsky", "jane@gmail.com", 28,ProductType.Other);

market.SubscribeForPromotion(user1.ReadPromotion, user1.Email);
market.SubscribeForPromotion(user2.ReadPromotion, user2.Email);
//vaka vo momentot se povikva a treba kako referenca da se povika


market.SendPromotions();