namespace mapster_example_001;

public sealed class DestinationClassDto
{
    /// <summary>
    /// This is the destination guid as a guid (001)
    /// </summary>
    /// <remarks>Will attempt to map from source guid as a string (DestinationClassDto.Source_001_Guid_As_String / source type System.String)</remarks>
    public Guid Destination_001_Guid_As_Guid { get; init; } = default!;

    /// <summary>
    /// This is the destination guid as a string (002)
    /// </summary>
    /// <remarks>Will attempt to map from source guid as a guid (SourceClassDto.Source_002_Guid_As_Guid / source type System.Guid)</remarks>
    public string Destination_002_Guid_As_String { get; init; } = default!;
}

