using Microsoft.EntityFrameworkCore;
using TestForIntern.Domain.Entities;
using TestForIntern.Logic.Dtos;
using TestForIntern.Logic.Interfaces;

namespace TestForIntern.Logic.Services;

internal class OfferService : IOfferService
{
    private readonly IAppDbContext _dbContext;
    private readonly IXmlSerializeService _xmlSerializeService;

    public OfferService(IAppDbContext dbContext, IXmlSerializeService xmlSerializeService)
    {
        _dbContext = dbContext;
        _xmlSerializeService = xmlSerializeService;
    }

    public async Task<OfferDto> GetOfferById(int offerId)
    {
        var offer = await _dbContext.Offers.FirstOrDefaultAsync(o => o.OfferId == offerId);

        if (offer == null)
        {
            throw new Exception("offer not found");
        }

        return new OfferDto
        {
            OfferId = offer.OfferId,
            Url = offer.Url,
            Price = offer.Price,
            CurrencyId = offer.CurrencyId,
            CategoryId = offer.CategoryId,
            Picture = offer.Picture,
            Delivery = offer.Delivery,
            Artist = offer.Artist,
            Year = offer.Year,
            Description = offer.Description
        };
    }

    public async Task<int> CreateOffer(OfferDto offerDto)
    {
        var offerIsExist = await _dbContext.Offers.AnyAsync(o => o.OfferId == offerDto.OfferId);

        if (offerIsExist)
        {
            return offerDto.OfferId;
        }

        var offer = new Offer
        {
            OfferId = offerDto.OfferId,
            Url = offerDto.Url,
            Price = offerDto.Price,
            CurrencyId = offerDto.CurrencyId,
            CategoryId = offerDto.CategoryId,
            Picture = offerDto.Picture,
            Delivery = offerDto.Delivery,
            Artist = offerDto.Artist,
            Year = offerDto.Year,
            Description = offerDto.Description
        };

        _dbContext.Offers.Add(offer);
        await _dbContext.SaveChangesAsync();

        return offer.Id;
    }

    public async Task<OfferDto> GetOfferFromExternalSourceById(int offerId)
    {
        var data = await _xmlSerializeService.GetDeserializedData();

        var offer = data.Shop.Offers.Offer.FirstOrDefault(o => o.Id == offerId);

        return new OfferDto
        {
            OfferId = offer.Id,
            Url = offer.Url,
            Price = offer.Price,
            CurrencyId = offer.CurrencyId,
            CategoryId = offer.CategoryId.Text,
            Picture = offer.Picture,
            Delivery = offer.Delivery,
            Artist = offer.Artist,
            Year = offer.Year,
            Description = offer.Description
        };
    }
}