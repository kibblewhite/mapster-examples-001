namespace mapster_example_001;

public sealed class SourceClassDto
{
    /// <summary>
    /// This is the source guid as a string (001)
    /// </summary>
    /// <remarks>Will attempt to map this to destination guid as a guid (DestinationClassDto.Destination_001_Guid_As_Guid / destination type System.Guid)</remarks>
    public string Source_001_Guid_As_String { get; init; } = default!;

    /// <summary>
    /// This is the source guid as a guid (002)
    /// </summary>
    /// <remarks>Will attempt to map this to destination guid as a string (DestinationClassDto.Destination_001_Guid_As_String / destination type System.String)</remarks>
    public Guid Source_002_Guid_As_Guid { get; init; } = default!;
}

