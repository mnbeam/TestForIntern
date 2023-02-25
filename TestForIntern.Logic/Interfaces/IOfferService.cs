using TestForIntern.Logic.Dtos;

namespace TestForIntern.Logic.Interfaces;

public interface IOfferService
{
    Task<OfferDto> GetOfferById(int offerId);

    Task<int> CreateOffer(OfferDto offerDto);

    Task<OfferDto> GetOfferFromExternalSourceById(int offerId);
}