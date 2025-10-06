namespace PasswordGenerateLib;

public class SpecialPassword : PasswordBase
{
    public SpecialPassword(params PasswordBase[] passwordBase) : base(passwordBase)
    {
        
    }

    public SpecialPassword() : base()
    {
        
    }

    protected override string GetSymbols()
    {
        return "!@#$%^&*()_+-=[]{}|;:,.<>?";
    }
}
