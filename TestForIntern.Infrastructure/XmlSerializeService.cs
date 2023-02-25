using System.Xml.Serialization;
using TestForIntern.Logic.Dtos;
using TestForIntern.Logic.Interfaces;

namespace TestForIntern.Infrastructure;

public class XmlSerializeService : IXmlSerializeService
{
    private readonly HttpClient _httpClient;

    public XmlSerializeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://yastatic.net/market-export/_/partner/help/");
    }

    public async Task<YmlCatalogUniversalDto> GetDeserializedData()
    {
        var serializer = new XmlSerializer(typeof(YmlCatalogUniversalDto));

        var data = await _httpClient.GetStringAsync("YML.xml");

        using (var reader = new StringReader(data))
        {
            return (YmlCatalogUniversalDto) serializer.Deserialize(reader);
        }
    }
}