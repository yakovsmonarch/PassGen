using PasswordGenerateLib;

namespace TestPassGen;

public class PasswordRangeTest : BaseTest
{
    private PasswordBase _passwordBase;

    private List<string> _ranges;

    [SetUp]
    public void Setup()
    {
        _ranges = new List<string>();

        PasswordBase numberPass = new NumbersPassword();
        _ranges.Add(numberPass.ToString());

        PasswordBase symbolsPass = new SymbolsPassword();
        _ranges.Add(symbolsPass.ToString());

        PasswordBase specialPass = new SpecialPassword();
        _ranges.Add(specialPass.ToString());


        
        _passwordBase = new NumbersPassword(symbolsPass, specialPass);
    }

    [Test]
    [Repeat(10)]
    public void CheckSymblsTest()
    {
        string password = _passwordBase.Generate((uint)_ranges.Count);
        foreach (string rang in _ranges)
        {
            bool presence = false;
            foreach (char ch in password)
            {
                if (rang.Contains(ch))
                {
                    presence = true;
                    break;
                }
            }
            Assert.That(presence, password);
        }
        Assert.Pass();
    }
}
