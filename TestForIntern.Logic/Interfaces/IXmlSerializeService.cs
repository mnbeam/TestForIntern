using TestForIntern.Logic.Dtos;

namespace TestForIntern.Logic.Interfaces;

public interface IXmlSerializeService
{
    Task<YmlCatalogUniversalDto> GetDeserializedData();
}