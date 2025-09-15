namespace PasswordGenerateLib;

public class SymbolsPassword : PasswordBase
{
    public SymbolsPassword(PasswordBase passwordBase) : base(passwordBase)
    {
    }

    public SymbolsPassword() : base()
    {
    }

    protected override string GetSymbols()
    {
        return "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    }
}