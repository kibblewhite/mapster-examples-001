namespace mapster_example_001;

public static class Output
{
    public static void ToConsoleAndWait(SourceClassDto source_dto, DestinationClassDto destination_dto)
    {
        Console.WriteLine($"             Source_001: {source_dto.Source_001_Guid_As_String}");
        Console.WriteLine($"        Destination_001: {destination_dto.Destination_001_Guid_As_Guid}");
        Console.WriteLine($"             Source_002: {source_dto.Source_002_Guid_As_Guid}");
        Console.WriteLine($"        Destination_002: {destination_dto.Destination_002_Guid_As_String}");
        Console.WriteLine($"             Source_003: {source_dto.Common_003_Guid_As_Guid}");
        Console.WriteLine($"        Destination_003: {destination_dto.Common_003_Guid_As_Guid}");
        ToConsole(source_dto.Common_DTO, destination_dto.Common_DTO);
        Console.ReadLine();
    }

    public static void ToConsole(CommonDto source_common_dto, CommonDto destination_common_dto)
    {

        Console.WriteLine($"------------------------");
        Console.WriteLine($"              Source_Id: {source_common_dto?.Id}");
        Console.WriteLine($"         Destination_Id: {destination_common_dto?.Id}");

        Console.WriteLine($"            Source_Name: {source_common_dto?.Name}");
        Console.WriteLine($"       Destination_Name: {destination_common_dto?.Name}");

        Console.WriteLine($"     Source_CreatedDate: {source_common_dto?.CreatedDate}");
        Console.WriteLine($"Destination_CreatedDate: {destination_common_dto?.CreatedDate}");

    }

}

