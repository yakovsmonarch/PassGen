namespace PasswordGenerateLib;

public abstract class PasswordBase
{
    protected string SourseSymbols = string.Empty;

    private Random _random = new Random();

    public PasswordBase(params PasswordBase[] passwordBase)
    {
        SourseSymbols = GetSymbols();
        foreach (PasswordBase p in passwordBase)
        {
            SourseSymbols += p.ToString();
        }
    }

    public PasswordBase()
    {
        SourseSymbols = GetSymbols();
    }

    public string Generate(uint size)
    {
        char[] result = new char[size];

        for (int i = 0; i < size; i++)
        {
            int item = _random.Next(0, SourseSymbols.Length);
            result[i] = SourseSymbols[item];
        }

        return new string(result);
    }

    public override string ToString()
    {
        return SourseSymbols;
    }

    protected abstract string GetSymbols();
}

