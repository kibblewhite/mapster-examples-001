// See https://aka.ms/new-console-template for more information
using mapster_example_001;

Console.WriteLine("Heylo, World!");

TypeAdapterConfig<SourceClassDto, DestinationClassDto>.NewConfig()
    .Map(dest => dest.Destination_001_Guid_As_Guid, src => src.Source_001_Guid_As_String)
    .Map(dest => dest.Destination_002_Guid_As_String, src => src.Source_002_Guid_As_Guid)
    .Compile();

Guid Source_001 = Guid.NewGuid();
Guid Source_002 = Guid.NewGuid();

SourceClassDto source_class_dto = new()
{
    Source_001_Guid_As_String = Source_001.ToString(),
    Source_002_Guid_As_Guid = Source_002
};

DestinationClassDto dto = TypeAdapter.Adapt<SourceClassDto, DestinationClassDto>(source_class_dto);

Console.WriteLine($"     Source_001: {Source_001}");
Console.WriteLine($"Destination_001: {dto.Destination_001_Guid_As_Guid}");
Console.WriteLine($"     Source_002: {Source_002}");
Console.WriteLine($"Destination_002: {dto.Destination_002_Guid_As_String}");

Console.ReadLine();
