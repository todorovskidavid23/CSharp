using Events.Enums;

namespace Events.Models
{
    //subsriberot na nastiot sistem
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public ProductType FavouriteProductType { get; set; }
        public User(int id, string name, string email, int age, ProductType favouriteProductType)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
            FavouriteProductType = favouriteProductType;
        }

        public void ReadPromotion(ProductType productType)
        {
            Console.WriteLine($"Mr/Mrs {Name}, theproducts of type {productType} are on promotion");
        }
    }
}
