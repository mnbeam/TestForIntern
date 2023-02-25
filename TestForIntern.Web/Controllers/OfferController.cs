using Microsoft.AspNetCore.Mvc;
using TestForIntern.Logic.Interfaces;

namespace TestForIntern.Web.Controllers;

[Route("[controller]/[action]")]
public class OfferController : Controller
{
    private readonly IOfferService _offerService;

    public OfferController(IOfferService offerService)
    {
        _offerService = offerService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var offer = await _offerService.GetOfferFromExternalSourceById(12344);

        Console.WriteLine(offer.OfferId);

        var result = await _offerService.CreateOffer(offer);

        Console.WriteLine(result);

        var viewModel = await _offerService.GetOfferById(result);

        return View(viewModel);
    }
}