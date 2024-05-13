namespace WebAPIServices.Services.SuperHeroService
{
    public interface ISellerService
    {
        
        List<Seller> GetAllSellers();
        Seller? GetSingleSeller(int id);
        List<Seller> AddSeller(Seller seller);
        List<Seller>? UpdateSeller(int id, Seller request);
        List<Seller>? DeleteSeller(int id);
    }
}
