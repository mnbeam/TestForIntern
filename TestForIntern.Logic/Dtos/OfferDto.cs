namespace TestForIntern.Logic.Dtos;

public class OfferDto
{
    public int ExternalOfferId { get; set; }

    public string? Url { get; set; }

    public decimal Price { get; set; }

    public string CurrencyId { get; set; }

    public int CategoryId { get; set; }

    public string? Picture { get; set; }

    public bool Delivery { get; set; }

    public string? Artist { get; set; }

    public string? Title { get; set; }

    public int Year { get; set; }

    public string? Media { get; set; }

    public string? Description { get; set; }
}