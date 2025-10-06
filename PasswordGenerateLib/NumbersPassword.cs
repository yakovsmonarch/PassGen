namespace PasswordGenerateLib;

public class NumbersPassword : PasswordBase
{
    public NumbersPassword(params PasswordBase[] passwordBase) : base(passwordBase)
    {
    }

    public NumbersPassword() : base()
    {
    }

    protected override string GetSymbols()
    {
        return "0123456789";
    }
}