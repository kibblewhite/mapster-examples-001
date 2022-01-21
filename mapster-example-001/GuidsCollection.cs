namespace mapster_example_001;

public class GuidsCollection
{
    public Guid Source_001 { get; init; }
    public Guid Source_002 { get; init; }
    public Guid Source_003 { get; init; }

    public GuidsCollection()
    {
        Source_001 = Guid.NewGuid();
        Source_002 = Guid.NewGuid();
        Source_003 = Guid.NewGuid();
    }
}

