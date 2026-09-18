using lab_1.Exceptions;

namespace lab_1.Lexer;


public class Lexer
{
    private string _input;
    private char _currentToken;
    
    private List<Token> _tokens;
    private int _position;
    private char _previous;

    public Lexer()
    {
        _input = "";
        _tokens = new List<Token>();
        _position = 0;
        _previous = '\0';
    }
    
    public string Input
    {
        get => _input;
        set => _input = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void BuildTokens()
    {
        for (int i = 0; i < _input.Length; i++)
        {
            switch (_input[i])
            {
                case '+': 
                    _tokens.Add(new Token(TokenType.Plus, "+"));
                    break;
                case '-':
                    _tokens.Add(new Token(TokenType.Minus, "-"));
                    break;
                case '*':
                    _tokens.Add(new Token(TokenType.Multiply, "*"));
                    break;
                case '/':
                    _tokens.Add(new Token(TokenType.Divide, "/"));
                    break;
                
            }
        }
    }

    public string ReadNumber(ref int i)
    {
        int start = i;
        bool WasDot = false;

        while (i < _input.Length && (_input[i] == '.' || char.IsDigit(_input[i])))
        {
            i++;
            if (WasDot && _input[i] == '.') throw new SyntaxException("Invalid number");
        }
        
        return _input.Substring(start, i - start);
    }
}