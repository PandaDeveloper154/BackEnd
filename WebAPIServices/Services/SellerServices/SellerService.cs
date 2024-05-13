
using WebAPIServices.Models;

namespace WebAPIServices.Services.SuperHeroService
{
    public class SellerService : ISellerService
    {
        private static List<Seller> sellers = new List<Seller>
            {
                new Seller{
                    Id = 1,
                    Name="Spider Man",
                    Email="Peter@gmail.com",
                    Password="Parker"
                },
                new Seller{
                    Id = 2,
                    Name="Iron Man",
                    Email="Tony@gmail.com",
                    Password="Stark"
                }
            };
        public List<Seller> AddSeller(Seller seller)
        {
            sellers.Add(seller);
            return sellers;
        }


        public List<Seller>? DeleteSeller(int id)
        {
            var seller = sellers.Find(x => x.Id == id);
            if (seller is null)
                return null;
            sellers.Remove(seller);
            return sellers;
        }


        public List<Seller> GetAllSellers()
        {
            return sellers;
        }


        public Seller? GetSingleSeller(int id)
        {
            var seller = sellers.Find(x => x.Id == id);
            if (seller is null)
                return null;
            return seller;
        }


        public List<Seller>? UpdateSeller(int id, Seller request)
        {
            var seller = sellers.Find(x => x.Id == id);
            if (seller is null)
                return null;
            seller.Name = request.Name;
            seller.Email = request.Email;
            seller.Password = request.Password;
            return sellers;
        }
    }
}
