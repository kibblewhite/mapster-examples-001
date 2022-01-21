// See https://aka.ms/new-console-template for more information
using mapster_example_001;

GuidsCollection guids_collection = new();

SourceClassDto source_class_dto = new()
{
    Source_001_Guid_As_String = guids_collection.Source_001.ToString(),
    Source_002_Guid_As_Guid = guids_collection.Source_002,
    Common_003_Guid_As_Guid = guids_collection.Source_003,
    Common_DTO = new()
    {
        CreatedDate = DateTime.UtcNow,
        Id = 79,
        Name = "Joe.B"
    }
};

Console.WriteLine("Heylo, World!");


#region [Static.TypeAdapterConfig]
Console.WriteLine("=======// Static.TypeAdapterConfig //=======");
TypeAdapterConfig<SourceClassDto, DestinationClassDto>.NewConfig()
    .Map(dest => dest.Destination_001_Guid_As_Guid, src => src.Source_001_Guid_As_String)
    .Map(dest => dest.Destination_002_Guid_As_String, src => src.Source_002_Guid_As_Guid)
    .Compile();
DestinationClassDto static_dto = TypeAdapter.Adapt<SourceClassDto, DestinationClassDto>(source_class_dto);
Output.ToConsoleAndWait(source_class_dto, static_dto);
#endregion [Static.TypeAdapterConfig]

#region [TypeAdapterConfig]
Console.WriteLine("=======// TypeAdapterConfig //=======");
TypeAdapterConfig config = new();
config.When((srcType, destType, mapType) =>
{
    return srcType == destType;
});
DestinationClassDto new_dto = source_class_dto.Adapt<DestinationClassDto>(config);
Output.ToConsoleAndWait(source_class_dto, new_dto);
#endregion [TypeAdapterConfig]

#region [TypeAdapterConfig.GlobalSettings.Clone]
Console.WriteLine("=======// TypeAdapterConfig.GlobalSettings.Clone //=======");
TypeAdapterConfig clone_config = TypeAdapterConfig.GlobalSettings.Clone();
DestinationClassDto clone_dto = source_class_dto.Adapt<DestinationClassDto>(config);
Output.ToConsoleAndWait(source_class_dto, clone_dto);
#endregion [TypeAdapterConfig.GlobalSettings.Clone]
