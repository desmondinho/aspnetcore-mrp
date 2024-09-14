namespace BlazorApp1.Client;

public class Ok( string value, string value2 )
{
    public string Value { get; } = value;
    public string Value2 { get; } = value2;
}

public class NotOk
{
    public string Value { get; }
    public string? Value2 { get; }

    public NotOk( string value )
    {
        Value = value;
    }

    public NotOk( string value, string value2 ) : this( value )
    {
        Value2 = value2;
    }
}

public class AnotherNotOk
{
    public string? Value { get; }
    public string? Value2 { get; }

    public AnotherNotOk() { }

    public AnotherNotOk( string value )
    {
        Value = value;
    }

    public AnotherNotOk( string value, string value2 ) : this( value )
    {
        Value2 = value2;
    }
}
