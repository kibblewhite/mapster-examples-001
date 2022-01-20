namespace mapster_example_001;

public class CodeGenerationRegister : ICodeGenerationRegister
{
    public void Register(CodeGenerationConfig config)
    {
        config.AdaptTo("[name]Dto")
            .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), nameof(mapster_example_001));

        config.GenerateMapper("[name]Mapper")
                .ForType<SourceClassDto>()
                .ForType<DestinationClassDto>();
    }
}
