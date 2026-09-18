namespace lab_1;


public class Token
{
    public TokenType Type;
    public string Value;

    public Token(TokenType type, string value)
    {
        this.Type = type;
        this.Value = value;
    }
}